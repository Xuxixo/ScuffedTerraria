using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ScuffedTerraria.NPCs
{
    public class FrostMiner : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Frost Miner");
        }
        public override void SetDefaults()
        {
            npc.width = 18;
            npc.height = 40;
            Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.Zombie];
            npc.lifeMax = 86;
            npc.defense = 12;
            npc.DeathSound = SoundID.NPCDeath3;
            npc.HitSound = SoundID.NPCHit1;
            npc.aiStyle = 3;
            npc.knockBackResist = 0.8f;
            npc.value = 1000;
            animationType = NPCID.Zombie;
            aiType = NPCID.Zombie;
            npc.damage = 46;

        }

        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            return SpawnCondition.Underground.Chance * 0.1f;
        }

        public override void OnHitPlayer(Player target, int damage, bool crit)
        {
            target.AddBuff(BuffID.Frozen, 40);
            target.AddBuff(BuffID.Slow, 180);
        }






    }
}