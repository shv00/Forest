using UnityEngine;
using TheForest.Utils;

namespace Forest.Player
{
    public class StaminaHack : MonoBehaviour
    {
        public void Update()
        {
            if (Menu.InfiniteStamina)
            {
                LocalPlayer.Stats.Stamina = 100f;

            }
        }
    }
}
