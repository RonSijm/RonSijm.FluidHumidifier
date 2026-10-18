// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataBrew;

public class InnerJobRecipeFactory(Action<Humidifier.DataBrew.JobTypes.Recipe> factoryAction = null) : SubResourceFactory<Humidifier.DataBrew.JobTypes.Recipe>
{

    protected override Humidifier.DataBrew.JobTypes.Recipe Create()
    {
        var recipeResult = CreateRecipe();
        factoryAction?.Invoke(recipeResult);

        return recipeResult;
    }

    private Humidifier.DataBrew.JobTypes.Recipe CreateRecipe()
    {
        var recipeResult = new Humidifier.DataBrew.JobTypes.Recipe();

        return recipeResult;
    }

} // End Of Class

public static class InnerJobRecipeFactoryExtensions
{
}
