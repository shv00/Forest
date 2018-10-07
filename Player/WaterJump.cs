using UnityEngine;
using TheForest.Utils;

namespace Forest.Player
{
    public class WaterJump : MonoBehaviour
    {
        public void Update()
        {
            if (Menu.WaterJump)
            {
                LocalPlayer.FpCharacter.allowWaterJump = true;
            }
        }
    }
}
