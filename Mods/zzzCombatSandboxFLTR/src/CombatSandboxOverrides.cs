using GearsAPI.Settings;
using GearsAPI.Settings.Global;
using GearsAPI.Settings.World;
using HarmonyLib;
using System.Reflection;

namespace CombatSandboxOverrides;

[Harmony]
public class CombatSandboxOverrides : IModApi
{
    public static bool Applied = false;
    public void InitMod(Mod _modInstance)
    {
        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), "com.byteblazar.combatsandboxoverrides");
    }

    [HarmonyFinalizer]
    [HarmonyPatch(typeof(XUiC_MainMenu), nameof(XUiC_MainMenu.OnOpen))]
    public static void Finalizer_OnOpen()
    {
        Applied = false;
    }

    public static ItemAction.RepairTypes? backup;

    [HarmonyFinalizer]
    [HarmonyPatch(typeof(EntityPlayerLocal), nameof(EntityPlayerLocal.AfterPlayerRespawn))]
    public static void Finalizer_AfterPlayerRespawn()
    {
        if (Applied) return;
        Applied = true;

        backup = null;
        ApplyRepairOverride();
    }

    public static void ApplyRepairOverride(string? option = null)
    {
        try
        {
            backup ??= ItemAction.RepairType;
            option ??= Config.GetPropertyValue("Overrides", "CombineStationRepairs");
            if (!string.IsNullOrWhiteSpace(option) && option.ToLowerInvariant() == "no")
            {
                ItemAction.RepairType = ItemAction.RepairTypes.RepairOnly;
                Log.Out($"[Combat Sandbox] Disabled Combine Station repairs.");
            }
            else
            {
                ItemAction.RepairType = (ItemAction.RepairTypes)backup;
                Log.Out($"[Combat Sandbox] Combine Station repairs restored.");
            }
        }
        catch (Exception e)
        {
            Log.Out($"[Combat Sandbox] Failed to apply hardcoded-features.xml.\n{e.Message}");
        }
    }
}

public class Gears : IGearsModApi
{
    public void InitMod(IGearsMod modInstance) { }

    public void OnGlobalSettingsLoaded(IModGlobalSettings modSettings)
    {
        // Main Tab
        var tabMain = modSettings.GetTab("RestrictedRunSettings");

        var catRepair = tabMain.GetCategory("AllWeaponsRepairDegradationCategory");
        var selRepairType = catRepair.GetSetting("Enable_AllWeapons_Repair_CombineStation") as ISwitchGlobalSetting;

        selRepairType.OnSettingChanged += (s, e) =>
        {
            if (CombatSandboxOverrides.Applied)
                CombatSandboxOverrides.ApplyRepairOverride(e);
        };

        selRepairType.Enabled = !CombatSandboxOverrides.Applied || Utils.IsOfflineSingleplayer || Utils.IsHost;
    }

    public void OnWorldSettingsLoaded(IModWorldSettings worldSettings) { }
}
