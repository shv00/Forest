using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using TheForest.Utils;

namespace Forest.World
{
    public class Enemies : EnemyHealth
    {
        public void Start(int damage)
        {
            base.Hit(damage * 100000);
        }
    }
}
