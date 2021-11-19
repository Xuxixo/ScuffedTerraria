using System;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;
using Terraria.Localization;
using ScuffedTerraria.Items.Weapons;
using ScuffedTerraria.Projectiles;
using ScuffedTerraria.Sounds;
using ScuffedTerraria.Items;
using ScuffedTerraria;
using Terraria.Utilities;

namespace ScuffedTerraria.NPCs
{
    [AutoloadHead]
    public class PropagandaMinister : ModNPC
    {
        public override string Texture => "ScuffedTerraria/NPCs/PropagandaMinister";

        public override string[] AltTextures => new[] { "ScuffedTerraria/NPCs/PropagandaMinister_Alt_1" };

        public override bool Autoload(ref string name)
        {
            name = "PropagandadMinister";
            return mod.Properties.Autoload;
        }

        public override void SetStaticDefaults()
        {
            Main.npcFrameCount[npc.type] = 25;
            NPCID.Sets.ExtraFramesCount[npc.type] = 9;
            NPCID.Sets.AttackFrameCount[npc.type] = 4;
            NPCID.Sets.DangerDetectRange[npc.type] = 700;
            NPCID.Sets.AttackType[npc.type] = 0;
            NPCID.Sets.AttackTime[npc.type] = 90;
            NPCID.Sets.AttackAverageChance[npc.type] = 30;
            NPCID.Sets.HatOffsetY[npc.type] = 4;
        }

        public override void SetDefaults()
        {
            npc.townNPC = true;
            npc.friendly = true;
            npc.lifeMax = 300;
            npc.damage = 20;
            npc.defense = 15;
            animationType = NPCID.DD2Bartender;
            npc.HitSound = mod.GetLegacySoundSlot(SoundType.Item, "Sounds/Item/BingChillingSound");
            npc.DeathSound = mod.GetLegacySoundSlot(SoundType.Item, "Sounds/Item/VineBoomSound");
            npc.width = 22;
            npc.height = 42;
            npc.aiStyle = 7;

        }
        public override bool CanTownNPCSpawn(int numTownNPCs, int money)
        {
            if (Main.hardMode)

                for (int k = 0; k < 255; k++)
            {
                Player player = Main.player[k];
                if (!player.active)
                {
                    continue;
                }

                foreach (Item item in player.inventory)
                {
                    if (item.type == mod.ItemType("SocialCredit"))
                    {
                        return true;
                    }
                }
            }
            
            return false;

        }
       
        public override string TownNPCName()
        {
            switch (WorldGen.genRand.Next(2))
            {
                case 0:
                    return "John Xina";

                case 1:
                    return "John Xina";

                default:
                    return "John Xina";
            }
        }
        public override void TownNPCAttackStrength(ref int damage, ref float knockback)
        {
            damage = 60;
            knockback = 4f;
        }

        public override void TownNPCAttackCooldown(ref int cooldown, ref int randExtraCooldown)
        {
            cooldown = 4;
            randExtraCooldown = 4;
        }

        public override void TownNPCAttackProj(ref int projType, ref int attackDelay)
        {
            projType = ModContent.ProjectileType<WaveCasterProjectile>();
            attackDelay = 1;
        }

        public override void TownNPCAttackProjSpeed(ref float multiplier, ref float gravityCorrection, ref float randomOffset)
        {
            multiplier = 12f;
            randomOffset = 2f;
        }


        public override string GetChat()
        {
            int Guide = NPC.FindFirstNPC(NPCID.Guide);
            if (Guide >= 0 && Main.rand.NextBool(4))
            {
                return "Can you please tell " + Main.npc[Guide].GivenName + " to praise the great leader Mao Zedong?";
            }
            switch (Main.rand.Next(4))
            {
                case 0:
                    return "If dog barks he no cooked enough.";
                case 1:
                    return "What's your favorite color? Mine is communism.";
                case 2:
                    {

                        Main.npcChatCornerItem = ModContent.ItemType<SocialCredit>();
                        return $"Hey, if you find a [i:{ModContent.ItemType<SocialCredit>()}], I can exchange it for you.";
                    }
                default:
                    return "Bing Chilling";
            }
        }

        public override void SetChatButtons(ref string button, ref string button2)
        {
            button = Language.GetTextValue("LegacyInterface.28");
            if (Main.LocalPlayer.HasItem(ModContent.ItemType<SocialCredit>()))
                button = "Exchange " + Lang.GetItemNameValue(ModContent.ItemType<SocialCredit>());
        }


        public override void OnChatButtonClicked(bool firstButton, ref bool shop)
        {
            shop = true;
            if (Main.LocalPlayer.HasItem(ModContent.ItemType<SocialCredit>()))
            {
                Main.PlaySound(SoundID.Item37); // Reforge/Anvil sound
                Main.npcChatText = $"I exchanged your {Lang.GetItemNameValue(ModContent.ItemType<SocialCredit>())} for a {Lang.GetItemNameValue(ModContent.ItemType<Items.Weapons.MagicUmbrella>())}";
                int SocialCreditItemIndex = Main.LocalPlayer.FindItem(ModContent.ItemType<SocialCredit>());
                Main.LocalPlayer.inventory[SocialCreditItemIndex].TurnToAir();
                Main.LocalPlayer.QuickSpawnItem(ModContent.ItemType<Items.Weapons.MagicUmbrella>());
                return;

            }
            if (Main.LocalPlayer.HasItem(ModContent.ItemType<ABitMoreSocialCredit>()))
            {
                Main.PlaySound(SoundID.Item37); // Reforge/Anvil sound
                Main.npcChatText = $"I exchanged your {Lang.GetItemNameValue(ModContent.ItemType<ABitMoreSocialCredit>())} for a {Lang.GetItemNameValue(ModContent.ItemType<Items.Weapons.WaveCaster>())}";
                int ABitMoreSocialCreditItemIndex = Main.LocalPlayer.FindItem(ModContent.ItemType<ABitMoreSocialCredit>());
                Main.LocalPlayer.inventory[ABitMoreSocialCreditItemIndex].TurnToAir();
                Main.LocalPlayer.QuickSpawnItem(ModContent.ItemType<Items.Weapons.WaveCaster>());
                return;

            }
        }

        public override void SetupShop(Chest shop, ref int nextSlot)
        {
            if (Main.hardMode)

            shop.item[nextSlot].SetDefaults(ModContent.ItemType<Items.Weapons.SolarExpulsor>());
            shop.item[nextSlot].shopCustomPrice = 1000000;
            nextSlot++;
            shop.item[nextSlot].SetDefaults(ModContent.ItemType<Items.Weapons.EternalFlame>());
            shop.item[nextSlot].shopCustomPrice = 1000000;
            nextSlot++;
            shop.item[nextSlot].SetDefaults(ModContent.ItemType<Items.Weapons.Monsoon>());
            shop.item[nextSlot].shopCustomPrice = 1000000;
            
        }


    }
}