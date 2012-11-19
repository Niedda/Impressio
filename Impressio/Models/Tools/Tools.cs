using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Subvento.DatabaseObject;

namespace Impressio.Models.Tools
{
  public static class Integer
  {
    public static int GetInt(this object obj)
    {
      try
      {
        int result;

        if (Int32.TryParse(obj.ToString(), out result))
        {
          return result;
        }
        return 0;
      }
      catch (Exception)
      {
        return 0;
      }
    }
  }

  public static class DatabaseTools
  {
    public static object SetStringDbNull(this string value)
    {
      return string.IsNullOrWhiteSpace(value) ? (object)DBNull.Value : value;
    }

    public static object SetIntDbNull(this int value)
    {
      return value == 0 ? (object)DBNull.Value : value;
    }
  }

  public static class ModelTools
  {
    public static bool Usable<T>(this DatabaseObjectBase<T> databaseObject)
    {
      if (databaseObject != null)
      {
        if (databaseObject.Identity > 0)
        {
          return true;
        }
      }
      return false;
    }

    public static bool Usable(this Position position)
    {
      if (position != null && !string.IsNullOrEmpty(position.Name))
      {
        return true;
      }
      return false;
    }

    public static Position ToPosition<T>(this T position) where T : IPosition
    {
      return new Position
               {
                 Identity = position.Identity,
                 Name = position.Name,
                 FkOrder = position.FkOrder,
                 PositionTotal = position.PositionTotal,
                 Type = position.Type,
               };
    }

    public static List<Position> ToPosition<T>(this List<T> positions) where T : IPosition
    {
      return positions.Select(position => position.ToPosition()).ToList();
    }

    public static T ToType<T>(this Position position) where T : IPosition, new()
    {
      if (position == null) { throw new InvalidOperationException("Position is null"); }

      return new T
               {
                 Identity = position.Identity,
                 FkOrder = position.FkOrder,
                 Name = position.Name,
                 IsPredefined = position.IsPredefined,
               };
    }
  }

  public static class ApplicationTools
  {
    public static void RestartApplication()
    {
      Application.Restart();
    }
  }
}