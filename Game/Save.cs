using UnityEngine;
using TheForest.Utils;

namespace Forest.Game
{
    public class Save : MonoBehaviour
    {
        public void Update()
        {
            if (UnityEngine.Input.GetKey(KeyCode.F5) && LocalPlayer.IsInWorld)
            {
                LocalPlayer.Stats.JustSave();
            }
        }
    }
}
