using UnityEngine;
using TheForest.Utils;


namespace Forest.Player
{
    public class NoThirsty : MonoBehaviour
    {
        public void Update()
        {
            if(Menu.NoThirsty)
            {
                LocalPlayer.Stats.Thirst = 0f;
            }
        }
    }
}
