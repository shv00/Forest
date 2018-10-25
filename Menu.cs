using UnityEngine;
using TheForest.Utils;

namespace Forest
{
    public class Menu : MonoBehaviour
    {
        private Rect _window;
        private Rect _window2;
        private Rect _window3;
        private Rect _window4;
        private Rect _window5;
        private Rect _window6;
        private Rect _window7;
        private Rect _window8;

        public bool Visible = true;
        public bool VisualVisible = false;
        public bool WorldVisible = false;
        public bool PlayerVisible = false;
        public bool ExperimentVisible = false;
        public bool StatOptionsVisible = false;
        public bool WorldWeatherVisible = false;
        public bool NetworkVisible = false;

        public void Start()
        {
            // Main
            _window = new Rect(10f, 10f, 250f, 150f);
            
            // Visual
            _window2 = new Rect(10f, 10f, 250f, 350f);
            
            // World Options
            _window3 = new Rect(10f, 10f, 250f, 350f);

            // Player Options
            _window4 = new Rect(10f, 10f, 350f, 450f);
            
            // Experiment
            _window5 = new Rect(10f, 10f, 350f, 350f);

            // Infinite
            _window6 = new Rect(10f, 10f, 250f, 250f);

            // Control Weather
            _window7 = new Rect(10f, 10f, 250f, 250f);

            // Network
            _window8 = new Rect(10f, 10f, 250f, 250f);
        }

        private void ToggleMenu()
        {
            if (UnityEngine.Input.GetKeyDown(KeyCode.Insert))
            {
                if (Visible)
                {
                    LocalPlayer.FpCharacter.UnLockView();
                }
                else
                {
                    LocalPlayer.FpCharacter.LockView(true);
                }
                Visible = !Visible;
            }
        }

        private void Update()
        {
            ToggleMenu();
        }

        public void OnGUI()
        {
            if (!Visible)
            {
                return;
            }

            _window = GUILayout.Window(0, _window, new GUI.WindowFunction(Draw), "The Forest v1.09", new GUILayoutOption[0]);
            if (VisualVisible)
            {
                _window2 = GUILayout.Window(1, _window2, new GUI.WindowFunction(DrawRenderOptions), "Visuals", new GUILayoutOption[0]);
            }
            if (WorldVisible)
            {
                _window3 = GUILayout.Window(2, _window3, new GUI.WindowFunction(DrawWorldOptions), "World Options", new GUILayoutOption[0]);
            }
            if (PlayerVisible)
            {
                _window4 = GUILayout.Window(3, _window4, new GUI.WindowFunction(DrawPlayerOptions), "Player Options", new GUILayoutOption[0]);
            }
            if (ExperimentVisible)
            {
                _window5 = GUILayout.Window(4, _window5, new GUI.WindowFunction(DrawExperiment), "Experiment Features", new GUILayoutOption[0]);
            }
            if (StatOptionsVisible)
            {
                _window6 = GUILayout.Window(5, _window6, new GUI.WindowFunction(DrawStatOptions), "Player Stat Options", new GUILayoutOption[0]);
            }
            if (WorldWeatherVisible)
            {
                _window7 = GUILayout.Window(6, _window7, new GUI.WindowFunction(DrawWeatherOptions), "Control Weather", new GUILayoutOption[0]);
            }
            if (NetworkVisible)
            {
                _window8 = GUILayout.Window(7, _window8, new GUI.WindowFunction(DrawNetworkOptions), "Online", new GUILayoutOption[0]);
            }
        }

