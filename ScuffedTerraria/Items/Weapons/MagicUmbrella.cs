using ScuffedTerraria.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace ScuffedTerraria.Items.Weapons
{
    public class MagicUmbrella : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Magic Umbrella");
            Tooltip.SetDefault("Sprinkle your foes with heavenly water");
        }
        public override void SetDefaults()
        {
            item.shoot = ModContent.ProjectileType<WaveCasterProjectile>();
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.UseSound = SoundID.Item13;
            item.shootSpeed = 10f;
            item.width = 50;
            item.height = 54;
            item.damage = 10;
            item.autoReuse = true;
            item.maxStack = 1;
            item.value = 15000;
            item.useTime = 16;
            item.useAnimation = 16;
            item.melee = true;

        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            int numberProjectiles = 1 + Main.rand.Next(2);  
            for (int index = 0; index < numberProjectiles; ++index)
            {
                Vector2 vector2_1 = new Vector2((float)((double)player.position.X + (double)player.width * 0.5 + (double)(Main.rand.Next(201) * -player.direction) + ((double)Main.mouseX + (double)Main.screenPosition.X - (double)player.position.X)), (float)((double)player.position.Y + (double)player.height * 0.5 - 600.0));   //this defines the projectile width, direction and position
                vector2_1.X = (float)(((double)vector2_1.X + (double)player.Center.X) / 2.0) + (float)Main.rand.Next(-200, 201);
                vector2_1.Y -= (float)(100 * index);
                float num12 = (float)Main.mouseX + Main.screenPosition.X - vector2_1.X;
                float num13 = (float)Main.mouseY + Main.screenPosition.Y - vector2_1.Y;
                if ((double)num13 < 0.0) num13 *= -1f;
                if ((double)num13 < 20.0) num13 = 20f;
                float num14 = (float)Math.Sqrt((double)num12 * (double)num12 + (double)num13 * (double)num13);
                float num15 = item.shootSpeed / num14;
                float num16 = num12 * num15;
                float num17 = num13 * num15;
                float SpeedX = num16 + (float)Main.rand.Next(-40, 41) * 0.02f;  //this defines the projectile X position speed and randomnes
                float SpeedY = num17 + (float)Main.rand.Next(-40, 41) * 0.02f;  //this defines the projectile Y position speed and randomnes
                Projectile.NewProjectile(vector2_1.X, vector2_1.Y, SpeedX, SpeedY, type, damage, knockBack, Main.myPlayer, 0.0f, (float)Main.rand.Next(5));
            }
            return false;
        }
        public override void HoldItem(Player player)
        {
            player.itemRotation = 0f;
            player.itemLocation.Y = player.Center.Y;
            player.itemLocation.X = player.Center.X - 18 * player.direction;
        }




    }
} 
