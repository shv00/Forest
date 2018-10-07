using UnityEngine;
using TheForest.Utils;
using TheForest.World;

namespace Forest.World
{
    public class ForestAtmosphere : WeatherSystem
    {
        public void Freeze()
        {
            if(Menu.FreezeWeather)
            {
                return;
            }
        }

        public void Update()
        {
            if (LocalPlayer.IsInWorld)
            {
                if(Menu.ForceWeather >= 0)
                {
                    this.AllOff();
                    Scene.RainFollowGO.SetActive(true);
                    Scene.RainTypes.SnowConstant.SetActive(false);

                    if(Menu.ForceWeather == 1 )
                    {
                        this.TurnOn(WeatherSystem.RainTypes.Light);
                    }
                    if(Menu.ForceWeather == 2)
                    {
                        this.TurnOn(WeatherSystem.RainTypes.Medium);
                    }
                    if (Menu.ForceWeather == 3)
                    {
                        this.TurnOn(WeatherSystem.RainTypes.Heavy);
                    }
                    if (Menu.ForceWeather == 4)
                    {
                        this.GrowClouds();
                        this.ReduceClouds();
                    }
                    if (Menu.ForceWeather == 5)
                    {
                        Scene.RainTypes.SnowLight.SetActive(true);
                    }
                    if (Menu.ForceWeather == 6)
                    {
                        Scene.RainTypes.SnowMedium.SetActive(true);
                    }
                    if (Menu.ForceWeather == 7)
                    {
                        Scene.RainTypes.SnowHeavy.SetActive(true);
                    }

                    Menu.ForceWeather = -1;

                }
            }
        }
    }
}
