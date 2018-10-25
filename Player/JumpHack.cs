using UnityEngine;
using TheForest.Utils;

namespace Forest.Player
{
    public class JumpHack : MonoBehaviour
    {
        private float JumpHeight = 8f;

        public void Update()
        {
            if(Menu.JumpHack && LocalPlayer.IsInWorld)
            {
                LocalPlayer.FpCharacter.jumpHeight = JumpHeight * Menu.JumpMultiplier; 
            } else
            {
                LocalPlayer.FpCharacter.jumpHeight = JumpHeight;
            }
        }
    }
}
