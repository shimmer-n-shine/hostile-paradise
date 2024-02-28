using System;
using System.Collections.Generic;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace hostileparadise.NPCs;
public class DisableVanillaSkySpawns : ILoadable
{
    public void Load(Mod mod)
    {
        On_NPC.NewNPC += NewNPC;
    }
    public void Unload() 
    {
        On_NPC.NewNPC -= NewNPC;
    }

    private int NewNPC(On_NPC.orig_NewNPC orig, IEntitySource source, int X, int Y, int Type, int Start, float ai0, float ai1, float ai2, float ai3, int Target)
    {
        if (Type is NPCID.WyvernHead or NPCID.Harpy) return Main.maxNPCs;
        return orig(source, X, Y, Type, Start, ai0, ai1, ai2, ai3, Target);
    }
}
