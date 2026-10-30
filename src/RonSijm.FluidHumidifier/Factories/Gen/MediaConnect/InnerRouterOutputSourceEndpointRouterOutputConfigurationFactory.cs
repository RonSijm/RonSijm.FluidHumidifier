// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class InnerRouterOutputSourceEndpointRouterOutputConfigurationFactory(Action<Humidifier.MediaConnect.RouterOutputTypes.SourceEndpointRouterOutputConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.MediaConnect.RouterOutputTypes.SourceEndpointRouterOutputConfiguration>
{

    internal InnerRouterOutputEndpointEncryptionConfigurationFactory DestinationTransitEncryptionFactory { get; set; }

    protected override Humidifier.MediaConnect.RouterOutputTypes.SourceEndpointRouterOutputConfiguration Create()
    {
        var sourceEndpointRouterOutputConfigurationResult = CreateSourceEndpointRouterOutputConfiguration();
        factoryAction?.Invoke(sourceEndpointRouterOutputConfigurationResult);

        return sourceEndpointRouterOutputConfigurationResult;
    }

    private Humidifier.MediaConnect.RouterOutputTypes.SourceEndpointRouterOutputConfiguration CreateSourceEndpointRouterOutputConfiguration()
    {
        var sourceEndpointRouterOutputConfigurationResult = new Humidifier.MediaConnect.RouterOutputTypes.SourceEndpointRouterOutputConfiguration();

        return sourceEndpointRouterOutputConfigurationResult;
    }
    public override void CreateChildren(Humidifier.MediaConnect.RouterOutputTypes.SourceEndpointRouterOutputConfiguration result)
    {
        base.CreateChildren(result);

        result.DestinationTransitEncryption ??= DestinationTransitEncryptionFactory?.Build();
    }

} // End Of Class

public static class InnerRouterOutputSourceEndpointRouterOutputConfigurationFactoryExtensions
{
    public static CombinedResult<InnerRouterOutputSourceEndpointRouterOutputConfigurationFactory, InnerRouterOutputEndpointEncryptionConfigurationFactory> WithDestinationTransitEncryption(this InnerRouterOutputSourceEndpointRouterOutputConfigurationFactory parentFactory, Action<Humidifier.MediaConnect.RouterOutputTypes.EndpointEncryptionConfiguration> subFactoryAction = null)
    {
        parentFactory.DestinationTransitEncryptionFactory = new InnerRouterOutputEndpointEncryptionConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DestinationTransitEncryptionFactory);
    }

    public static CombinedResult<InnerRouterOutputSourceEndpointRouterOutputConfigurationFactory, T1, InnerRouterOutputEndpointEncryptionConfigurationFactory> WithDestinationTransitEncryption<T1>(this CombinedResult<InnerRouterOutputSourceEndpointRouterOutputConfigurationFactory, T1> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.EndpointEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithDestinationTransitEncryption(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRouterOutputSourceEndpointRouterOutputConfigurationFactory, InnerRouterOutputEndpointEncryptionConfigurationFactory> WithDestinationTransitEncryption<T1>(this CombinedResult<T1, InnerRouterOutputSourceEndpointRouterOutputConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.EndpointEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithDestinationTransitEncryption(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerRouterOutputSourceEndpointRouterOutputConfigurationFactory, T1, T2, InnerRouterOutputEndpointEncryptionConfigurationFactory> WithDestinationTransitEncryption<T1, T2>(this CombinedResult<InnerRouterOutputSourceEndpointRouterOutputConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.EndpointEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDestinationTransitEncryption(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRouterOutputSourceEndpointRouterOutputConfigurationFactory, T2, InnerRouterOutputEndpointEncryptionConfigurationFactory> WithDestinationTransitEncryption<T1, T2>(this CombinedResult<T1, InnerRouterOutputSourceEndpointRouterOutputConfigurationFactory, T2> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.EndpointEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDestinationTransitEncryption(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRouterOutputSourceEndpointRouterOutputConfigurationFactory, InnerRouterOutputEndpointEncryptionConfigurationFactory> WithDestinationTransitEncryption<T1, T2>(this CombinedResult<T1, T2, InnerRouterOutputSourceEndpointRouterOutputConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.EndpointEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDestinationTransitEncryption(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerRouterOutputSourceEndpointRouterOutputConfigurationFactory, T1, T2, T3, InnerRouterOutputEndpointEncryptionConfigurationFactory> WithDestinationTransitEncryption<T1, T2, T3>(this CombinedResult<InnerRouterOutputSourceEndpointRouterOutputConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.EndpointEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationTransitEncryption(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRouterOutputSourceEndpointRouterOutputConfigurationFactory, T2, T3, InnerRouterOutputEndpointEncryptionConfigurationFactory> WithDestinationTransitEncryption<T1, T2, T3>(this CombinedResult<T1, InnerRouterOutputSourceEndpointRouterOutputConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.EndpointEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationTransitEncryption(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRouterOutputSourceEndpointRouterOutputConfigurationFactory, T3, InnerRouterOutputEndpointEncryptionConfigurationFactory> WithDestinationTransitEncryption<T1, T2, T3>(this CombinedResult<T1, T2, InnerRouterOutputSourceEndpointRouterOutputConfigurationFactory, T3> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.EndpointEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationTransitEncryption(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerRouterOutputSourceEndpointRouterOutputConfigurationFactory, InnerRouterOutputEndpointEncryptionConfigurationFactory> WithDestinationTransitEncryption<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerRouterOutputSourceEndpointRouterOutputConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.EndpointEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationTransitEncryption(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerRouterOutputSourceEndpointRouterOutputConfigurationFactory, T1, T2, T3, T4, InnerRouterOutputEndpointEncryptionConfigurationFactory> WithDestinationTransitEncryption<T1, T2, T3, T4>(this CombinedResult<InnerRouterOutputSourceEndpointRouterOutputConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.EndpointEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationTransitEncryption(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRouterOutputSourceEndpointRouterOutputConfigurationFactory, T2, T3, T4, InnerRouterOutputEndpointEncryptionConfigurationFactory> WithDestinationTransitEncryption<T1, T2, T3, T4>(this CombinedResult<T1, InnerRouterOutputSourceEndpointRouterOutputConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.EndpointEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationTransitEncryption(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRouterOutputSourceEndpointRouterOutputConfigurationFactory, T3, T4, InnerRouterOutputEndpointEncryptionConfigurationFactory> WithDestinationTransitEncryption<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerRouterOutputSourceEndpointRouterOutputConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.EndpointEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationTransitEncryption(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerRouterOutputSourceEndpointRouterOutputConfigurationFactory, T4, InnerRouterOutputEndpointEncryptionConfigurationFactory> WithDestinationTransitEncryption<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerRouterOutputSourceEndpointRouterOutputConfigurationFactory, T4> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.EndpointEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationTransitEncryption(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerRouterOutputSourceEndpointRouterOutputConfigurationFactory, InnerRouterOutputEndpointEncryptionConfigurationFactory> WithDestinationTransitEncryption<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerRouterOutputSourceEndpointRouterOutputConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.EndpointEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationTransitEncryption(combinedResult.T5, subFactoryAction).T2);
}
