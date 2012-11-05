using System;
using System.Collections.Generic;
using System.Linq;
using Impressio.Models.Database.DatabaseObject;
using Impressio.Models.Tools;

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

    private readonly Address _address = new Address();
    private readonly Client _client = new Client();
    private readonly Company _company = new Company();
    private readonly List<Delivery> _deliveries = new List<Delivery>();
    private readonly DeliveryPosition _deliveryPosition = new DeliveryPosition();
    private readonly Order _order = new Order();

    public override int Identity { get; set; }

    public override string IdentityColumn
    {
      get { return "DeliveryId"; }
    }

    public override string Table
    {
      get { return "Delivery"; }
    }

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
          _order.Identity = FkDeliveryOrder;
          return (Order) _order.LoadSingleObject();
        }
        return new Order();
      }
    }

    public Company Company
    {
      get
      {
        if (FkDeliveryCompany != 0)
        {
          _company.Identity = FkDeliveryCompany;
          return (Company) _company.LoadSingleObject();
        }
        return new Company();
      }
    }

    public Client Client
    {
      get
      {
        if (FkDeliveryClient != 0)
        {
          _client.Identity = FkDeliveryClient;
          return (Client) _client.LoadSingleObject();
        }
        return new Client();
      }
    }

    public Address Address
    {
      get
      {
        if (FkDeliveryAddress != 0)
        {
          _address.Identity = FkDeliveryAddress;
          return (Address) _address.LoadSingleObject();
        }
        return new Address();
      }
    }

    public override List<Delivery> Objects
    {
      get { return _deliveries; }
    }

    public List<Client> AvaibleClients
    {
      get
      {
        return FkDeliveryCompany != 0
                 ? _client.LoadObjectList(Client.Columns.FkClientCompany, FkDeliveryCompany)
                 : new List<Client>();
      }
    }

    public List<Address> AvaibleAddresses
    {
      get
      {
        return FkDeliveryCompany != 0
                 ? _address.LoadObjectList(Address.Columns.FkAddressCompany, FkDeliveryCompany)
                 : new List<Address>();
      }
    }

    public List<DeliveryPosition> DeliveryPositions
    {
      get
      {
        return Identity != 0
                 ? _deliveryPosition.LoadObjectList(DeliveryPosition.Columns.FkDeliveryPositionDelivery, Identity)
                 : new List<DeliveryPosition>();
      }
    }

    public override void SetObject()
    {
      Identity = Database.Reader[IdentityColumn].GetInt();
      FkDeliveryCompany = Database.Reader[Columns.FkDeliveryCompany.ToString()].GetInt();
      FkDeliveryAddress = Database.Reader["FkDeliveryAddress"].GetInt();
      FkDeliveryClient = Database.Reader["FkDeliveryClient"].GetInt();
      FkDeliveryOrder = Database.Reader["FkDeliveryOrder"].GetInt();
      DeliveryDate = Convert.ToDateTime(Database.Reader["DeliveryDate"]);
    }

    public override void SetObjectList()
    {
      var delivery = new Delivery();
      delivery.SetObject();
      _deliveries.Add(delivery);
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

    private readonly List<DeliveryPosition> _deliveryPositions = new List<DeliveryPosition>();

    private readonly Description _description = new Description();

    public override int Identity { get; set; }

    public override string IdentityColumn
    {
      get { return "DeliveryPositionId"; }
    }

    public override string Table
    {
      get { return "DeliveryPosition"; }
    }

    public int FkDeliveryPositionDelivery { get; set; }

    public string Position { get; set; }

    public int Quantity { get; set; }

    public override List<DeliveryPosition> Objects
    {
      get { return _deliveryPositions; }
    }

    public override void SetObject()
    {
      Identity = Database.Reader["DeliveryPositionId"].GetInt();
      Quantity = Database.Reader["Quantity"].GetInt();
      Position = Database.Reader["DeliveryPosition"] as string;
      FkDeliveryPositionDelivery = Database.Reader["FkDeliveryPositionDelivery"].GetInt();
    }

    public override void SetObjectList()
    {
      var deliveryPosition = new DeliveryPosition();
      deliveryPosition.SetObject();
      _deliveryPositions.Add(deliveryPosition);
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
  }
}