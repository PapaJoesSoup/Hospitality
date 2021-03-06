using HarmonyLib;
using RimWorld;
using Verse;

namespace Hospitality.Harmony
{
    internal static class FoodUtility_Patch
    {
        /// <summary>
        /// So guests will care
        /// </summary>
        [HarmonyPatch(typeof(FoodUtility), "BestFoodSourceOnMap")]
        public class BestFoodSourceOnMap
        {
            [HarmonyPrefix]
            public static bool Prefix(ref Thing __result, Pawn eater, bool desperate)
            {
                if (!eater.IsGuest()) return true;
                return desperate;
            }
        }
    }
}

    
