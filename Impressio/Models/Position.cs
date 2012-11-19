using System;
using System.Collections.Generic;
using Impressio.Models.Tools;
using Subvento.DatabaseObject;

namespace Impressio.Models
{
  public class Position : IPosition
  {
    public int OrderId { get; set; }

    public int Identity { get; set; }

    public string Name { get; set; }

    public int FkOrder { get; set; }

    public bool IsPredefined { get; set; }

    public int PositionTotal { get; set; }

    public Type Type { get; set; }

    public List<Position> Objects
    {
      get { return _objects; }
    }

    public List<Position> PredefinedObjects
    {
      get { return _predefinedObjects; }
    }

    public List<Offset> Offsets
    {
      get { return _offsets ?? (_offsets = (new Offset().LoadObjectList(Offset.Columns.FkOffsetOrder, OrderId))); }
    }

    public List<Print> Prints
    {
      get { return _prints ?? (_prints = (new Print().LoadObjectList(Print.Columns.FkPrintOrder, OrderId))); }
    }

    public List<Data> Datas
    {
      get
      {
        return _datas ?? (_datas = (new Data().LoadObjectList(Data.Columns.FkDataOrder, OrderId)));
      }
    }

    public List<Finish> Finishes
    {
      get { return _finishes ?? (_finishes = (new Finish().LoadObjectList(Finish.Columns.FkFinishOrder, OrderId))); }
    }

    public List<Offset> PredefinedOffsets
    {
      get { return _predefinedOffsets ?? (_predefinedOffsets = (new Offset().LoadObjectList(Offset.Columns.IsPredefined, true))); }
    }

    public List<Print> PredefinedPrints
    {
      get { return _predefinedPrints ?? (_predefinedPrints = (new Print().LoadObjectList(Print.Columns.IsPredefined, true))); }
    }

    public List<Data> PredefinedDatas
    {
      get
      {
        return _predefinedDatas ?? (_predefinedDatas = (new Data().LoadObjectList(Data.Columns.IsPredefined, true)));
      }
    }

    public List<Finish> PredefinedFinishes
    {
      get { return _predefinedFinishes ?? (_predefinedFinishes = (new Finish().LoadObjectList(Finish.Columns.IsPredefined, true))); }
    }

    public void LoadPositions()
    {
      if (OrderId <= 0)
      {
        throw new InvalidOperationException("Order Id out of range");
      }

      _objects.AddRange(Datas.ToPosition());
      _objects.AddRange(Prints.ToPosition());
      _objects.AddRange(Offsets.ToPosition());
      _objects.AddRange(Finishes.ToPosition());
    }

    public void ClearPositions()
    {
      _datas = null;
      _prints = null;
      _offsets = null;
      _finishes = null;
      _objects.Clear();
    }

    public void LoadPredefinedObjects()
    {
      _predefinedObjects.AddRange(PredefinedDatas.ToPosition());
      _predefinedObjects.AddRange(PredefinedPrints.ToPosition());
      _predefinedObjects.AddRange(PredefinedOffsets.ToPosition());
      _predefinedObjects.AddRange(PredefinedFinishes.ToPosition());
    }

    public void ClearPredefinedObjects()
    {
      _predefinedDatas = null;
      _predefinedFinishes = null;
      _predefinedOffsets = null;
      _predefinedPrints = null;
      _predefinedObjects.Clear();
    }
    
    private readonly List<Position> _objects = new List<Position>();

    private readonly List<Position> _predefinedObjects = new List<Position>();

    private List<Finish> _finishes;

    private List<Data> _datas;

    private List<Print> _prints;

    private List<Offset> _offsets;

    private List<Finish> _predefinedFinishes;

    private List<Data> _predefinedDatas;

    private List<Print> _predefinedPrints;

    private List<Offset> _predefinedOffsets;
  }

  public enum Type
  {
    Datenaufbereitung,
    Digitaldruck,
    Offsetdruck,
    Weiterverarbeitung,
  }
}