        public void Draw(int id)
        {
            GUILayout.Label("F4 To add all items to ur backpack", new GUILayoutOption[0]);
            GUILayout.Label("F5 To save without sleeping place", new GUILayoutOption[0]);
            Watermark = GUILayout.Toggle(Watermark, "Watermark", new GUILayoutOption[0]);
            Crosshair = GUILayout.Toggle(Crosshair, "CrossHair", new GUILayoutOption[0]);
            GUILayout.Space(+5f);

            if (GUILayout.Button("Visuals", new GUILayoutOption[0]))
            {
                _window2.x = _window.width + 20f;
                VisualVisible = !VisualVisible;
            }

            if (GUILayout.Button("World Options", new GUILayoutOption[0]))
            {
                _window3.x = _window2.width + 20f;
                WorldVisible = !WorldVisible;
            }
            if (GUILayout.Button("Player Options", new GUILayoutOption[0]))
            {
                _window4.x = _window3.width + 20f;
                _window4.y = _window3.width + 80f;
                PlayerVisible = !PlayerVisible;
            }
            if (GUILayout.Button("Online Servers", new GUILayoutOption[0]))
            {
                _window6.x = _window5.width + 20f;
                _window6.y = _window5.width + 80f;
                NetworkVisible = !NetworkVisible;
            }
            if (GUILayout.Button("Experiment Features", new GUILayoutOption[0]))
            {
                _window5.x = _window4.width + 20f;
                _window5.y = _window4.width + 80f;
                ExperimentVisible = !ExperimentVisible;
            }

            GUILayout.Space(5f);

            if (GUILayout.Button("Unload", new GUILayoutOption[0]))
            {
                Loader.Unload();
            }

            GUI.DragWindow();
        }


        public static float SpeedMultiplier = 1f;
        public static float JumpMultiplier = 1f;
        public static int DaysSurvived = 1;
        public static bool DaysSurvivedActivate = false;

        public void DrawPlayerOptions(int id)
        {
            GUILayout.Label("Player Options:", new GUILayoutOption[0]);
            GUILayout.Space(+5f);

            if (GUILayout.Button("Player Stats", new GUILayoutOption[0]))
            {
                _window6.x = _window.width + 20f;
                StatOptionsVisible = !StatOptionsVisible;
            }

            GUILayout.Space(+10f);

            SpeedHack = GUILayout.Toggle(SpeedHack, "Speedhack", new GUILayoutOption[0]);
            SpeedMultiplier = Mathf.Round(GUILayout.HorizontalSlider(SpeedMultiplier, 0f, 50f, new GUILayoutOption[0]) * 50f) / 50f;
            JumpHack = GUILayout.Toggle(JumpHack, "JumpHack", new GUILayoutOption[0]);
            JumpMultiplier = Mathf.Round(GUILayout.HorizontalSlider(JumpMultiplier, 0f, 50f, new GUILayoutOption[0]) * 50f) / 50f;

            DaysSurvivedActivate = GUILayout.Toggle(DaysSurvivedActivate, "Change Days Survived", new GUILayoutOption[0]);
            GUILayout.Label(string.Format("Days Survived: {0}", DaysSurvived), new GUILayoutOption[0]);
            DaysSurvived = Mathf.RoundToInt(GUILayout.HorizontalSlider(DaysSurvived, 1, 5000, new GUILayoutOption[0]) * 5000 / 5000);


            WaterJump = GUILayout.Toggle(WaterJump, "Water Jump", new GUILayoutOption[0]);
            NoDamage = GUILayout.Toggle(NoDamage, "God Mode", new GUILayoutOption[0]);
            NoFallDamage = GUILayout.Toggle(NoFallDamage, "No Fall Damage", new GUILayoutOption[0]);
            InfiniteInventory = GUILayout.Toggle(InfiniteInventory, "Inf. Inventory", new GUILayoutOption[0]);

            GUILayout.Space(+5f);
            GUILayout.Label("Sets Sanity to 100%, Disables Effigy Tab Access ", new GUILayoutOption[0]);
            InfiniteSanity = GUILayout.Toggle(InfiniteSanity, "Inf. Sanity", new GUILayoutOption[0]);

            GUILayout.Space(+5f);
            GUILayout.Label("Sets Sanity to 89% all time. Disables Infinite Sanity ", new GUILayoutOption[0]);
            EffigyAccess = GUILayout.Toggle(EffigyAccess, "Effigy Tab Access", new GUILayoutOption[0]);
            GUILayout.Space(+5f);

            GUI.DragWindow();

        }

