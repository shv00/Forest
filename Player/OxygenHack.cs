using UnityEngine;
using TheForest.Utils;

namespace Forest.Player
{
    public class OxygenHack : MonoBehaviour
    {
        private void Update()
        {
            if (Menu.InfiniteBreath && LocalPlayer.IsInWorld)
            {
                LocalPlayer.Stats.AirBreathing.TakingDamage = false;
                LocalPlayer.Stats.AirBreathing.CurrentLungAir = 9000f;
            }
        }
    }
}
