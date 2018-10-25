using UnityEngine;

namespace Forest.Network
{
    public class KillAllAnimals : MonoBehaviour
    {
        public static void KillAll()
        {
            animalHealth[] array = FindObjectsOfType<animalHealth>();
            animalHealth[] array2 = array;
            for (int i = 0; i < array2.Length; i++)
            {
                animalHealth animalHealth = array2[i];
                if (animalHealth.gameObject.activeInHierarchy)
                {
                    animalHealth.SendMessage("Die");
                }
            }

            lb_Bird[] arrayB = FindObjectsOfType<lb_Bird>();
            lb_Bird[] arrayB2 = arrayB;
            for (int i = 0; i < arrayB2.Length; i++)
            {
                lb_Bird birdHealth = arrayB2[i];
                if (birdHealth.gameObject.activeInHierarchy)
                {
                    birdHealth.SendMessage("die");
                }
            }
        }
    }
}
