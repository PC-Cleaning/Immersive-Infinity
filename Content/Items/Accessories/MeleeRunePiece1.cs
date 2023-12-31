﻿using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using immersiveinfinity;
using immersiveinfinity.Rarities;
namespace immersiveinfinity.Content.Items.Accessories
{


    public class MeleeRunePiece1 : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Melee Rune Piece 1");
            Tooltip.SetDefault("Minor improvement to melee damage\n"
                + "15% extra damage\n"
            );


        }

        public override void SetDefaults()
        {
            Item.width = 42;
            Item.height = 34;
            Item.value = 500;
            Item.rare = ModContent.RarityType<woda>();
            Item.accessory = true;




        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.GetDamage(DamageClass.Generic) += 0.15f;
            


        }

         public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.StoneBlock, 30);
            recipe.AddIngredient(ItemID.HellstoneBar, 5);
            recipe.AddTile(TileID.Anvils);
            recipe.Register();

        }




    }
}

