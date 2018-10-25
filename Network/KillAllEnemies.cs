using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Forest.Network
{
    public class KillAllEnemies : MonoBehaviour
    {
        public static void KillAll()
        {
            List<GameObject> list = new List<GameObject>(TheForest.Utils.Scene.MutantControler.activeCannibals);
            foreach (GameObject current in TheForest.Utils.Scene.MutantControler.activeInstantSpawnedCannibals)
            {
                if(!list.Contains(current))
                {
                    list.Add(current);
                }
            }

            list.RemoveAll((GameObject o) => 0 == null);
            list.RemoveAll((GameObject o) => o != o.activeSelf);
            if(list.Count > 0)
            {
                for (var i = 0; i < list.Count; i++)
                    list[i].SendMessage("killThisEnemy", SendMessageOptions.DontRequireReceiver);
            }
            else
            {
                // do nothing.
            }


        }
    }
}
