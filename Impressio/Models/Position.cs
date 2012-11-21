using System;
using System.Collections.Generic;
using System.Linq;
using Impressio.Controls;
using Impressio.Models.Tools;

namespace Impressio.Models
{
  /// <summary>
  /// Base class for Positions
  /// </summary>
  public class Position : PositionBase
  {
    public override int Identity { get; set; }

    public override string Name { get; set; }

    public override string DisplayName { get; set; }

    public override int FkOrder { get; set; }

    public override int PositionTotal { get; set; }

    public override bool IsPredefined { get; set; }

    public override IControl AssignedControl
    {
      get
      {
        if (!string.IsNullOrEmpty(DisplayName) && !string.IsNullOrEmpty(Name) && Identity > 0)
        {
          var typeList = ReflectionTools.GetClassByInterface(Type.GetType("Impressio.Models.IPosition"));
          typeList.Remove(Type.GetType("Impressio.Models.PositionBase"));
          typeList.Remove(Type.GetType("Impressio.Models.Position"));

          foreach (var pos in typeList.Select(type => (IPosition)Activator.CreateInstance(type)).Where(pos => pos.DisplayName == DisplayName))
          {
            pos.FkOrder = FkOrder;
            pos.Identity = Identity;
            return pos.AssignedControl;
          }
        }
        throw new InvalidOperationException("Invalid call for Control");
      }
    }

    public List<Position> Positions
    {
      get { return _positions ?? (_positions = LoadPositions()); }
      set { _positions = value; }
    }

    public List<Position> PredefinedPosition
    {
      get { return _predefinedPositions ?? (_predefinedPositions = LoadPredefinedPositions()); }
      set { _predefinedPositions = value; }
    } 

    public override List<Position> LoadPositions()
    {
      var typeList = ReflectionTools.GetClassByInterface(Type.GetType("Impressio.Models.IPosition"));
      typeList.Remove(Type.GetType("Impressio.Models.PositionBase"));
      typeList.Remove(Type.GetType("Impressio.Models.Position"));
      var list = new List<Position>();

      foreach (var position in typeList.Select(type => (Position)Activator.CreateInstance(type)))
      {
        position.FkOrder = FkOrder;
        list.AddRange(position.LoadPositions());
      }
      return list;
    }

    public override List<Position> LoadPredefinedPositions()
    {
      var typeList = ReflectionTools.GetClassByInterface(Type.GetType("Impressio.Models.IPosition"));
      typeList.Remove(Type.GetType("Impressio.Models.PositionBase"));
      typeList.Remove(Type.GetType("Impressio.Models.Position"));
      var list = new List<Position>();

      foreach (var position in typeList.Select(type => (Position)Activator.CreateInstance(type)))
      {
        list.AddRange(position.LoadPredefinedPositions());
      }
      return list;
    }

    public override void ClearPredefinedObjects()
    {
      _predefinedPositions = null;
    }

    public override void ClearObjects()
    {
      _positions = null;
    }

    public override void DeletePosition()
    {
      if (Identity > 0 && !string.IsNullOrEmpty(DisplayName))
      {
        var typeList = ReflectionTools.GetClassByInterface(Type.GetType("Impressio.Models.IPosition"));
        typeList.Remove(Type.GetType("Impressio.Models.PositionBase"));
        typeList.Remove(Type.GetType("Impressio.Models.Position"));

        foreach (var type in typeList)
        {
          var pos = (IPosition)Activator.CreateInstance(type);

          if (pos.DisplayName == DisplayName)
          {
            pos = this;
            pos.DeletePosition();
          }
        }
      }
      throw new InvalidOperationException("Position could not be deleted");
    }

    public override int SavePosition()
    {
      if (!string.IsNullOrEmpty(DisplayName))
      {
        var typeList = ReflectionTools.GetClassByInterface(Type.GetType("Impressio.Models.IPosition"));
        typeList.Remove(Type.GetType("Impressio.Models.PositionBase"));
        typeList.Remove(Type.GetType("Impressio.Models.Position"));

        foreach (var type in typeList)
        {
          var pos = (IPosition)Activator.CreateInstance(type);

          if (pos.DisplayName == DisplayName)
          {
            var conPos = (IPosition)Activator.CreateInstance(type);
            conPos.FkOrder = FkOrder;
            conPos.IsPredefined = IsPredefined;
            conPos.Name = Name;
            return conPos.SavePosition();
          }
        }
      }
      throw new InvalidOperationException("Position does not exist");
    }

    public override int CopyPosition(int orderId)
    {
      Identity = 0;
      IsPredefined = false;
      FkOrder = orderId;
      return SavePosition();
    }

    public static List<string> AvailablePositions()
    {
      var typeList = ReflectionTools.GetClassByInterface(Type.GetType("Impressio.Models.IPosition"));
      typeList.Remove(Type.GetType("Impressio.Models.PositionBase"));
      typeList.Remove(Type.GetType("Impressio.Models.Position"));
      return typeList.Select(type => (IPosition)Activator.CreateInstance(type)).Select(pos => pos.DisplayName).ToList();
    }

    public static List<string> AvailableTypes()
    {
      var typeList = ReflectionTools.GetClassByInterface(Type.GetType("Impressio.Models.IPosition"));
      typeList.Remove(Type.GetType("Impressio.Models.PositionBase"));
      typeList.Remove(Type.GetType("Impressio.Models.Position"));
      var list = new List<string>();
      foreach (var type in typeList)
      {
        var pos = (Position)Activator.CreateInstance(type);
        list.Add(pos.DisplayName);
      }
      return list;
    }

    private List<Position> _positions;

    private List<Position> _predefinedPositions;
  } 
}