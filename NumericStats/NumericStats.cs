using BepInEx;
using BepInEx.Logging;
using UnboundLib;
using UnityEngine;

namespace NumericStats
{
    [BepInDependency("com.willis.rounds.unbound")]
    [BepInPlugin("com.bbb651.rounds.numericstats", "NumericStats", "0.1.0")]
    [BepInProcess("Rounds.exe")]
    public class NumericStats : BaseUnityPlugin
    {
        private void Awake()
        {
            Logger.Log(LogLevel.Info, "Hello world from NumericStats!");
        }
    }
}