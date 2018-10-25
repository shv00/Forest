using UnityEngine;
using TheForest.Utils;

namespace Forest.Player
{
    public class StealthHack : MonoBehaviour
    {
        private void Update()
        {
            if (Menu.InfiniteEnergy && LocalPlayer.IsInWorld)
            {
                LocalPlayer.Stats.Stealth = 100f;
            }
        }
    }
}
