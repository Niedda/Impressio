using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using DevExpress.XtraReports.UserDesigner;
using Impressio.Models.Tools;
using Impressio.Properties;
using Impressio.Reports;
using Subvento.DatabaseObject;

namespace Impressio.Models
{
  /// <summary>
  /// Delivery class for creating and editing deliveries
  /// </summary>
  public class Delivery : DatabaseObjectBase<Delivery>
  {
    #region Columns enum

    public enum Columns
    {
      FkDeliveryOrder,
      FkDeliveryAddress,
      FkDeliveryClient,
      DeliveryDate,
      FkDeliveryCompany,
    }

    #endregion

    #region Reports

    /// <summary>
    /// Load a preview of the delivery
    /// </summary>
    public void LoadDeliveryReport()
    {
      _deliveryPosition = null;

      var report = new DeliveryReport { deliveryBindingSource = { DataSource = this } };

      if (File.Exists(Settings.Default.logoImage))
      {
        report.logoBox.ImageUrl = Settings.Default.logoImage;
      }

      report.ShowRibbonPreview();
    }

    /// <summary>
    /// Load the designer for the delivery
    /// </summary>
    public static void LoadDeliveryDesigner()
    {
      var form = new XRDesignRibbonForm();
      var report = new DeliveryReport();

      var controler = form.DesignMdiController;
      controler.DesignPanelLoaded += DeliveryDesignerLoad;
      report.LoadLayout("Reports\\deliveryReport.repx");
      controler.OpenReport(report);
      form.ShowDialog();
      controler.ActiveDesignPanel.CloseReport();
    }

    public static void DeliveryDesignerLoad(object sender, DesignerLoadedEventArgs e)
    {
      var panel = (XRDesignPanel)sender;
      panel.AddCommandHandler(new DeliverySaveCommand(panel));
    }

    public class DeliverySaveCommand : ICommandHandler
    {
      public DeliverySaveCommand(XRDesignPanel panel)
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
        _panel.Report.SaveLayout("Reports\\deliveryReport.repx");
        _panel.ReportState = ReportState.Saved;
      }

      private readonly XRDesignPanel _panel;
    }

    #endregion

    public override int Identity { get; set; }

    public override string IdentityColumn { get { return "DeliveryId"; } }

    public override string Table { get { return "Delivery"; } }

    public int FkDeliveryCompany { get; set; }

    public int FkDeliveryOrder { get; set; }

    public int FkDeliveryAddress { get; set; }

    public int FkDeliveryClient { get; set; }

    public DateTime DeliveryDate { get; set; }

    public Order Order
    {
      get
      {
        if (FkDeliveryOrder != 0)
        {
          return _order ?? (_order = (Order)new Order { Identity = FkDeliveryOrder }.LoadSingleObject());
        }
        return null;
      }
    }

    public Company Company
    {
      get
      {
        if (FkDeliveryCompany != 0)
        {
          return _company ?? (_company = (Company)new Company { Identity = FkDeliveryCompany }.LoadSingleObject());
        }
        return null;
      }
    }

    public Client Client
    {
      get
      {
        if (FkDeliveryClient != 0)
        {
          return _client ?? (_client = (Client)new Client { Identity = FkDeliveryClient }.LoadSingleObject());
        }
        return null;
      }
    }

    public Address Address
    {
      get
      {
        if (FkDeliveryAddress != 0)
        {
          return _address ?? (_address = (Address)new Address { Identity = FkDeliveryAddress }.LoadSingleObject());
        }
        return null;
      }
    }

    public override List<Delivery> Objects { get { return _deliveries; } }

    public List<Client> AvaibleClients
    {
      get
      {
        if (FkDeliveryCompany != 0)
        {
          return _clients ?? (_clients = new Client().LoadObjectList(Client.Columns.FkClientCompany, FkDeliveryCompany));
        }
        return null;
      }
    }

    public List<Address> AvaibleAddresses
    {
      get
      {
        if (FkDeliveryCompany != 0)
        {
          return _addresses ?? (_addresses = new Address().LoadObjectList(Address.Columns.FkAddressCompany, FkDeliveryCompany));
        }
        return null;
      }
    }

