using MelonLoader;

[assembly: MelonInfo(typeof(HPAchievementsEnabler.Core), "HPAchievementsEnabler", "1.0.0", "igromanru", null)]
[assembly: MelonGame("Eek", "House Party")]

namespace HPAchievementsEnabler
{
    public class Core : MelonMod
    {
        public override void OnInitializeMelon()
        {
            LoggerInstance.Msg("Initialized.");
        }
    }
}