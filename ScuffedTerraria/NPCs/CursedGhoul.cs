using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace ScuffedTerraria.NPCs
{
    public class CursedGhoul : ModNPC
    {
        public override void SetStaticDefaults()
        {

            DisplayName.SetDefault("Cursed Ghoul");

        }

        public override void SetDefaults()
        {
            npc.CloneDefaults(NPCID.FloatyGross);
            Main.npcFrameCount[npc.type] = 5;
            npc.height = 80;
            npc.width = 32;
            npc.damage = 46;
            npc.lifeMax = 680;
            npc.aiStyle = 22;
            npc.value = 9200;
            npc.knockBackResist = 0.7f;
            npc.defense = 26;
            npc.DeathSound = SoundID.NPCDeath26;
            npc.HitSound = SoundID.NPCHit27;
            aiType = 22;
            animationType = NPCID.FloatyGross;
        }

        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            return SpawnCondition.SolarEclipse.Chance * 0.24f;
        }

        public override void OnHitPlayer(Player target, int damage, bool crit)
        {
            target.AddBuff(BuffID.Ichor, 100);
        }
    }
}
