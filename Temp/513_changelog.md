Mods/7D1.0_Izayo_Visible_FPV_Gloves_mod/Config/buffs.xml

hands



Mods/7D1.0_Izayo_WeaponpackMisc_pack/Config/items.xml
Updated IZYgunTminus1MusketM1777Rifle
hands

NEW FILE
Mods/7D1.0_Izayo_WeaponpackMisc_pack/Config/loot.xml
Added IZYgunTminus1MusketM1777Rifle and ammoMuzzleloadershot


Mods/7D1.0_Izayo_WeaponpackRemastered_44mag/Config/items.xml

hands only


Mods/7D1.0_Izayo_WeaponpackRemastered_45ACP/Config/item_modifiers.xml
mesh


Mods/7D1.0_Izayo_WeaponpackRemastered_45ACP/Config/items.xml
hands only


Mods/7D1.0_Izayo_WeaponpackRemastered_45ACP/Config/progression.xml
<append xpath="/progression/perks/book[@name='perkPistolPeteComplete']">
	<effect_group>
		<passive_effect name="RecipeTagUnlocked" operation="base_set" level="1" value="1" tags=",ammoBundle45ACPBulletBall,ammoBundle45ACPHighpower,ammoBundle45ACPArmorpiecing,ammoBundle45ACPEnhanced"/>
		<passive_effect name="RecipeTagUnlocked" operation="base_set" level="1" value="1" tags="ammoBundle45ACPBulletBall,ammoBundle45ACPHighpower,ammoBundle45ACPArmorpiecing,ammoBundle45ACPEnhanced"/>
	</effect_group>
</append>



Mods/7D1.0_Izayo_WeaponpackRemastered_556pack/Config/items.xml

hands only



Mods/7D1.0_Izayo_WeaponpackRemastered_762pack/Config/items.xml

hands only



Mods/7D1.0_Izayo_WeaponpackRemastered_9mmVAL/Config/items.xml

hands only


Mods/7D1.0_Izayo_WeaponpackRemastered_DemolitionPack/Config/items.xml
hands only


Mods/7D1.0_Izayo_WeaponpackRemastered_Heavy_WeaponPack/Config/items.xml
hands only


Mods/7D1.0_Izayo_WeaponpackRemastered_Heavy_WeaponPack/Config/loot.xml

	<insertAfter xpath="//lootgroup[@name='groupHardenedChestT5_07']">
		<item name="IZYgunT5HeavyWeaponM2flameThrower" loot_prob_template="low"/>
	<insertAfter xpath="//lootgroup[@name='groupWeaponsT3_Machinegunner']">
		<item name="IZYgunT5HeavyWeaponM134MinigunGatling" loot_prob_template="low"/>
	</insertAfter>
	<insertAfter xpath="//lootgroup[@name='groupWeaponsT3_Boomstick']">
		<item name="IZYgunT5HeavyWeaponM2flameThrower" loot_prob_template="low"/>
	</insertAfter>
	
	
Mods/7D1.0_Izayo_WeaponpackRemastered_Heavy_WeaponPack/Config/recipes.xml

empty lines removed


Mods/7D1.0_Izayo_WeaponpackRemastered_SHOTGUNpackVAL/Config/item_modifiers.xml
	<!--	SAW OFF BARREL	--> bug removed



Mods/7D1.0_Izayo_WeaponpackRemastered_SHOTGUNpackVAL/Config/items.xml

hands only

Mods/7D1.0_Izayo_WeaponpackRemastered_SHOTGUNpackVAL/Config/recipes.xml
removed recipe IZYgunT4TACshotgunM1014
	<!--
		<recipe name="IZYgunT4TACshotgunM1014" count="1" craft_area="workbench" tags="learnable,perkBoomstick">
			<ingredient name="gunShotgunT1DoubleBarrelParts" count="16"/>
			<ingredient name="resourceForgedSteel" count="100"/>
@@ -124,7 +124,7 @@
				<passive_effect name="CraftingIngredientCount" level="2,6" operation="base_add" value="1,5" tags="resourceLegendaryParts"/>
			</effect_group>
		</recipe>

	-->



Mods/7D1.0_Izayo_WeaponpackRemastered_Technicalpack/Config/items.xml


hands only



Mods/7D1.0_Izayo_WeaponpackSpecial_Melee/Config/items.xml

hands only



Mods/7D1.0_Izayo_WeaponpackVanillaReplacer/Config/items.xml

hands only
