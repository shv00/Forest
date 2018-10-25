using UnityEngine;
using TheForest.Utils;


namespace Forest.Player
{
    public class ArmourHack :MonoBehaviour
    {
        public void Update()
        {
            if (Menu.InfiniteArmour && LocalPlayer.IsInWorld)
            {
                LocalPlayer.Stats.Armor = 100;
            }
        }
    }
}
