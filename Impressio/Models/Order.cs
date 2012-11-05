using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Impressio.Models.Database.DatabaseObject;
using Impressio.Models.Tools;
using Impressio.Properties;
using Impressio.Reports;

namespace Impressio.Models
{
  public class Order : DatabaseObjectBase<Order>
  {
    #region Columns enum

    public enum Columns
    {
      FkOrderCompany,
      OrderName,
      FkOrderState,
      DateCreated,
      DateModified,
      UserCreated,
      UserModified,
      IsPredefined,
      FkOrderClient,
      FkOrderAddress,
    }

    #endregion

    private readonly Address _address = new Address();

    private readonly Client _client = new Client();
    private readonly Company _company = new Company();
    private readonly Data _data = new Data();
    private readonly Description _description = new Description();
    private readonly Finish _finish = new Finish();
    private readonly Offset _offset = new Offset();
    private readonly List<Order> _orders = new List<Order>();
    private readonly Print _print = new Print();
    private readonly State _state = new State();
    private string _dateCreated;

    private string _userCreated;

    public override int Identity { get; set; }

    public override string IdentityColumn
    {
      get { return "Order"; }
    }

    public override string Table
    {
      get { return "Order"; }
    }

    public int FkOrderCompany { get; set; }

    public string OrderName { get; set; }

    public State State
    {
      get
      {
        _state.Identity = FkOrderState;
        return (State) _state.LoadSingleObject();
      }
    }

    public int FkOrderState { get; set; }

    public string DateCreated
    {
      get
      {
        if (string.IsNullOrEmpty(_dateCreated))
        {
          return DateTime.Now.ToShortDateString();
        }
        return _dateCreated;
      }
    }

    public string UserCreated
    {
      get
      {
        if (string.IsNullOrEmpty(_userCreated))
        {
          return Settings.Default.User;
        }
        return _userCreated;
      }
    }

    public string DateModified { get; set; }

    public string UserModified { get; set; }

    public bool IsPredefined { get; set; }

    public int FkOrderClient { get; set; }

    public int FkOrderAddress { get; set; }

    public string FolderPath
    {
      get { return Settings.Default.folderPath + Identity; }
    }

    public Client Client
    {
      get
      {
        if (FkOrderClient != 0)
        {
          _client.Identity = FkOrderClient;
          return (Client) _client.LoadSingleObject();
        }
        return new Client();
      }
    }

    public Address Address
    {
      get
      {
        if (FkOrderAddress != 0)
        {
          _address.Identity = FkOrderAddress;
          return (Address) _address.LoadSingleObject();
        }
        return new Address();
      }
    }

    public Company Company
    {
      get
      {
        _company.Identity = FkOrderCompany;
        return (Company) _company.LoadSingleObject();
      }
    }

    public override List<Order> Objects
    {
      get { return _orders; }
    }

    public List<Client> AvaibleClients
    {
      get { return _client.LoadObjectList(Client.Columns.FkClientCompany, FkOrderCompany); }
    }

    public List<Address> AvaibleAddress
    {
      get { return _address.LoadObjectList(Address.Columns.FkAddressCompany, FkOrderCompany); }
    }

    public List<Data> Datas
    {
      get { return _data.LoadObjectList(Data.Columns.FkDataOrder, Identity); }
    }

    public List<Finish> Finishes
    {
      get { return _finish.LoadObjectList(Finish.Columns.FkFinishOrder, Identity); }
    }

    public List<Print> Prints
    {
      get { return _print.LoadObjectList(Print.Columns.FkPrintOrder, Identity); }
    }

    public List<Offset> Offsets
    {
      get { return _offset.LoadObjectList(Offset.Columns.FkOffsetOrder, Identity); }
    }

    public List<Description> Descriptions
    {
      get { return _description.LoadObjectList(Description.Columns.FkDescriptionOrder, Identity); }
    }

    public override void SetObject()
    {
      Identity = Database.Reader["OrderId"].GetInt();
      _dateCreated = Database.Reader["DateCreated"] as string;
      DateModified = Database.Reader["DateModified"] as string;
      _userCreated = Database.Reader["UserCreated"] as string;
      UserModified = Database.Reader["UserModified"] as string;
      OrderName = Database.Reader["OrderName"] as string;
      FkOrderCompany = Database.Reader["FkOrderCompany"].GetInt();
      FkOrderState = Database.Reader["FkOrderState"].GetInt();
      FkOrderAddress = Database.Reader["FkOrderAddress"].GetInt();
      FkOrderClient = Database.Reader["FkOrderClient"].GetInt();
      IsPredefined = (bool) Database.Reader["IsPredefined"];
    }

    public override void SetObjectList()
    {
      var order = new Order();
      order.SetObject();
      _orders.Add(order);
    }

    public override Dictionary<Enum, object> GetObject()
    {
      return new Dictionary<Enum, object>
               {
                 {Columns.FkOrderCompany, FkOrderCompany},
                 {Columns.OrderName, OrderName},
                 {Columns.FkOrderState, FkOrderState},
                 {Columns.DateCreated, DateCreated},
                 {Columns.DateModified, DateTime.Now.ToShortDateString()},
                 {Columns.UserCreated, UserCreated},
                 {Columns.IsPredefined, IsPredefined},
                 {Columns.UserModified, Settings.Default.User},
                 {Columns.FkOrderClient, FkOrderClient.SetIntDbNull()},
                 {Columns.FkOrderAddress, FkOrderAddress.SetIntDbNull()},
               };
    }

    public override void ClearObjectList()
    {
      _orders.Clear();
    }

    public void OpenFolder()
    {
      if (!Directory.Exists(FolderPath))
      {
        Directory.CreateDirectory(FolderPath);
      }
      Process.Start("explorer.exe", FolderPath);
    }

    public void LoadOrderReport()
    {
      if (Identity != 0)
      {
        var report = new OrderReport
                       {
                         orderBindingSource = {DataSource = this}
                       };
        report.ShowPreview();
      }
    }

    public void LoadOrderOffer()
    {
      if (Identity != 0)
      {
        var report = new OfferReport
                       {
                         orderBindingSourcew = {DataSource = this}
                       };
        report.ShowPreview();
      }
    }
  }

  public class State : DatabaseObjectBase<State>
  {
    #region Columns enum

    public enum Columns
    {
      StateName,
    }

    #endregion

    private readonly List<State> _states = new List<State>();

    public override int Identity { get; set; }

    public override string IdentityColumn
    {
      get { return "StateId"; }
    }

    public override string Table
    {
      get { return "State"; }
    }

    public string StateName { get; set; }

    public override List<State> Objects
    {
      get { return _states; }
    }

    public override void SetObject()
    {
      Identity = Database.Reader["StateId"].GetInt();
      StateName = Database.Reader["StateName"] as string;
    }

    public override void SetObjectList()
    {
      var state = new State();
      state.SetObject();
      _states.Add(state);
    }

    public override void ClearObjectList()
    {
      _states.Clear();
    }

    public override Dictionary<Enum, object> GetObject()
    {
      return new Dictionary<Enum, object>
               {
                 {Columns.StateName, StateName},
               };
    }
  }
}