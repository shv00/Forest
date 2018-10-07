using UnityEngine;
using TheForest.Utils;

namespace Forest.World
{
    public class CaveLight : TheForestAtmosphere
    {
        public void Update()
        {
            if (Menu.EnableCaveLight == true)
            {
                if (LocalPlayer.IsInCaves)
                {
                    this.CaveAddLight1 = new Color(255, 255, 255);
                    this.CaveAddLight2 = new Color(255, 255, 255);
                    this.CaveAddLight1Intensity = 3;
                    this.CaveAddLight2Intensity = 3;
                }
            }
        }
    }
}
