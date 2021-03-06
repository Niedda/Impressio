﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using DevExpress.XtraEditors;
using Impressio.Models.Tools;
using Impressio.Views;
using Subvento.DatabaseObject;

namespace Impressio.Models
{
  /// <summary>
  /// Paper class containing basic parameters for papers
  /// </summary>
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

    public int SizeW { get; set; }

    public int SizeH { get; set; }

    public string Size
    {
      get { return SizeH + " x " + SizeW; }
    }

    public override List<Paper> Objects
    {
      get { return _papers; }
    }

    public override void SetObject()
    {
      Identity = Database.DatabaseCommand.Reader[IdentityColumn].GetInt();
      Price1 = Database.DatabaseCommand.Reader[Columns.Price1.ToString()].GetInt();
      Price2 = Database.DatabaseCommand.Reader[Columns.Price2.ToString()].GetInt();
      Price3 = Database.DatabaseCommand.Reader[Columns.Price3.ToString()].GetInt();
      Price4 = Database.DatabaseCommand.Reader[Columns.Price4.ToString()].GetInt();
      Amount1 = Database.DatabaseCommand.Reader[Columns.Amount1.ToString()].GetInt();
      Amount2 = Database.DatabaseCommand.Reader[Columns.Amount2.ToString()].GetInt();
      Amount3 = Database.DatabaseCommand.Reader[Columns.Amount3.ToString()].GetInt();
      Direction = Database.DatabaseCommand.Reader[Columns.Direction.ToString()].GetInt();
      ItemNumber = Database.DatabaseCommand.Reader[Columns.ItemNumber.ToString()].GetInt();
      SizeH = Database.DatabaseCommand.Reader[Columns.SizeB.ToString()].GetInt();
      SizeW = Database.DatabaseCommand.Reader[Columns.SizeL.ToString()].GetInt();
      Name = Database.DatabaseCommand.Reader[Columns.PaperName.ToString()] as string;
      Weight = Database.DatabaseCommand.Reader[Columns.Weight.ToString()].GetInt();
      Vendor = Database.DatabaseCommand.Reader[Columns.Vendor.ToString()] as string;
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
                 {Columns.SizeL, SizeW.ToString()},
                 {Columns.SizeB, SizeH.ToString()},
                 {Columns.Weight, Weight.ToString()},
               };
    }

    /// <summary>
    /// Load papers from excel files a predefined excel included in the application folder
    /// </summary>
    /// <param name="filePath">Path to the file</param>
    /// <returns>true if succsessful</returns>
    public static bool LoadFromExcel(string filePath)
    {
      try
      {
        if (File.Exists(filePath) && filePath != null)
        {
          string extension = Path.GetExtension(filePath);
          var xlConn = new OleDbConnection();

          if (extension != null && extension.Equals(".xls"))
          {
            xlConn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + filePath +
                                      "; Extended Properties='Excel 8.0;HDR=Yes;IMEX=1'";
          }
          else if (extension != null && extension.Equals(".xlsx"))
          {
            xlConn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + filePath + @"; Extended Properties='Excel 12.0;HDR=Yes;IMEX=1'";
          }
          else
          {
            return false;
          }
          xlConn.Open();

          var schema = xlConn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
          var listSheet = (from DataRow drSheet in schema.Rows where drSheet["TABLE_NAME"].ToString().Contains("$") select drSheet["TABLE_NAME"].ToString()).ToList();
          new ExcelImportView
                         {
                           ExcelSheets = listSheet,
                           Connection = xlConn,
                         }.Show();
          return true;


          var command = new OleDbCommand("SELECT * FROM [Papier$]", xlConn);
          var reader = command.ExecuteReader();

          var paper = new Paper();
          paper.LoadObjectList();

          while (reader != null && reader.Read())
          {
            paper.Identity = 0;
            paper.Price1 = Convert.ToInt32(reader["Preis1"]);
            paper.Price2 = Convert.ToInt32(reader["Preis2"]);
            paper.Price3 = Convert.ToInt32(reader["Preis3"]);
            paper.Price4 = Convert.ToInt32(reader["Preis4"]);
            paper.Amount1 = reader["Menge1"].GetInt();
            paper.Amount2 = reader["Menge2"].GetInt();
            paper.Amount3 = reader["Menge3"].GetInt();
            paper.Direction = reader["Laufrichtung"].GetInt();
            paper.ItemNumber = reader["Artikelnummer"].GetInt();
            paper.SizeH = reader["Breite"].GetInt();
            paper.SizeW = reader["Länge"].GetInt();
            paper.Name = reader["Name"] as string;
            paper.Weight = reader["Grammatur"].GetInt();
            paper.Vendor = reader["Verkäufer"] as string;

            if (paper.ItemNumber != 0)
            {
              var exists =
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
        XtraMessageBox.Show("Feher beim Einlesen der Papiere." + Environment.NewLine + exception, "Fehler");
        return false;
      }
    }

    private readonly List<Paper> _papers = new List<Paper>();
  }
}