        public void DrawStatOptions(int id)
        {
            GUILayout.Label("Player Stats Options:", new GUILayoutOption[0]);
            GUILayout.Space(+5f);
            InfiniteBreath = GUILayout.Toggle(InfiniteBreath, "Inf. Breath", new GUILayoutOption[0]);
            InfiniteHealth = GUILayout.Toggle(InfiniteHealth, "Inf. Health", new GUILayoutOption[0]);
            InfiniteArmour = GUILayout.Toggle(InfiniteArmour, "Inf. Armour", new GUILayoutOption[0]);
            InfiniteColdArmor = GUILayout.Toggle(InfiniteColdArmor, "Inf. Cold Armor", new GUILayoutOption[0]);
            NoThirsty = GUILayout.Toggle(NoThirsty, "Inf. Thirst", new GUILayoutOption[0]);
            InfiniteEnergy = GUILayout.Toggle(InfiniteEnergy, "Inf. Energy", new GUILayoutOption[0]);
            InfiniteStamina = GUILayout.Toggle(InfiniteStamina, "Inf. Stamina", new GUILayoutOption[0]);
            NoStarvation = GUILayout.Toggle(NoStarvation, "No Starve", new GUILayoutOption[0]);

            GUI.DragWindow();
        }

        public void DrawRenderOptions(int id)
        {
            GUILayout.Label("Visuals Renders:", new GUILayoutOption[0]);
            GUILayout.Space(+5f);
            Visual = GUILayout.Toggle(Visual, "Visual Enable", new GUILayoutOption[0]);
            NameESP = GUILayout.Toggle(NameESP, "Name ESP", new GUILayoutOption[0]);
            GUILayout.Label(string.Format("Cannibal Distance: {0}", LoopDist), new GUILayoutOption[0]);
            LoopDist = Mathf.Round(GUILayout.HorizontalSlider(LoopDist, 0f, 5000f, new GUILayoutOption[0]) * 5000f) / 5000f;
  

            GUI.DragWindow();
        }

        public void Cave(bool inCave)
        {
            if (inCave && !LocalPlayer.IsInCaves)
            {
                LocalPlayer.GameObject.SendMessage("InACave");
            }
            else if (!inCave && LocalPlayer.IsInCaves)
            {
                LocalPlayer.GameObject.SendMessage("NotInCave");
            }
        }

        public static float CaveLight = 1f;
        public void DrawWorldOptions(int id)
        {
            GUILayout.Label("World Options:", new GUILayoutOption[0]);
            GUILayout.Space(+5f);
            // InstantBuild = GUILayout.Toggle(InstantBuild, "Instant Build", new GUILayoutOption[0]);
            NoFog = GUILayout.Toggle(NoFog, "No Fog", new GUILayoutOption[0]);

            EnableCaveLight = GUILayout.Toggle(EnableCaveLight, "Cave Light (Let there be light!)", new GUILayoutOption[0]);
            GUILayout.Label(string.Format("Cave Light Intensity: {0}", CaveLight), new GUILayoutOption[0]);
            CaveLight = Mathf.Round(GUILayout.HorizontalSlider(CaveLight, 1f, 50f, new GUILayoutOption[0]) * 50f / 50f);

            if (GUILayout.Button("Go to Cave", new GUILayoutOption[0]))
            {
                Cave(true);
            }

            GUILayout.Space(+10f);

            if (GUILayout.Button("Weather Options", new GUILayoutOption[0]))
            {
                _window7.x = _window.width + 20f;
                WorldWeatherVisible = !WorldWeatherVisible;
            }

            GUI.DragWindow();
        }

