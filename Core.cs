using Il2CppEekCharacterEngine.ConsoleV2;
using Il2CppEekUI.Achievements;
using MelonLoader;

[assembly: MelonInfo(typeof(HPAchievementsEnabler.Core), "HPAchievementsEnabler", "1.0.0", "igromanru", null)]
[assembly: MelonGame("Eek", "House Party")]

namespace HPAchievementsEnabler
{
    public class Core : MelonMod
    {
        public override void OnInitializeMelon()
        {
            LoggerInstance.Msg("Initialized");
        }

        public override void OnUpdate()
        {
            AchievementManager.Cheated = false;
            CV2.SetCheated(false);
        }
    }
}