using System;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;

namespace ScuffedTerraria.NPCs
{
    public class TheChampion : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("The Champion");
        }
        public override void SetDefaults()
        {
            npc.CloneDefaults(NPCID.Zombie);
            Main.npcFrameCount[npc.type] = 19;
            npc.lifeMax = 1500;
            npc.defense = 40;
            aiType = NPCID.Zombie;
            npc.damage = 150;
            animationType = NPCID.GreekSkeleton;
            npc.HitSound = SoundID.NPCHit2;
            npc.DeathSound = SoundID.NPCDeath2;
            npc.aiStyle = 3;
            npc.scale = 1.5f;
            npc.stepSpeed = 10f;
        }
        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            return SpawnCondition.JungleTemple.Chance * 0.2f;
        }

    }
}
