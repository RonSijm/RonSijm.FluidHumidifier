// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataBrew;

public class InnerRecipeRecipeStepFactory(Action<Humidifier.DataBrew.RecipeTypes.RecipeStep> factoryAction = null) : SubResourceFactory<Humidifier.DataBrew.RecipeTypes.RecipeStep>
{

    internal InnerRecipeActionFactory ActionFactory { get; set; }

    protected override Humidifier.DataBrew.RecipeTypes.RecipeStep Create()
    {
        var recipeStepResult = CreateRecipeStep();
        factoryAction?.Invoke(recipeStepResult);

        return recipeStepResult;
    }

    private Humidifier.DataBrew.RecipeTypes.RecipeStep CreateRecipeStep()
    {
        var recipeStepResult = new Humidifier.DataBrew.RecipeTypes.RecipeStep();

        return recipeStepResult;
    }
    public override void CreateChildren(Humidifier.DataBrew.RecipeTypes.RecipeStep result)
    {
        base.CreateChildren(result);

        result.Action ??= ActionFactory?.Build();
    }

} // End Of Class

public static class InnerRecipeRecipeStepFactoryExtensions
{
    public static CombinedResult<InnerRecipeRecipeStepFactory, InnerRecipeActionFactory> WithAction(this InnerRecipeRecipeStepFactory parentFactory, Action<Humidifier.DataBrew.RecipeTypes.Action> subFactoryAction = null)
    {
        parentFactory.ActionFactory = new InnerRecipeActionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ActionFactory);
    }

    public static CombinedResult<InnerRecipeRecipeStepFactory, T1, InnerRecipeActionFactory> WithAction<T1>(this CombinedResult<InnerRecipeRecipeStepFactory, T1> combinedResult, Action<Humidifier.DataBrew.RecipeTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, WithAction(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRecipeRecipeStepFactory, InnerRecipeActionFactory> WithAction<T1>(this CombinedResult<T1, InnerRecipeRecipeStepFactory> combinedResult, Action<Humidifier.DataBrew.RecipeTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, WithAction(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerRecipeRecipeStepFactory, T1, T2, InnerRecipeActionFactory> WithAction<T1, T2>(this CombinedResult<InnerRecipeRecipeStepFactory, T1, T2> combinedResult, Action<Humidifier.DataBrew.RecipeTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRecipeRecipeStepFactory, T2, InnerRecipeActionFactory> WithAction<T1, T2>(this CombinedResult<T1, InnerRecipeRecipeStepFactory, T2> combinedResult, Action<Humidifier.DataBrew.RecipeTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRecipeRecipeStepFactory, InnerRecipeActionFactory> WithAction<T1, T2>(this CombinedResult<T1, T2, InnerRecipeRecipeStepFactory> combinedResult, Action<Humidifier.DataBrew.RecipeTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerRecipeRecipeStepFactory, T1, T2, T3, InnerRecipeActionFactory> WithAction<T1, T2, T3>(this CombinedResult<InnerRecipeRecipeStepFactory, T1, T2, T3> combinedResult, Action<Humidifier.DataBrew.RecipeTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRecipeRecipeStepFactory, T2, T3, InnerRecipeActionFactory> WithAction<T1, T2, T3>(this CombinedResult<T1, InnerRecipeRecipeStepFactory, T2, T3> combinedResult, Action<Humidifier.DataBrew.RecipeTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRecipeRecipeStepFactory, T3, InnerRecipeActionFactory> WithAction<T1, T2, T3>(this CombinedResult<T1, T2, InnerRecipeRecipeStepFactory, T3> combinedResult, Action<Humidifier.DataBrew.RecipeTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerRecipeRecipeStepFactory, InnerRecipeActionFactory> WithAction<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerRecipeRecipeStepFactory> combinedResult, Action<Humidifier.DataBrew.RecipeTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerRecipeRecipeStepFactory, T1, T2, T3, T4, InnerRecipeActionFactory> WithAction<T1, T2, T3, T4>(this CombinedResult<InnerRecipeRecipeStepFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DataBrew.RecipeTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRecipeRecipeStepFactory, T2, T3, T4, InnerRecipeActionFactory> WithAction<T1, T2, T3, T4>(this CombinedResult<T1, InnerRecipeRecipeStepFactory, T2, T3, T4> combinedResult, Action<Humidifier.DataBrew.RecipeTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRecipeRecipeStepFactory, T3, T4, InnerRecipeActionFactory> WithAction<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerRecipeRecipeStepFactory, T3, T4> combinedResult, Action<Humidifier.DataBrew.RecipeTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerRecipeRecipeStepFactory, T4, InnerRecipeActionFactory> WithAction<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerRecipeRecipeStepFactory, T4> combinedResult, Action<Humidifier.DataBrew.RecipeTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerRecipeRecipeStepFactory, InnerRecipeActionFactory> WithAction<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerRecipeRecipeStepFactory> combinedResult, Action<Humidifier.DataBrew.RecipeTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T5, subFactoryAction));
}
