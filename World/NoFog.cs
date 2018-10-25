using TheForest.Utils;
using UnityEngine;

namespace Forest.World
{
    public class NoFog : TheForestAtmosphere
    {
        public void Update()
        {
            if(Menu.NoFog && LocalPlayer.IsInWorld)
            {
                FogColor = new Color(0f, 0f, 0f, 0f);
                if (Sunshine.Instance.Ready)
                {
                    Sunshine.Instance.ScatterColor = FogColor;
                }
                if (LocalPlayer.IsInCaves)
                {
                    FogColor = new Color(0f, 0f, 0f, 0f);
                }
                CurrentFogColor = FogColor;
                Shader.SetGlobalColor("_FogColor", FogColor);
            }
        }

        public void ChangeFogAmount()
        {
            FogCurrent = 300000f;
            Instance.FogCurrent = 300000f;
        }
    }
}
