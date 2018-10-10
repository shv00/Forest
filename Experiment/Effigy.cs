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
                lightBool = true;
                lightEvent = "event:/fire/fire_built_start";
            }
        }
    }
}
