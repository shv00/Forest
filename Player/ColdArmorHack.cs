using UnityEngine;
using TheForest.Utils;

namespace Forest.Player
{
    public class ColdArmorHack : MonoBehaviour
    {
        public void Update()
        {
            if (Menu.InfiniteArmour && LocalPlayer.IsInWorld)
            {
                LocalPlayer.Stats.ColdArmor = 100;
            }
        }
    }
}
