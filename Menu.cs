using UnityEngine;

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

        public bool Visible = true;
        public bool VisualVisible = false;
        public bool WorldVisible = false;
        public bool PlayerVisible = false;
        public bool ExperimentVisible = false;
        public bool StatOptionsVisible = false;
        public bool WorldWeatherVisible = false;

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
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Insert))
            {
                Visible = !Visible;
            }
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
        }

        public void Draw(int id)
        {
            GUILayout.Label("F4 To add all items to ur backpack", new GUILayoutOption[0]);
            Menu.Watermark = GUILayout.Toggle(Menu.Watermark, "Watermark", new GUILayoutOption[0]);
            Menu.Crosshair = GUILayout.Toggle(Menu.Crosshair, "CrossHair", new GUILayoutOption[0]);
            GUILayout.Space(+5f);

            if (GUILayout.Button("Visuals", new GUILayoutOption[0]))
            {
                _window2.x = _window.width + 20f;
                VisualVisible = !VisualVisible;
            }

            if (GUILayout.Button("World Options", new GUILayoutOption[0]))
            {
                _window3.x = _window2.width + 300f;
                WorldVisible = !WorldVisible;
            }
            if (GUILayout.Button("Player Options", new GUILayoutOption[0]))
            {
                _window4.x = _window3.width + 20f;
                _window4.y = _window3.width + 80f;
                PlayerVisible = !PlayerVisible;
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

        public void DrawPlayerOptions(int id)
        {
            GUILayout.Label("Player Options:", new GUILayoutOption[0]);
            GUILayout.Space(+5f);

            GUILayout.Label("(Dont hold shift while you speed around)", new GUILayoutOption[0]);
            Menu.SpeedHack = GUILayout.Toggle(Menu.SpeedHack, "Speedhack", new GUILayoutOption[0]);

            if (GUILayout.Button("Player Stats", new GUILayoutOption[0]))
            {
                _window6.x = _window.width + 20f;
                StatOptionsVisible = !StatOptionsVisible;
            }

            GUILayout.Space(+10f);

            Menu.JumpHack = GUILayout.Toggle(Menu.JumpHack, "JumpHack", new GUILayoutOption[0]);
            Menu.WaterJump = GUILayout.Toggle(Menu.WaterJump, "Water Jump", new GUILayoutOption[0]);
            // Menu.OneHit = GUILayout.Toggle(Menu.OneHit, "One Hit (One Punch man)", new GUILayoutOption[0]);
            Menu.GodMode = GUILayout.Toggle(Menu.GodMode, "God Mode", new GUILayoutOption[0]);
            Menu.NoFallDamage = GUILayout.Toggle(Menu.NoFallDamage, "No Fall Damage", new GUILayoutOption[0]);
            Menu.InfiniteInventory = GUILayout.Toggle(Menu.InfiniteInventory, "Inf. Inventory", new GUILayoutOption[0]);

            GUILayout.Space(+5f);
            GUILayout.Label("Sets Sanity to 100%, Disables Effigy Tab Access ", new GUILayoutOption[0]);
            Menu.InfiniteSanity = GUILayout.Toggle(Menu.InfiniteSanity, "Inf. Sanity", new GUILayoutOption[0]);

            GUILayout.Space(+5f);
            GUILayout.Label("Sets Sanity to 89% all time. Disables Infinite Sanity ", new GUILayoutOption[0]);
            Menu.EffigyAccess = GUILayout.Toggle(Menu.EffigyAccess, "Effigy Tab Access", new GUILayoutOption[0]);
            GUILayout.Space(+5f);

            GUI.DragWindow();

        }

        public void DrawStatOptions(int id)
        {
            GUILayout.Label("Player Stats Options:", new GUILayoutOption[0]);
            GUILayout.Space(+5f);
            Menu.InfiniteBreath = GUILayout.Toggle(Menu.InfiniteBreath, "Inf. Breath", new GUILayoutOption[0]);
            Menu.InfiniteHealth = GUILayout.Toggle(Menu.InfiniteHealth, "Inf. Health", new GUILayoutOption[0]);
            Menu.InfiniteArmour = GUILayout.Toggle(Menu.InfiniteArmour, "Inf. Armour", new GUILayoutOption[0]);
            Menu.InfiniteColdArmor = GUILayout.Toggle(Menu.InfiniteColdArmor, "Inf. Cold Armor", new GUILayoutOption[0]);
            Menu.NoThirsty = GUILayout.Toggle(Menu.NoThirsty, "Inf. Thirst", new GUILayoutOption[0]);
            Menu.InfiniteEnergy = GUILayout.Toggle(Menu.InfiniteEnergy, "Inf. Energy", new GUILayoutOption[0]);
            Menu.InfiniteStamina = GUILayout.Toggle(Menu.InfiniteStamina, "Inf. Stamina", new GUILayoutOption[0]);
            Menu.NoStarvation = GUILayout.Toggle(Menu.NoStarvation, "No Starve", new GUILayoutOption[0]);

            GUI.DragWindow();
        }

        public void DrawRenderOptions(int id)
        {
            GUILayout.Label("Visuals Renders:", new GUILayoutOption[0]);
            GUILayout.Space(+5f);
            Menu.Visual = GUILayout.Toggle(Menu.Visual, "Visual Enable", new GUILayoutOption[0]);
            Menu.Mat = GUILayout.Toggle(Menu.Mat, "Mate Visual", new GUILayoutOption[0]);
            Menu.NameESP = GUILayout.Toggle(Menu.NameESP, "Name ESP", new GUILayoutOption[0]);
            Menu.Espbox = GUILayout.Toggle(Menu.Espbox, "Esp Box", new GUILayoutOption[0]);
            GUILayout.Label(string.Format("Cannibal Distance: {0}", Menu.LoopDist), new GUILayoutOption[0]);
            Menu.LoopDist = Mathf.Round(GUILayout.HorizontalSlider(Menu.LoopDist, 0f, 5000f, new GUILayoutOption[0]) * 5000f) / 5000f;
  

            GUI.DragWindow();
        }


        public void DrawWorldOptions(int id)
        {
            GUILayout.Label("World Options:", new GUILayoutOption[0]);
            GUILayout.Space(+5f);
            // Menu.InstantTree = GUILayout.Toggle(Menu.InstantTree, "Instant Tree (Chuck Nories)", new GUILayoutOption[0]);
            Menu.NoFog = GUILayout.Toggle(Menu.NoFog, "No Fog", new GUILayoutOption[0]);
            Menu.EnableCaveLight = GUILayout.Toggle(Menu.EnableCaveLight, "Cave Light (Let there be light!)", new GUILayoutOption[0]);

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
            Menu.TriggerEndGame = GUILayout.Toggle(Menu.TriggerEndGame, "Trigger End Game", new GUILayoutOption[0]);
            Menu.TriggerEffigy = GUILayout.Toggle(Menu.TriggerEffigy, "TriggerEffigy", new GUILayoutOption[0]);
            Menu.TriggerSkipPlaneScene = GUILayout.Toggle(Menu.TriggerSkipPlaneScene, "Skip Plane Scene", new GUILayoutOption[0]);
            Menu.Flying = GUILayout.Toggle(Menu.Flying, "Fly around", new GUILayoutOption[0]);


            GUI.DragWindow();
        }

        // The Forest
        public static bool Crosshair = true;

        public static bool CannibalESP = true;
        public static float LoopDist = 10;

        // Player Options
        public static bool SpeedHack = false;
        public static bool JumpHack = false;
        public static bool WaterJump = false;
        // public static bool OneHit = false;
        public static bool GodMode = false;

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
        // public static bool InstantTree = false;
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
