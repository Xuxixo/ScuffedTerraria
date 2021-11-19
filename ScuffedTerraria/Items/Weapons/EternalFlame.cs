using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using ScuffedTerraria.Projectiles;

namespace ScuffedTerraria.Items.Weapons
{
    public class EternalFlame : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Eternal Flame");
            Tooltip.SetDefault("Command the Flame of Udun");
        }
        public override void SetDefaults()
        {
            item.shoot = ModContent.ProjectileType<EternalFlameProjectile>();
            item.magic = true;
            item.damage = 300;
            item.useTime = 10;
            item.useAnimation = 10;
            item.reuseDelay = 20;
            item.autoReuse = true;
            item.shootSpeed = 13f;
            item.useStyle = ItemHoldStyleID.HoldingOut;
            item.maxStack = 1;
            item.value = 20000;
            item.height = 30;
            item.width = 28;
            item.mana = 18;
           

        }
        public override void OnHitNPC(Player player, NPC target, int damage, float knockBack, bool crit)
        {
            target.AddBuff(BuffID.Ichor, 160);
            target.AddBuff(BuffID.OnFire, 160);
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.LunarBar, 16);
            recipe.AddIngredient(ItemID.DD2PhoenixBow);
            recipe.AddIngredient(ItemID.RavenStaff);
            recipe.AddIngredient(ItemID.GoldenShower);
            recipe.AddIngredient(ItemID.Flamelash);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();

        }
    }
}
