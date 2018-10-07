using UnityEngine;
using TheForest.Utils;

namespace Forest.Experiment
{
    public class FlyAround 
    {
        public void Update()
        {

            LocalPlayer.FpCharacter.checkGrounded = true;
            LocalPlayer.FpCharacter.rb.useGravity = false;


            Vector3 velocity = LocalPlayer.FpCharacter.rb.velocity;
            float baseSpeed = 20f;

            if (UnityEngine.Input.GetButton("Run"))
            {
                baseSpeed = LocalPlayer.FpCharacter.runSpeed * 1.5f;
            }
            if (UnityEngine.Input.GetButton("Jump"))
            {
                velocity.y -= baseSpeed;
            }
            if (UnityEngine.Input.GetButton("Crouch"))
            {
                velocity.y += baseSpeed;
            }
            Vector3 force = ((Vector3)(Camera.main.transform.rotation * (new Vector3(UnityEngine.Input.GetAxis("Horizontal"), 0f, UnityEngine.Input.GetAxis("Vertical")) * baseSpeed))) - velocity;
            LocalPlayer.FpCharacter.rb.AddForce(force, ForceMode.VelocityChange);
        }
    }
}
