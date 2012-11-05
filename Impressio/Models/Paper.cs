using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using Impressio.Models.Database.DatabaseObject;
using Impressio.Models.Tools;

namespace Impressio.Models
{
  public class Paper : DatabaseObjectBase<Paper>
  {
    #region Columns enum

    public enum Columns
    {
      PaperName,
      ItemNumber,
      Vendor,
      Price1,
      Price2,
      Price3,
      Price4,
      Amount1,
      Amount2,
      Amount3,
      Direction,
      SizeL,
      SizeB,
      Weight,
    }

    #endregion
    
    public override int Identity { get; set; }

    public override string IdentityColumn { get { return "PaperId"; } }

    public override string Table { get { return "Paper"; } }

    public string Name { get; set; }

    public int ItemNumber { get; set; }

    public string Vendor { get; set; }

    public int Price1 { get; set; }

    public int Price2 { get; set; }

    public int Price3 { get; set; }

    public int Price4 { get; set; }

    public int Amount1 { get; set; }

    public int Amount2 { get; set; }

    public int Amount3 { get; set; }

    public int Direction { get; set; }

    public string DirectionString
    {
      get
      {
        switch (Direction)
        {
          case 1:
            return "SB";
          case 2:
            return "BB";
          default:
            return "ND";
        }
      }
      set
      {
        switch (value)
        {
          case "SB":
            Direction = 1;
            return;
          case "BB":
            Direction = 2;
            return;
          default:
            return;
        }
      }
    }

    public int Weight { get; set; }

    public int SizeL { get; set; }

    public int SizeB { get; set; }

    public string Size
    {
      get { return SizeB + " x " + SizeL; }
    }

    public override List<Paper> Objects
    {
      get { return _papers; }
    }

    public override void SetObject()
    {
      Identity = Database.Reader["PaperId"].GetInt();
      Price1 = Database.Reader["Price1"].GetInt();
      Price2 = Database.Reader["Price2"].GetInt();
      Price3 = Database.Reader["Price3"].GetInt();
      Price4 = Database.Reader["Price4"].GetInt();
      Amount1 = Database.Reader["Amount1"].GetInt();
      Amount2 = Database.Reader["Amount2"].GetInt();
      Amount3 = Database.Reader["Amount3"].GetInt();
      Direction = Database.Reader["Direction"].GetInt();
      ItemNumber = Database.Reader["ItemNumber"].GetInt();
      SizeB = Database.Reader["SizeB"].GetInt();
      SizeL = Database.Reader["SizeL"].GetInt();
      Name = Database.Reader["PaperName"] as string;
      Weight = Database.Reader["Weight"].GetInt();
    }

    public override void SetObjectList()
    {
      var paper = new Paper();
      paper.SetObject();
      _papers.Add(paper);
    }

    public override void ClearObjectList()
    {
      _papers.Clear();
    }

    public override Dictionary<Enum, object> GetObject()
    {
      return new Dictionary<Enum, object>
               {
                 {Columns.PaperName, Name},
                 {Columns.ItemNumber, ItemNumber.SetIntDbNull()},
                 {Columns.Vendor, Vendor.SetStringDbNull()},
                 {Columns.Price1, Price1},
                 {Columns.Price2, Price2.SetIntDbNull()},
                 {Columns.Price3, Price3.SetIntDbNull()},
                 {Columns.Price4, Price4.SetIntDbNull()},
                 {Columns.Amount1, Amount1.SetIntDbNull()},
                 {Columns.Amount2, Amount2.SetIntDbNull()},
                 {Columns.Amount3, Amount3.SetIntDbNull()},
                 {Columns.Direction, Direction.SetIntDbNull()},
                 {Columns.SizeL, SizeL.ToString()},
                 {Columns.SizeB, SizeB.ToString()},
                 {Columns.Weight, Weight.ToString()},
               };
    }

    public static bool LoadFromExcel(string filePath)
    {
      try
      {
        if (File.Exists(filePath) && filePath != null)
        {
          string extension = Path.GetExtension(filePath);
          var xlConn = new OleDbConnection();
          var paper = new Paper();
          paper.LoadObjectList();

          if (extension != null && extension.Equals(".xls"))
          {
            xlConn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + filePath +
                                      "; Extended Properties=Excel 8.0;";
          }
          else if (extension != null && extension.Equals(".xlsx"))
          {
            xlConn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + filePath +
                                      "; Extended Properties=\"Excel 12.0;\";";
          }
          else
          {
            return false;
          }

          xlConn.Open();

          var command = new OleDbCommand("SELECT * FROM [Papier$]", xlConn);
          OleDbDataReader reader = command.ExecuteReader();

          while (reader != null && reader.Read())
          {
            paper.Identity = 0;
            paper.Price1 = reader["Preis1"].GetInt();
            paper.Price2 = reader["Preis2"].GetInt();
            paper.Price3 = reader["Preis3"].GetInt();
            paper.Price4 = reader["Preis4"].GetInt();
            paper.Amount1 = reader["Menge1"].GetInt();
            paper.Amount2 = reader["Menge2"].GetInt();
            paper.Amount3 = reader["Menge3"].GetInt();
            paper.Direction = reader["Laufrichtung"].GetInt();
            paper.ItemNumber = reader["Artikelnummer"].GetInt();
            paper.SizeB = reader["Breite"].GetInt();
            paper.SizeL = reader["Länge"].GetInt();
            paper.Name = reader["Name"] as string;
            paper.Weight = reader["Grammatur"].GetInt();

            if (paper.ItemNumber != 0)
            {
              Paper exists =
                (from pap in paper.Objects where pap.ItemNumber == paper.ItemNumber select pap).FirstOrDefault();
              if (exists != null)
              {
                paper.Identity = exists.Identity;
              }
            }
            paper.SaveObject();
          }
          return true;
        }
        return false;
      }
      catch (Exception exception)
      {
        ServiceLocator.Instance.Logger.WriteToLog(exception.ToString());
        return false;
      }
    }
    
    private readonly List<Paper> _papers = new List<Paper>();
  }
}