using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using TheForest.Utils;

namespace Forest.World
{
    public class SaveEverywhere : MonoBehaviour
    {
        public void CheckSave()
        {
            if (UnityEngine.Input.GetKeyDown(KeyCode.F5))
            {
                LocalPlayer.Stats.JustSave();
            }
        }
    }
}
