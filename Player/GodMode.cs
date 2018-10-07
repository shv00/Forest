using UnityEngine;
using TheForest.Utils;

namespace Forest.Player
{
    public class GodMode : MonoBehaviour
    {
        public void update()
        {
            if(Menu.GodMode)
            LocalPlayer.FpCharacter.hitByEnemy = false;
        }
    }
}
