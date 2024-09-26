// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ServiceCatalog;

public class InnerCloudFormationProductSourceConnectionFactory(Action<Humidifier.ServiceCatalog.CloudFormationProductTypes.SourceConnection> factoryAction = null) : SubResourceFactory<Humidifier.ServiceCatalog.CloudFormationProductTypes.SourceConnection>
{

    internal InnerCloudFormationProductConnectionParametersFactory ConnectionParametersFactory { get; set; }

    protected override Humidifier.ServiceCatalog.CloudFormationProductTypes.SourceConnection Create()
    {
        var sourceConnectionResult = CreateSourceConnection();
        factoryAction?.Invoke(sourceConnectionResult);

        return sourceConnectionResult;
    }

    private Humidifier.ServiceCatalog.CloudFormationProductTypes.SourceConnection CreateSourceConnection()
    {
        var sourceConnectionResult = new Humidifier.ServiceCatalog.CloudFormationProductTypes.SourceConnection();

        return sourceConnectionResult;
    }
    public override void CreateChildren(Humidifier.ServiceCatalog.CloudFormationProductTypes.SourceConnection result)
    {
        base.CreateChildren(result);

        result.ConnectionParameters ??= ConnectionParametersFactory?.Build();
    }

} // End Of Class

public static class InnerCloudFormationProductSourceConnectionFactoryExtensions
{
    public static CombinedResult<InnerCloudFormationProductSourceConnectionFactory, InnerCloudFormationProductConnectionParametersFactory> WithConnectionParameters(this InnerCloudFormationProductSourceConnectionFactory parentFactory, Action<Humidifier.ServiceCatalog.CloudFormationProductTypes.ConnectionParameters> subFactoryAction = null)
    {
        parentFactory.ConnectionParametersFactory = new InnerCloudFormationProductConnectionParametersFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ConnectionParametersFactory);
    }

    public static CombinedResult<InnerCloudFormationProductSourceConnectionFactory, T1, InnerCloudFormationProductConnectionParametersFactory> WithConnectionParameters<T1>(this CombinedResult<InnerCloudFormationProductSourceConnectionFactory, T1> combinedResult, Action<Humidifier.ServiceCatalog.CloudFormationProductTypes.ConnectionParameters> subFactoryAction = null) => new (combinedResult, combinedResult, WithConnectionParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCloudFormationProductSourceConnectionFactory, InnerCloudFormationProductConnectionParametersFactory> WithConnectionParameters<T1>(this CombinedResult<T1, InnerCloudFormationProductSourceConnectionFactory> combinedResult, Action<Humidifier.ServiceCatalog.CloudFormationProductTypes.ConnectionParameters> subFactoryAction = null) => new (combinedResult, combinedResult, WithConnectionParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerCloudFormationProductSourceConnectionFactory, T1, T2, InnerCloudFormationProductConnectionParametersFactory> WithConnectionParameters<T1, T2>(this CombinedResult<InnerCloudFormationProductSourceConnectionFactory, T1, T2> combinedResult, Action<Humidifier.ServiceCatalog.CloudFormationProductTypes.ConnectionParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConnectionParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCloudFormationProductSourceConnectionFactory, T2, InnerCloudFormationProductConnectionParametersFactory> WithConnectionParameters<T1, T2>(this CombinedResult<T1, InnerCloudFormationProductSourceConnectionFactory, T2> combinedResult, Action<Humidifier.ServiceCatalog.CloudFormationProductTypes.ConnectionParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConnectionParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerCloudFormationProductSourceConnectionFactory, InnerCloudFormationProductConnectionParametersFactory> WithConnectionParameters<T1, T2>(this CombinedResult<T1, T2, InnerCloudFormationProductSourceConnectionFactory> combinedResult, Action<Humidifier.ServiceCatalog.CloudFormationProductTypes.ConnectionParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConnectionParameters(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerCloudFormationProductSourceConnectionFactory, T1, T2, T3, InnerCloudFormationProductConnectionParametersFactory> WithConnectionParameters<T1, T2, T3>(this CombinedResult<InnerCloudFormationProductSourceConnectionFactory, T1, T2, T3> combinedResult, Action<Humidifier.ServiceCatalog.CloudFormationProductTypes.ConnectionParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConnectionParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCloudFormationProductSourceConnectionFactory, T2, T3, InnerCloudFormationProductConnectionParametersFactory> WithConnectionParameters<T1, T2, T3>(this CombinedResult<T1, InnerCloudFormationProductSourceConnectionFactory, T2, T3> combinedResult, Action<Humidifier.ServiceCatalog.CloudFormationProductTypes.ConnectionParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConnectionParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerCloudFormationProductSourceConnectionFactory, T3, InnerCloudFormationProductConnectionParametersFactory> WithConnectionParameters<T1, T2, T3>(this CombinedResult<T1, T2, InnerCloudFormationProductSourceConnectionFactory, T3> combinedResult, Action<Humidifier.ServiceCatalog.CloudFormationProductTypes.ConnectionParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConnectionParameters(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerCloudFormationProductSourceConnectionFactory, InnerCloudFormationProductConnectionParametersFactory> WithConnectionParameters<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerCloudFormationProductSourceConnectionFactory> combinedResult, Action<Humidifier.ServiceCatalog.CloudFormationProductTypes.ConnectionParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConnectionParameters(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerCloudFormationProductSourceConnectionFactory, T1, T2, T3, T4, InnerCloudFormationProductConnectionParametersFactory> WithConnectionParameters<T1, T2, T3, T4>(this CombinedResult<InnerCloudFormationProductSourceConnectionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ServiceCatalog.CloudFormationProductTypes.ConnectionParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConnectionParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCloudFormationProductSourceConnectionFactory, T2, T3, T4, InnerCloudFormationProductConnectionParametersFactory> WithConnectionParameters<T1, T2, T3, T4>(this CombinedResult<T1, InnerCloudFormationProductSourceConnectionFactory, T2, T3, T4> combinedResult, Action<Humidifier.ServiceCatalog.CloudFormationProductTypes.ConnectionParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConnectionParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerCloudFormationProductSourceConnectionFactory, T3, T4, InnerCloudFormationProductConnectionParametersFactory> WithConnectionParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerCloudFormationProductSourceConnectionFactory, T3, T4> combinedResult, Action<Humidifier.ServiceCatalog.CloudFormationProductTypes.ConnectionParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConnectionParameters(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerCloudFormationProductSourceConnectionFactory, T4, InnerCloudFormationProductConnectionParametersFactory> WithConnectionParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerCloudFormationProductSourceConnectionFactory, T4> combinedResult, Action<Humidifier.ServiceCatalog.CloudFormationProductTypes.ConnectionParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConnectionParameters(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerCloudFormationProductSourceConnectionFactory, InnerCloudFormationProductConnectionParametersFactory> WithConnectionParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerCloudFormationProductSourceConnectionFactory> combinedResult, Action<Humidifier.ServiceCatalog.CloudFormationProductTypes.ConnectionParameters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConnectionParameters(combinedResult.T5, subFactoryAction));
}
