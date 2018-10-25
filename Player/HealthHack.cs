using UnityEngine;
using TheForest.Utils;

namespace Forest.Player
{
    public class HealthHack : MonoBehaviour
    {
        private void Update()
        {
            if (Menu.InfiniteHealth && LocalPlayer.IsInWorld)
            {
                LocalPlayer.Stats.Health = 100;
            }
        }
    }
}
