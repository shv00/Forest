using UnityEngine;
using TheForest.Utils;

namespace Forest.Player
{
    public class NoDamage : MonoBehaviour
    {
        public void update()
        {
            if(Menu.NoDamage && LocalPlayer.IsInWorld)
                LocalPlayer.FpCharacter.hitByEnemy = false;
                LocalPlayer.Stats.Health = 100;
                LocalPlayer.FpCharacter.allowFallDamage = false;
        }
    }
}
