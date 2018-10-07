using UnityEngine;
using TheForest.Utils;

namespace Forest.Player
{
    public class NoFallDamage : MonoBehaviour
    {
        public void Update()
        {
            if (Menu.NoFallDamage)
            {
                LocalPlayer.FpCharacter.allowFallDamage = false;
            }
        }
    }
}
