using System;

namespace Impressio.Models.Tools
{
  public static class Integer
  {
    public static int GetInt(this object obj)
    {
      try
      {
        return Convert.ToInt32(obj);
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
      return string.IsNullOrWhiteSpace(value) ? (object) DBNull.Value : value;
    }

    public static object SetIntDbNull(this int value)
    {
      return value == 0 ? (object) DBNull.Value : value;
    }
  }
}