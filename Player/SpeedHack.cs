using UnityEngine;
using TheForest.Utils;

namespace Forest.Player
{
    public class SpeedHack : MonoBehaviour
    {

        private float baseWalkSpeed;
        private float baseRunSpeed;
        private float baseJumpHeight;
        private float baseCrouchSpeed;
        // private float baseStrafeSpeed;
        private float baseSwimmingSpeed;
        private float baseGravity;
        private float baseMaxVelocityChange;
        private float baseMaximumVelocity;
        private float baseMaxSwimVelocity;

        private void GameStandardValues()
        {
            baseMaxSwimVelocity = LocalPlayer.FpCharacter.maxSwimVelocity;
            baseWalkSpeed = LocalPlayer.FpCharacter.walkSpeed;
            baseRunSpeed = LocalPlayer.FpCharacter.runSpeed;
            baseJumpHeight = LocalPlayer.FpCharacter.jumpHeight;
            baseCrouchSpeed = LocalPlayer.FpCharacter.crouchSpeed;
            // baseStrafeSpeed = LocalPlayer.FpCharacter.strafeSpeed;
            baseSwimmingSpeed = LocalPlayer.FpCharacter.swimmingSpeed;
            baseMaxVelocityChange = LocalPlayer.FpCharacter.maxVelocityChange;
            baseMaximumVelocity = LocalPlayer.FpCharacter.maximumVelocity;
            baseGravity = LocalPlayer.FpCharacter.gravity;
        }

        private void Start()
        {
            GameStandardValues();
        }

        private void Update()
        {
            if(Menu.SpeedHack && LocalPlayer.IsInWorld)
            {
                LocalPlayer.FpCharacter.walkSpeed = baseWalkSpeed * Menu.SpeedMultiplier;
                LocalPlayer.FpCharacter.runSpeed = baseRunSpeed * Menu.SpeedMultiplier;
                LocalPlayer.FpCharacter.jumpHeight = baseJumpHeight * Menu.JumpMultiplier;
                LocalPlayer.FpCharacter.crouchSpeed = baseCrouchSpeed * Menu.SpeedMultiplier;
                // LocalPlayer.FpCharacter.strafeSpeed = baseStrafeSpeed * Menu.SpeedMultiplier;
                LocalPlayer.FpCharacter.swimmingSpeed = baseSwimmingSpeed * Menu.SpeedMultiplier;
                LocalPlayer.FpCharacter.maxSwimVelocity = baseMaxSwimVelocity * Menu.SpeedMultiplier;
            } else
            {
                GameStandardValues();
            }

        }
    }
}
