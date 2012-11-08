using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Impressio.Models.Tools;
using Impressio.Properties;
using Impressio.Reports;
using Subvento.DatabaseObject;

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
        return (Company)new Company { Identity = FkOrderCompany }.LoadSingleObject();
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
      Identity = Database.Reader[IdentityColumn].GetInt();
      _dateCreated = Database.Reader[Columns.DateCreated.ToString()] as string;
      DateModified = Database.Reader[Columns.DateModified.ToString()] as string;
      _userCreated = Database.Reader[Columns.UserCreated.ToString()] as string;
      UserModified = Database.Reader[Columns.UserModified.ToString()] as string;
      OrderName = Database.Reader[Columns.OrderName.ToString()] as string;
      FkOrderCompany = Database.Reader[Columns.FkOrderCompany.ToString()].GetInt();
      FkOrderState = Database.Reader[Columns.FkOrderState.ToString()].GetInt();
      FkOrderAddress = Database.Reader[Columns.FkOrderAddress.ToString()].GetInt();
      FkOrderClient = Database.Reader[Columns.FkOrderClient.ToString()].GetInt();
      IsPredefined = (bool)Database.Reader[Columns.IsPredefined.ToString()];
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
      _data = null;
      _finish = null;
      _offsets = null;
      _print = null;

      if (Identity != 0)
      {
        var report = new OrderReport
                       {
                         orderBindingSource = { DataSource = this }
                       };

        if (File.Exists(Settings.Default.logoImage))
        {
          report.logoBox.ImageUrl = Settings.Default.logoImage;
        }

        report.ShowRibbonPreview();
      }
    }

    public void LoadOrderOffer()
    {
      _description = null;

      if (Identity != 0)
      {
        var report = new OfferReport
                       {
                         orderBindingSourcew = { DataSource = this }
                       };

        if(File.Exists(Settings.Default.logoImage))
        {
          report.logoBox.ImageUrl = Settings.Default.logoImage;
        }

        report.ShowRibbonPreview();
      }
    }

    private string _dateCreated;

    private string _userCreated;

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
      Identity = Database.Reader[IdentityColumn].GetInt();
      StateName = Database.Reader[Columns.StateName.ToString()] as string;
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