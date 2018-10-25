using UnityEngine;
using TheForest.Utils;

namespace Forest.Player
{
    public class StaminaHack : MonoBehaviour
    {
        private void Update()
        {
            if (Menu.InfiniteStamina && LocalPlayer.IsInWorld)
            {
                LocalPlayer.Stats.Stamina = 100f;

            }
        }
    }
}
