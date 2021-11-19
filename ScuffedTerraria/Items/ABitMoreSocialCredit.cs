using System;
using Terraria.ModLoader;
using Terraria;
using Terraria.ID;
using Microsoft.Xna.Framework;

namespace ScuffedTerraria.Items
{
    public class ABitMoreSocialCredit : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("A Bit More Social Credit");
            Tooltip.SetDefault("This yields a slightly higher social credit score...");
        }
        public override void SetDefaults()
        {
            item.height = 10;
            item.width = 16;
            item.scale = 1.5f;
            item.maxStack = 99;
            item.value = 1000;
        }
    }
}
