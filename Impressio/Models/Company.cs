using System;
using System.Collections.Generic;
using Impressio.Models.Tools;
using Subvento.DatabaseObject;

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
      Identity = Database.DatabaseCommand.Reader["CompanyId"].GetInt();
      CompanyName = Database.DatabaseCommand.Reader["CompanyName"] as string;
      Addition = Database.DatabaseCommand.Reader["Addition"] as string;
      Remark = Database.DatabaseCommand.Reader["Remark"] as string;
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
      try
      {
        var query = new Query(Order.Columns.FkOrderCompany, new DatabaseOperator(DatabaseOperator.Operator.Equal), Identity);
        var queryBuilder = new QueryBuilder("Order", query);
        Database.DatabaseCommand.Reader = queryBuilder.GetQuery().ExecuteReader();
        return Database.DatabaseCommand.Reader.HasRows;
      }
      catch
      {
        return true;
      }
      finally
      {
        Database.DatabaseCommand.CloseReader();
      }
    }
    
    private List<Address> _address;

    private List<Client> _client;

    private readonly List<Company> _companies = new List<Company>();
  }
}