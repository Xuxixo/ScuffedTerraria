using Terraria.ModLoader;
using Terraria.ID;
using Terraria;

namespace ScuffedTerraria.Projectiles
{
    public class MonsoonProjectile : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            Main.projFrames[projectile.type] = 3;
        }

        public override void SetDefaults()
        {
            projectile.CloneDefaults(ProjectileID.Typhoon);
            aiType = ProjectileID.Typhoon;
            projectile.light = 0.5f;
            projectile.magic = true;
            projectile.alpha = 0;
            projectile.tileCollide = true;
        }






    }
}