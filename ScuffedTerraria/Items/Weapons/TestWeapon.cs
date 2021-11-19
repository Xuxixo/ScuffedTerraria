using Terraria.ID;
using Terraria.ModLoader;
using ScuffedTerraria.Projectiles;
using Terraria;


namespace ScuffedTerraria.Items.Weapons
{
    public class TestWeapon : ModItem

    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("TestWeapon");
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
            item.shoot = ModContent.ProjectileType<WaveCasterProjectile>();
            item.knockBack = 1.5f;
            item.autoReuse = true;
            item.mana = 20;
            item.shootSpeed = 7f;


        }
    }
}