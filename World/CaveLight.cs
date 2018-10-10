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
                    CaveAddLight1 = new Color(255, 255, 255);
                    CaveAddLight2 = new Color(255, 255, 255);
                    CaveAddLight1Intensity = 3;
                    CaveAddLight2Intensity = 3;
                }
            }
        }
    }
}
