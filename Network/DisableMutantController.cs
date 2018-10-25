using UnityEngine;
using TheForest.Utils;

namespace Forest.Network
{
    public class DisableMutantController : MonoBehaviour
    {
        public void Disable()
        {

            if(Menu.DisableMutantController && LocalPlayer.IsInWorld)
            {
                Scene.MutantControler.enabled = false;
            } else
            {
                Scene.MutantControler.enabled = true;
            }
        }
    }
}
