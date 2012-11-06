using System;
using System.Collections.Generic;
using System.Linq;
using Impressio.Models.Tools;
using Subvento.DatabaseObject;

namespace Impressio.Models
{
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
        return Identity != 0 ? (_deliveryPosition ?? (_deliveryPosition = new DeliveryPosition().LoadObjectList(DeliveryPosition.Columns.FkDeliveryPositionDelivery, Identity))) : null;
      }
    }

    public override void SetObject()
    {
      Identity = Database.Reader[IdentityColumn].GetInt();
      FkDeliveryCompany = Database.Reader[Columns.FkDeliveryCompany.ToString()].GetInt();
      FkDeliveryAddress = Database.Reader[Columns.FkDeliveryAddress.ToString()].GetInt();
      FkDeliveryClient = Database.Reader[Columns.FkDeliveryClient.ToString()].GetInt();
      FkDeliveryOrder = Database.Reader[Columns.FkDeliveryOrder.ToString()].GetInt();
      DeliveryDate = Convert.ToDateTime(Database.Reader[Columns.DeliveryDate.ToString()]);
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
      Identity = Database.Reader[IdentityColumn].GetInt();
      Quantity = Database.Reader[Columns.Quantity.ToString()].GetInt();
      Position = Database.Reader[Columns.DeliveryPosition.ToString()] as string;
      FkDeliveryPositionDelivery = Database.Reader[Columns.FkDeliveryPositionDelivery.ToString()].GetInt();
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