﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Intentory.Items.Containers
{
    public class PotionSatchel : SpecificContainer
    {
        public PotionSatchel() : base(4, ItemType.Potion)
        {
            Name = "Bag specifically for potions ONLY!";
            Description = "Fir lined padded bag.";
            Weight = 1;
            Type = ItemType.Container;
        }
    }
}
