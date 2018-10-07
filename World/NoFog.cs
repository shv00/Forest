using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheForest.Utils;
using UnityEngine;

namespace Forest.World
{
    public class NoFog : TheForestAtmosphere
    {
        public void Update()
        {
            if(Menu.NoFog)
            {
                this.FogColor = new Color(0f, 0f, 0f, 0f);
                if (Sunshine.Instance.Ready)
                {
                    Sunshine.Instance.ScatterColor = this.FogColor;
                }
                if (LocalPlayer.IsInCaves)
                {
                    this.FogColor = new Color(0f, 0f, 0f, 0f);
                }
                this.CurrentFogColor = this.FogColor;
                Shader.SetGlobalColor("_FogColor", this.FogColor);
            }
        }

        public void ChangeFogAmount()
        {
            this.FogCurrent = 300000f;
            TheForestAtmosphere.Instance.FogCurrent = 300000f;
        }
    }
}
