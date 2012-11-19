﻿using System;
using System.Collections.Generic;
using Impressio.Models.Tools;
using Subvento.DatabaseObject;

namespace Impressio.Models
{
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
    }

    #endregion

    private readonly List<Machine> _machines = new List<Machine>();

    public override int Identity { get; set; }

    public override string IdentityColumn { get { return "MachineId"; } }

    public override string Table { get { return "Machine"; } }

    public int PricePerColor { get; set; }

    public int Speed { get; set; }

    public int PricePerHour { get; set; }

    public string Name { get; set; }

    public int PlateCost { get; set; }

    public override List<Machine> Objects { get { return _machines; } }

    public override void SetObject()
    {
      Identity = Database.DatabaseCommand.Reader[IdentityColumn].GetInt();
      Name = Database.DatabaseCommand.Reader[Columns.Name.ToString()] as string;
      Speed = Database.DatabaseCommand.Reader[Columns.Speed.ToString()].GetInt();
      PricePerColor = Database.DatabaseCommand.Reader[Columns.PricePerColor.ToString()].GetInt();
      PlateCost = Database.DatabaseCommand.Reader[Columns.PlateCost.ToString()].GetInt();
      PricePerHour = Database.DatabaseCommand.Reader[Columns.PricePerHour.ToString()].GetInt();
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
               };
    }
  }
}
