using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using HarmonyLib;
using UnityEngine;

namespace Mod_PandaWishMod
{
    [HarmonyPatch]
    internal class TraitWell_TrySetAct_wellWished_Patch
    {
        [HarmonyTranspiler]
        [HarmonyPatch(typeof(TraitWell), "TrySetAct")]
        static void Postfix(ActPlan p)
        {
            EClass.player.wellWished = false;
        }
    }
}