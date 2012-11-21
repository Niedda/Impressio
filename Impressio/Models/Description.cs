using System;
using System.Collections.Generic;
using Impressio.Models.Tools;
using Subvento.DatabaseObject;

namespace Impressio.Models
{
  /// <summary>
  /// Description for the order - contains also the final price
  /// </summary>
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
        if(_details == null || _details.Count == 0 || _details[0].FkDetailDescription != Identity)
        {
          return _details = (new Detail().LoadObjectList(Detail.Columns.FkDetailDescription, Identity));
        }
        return _details;
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
      Identity = Database.DatabaseCommand.Reader[IdentityColumn].GetInt();
      JobTitle = Database.DatabaseCommand.Reader[Columns.JobTitle.ToString()] as string;
      Arrange = Database.DatabaseCommand.Reader[Columns.Arrange.ToString()].GetInt();
      FkDescriptionOrder = Database.DatabaseCommand.Reader[Columns.FkDescriptionOrder.ToString()].GetInt();
      Price = Database.DatabaseCommand.Reader[Columns.Price.ToString()].GetInt();
      IsPredefined = (bool)Database.DatabaseCommand.Reader[Columns.IsPredefined.ToString()];
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

    private List<Detail> _details;

    private readonly List<Description> _predefinedDescriptions = new List<Description>();
  }

  /// <summary>
  /// Positons contained by the descriptions
  /// </summary>
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
      DetailContent = Database.DatabaseCommand.Reader[Columns.DetailContent.ToString()] as string;
      Identity = Database.DatabaseCommand.Reader[IdentityColumn].GetInt();
      Arrange = Database.DatabaseCommand.Reader[Columns.Arrange.ToString()].GetInt();
      DetailTitle = Database.DatabaseCommand.Reader[Columns.DetailTitle.ToString()] as string;
      FkDetailDescription = Database.DatabaseCommand.Reader[Columns.FkDetailDescription.ToString()].GetInt();
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