using System.Collections.Generic;
using Terraria.ModLoader;
using Terraria.WorldBuilding;

namespace hostileparadise.World;
public class VanillaSkyGenerationSystem : ModSystem
{
    public override void ModifyWorldGenTasks(List<GenPass> tasks, ref double totalWeight)
    {
        int floatingIslandsIndex = tasks.FindIndex(genpass => genpass.Name.Equals("Floating Islands"));
        int floatingIslandHousesIndex = tasks.FindIndex(genpass => genpass.Name.Equals("Floating Island Houses"));

        if (floatingIslandsIndex == -1) tasks.RemoveAt(floatingIslandsIndex);
        if (floatingIslandHousesIndex == -1) tasks.RemoveAt(floatingIslandHousesIndex);
    }
}
