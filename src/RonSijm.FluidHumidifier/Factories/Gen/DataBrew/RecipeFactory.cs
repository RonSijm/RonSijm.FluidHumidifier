// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataBrew;

public class RecipeFactory(string resourceName = null, Action<Humidifier.DataBrew.Recipe> factoryAction = null) : ResourceFactory<Humidifier.DataBrew.Recipe>(resourceName)
{

    internal List<InnerRecipeRecipeStepFactory> StepsFactories { get; set; } = [];

    protected override Humidifier.DataBrew.Recipe Create()
    {
        var recipeResult = CreateRecipe();
        factoryAction?.Invoke(recipeResult);

        return recipeResult;
    }

    private Humidifier.DataBrew.Recipe CreateRecipe()
    {
        var recipeResult = new Humidifier.DataBrew.Recipe
        {
            GivenName = InputResourceName,
        };

        return recipeResult;
    }
    public override void CreateChildren(Humidifier.DataBrew.Recipe result)
    {
        base.CreateChildren(result);

        result.Steps = StepsFactories.Any() ? StepsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class RecipeFactoryExtensions
{
    public static CombinedResult<RecipeFactory, InnerRecipeRecipeStepFactory> WithSteps(this RecipeFactory parentFactory, Action<Humidifier.DataBrew.RecipeTypes.RecipeStep> subFactoryAction = null)
    {
        var factory = new InnerRecipeRecipeStepFactory(subFactoryAction);
        parentFactory.StepsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<RecipeFactory, T1, InnerRecipeRecipeStepFactory> WithSteps<T1>(this CombinedResult<RecipeFactory, T1> combinedResult, Action<Humidifier.DataBrew.RecipeTypes.RecipeStep> subFactoryAction = null) => new (combinedResult, combinedResult, WithSteps(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RecipeFactory, InnerRecipeRecipeStepFactory> WithSteps<T1>(this CombinedResult<T1, RecipeFactory> combinedResult, Action<Humidifier.DataBrew.RecipeTypes.RecipeStep> subFactoryAction = null) => new (combinedResult, combinedResult, WithSteps(combinedResult.T2, subFactoryAction));
    public static CombinedResult<RecipeFactory, T1, T2, InnerRecipeRecipeStepFactory> WithSteps<T1, T2>(this CombinedResult<RecipeFactory, T1, T2> combinedResult, Action<Humidifier.DataBrew.RecipeTypes.RecipeStep> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSteps(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RecipeFactory, T2, InnerRecipeRecipeStepFactory> WithSteps<T1, T2>(this CombinedResult<T1, RecipeFactory, T2> combinedResult, Action<Humidifier.DataBrew.RecipeTypes.RecipeStep> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSteps(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, RecipeFactory, InnerRecipeRecipeStepFactory> WithSteps<T1, T2>(this CombinedResult<T1, T2, RecipeFactory> combinedResult, Action<Humidifier.DataBrew.RecipeTypes.RecipeStep> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSteps(combinedResult.T3, subFactoryAction));
    public static CombinedResult<RecipeFactory, T1, T2, T3, InnerRecipeRecipeStepFactory> WithSteps<T1, T2, T3>(this CombinedResult<RecipeFactory, T1, T2, T3> combinedResult, Action<Humidifier.DataBrew.RecipeTypes.RecipeStep> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSteps(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RecipeFactory, T2, T3, InnerRecipeRecipeStepFactory> WithSteps<T1, T2, T3>(this CombinedResult<T1, RecipeFactory, T2, T3> combinedResult, Action<Humidifier.DataBrew.RecipeTypes.RecipeStep> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSteps(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, RecipeFactory, T3, InnerRecipeRecipeStepFactory> WithSteps<T1, T2, T3>(this CombinedResult<T1, T2, RecipeFactory, T3> combinedResult, Action<Humidifier.DataBrew.RecipeTypes.RecipeStep> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSteps(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, RecipeFactory, InnerRecipeRecipeStepFactory> WithSteps<T1, T2, T3>(this CombinedResult<T1, T2, T3, RecipeFactory> combinedResult, Action<Humidifier.DataBrew.RecipeTypes.RecipeStep> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSteps(combinedResult.T4, subFactoryAction));
    public static CombinedResult<RecipeFactory, T1, T2, T3, T4, InnerRecipeRecipeStepFactory> WithSteps<T1, T2, T3, T4>(this CombinedResult<RecipeFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DataBrew.RecipeTypes.RecipeStep> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSteps(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RecipeFactory, T2, T3, T4, InnerRecipeRecipeStepFactory> WithSteps<T1, T2, T3, T4>(this CombinedResult<T1, RecipeFactory, T2, T3, T4> combinedResult, Action<Humidifier.DataBrew.RecipeTypes.RecipeStep> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSteps(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, RecipeFactory, T3, T4, InnerRecipeRecipeStepFactory> WithSteps<T1, T2, T3, T4>(this CombinedResult<T1, T2, RecipeFactory, T3, T4> combinedResult, Action<Humidifier.DataBrew.RecipeTypes.RecipeStep> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSteps(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, RecipeFactory, T4, InnerRecipeRecipeStepFactory> WithSteps<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, RecipeFactory, T4> combinedResult, Action<Humidifier.DataBrew.RecipeTypes.RecipeStep> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSteps(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, RecipeFactory, InnerRecipeRecipeStepFactory> WithSteps<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, RecipeFactory> combinedResult, Action<Humidifier.DataBrew.RecipeTypes.RecipeStep> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSteps(combinedResult.T5, subFactoryAction));
}
