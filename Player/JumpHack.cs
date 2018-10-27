using UnityEngine;
using TheForest.Utils;

namespace Forest.Player
{
    public class JumpHack : MonoBehaviour
    {
        private float baseJumpHeight;
        
        private void GameStandardValues()
        {
            baseJumpHeight = LocalPlayer.FpCharacter.jumpHeight;
        }
        
        private void Start()
        {
            GameStandardValues
        }
        
        public void Update()
        {
            if(Menu.JumpHack && LocalPlayer.IsInWorld)
            {
                LocalPlayer.FpCharacter.jumpHeight = baseJumpHeight * Menu.JumpMultiplier;
            } else
            {
                GameStandardValues();
            }
        }
    }
}
