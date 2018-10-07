using UnityEngine;
using TheForest.Utils;

namespace Forest.Visual
{
    public class MatVisual : MonoBehaviour
    {
        public void OnGui()
        {
            if(Menu.Visual == true)
            {
                if(Menu.Mat)
                {
                    foreach (GameObject cannibals in Scene.MutantControler.activeWorldCannibals)
                    {
                        DrawMat(cannibals.transform);
                    }
                    foreach (GameObject cannibals in Scene.MutantControler.activeBabies)
                    {
                        DrawMat(cannibals.transform);
                    }
                    foreach (GameObject cannibals in Scene.MutantControler.activeCannibals)
                    {
                        DrawMat(cannibals.transform);
                    }
                    foreach (GameObject cannibals in Scene.MutantControler.activeCaveCannibals)
                    {
                        DrawMat(cannibals.transform);
                    }
                    foreach (GameObject cannibals in Scene.MutantControler.activeFamilies)
                    {
                        DrawMat(cannibals.transform);
                    }
                    foreach (GameObject cannibals in Scene.MutantControler.activeInstantSpawnedCannibals)
                    {
                        DrawMat(cannibals.transform);
                    }
                    foreach (GameObject cannibals in Scene.MutantControler.activeSkinnyCannibals)
                    {
                        DrawMat(cannibals.transform);
                    }
                }
            }
        }

        private Material mat;
        void DrawMat(Transform transform)
        {
            Vector3 screenPos = LocalPlayer.MainCam.WorldToScreenPoint(transform.position);

            if (!mat)
            {
                Shader shader = Shader.Find("Hidden/Internal-Colored");
                mat = new Material(shader);
                mat.hideFlags = HideFlags.HideAndDontSave;
                mat.SetInt("_SrcBlend", (int)UnityEngine.Rendering.BlendMode.OneMinusDstColor);
                mat.SetInt("_DstBlend", (int)UnityEngine.Rendering.BlendMode.Zero);
                mat.SetInt("_Cull", (int)UnityEngine.Rendering.CullMode.Off);
                mat.SetInt("_ZWrite", 0);
                mat.SetInt("_ZTest", (int)UnityEngine.Rendering.CompareFunction.Always);
            }

            GL.PushMatrix();
            GL.LoadOrtho();

            mat.SetPass(0);
            GL.Begin(GL.QUADS);
            GL.Vertex3(0, 0, 0);
            GL.Vertex3(1, 0, 0);
            GL.Vertex3(1, 1, 0);
            GL.Vertex3(0, 1, 0);
            GL.End();
            GL.PopMatrix();
        }
    }
}
