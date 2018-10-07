using UnityEngine;
using TheForest.Utils;
using TheForest.Tools;
using Bolt;
using UnityEngine.Events;
using FMOD.Studio;

namespace Forest.Player
{
    public class InstantTree : TreeHealth
    {
        public void Hit()
        {
            if(Menu.InstantTree)
            {
                Health = 1;
            }
            this.Hit();
        }
    }
}
