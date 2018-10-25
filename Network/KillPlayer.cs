using UnityEngine;
using TheForest.Utils;

namespace Forest.Network
{
    public class KillPlayer : MonoBehaviour
    {
        public static void KillYourself()
        {
            if(LocalPlayer.Stats && LocalPlayer.IsInWorld)
            {
                LocalPlayer.Stats.Hit(1000, true, PlayerStats.DamageType.Physical);
            }
        }
    }
}
