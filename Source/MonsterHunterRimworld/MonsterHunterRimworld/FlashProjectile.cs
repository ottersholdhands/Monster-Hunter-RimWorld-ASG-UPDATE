using UnityEngine;
using RimWorld;
using Verse;

namespace MonsterHunterRimworld
{
    class FlashProjectile : Bullet
    {
        public ThingDef_FlashProjectile Def
        {
            get
            {
                return this.def as ThingDef_FlashProjectile;
            }
        }

        protected override void Tick()
        {
            GenExplosion.DoExplosion(this.Position, this.Map, 4.5f, DamageDefOf.Stun, this, -1, -1f, null, null, null, null, null, 0f, 1, GasType.BlindSmoke);
            this.Destroy();
        }
    }

    public class ThingDef_FlashProjectile : ThingDef
    {

    }

  
}
