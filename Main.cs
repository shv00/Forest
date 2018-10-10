using Forest;
using UnityEngine;
using TheForest.Utils;

namespace Forest
{
    public class Main : MonoBehaviour
    {
        private void Update()
        {
            if(UnityEngine.Input.GetKey(KeyCode.Delete))
            {
                Loader.Unload();
            }
        }

        private void OnGUI()
        {
            if(Menu.Watermark)
            {
                if (LocalPlayer.IsInWorld)
                {
                    GUI.Label(new Rect(20, 20, 200, 60), "Unknowncheats.me | Shv00");
                }
            }

            if(LocalPlayer.IsInWorld)
            {
                if (Menu.Crosshair)
                {
                    Render.DrawBox(new Vector2((float)Screen.width / 2f, (float)Screen.height / 2f - 7f), new Vector2(1, 15), Color.green);
                    Render.DrawBox(new Vector2((float)Screen.width / 2f - 7f, (float)Screen.height / 2f), new Vector2(15, 1), Color.green);
                }
            }
        }

    }

}
