// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class SourceEndpointFactory(string resourceName = null, Action<Humidifier.MediaConnect.SourceEndpoint> factoryAction = null) : ResourceFactory<Humidifier.MediaConnect.SourceEndpoint>(resourceName)
{

    internal InnerSourceEndpointSourceEndpointConfigurationFactory ConfigurationFactory { get; set; }

    protected override Humidifier.MediaConnect.SourceEndpoint Create()
    {
        var sourceEndpointResult = CreateSourceEndpoint();
        factoryAction?.Invoke(sourceEndpointResult);

        return sourceEndpointResult;
    }

    private Humidifier.MediaConnect.SourceEndpoint CreateSourceEndpoint()
    {
        var sourceEndpointResult = new Humidifier.MediaConnect.SourceEndpoint
        {
            GivenName = InputResourceName,
        };

        return sourceEndpointResult;
    }
    public override void CreateChildren(Humidifier.MediaConnect.SourceEndpoint result)
    {
        base.CreateChildren(result);

        result.Configuration ??= ConfigurationFactory?.Build();
    }

} // End Of Class

public static class SourceEndpointFactoryExtensions
{
    public static CombinedResult<SourceEndpointFactory, InnerSourceEndpointSourceEndpointConfigurationFactory> WithConfiguration(this SourceEndpointFactory parentFactory, Action<Humidifier.MediaConnect.SourceEndpointTypes.SourceEndpointConfiguration> subFactoryAction = null)
    {
        parentFactory.ConfigurationFactory = new InnerSourceEndpointSourceEndpointConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ConfigurationFactory);
    }

    public static CombinedResult<SourceEndpointFactory, T1, InnerSourceEndpointSourceEndpointConfigurationFactory> WithConfiguration<T1>(this CombinedResult<SourceEndpointFactory, T1> combinedResult, Action<Humidifier.MediaConnect.SourceEndpointTypes.SourceEndpointConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SourceEndpointFactory, InnerSourceEndpointSourceEndpointConfigurationFactory> WithConfiguration<T1>(this CombinedResult<T1, SourceEndpointFactory> combinedResult, Action<Humidifier.MediaConnect.SourceEndpointTypes.SourceEndpointConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<SourceEndpointFactory, T1, T2, InnerSourceEndpointSourceEndpointConfigurationFactory> WithConfiguration<T1, T2>(this CombinedResult<SourceEndpointFactory, T1, T2> combinedResult, Action<Humidifier.MediaConnect.SourceEndpointTypes.SourceEndpointConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SourceEndpointFactory, T2, InnerSourceEndpointSourceEndpointConfigurationFactory> WithConfiguration<T1, T2>(this CombinedResult<T1, SourceEndpointFactory, T2> combinedResult, Action<Humidifier.MediaConnect.SourceEndpointTypes.SourceEndpointConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, SourceEndpointFactory, InnerSourceEndpointSourceEndpointConfigurationFactory> WithConfiguration<T1, T2>(this CombinedResult<T1, T2, SourceEndpointFactory> combinedResult, Action<Humidifier.MediaConnect.SourceEndpointTypes.SourceEndpointConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<SourceEndpointFactory, T1, T2, T3, InnerSourceEndpointSourceEndpointConfigurationFactory> WithConfiguration<T1, T2, T3>(this CombinedResult<SourceEndpointFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaConnect.SourceEndpointTypes.SourceEndpointConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SourceEndpointFactory, T2, T3, InnerSourceEndpointSourceEndpointConfigurationFactory> WithConfiguration<T1, T2, T3>(this CombinedResult<T1, SourceEndpointFactory, T2, T3> combinedResult, Action<Humidifier.MediaConnect.SourceEndpointTypes.SourceEndpointConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, SourceEndpointFactory, T3, InnerSourceEndpointSourceEndpointConfigurationFactory> WithConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, SourceEndpointFactory, T3> combinedResult, Action<Humidifier.MediaConnect.SourceEndpointTypes.SourceEndpointConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, SourceEndpointFactory, InnerSourceEndpointSourceEndpointConfigurationFactory> WithConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, SourceEndpointFactory> combinedResult, Action<Humidifier.MediaConnect.SourceEndpointTypes.SourceEndpointConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<SourceEndpointFactory, T1, T2, T3, T4, InnerSourceEndpointSourceEndpointConfigurationFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<SourceEndpointFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.SourceEndpointTypes.SourceEndpointConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SourceEndpointFactory, T2, T3, T4, InnerSourceEndpointSourceEndpointConfigurationFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, SourceEndpointFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.SourceEndpointTypes.SourceEndpointConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, SourceEndpointFactory, T3, T4, InnerSourceEndpointSourceEndpointConfigurationFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, SourceEndpointFactory, T3, T4> combinedResult, Action<Humidifier.MediaConnect.SourceEndpointTypes.SourceEndpointConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, SourceEndpointFactory, T4, InnerSourceEndpointSourceEndpointConfigurationFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, SourceEndpointFactory, T4> combinedResult, Action<Humidifier.MediaConnect.SourceEndpointTypes.SourceEndpointConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, SourceEndpointFactory, InnerSourceEndpointSourceEndpointConfigurationFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, SourceEndpointFactory> combinedResult, Action<Humidifier.MediaConnect.SourceEndpointTypes.SourceEndpointConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T5, subFactoryAction).T2);
}
