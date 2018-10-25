using UnityEngine;
using TheForest.Utils;

namespace Forest.Player
{
    public class NoStarvation : MonoBehaviour
    {
        public void Update()
        {
            if (Menu.NoStarvation && LocalPlayer.IsInWorld)
            {
                LocalPlayer.Stats.Fullness = 100f;
                LocalPlayer.Stats.StarvationCurrentDuration = 0f;
            }
        }
    }
}
