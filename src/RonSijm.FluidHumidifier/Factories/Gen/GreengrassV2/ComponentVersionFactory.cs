// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GreengrassV2;

public class ComponentVersionFactory(string resourceName = null, Action<Humidifier.GreengrassV2.ComponentVersion> factoryAction = null) : ResourceFactory<Humidifier.GreengrassV2.ComponentVersion>(resourceName)
{

    internal InnerComponentVersionLambdaFunctionRecipeSourceFactory LambdaFunctionFactory { get; set; }

    protected override Humidifier.GreengrassV2.ComponentVersion Create()
    {
        var componentVersionResult = CreateComponentVersion();
        factoryAction?.Invoke(componentVersionResult);

        return componentVersionResult;
    }

    private Humidifier.GreengrassV2.ComponentVersion CreateComponentVersion()
    {
        var componentVersionResult = new Humidifier.GreengrassV2.ComponentVersion
        {
            GivenName = InputResourceName,
        };

        return componentVersionResult;
    }
    public override void CreateChildren(Humidifier.GreengrassV2.ComponentVersion result)
    {
        base.CreateChildren(result);

        result.LambdaFunction ??= LambdaFunctionFactory?.Build();
    }

} // End Of Class

public static class ComponentVersionFactoryExtensions
{
    public static CombinedResult<ComponentVersionFactory, InnerComponentVersionLambdaFunctionRecipeSourceFactory> WithLambdaFunction(this ComponentVersionFactory parentFactory, Action<Humidifier.GreengrassV2.ComponentVersionTypes.LambdaFunctionRecipeSource> subFactoryAction = null)
    {
        parentFactory.LambdaFunctionFactory = new InnerComponentVersionLambdaFunctionRecipeSourceFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.LambdaFunctionFactory);
    }

    public static CombinedResult<ComponentVersionFactory, T1, InnerComponentVersionLambdaFunctionRecipeSourceFactory> WithLambdaFunction<T1>(this CombinedResult<ComponentVersionFactory, T1> combinedResult, Action<Humidifier.GreengrassV2.ComponentVersionTypes.LambdaFunctionRecipeSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithLambdaFunction(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ComponentVersionFactory, InnerComponentVersionLambdaFunctionRecipeSourceFactory> WithLambdaFunction<T1>(this CombinedResult<T1, ComponentVersionFactory> combinedResult, Action<Humidifier.GreengrassV2.ComponentVersionTypes.LambdaFunctionRecipeSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithLambdaFunction(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ComponentVersionFactory, T1, T2, InnerComponentVersionLambdaFunctionRecipeSourceFactory> WithLambdaFunction<T1, T2>(this CombinedResult<ComponentVersionFactory, T1, T2> combinedResult, Action<Humidifier.GreengrassV2.ComponentVersionTypes.LambdaFunctionRecipeSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLambdaFunction(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ComponentVersionFactory, T2, InnerComponentVersionLambdaFunctionRecipeSourceFactory> WithLambdaFunction<T1, T2>(this CombinedResult<T1, ComponentVersionFactory, T2> combinedResult, Action<Humidifier.GreengrassV2.ComponentVersionTypes.LambdaFunctionRecipeSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLambdaFunction(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ComponentVersionFactory, InnerComponentVersionLambdaFunctionRecipeSourceFactory> WithLambdaFunction<T1, T2>(this CombinedResult<T1, T2, ComponentVersionFactory> combinedResult, Action<Humidifier.GreengrassV2.ComponentVersionTypes.LambdaFunctionRecipeSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLambdaFunction(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ComponentVersionFactory, T1, T2, T3, InnerComponentVersionLambdaFunctionRecipeSourceFactory> WithLambdaFunction<T1, T2, T3>(this CombinedResult<ComponentVersionFactory, T1, T2, T3> combinedResult, Action<Humidifier.GreengrassV2.ComponentVersionTypes.LambdaFunctionRecipeSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLambdaFunction(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ComponentVersionFactory, T2, T3, InnerComponentVersionLambdaFunctionRecipeSourceFactory> WithLambdaFunction<T1, T2, T3>(this CombinedResult<T1, ComponentVersionFactory, T2, T3> combinedResult, Action<Humidifier.GreengrassV2.ComponentVersionTypes.LambdaFunctionRecipeSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLambdaFunction(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ComponentVersionFactory, T3, InnerComponentVersionLambdaFunctionRecipeSourceFactory> WithLambdaFunction<T1, T2, T3>(this CombinedResult<T1, T2, ComponentVersionFactory, T3> combinedResult, Action<Humidifier.GreengrassV2.ComponentVersionTypes.LambdaFunctionRecipeSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLambdaFunction(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ComponentVersionFactory, InnerComponentVersionLambdaFunctionRecipeSourceFactory> WithLambdaFunction<T1, T2, T3>(this CombinedResult<T1, T2, T3, ComponentVersionFactory> combinedResult, Action<Humidifier.GreengrassV2.ComponentVersionTypes.LambdaFunctionRecipeSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLambdaFunction(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ComponentVersionFactory, T1, T2, T3, T4, InnerComponentVersionLambdaFunctionRecipeSourceFactory> WithLambdaFunction<T1, T2, T3, T4>(this CombinedResult<ComponentVersionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.GreengrassV2.ComponentVersionTypes.LambdaFunctionRecipeSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLambdaFunction(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ComponentVersionFactory, T2, T3, T4, InnerComponentVersionLambdaFunctionRecipeSourceFactory> WithLambdaFunction<T1, T2, T3, T4>(this CombinedResult<T1, ComponentVersionFactory, T2, T3, T4> combinedResult, Action<Humidifier.GreengrassV2.ComponentVersionTypes.LambdaFunctionRecipeSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLambdaFunction(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ComponentVersionFactory, T3, T4, InnerComponentVersionLambdaFunctionRecipeSourceFactory> WithLambdaFunction<T1, T2, T3, T4>(this CombinedResult<T1, T2, ComponentVersionFactory, T3, T4> combinedResult, Action<Humidifier.GreengrassV2.ComponentVersionTypes.LambdaFunctionRecipeSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLambdaFunction(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ComponentVersionFactory, T4, InnerComponentVersionLambdaFunctionRecipeSourceFactory> WithLambdaFunction<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ComponentVersionFactory, T4> combinedResult, Action<Humidifier.GreengrassV2.ComponentVersionTypes.LambdaFunctionRecipeSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLambdaFunction(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ComponentVersionFactory, InnerComponentVersionLambdaFunctionRecipeSourceFactory> WithLambdaFunction<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ComponentVersionFactory> combinedResult, Action<Humidifier.GreengrassV2.ComponentVersionTypes.LambdaFunctionRecipeSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLambdaFunction(combinedResult.T5, subFactoryAction));
}
