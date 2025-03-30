using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using System.Linq;

namespace OnlyMounts{
    class OnlyMountsPlayer : ModPlayer{
        public override IEnumerable<Item> AddStartingItems(bool mediumCoreDeath){
            return base.AddStartingItems(mediumCoreDeath).Append(new Item(ItemID.FuzzyCarrot));
        }

        public override void PostUpdateEquips(){
            base.PostUpdateEquips();
            if(Player.mount.Active){
                Player.maxRunSpeed = 3f;
                Player.jumpSpeed = 5.01f;
                Player.moveSpeed = 1f;
                Player.runSlowdown = 0.2f;
            }else{
                Player.velocity.X = 0f;
                Player.maxRunSpeed = 0f;
                Player.jumpSpeed = 0f;
                Player.moveSpeed = 0f;
                Player.runSlowdown = 10f;
            }
        }
    }
}
