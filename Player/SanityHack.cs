using UnityEngine;
using TheForest.Utils;


namespace Forest.Player
{
    public class SanityHack : MonoBehaviour
    {
        public void Update()
        {
            if (Menu.InfiniteSanity)
            {
                Menu.EffigyAccess = false;

                LocalPlayer.Stats.Sanity.CurrentSanity = 100f;

                // Decrease Sanity
                LocalPlayer.Stats.Sanity.SanityPerCannibalism = 0f;
                LocalPlayer.Stats.Sanity.SanityPerSecondInCave = 0f;
                LocalPlayer.Stats.Sanity.SanityPerKill = 0f;
                LocalPlayer.Stats.Sanity.SanityPerLimbCutOff = 0f;

                // Increase Sanity
                LocalPlayer.Stats.Sanity.SanityPerSecondSittedOnBench = 0f;
                LocalPlayer.Stats.Sanity.SanityPerFreshFoodEaten = 0f;
                LocalPlayer.Stats.Sanity.SanityPerInGameHourOfSleep = 0f;
                LocalPlayer.Stats.Sanity.SanityPerSecondOfMusic = 0f;
            }
        }
    }
}
