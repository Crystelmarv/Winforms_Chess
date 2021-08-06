﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Winforms_Chess.Game_Objects;

namespace Winforms_Chess
{
  public class Tile : IGameObject
  {
    public Coords Coord { get; set; }
    public TileColor Color { get; set; }

  }
}
