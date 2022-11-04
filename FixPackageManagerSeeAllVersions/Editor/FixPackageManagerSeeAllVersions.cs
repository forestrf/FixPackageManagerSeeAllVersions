#if UNITY_2021_1_OR_NEWER
using Harmony;
using System.Reflection;
using UnityEditor;
using UnityEngine;

public class FixPackageManagerSeeAllVersions {
	static HarmonyInstance harmony;

	[InitializeOnLoadMethod]
	static void Init() {
		Patch();
	}

	static void Patch() {
		MethodInfo Method_IsDeveloperBuild = typeof(Unsupported).GetMethod("IsDeveloperBuild", BindingFlags.Static | BindingFlags.Public);

		if (Method_IsDeveloperBuild == null) {
			Debug.LogWarning("Can't find the method Unsupported.IsDeveloperBuild(). Patching won't be done.");
			return;
		}

		if (harmony == null) harmony = HarmonyInstance.Create("com.Nukefist.Ashkatchap.FixPackageManagerSeeAllVersions");
		else harmony.UnpatchAll();

		harmony.Patch(Method_IsDeveloperBuild, prefix: new HarmonyMethod(typeof(FixPackageManagerSeeAllVersions), "ReturnTrue"));
	}

	static bool ReturnTrue(ref bool __result) {
		__result = true;
		return false;
	}
}
#endif
