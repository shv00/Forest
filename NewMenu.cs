using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Forest
{
    public class NewMenu : MonoBehaviour
    {
        private int iTabSelected = 0;

        public void OnGUI()
        {
            GUILayout.BeginVertical();
            {
                GUILayout.BeginHorizontal();
                {

            }
                GUILayout.EndHorizontal();
                DoGUI(iTabSelected);
            }
            GUILayout.EndVertical();

        }

        private void DoGUI(int iTabSelected)
        {
            if (iTabSelected == 0)
            {
                //Draw some control
            }

            if (iTabSelected == 1)
            {
                //Draw some control
            }
        }
    }
}
