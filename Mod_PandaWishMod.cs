using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BepInEx;
using HarmonyLib;

namespace PandaWishMod
{
    [BepInPlugin("panda.wish.mod", "Panda's Wish Mod", "1.0.0.0")]
    public class Mod_PandaWishMod : BaseUnityPlugin
    {
        private void Start()
        {
            var harmony = new Harmony("Panda's Wish Mod");
            harmony.PatchAll();
        }
    }
}
