# Flatlander's Fixes and Tweaks for IZY-All in One Gun Pack v5.1.3 released on 2026-04-14 - version 2.6.1.5

## Overview

The **Flatlander's Fixes and Tweaks for IZY-All in One Gun Pack** mod provides fixes, tweaks and enhancements for the IZY-All in One Gun Pack (hereafter the "IGP") v2.6.5.1.3 released on 2026-04-14 on Nexus Mods. 

Several optional enhancements, including the "No Kick" option, are managed exclusively through the Gears mod interface. In order to access these optional enhancements, you must install the Gears mod and the Quartz mod.

See Changelog below for a full list of changes and additions.

## Requirements

 - [IZY-All in One Gun Pack v2.6.5.1.3 released on 2026-04-14 on Nexus Mods](https://www.nexusmods.com/7daystodie/mods/5458),
 - [Gears 6.0.0 or later](https://www.nexusmods.com/7daystodie/mods/4017),
 - [Quartz 7.0.0 or later](https://www.nexusmods.com/7daystodie/mods/2409),
 - 7 Days to Die v2.6 and later.

## Manual installation

 1. Download the mod file.
 2. Unzip it anywhere on your hard drive.
 3. Copy the zzz\_IZYAIOGunPackv51\_FIXES\_FLTR folder to the 7 Days to Die Mods folder. The default location is **%APPDATA%\7DaysToDie\Mods**.
 4. The mod must load after all the IGP mods, patches and extensions.
 5. Download and install the required Gears and Quartz mods.

## Important notes

 1. The 2.6.1.5 version of the mod is designed to work with the **2.6.5.1.3** version of the IGP released on 2026-04-14. Check the version of your IGP. NO OTHER VERSION WILL BE SUPPORTED.
 2. If you are still on the previous **5.1** version of the IGP, DO NOT INSTALL THE 2.6.1.5 VERSION OF THIS MOD. Use the 2.6.1.0 version of this mod instead.
 3. Do not bother Izayo with questions regarding this mod. 
 4. Adding the mod to an existing save is probably safe, but you should always make a backup of your game save.
 5. Removing the mod is probably safe, but you should always make a backup of your game save.
 6. If you change the settings through the Gears interface, you must restart the game for the changes to take effect. 

## Bug reports and feature suggestions

 - [GitHub](https://github.com/flatlanderone/gunpack/issues) (preferred).
 - [My channel on Guppy's Modding Server](https://discord.gg/yPFh79rq8J),
 - This mod's page on Nexus Mods.

## About this mod

 - **Author**: Flat Lander - [GitHub](https://github.com/flatlanderone/flatlander-releases) / [Nexus Mods](https://next.nexusmods.com/profile/flatlanderone)
 - **Download page**: [Flatlander's Fixes for IZY-All in One Gun Pack v5.1 and v2.6.5.1.3](https://www.nexusmods.com/7daystodie/mods/9980)
 - **Initial release**: 2.5.1.0 (2026-03-30)
 - **Previous releases**: 2.6.1.0 (2026-04-12), 2.6.1.1 (2026-04-15), 2.6.1.2 (2026-04-17), 2.6.1.3 (2026-04-22), 2.6.1.4 (2026-04-29).
 - **This release**: 2.6.1.5 (2026-05-xx)

# Changelog for 2.6.1.5 (2026-0x-xx)

## Notes

## Known issues

## Planned features



# Changelog for 2.6.1.4 (2026-04-29)

## Notes

 - The main feature of this update is the ability to disable kick attack. Read below for more details.
 - This update introduces three new sets of options (Kick Attack, Weapon Packs, Tier 4 Weapons) that are managed exclusively through the Gears interface. Read below for more details. 
 - Minor localization fixes have been implemented.
 - All bug fixes from previous versions of the patch remain in place.

## Known issues

 - Issues (A) and (B) from 2.6.1.3 are still occurring.
 - Issue (C) from 2.6.1.3 is resolved in 2.6.1.4.
 - See https://github.com/flatlanderone/gunpack/issues?q=is%3Aissue%20state%3Aopen%20label%3Abug for a full list of unresolved issues. 

## Planned features

See https://github.com/flatlanderone/gunpack/issues?q=is%3Aissue%20state%3Aopen%20label%3A2.6.1.5 for a list of planned fixes and enhancements.

### How to use Gears

 - To manage the new settings introduced in this update, click on 'Mods' in the 'Main Menu' of the game and select this mod's entry in the left-hand panel.
 - Each set of options is managed in its own tab in the right-hand panel. 
 - After changing the settings, click 'Apply'.
 - Click 'Defaults', then 'Apply' to restore the settings to their default values. 
 
## New Settings

The new settings introduced in this update present as follows:

### 1. Kick Attack

The IGP added the kick attack only to some vanilla firearms and two harvesting tools.

This update adds the option:
- to enable the kick attack for the remaining vanilla firearms, the bows/crossbows and all the tools,
- to disable the kick attack per item group.

By default, the kick attack is already ENABLED for:
 - All vanilla and IGP handguns, rifles, submachine guns, machine guns and grenade launchers,
 - All vanilla and IGP bows and crossbows.

The kick attack is by default DISABLED for all IGP and vanilla melee weapons and tools.

Select 'Kick On' or 'Kick Off' for each group. By selecting 'Kick Off', you will disable the kick attack for the selected group.

### 2. Weapon Packs

This update adds the option to disable the various weapon packs that make up the IGP. Weapons and ammo from disabled weapon packs will not appear in loot. You will not be able to craft them nor buy them from the traders. However the weapons and ammo are not removed from the game and can be spawned using the 'Creative Menu'. 

Click 'Off' to disable the chosen weapon pack. Click 'On' to enable it again.

Note that the Vanilla Replacer Pack and other packs cannot currently be disabled.

### 3. Tier 4 Weapons

This update adds the option to modify your gameplay experience with Tier 4 Weapons. You can:
 - disable the crafting of these weapons,
 - prevent them from appearing in loot containers,
 - prevent them from appearing in trader inventory,
 - disable the possibility to repair them,
 - accelerate the rate at which they degrade up to 500%.

By default these options are not active.

## 7 Days To Die 2.6 / IZY_VRP

### Options/items.xml (managed by Gears, see above)
 - Added kick to the following vanilla guns, launchers, bows, melee weapons amd tools:
   - gunBowT0PrimitiveBow
   - gunBowT1WoodenBow
   - gunBowT1IronCrossbow
   - gunBowT3CompoundCrossbow 
   - gunRifleT0PipeRifle
   - gunHandgunT0PipePistol
   - gunShotgunT0PipeShotgun
   - gunRifleT1HuntingRifle
   - gunExplosivesT3RocketLauncher
   - meleeWpnBladeT0BoneKnife
   - meleeWpnBladeT1HuntingKnife
   - meleeWpnBladeT1CandyKnife
   - meleeWpnBladeT3Machete
   - meleeWpnClubT0WoodenClub
   - meleeWpnClubT1BaseballBat
   - meleeWpnClubT1CandyClub
   - meleeWpnClubT3SteelClub
   - meleeWpnBatonT0PipeBaton
   - meleeWpnBatonT2StunBaton
   - meleeWpnSpearT0StoneSpear
   - meleeWpnSpearT1IronSpear
   - meleeWpnSpearT3SteelSpear
   - meleeWpnSledgeT0StoneSledgehammer
   - meleeWpnSledgeT1IronSledgehammer
   - meleeWpnSledgeT3SteelSledgehammer
   - meleeWpnKnucklesT0LeatherKnuckles
   - meleeWpnKnucklesT1IronKnuckles
   - meleeWpnKnucklesT3SteelKnuckles
   - meleeToolRepairT0StoneAxe
   - meleeToolRepairT0TazasStoneAxe
   - meleeToolRepairT1ClawHammer
   - meleeToolRepairT3Nailgun
   - meleeToolAxeT1IronFireaxe
   - meleeToolPickT1IronPickaxe
   - meleeToolShovelT0StoneShovel
   - meleeToolShovelT1IronShovel
   - meleeToolShovelT2SteelShovel
   - meleeToolAxeT3Chainsaw
   - meleeToolPickT3Auger
   - meleeToolSalvageT1Wrench
   - meleeToolSalvageT2Ratchet
   - meleeToolSalvageT3ImpactDriver
   - meleeToolTorch

## IZY_melee

### loot.xml
- Added IZYMeleeT4BladeKatana to groupWeaponsT2_Melee and groupQuestWeaponsMeleeT2.

## IZY_RMP_44magnum

### loot.xml:
 - Added IZYgunT3PistolMagnumAutomag44 and IZYgunT4DualMagnumDesertEagles to loot.

## IZY_RMP_45ACP

### items.xml
 - Fixed IZYgunT0PistolLiberatorImprovisedPistol high kick.

### loot.xml
 - Added missing IZYgunT1Pistol45Type17C96 entry to groupQuestWeaponsRangedT1.

## IZY_RMP_9mmVAL

### loot.xml
 - Added missing IZYgunT1Pistol9Makarov entries to groupWeaponsT1_Gunslinger, groupQuestWeaponsRangedT1 and groupWeaponsT1_Ranged.

## IZY_RMP_Miscpack

### traders.xml
 - Removed ammoMuzzleloaderscattershot from trader inventory.

## IZY_RMP_Tech

### loot.xml
 - Added IZYgunT3TechnicalNailmachinegun to loot groups.

# Changelog for 2.6.1.3 (2026-04-22)

## Notes

 - This is a hotfix release to remove the ability to kick while crouching and sneaking for several weapons across multiple weapon packs. Big thanks to Nexus user HatomugiBread for bringing my attention to this issue.
 - Additional localization changes were implemented to ensure a consistent presention for all weapon types.
 - The description panel of all special ammo types (Enhanced .45 ACP, Light Bolts, 7.62mm Explosive Ammo, 25mm Grenades, 40mm Grenades) contains information about compatible weapons. Thank you to Black Wolf for bringing this to my attention.
 - The weapon description template was further tweaked to enhance readability and prepare the ground for the planned automation of certain fields.
 - All bug fixes from previous versions of the patch remain in place.
 
## Known issues

 - (A) When holding the majority of vanilla weapons from the IZY_VRP pack, the player is unable to switch off the weapon flashlight. Also the flashlight starts turned on. I am investigating the cause and the possible fixes.
 - (B) Pressing F while crouching affects the stealth meter even when the weapon doesn't have a flashlight.
 - (C) Several weapons do not have the kick feature, notably the following vanilla weapons: 
   - gunBowT0PrimitiveBow
   - gunBowT1WoodenBow
   - gunBowT1IronCrossbow
   - gunBowT3CompoundCrossbow 
   - gunRifleT0PipeRifle
   - gunHandgunT0PipePistol
   - gunShotgunT0PipeShotgun
   - gunRifleT1HuntingRifle
   - gunExplosivesT3RocketLauncher
 - See https://github.com/flatlanderone/gunpack/issues?q=is%3Aissue%20state%3Aopen%20label%3A%22Base%20IGP%20issue%22 for more information on issues that require an update of the base IGP files.
   
## 7 Days To Die 2.6

### items.xml 
- Added ammoShotgunShellPremium compatibility for the vanilla shotguns:
   - gunShotgunT0PipeShotgun
   - gunShotgunT1DoubleBarrel
   - gunShotgunT2PumpShotgun
   - gunShotgunT3AutoShotgun

## IZY_melee

### items.xml
 - Removed the ability to kick while crouching for the following weapons: 
   - IZYMeleeT4SpearPoleAxe
   - IZYMeleeT4BladeKatana
   - IZYMeleeT4SledghammerSpikeMace
 
## IZY_VRP
 
### items.xml
 - Removed the ability to kick while crouching for the following weapons: 
   - gunHandgunT1Pistol
   - gunHandgunT3SMG5
   - gunHandgunT2Magnum44
   - gunHandgunT3DesertVulture
   - gunShotgunT1DoubleBarrel
   - gunShotgunT2PumpShotgun
   - gunShotgunT3AutoShotgun
   - gunRifleT2LeverActionRifle
   - gunRifleT3SniperRifle
   - gunMGT1AK47
   - gunMGT2TacticalAR
   - gunMGT3M60
 
## IZY_RMP_556pack

### items.xml
 - Removed the ability to kick while crouching for the following weapons: 
   - IZYgunT0SNIPERpipeAR15Broken15Junk
   - IZYgunT3MarksManRifle556M16A2DMR

## IZY_RMP_SG

### items.xml
 - Removed the ability to kick while crouching for the IZYgunT1TACCompactshotgunSuperShortty.

## IZY_RMP_Miscpack

### items.xml
 - Removed the ability to kick while crouching for the IZYgunTminus1MusketM1777Rifle.
 - ammoMuzzleloadershot display changed from ammoBullet to ammoBulletAP.
 
## IZY_RMP_762pack

### items.xml 
  - ammo762mmExplosiveFragmentations display changed from ammoBullet to ammoBulletAP.
  
# Changelog for 2.6.1.2 (2026-04-17)

## Notes

 - This is a hotfix release to address the issues described at https://github.com/flatlanderone/gunpack/issues/15 and https://github.com/flatlanderone/gunpack/issues/16. Big thanks to Nexus user reichi1996 for first reporting the "White square in the place of the red dot issue".
 - The weapon description template has been further tweaked to enhance readability and prepare the ground for the planned automation of certain fields.
 - The changelog format was slightly updated to enhance readability.
 - All bug fixes from previous versions of the patch remain in place.

## 7 Days To Die 2.6

### item_modifiers.xml
 - Added no2xScopesFLTR tag to block the installation of the 2x scope.
 - Added no4xScopesFLTR tag to block the installation of the 4x scope.
 - Added no8xScopesFLTR tag to block the installation of the 8x scope.

## IZY_RMP_Tech

### items.xml
 - IZYgunT3TechnicalNailmachinegun now scraps to Robotics Parts instead of Machine Gun Parts.

## IZY_MMVMV2

### Localization.xml
 -  Added full localization for modGunReflexSightA and modGunReflexSightB.
 -  Added temporary localization for modGunFlashHider.

## IZY_RMP_762pack

### items.xml
 - Hotfix: IZYgunT1SNIPERRIFLE762Mosinnagant and IZYgunT2MarksManRifle762M1garandNavyconverted cannot install the Scope 2x Mod to avoid "White square in the place of the red dot" issue https://github.com/flatlanderone/gunpack/issues/15

 - Hotfix: IZYgunT3SNIPERRIFLE762LeeEnfieldRifle cannot install the Scope 2x Mod to avoid "Black or purple sight image when ADS" issue https://github.com/flatlanderone/gunpack/issues/16

## IZY_RMP_556pack

### items.xml
 - Hotfix: IZYgunT2ARCabineCAR15 and IZYgunT3MarksManRifle556M16A2DMR cannot install the Scope 2x Mod to avoid "Black or purple sight image when ADS" issue https://github.com/flatlanderone/gunpack/issues/16 

## IZY_RMP_SG

### items.xml
 - Hotfix: IZYgunT3TradshotgunTrenchGunM1897 and IZYgunT4TradshotgunBrowningAuto5 cannot install the Scope 2x Mod to avoid "Black or purple sight image when ADS" issue https://github.com/flatlanderone/gunpack/issues/16 

## IZY_RMP_9mmVAL

### items.xml
 - Hotfix: IZYgunT4SMGCZScorpionEVO3 cannot install the Scope 2x Mod to avoid "Black or purple sight image when ADS" issue https://github.com/flatlanderone/gunpack/issues/16

# Changelog for 2.6.1.1 (2026-04-15)

## Notes

All bug fixes from 2.5.1.0 and 2.6.1.0, except those specified below as reverted, remain in place.

## Known Issues

None.

## Black Wolf's better loot spawns 

 - See Nexus Mods: https://www.nexusmods.com/7daystodie/mods/3872

### loot.xml
 - 2.6.1.0 Change reverted: ammoShotgunShellDragoBreath was removed from loot in BetterlootIzy.

## IZY_RMP_762pack

### items.xml
 - Replaced missing drop mesh for IZYgunT3BattleRifleHKG3 with sack_dropped. 

## IZY_RMP_556pack

### items.xml
 - Replaced leather drop mesh for IZYgunT0SNIPERpipeAR15Broken15Junk with sack_dropped.
 - Replaced missing drop mesh for IZYgunT4ARCabineHK416 with sack_dropped. 

## IZY_RMP_SG

### recipes.xml
 - Reverted 2.6.1.0 removal of IZYgunT4TACshotgunM1014 recipe as this has been implemented in 5.1.3.

## IZY_RMP_Miscpack

### items.xml
  - Reverted from 2.6.1.0. IZYgunTminus1MusketM1777Rifle is visible again in the Creative menu for players.

### traders.xml
 - Added traderstage_template ammoTier0 to fix trader inventory crash due to Exception: TraderStageTemplate ammoTier0 for item: Muzzleloader Ammo does not exist. Bug:https://github.com/flatlanderone/gunpack/issues/9 (ammoMuzzleloadershot) reported by Black Wolf.
   
### recipes.xml
 - Enabled and updated the campfire recipe for ammoleadball.
 - Added a new forge recipe for ammoleadball.
 - Enabled and updated the backpack recipe for ammoMuzzleloadershot.

### Localization.txt:
 - Added localization for ammoleadball, ammoMuzzleloadershot and IZYgunTminus1MusketM1777Rifle.

# Changelog for 2.5.1.0 and 2.6.1.0
 
## Global changes

 - Removed all items that are disabled or not ready from the player view in Creative Mode.
 - Removed all items that are disabled or not ready from recipes, loot, and trader inventory.
 - All vanilla and IGP weapons have a new expanded description based on the original IGP format.
 - All vanilla and IGP weapon names display their weapon tier. For example, it is now possible to filter for all T3 weapons by typing "(T3)" in the search field.
 - Most vanilla and IGP weapon names display their weapon type. For example, it is now possible to display all shotguns by typing "shotgun" in the search field.
 - Localization has been reviewed and updated for clarity and consistency.
 
## IZY_FPV_GLOVES

### buffs.xml
 - Set IZYBeltAmmoCheck_02 buff to hidden. 

## IZY_MMVMV2

### item_modifiers.xml
 - Enabled localization for IZYmodPistolHoldstyle01Desc and IZYmodPistolHoldstyle02Desc.

### buffs.xml
 - Added name_key attribute to IZYNightHunterKit and IZYNightHunterKit_Aiming to enable localization.

### Localization.txt
 - Added full localization for Holdstyle Mod names and descriptions.  

## IZY_melee

### items.xml
 - IZYMeleeT4SpearPoleAxe can be sold like the other T4 melee weapons.
 - IZYMeleeT4BladeKatana has now the same sneak damage bonus as meleeWpnBladeT3Machete.
 
### Localization.txt  
 - Updated for clarity and consistency.

## IZY_RMP_Miscpack

### items.xml
 - IZYgunT4BowVanhelsingAutomaticCrossbowVH has its own description.
 - gunBowT3CompoundCrossbow has its own description.

### Localization.txt
 - Added descriptions for:
   - ammoCrossbowLightBoltStone
   - ammoCrossbowLightBoltIron
   - ammoCrossbowLightBoltSteelAP.
 - Updated for clarity and consistency.

## IZY_RMP_HVW

### Localization.txt:
 - Updated for clarity and consistency.
 
## IZY_RMP_Demopack

### items.xml 
 - 25mm grenades (ammo25mmGrenadeTraining, ammo25mmGrenadeHE, ammo25mmGrenadeFRAGS) have now the correct unlock information (craftingExplosives).

### progression.xml
 - Changed unlock levels from 45 to 50 for IZYgunT3LGLXM25 and IZYgunT3RocketLauncherRPG7, as intended in original Localization.txt.

### recipes.xml
 - Made the following grenade recipes learnable: ammo25mmGrenadeTraining, ammo25mmGrenadeHE, ammo25mmGrenadeFRAGS, ammoRocketRPGTraning, ammoRocketRPGHE, ammoRocketRPGIncendiary.

### Localization.txt:
 - Renamed ammoRocketRPGTraning, ammoRocketRPGHE, ammoRocketRPGIncendiary to 40mm Grenades.
 - Updated for clarity and consistency

## IZY_VRP

### items.xml
 - gunRifleT1HuntingRifle now shows rounds per minute.
  
## IZY_RMP_9mmVAL

### loot.xml
 - Removed from loot the following items: IZYgunT4DualPistolC96M,  IZYgunT3SMGMP5Ksubmachinegun, IZYgunT4SMGColt9mmsubmachinegun.
  
### recipes.xml
 - Removed legendary part requirement from level 6 IZYgunT0SMGPIPEsubmachinegun recipe.

### Localization.txt
 - IZYgunT1Pistol9Makarov and IZYgunT1Pistol9MakarovDesc have a full localization.
 - IZYgunT0SMGPIPEsubmachinegun localization now correctly shows Material as Scrap Iron, not Handgun Parts.
 - Renamed vanilla Pipe Pistol to Pipe Revolver.
 - Renamed vanilla Pistol to M9 Pistol.
 - Updated for clarity and consistency.  

## IZY_RMP_SG

### items.xml
 - Removed firingMode tag from IZYgunT2TradshotgunLeveractionShotgunModel1887 to prevent the installation of Trigger Group mods on a lever-action weapon.
 - Added ammoShotgunShellPremium compatibility for the following shotguns: IZYgunT3TradshotgunTrenchGunM1897, IZYgunT4TradshotgunBrowningAuto5, IZYgunT1TACCompactshotgunSuperShortty.

### progression.xml
 - Removed IZYgunT4TACshotgunM1014 from progression display.

### loot.xml
 - Removed IZYgunT4TACshotgunM1014 from loot.

### recipes.xml
 - Removed IZYgunT4TACshotgunM1014 from recipes.

### Localization.txt:
 - Updated for clarity and consistency.

## IZY_RMP_556pack

### items.xml
 - ammo556mmHIpower and ammo556mmArmorPiercing recipes unlock through craftingMachineGuns progression.
 - All 5.56mm bundles recipes unlock at Automatic Weapons Handbook - Completion.
 - 5.56 ammo displays penetration values.
 - IZYgunT0SNIPERpipeAR15Broken15Junk now scraps to Scrap Iron instead of Rifle Parts.
 - Changed display type from rangedGunNoMag to rangedGun to show rounds per minute for the following weapons:
   - IZYgunT0SNIPERpipeAR15Broken15Junk
   - IZYgunT3MarksManRifle556M16A2DMR
   - IZYgunT4MarksManRifle556SSMAR15

### progression.xml
 - Removed IZYgunT1LRLongRifleM16a1 from progression display.
 - ammo556mmHIpower recipe unlocks at level 26.
 - ammo556mmArmorPiercing recipe unlocks at level 46.
 - Added name_key attribute to perkAutoWeaponsCompleteName. Missing in vanilla.
 - All 5.56mm bundles recipes unlock at Automatic Weapons Handbook - Completion.

### traders.xml
 - Removed IZYgunT1LRLongRifleM16a1 from trader inventory.

### recipes.xml
 - Made HP and AP 5.56mm (single round and bundle) recipes learnable.
 - Removed IZYgunT1LRLongRifleM16a1 from recipes.

### Localization.txt:
 - Updated for clarity and consistency.
 - Added 5.56mm ammo to Automatic Weapons Handbook book perk descriptions.

## IZY_RMP_45ACP

### items.xml
 - Changed display type of all .45 ACP types to ammoBulletAP to show penetration values.
 - Added missing armor piercing code to ammo45ACPArmorpiecing. Copied values from AP 9mm.
 - Added missing armor piercing code to ammo45ACPEnhanced. Copied values from AP 5.56mm.
 - IZYgunT4Pistol45STIEAGLE6 is now compatible with ALL .45 ACP ammo types.
 - IZYgunT0PistolLiberatorImprovisedPistol now scraps to Scrap Iron instead of Handgun  Parts.
 - Changed display type from rangedGunNoMag to rangedGun to show rounds per minute for the following weapons:
   - IZYgunT3MarksmanRifleMMRM1Carbine45
   - IZYgunT4MarksmanRifle45MMRKrissVectorCarbine

### recipes.xml
 - Made HP and AP .45 ACP recipes learnable.
 - Removed legendary part requirement from level 6 IZYgunT0PistolLiberatorImprovisedPistol recipe.

### Localization.txt:
 - Updated for clarity and consistency.
 - Added .45 ACP ammo to Pistol Pete book perk descriptions.
 
## IZY_RMP_762pack

### items.xml
 - Fixed the number of mod slots for level 6 RPD Machine Gun (T2) and Antique Machine Gun (T4).
 - ammoBundle762mmBulletHP now uses the correct custom item icon.
 - Added ammo762mmExplosiveFragmentationsBundle. Borrowed from zzz_Ammo_Press_Add-On_Compatibility_Patch.
 - ammo762mmExplosiveFragmentations is now compatible with the following T4 7.62mm sniper rifles:
   - IZYgunT4SNIPERRIFLE762L96AWMRifle
   - IZYgunT4MarksManRifle762SVUprototypeRifle
 - Changed display type from rangedGunNoMag to rangedGun to show rounds per minute for the following weapons: IZYgunT4MarksManRifleM110SASS, IZYgunT4SNIPERRIFLE762L96AWMRifle,, IZYgunT4MarksManRifle762SVUprototypeRifle, IZYgunT1SNIPERRIFLE762Mosinnagant, IZYgunT3SNIPERRIFLE762LeeEnfieldRifle, IZYgunT2MarksManRifle762M1garandNavyconverted, IZYgunT3MarksManRifle762HKPSG1.

### progression.xml
 - ammo762mmExplosiveFragmentations and ammo762mmExplosiveFragmentationsBundle recipes unlock at the same time as IZYgunT4MarksManRifleM110SASS (level 61).
   
### recipes.xml
 - Added ammo762mmExplosiveFragmentations recipe. Borrowed from zzz_Ammo_Press_Add-On_Compatibility_Patch

### Localization.txt:
 - Updated for clarity and consistency.
 
## Ammo Press Add-On Patch for EFT and Izy v2
 - See Nexus Mods: https://www.nexusmods.com/7daystodie/mods/6993 
### recipes.xml
 - Removed ammoShotgunShellDragoBreath and ammoShotgunShellDragoBreathBundle recipe.

## Black Wolf's better loot spawns 
 - See Nexus Mods: https://www.nexusmods.com/7daystodie/mods/3872

### loot.xml
 - Removed ammoShotgunShellDragoBreath from loot.