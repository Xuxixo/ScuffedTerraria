using Terraria.ID;
using Terraria.ModLoader;

namespace ScuffedTerraria.Items.Weapons
{
    public class Monsoon : ModItem

    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Monsoon");
        }

        public override void SetDefaults()
        {
            item.width = 28;
            item.height = 30;
            item.rare = ItemRarityID.Red;
            item.value = 10000;
            item.maxStack = 1;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.useTime = 12;
            item.useAnimation = 12;
            item.magic = true;
            item.damage = 170;
            item.UseSound = SoundID.Item1;
            item.shoot = ProjectileID.Typhoon;
            item.knockBack = 1.5f;
            item.autoReuse = true;
            item.mana = 20;
            item.shootSpeed = 7f;


        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.RazorbladeTyphoon);
            recipe.AddIngredient(ItemID.SpectreBar, 10);
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }




    }
}