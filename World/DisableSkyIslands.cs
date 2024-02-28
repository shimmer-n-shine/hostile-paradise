using System.Collections.Generic;
using Terraria.ModLoader;
using Terraria.WorldBuilding;

namespace hostileparadise.World;
public class DisableSkyIslands : ModSystem
{
    public override void ModifyWorldGenTasks(List<GenPass> tasks, ref double totalWeight)
    {
        int floatingIslandsIndex = tasks.FindIndex(genpass => genpass.Name.Equals("Floating Islands"));
        if (floatingIslandsIndex != -1) tasks.RemoveAt(floatingIslandsIndex);

        int floatingIslandHousesIndex = tasks.FindIndex(genpass => genpass.Name.Equals("Floating Island Houses"));
        if (floatingIslandHousesIndex != -1) tasks.RemoveAt(floatingIslandHousesIndex);
    }
}
