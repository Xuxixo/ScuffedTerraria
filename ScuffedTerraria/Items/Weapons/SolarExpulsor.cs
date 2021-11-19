using Terraria.ModLoader;
using Terraria.ID;
using ScuffedTerraria.Projectiles;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Terraria;


namespace ScuffedTerraria.Items.Weapons
{
    public class SolarExpulsor : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Solar Expulsor");
            Tooltip.SetDefault("Vanquish Thy Enemies With Heavenly Light");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.MagnetSphere);
            item.damage = 130;
            item.shoot = ModContent.ProjectileType<SolarExpulsionProjectile>();
            item.useTime = 20;
            item.useAnimation = 20;
            item.autoReuse = true;
            item.shootSpeed = 7f;
            item.mana = 35;
            item.reuseDelay = 180;
            item.UseSound = mod.GetLegacySoundSlot(SoundType.Item, "Sounds/Item/DragonRoar");

        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.MagnetSphere);
            recipe.AddIngredient(ItemID.FragmentSolar, 10);
            recipe.AddIngredient(ItemID.LunarBar, 8);
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

    }
}
