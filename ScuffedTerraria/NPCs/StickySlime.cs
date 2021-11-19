using Terraria;
using Terraria.ID;
using Terraria.ModLoader;


namespace ScuffedTerraria.NPCs
{

    public class StickySlime : ModNPC
    {

        public override void SetDefaults()
        {
            npc.width = 28;
            npc.height = 24;
            npc.aiStyle = 1;
            npc.DeathSound = SoundID.NPCDeath1;
            npc.HitSound = SoundID.NPCHit1;
            npc.damage = 26;
            Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.BlueSlime];
            aiType = NPCID.BlueSlime;
            npc.lifeMax = 28;
            npc.defense = 4;
            npc.knockBackResist = 0.75f;
            npc.value = 1000;
            animationType = NPCID.BlueSlime;
        }

        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            return SpawnCondition.OverworldDaySlime.Chance * 0.6f;
        }

        public override void OnHitPlayer(Player target, int damage, bool crit)
        {
            target.AddBuff(BuffID.Slow, 120);
            target.AddBuff(BuffID.Stinky, 120);
        }
    }
}