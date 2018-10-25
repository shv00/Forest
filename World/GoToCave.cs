using UnityEngine;
using TheForest.Utils;

namespace Forest.World
{
    public class GoToCave : MonoBehaviour
    {
        public void Cave(bool inCave)
        {
            if (inCave && !LocalPlayer.IsInCaves)
            {
                LocalPlayer.GameObject.SendMessage("InACave");
            } else if(!inCave && LocalPlayer.IsInCaves) {
                LocalPlayer.GameObject.SendMessage("NotInCave");
            }
        }
    }
}
