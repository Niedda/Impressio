using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Impressio.Models.Tools
{
  public static class ReflectionTools
  {
    public static List<System.Type> GetClassByInterface(System.Type myType)
    {
      var typesInAssambly = Assembly.GetExecutingAssembly().GetTypes();
      return (typesInAssambly.Where(ass => ass.GetInterfaces().Contains(myType))).ToList();
    }
  }
}
