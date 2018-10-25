using TheForest.Items;
using TheForest.Utils;
using UnityEngine;

namespace Forest.World
{
    public class FillInventory : MonoBehaviour
    {
        public void Update()
        {

                if (UnityEngine.Input.GetKeyDown(KeyCode.F4) && LocalPlayer.IsInWorld)
                {
                    for (int i = 0; i < ItemDatabase.Items.Length; i++)
                    {
                        Item item = ItemDatabase.Items[i];
                        try
                        {
                            if (item._maxAmount >= 0)
                            {
                                LocalPlayer.Inventory.AddItem(item._id, 2000 - LocalPlayer.Inventory.AmountOf(item._id, true), true, false, null);
                            }
                        }
                        catch (System.Exception)
                        {
                            // Do nothing??
                        }
                    }
                }
            
        }
    }
}
