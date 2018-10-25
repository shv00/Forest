using UnityEngine;
using TheForest.Utils;


namespace Forest.Player
{
    public class DaysSurvived : MonoBehaviour
    {

        private float baseDaysSurvived;

        private void GameStandardValues()
        {
            baseDaysSurvived = LocalPlayer.Stats.DaySurvived;
        }

        private void Start()
        {
            GameStandardValues();
        }

        private void Update()
        {   
            if (Menu.DaysSurvivedActivate)
            {
                LocalPlayer.Stats.DaySurvived = baseDaysSurvived * Menu.DaysSurvived;
            } else
            {
                GameStandardValues();
            }
        }
        
    }
}
