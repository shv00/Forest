using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using TheForest.Utils;
using System.Collections;

namespace Forest.Visual
{
    public class CannibalNameESP : MonoBehaviour 
    {
        IEnumerator SleepFor(float Time)
        {
            yield return new WaitForSeconds(Time);
        }

        public void OnGUI()
        {
            if (Menu.Visual == true)
            {
                if (Menu.NameESP && LocalPlayer.IsInWorld)
                {

                            foreach (GameObject cannibals in Scene.MutantControler.activeWorldCannibals)
                            {
                                DrawESP(cannibals.transform);
                            }
                            foreach (GameObject cannibals in Scene.MutantControler.activeBabies)
                            {
                                DrawESP(cannibals.transform);
                            }
                            foreach (GameObject cannibals in Scene.MutantControler.activeCannibals)
                            {
                                DrawESP(cannibals.transform);
                            }
                            foreach (GameObject cannibals in Scene.MutantControler.activeCaveCannibals)
                            {
                                DrawESP(cannibals.transform);
                            }
                            foreach (GameObject cannibals in Scene.MutantControler.activeFamilies)
                            {
                                DrawESP(cannibals.transform);
                            }
                            foreach (GameObject cannibals in Scene.MutantControler.activeInstantSpawnedCannibals)
                            {
                                DrawESP(cannibals.transform);
                            }
                            foreach (GameObject cannibals in Scene.MutantControler.activeSkinnyCannibals)
                            {
                                DrawESP(cannibals.transform);
 
                    }
                }
            }

        }

        void DrawESP(Transform transform)
        {
            Vector3 screenPos = LocalPlayer.MainCam.WorldToScreenPoint(transform.position);
            Vector3 pos = LocalPlayer.Transform.position;

            if (screenPos.z > 0 & screenPos.y < Screen.width - 2)
            {
                float dist = Vector3.Distance(pos, LocalPlayer.Transform.position);
                if (dist < Menu.LoopDist)
                {
                    screenPos.y = Screen.height - (screenPos.y + 1f);
                    Render.DrawString(new Vector2(screenPos.x, screenPos.y), (" Cannibal"), Color.cyan);
                }
                SleepFor(0.300f);
            }
            SleepFor(0.300f);
        }
        
    }
}
