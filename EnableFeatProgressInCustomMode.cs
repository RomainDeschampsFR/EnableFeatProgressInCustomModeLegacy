using MelonLoader;
using UnityEngine;
using Il2CppInterop;
using Il2CppInterop.Runtime.Injection; 
using System.Collections;
using HarmonyLib;
using Il2Cpp;

namespace EnableFeatProgressInCustomMode
{
	public class Mod : MelonMod
	{
		public override void OnInitializeMelon()
		{           
			 Debug.Log($"[{Info.Name}] Version {Info.Version} loaded!");
        }
    }
	
	internal static class Patches 
	{

		[HarmonyPatch(typeof(Feat), "ShouldBlockIncrement")]
		private static class NeverBlockIncrement 
		{
			private static void Postfix(ref bool __result) 
			{
				__result = false;
			}
		}
	}
}