        public void DrawWeatherOptions(int id)
        {
            GUILayout.Label("Control the weather!:", new GUILayoutOption[0]);
            GUILayout.Space(+5f);

            if (GUILayout.Button("Clear Weather", new GUILayoutOption[0]))
            {
                ForceWeather = 0;
            }

            if (GUILayout.Button("Light Rain", new GUILayoutOption[0]))
            {
                ForceWeather = 1;
            }

            if (GUILayout.Button("Medium Rain", new GUILayoutOption[0]))
            {
                ForceWeather = 2;
            }

            if (GUILayout.Button("Heavy Rain", new GUILayoutOption[0]))
            {
                ForceWeather = 3;
            }
            if (GUILayout.Button("Cloudy", new GUILayoutOption[0]))
            {
                ForceWeather = 4;
            }
            if (GUILayout.Button("Light Snow", new GUILayoutOption[0]))
            {
                ForceWeather = 5;
            }
            if (GUILayout.Button("Medium Snow", new GUILayoutOption[0]))
            {
                ForceWeather = 6;
            }
            if (GUILayout.Button("Heavy Snow", new GUILayoutOption[0]))
            {
                ForceWeather = 7;
            }

            GUI.DragWindow();
        }

        public void DrawExperiment(int id)
        {
            GUILayout.Label("NOTE: Highly Experimential (May break your game)", new GUILayoutOption[0]);
            GUILayout.Space(+5f);
            if (GUILayout.Button("Trigger Plane Scene", new GUILayoutOption[0]))
            {
                TriggerPlaneScene = 1;
            }

            GUI.DragWindow();
        }

        public static bool DisableMutantController = false;

        public void DrawNetworkOptions(int id)
        {
            GUILayout.Label("Network ", new GUILayoutOption[0]);
            GUILayout.Space(+5f);

            // InstantDestory = GUILayout.Toggle(InstantDestory, "Instant Destory Buildings", new GUILayoutOption[0]);
            DisableMutantController = GUILayout.Toggle(DisableMutantController, "Disable Mutant Controller", new GUILayoutOption[0]);

            if (GUILayout.Button("Kill yourself", new GUILayoutOption[0]))
            {
                Network.KillPlayer.KillYourself();
            }

            if (GUILayout.Button("Kill all enemies", new GUILayoutOption[0]))
            {
                Network.KillAllEnemies.KillAll();
            }

            if (GUILayout.Button("Kill all animals", new GUILayoutOption[0]))
            {
                Network.KillAllAnimals.KillAll();
            }

            if (GUILayout.Button("Kill End Boss", new GUILayoutOption[0]))
            {
                Network.KillAllAnimals.KillAll();
            }

            GUI.DragWindow();
        }

        // Testing
        public static bool InstantDestory = false;
        public static bool InstantBuild = false;


        // The Forest
        public static bool Crosshair = true;

        public static bool CannibalESP = true;
        public static float LoopDist = 10;

        // Player Options
        public static bool SpeedHack = false;
        public static bool JumpHack = false;
        public static bool WaterJump = false;
         public static bool OneHit = false;
        public static bool NoDamage = false;

        public static bool EasyBuild = false;

        // public static float daySurvival = 9000;

        public static bool InfiniteBreath = false;
        public static bool InfiniteSanity = false;
        public static bool InfiniteHealth = false;
        public static bool InfiniteArmour = false;
        public static bool InfiniteColdArmor = false;
        public static bool InfiniteStamina = false;
        public static bool InfiniteEnergy = false;
        public static bool InfiniteInventory = false;

        public static bool StealthMode = false;

        public static bool NoFallDamage = false;
        public static bool NoStarvation = false;
        public static bool NoThirsty = false;

        public static bool Watermark = true;

        // Book Tab
        public static bool EffigyAccess = false;

        // World Options
        public static int ForceWeather = -1;
        public static bool FreezeWeather = false;
        public static bool EnableCaveLight = false;
        public static bool InstantTree = false;
        public static bool FreezeTime = false;
        public static bool NoFog = false;

        // Visual Options
        public static bool Visual = false;
        public static bool Mat = false;
        public static bool NameESP = false;
        public static bool Espbox = false;
        

        // Experiment?
        public static float TriggerPlaneScene = 1;
        public static bool TriggerEndGame = false;
        public static bool TriggerEffigy = false;
        public static bool TriggerSkipPlaneScene = false;
        public static bool Flying = false;

    }

}
