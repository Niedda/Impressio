using System;
using System.Collections.Generic;
using Impressio.Models.Tools;
using Subvento.DatabaseObject;

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

    public override int Identity { get; set; }

    public override string IdentityColumn { get { return "DescriptionId"; } }

    public override string Table { get { return "Description"; } }

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
      get
      {
        return Identity != 0 ? _detail.LoadObjectList(Detail.Columns.FkDetailDescription, Identity) : new List<Detail>();
      }
    }

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

    public override void SetObject()
    {
      Identity = Database.Reader[IdentityColumn].GetInt();
      JobTitle = Database.Reader[Columns.JobTitle.ToString()] as string;
      Arrange = Database.Reader[Columns.Arrange.ToString()].GetInt();
      FkDescriptionOrder = Database.Reader[Columns.FkDescriptionOrder.ToString()].GetInt();
      Price = Database.Reader[Columns.Price.ToString()].GetInt();
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
    
    private readonly List<Description> _descriptions = new List<Description>();

    private readonly Detail _detail = new Detail();

    private readonly List<Description> _predefinedDescriptions = new List<Description>();
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
    
    public override int Identity { get; set; }

    public override string IdentityColumn { get { return "DetailId"; } }

    public override string Table { get { return "Detail"; } }

    public int FkDetailDescription { get; set; }

    public string DetailTitle { get; set; }

    public string DetailContent { get; set; }

    public int Arrange { get; set; }

    public override List<Detail> Objects { get { return _details; } }

    public override void SetObject()
    {
      DetailContent = Database.Reader[Columns.DetailContent.ToString()] as string;
      Identity = Database.Reader[IdentityColumn].GetInt();
      Arrange = Database.Reader[Columns.Arrange.ToString()].GetInt();
      DetailTitle = Database.Reader[Columns.DetailTitle.ToString()] as string;
      FkDetailDescription = Database.Reader[Columns.FkDetailDescription.ToString()].GetInt();
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

    private readonly List<Detail> _details = new List<Detail>();
  }
}