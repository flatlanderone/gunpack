# Weapon, Ammo and Tool Naming Conventions in 7 Days To Die

## Overview

7 Days To Die follows a set of specific naming conventions for weapons, ammo and tools. 

## Benefits

There are many benefits to following the vanilla weapon and ammo namimg convention for modded weapons:

1. It is easier to organize and track weapons during the design, testing and update cycles.
2. Modded weapons will sort alphabetically with vanilla weapons and other modded weapons of the same type and tier in the in-game panels. 
3. It is easier to consistently target weapon groups using XPATH expressions, such as starts-with, ends-with, contains. 

	Example: Remove all vanilla and modded shotgun recipes:
	```
	<remove xpath="/recipes/recipe[starts-with(@name, 'gunShotgun') /> 
	```

4. It is easier to search for weapons across folders and files in large weapon pack projects.
 
## Syntax for weapons

### Vanilla weapons
[weapon usage][weapon type][tier][weapon name]

Examples:
```
gunHandgunT3DesertVulture
gunMGT3M60
gunShotgunT2PumpShotgun
```

### Recommendations for modded weapons

[weapon usage][weapon type][tier][weapon name][namespace]
or
[weapon usage][weapon type][tier][namespace][weapon name]

Example:
```
gunHandgunT4ForestOwlFLTR
gunRifleT1ArisakaType99FNK
gunExplosivesT2LGLChinalakeGrenadeLauncherIZY

gunMGT1IzyAK47
gunMGT1LRSAK47
gunMGT1FNKAK47

```

### [weapon usage]

- gun: all ranged weapons.
- meleeWpn: all melee weapons.

### [weapon type]

- Bot: robotic weapons, turrets.
- Bow: bows, crossbows.
- Explosives: grenade launchers, rocket launchers.
- Handgun: pistols, revolvers, SMGs/submachine guns.
- MG: machine guns.
- Rifle: hunting rifle, sniper rifle.
- Shotgun: shotguns.
- Baton: police baton, stun batons, cattle prod.
- Blade: knife, machete, sword.
- Club: club, baseball bat, mace, one-handed bashing weapons.
- Knuckles: knuckles, gloves.
- Sledge: sledgehammer, two-handed bashing weapons.
- Spear: spears, halberds, poleAxes.

### [tier]

- T0 to T5

### [weapon name]

- Distinctive weapon name, including variants, calibers etc.

### [namespace] 

- A string to distinguish the weapon from vanilla weapons and weapons from other weapon packs.

## Syntax for ammo

### Vanilla ammo

### Recommendation for modded ammo


ammo44MagnumBulletAP
ammoShotgunBreachingSlug
ammoShotgunShell
ammoShotgunSlug
[item usage][caliber or weapon type][ammo type][special ability]
- ammo: all ammunitions.

### [caliber or weapon type]
