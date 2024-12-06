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
    internal class TraitWell_TrySetAct_Fragrance_Patch
    {
        [HarmonyTranspiler]
        [HarmonyPatch(typeof(TraitWell), "<TrySetAct>b__18_0")]
        internal static IEnumerable<CodeInstruction> OnTrySetActIl(IEnumerable<CodeInstruction> instructions)
        {
            return new CodeMatcher(instructions)
                .MatchEndForward(
                    new CodeMatch(o => o.opcode == OpCodes.Callvirt &&
                                        o.operand.ToString().Contains(nameof(Player.ModKeyItem))))
                .SetInstruction(
                    Transpilers.EmitDelegate<Action<Player, string, int, bool>>((_, _, _, _) => { }))
                .InstructionEnumeration();
        }
    }
}