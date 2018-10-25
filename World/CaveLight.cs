using UnityEngine;
using TheForest.Utils;

namespace Forest.World
{
    public class CaveLight : TheForestAtmosphere
    {
        private float baseCaveAddLight1Intensity;
        private float baseCaveAddLight2Intensity;

        private void GameStandardValues()
        {
            baseCaveAddLight1Intensity = CaveAddLight1Intensity;
            baseCaveAddLight2Intensity = CaveAddLight2Intensity;
        }

        private void Start()
        {
            GameStandardValues();
        }

        private void Update()
        {
            Shader.SetGlobalColor("_AmbientSkyColor", RenderSettings.ambientSkyColor.linear * RenderSettings.ambientIntensity);
            Shader.SetGlobalFloat("CaveAmount", Menu.CaveLight);
            Shader.SetGlobalFloat("_ForestCaveSetting", Mathf.Lerp(1f, -1f, Menu.CaveLight));

            if (Menu.EnableCaveLight && LocalPlayer.IsInCaves)
            {
                ReflectionAmount = 0.2f;

                //CaveAddLight1 = new Color(255, 255, 255);
                //CaveAddLight2 = new Color(255, 255, 255);
                //CaveGroundColor = new Color(255, 255, 255);
                //CaveEquatorColor = new Color(255, 255, 255);
                //CaveSkyColor = new Color(255, 255, 255);

                temp_AmbientIntensity = Mathf.Lerp(SunsetAmbientIntensity, Menu.CaveLight, Time.deltaTime);
                temp_SunIntensity = Mathf.Lerp(this.temp_SunIntensity, 0f, Time.deltaTime);
                temp_SunBounceIntensity = Mathf.Lerp(this.temp_SunBounceIntensity, 0f, Time.deltaTime);
                temp_BounceColor = Color.Lerp(this.temp_BounceColor, Color.black, Time.deltaTime);
                temp_SkyColor = Color.Lerp(this.temp_SkyColor, this.CaveSkyColor, Time.deltaTime);
                temp_EquatorColor = new Color(255, 255, 255);
                temp_GroundColor = new Color(255, 255, 255);
                temp_AddLight1 = Color.Lerp(this.SunsetAddLight1, this.CaveAddLight1, Time.deltaTime);
                temp_AddLight1Dir = Vector3.Lerp(this.SunsetAddLight1Dir, this.CaveAddLight1Dir, Time.deltaTime);
                temp_AddLight2 = Color.Lerp(this.SunsetAddLight2, this.CaveAddLight2, Time.deltaTime);
                temp_AddLight2Dir = Vector3.Lerp(this.SunsetAddLight2Dir, this.CaveAddLight2Dir, Time.deltaTime);

            } else
            {
                GameStandardValues();
            }
        }
    }
}
