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
                this.timmySleepGo.SetActive(true);
                this.pmTrigger.SendEvent("begin");

                this.ScreenFlight.SetActive(false);
                this.ScreenFlightTimmy.SetActive(false);
                this.ScreenFlightClient.SetActive(false);
                this.ScreenCrash.SetActive(true);
                this.ScreenCrashTimmy.SetActive(true);
                this.ScreenCrashClient.SetActive(true);
                this.planeController.startCrashCameraShake();
            }
        }
    }
}
