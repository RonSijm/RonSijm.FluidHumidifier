// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataBrew;

public class InnerRecipeRecipeParametersFactory(Action<Humidifier.DataBrew.RecipeTypes.RecipeParameters> factoryAction = null) : SubResourceFactory<Humidifier.DataBrew.RecipeTypes.RecipeParameters>
{

    internal InnerRecipeInputFactory InputFactory { get; set; }

    protected override Humidifier.DataBrew.RecipeTypes.RecipeParameters Create()
    {
        var recipeParametersResult = CreateRecipeParameters();
        factoryAction?.Invoke(recipeParametersResult);

        return recipeParametersResult;
    }

    private Humidifier.DataBrew.RecipeTypes.RecipeParameters CreateRecipeParameters()
    {
        var recipeParametersResult = new Humidifier.DataBrew.RecipeTypes.RecipeParameters();

        return recipeParametersResult;
    }
    public override void CreateChildren(Humidifier.DataBrew.RecipeTypes.RecipeParameters result)
    {
        base.CreateChildren(result);

        result.Input ??= InputFactory?.Build();
    }

} // End Of Class

public static class InnerRecipeRecipeParametersFactoryExtensions
{
    public static CombinedResult<InnerRecipeRecipeParametersFactory, InnerRecipeInputFactory> WithInput(this InnerRecipeRecipeParametersFactory parentFactory, Action<Humidifier.DataBrew.RecipeTypes.Input> subFactoryAction = null)
    {
        parentFactory.InputFactory = new InnerRecipeInputFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.InputFactory);
    }

    public static CombinedResult<InnerRecipeRecipeParametersFactory, T1, InnerRecipeInputFactory> WithInput<T1>(this CombinedResult<InnerRecipeRecipeParametersFactory, T1> combinedResult, Action<Humidifier.DataBrew.RecipeTypes.Input> subFactoryAction = null) => new (combinedResult, combinedResult, WithInput(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRecipeRecipeParametersFactory, InnerRecipeInputFactory> WithInput<T1>(this CombinedResult<T1, InnerRecipeRecipeParametersFactory> combinedResult, Action<Humidifier.DataBrew.RecipeTypes.Input> subFactoryAction = null) => new (combinedResult, combinedResult, WithInput(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerRecipeRecipeParametersFactory, T1, T2, InnerRecipeInputFactory> WithInput<T1, T2>(this CombinedResult<InnerRecipeRecipeParametersFactory, T1, T2> combinedResult, Action<Humidifier.DataBrew.RecipeTypes.Input> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInput(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRecipeRecipeParametersFactory, T2, InnerRecipeInputFactory> WithInput<T1, T2>(this CombinedResult<T1, InnerRecipeRecipeParametersFactory, T2> combinedResult, Action<Humidifier.DataBrew.RecipeTypes.Input> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInput(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRecipeRecipeParametersFactory, InnerRecipeInputFactory> WithInput<T1, T2>(this CombinedResult<T1, T2, InnerRecipeRecipeParametersFactory> combinedResult, Action<Humidifier.DataBrew.RecipeTypes.Input> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInput(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerRecipeRecipeParametersFactory, T1, T2, T3, InnerRecipeInputFactory> WithInput<T1, T2, T3>(this CombinedResult<InnerRecipeRecipeParametersFactory, T1, T2, T3> combinedResult, Action<Humidifier.DataBrew.RecipeTypes.Input> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInput(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRecipeRecipeParametersFactory, T2, T3, InnerRecipeInputFactory> WithInput<T1, T2, T3>(this CombinedResult<T1, InnerRecipeRecipeParametersFactory, T2, T3> combinedResult, Action<Humidifier.DataBrew.RecipeTypes.Input> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInput(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRecipeRecipeParametersFactory, T3, InnerRecipeInputFactory> WithInput<T1, T2, T3>(this CombinedResult<T1, T2, InnerRecipeRecipeParametersFactory, T3> combinedResult, Action<Humidifier.DataBrew.RecipeTypes.Input> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInput(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerRecipeRecipeParametersFactory, InnerRecipeInputFactory> WithInput<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerRecipeRecipeParametersFactory> combinedResult, Action<Humidifier.DataBrew.RecipeTypes.Input> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInput(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerRecipeRecipeParametersFactory, T1, T2, T3, T4, InnerRecipeInputFactory> WithInput<T1, T2, T3, T4>(this CombinedResult<InnerRecipeRecipeParametersFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DataBrew.RecipeTypes.Input> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInput(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRecipeRecipeParametersFactory, T2, T3, T4, InnerRecipeInputFactory> WithInput<T1, T2, T3, T4>(this CombinedResult<T1, InnerRecipeRecipeParametersFactory, T2, T3, T4> combinedResult, Action<Humidifier.DataBrew.RecipeTypes.Input> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInput(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRecipeRecipeParametersFactory, T3, T4, InnerRecipeInputFactory> WithInput<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerRecipeRecipeParametersFactory, T3, T4> combinedResult, Action<Humidifier.DataBrew.RecipeTypes.Input> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInput(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerRecipeRecipeParametersFactory, T4, InnerRecipeInputFactory> WithInput<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerRecipeRecipeParametersFactory, T4> combinedResult, Action<Humidifier.DataBrew.RecipeTypes.Input> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInput(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerRecipeRecipeParametersFactory, InnerRecipeInputFactory> WithInput<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerRecipeRecipeParametersFactory> combinedResult, Action<Humidifier.DataBrew.RecipeTypes.Input> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInput(combinedResult.T5, subFactoryAction));
}
