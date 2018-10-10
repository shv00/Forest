using UnityEngine;
using TheForest.Utils;
using TheForest.Items.Inventory;

namespace Forest.Experiment
{
    public class PlaneCrash : TriggerCutScene
    {
        public void Update()
        {
            if (Menu.TriggerPlaneScene == 1)
            {
                SpaceTut.SetActive(true);
                Clock.planecrash = true;
                Hud.enabled = false;
                LocalPlayer.Inventory.enabled = false;
                LocalPlayer.Inventory.CurrentView = PlayerInventory.PlayerViews.PlaneCrash;
                LocalPlayer.FpCharacter.enabled = false;
                LocalPlayer.FpCharacter.Locked = true;
                LocalPlayer.MainRotator.enabled = false;

                if (BoltNetwork.isClient && !ForestVR.Enabled)
                {
                    base.StartCoroutine("lockPlayerPosition");
                }
                timmySleepGo.SetActive(true);
                pmTrigger.SendEvent("begin");

                ScreenFlight.SetActive(false);
                ScreenFlightTimmy.SetActive(false);
                ScreenFlightClient.SetActive(false);
                ScreenCrash.SetActive(true);
                ScreenCrashTimmy.SetActive(true);
                ScreenCrashClient.SetActive(true);
                planeController.startCrashCameraShake();
            }
        }
    }
}