    public List<DeliveryPosition> DeliveryPositions
    {
      get
      {
        return Identity != 0 ? (_deliveryPosition ?? (_deliveryPosition = new DeliveryPosition().LoadObjectList(DeliveryPosition.Columns.FkDeliveryPositionDelivery, Identity))) : new List<DeliveryPosition>();
      }
    }

    public override void SetObject()
    {
      Identity = Database.DatabaseCommand.Reader[IdentityColumn].GetInt();
      FkDeliveryCompany = Database.DatabaseCommand.Reader[Columns.FkDeliveryCompany.ToString()].GetInt();
      FkDeliveryAddress = Database.DatabaseCommand.Reader[Columns.FkDeliveryAddress.ToString()].GetInt();
      FkDeliveryClient = Database.DatabaseCommand.Reader[Columns.FkDeliveryClient.ToString()].GetInt();
      FkDeliveryOrder = Database.DatabaseCommand.Reader[Columns.FkDeliveryOrder.ToString()].GetInt();
      DeliveryDate = Convert.ToDateTime(Database.DatabaseCommand.Reader[Columns.DeliveryDate.ToString()]);
    }
    
    public override Dictionary<Enum, object> GetObject()
    {
      return new Dictionary<Enum, object>
               {
                 {Columns.FkDeliveryAddress, FkDeliveryAddress.SetIntDbNull()},
                 {Columns.FkDeliveryClient, FkDeliveryClient.SetIntDbNull()},
                 {Columns.FkDeliveryOrder, FkDeliveryOrder},
                 {Columns.FkDeliveryCompany, FkDeliveryCompany},
                 {Columns.DeliveryDate, DeliveryDate},
               };
    }

    public override void ClearObjectList()
    {
      _deliveries.Clear();
    }
    
    private Company _company;

    private Order _order;

    private Address _address;

    private Client _client;

    private List<DeliveryPosition> _deliveryPosition;

    private List<Address> _addresses;

    private List<Client> _clients;

    private readonly List<Delivery> _deliveries = new List<Delivery>();
  }

  /// <summary>
  /// Positions contained by a delivery
  /// </summary>
  public class DeliveryPosition : DatabaseObjectBase<DeliveryPosition>
  {
    #region Columns enum

    public enum Columns
    {
      Quantity,
      FkDeliveryPositionDelivery,
      DeliveryPosition,
    }

    #endregion

    public override int Identity { get; set; }

    public override string IdentityColumn
    {
      get { return "DeliveryPositionId"; }
    }

    public override string Table { get { return "DeliveryPosition"; } }

    public int FkDeliveryPositionDelivery { get; set; }

    public string Position { get; set; }

    public int Quantity { get; set; }

    public override List<DeliveryPosition> Objects
    {
      get { return _deliveryPositions; }
    }

    public override void SetObject()
    {
      Identity = Database.DatabaseCommand.Reader[IdentityColumn].GetInt();
      Quantity = Database.DatabaseCommand.Reader[Columns.Quantity.ToString()].GetInt();
      Position = Database.DatabaseCommand.Reader[Columns.DeliveryPosition.ToString()] as string;
      FkDeliveryPositionDelivery = Database.DatabaseCommand.Reader[Columns.FkDeliveryPositionDelivery.ToString()].GetInt();
    }
    
    public override Dictionary<Enum, object> GetObject()
    {
      return new Dictionary<Enum, object>
               {
                 {Columns.Quantity, Quantity.ToString()},
                 {Columns.FkDeliveryPositionDelivery, FkDeliveryPositionDelivery.ToString()},
                 {Columns.DeliveryPosition, Position},
               };
    }

    public List<string> LoadDescriptions(int id)
    {
      List<Description> descriptions = _description.LoadObjectList(Description.Columns.FkDescriptionOrder, id);
      return (from des in descriptions select des.JobTitle).Distinct().ToList();
    }

    private readonly List<DeliveryPosition> _deliveryPositions = new List<DeliveryPosition>();

    private readonly Description _description = new Description();
  }
}