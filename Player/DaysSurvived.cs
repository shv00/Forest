using UnityEngine;
using TheForest.Utils;


namespace Forest.Player
{
    public class DaysSurvived : MonoBehaviour
    {
        public void Start()
        {
            float days = 20;
            
            if (days < Menu.daySurvival)
            {
                LocalPlayer.Stats.DaySurvived = days;
            }
        }
    }
}
