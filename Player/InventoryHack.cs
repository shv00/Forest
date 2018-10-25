using UnityEngine;
using TheForest.Utils;


namespace Forest.Player
{
    public class InventoryHack : MonoBehaviour
    {
        public void Update()
        {
            if (Menu.InfiniteInventory && LocalPlayer.IsInWorld)
            {
                foreach(TheForest.Items.Item item in TheForest.Items.ItemDatabase.Items)
                {
                    item._maxAmount = 9000;
                }
            }
        }
    }
}
