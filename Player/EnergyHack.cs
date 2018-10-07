using UnityEngine;
using TheForest.Utils;

namespace Forest.Player
{
    public class EnergyHack : MonoBehaviour
    {
        public void Update()
        {
            if (Menu.InfiniteEnergy)
            {
                LocalPlayer.Stats.Energy = 100f;
            }
        }
    }
}
