using UnityEngine;
using TheForest.Utils;

namespace Forest.Player
{
    public class OxygenHack : MonoBehaviour
    {
        public void Update()
        {
            if (Menu.InfiniteBreath)
            {
                LocalPlayer.Stats.AirBreathing.TakingDamage = false;
                LocalPlayer.Stats.AirBreathing.CurrentLungAir = 9000f;
            }
        }
    }
}
