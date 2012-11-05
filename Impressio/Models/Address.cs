using System;
using System.Collections.Generic;
using Impressio.Models.Database.DatabaseObject;
using Impressio.Models.Tools;

namespace Impressio.Models
{
  public class Address : DatabaseObjectBase<Address>
  {
    #region Columns enum

    public enum Columns
    {
      AddressId,
      FkAddressCompany,
      Street,
      StreetNumber,
      ZipCode,
      City,
      Addition,
    }

    #endregion

    private readonly List<Address> _addresses = new List<Address>();
    public override int Identity { get; set; }

    public override string IdentityColumn
    {
      get { return "AddressId"; }
    }

    public override string Table
    {
      get { return "Address"; }
    }

    public int FkAddressCompany { get; set; }

    public string Street { get; set; }

    public string StreetNumber { get; set; }

    public string City { get; set; }

    public string ZipCode { get; set; }

    public string Addition { get; set; }

    public string FullAddress
    {
      get { return string.Format("{0} {1}  {2} {3}", Street, StreetNumber, ZipCode, City); }
    }

    public override List<Address> Objects
    {
      get { return _addresses; }
    }

    public override void SetObject()
    {
      FkAddressCompany = Database.Reader["FkAddressCompany"].GetInt();
      Identity = Database.Reader["AddressId"].GetInt();
      Street = Database.Reader["Street"] as string;
      StreetNumber = Database.Reader["StreetNumber"] as string;
      ZipCode = Database.Reader["ZipCode"] as string;
      City = Database.Reader["City"] as string;
      Addition = Database.Reader["Addition"] as string;
    }

    public override Dictionary<Enum, object> GetObject()
    {
      return new Dictionary<Enum, object>
               {
                 {Columns.FkAddressCompany, FkAddressCompany},
                 {Columns.City, City},
                 {Columns.Street, Street},
                 {Columns.StreetNumber, StreetNumber.SetStringDbNull()},
                 {Columns.ZipCode, ZipCode.SetStringDbNull()},
                 {Columns.Addition, Addition.SetStringDbNull()},
               };
    }

    public override void SetObjectList()
    {
      var address = new Address();
      address.SetObject();
      Objects.Add(address);
    }

    public override void ClearObjectList()
    {
      _addresses.Clear();
    }
  }
}