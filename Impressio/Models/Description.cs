﻿using System;
using System.Collections.Generic;
using Impressio.Models.Database.DatabaseObject;
using Impressio.Models.Tools;

namespace Impressio.Models
{
  public class Description : DatabaseObjectBase<Description>, IPredefined<Description>
  {
    #region Columns enum

    public enum Columns
    {
      JobTitle,
      FkDescriptionOrder,
      Arrange,
      IsPredefined,
      Price,
    }

    #endregion

    private readonly List<Description> _descriptions = new List<Description>();

    private readonly Detail _detail = new Detail();
    private readonly List<Description> _predefinedDescriptions = new List<Description>();

    public override int Identity { get; set; }

    public override string IdentityColumn
    {
      get { return "DescriptionId"; }
    }

    public override string Table
    {
      get { return "Description"; }
    }

    public string JobTitle { get; set; }

    public int FkDescriptionOrder { get; set; }

    public int Arrange { get; set; }

    public bool IsPredefined { get; set; }

    public int Price { get; set; }

    public override List<Description> Objects
    {
      get { return _descriptions; }
    }

    public List<Detail> Details
    {
      get { return Identity != 0 ? _detail.LoadObjectList(Detail.Columns.FkDetailDescription, Identity) : new List<Detail>(); }
    }

    #region IPredefined<Description> Members

    public void LoadPredefined()
    {
      var description = new Description();
      _predefinedDescriptions.AddRange(description.LoadObjectList(Columns.IsPredefined, true));
    }

    public List<Description> PredefinedObjects
    {
      get { return _predefinedDescriptions; }
    }

    public void ClearPredefinedObjects()
    {
      _predefinedDescriptions.Clear();
    }

    #endregion

    public override void SetObject()
    {
      Identity = Database.Reader["DescriptionId"].GetInt();
      JobTitle = Database.Reader["JobTitle"] as string;
      Arrange = Database.Reader["Arrange"].GetInt();
      FkDescriptionOrder = Database.Reader["FkDescriptionOrder"].GetInt();
      Price = Database.Reader["Price"].GetInt();
    }

    public override void SetObjectList()
    {
      var description = new Description();
      description.SetObject();
      _descriptions.Add(description);
    }

    public override Dictionary<Enum, object> GetObject()
    {
      return new Dictionary<Enum, object>
               {
                 {Columns.JobTitle, JobTitle},
                 {Columns.FkDescriptionOrder, FkDescriptionOrder.SetIntDbNull()},
                 {Columns.Arrange, Arrange.ToString()},
                 {Columns.IsPredefined, IsPredefined.ToString()},
                 {Columns.Price, Price.ToString()},
               };
    }

    public override void ClearObjectList()
    {
      _descriptions.Clear();
    }
  }

  public class Detail : DatabaseObjectBase<Detail>
  {
    #region Columns enum

    public enum Columns
    {
      FkDetailDescription,
      DetailTitle,
      DetailContent,
      Arrange,
    }

    #endregion

    private readonly List<Detail> _details = new List<Detail>();

    public override int Identity { get; set; }

    public override string IdentityColumn
    {
      get { return "DetailId"; }
    }

    public override string Table
    {
      get { return "Detail"; }
    }

    public int FkDetailDescription { get; set; }

    public string DetailTitle { get; set; }

    public string DetailContent { get; set; }

    public int Arrange { get; set; }

    public override List<Detail> Objects
    {
      get { return _details; }
    }

    public override void SetObject()
    {
      DetailContent = Database.Reader["DetailContent"] as string;
      Identity = Database.Reader["DetailId"].GetInt();
      Arrange = Database.Reader["Arrange"].GetInt();
      DetailTitle = Database.Reader["DetailTitle"] as string;
      FkDetailDescription = Database.Reader["FkDetailDescription"].GetInt();
    }

    public override void SetObjectList()
    {
      var detail = new Detail();
      detail.SetObject();
      _details.Add(detail);
    }

    public override Dictionary<Enum, object> GetObject()
    {
      return new Dictionary<Enum, object>
               {
                 {Columns.DetailTitle, DetailTitle},
                 {Columns.Arrange, Arrange},
                 {Columns.DetailContent, DetailContent},
                 {Columns.FkDetailDescription, FkDetailDescription},
               };
    }
  }
}