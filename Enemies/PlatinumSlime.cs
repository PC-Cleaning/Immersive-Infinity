﻿using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.ModLoader.Utilities;

namespace immersiveinfinity.Enemies
{
    internal class PlatinumSlime : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Platinum Slime");
        }

        public override void SetDefaults()
        {
            NPC.aiStyle = 1;
            NPC.scale = 1.2f;
            NPC.npcSlots = 1;
            NPC.width = 20;
            NPC.height = 20;
            NPC.defense = 6;
            NPC.damage = 45;
            NPC.lifeMax = 160;
            NPC.HitSound = SoundID.NPCHit1;
            NPC.DeathSound = SoundID.NPCDeath1;
            NPC.knockBackResist = 0.2f;
            Main.npcFrameCount[NPC.type] = 2;
            NPC.value = 1000f;
            NPC.friendly = false;
            AIType = NPCID.BlueSlime;
            AnimationType = NPCID.BlueSlime;
        }


        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            return SpawnCondition.Cavern.Chance * 0.05f;
        }

        public override void OnKill()
        {

            Item.NewItem(NPC.GetSource_Death(), NPC.getRect(), ItemID.Gel, Main.rand.Next(15,25));
            Item.NewItem(NPC.GetSource_Death(), NPC.getRect(), ItemID.PlatinumOre, Main.rand.Next(30, 40));
        }
    }
}
