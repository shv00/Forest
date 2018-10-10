using Forest.Player;
using Forest.Experiment;
using Forest.Visual;
using Forest.World;
using UnityEngine;

namespace Forest
{
    public class Loader
    {
        public static GameObject _loadObject;

        public static void Load()
        {
            _loadObject = new GameObject();

            // All Componenets.
            _loadObject.AddComponent<Main>();
            _loadObject.AddComponent<Menu>();
            _loadObject.AddComponent<SpeedHack>();
            _loadObject.AddComponent<JumpHack>();
            _loadObject.AddComponent<OxygenHack>();
            _loadObject.AddComponent<SanityHack>();
            _loadObject.AddComponent<EffigyTab>();
            _loadObject.AddComponent<HealthHack>();
            _loadObject.AddComponent<ArmourHack>();
            _loadObject.AddComponent<NoFallDamage>();
            _loadObject.AddComponent<NoStarvation>();
            _loadObject.AddComponent<NoThirsty>();
            _loadObject.AddComponent<OneHit>();
            _loadObject.AddComponent<StaminaHack>();
            _loadObject.AddComponent<DaysSurvived>();
            _loadObject.AddComponent<ColdArmorHack>();
            _loadObject.AddComponent<EnergyHack>();
            _loadObject.AddComponent<InventoryHack>();
            _loadObject.AddComponent<WaterJump>();
            _loadObject.AddComponent<GodMode>();

            // Visual   
            _loadObject.AddComponent<CannibalNameESP>();
            _loadObject.AddComponent<MatVisual>();

            // World
            _loadObject.AddComponent<InstantTree>();
            _loadObject.AddComponent<ForestAtmosphere>();
            _loadObject.AddComponent<NoFog>();
            _loadObject.AddComponent<FillInventory>();
            _loadObject.AddComponent<CaveLight>();

            // Experiment
            _loadObject.AddComponent<Effigy>();
            _loadObject.AddComponent<EndGame>();
            _loadObject.AddComponent<Experiment.PlaneCrash>();
            _loadObject.AddComponent<SkpPlaneScene>();

            Object.DontDestroyOnLoad(_loadObject);

        }

        public static void Unload()
        {
            _Unload();
        }

        public static void _Unload()
        {
            Object.Destroy(_loadObject);
        }
    }
}
