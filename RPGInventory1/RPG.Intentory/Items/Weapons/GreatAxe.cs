using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Intentory.Items.Weapons
{
    public class GreatAxe : Item
    {
        public GreatAxe()
        {
            Name = "A metal sword.";
            Description = "It's sharp weapon to use.";
            Weight = 3;
            Type = ItemType.Weapon;
        }
    }
}