// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GreengrassV2;

public class InnerComponentVersionLambdaFunctionRecipeSourceFactory(Action<Humidifier.GreengrassV2.ComponentVersionTypes.LambdaFunctionRecipeSource> factoryAction = null) : SubResourceFactory<Humidifier.GreengrassV2.ComponentVersionTypes.LambdaFunctionRecipeSource>
{

    internal InnerComponentVersionLambdaExecutionParametersFactory ComponentLambdaParametersFactory { get; set; }

    protected override Humidifier.GreengrassV2.ComponentVersionTypes.LambdaFunctionRecipeSource Create()
    {
        var lambdaFunctionRecipeSourceResult = CreateLambdaFunctionRecipeSource();
        factoryAction?.Invoke(lambdaFunctionRecipeSourceResult);

        return lambdaFunctionRecipeSourceResult;
    }

    private Humidifier.GreengrassV2.ComponentVersionTypes.LambdaFunctionRecipeSource CreateLambdaFunctionRecipeSource()
    {
        var lambdaFunctionRecipeSourceResult = new Humidifier.GreengrassV2.ComponentVersionTypes.LambdaFunctionRecipeSource();

        return lambdaFunctionRecipeSourceResult;
    }
    public override void CreateChildren(Humidifier.GreengrassV2.ComponentVersionTypes.LambdaFunctionRecipeSource result)
    {
        base.CreateChildren(result);

        result.ComponentLambdaParameters ??= ComponentLambdaParametersFactory?.Build();
    }

} // End Of Class

