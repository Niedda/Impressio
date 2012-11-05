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

    public override int Identity { get; set; }

    public override string IdentityColumn { get { return "OrderId"; } }

    public override string Table { get { return "Order"; } }

    public int FkOrderCompany { get; set; }

    public string OrderName { get; set; }

    public State State
    {
      get
      {
        _state.Identity = FkOrderState;
        return (State)_state.LoadSingleObject();
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
          return (Client)new Client { Identity = FkOrderClient }.LoadSingleObject();
        }
        return null;
      }
    }

    public Address Address
    {
      get
      {
        if (FkOrderAddress != 0)
        {
          return (Address)new Address { Identity = FkOrderAddress }.LoadSingleObject();
        }
        return null;
      }
    }

    public Company Company
    {
      get
      {
        return (Company)new Company { Identity = FkOrderClient }.LoadSingleObject();
      }
    }

    public override List<Order> Objects
    {
      get { return _orders; }
    }

    public List<Client> AvaibleClients
    {
      get
      {
        return _client ?? (_client = new Client().LoadObjectList(Client.Columns.FkClientCompany, FkOrderCompany));
      }
    }

    public List<Address> AvaibleAddress
    {
      get
      {
        return _address ?? (_address = new Address().LoadObjectList(Address.Columns.FkAddressCompany, FkOrderCompany));
      }
    }

    public List<Data> Datas
    {
      get
      {
        return _data ?? (_data = new Data().LoadObjectList(Data.Columns.FkDataOrder, Identity));
      }
    }

    public List<Finish> Finishes
    {
      get
      {
        return _finish ?? (_finish = new Finish().LoadObjectList(Finish.Columns.FkFinishOrder, Identity));
      }
    }

    public List<Print> Prints
    {
      get
      {
        return _print ?? (_print = new Print().LoadObjectList(Print.Columns.FkPrintOrder, Identity));
      }
    }

    public List<Offset> Offsets
    {
      get
      {
        return _offsets ?? (_offsets = (new Offset().LoadObjectList(Offset.Columns.FkOffsetOrder, Identity)));
      }
    }

    public List<Description> Descriptions
    {
      get
      {
        return _description ?? (_description = new Description().LoadObjectList(Description.Columns.FkDescriptionOrder, Identity));
      }
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
      IsPredefined = (bool)Database.Reader["IsPredefined"];
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
                         orderBindingSource = { DataSource = this }
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
                         orderBindingSourcew = { DataSource = this }
                       };
        report.ShowPreview();
      }
    }

    private string _dateCreated;

    private string _userCreated;

    private readonly Company _company = new Company();

    private List<Address> _address;

    private List<Client> _client;

    private List<Data> _data;

    private List<Description> _description;

    private List<Finish> _finish;

    private List<Offset> _offsets;

    private List<Print> _print;

    private readonly State _state = new State();

    private readonly List<Order> _orders = new List<Order>();
  }

  public class State : DatabaseObjectBase<State>
  {
    #region Columns enum

    public enum Columns
    {
      StateName,
    }

    #endregion

    public override int Identity { get; set; }

    public override string IdentityColumn { get { return "StateId"; } }

    public override string Table { get { return "State"; } }

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

    private readonly List<State> _states = new List<State>();
  }
}