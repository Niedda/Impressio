using System;
using System.Collections.Generic;
using Impressio.Models.Database.DatabaseObject;
using Impressio.Models.Tools;

namespace Impressio.Models
{
  public class Company : DatabaseObjectBase<Company>
  {
    #region Columns enum

    public enum Columns
    {
      CompanyName,
      Addition,
      Remark,
    }

    #endregion

    public override int Identity { get; set; }

    public override string IdentityColumn { get { return "CompanyId"; } }

    public override string Table { get { return "Company"; } }

    public string CompanyName { get; set; }

    public string Addition { get; set; }

    public string Remark { get; set; }

    public List<Client> Clients
    {
      get
      {
        return _client ?? (_client = new Client().LoadObjectList(Client.Columns.FkClientCompany, Identity));
      }
    }

    public List<Address> Addresses
    {
      get
      {
        return _address ?? (_address = new Address().LoadObjectList(Address.Columns.FkAddressCompany, Identity));
      }
    }

    public override List<Company> Objects { get { return _companies; } }

    public override void SetObject()
    {
      Identity = Database.Reader["CompanyId"].GetInt();
      CompanyName = Database.Reader["CompanyName"] as string;
      Addition = Database.Reader["Addition"] as string;
      Remark = Database.Reader["Remark"] as string;
    }

    public override void SetObjectList()
    {
      var company = new Company();
      company.SetObject();
      _companies.Add(company);
    }

    public override Dictionary<Enum, object> GetObject()
    {
      return new Dictionary<Enum, object>
               {
                 {Columns.CompanyName, CompanyName},
                 {Columns.Addition, Addition.SetStringDbNull()},
                 {Columns.Remark, Remark.SetStringDbNull()},
               };
    }

    public bool HasOrders()
    {
      throw new NotImplementedException();
    }

    private List<Address> _address;

    private List<Client> _client;

    private readonly List<Company> _companies = new List<Company>();
  }
}