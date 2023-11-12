﻿using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace immersiveinfinity.Content.Items.Accessories.Dyes
{
    public class Dye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("DYIES");
            Tooltip.SetDefault("caca\n"
                + "yes\n"
            );

            // Avoid loading assets on dedicated servers. They don't use graphics cards.
            if (!Main.dedServ)
            {
                // The following code creates an effect (shader) reference and associates it with this item's type Id.
                GameShaders.Armor.BindShader(
                    Item.type,
                    new ArmorShaderData(new Ref<Effect>(Mod.Assets.Request<Effect>("Effects/Dye", AssetRequestMode.ImmediateLoad).Value), "DyePass") // Be sure to update the effect path and pass name here.
                );
            }

            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 3;
        }

        public override void SetDefaults()
        {
            // Item.dye will already be assigned to this item prior to SetDefaults because of the above GameShaders.Armor.BindShader code in Load().
            // This code here remembers Item.dye so that information isn't lost during CloneDefaults.
            Item.width = 42;
            Item.height = 34;
            Item.value = 500;
            Item.dye = ItemRarityID.Blue;
        }
    }
}