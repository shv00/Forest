using UnityEngine;
using TheForest.Utils;

namespace Forest.Experiment
{
    public class Effigy : enableEffigy
    {
        public void Update()
        {
            if (Menu.TriggerEffigy)
            {
                this.lightBool = true;
                this.lightEvent = "event:/fire/fire_built_start";
            }
        }
    }
}
