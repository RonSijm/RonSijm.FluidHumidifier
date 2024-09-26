// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFront;

public class FunctionFactory(string resourceName = null, Action<Humidifier.CloudFront.Function> factoryAction = null) : ResourceFactory<Humidifier.CloudFront.Function>(resourceName)
{

    internal InnerFunctionFunctionConfigFactory FunctionConfigFactory { get; set; }

    internal InnerFunctionFunctionMetadataFactory FunctionMetadataFactory { get; set; }

    protected override Humidifier.CloudFront.Function Create()
    {
        var functionResult = CreateFunction();
        factoryAction?.Invoke(functionResult);

        return functionResult;
    }

    private Humidifier.CloudFront.Function CreateFunction()
    {
        var functionResult = new Humidifier.CloudFront.Function
        {
            GivenName = InputResourceName,
        };

        return functionResult;
    }
    public override void CreateChildren(Humidifier.CloudFront.Function result)
    {
        base.CreateChildren(result);

        result.FunctionConfig ??= FunctionConfigFactory?.Build();
        result.FunctionMetadata ??= FunctionMetadataFactory?.Build();
    }

} // End Of Class

public static class FunctionFactoryExtensions
{
    public static CombinedResult<FunctionFactory, InnerFunctionFunctionConfigFactory> WithFunctionConfig(this FunctionFactory parentFactory, Action<Humidifier.CloudFront.FunctionTypes.FunctionConfig> subFactoryAction = null)
    {
        parentFactory.FunctionConfigFactory = new InnerFunctionFunctionConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.FunctionConfigFactory);
    }

    public static CombinedResult<FunctionFactory, InnerFunctionFunctionMetadataFactory> WithFunctionMetadata(this FunctionFactory parentFactory, Action<Humidifier.CloudFront.FunctionTypes.FunctionMetadata> subFactoryAction = null)
    {
        parentFactory.FunctionMetadataFactory = new InnerFunctionFunctionMetadataFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.FunctionMetadataFactory);
    }

    public static CombinedResult<FunctionFactory, T1, InnerFunctionFunctionConfigFactory> WithFunctionConfig<T1>(this CombinedResult<FunctionFactory, T1> combinedResult, Action<Humidifier.CloudFront.FunctionTypes.FunctionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithFunctionConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FunctionFactory, InnerFunctionFunctionConfigFactory> WithFunctionConfig<T1>(this CombinedResult<T1, FunctionFactory> combinedResult, Action<Humidifier.CloudFront.FunctionTypes.FunctionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithFunctionConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<FunctionFactory, T1, T2, InnerFunctionFunctionConfigFactory> WithFunctionConfig<T1, T2>(this CombinedResult<FunctionFactory, T1, T2> combinedResult, Action<Humidifier.CloudFront.FunctionTypes.FunctionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFunctionConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FunctionFactory, T2, InnerFunctionFunctionConfigFactory> WithFunctionConfig<T1, T2>(this CombinedResult<T1, FunctionFactory, T2> combinedResult, Action<Humidifier.CloudFront.FunctionTypes.FunctionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFunctionConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FunctionFactory, InnerFunctionFunctionConfigFactory> WithFunctionConfig<T1, T2>(this CombinedResult<T1, T2, FunctionFactory> combinedResult, Action<Humidifier.CloudFront.FunctionTypes.FunctionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFunctionConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<FunctionFactory, T1, T2, T3, InnerFunctionFunctionConfigFactory> WithFunctionConfig<T1, T2, T3>(this CombinedResult<FunctionFactory, T1, T2, T3> combinedResult, Action<Humidifier.CloudFront.FunctionTypes.FunctionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFunctionConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FunctionFactory, T2, T3, InnerFunctionFunctionConfigFactory> WithFunctionConfig<T1, T2, T3>(this CombinedResult<T1, FunctionFactory, T2, T3> combinedResult, Action<Humidifier.CloudFront.FunctionTypes.FunctionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFunctionConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FunctionFactory, T3, InnerFunctionFunctionConfigFactory> WithFunctionConfig<T1, T2, T3>(this CombinedResult<T1, T2, FunctionFactory, T3> combinedResult, Action<Humidifier.CloudFront.FunctionTypes.FunctionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFunctionConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, FunctionFactory, InnerFunctionFunctionConfigFactory> WithFunctionConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, FunctionFactory> combinedResult, Action<Humidifier.CloudFront.FunctionTypes.FunctionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFunctionConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<FunctionFactory, T1, T2, T3, T4, InnerFunctionFunctionConfigFactory> WithFunctionConfig<T1, T2, T3, T4>(this CombinedResult<FunctionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CloudFront.FunctionTypes.FunctionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFunctionConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FunctionFactory, T2, T3, T4, InnerFunctionFunctionConfigFactory> WithFunctionConfig<T1, T2, T3, T4>(this CombinedResult<T1, FunctionFactory, T2, T3, T4> combinedResult, Action<Humidifier.CloudFront.FunctionTypes.FunctionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFunctionConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FunctionFactory, T3, T4, InnerFunctionFunctionConfigFactory> WithFunctionConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, FunctionFactory, T3, T4> combinedResult, Action<Humidifier.CloudFront.FunctionTypes.FunctionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFunctionConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, FunctionFactory, T4, InnerFunctionFunctionConfigFactory> WithFunctionConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, FunctionFactory, T4> combinedResult, Action<Humidifier.CloudFront.FunctionTypes.FunctionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFunctionConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, FunctionFactory, InnerFunctionFunctionConfigFactory> WithFunctionConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, FunctionFactory> combinedResult, Action<Humidifier.CloudFront.FunctionTypes.FunctionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFunctionConfig(combinedResult.T5, subFactoryAction));
    public static CombinedResult<FunctionFactory, T1, InnerFunctionFunctionMetadataFactory> WithFunctionMetadata<T1>(this CombinedResult<FunctionFactory, T1> combinedResult, Action<Humidifier.CloudFront.FunctionTypes.FunctionMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, WithFunctionMetadata(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FunctionFactory, InnerFunctionFunctionMetadataFactory> WithFunctionMetadata<T1>(this CombinedResult<T1, FunctionFactory> combinedResult, Action<Humidifier.CloudFront.FunctionTypes.FunctionMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, WithFunctionMetadata(combinedResult.T2, subFactoryAction));
    public static CombinedResult<FunctionFactory, T1, T2, InnerFunctionFunctionMetadataFactory> WithFunctionMetadata<T1, T2>(this CombinedResult<FunctionFactory, T1, T2> combinedResult, Action<Humidifier.CloudFront.FunctionTypes.FunctionMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFunctionMetadata(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FunctionFactory, T2, InnerFunctionFunctionMetadataFactory> WithFunctionMetadata<T1, T2>(this CombinedResult<T1, FunctionFactory, T2> combinedResult, Action<Humidifier.CloudFront.FunctionTypes.FunctionMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFunctionMetadata(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FunctionFactory, InnerFunctionFunctionMetadataFactory> WithFunctionMetadata<T1, T2>(this CombinedResult<T1, T2, FunctionFactory> combinedResult, Action<Humidifier.CloudFront.FunctionTypes.FunctionMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFunctionMetadata(combinedResult.T3, subFactoryAction));
    public static CombinedResult<FunctionFactory, T1, T2, T3, InnerFunctionFunctionMetadataFactory> WithFunctionMetadata<T1, T2, T3>(this CombinedResult<FunctionFactory, T1, T2, T3> combinedResult, Action<Humidifier.CloudFront.FunctionTypes.FunctionMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFunctionMetadata(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FunctionFactory, T2, T3, InnerFunctionFunctionMetadataFactory> WithFunctionMetadata<T1, T2, T3>(this CombinedResult<T1, FunctionFactory, T2, T3> combinedResult, Action<Humidifier.CloudFront.FunctionTypes.FunctionMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFunctionMetadata(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FunctionFactory, T3, InnerFunctionFunctionMetadataFactory> WithFunctionMetadata<T1, T2, T3>(this CombinedResult<T1, T2, FunctionFactory, T3> combinedResult, Action<Humidifier.CloudFront.FunctionTypes.FunctionMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFunctionMetadata(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, FunctionFactory, InnerFunctionFunctionMetadataFactory> WithFunctionMetadata<T1, T2, T3>(this CombinedResult<T1, T2, T3, FunctionFactory> combinedResult, Action<Humidifier.CloudFront.FunctionTypes.FunctionMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFunctionMetadata(combinedResult.T4, subFactoryAction));
    public static CombinedResult<FunctionFactory, T1, T2, T3, T4, InnerFunctionFunctionMetadataFactory> WithFunctionMetadata<T1, T2, T3, T4>(this CombinedResult<FunctionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CloudFront.FunctionTypes.FunctionMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFunctionMetadata(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FunctionFactory, T2, T3, T4, InnerFunctionFunctionMetadataFactory> WithFunctionMetadata<T1, T2, T3, T4>(this CombinedResult<T1, FunctionFactory, T2, T3, T4> combinedResult, Action<Humidifier.CloudFront.FunctionTypes.FunctionMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFunctionMetadata(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FunctionFactory, T3, T4, InnerFunctionFunctionMetadataFactory> WithFunctionMetadata<T1, T2, T3, T4>(this CombinedResult<T1, T2, FunctionFactory, T3, T4> combinedResult, Action<Humidifier.CloudFront.FunctionTypes.FunctionMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFunctionMetadata(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, FunctionFactory, T4, InnerFunctionFunctionMetadataFactory> WithFunctionMetadata<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, FunctionFactory, T4> combinedResult, Action<Humidifier.CloudFront.FunctionTypes.FunctionMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFunctionMetadata(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, FunctionFactory, InnerFunctionFunctionMetadataFactory> WithFunctionMetadata<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, FunctionFactory> combinedResult, Action<Humidifier.CloudFront.FunctionTypes.FunctionMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFunctionMetadata(combinedResult.T5, subFactoryAction));
}
