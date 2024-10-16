// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.OpsWorks;

public class InnerLayerRecipesFactory(Action<Humidifier.OpsWorks.LayerTypes.Recipes> factoryAction = null) : SubResourceFactory<Humidifier.OpsWorks.LayerTypes.Recipes>
{

    protected override Humidifier.OpsWorks.LayerTypes.Recipes Create()
    {
        var recipesResult = CreateRecipes();
        factoryAction?.Invoke(recipesResult);

        return recipesResult;
    }

    private Humidifier.OpsWorks.LayerTypes.Recipes CreateRecipes()
    {
        var recipesResult = new Humidifier.OpsWorks.LayerTypes.Recipes();

        return recipesResult;
    }

} // End Of Class

public static class InnerLayerRecipesFactoryExtensions
{
}
