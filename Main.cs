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
            if (LocalPlayer.IsInWorld)
            {
                if(Menu.Watermark)
                {
                    GUI.Label(new Rect(20, 20, 200, 60), "UnKnoWnCheaTs.me | Shv00");
                }

                if (Menu.Crosshair)
                {
                    Render.DrawBox(new Vector2(Screen.width / 2f, Screen.height / 2f - 7f), new Vector2(1, 15), Color.green);
                    Render.DrawBox(new Vector2(Screen.width / 2f - 7f, Screen.height / 2f), new Vector2(15, 1), Color.green);
                }
            }
        }

    }

}
