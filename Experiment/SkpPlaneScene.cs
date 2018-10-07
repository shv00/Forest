using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using TheForest.Utils;
using Input = TheForest.Utils.Input;

namespace Forest.Experiment
{
    public class SkpPlaneScene : TriggerCutScene
    {
        public void Update()
        {
            if(Menu.TriggerSkipPlaneScene)
            {
                SpaceTut.SetActive(false);
                LightsFlight.SetActive(false);
                pmTrigger.SendEvent("toSkipOpening");
                //skipOpening(true);
            }
            else
            {
                Input.LockMouse();
            }
        }
    }
}
