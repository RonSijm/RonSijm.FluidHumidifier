// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Personalize;

public class RecipeFactory(string resourceName = null, Action<Humidifier.Personalize.Recipe> factoryAction = null) : ResourceFactory<Humidifier.Personalize.Recipe>(resourceName)
{

    protected override Humidifier.Personalize.Recipe Create()
    {
        var recipeResult = CreateRecipe();
        factoryAction?.Invoke(recipeResult);

        return recipeResult;
    }

    private Humidifier.Personalize.Recipe CreateRecipe()
    {
        var recipeResult = new Humidifier.Personalize.Recipe
        {
            GivenName = InputResourceName,
        };

        return recipeResult;
    }

} // End Of Class

public static class RecipeFactoryExtensions
{
}
