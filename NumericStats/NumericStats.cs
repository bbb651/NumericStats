using BepInEx;

namespace NumericStats
{
    [BepInDependency("com.willis.rounds.unbound")]
    [BepInPlugin("com.bbb651.rounds.numericstats", "NumericStats", "0.1.0")]
    [BepInProcess("Rounds.exe")]
    public class NumericStats : BaseUnityPlugin
    {
        private void Start()
        {
            On.CardInfoStat.GetSimpleAmount += (orig, self) => self.amount;
        }
    }
}