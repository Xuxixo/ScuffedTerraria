using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;

namespace ScuffedTerraria.Projectiles
{
    public class SolarExpulsionProjectile : ModProjectile
    {

        public override void SetStaticDefaults()
        {
            Main.projFrames[projectile.type] = 5;
        }

        public override void SetDefaults()
        {
            projectile.CloneDefaults(ProjectileID.MagnetSphereBall);
            aiType = ProjectileID.MagnetSphereBall;
            projectile.scale = 2f;
            projectile.light = 0.6f;
            projectile.friendly = true;
            projectile.tileCollide = false;
            projectile.penetrate = 5;
        }



    }
}
