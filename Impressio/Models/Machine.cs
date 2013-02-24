using System;
using System.Collections.Generic;
using Impressio.Models.Tools;
using Subvento.DatabaseObject;

namespace Impressio.Models
{
  /// <summary>
  /// Offset print machine class containig the basic parameters of the machine
  /// </summary>
  public class Machine : DatabaseObjectBase<Machine>
  {
    #region Columns enum

    public enum Columns
    {
      Name,
      PlateCost,
      Speed,
      PricePerColor,
      PricePerHour,
      EasySetup,
      DifficultSetup,
      DifficultColor,
      PlateSetup
    }

    #endregion

    private readonly List<Machine> _machines = new List<Machine>();

    public override int Identity { get; set; }

    public override string IdentityColumn { get { return "MachineId"; } }

    public override string Table { get { return "Machine"; } }

    public int PricePerColor { get; set; }

    public int Speed { get; set; }

    public int PricePerHour { get; set; }

    public int DifficultColor { get; set; }

    public int DifficultSetup { get; set; }

    public int EasySetup { get; set; }

    public string Name { get; set; }

    public int PlateCost { get; set; }

    public int PlateSetup { get; set; }

    public override List<Machine> Objects { get { return _machines; } }

    public override void SetObject()
    {
      Identity = Database.DatabaseCommand.Reader[IdentityColumn].GetInt();
      Name = Database.DatabaseCommand.Reader[Columns.Name.ToString()] as string;
      Speed = Database.DatabaseCommand.Reader[Columns.Speed.ToString()].GetInt();
      PricePerColor = Database.DatabaseCommand.Reader[Columns.PricePerColor.ToString()].GetInt();
      PlateCost = Database.DatabaseCommand.Reader[Columns.PlateCost.ToString()].GetInt();
      PricePerHour = Database.DatabaseCommand.Reader[Columns.PricePerHour.ToString()].GetInt();
      DifficultColor = Database.DatabaseCommand.Reader[Columns.DifficultColor.ToString()].GetInt();
      EasySetup = Database.DatabaseCommand.Reader[Columns.EasySetup.ToString()].GetInt();
      DifficultSetup = Database.DatabaseCommand.Reader[Columns.DifficultSetup.ToString()].GetInt();
      PlateSetup = Database.DatabaseCommand.Reader[Columns.PlateSetup.ToString()].GetInt();
    }

    public override void ClearObjectList()
    {
      _machines.Clear();
    }

    public override Dictionary<Enum, object> GetObject()
    {
      return new Dictionary<Enum, object>
               {
                 {Columns.Name, Name},
                 {Columns.PlateCost, PlateCost},
                 {Columns.Speed, Speed},
                 {Columns.PricePerColor, PricePerColor},
                 {Columns.PricePerHour, PricePerHour},
                 {Columns.DifficultColor, DifficultColor},
                 {Columns.EasySetup, EasySetup},
                 {Columns.DifficultSetup, DifficultSetup},
                 {Columns.PlateSetup, PlateSetup},
               };
    }
  }
}
