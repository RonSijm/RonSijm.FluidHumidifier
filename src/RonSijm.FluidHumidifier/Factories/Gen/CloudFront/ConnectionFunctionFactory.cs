// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFront;

public class ConnectionFunctionFactory(string resourceName = null, Action<Humidifier.CloudFront.ConnectionFunction> factoryAction = null) : ResourceFactory<Humidifier.CloudFront.ConnectionFunction>(resourceName)
{

    internal InnerConnectionFunctionConnectionFunctionConfigFactory ConnectionFunctionConfigFactory { get; set; }

    protected override Humidifier.CloudFront.ConnectionFunction Create()
    {
        var connectionFunctionResult = CreateConnectionFunction();
        factoryAction?.Invoke(connectionFunctionResult);

        return connectionFunctionResult;
    }

    private Humidifier.CloudFront.ConnectionFunction CreateConnectionFunction()
    {
        var connectionFunctionResult = new Humidifier.CloudFront.ConnectionFunction
        {
            GivenName = InputResourceName,
        };

        return connectionFunctionResult;
    }
    public override void CreateChildren(Humidifier.CloudFront.ConnectionFunction result)
    {
        base.CreateChildren(result);

        result.ConnectionFunctionConfig ??= ConnectionFunctionConfigFactory?.Build();
    }

} // End Of Class

public static class ConnectionFunctionFactoryExtensions
{
    public static CombinedResult<ConnectionFunctionFactory, InnerConnectionFunctionConnectionFunctionConfigFactory> WithConnectionFunctionConfig(this ConnectionFunctionFactory parentFactory, Action<Humidifier.CloudFront.ConnectionFunctionTypes.ConnectionFunctionConfig> subFactoryAction = null)
    {
        parentFactory.ConnectionFunctionConfigFactory = new InnerConnectionFunctionConnectionFunctionConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ConnectionFunctionConfigFactory);
    }

    public static CombinedResult<ConnectionFunctionFactory, T1, InnerConnectionFunctionConnectionFunctionConfigFactory> WithConnectionFunctionConfig<T1>(this CombinedResult<ConnectionFunctionFactory, T1> combinedResult, Action<Humidifier.CloudFront.ConnectionFunctionTypes.ConnectionFunctionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithConnectionFunctionConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ConnectionFunctionFactory, InnerConnectionFunctionConnectionFunctionConfigFactory> WithConnectionFunctionConfig<T1>(this CombinedResult<T1, ConnectionFunctionFactory> combinedResult, Action<Humidifier.CloudFront.ConnectionFunctionTypes.ConnectionFunctionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithConnectionFunctionConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<ConnectionFunctionFactory, T1, T2, InnerConnectionFunctionConnectionFunctionConfigFactory> WithConnectionFunctionConfig<T1, T2>(this CombinedResult<ConnectionFunctionFactory, T1, T2> combinedResult, Action<Humidifier.CloudFront.ConnectionFunctionTypes.ConnectionFunctionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConnectionFunctionConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ConnectionFunctionFactory, T2, InnerConnectionFunctionConnectionFunctionConfigFactory> WithConnectionFunctionConfig<T1, T2>(this CombinedResult<T1, ConnectionFunctionFactory, T2> combinedResult, Action<Humidifier.CloudFront.ConnectionFunctionTypes.ConnectionFunctionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConnectionFunctionConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ConnectionFunctionFactory, InnerConnectionFunctionConnectionFunctionConfigFactory> WithConnectionFunctionConfig<T1, T2>(this CombinedResult<T1, T2, ConnectionFunctionFactory> combinedResult, Action<Humidifier.CloudFront.ConnectionFunctionTypes.ConnectionFunctionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConnectionFunctionConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<ConnectionFunctionFactory, T1, T2, T3, InnerConnectionFunctionConnectionFunctionConfigFactory> WithConnectionFunctionConfig<T1, T2, T3>(this CombinedResult<ConnectionFunctionFactory, T1, T2, T3> combinedResult, Action<Humidifier.CloudFront.ConnectionFunctionTypes.ConnectionFunctionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConnectionFunctionConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ConnectionFunctionFactory, T2, T3, InnerConnectionFunctionConnectionFunctionConfigFactory> WithConnectionFunctionConfig<T1, T2, T3>(this CombinedResult<T1, ConnectionFunctionFactory, T2, T3> combinedResult, Action<Humidifier.CloudFront.ConnectionFunctionTypes.ConnectionFunctionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConnectionFunctionConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ConnectionFunctionFactory, T3, InnerConnectionFunctionConnectionFunctionConfigFactory> WithConnectionFunctionConfig<T1, T2, T3>(this CombinedResult<T1, T2, ConnectionFunctionFactory, T3> combinedResult, Action<Humidifier.CloudFront.ConnectionFunctionTypes.ConnectionFunctionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConnectionFunctionConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ConnectionFunctionFactory, InnerConnectionFunctionConnectionFunctionConfigFactory> WithConnectionFunctionConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, ConnectionFunctionFactory> combinedResult, Action<Humidifier.CloudFront.ConnectionFunctionTypes.ConnectionFunctionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConnectionFunctionConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<ConnectionFunctionFactory, T1, T2, T3, T4, InnerConnectionFunctionConnectionFunctionConfigFactory> WithConnectionFunctionConfig<T1, T2, T3, T4>(this CombinedResult<ConnectionFunctionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CloudFront.ConnectionFunctionTypes.ConnectionFunctionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConnectionFunctionConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ConnectionFunctionFactory, T2, T3, T4, InnerConnectionFunctionConnectionFunctionConfigFactory> WithConnectionFunctionConfig<T1, T2, T3, T4>(this CombinedResult<T1, ConnectionFunctionFactory, T2, T3, T4> combinedResult, Action<Humidifier.CloudFront.ConnectionFunctionTypes.ConnectionFunctionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConnectionFunctionConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ConnectionFunctionFactory, T3, T4, InnerConnectionFunctionConnectionFunctionConfigFactory> WithConnectionFunctionConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, ConnectionFunctionFactory, T3, T4> combinedResult, Action<Humidifier.CloudFront.ConnectionFunctionTypes.ConnectionFunctionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConnectionFunctionConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ConnectionFunctionFactory, T4, InnerConnectionFunctionConnectionFunctionConfigFactory> WithConnectionFunctionConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ConnectionFunctionFactory, T4> combinedResult, Action<Humidifier.CloudFront.ConnectionFunctionTypes.ConnectionFunctionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConnectionFunctionConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, ConnectionFunctionFactory, InnerConnectionFunctionConnectionFunctionConfigFactory> WithConnectionFunctionConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ConnectionFunctionFactory> combinedResult, Action<Humidifier.CloudFront.ConnectionFunctionTypes.ConnectionFunctionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConnectionFunctionConfig(combinedResult.T5, subFactoryAction).T2);
}
