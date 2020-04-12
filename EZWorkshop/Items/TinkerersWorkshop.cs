using Terraria.ID;
using Terraria.ModLoader;

namespace EZWorkshop.Items
{
	public class TinkerersWorkshop : ModItem
	{
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(9, 500);
            recipe.AddIngredient(225, 50);
            recipe.AddIngredient(149, 10);
            recipe.AddTile(18);
            recipe.SetResult(398);
            recipe.AddRecipe();
        }
    }
}