using UnityEngine;
using TheForest.Utils;

namespace Forest.Player
{
    public class StealthHack : MonoBehaviour
    {
        public void Update()
        {
            if (Menu.InfiniteEnergy)
            {
                LocalPlayer.Stats.Stealth = 100f;
            }
        }
    }
}
