using UnityEngine;
using TheForest.Utils;

namespace Forest.Player
{
    public class JumpHack : MonoBehaviour
    {
        private float JumpHeight = 8f;

        public void Update()
        {
            if(Menu.JumpHack)
            {
                LocalPlayer.FpCharacter.jumpHeight = JumpHeight * 20f; 
            } else
            {
                LocalPlayer.FpCharacter.jumpHeight = JumpHeight;
            }
        }
    }
}
