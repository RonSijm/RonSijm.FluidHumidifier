// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECS;

public class InnerGatewayGatewayElbAccessLogDestinationFactory(Action<Humidifier.ECS.GatewayTypes.GatewayElbAccessLogDestination> factoryAction = null) : SubResourceFactory<Humidifier.ECS.GatewayTypes.GatewayElbAccessLogDestination>
{

    internal InnerGatewayGatewayElbAccessLogS3DestinationFactory S3Factory { get; set; }

    protected override Humidifier.ECS.GatewayTypes.GatewayElbAccessLogDestination Create()
    {
        var gatewayElbAccessLogDestinationResult = CreateGatewayElbAccessLogDestination();
        factoryAction?.Invoke(gatewayElbAccessLogDestinationResult);

        return gatewayElbAccessLogDestinationResult;
    }

    private Humidifier.ECS.GatewayTypes.GatewayElbAccessLogDestination CreateGatewayElbAccessLogDestination()
    {
        var gatewayElbAccessLogDestinationResult = new Humidifier.ECS.GatewayTypes.GatewayElbAccessLogDestination();

        return gatewayElbAccessLogDestinationResult;
    }
    public override void CreateChildren(Humidifier.ECS.GatewayTypes.GatewayElbAccessLogDestination result)
    {
        base.CreateChildren(result);

        result.S3 ??= S3Factory?.Build();
    }

} // End Of Class

public static class InnerGatewayGatewayElbAccessLogDestinationFactoryExtensions
{
    public static CombinedResult<InnerGatewayGatewayElbAccessLogDestinationFactory, InnerGatewayGatewayElbAccessLogS3DestinationFactory> WithS3(this InnerGatewayGatewayElbAccessLogDestinationFactory parentFactory, Action<Humidifier.ECS.GatewayTypes.GatewayElbAccessLogS3Destination> subFactoryAction = null)
    {
        parentFactory.S3Factory = new InnerGatewayGatewayElbAccessLogS3DestinationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.S3Factory);
    }

    public static CombinedResult<InnerGatewayGatewayElbAccessLogDestinationFactory, T1, InnerGatewayGatewayElbAccessLogS3DestinationFactory> WithS3<T1>(this CombinedResult<InnerGatewayGatewayElbAccessLogDestinationFactory, T1> combinedResult, Action<Humidifier.ECS.GatewayTypes.GatewayElbAccessLogS3Destination> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGatewayGatewayElbAccessLogDestinationFactory, InnerGatewayGatewayElbAccessLogS3DestinationFactory> WithS3<T1>(this CombinedResult<T1, InnerGatewayGatewayElbAccessLogDestinationFactory> combinedResult, Action<Humidifier.ECS.GatewayTypes.GatewayElbAccessLogS3Destination> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerGatewayGatewayElbAccessLogDestinationFactory, T1, T2, InnerGatewayGatewayElbAccessLogS3DestinationFactory> WithS3<T1, T2>(this CombinedResult<InnerGatewayGatewayElbAccessLogDestinationFactory, T1, T2> combinedResult, Action<Humidifier.ECS.GatewayTypes.GatewayElbAccessLogS3Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGatewayGatewayElbAccessLogDestinationFactory, T2, InnerGatewayGatewayElbAccessLogS3DestinationFactory> WithS3<T1, T2>(this CombinedResult<T1, InnerGatewayGatewayElbAccessLogDestinationFactory, T2> combinedResult, Action<Humidifier.ECS.GatewayTypes.GatewayElbAccessLogS3Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerGatewayGatewayElbAccessLogDestinationFactory, InnerGatewayGatewayElbAccessLogS3DestinationFactory> WithS3<T1, T2>(this CombinedResult<T1, T2, InnerGatewayGatewayElbAccessLogDestinationFactory> combinedResult, Action<Humidifier.ECS.GatewayTypes.GatewayElbAccessLogS3Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerGatewayGatewayElbAccessLogDestinationFactory, T1, T2, T3, InnerGatewayGatewayElbAccessLogS3DestinationFactory> WithS3<T1, T2, T3>(this CombinedResult<InnerGatewayGatewayElbAccessLogDestinationFactory, T1, T2, T3> combinedResult, Action<Humidifier.ECS.GatewayTypes.GatewayElbAccessLogS3Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGatewayGatewayElbAccessLogDestinationFactory, T2, T3, InnerGatewayGatewayElbAccessLogS3DestinationFactory> WithS3<T1, T2, T3>(this CombinedResult<T1, InnerGatewayGatewayElbAccessLogDestinationFactory, T2, T3> combinedResult, Action<Humidifier.ECS.GatewayTypes.GatewayElbAccessLogS3Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerGatewayGatewayElbAccessLogDestinationFactory, T3, InnerGatewayGatewayElbAccessLogS3DestinationFactory> WithS3<T1, T2, T3>(this CombinedResult<T1, T2, InnerGatewayGatewayElbAccessLogDestinationFactory, T3> combinedResult, Action<Humidifier.ECS.GatewayTypes.GatewayElbAccessLogS3Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerGatewayGatewayElbAccessLogDestinationFactory, InnerGatewayGatewayElbAccessLogS3DestinationFactory> WithS3<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerGatewayGatewayElbAccessLogDestinationFactory> combinedResult, Action<Humidifier.ECS.GatewayTypes.GatewayElbAccessLogS3Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerGatewayGatewayElbAccessLogDestinationFactory, T1, T2, T3, T4, InnerGatewayGatewayElbAccessLogS3DestinationFactory> WithS3<T1, T2, T3, T4>(this CombinedResult<InnerGatewayGatewayElbAccessLogDestinationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ECS.GatewayTypes.GatewayElbAccessLogS3Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGatewayGatewayElbAccessLogDestinationFactory, T2, T3, T4, InnerGatewayGatewayElbAccessLogS3DestinationFactory> WithS3<T1, T2, T3, T4>(this CombinedResult<T1, InnerGatewayGatewayElbAccessLogDestinationFactory, T2, T3, T4> combinedResult, Action<Humidifier.ECS.GatewayTypes.GatewayElbAccessLogS3Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerGatewayGatewayElbAccessLogDestinationFactory, T3, T4, InnerGatewayGatewayElbAccessLogS3DestinationFactory> WithS3<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerGatewayGatewayElbAccessLogDestinationFactory, T3, T4> combinedResult, Action<Humidifier.ECS.GatewayTypes.GatewayElbAccessLogS3Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerGatewayGatewayElbAccessLogDestinationFactory, T4, InnerGatewayGatewayElbAccessLogS3DestinationFactory> WithS3<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerGatewayGatewayElbAccessLogDestinationFactory, T4> combinedResult, Action<Humidifier.ECS.GatewayTypes.GatewayElbAccessLogS3Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerGatewayGatewayElbAccessLogDestinationFactory, InnerGatewayGatewayElbAccessLogS3DestinationFactory> WithS3<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerGatewayGatewayElbAccessLogDestinationFactory> combinedResult, Action<Humidifier.ECS.GatewayTypes.GatewayElbAccessLogS3Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T5, subFactoryAction).T2);
}
