using UnityEngine;


namespace Forest.Network
{
    public class KillEndBoss : MonoBehaviour
    {
        public static void KillBoss()
        {

            GameObject gameObject = GameObject.Find("girl_base");
            if(gameObject)
            {
                gameObject.transform.parent.SendMessage("killThisEnemey", SendMessageOptions.DontRequireReceiver);
            }
            else
            {

            }
        }
    }
}
