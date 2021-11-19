using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using ScuffedTerraria.Items;

namespace ScuffedTerraria.NPCs
{

        
    public class TestGlobalNPC : GlobalNPC
    {
        public override void NPCLoot(NPC npc)
        {
            if (npc.type == NPCID.KingSlime && !Main.expertMode)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<SocialCredit>());
            }
            if (npc.type == NPCID.DukeFishron && !Main.expertMode)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<SocialCredit>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.EyeofCthulhu && !Main.expertMode)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<ABitMoreSocialCredit>());
            }
            if (npc.type == NPCID.SkeletronHead && !Main.expertMode)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<SocialCredit>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.QueenBee && !Main.expertMode)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<SocialCredit>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.WallofFlesh && !Main.expertMode)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<SocialCredit>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.EaterofWorldsBody && !Main.expertMode)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<SocialCredit>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.BrainofCthulhu && !Main.expertMode)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<SocialCredit>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.CultistBoss && !Main.expertMode)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<SocialCredit>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.Plantera && !Main.expertMode)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<SocialCredit>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.Golem && !Main.expertMode)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<SocialCredit>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.SkeletronPrime && !Main.expertMode)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<SocialCredit>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.TheDestroyer && !Main.expertMode)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<SocialCredit>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.Retinazer && !Main.expertMode)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<SocialCredit>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.Spazmatism && !Main.expertMode)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<SocialCredit>(), Main.rand.Next(1, 2));
            }
            if (npc.type == NPCID.MoonLordCore && !Main.expertMode)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<SocialCredit>(), Main.rand.Next(1, 2));
            }





        }
    }

}
