using UnityEngine;
using TheForest.Utils;

namespace Forest.Player
{
    public class SpeedHack : MonoBehaviour
    {
        public float WalkSpeed = 8f; // 5f before
        public float RunSpeed = 16f * Mathf.Min(1f + (float)LocalPlayer.Stats.Skills.AthleticismSkillLevel * 0.05f, 1.3f);
        public float CrouchSpeed = 2f * 1.75f * Mathf.Min(1f + (float)LocalPlayer.Stats.Skills.AthleticismSkillLevel * 0.01f, 1.85f);
        //public float strafeSpeed = 4f;
        public float SwimSpeed = 6f;

        public void Update()
        {
            if( Menu.SpeedHack == true)
            {
                LocalPlayer.FpCharacter.walkSpeed = WalkSpeed * 20f;
                LocalPlayer.FpCharacter.runSpeed = RunSpeed * 20f;
                LocalPlayer.FpCharacter.swimmingSpeed = SwimSpeed * 20f;
                //LocalPlayer.FpCharacter.strafeSpeed = strafeSpeed * 100f;
                LocalPlayer.FpCharacter.crouchSpeed = CrouchSpeed * 20f;
            }
            else
            {
                LocalPlayer.FpCharacter.walkSpeed = WalkSpeed;
                LocalPlayer.FpCharacter.runSpeed = RunSpeed;
                LocalPlayer.FpCharacter.swimmingSpeed = SwimSpeed;
                //LocalPlayer.FpCharacter.strafeSpeed = strafeSpeed;
                LocalPlayer.FpCharacter.crouchSpeed = CrouchSpeed;
            }
            
        }
    }
}
