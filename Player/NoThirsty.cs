using UnityEngine;
using TheForest.Utils;

namespace Forest.Player
{
    public class NoThirsty : MonoBehaviour
    {
        private void Update()
        {
            if(Menu.NoThirsty && LocalPlayer.IsInWorld)
            {
                LocalPlayer.Stats.Thirst = 0f;
            }
        }
    }
}
