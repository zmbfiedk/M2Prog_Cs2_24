using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    internal class mob
    {
        internal bool isdead;
        internal int hp = 10;
        
        internal mob(int initialHp)
        {
            hp = initialHp;
            isdead = false;
        }

        internal void TakeDamage(int damage)
        {
            if (isdead)
            {
                return; 
            }

            hp -= damage; 

            if (hp <= 0)
            {
                hp = 0; 
                isdead = true; 
            }
        }
    }
}