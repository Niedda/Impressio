using System;
using System.Collections.Generic;
using System.IO;
using DevExpress.XtraReports.UserDesigner;
using Impressio.Models.Tools;
using Impressio.Properties;
using Impressio.Reports;
using Subvento.DatabaseObject;

namespace Impressio.Models
{
  /// <summary>
  /// Order class containing descriptions, position and deliveries
  /// </summary>
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

    #region Reports

    //previews of the documents
    public void LoadOrderReport()
    {
      _datas = null;
      _finishs = null;
      _offsets = null;
      _prints = null;

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

        report.LoadLayout("Reports\\orderReport.repx");
        report.ShowRibbonPreview();
      }
    }

    public void LoadOfferReport()
    {
      _description = null;

      if (Identity != 0)
      {
        var report = new OfferReport
        {
          orderBindingSourcew = { DataSource = this }
        };

        if (File.Exists(Settings.Default.logoImage))
        {
          
          report.logoBox.ImageUrl = Settings.Default.logoImage;
        }

        report.LoadLayout("Reports\\offerReport.repx");
        report.ShowRibbonPreview();
      }
    }

    //designer for the documents
    public static void LoadOfferDesigner()
    {
      var form = new XRDesignRibbonForm();
      var report = new OfferReport();

      var controler = form.DesignMdiController;
      controler.DesignPanelLoaded += OfferDesignerLoad;
      report.LoadLayout("Reports\\offerReport.repx");
      controler.OpenReport(report);
      form.ShowDialog();
      controler.ActiveDesignPanel.CloseReport();
    }

    public static void OfferDesignerLoad(object sender, DesignerLoadedEventArgs e)
    {
      var panel = (XRDesignPanel)sender;
      panel.AddCommandHandler(new OfferSaveCommand(panel));
    }

    public class OfferSaveCommand : ICommandHandler
    {
      public OfferSaveCommand(XRDesignPanel panel)
      {
        _panel = panel;
      }

      public virtual void HandleCommand(ReportCommand command, object[] args, ref bool handled)
      {
        if (!CanHandleCommand(command)) return;
        Save();
        handled = true;
      }

      public virtual bool CanHandleCommand(ReportCommand command)
      {
        return command == ReportCommand.SaveFile || command == ReportCommand.SaveFileAs || command == ReportCommand.Closing;
      }

      private void Save()
      {
        _panel.Report.SaveLayout("Reports\\offerReport.repx");
        _panel.ReportState = ReportState.Saved;
      }

      private readonly XRDesignPanel _panel;
    }

    public static void LoadOrderDesigner()
    {
      var form = new XRDesignRibbonForm();
      var report = new OrderReport();

      var controler = form.DesignMdiController;
      controler.DesignPanelLoaded += OrderDesignerLoad;
      report.LoadLayout("Reports\\orderReport.repx");
      controler.OpenReport(report);
      form.ShowDialog();
      controler.ActiveDesignPanel.CloseReport();
    }

    public static void OrderDesignerLoad(object sender, DesignerLoadedEventArgs e)
    {
      var panel = (XRDesignPanel)sender;
      panel.AddCommandHandler(new OrderSaveCommand(panel));
    }

    public class OrderSaveCommand : ICommandHandler
    {
      public OrderSaveCommand(XRDesignPanel panel)
      {
        _panel = panel;
      }

      public virtual void HandleCommand(ReportCommand command, object[] args, ref bool handled)
      {
        if (!CanHandleCommand(command)) return;
        Save();
        handled = true;
      }

      public virtual bool CanHandleCommand(ReportCommand command)
      {
        return command == ReportCommand.SaveFile || command == ReportCommand.SaveFileAs || command == ReportCommand.Closing;
      }

      private void Save()
      {
        _panel.Report.SaveLayout("Reports\\orderReport.repx");
        _panel.ReportState = ReportState.Saved;
      }

      private readonly XRDesignPanel _panel;
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

    public string FolderPath { get; set; }

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
        if (_client == null || _client.Count == 0)
        {
          return (_client = new Client().LoadObjectList(Client.Columns.FkClientCompany, FkOrderCompany));
        }
        return _client;
      }
    }

    public List<Address> AvaibleAddress
    {
      get
      {
        if (_address == null || _address.Count == 0)
        {
          return (_address = new Address().LoadObjectList(Address.Columns.FkAddressCompany, FkOrderCompany));
        }
        return _address;
      }
    }

    public List<Data> Datas
    {
      get
      {
        return _datas ?? (_datas = new Data().LoadObjectList(Data.Columns.FkDataOrder, Identity));
      }
    }

    public List<Finish> Finishes
    {
      get
      {
        return _finishs ?? (_finishs = new Finish().LoadObjectList(Finish.Columns.FkFinishOrder, Identity));
      }
    }

    public List<Print> Prints
    {
      get
      {
        return _prints ?? (_prints = new Print().LoadObjectList(Print.Columns.FkPrintOrder, Identity));
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

    public List<Delivery> Deliveries
    {
      get { return _deliveries ?? (_deliveries = new Delivery().LoadObjectList(Delivery.Columns.FkDeliveryOrder, Identity)); }
    }

    public override void SetObject()
    {
        Identity = Database.DatabaseCommand.Reader[IdentityColumn].GetInt();
        _dateCreated = Database.DatabaseCommand.Reader[Columns.DateCreated.ToString()] as string;
        DateModified = Database.DatabaseCommand.Reader[Columns.DateModified.ToString()] as string;
        _userCreated = Database.DatabaseCommand.Reader[Columns.UserCreated.ToString()] as string;
        UserModified = Database.DatabaseCommand.Reader[Columns.UserModified.ToString()] as string;
        OrderName = Database.DatabaseCommand.Reader[Columns.OrderName.ToString()] as string;
        FkOrderCompany = Database.DatabaseCommand.Reader[Columns.FkOrderCompany.ToString()].GetInt();
        FkOrderState = Database.DatabaseCommand.Reader[Columns.FkOrderState.ToString()].GetInt();
        FkOrderAddress = Database.DatabaseCommand.Reader[Columns.FkOrderAddress.ToString()].GetInt();
        FkOrderClient = Database.DatabaseCommand.Reader[Columns.FkOrderClient.ToString()].GetInt();
        IsPredefined = (bool)Database.DatabaseCommand.Reader[Columns.IsPredefined.ToString()];
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

    public int CopyOrder()
    {
      var descriptions = Descriptions;
      var prints = Prints;
      var offsets = Offsets;
      var datas = Datas;
      var finishes = Finishes;
      var deliveries = Deliveries;

      Identity = 0;
      _dateCreated = "";
      _userCreated = "";
      OrderName += " [Kopie]";

      Identity = this.SaveObject();

      foreach (var description in descriptions)
      {
        var descriptionPositions = description.Details;
        description.Identity = 0;
        description.FkDescriptionOrder = Identity;
        var descriptionId = description.SaveObject();

        foreach (var detail in descriptionPositions)
        {
          detail.Identity = 0;
          detail.FkDetailDescription = descriptionId;
          detail.SaveObject();
        }
      }

      foreach (var data in datas)
      {
        var dataPositions = data.DataPositions;
        data.Identity = 0;
        data.FkOrder = Identity;
        var dataId = data.SaveObject();

        foreach (var dataPosition in dataPositions)
        {
          dataPosition.FkDataDataPosition = dataId;
          dataPosition.SaveObject();
        }
      }

      foreach (var print in prints)
      {
        print.Identity = 0;
        print.FkOrder = Identity;
        print.SaveObject();
      }

      foreach(var offset in offsets)
      {
        offset.Identity = 0;
        offset.FkOrder = Identity;
        offset.SaveObject();
      }

      foreach (var finish in finishes)
      {
        var finishPositions = finish.FinishPositions;
        finish.Identity = 0;
        finish.FkOrder = Identity;
        var finishId = finish.SaveObject();

        foreach (var finishPosition in finishPositions)
        {
          finishPosition.Identity = 0;
          finishPosition.FkFinishFinishPosition = finishId;
          finishPosition.SaveObject();
        }
      }
      
      foreach (var delivery in deliveries)
      {
        var deliveryPositions = delivery.DeliveryPositions;
        delivery.Identity = 0;
        delivery.FkDeliveryOrder = Identity;
        var deliveryId = delivery.SaveObject();

        foreach (var deliveryPosition in deliveryPositions)
        {
          deliveryPosition.Identity = 0;
          deliveryPosition.FkDeliveryPositionDelivery = deliveryId;
          deliveryPosition.SaveObject();
        }
      }
      return Identity;
    }

    private string _dateCreated;

    private string _userCreated;

    private List<Address> _address;

    private List<Client> _client;

    private List<Data> _datas;

    private List<Description> _description;

    private List<Finish> _finishs;

    private List<Offset> _offsets;

    private List<Print> _prints;

    private List<Delivery> _deliveries; 

    private readonly State _state = new State();

    private readonly List<Order> _orders = new List<Order>();
  }
}