public static class InnerComponentVersionLambdaFunctionRecipeSourceFactoryExtensions
{
    public static CombinedResult<InnerComponentVersionLambdaFunctionRecipeSourceFactory, InnerComponentVersionLambdaExecutionParametersFactory> WithComponentLambdaParameters(this InnerComponentVersionLambdaFunctionRecipeSourceFactory parentFactory, Action<Humidifier.GreengrassV2.ComponentVersionTypes.LambdaExecutionParameters> subFactoryAction = null)
    {
        parentFactory.ComponentLambdaParametersFactory = new InnerComponentVersionLambdaExecutionParametersFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ComponentLambdaParametersFactory);
    }

    public static CombinedResult<InnerComponentVersionLambdaFunctionRecipeSourceFactory, T1, InnerComponentVersionLambdaExecutionParametersFactory> WithComponentLambdaParameters<T1>(this CombinedResult<InnerComponentVersionLambdaFunctionRecipeSourceFactory, T1> combinedResult, Action<Humidifier.GreengrassV2.ComponentVersionTypes.LambdaExecutionParameters> subFactoryAction = null) => new (combinedResult, combinedResult, WithComponentLambdaParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerComponentVersionLambdaFunctionRecipeSourceFactory, InnerComponentVersionLambdaExecutionParametersFactory> WithComponentLambdaParameters<T1>(this CombinedResult<T1, InnerComponentVersionLambdaFunctionRecipeSourceFactory> combinedResult, Action<Humidifier.GreengrassV2.ComponentVersionTypes.LambdaExecutionParameters> subFactoryAction = null) => new (combinedResult, combinedResult, WithComponentLambdaParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerComponentVersionLambdaFunctionRecipeSourceFactory, T1, T2, InnerComponentVersionLambdaExecutionParametersFactory> WithComponentLambdaParameters<T1, T2>(this CombinedResult<InnerComponentVersionLambdaFunctionRecipeSourceFactory, T1, T2> combinedResult, Action<Humidifier.GreengrassV2.ComponentVersionTypes.LambdaExecutionParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithComponentLambdaParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerComponentVersionLambdaFunctionRecipeSourceFactory, T2, InnerComponentVersionLambdaExecutionParametersFactory> WithComponentLambdaParameters<T1, T2>(this CombinedResult<T1, InnerComponentVersionLambdaFunctionRecipeSourceFactory, T2> combinedResult, Action<Humidifier.GreengrassV2.ComponentVersionTypes.LambdaExecutionParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithComponentLambdaParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerComponentVersionLambdaFunctionRecipeSourceFactory, InnerComponentVersionLambdaExecutionParametersFactory> WithComponentLambdaParameters<T1, T2>(this CombinedResult<T1, T2, InnerComponentVersionLambdaFunctionRecipeSourceFactory> combinedResult, Action<Humidifier.GreengrassV2.ComponentVersionTypes.LambdaExecutionParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithComponentLambdaParameters(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerComponentVersionLambdaFunctionRecipeSourceFactory, T1, T2, T3, InnerComponentVersionLambdaExecutionParametersFactory> WithComponentLambdaParameters<T1, T2, T3>(this CombinedResult<InnerComponentVersionLambdaFunctionRecipeSourceFactory, T1, T2, T3> combinedResult, Action<Humidifier.GreengrassV2.ComponentVersionTypes.LambdaExecutionParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithComponentLambdaParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerComponentVersionLambdaFunctionRecipeSourceFactory, T2, T3, InnerComponentVersionLambdaExecutionParametersFactory> WithComponentLambdaParameters<T1, T2, T3>(this CombinedResult<T1, InnerComponentVersionLambdaFunctionRecipeSourceFactory, T2, T3> combinedResult, Action<Humidifier.GreengrassV2.ComponentVersionTypes.LambdaExecutionParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithComponentLambdaParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerComponentVersionLambdaFunctionRecipeSourceFactory, T3, InnerComponentVersionLambdaExecutionParametersFactory> WithComponentLambdaParameters<T1, T2, T3>(this CombinedResult<T1, T2, InnerComponentVersionLambdaFunctionRecipeSourceFactory, T3> combinedResult, Action<Humidifier.GreengrassV2.ComponentVersionTypes.LambdaExecutionParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithComponentLambdaParameters(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerComponentVersionLambdaFunctionRecipeSourceFactory, InnerComponentVersionLambdaExecutionParametersFactory> WithComponentLambdaParameters<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerComponentVersionLambdaFunctionRecipeSourceFactory> combinedResult, Action<Humidifier.GreengrassV2.ComponentVersionTypes.LambdaExecutionParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithComponentLambdaParameters(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerComponentVersionLambdaFunctionRecipeSourceFactory, T1, T2, T3, T4, InnerComponentVersionLambdaExecutionParametersFactory> WithComponentLambdaParameters<T1, T2, T3, T4>(this CombinedResult<InnerComponentVersionLambdaFunctionRecipeSourceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.GreengrassV2.ComponentVersionTypes.LambdaExecutionParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithComponentLambdaParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerComponentVersionLambdaFunctionRecipeSourceFactory, T2, T3, T4, InnerComponentVersionLambdaExecutionParametersFactory> WithComponentLambdaParameters<T1, T2, T3, T4>(this CombinedResult<T1, InnerComponentVersionLambdaFunctionRecipeSourceFactory, T2, T3, T4> combinedResult, Action<Humidifier.GreengrassV2.ComponentVersionTypes.LambdaExecutionParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithComponentLambdaParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerComponentVersionLambdaFunctionRecipeSourceFactory, T3, T4, InnerComponentVersionLambdaExecutionParametersFactory> WithComponentLambdaParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerComponentVersionLambdaFunctionRecipeSourceFactory, T3, T4> combinedResult, Action<Humidifier.GreengrassV2.ComponentVersionTypes.LambdaExecutionParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithComponentLambdaParameters(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerComponentVersionLambdaFunctionRecipeSourceFactory, T4, InnerComponentVersionLambdaExecutionParametersFactory> WithComponentLambdaParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerComponentVersionLambdaFunctionRecipeSourceFactory, T4> combinedResult, Action<Humidifier.GreengrassV2.ComponentVersionTypes.LambdaExecutionParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithComponentLambdaParameters(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerComponentVersionLambdaFunctionRecipeSourceFactory, InnerComponentVersionLambdaExecutionParametersFactory> WithComponentLambdaParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerComponentVersionLambdaFunctionRecipeSourceFactory> combinedResult, Action<Humidifier.GreengrassV2.ComponentVersionTypes.LambdaExecutionParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithComponentLambdaParameters(combinedResult.T5, subFactoryAction));
}
