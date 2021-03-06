﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCW.ConsoleGame.Models.Characters
{
    public interface IPlayer : IComposite
    {
        int Health { get; set; }
        int Agility { get; set; }
        int Damage { get; set; }
        int Defense { get; set; }
        int Vitality { get; set; }
    }
}
