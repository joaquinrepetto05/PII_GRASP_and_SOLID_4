namespace Recipies
{
    public class RecipeBuilder
    {
        private Recipe recipe;

        public RecipeBuilder()
        {
            recipe = new Recipe();
        }

        public RecipeBuilder WithFinalProduct(Product finalProduct)
        {
            recipe.FinalProduct = finalProduct;
            return this;
        }

        public RecipeBuilder WithStep(Product input, double quantity, Equipment equipment, int time)
        {
            recipe.AddStep(new Step(input, quantity, equipment, time));
            return this;
        }

        public Recipe Build()
        {
            return recipe;
        }
    }
}