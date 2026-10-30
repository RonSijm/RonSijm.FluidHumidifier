// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class InnerRouterInputDestinationEndpointRouterInputConfigurationFactory(Action<Humidifier.MediaConnect.RouterInputTypes.DestinationEndpointRouterInputConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.MediaConnect.RouterInputTypes.DestinationEndpointRouterInputConfiguration>
{

    internal InnerRouterInputEndpointEncryptionConfigurationFactory SourceTransitDecryptionFactory { get; set; }

    protected override Humidifier.MediaConnect.RouterInputTypes.DestinationEndpointRouterInputConfiguration Create()
    {
        var destinationEndpointRouterInputConfigurationResult = CreateDestinationEndpointRouterInputConfiguration();
        factoryAction?.Invoke(destinationEndpointRouterInputConfigurationResult);

        return destinationEndpointRouterInputConfigurationResult;
    }

    private Humidifier.MediaConnect.RouterInputTypes.DestinationEndpointRouterInputConfiguration CreateDestinationEndpointRouterInputConfiguration()
    {
        var destinationEndpointRouterInputConfigurationResult = new Humidifier.MediaConnect.RouterInputTypes.DestinationEndpointRouterInputConfiguration();

        return destinationEndpointRouterInputConfigurationResult;
    }
    public override void CreateChildren(Humidifier.MediaConnect.RouterInputTypes.DestinationEndpointRouterInputConfiguration result)
    {
        base.CreateChildren(result);

        result.SourceTransitDecryption ??= SourceTransitDecryptionFactory?.Build();
    }

} // End Of Class

public static class InnerRouterInputDestinationEndpointRouterInputConfigurationFactoryExtensions
{
    public static CombinedResult<InnerRouterInputDestinationEndpointRouterInputConfigurationFactory, InnerRouterInputEndpointEncryptionConfigurationFactory> WithSourceTransitDecryption(this InnerRouterInputDestinationEndpointRouterInputConfigurationFactory parentFactory, Action<Humidifier.MediaConnect.RouterInputTypes.EndpointEncryptionConfiguration> subFactoryAction = null)
    {
        parentFactory.SourceTransitDecryptionFactory = new InnerRouterInputEndpointEncryptionConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SourceTransitDecryptionFactory);
    }

    public static CombinedResult<InnerRouterInputDestinationEndpointRouterInputConfigurationFactory, T1, InnerRouterInputEndpointEncryptionConfigurationFactory> WithSourceTransitDecryption<T1>(this CombinedResult<InnerRouterInputDestinationEndpointRouterInputConfigurationFactory, T1> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.EndpointEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithSourceTransitDecryption(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRouterInputDestinationEndpointRouterInputConfigurationFactory, InnerRouterInputEndpointEncryptionConfigurationFactory> WithSourceTransitDecryption<T1>(this CombinedResult<T1, InnerRouterInputDestinationEndpointRouterInputConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.EndpointEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithSourceTransitDecryption(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerRouterInputDestinationEndpointRouterInputConfigurationFactory, T1, T2, InnerRouterInputEndpointEncryptionConfigurationFactory> WithSourceTransitDecryption<T1, T2>(this CombinedResult<InnerRouterInputDestinationEndpointRouterInputConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.EndpointEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSourceTransitDecryption(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRouterInputDestinationEndpointRouterInputConfigurationFactory, T2, InnerRouterInputEndpointEncryptionConfigurationFactory> WithSourceTransitDecryption<T1, T2>(this CombinedResult<T1, InnerRouterInputDestinationEndpointRouterInputConfigurationFactory, T2> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.EndpointEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSourceTransitDecryption(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRouterInputDestinationEndpointRouterInputConfigurationFactory, InnerRouterInputEndpointEncryptionConfigurationFactory> WithSourceTransitDecryption<T1, T2>(this CombinedResult<T1, T2, InnerRouterInputDestinationEndpointRouterInputConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.EndpointEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSourceTransitDecryption(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerRouterInputDestinationEndpointRouterInputConfigurationFactory, T1, T2, T3, InnerRouterInputEndpointEncryptionConfigurationFactory> WithSourceTransitDecryption<T1, T2, T3>(this CombinedResult<InnerRouterInputDestinationEndpointRouterInputConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.EndpointEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSourceTransitDecryption(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRouterInputDestinationEndpointRouterInputConfigurationFactory, T2, T3, InnerRouterInputEndpointEncryptionConfigurationFactory> WithSourceTransitDecryption<T1, T2, T3>(this CombinedResult<T1, InnerRouterInputDestinationEndpointRouterInputConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.EndpointEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSourceTransitDecryption(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRouterInputDestinationEndpointRouterInputConfigurationFactory, T3, InnerRouterInputEndpointEncryptionConfigurationFactory> WithSourceTransitDecryption<T1, T2, T3>(this CombinedResult<T1, T2, InnerRouterInputDestinationEndpointRouterInputConfigurationFactory, T3> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.EndpointEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSourceTransitDecryption(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerRouterInputDestinationEndpointRouterInputConfigurationFactory, InnerRouterInputEndpointEncryptionConfigurationFactory> WithSourceTransitDecryption<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerRouterInputDestinationEndpointRouterInputConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.EndpointEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSourceTransitDecryption(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerRouterInputDestinationEndpointRouterInputConfigurationFactory, T1, T2, T3, T4, InnerRouterInputEndpointEncryptionConfigurationFactory> WithSourceTransitDecryption<T1, T2, T3, T4>(this CombinedResult<InnerRouterInputDestinationEndpointRouterInputConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.EndpointEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourceTransitDecryption(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRouterInputDestinationEndpointRouterInputConfigurationFactory, T2, T3, T4, InnerRouterInputEndpointEncryptionConfigurationFactory> WithSourceTransitDecryption<T1, T2, T3, T4>(this CombinedResult<T1, InnerRouterInputDestinationEndpointRouterInputConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.EndpointEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourceTransitDecryption(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRouterInputDestinationEndpointRouterInputConfigurationFactory, T3, T4, InnerRouterInputEndpointEncryptionConfigurationFactory> WithSourceTransitDecryption<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerRouterInputDestinationEndpointRouterInputConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.EndpointEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourceTransitDecryption(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerRouterInputDestinationEndpointRouterInputConfigurationFactory, T4, InnerRouterInputEndpointEncryptionConfigurationFactory> WithSourceTransitDecryption<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerRouterInputDestinationEndpointRouterInputConfigurationFactory, T4> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.EndpointEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourceTransitDecryption(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerRouterInputDestinationEndpointRouterInputConfigurationFactory, InnerRouterInputEndpointEncryptionConfigurationFactory> WithSourceTransitDecryption<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerRouterInputDestinationEndpointRouterInputConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.EndpointEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourceTransitDecryption(combinedResult.T5, subFactoryAction).T2);
}
