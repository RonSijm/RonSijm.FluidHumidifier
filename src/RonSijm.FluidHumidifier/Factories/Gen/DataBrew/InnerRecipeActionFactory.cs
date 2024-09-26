// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataBrew;

public class InnerRecipeActionFactory(Action<Humidifier.DataBrew.RecipeTypes.Action> factoryAction = null) : SubResourceFactory<Humidifier.DataBrew.RecipeTypes.Action>
{

    internal InnerRecipeRecipeParametersFactory ParametersFactory { get; set; }

    protected override Humidifier.DataBrew.RecipeTypes.Action Create()
    {
        var actionResult = CreateAction();
        factoryAction?.Invoke(actionResult);

        return actionResult;
    }

    private Humidifier.DataBrew.RecipeTypes.Action CreateAction()
    {
        var actionResult = new Humidifier.DataBrew.RecipeTypes.Action();

        return actionResult;
    }
    public override void CreateChildren(Humidifier.DataBrew.RecipeTypes.Action result)
    {
        base.CreateChildren(result);

        result.Parameters ??= ParametersFactory?.Build();
    }

} // End Of Class

public static class InnerRecipeActionFactoryExtensions
{
    public static CombinedResult<InnerRecipeActionFactory, InnerRecipeRecipeParametersFactory> WithParameters(this InnerRecipeActionFactory parentFactory, Action<Humidifier.DataBrew.RecipeTypes.RecipeParameters> subFactoryAction = null)
    {
        parentFactory.ParametersFactory = new InnerRecipeRecipeParametersFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ParametersFactory);
    }

    public static CombinedResult<InnerRecipeActionFactory, T1, InnerRecipeRecipeParametersFactory> WithParameters<T1>(this CombinedResult<InnerRecipeActionFactory, T1> combinedResult, Action<Humidifier.DataBrew.RecipeTypes.RecipeParameters> subFactoryAction = null) => new (combinedResult, combinedResult, WithParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRecipeActionFactory, InnerRecipeRecipeParametersFactory> WithParameters<T1>(this CombinedResult<T1, InnerRecipeActionFactory> combinedResult, Action<Humidifier.DataBrew.RecipeTypes.RecipeParameters> subFactoryAction = null) => new (combinedResult, combinedResult, WithParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerRecipeActionFactory, T1, T2, InnerRecipeRecipeParametersFactory> WithParameters<T1, T2>(this CombinedResult<InnerRecipeActionFactory, T1, T2> combinedResult, Action<Humidifier.DataBrew.RecipeTypes.RecipeParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRecipeActionFactory, T2, InnerRecipeRecipeParametersFactory> WithParameters<T1, T2>(this CombinedResult<T1, InnerRecipeActionFactory, T2> combinedResult, Action<Humidifier.DataBrew.RecipeTypes.RecipeParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRecipeActionFactory, InnerRecipeRecipeParametersFactory> WithParameters<T1, T2>(this CombinedResult<T1, T2, InnerRecipeActionFactory> combinedResult, Action<Humidifier.DataBrew.RecipeTypes.RecipeParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithParameters(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerRecipeActionFactory, T1, T2, T3, InnerRecipeRecipeParametersFactory> WithParameters<T1, T2, T3>(this CombinedResult<InnerRecipeActionFactory, T1, T2, T3> combinedResult, Action<Humidifier.DataBrew.RecipeTypes.RecipeParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRecipeActionFactory, T2, T3, InnerRecipeRecipeParametersFactory> WithParameters<T1, T2, T3>(this CombinedResult<T1, InnerRecipeActionFactory, T2, T3> combinedResult, Action<Humidifier.DataBrew.RecipeTypes.RecipeParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRecipeActionFactory, T3, InnerRecipeRecipeParametersFactory> WithParameters<T1, T2, T3>(this CombinedResult<T1, T2, InnerRecipeActionFactory, T3> combinedResult, Action<Humidifier.DataBrew.RecipeTypes.RecipeParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithParameters(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerRecipeActionFactory, InnerRecipeRecipeParametersFactory> WithParameters<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerRecipeActionFactory> combinedResult, Action<Humidifier.DataBrew.RecipeTypes.RecipeParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithParameters(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerRecipeActionFactory, T1, T2, T3, T4, InnerRecipeRecipeParametersFactory> WithParameters<T1, T2, T3, T4>(this CombinedResult<InnerRecipeActionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DataBrew.RecipeTypes.RecipeParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRecipeActionFactory, T2, T3, T4, InnerRecipeRecipeParametersFactory> WithParameters<T1, T2, T3, T4>(this CombinedResult<T1, InnerRecipeActionFactory, T2, T3, T4> combinedResult, Action<Humidifier.DataBrew.RecipeTypes.RecipeParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRecipeActionFactory, T3, T4, InnerRecipeRecipeParametersFactory> WithParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerRecipeActionFactory, T3, T4> combinedResult, Action<Humidifier.DataBrew.RecipeTypes.RecipeParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithParameters(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerRecipeActionFactory, T4, InnerRecipeRecipeParametersFactory> WithParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerRecipeActionFactory, T4> combinedResult, Action<Humidifier.DataBrew.RecipeTypes.RecipeParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithParameters(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerRecipeActionFactory, InnerRecipeRecipeParametersFactory> WithParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerRecipeActionFactory> combinedResult, Action<Humidifier.DataBrew.RecipeTypes.RecipeParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithParameters(combinedResult.T5, subFactoryAction));
}
