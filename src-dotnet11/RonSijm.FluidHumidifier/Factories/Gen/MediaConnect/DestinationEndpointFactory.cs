// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class DestinationEndpointFactory(string resourceName = null, Action<Humidifier.MediaConnect.DestinationEndpoint> factoryAction = null) : ResourceFactory<Humidifier.MediaConnect.DestinationEndpoint>(resourceName)
{

    internal InnerDestinationEndpointDestinationEndpointConfigurationFactory ConfigurationFactory { get; set; }

    protected override Humidifier.MediaConnect.DestinationEndpoint Create()
    {
        var destinationEndpointResult = CreateDestinationEndpoint();
        factoryAction?.Invoke(destinationEndpointResult);

        return destinationEndpointResult;
    }

    private Humidifier.MediaConnect.DestinationEndpoint CreateDestinationEndpoint()
    {
        var destinationEndpointResult = new Humidifier.MediaConnect.DestinationEndpoint
        {
            GivenName = InputResourceName,
        };

        return destinationEndpointResult;
    }
    public override void CreateChildren(Humidifier.MediaConnect.DestinationEndpoint result)
    {
        base.CreateChildren(result);

        result.Configuration ??= ConfigurationFactory?.Build();
    }

} // End Of Class

public static class DestinationEndpointFactoryExtensions
{
    public static CombinedResult<DestinationEndpointFactory, InnerDestinationEndpointDestinationEndpointConfigurationFactory> WithConfiguration(this DestinationEndpointFactory parentFactory, Action<Humidifier.MediaConnect.DestinationEndpointTypes.DestinationEndpointConfiguration> subFactoryAction = null)
    {
        parentFactory.ConfigurationFactory = new InnerDestinationEndpointDestinationEndpointConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ConfigurationFactory);
    }

    public static CombinedResult<DestinationEndpointFactory, T1, InnerDestinationEndpointDestinationEndpointConfigurationFactory> WithConfiguration<T1>(this CombinedResult<DestinationEndpointFactory, T1> combinedResult, Action<Humidifier.MediaConnect.DestinationEndpointTypes.DestinationEndpointConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, DestinationEndpointFactory, InnerDestinationEndpointDestinationEndpointConfigurationFactory> WithConfiguration<T1>(this CombinedResult<T1, DestinationEndpointFactory> combinedResult, Action<Humidifier.MediaConnect.DestinationEndpointTypes.DestinationEndpointConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<DestinationEndpointFactory, T1, T2, InnerDestinationEndpointDestinationEndpointConfigurationFactory> WithConfiguration<T1, T2>(this CombinedResult<DestinationEndpointFactory, T1, T2> combinedResult, Action<Humidifier.MediaConnect.DestinationEndpointTypes.DestinationEndpointConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, DestinationEndpointFactory, T2, InnerDestinationEndpointDestinationEndpointConfigurationFactory> WithConfiguration<T1, T2>(this CombinedResult<T1, DestinationEndpointFactory, T2> combinedResult, Action<Humidifier.MediaConnect.DestinationEndpointTypes.DestinationEndpointConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, DestinationEndpointFactory, InnerDestinationEndpointDestinationEndpointConfigurationFactory> WithConfiguration<T1, T2>(this CombinedResult<T1, T2, DestinationEndpointFactory> combinedResult, Action<Humidifier.MediaConnect.DestinationEndpointTypes.DestinationEndpointConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<DestinationEndpointFactory, T1, T2, T3, InnerDestinationEndpointDestinationEndpointConfigurationFactory> WithConfiguration<T1, T2, T3>(this CombinedResult<DestinationEndpointFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaConnect.DestinationEndpointTypes.DestinationEndpointConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, DestinationEndpointFactory, T2, T3, InnerDestinationEndpointDestinationEndpointConfigurationFactory> WithConfiguration<T1, T2, T3>(this CombinedResult<T1, DestinationEndpointFactory, T2, T3> combinedResult, Action<Humidifier.MediaConnect.DestinationEndpointTypes.DestinationEndpointConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, DestinationEndpointFactory, T3, InnerDestinationEndpointDestinationEndpointConfigurationFactory> WithConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, DestinationEndpointFactory, T3> combinedResult, Action<Humidifier.MediaConnect.DestinationEndpointTypes.DestinationEndpointConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, DestinationEndpointFactory, InnerDestinationEndpointDestinationEndpointConfigurationFactory> WithConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, DestinationEndpointFactory> combinedResult, Action<Humidifier.MediaConnect.DestinationEndpointTypes.DestinationEndpointConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<DestinationEndpointFactory, T1, T2, T3, T4, InnerDestinationEndpointDestinationEndpointConfigurationFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<DestinationEndpointFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.DestinationEndpointTypes.DestinationEndpointConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, DestinationEndpointFactory, T2, T3, T4, InnerDestinationEndpointDestinationEndpointConfigurationFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, DestinationEndpointFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.DestinationEndpointTypes.DestinationEndpointConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, DestinationEndpointFactory, T3, T4, InnerDestinationEndpointDestinationEndpointConfigurationFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, DestinationEndpointFactory, T3, T4> combinedResult, Action<Humidifier.MediaConnect.DestinationEndpointTypes.DestinationEndpointConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, DestinationEndpointFactory, T4, InnerDestinationEndpointDestinationEndpointConfigurationFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, DestinationEndpointFactory, T4> combinedResult, Action<Humidifier.MediaConnect.DestinationEndpointTypes.DestinationEndpointConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, DestinationEndpointFactory, InnerDestinationEndpointDestinationEndpointConfigurationFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, DestinationEndpointFactory> combinedResult, Action<Humidifier.MediaConnect.DestinationEndpointTypes.DestinationEndpointConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T5, subFactoryAction).T2);
}
