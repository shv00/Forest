using UnityEngine;
using TheForest.Utils;

namespace Forest.Player
{
    public class HealthHack : MonoBehaviour
    {
        public void Update()
        {
            if (Menu.InfiniteHealth)
            {
                LocalPlayer.Stats.Health = 100;
            }
        }
    }
}
