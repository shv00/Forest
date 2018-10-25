using UnityEngine;
using TheForest.Utils;

namespace Forest.Player
{
    public class WaterJump : MonoBehaviour
    {
        private void Update()
        {
            if (Menu.WaterJump && LocalPlayer.IsInWorld)
            {
                LocalPlayer.FpCharacter.allowWaterJump = true;
            }
        }
    }
}
