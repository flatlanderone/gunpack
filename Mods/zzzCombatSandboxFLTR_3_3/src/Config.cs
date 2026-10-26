namespace CombatSandboxOverrides;

/* Credit to SphereII for this class */
public static class Config
{
	private static readonly List<string> requiredModletsCache = new();
	public const string cfg = "CombatSandboxConfig";

	public static bool CheckFeatureStatus(string strFeature)
	{
		BlockValue ConfigurationFeatureBlock = Block.GetBlockValue(cfg);
		if (ConfigurationFeatureBlock.type == 0)
			return false;

		bool result = false;
		if (ConfigurationFeatureBlock.Block.Properties.Contains(strFeature))
			result = ConfigurationFeatureBlock.Block.Properties.GetBool(strFeature);

		return result;
	}

	public static bool RequiredModletAvailable(string strClass)
	{
		// Check if the feature has a required modlet defined.
		string requiredModlet = GetPropertyValue(strClass, "RequiredModlet");

		// None? pass through the results.
		if (string.IsNullOrEmpty(requiredModlet)) return true;

		string[] requiredModlets = requiredModlet.Split(',');
		foreach (string? requiredMod in requiredModlet.Split(','))
		{
			if (!ModManager.ModLoaded(requiredMod))
			{
				if (requiredModletsCache.Contains(requiredMod)) return false;
				requiredModletsCache.Add(requiredMod);
				Log.Out($"WARN: RequiredModlet is defined on {strClass}: {requiredMod} not found. Feature is turned off.");
				return false;
			}
		}

		return true;
	}

	public static bool CheckFeatureStatus(string strClass, string strFeature, bool checkCVarFirst = false)
	{
		EntityPlayerLocal localPlayer = GameManager.Instance.myEntityPlayerLocal;
		if (localPlayer != null && checkCVarFirst)
		{
			string cvarName = $"{strClass}_{strFeature}";
			if (localPlayer.Buffs.HasCustomVar(cvarName))
			{
				if (localPlayer.Buffs.GetCustomVar(cvarName) > 0)
					return true;
			}
		}

		BlockValue ConfigurationFeatureBlock = Block.GetBlockValue(cfg);
		if (ConfigurationFeatureBlock.type == 0)
			return false;


		bool result = false;
		if (ConfigurationFeatureBlock.Block.Properties.Classes.ContainsKey(strClass))
		{
			DynamicProperties dynamicProperties3 = ConfigurationFeatureBlock.Block.Properties.Classes[strClass];
			foreach (KeyValuePair<string, string> keyValuePair in dynamicProperties3.Values)
			{
				if (string.Equals(keyValuePair.Key, strFeature, StringComparison.CurrentCultureIgnoreCase))
					result = StringParsers.ParseBool(dynamicProperties3.Values[keyValuePair.Key]);
			}
		}

		if (result)
			result = RequiredModletAvailable(strClass);


		return result;
	}

	public static string GetPropertyValue(string strClass, string strFeature)
	{
		BlockValue ConfigurationFeatureBlock = Block.GetBlockValue(cfg);
		if (ConfigurationFeatureBlock.type == 0)
			return string.Empty;


		string result = string.Empty;
		if (ConfigurationFeatureBlock.Block.Properties.Classes.ContainsKey(strClass))
		{
			DynamicProperties dynamicProperties3 = ConfigurationFeatureBlock.Block.Properties.Classes[strClass];
			foreach (KeyValuePair<string, string> keyValuePair in dynamicProperties3.Values)
			{
				if (keyValuePair.Key == strFeature)
					return keyValuePair.Value.ToString();
			}
		}

		return result;
	}
}
