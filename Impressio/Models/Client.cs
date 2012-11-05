using System;
using System.Collections.Generic;
using Impressio.Models.Database.DatabaseObject;
using Impressio.Models.Tools;

namespace Impressio.Models
{
  public class Client : DatabaseObjectBase<Client>
  {
    #region Columns enum

    public enum Columns
    {
      FkClientCompany,
      FirstName,
      LastName,
      Phone,
      Mobile,
      Mail,
      Remark,
      FkClientGender,
    }

    #endregion

    public override int Identity { get; set; }

    public override string IdentityColumn { get { return "ClientId"; } }

    public override string Table { get { return "Client"; } }

    public int FkClientCompany { get; set; }

    public int FkClientGender { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Phone { get; set; }

    public string Mobile { get; set; }

    public string Mail { get; set; }

    public string Remark { get; set; }

    public string FullName
    {
      get { return string.Format("{0} {1} {2}", Gender.Name, FirstName, LastName); }
    }

    public Gender Gender
    {
      get
      {
        if (FkClientGender != 0)
        {
          return _gender ?? (_gender = (Gender)( new Gender {Identity = FkClientGender}.LoadSingleObject()));
        }
        return null;
      }
    }

    public override List<Client> Objects { get { return _clients; } }
    
    public override void SetObject()
    {
      Identity = Database.Reader["ClientId"].GetInt();
      FirstName = Database.Reader["FirstName"] as string;
      LastName = Database.Reader["LastName"] as string;
      Mobile = Database.Reader["Mobile"] as string;
      Phone = Database.Reader["Phone"] as string;
      Mail = Database.Reader["Mail"] as string;
      Remark = Database.Reader["Remark"] as string;
      FkClientCompany = Database.Reader["FkClientCompany"].GetInt();
      FkClientGender = Database.Reader["FkClientGender"].GetInt();
    }

    public override void SetObjectList()
    {
      var client = new Client();
      client.SetObject();
      _clients.Add(client);
    }

    public override void ClearObjectList()
    {
      _clients.Clear();
    }

    public override Dictionary<Enum, object> GetObject()
    {
      return new Dictionary<Enum, object>
               {
                 {Columns.LastName, LastName},
                 {Columns.FirstName, FirstName.SetStringDbNull()},
                 {Columns.Mail, Mail.SetStringDbNull()},
                 {Columns.Remark, Remark.SetStringDbNull()},
                 {Columns.Phone, Phone.SetStringDbNull()},
                 {Columns.Mobile, Mobile.SetStringDbNull()},
                 {Columns.FkClientCompany, FkClientCompany},
                 {Columns.FkClientGender, FkClientGender}
               };
    }

    private Gender _gender;

    private readonly List<Client> _clients = new List<Client>();
  }
}