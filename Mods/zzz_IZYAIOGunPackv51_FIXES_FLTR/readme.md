# Flatlander's Fixes for IZY-All in One Gun Pack v5.1 - 1.1.0.4 version 2.6.1.1

## Overview

This mod provides various bug fixes and enhancements for the IZY-All in One Gun Pack v5.1 (1.1.0.4), hereafter "IZY Gun Pack"). See Changelog below for a full list of fixes and other changes.

## Requirements

 - [IZY-All in One Gun Pack v5.1.3 v. 1.1.0.4 released on 2026-04-14](https://www.nexusmods.com/7daystodie/mods/5458),
 - [z Izayo Weapon Fixes](https://www.nexusmods.com/7daystodie/mods/5458),
 - 7 Days to Die v2.5 and later.

## Manual installation

 1. Download the mod file.
 2. Unzip it anywhere on your hard drive.
 3. Copy the **zzz_IZYAIOGunPackv51_FIXES_FLTR** folder to the 7 Days to Die Mods folder. The default location is **%APPDATA%\7DaysToDie\Mods**.
 4. The mod must load after all the IZY Gun Pack mods, patches and extensions.

## Important notes

 1. The 2.6.1.1 version of the mod will work ONLY with the **5.1.3 - 1.1.0.4** version of the IZY Gun pack available on Nexus Mods and released on 2026-04-14. Check the version of your IZY Gun pack in the ModInfo.xml file. NO OTHER VERSION WILL BE SUPPORTED.
 2. If you are still on the older **5.1 - 1.1.0.4** version of the IZY Gun pack, DO NOT INSTALL THE 2.6.1.1 version. Use the 2.6.1.0 verson instead.
 3. Do not bother Izayo with questions regarding this mod. 
 4. Adding the mod to an existing save is probably safe, but you should always make a backup of your game save.
 5. Removing the mod is probably safe, but you should always make a backup of your game save.

## Bug reports and feature suggestions

 - [GitHub](https://github.com/flatlanderone/flatlander-releases/issues) (preferred).
 - [My channel on Guppy's Modding Server](https://discord.gg/yPFh79rq8J),
 - This mod's page on Nexus Mods.

## About this mod

 - **Author**: Flat Lander - [GitHub](https://github.com/flatlanderone/flatlander-releases) / [Nexus Mods](https://next.nexusmods.com/profile/flatlanderone)
 - **Download page**: [Flatlander's Fixes for IZY-All in One Gun Pack v5.1](https://www.nexusmods.com/7daystodie/mods/9980)
 - **Initial release**: 2.5.1.0 (2026-03-30)
 - **This release**: 2.6.1.0 (2026-04-12)
 
# Changelog for 2.6.1.1 (2026-04-15)

## Note

All bug fixes from 2.6.1.0, except those specified below as reverted, remain in place.

## Known Issues

None.

## Black Wolf's better loot spawns 
 - See Nexus Mods: https://www.nexusmods.com/7daystodie/mods/3872
 - loot.xml: 
   - 2.6.1.0 Change reverted as ammoShotgunShellDragoBreath was removed from loot in BetterlootIzy.


## IZY_RMP_SG
 - recipes.xml: reverted 2.6.1.0 removal of IZYgunT4TACshotgunM1014 recipe as this has been implemented in 5.1.3.

## IZY_RMP_Miscpack

 - items.xml:
   - IZYgunTminus1MusketM1777Rifle is visible again in the Creative menu for players.

 - recipes.xml:
   - Enabled and updated the campfire recipe for ammoleadball.
   - Added a new forge recipe for ammoleadball.
   - Enabled and updated the backpack recipe for ammoMuzzleloadershot.

 - Localization.txt:
   - Added localization for ammoleadball, ammoMuzzleloadershot and IZYgunTminus1MusketM1777Rifle.

# Changelog for 2.5.1.0 and 2.6.1.0
 
## Global changes

 - Removed all items that are disabled or not ready from the player view in Creative Mode.
 - Removed all items that are disabled or not ready from recipes, loot, and trader inventory.
 - All vanilla and IZY Gun Pack weapons have a new expanded description based on the original IZY format.
 - All vanilla and IZY Gun Pack weapon names display their weapon tier. For example, it is now possible to filter for all T3 weapons by typing "(T3)" in the search field.
 - Most vanilla and IZY Gun Pack weapon names display their weapon type. For example, it is now possible to display all shotguns by typing "shotgun" in the search field.
 - Localization has been reviewed and updated for clarity and consistency.
 
## IZY_FPV_GLOVES

 - buffs.xml:
   - Set IZYBeltAmmoCheck_02 buff to hidden. 

## IZY_MMVMV2

 - item_modifiers.xml:
   - Enabled localization for IZYmodPistolHoldstyle01Desc and IZYmodPistolHoldstyle02Desc.

 - buffs.xml:
   - Added name_key attribute to IZYNightHunterKit and IZYNightHunterKit_Aiming to enable localization.
 - Localization.txt  
    - Added full localization for Holdstyle Mod names and descriptions.  

## IZY_melee

 - items.xml: 
   - IZYMeleeT4SpearPoleAxe can be sold like the other T4 melee weapons.
   - IZYMeleeT4BladeKatana has now the same sneak damage bonus as meleeWpnBladeT3Machete.
 
 - Localization.txt  
   - Updated for clarity and consistency.

## IZY_RMP_Miscpack

 - items.xml:
   - IZYgunT4BowVanhelsingAutomaticCrossbowVH has its own description.
   - gunBowT3CompoundCrossbow has its own description.

 - Localization.txt
   - Added descriptions for:
     - ammoCrossbowLightBoltStone
     - ammoCrossbowLightBoltIron
     - ammoCrossbowLightBoltSteelAP.
   - Updated for clarity and consistency.

## IZY_RMP_HVW

 - Localization.txt:
   - Updated for clarity and consistency.
 
## IZY_RMP_Demopack

 - items.xml: 
   - 25mm grenades (ammo25mmGrenadeTraining, ammo25mmGrenadeHE, ammo25mmGrenadeFRAGS) have now the correct unlock information (craftingExplosives).

 - progression.xml:
   - Changed unlock levels from 45 to 50 for IZYgunT3LGLXM25 and IZYgunT3RocketLauncherRPG7, as intended in original Localization.txt.

 - recipes.xml:
   - Made the following grenade recipes learnable: ammo25mmGrenadeTraining, ammo25mmGrenadeHE, ammo25mmGrenadeFRAGS, ammoRocketRPGTraning, ammoRocketRPGHE, ammoRocketRPGIncendiary.

 - Localization.txt:
   - Renamed ammoRocketRPGTraning, ammoRocketRPGHE, ammoRocketRPGIncendiary to 40mm Grenades.
   - Updated for clarity and consistency

## IZY_VRP

 - items.xml:
   - gunRifleT1HuntingRifle now shows rounds per minute.
  
## IZY_RMP_9mmVAL

 - loot.xml:
   - Removed from loot the following items: IZYgunT4DualPistolC96M,  IZYgunT3SMGMP5Ksubmachinegun, IZYgunT4SMGColt9mmsubmachinegun.
  
 - recipes.xml:
   - Removed legendary part requirement from level 6 IZYgunT0SMGPIPEsubmachinegun recipe.

 - Localization.txt
   - IZYgunT1Pistol9Makarov and IZYgunT1Pistol9MakarovDesc have a full localization.
   - IZYgunT0SMGPIPEsubmachinegun localization now correctly shows Material as Scrap Iron, not Handgun Parts.
   - Renamed vanilla Pipe Pistol to Pipe Revolver.
   - Renamed vanilla Pistol to M9 Pistol.
   - Updated for clarity and consistency.  

## IZY_RMP_SG

 - items.xml:
   - Removed firingMode tag from IZYgunT2TradshotgunLeveractionShotgunModel1887 to prevent the installation of Trigger Group mods on a lever-action weapon.
   - Added ammoShotgunShellPremium compatibility for the following shotguns: IZYgunT3TradshotgunTrenchGunM1897, IZYgunT4TradshotgunBrowningAuto5, IZYgunT1TACCompactshotgunSuperShortty.

 - progression.xml:
   - Removed IZYgunT4TACshotgunM1014 from progression display.

 - loot.xml:
   - Removed IZYgunT4TACshotgunM1014 from loot.

 - recipes.xml:
   - Removed IZYgunT4TACshotgunM1014 from recipes.

 - Localization.txt:
   - Updated for clarity and consistency.

## IZY_RMP_556pack

 - items.xml:
   - ammo556mmHIpower and ammo556mmArmorPiercing recipes unlock through craftingMachineGuns progression.
   - All 5.56mm bundles recipes unlock at Automatic Weapons Handbook - Completion.
   - 5.56 ammo displays penetration values.
   - IZYgunT0SNIPERpipeAR15Broken15Junk now scraps to Scrap Iron instead of Rifle Parts.
   - Changed display type from rangedGunNoMag to rangedGun to show rounds per minute for the following weapons:
     - IZYgunT0SNIPERpipeAR15Broken15Junk
     - IZYgunT3MarksManRifle556M16A2DMR
     - IZYgunT4MarksManRifle556SSMAR15

 - progression.xml:
   - Removed IZYgunT1LRLongRifleM16a1 from progression display.
   - ammo556mmHIpower recipe unlocks at level 26.
   - ammo556mmArmorPiercing recipe unlocks at level 46.
   - Added name_key attribute to perkAutoWeaponsCompleteName. Missing in vanilla.
   - All 5.56mm bundles recipes unlock at Automatic Weapons Handbook - Completion.

 - traders.xml:
   - Removed IZYgunT1LRLongRifleM16a1 from trader inventory.

 - recipes.xml:
   - Made HP and AP 5.56mm (single round and bundle) recipes learnable.
   - Removed IZYgunT1LRLongRifleM16a1 from recipes.

 - Localization.txt:
   - Updated for clarity and consistency.
   - Added 5.56mm ammo to Automatic Weapons Handbook book perk descriptions.

## IZY_RMP_45ACP

 - items.xml:
   - Changed display type of all .45 ACP types to ammoBulletAP to show penetration values.
   - Added missing armor piercing code to ammo45ACPArmorpiecing. Copied values from AP 9mm.
   - Added missing armor piercing code to ammo45ACPEnhanced. Copied values from AP 5.56mm.
   - IZYgunT4Pistol45STIEAGLE6 is now compatible with ALL .45 ACP ammo types.
   - IZYgunT0PistolLiberatorImprovisedPistol now scraps to Scrap Iron instead of Handgun  Parts.
   - Changed display type from rangedGunNoMag to rangedGun to show rounds per minute for the following weapons:
     - IZYgunT3MarksmanRifleMMRM1Carbine45
     - IZYgunT4MarksmanRifle45MMRKrissVectorCarbine

 - recipes.xml:
   - Made HP and AP .45 ACP recipes learnable.
   - Removed legendary part requirement from level 6 IZYgunT0PistolLiberatorImprovisedPistol recipe.

 - Localization.txt:
   - Updated for clarity and consistency.
   - Added .45 ACP ammo to Pistol Pete book perk descriptions.
 
## IZY_RMP_762pack

 - items.xml:
   - Fixed the number of mod slots for level 6 RPD Machine Gun (T2) and Antique Machine Gun (T4).
   - ammoBundle762mmBulletHP now uses the correct custom item icon.
   - Added ammo762mmExplosiveFragmentationsBundle. Borrowed from zzz_Ammo_Press_Add-On_Compatibility_Patch.
   - ammo762mmExplosiveFragmentations is now compatible with the following T4 7.62 sniper rifles:
     - IZYgunT4SNIPERRIFLE762L96AWMRifle
     - IZYgunT4MarksManRifle762SVUprototypeRifle
   - Changed display type from rangedGunNoMag to rangedGun to show rounds per minute for the following wweapons: IZYgunT4MarksManRifleM110SASS, IZYgunT4SNIPERRIFLE762L96AWMRifle,, IZYgunT4MarksManRifle762SVUprototypeRifle, IZYgunT1SNIPERRIFLE762Mosinnagant, IZYgunT3SNIPERRIFLE762LeeEnfieldRifle, IZYgunT2MarksManRifle762M1garandNavyconverted, IZYgunT3MarksManRifle762HKPSG1.

 - progression.xml:
   - ammo762mmExplosiveFragmentations and ammo762mmExplosiveFragmentationsBundle recipes unlock at the same time as IZYgunT4MarksManRifleM110SASS (level 61).
   
 - recipes.xml:
   - Added ammo762mmExplosiveFragmentations recipe. Borrowed from zzz_Ammo_Press_Add-On_Compatibility_Patch

 - Localization.txt:
   - Updated for clarity and consistency.
 
## Ammo Press Add-On Patch for EFT and Izy v2

 - See Nexus Mods: https://www.nexusmods.com/7daystodie/mods/6993 
 - recipes.xml:
   - Removed ammoShotgunShellDragoBreath and ammoShotgunShellDragoBreathBundle recipe.

## Black Wolf's better loot spawns 
 - See Nexus Mods: https://www.nexusmods.com/7daystodie/mods/3872
 - loot.xml: 
   - Removed ammoShotgunShellDragoBreath from loot.