// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataZone;

public class ConnectionFactory(string resourceName = null, Action<Humidifier.DataZone.Connection> factoryAction = null) : ResourceFactory<Humidifier.DataZone.Connection>(resourceName)
{

    internal List<InnerConnectionConnectionConfigurationFactory> ConfigurationsFactories { get; set; } = [];

    internal InnerConnectionConnectionPropertiesInputFactory PropsFactory { get; set; }

    internal InnerConnectionAwsLocationFactory AwsLocationFactory { get; set; }

    protected override Humidifier.DataZone.Connection Create()
    {
        var connectionResult = CreateConnection();
        factoryAction?.Invoke(connectionResult);

        return connectionResult;
    }

    private Humidifier.DataZone.Connection CreateConnection()
    {
        var connectionResult = new Humidifier.DataZone.Connection
        {
            GivenName = InputResourceName,
        };

        return connectionResult;
    }
    public override void CreateChildren(Humidifier.DataZone.Connection result)
    {
        base.CreateChildren(result);

        result.Configurations = ConfigurationsFactories.Any() ? ConfigurationsFactories.Select(x => x.Build()).ToList() : null;
        result.Props ??= PropsFactory?.Build();
        result.AwsLocation ??= AwsLocationFactory?.Build();
    }

} // End Of Class

public static class ConnectionFactoryExtensions
{
    public static CombinedResult<ConnectionFactory, InnerConnectionConnectionConfigurationFactory> WithConfigurations(this ConnectionFactory parentFactory, Action<Humidifier.DataZone.ConnectionTypes.ConnectionConfiguration> subFactoryAction = null)
    {
        var factory = new InnerConnectionConnectionConfigurationFactory(subFactoryAction);
        parentFactory.ConfigurationsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<ConnectionFactory, InnerConnectionConnectionPropertiesInputFactory> WithProps(this ConnectionFactory parentFactory, Action<Humidifier.DataZone.ConnectionTypes.ConnectionPropertiesInput> subFactoryAction = null)
    {
        parentFactory.PropsFactory = new InnerConnectionConnectionPropertiesInputFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.PropsFactory);
    }

    public static CombinedResult<ConnectionFactory, InnerConnectionAwsLocationFactory> WithAwsLocation(this ConnectionFactory parentFactory, Action<Humidifier.DataZone.ConnectionTypes.AwsLocation> subFactoryAction = null)
    {
        parentFactory.AwsLocationFactory = new InnerConnectionAwsLocationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AwsLocationFactory);
    }

    public static CombinedResult<ConnectionFactory, T1, InnerConnectionConnectionConfigurationFactory> WithConfigurations<T1>(this CombinedResult<ConnectionFactory, T1> combinedResult, Action<Humidifier.DataZone.ConnectionTypes.ConnectionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithConfigurations(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ConnectionFactory, InnerConnectionConnectionConfigurationFactory> WithConfigurations<T1>(this CombinedResult<T1, ConnectionFactory> combinedResult, Action<Humidifier.DataZone.ConnectionTypes.ConnectionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithConfigurations(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<ConnectionFactory, T1, T2, InnerConnectionConnectionConfigurationFactory> WithConfigurations<T1, T2>(this CombinedResult<ConnectionFactory, T1, T2> combinedResult, Action<Humidifier.DataZone.ConnectionTypes.ConnectionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfigurations(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ConnectionFactory, T2, InnerConnectionConnectionConfigurationFactory> WithConfigurations<T1, T2>(this CombinedResult<T1, ConnectionFactory, T2> combinedResult, Action<Humidifier.DataZone.ConnectionTypes.ConnectionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfigurations(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ConnectionFactory, InnerConnectionConnectionConfigurationFactory> WithConfigurations<T1, T2>(this CombinedResult<T1, T2, ConnectionFactory> combinedResult, Action<Humidifier.DataZone.ConnectionTypes.ConnectionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfigurations(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<ConnectionFactory, T1, T2, T3, InnerConnectionConnectionConfigurationFactory> WithConfigurations<T1, T2, T3>(this CombinedResult<ConnectionFactory, T1, T2, T3> combinedResult, Action<Humidifier.DataZone.ConnectionTypes.ConnectionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfigurations(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ConnectionFactory, T2, T3, InnerConnectionConnectionConfigurationFactory> WithConfigurations<T1, T2, T3>(this CombinedResult<T1, ConnectionFactory, T2, T3> combinedResult, Action<Humidifier.DataZone.ConnectionTypes.ConnectionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfigurations(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ConnectionFactory, T3, InnerConnectionConnectionConfigurationFactory> WithConfigurations<T1, T2, T3>(this CombinedResult<T1, T2, ConnectionFactory, T3> combinedResult, Action<Humidifier.DataZone.ConnectionTypes.ConnectionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfigurations(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ConnectionFactory, InnerConnectionConnectionConfigurationFactory> WithConfigurations<T1, T2, T3>(this CombinedResult<T1, T2, T3, ConnectionFactory> combinedResult, Action<Humidifier.DataZone.ConnectionTypes.ConnectionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfigurations(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<ConnectionFactory, T1, T2, T3, T4, InnerConnectionConnectionConfigurationFactory> WithConfigurations<T1, T2, T3, T4>(this CombinedResult<ConnectionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DataZone.ConnectionTypes.ConnectionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfigurations(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ConnectionFactory, T2, T3, T4, InnerConnectionConnectionConfigurationFactory> WithConfigurations<T1, T2, T3, T4>(this CombinedResult<T1, ConnectionFactory, T2, T3, T4> combinedResult, Action<Humidifier.DataZone.ConnectionTypes.ConnectionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfigurations(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ConnectionFactory, T3, T4, InnerConnectionConnectionConfigurationFactory> WithConfigurations<T1, T2, T3, T4>(this CombinedResult<T1, T2, ConnectionFactory, T3, T4> combinedResult, Action<Humidifier.DataZone.ConnectionTypes.ConnectionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfigurations(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ConnectionFactory, T4, InnerConnectionConnectionConfigurationFactory> WithConfigurations<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ConnectionFactory, T4> combinedResult, Action<Humidifier.DataZone.ConnectionTypes.ConnectionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfigurations(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, ConnectionFactory, InnerConnectionConnectionConfigurationFactory> WithConfigurations<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ConnectionFactory> combinedResult, Action<Humidifier.DataZone.ConnectionTypes.ConnectionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfigurations(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<ConnectionFactory, T1, InnerConnectionConnectionPropertiesInputFactory> WithProps<T1>(this CombinedResult<ConnectionFactory, T1> combinedResult, Action<Humidifier.DataZone.ConnectionTypes.ConnectionPropertiesInput> subFactoryAction = null) => new (combinedResult, combinedResult, WithProps(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ConnectionFactory, InnerConnectionConnectionPropertiesInputFactory> WithProps<T1>(this CombinedResult<T1, ConnectionFactory> combinedResult, Action<Humidifier.DataZone.ConnectionTypes.ConnectionPropertiesInput> subFactoryAction = null) => new (combinedResult, combinedResult, WithProps(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<ConnectionFactory, T1, T2, InnerConnectionConnectionPropertiesInputFactory> WithProps<T1, T2>(this CombinedResult<ConnectionFactory, T1, T2> combinedResult, Action<Humidifier.DataZone.ConnectionTypes.ConnectionPropertiesInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithProps(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ConnectionFactory, T2, InnerConnectionConnectionPropertiesInputFactory> WithProps<T1, T2>(this CombinedResult<T1, ConnectionFactory, T2> combinedResult, Action<Humidifier.DataZone.ConnectionTypes.ConnectionPropertiesInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithProps(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ConnectionFactory, InnerConnectionConnectionPropertiesInputFactory> WithProps<T1, T2>(this CombinedResult<T1, T2, ConnectionFactory> combinedResult, Action<Humidifier.DataZone.ConnectionTypes.ConnectionPropertiesInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithProps(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<ConnectionFactory, T1, T2, T3, InnerConnectionConnectionPropertiesInputFactory> WithProps<T1, T2, T3>(this CombinedResult<ConnectionFactory, T1, T2, T3> combinedResult, Action<Humidifier.DataZone.ConnectionTypes.ConnectionPropertiesInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProps(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ConnectionFactory, T2, T3, InnerConnectionConnectionPropertiesInputFactory> WithProps<T1, T2, T3>(this CombinedResult<T1, ConnectionFactory, T2, T3> combinedResult, Action<Humidifier.DataZone.ConnectionTypes.ConnectionPropertiesInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProps(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ConnectionFactory, T3, InnerConnectionConnectionPropertiesInputFactory> WithProps<T1, T2, T3>(this CombinedResult<T1, T2, ConnectionFactory, T3> combinedResult, Action<Humidifier.DataZone.ConnectionTypes.ConnectionPropertiesInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProps(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ConnectionFactory, InnerConnectionConnectionPropertiesInputFactory> WithProps<T1, T2, T3>(this CombinedResult<T1, T2, T3, ConnectionFactory> combinedResult, Action<Humidifier.DataZone.ConnectionTypes.ConnectionPropertiesInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProps(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<ConnectionFactory, T1, T2, T3, T4, InnerConnectionConnectionPropertiesInputFactory> WithProps<T1, T2, T3, T4>(this CombinedResult<ConnectionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DataZone.ConnectionTypes.ConnectionPropertiesInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProps(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ConnectionFactory, T2, T3, T4, InnerConnectionConnectionPropertiesInputFactory> WithProps<T1, T2, T3, T4>(this CombinedResult<T1, ConnectionFactory, T2, T3, T4> combinedResult, Action<Humidifier.DataZone.ConnectionTypes.ConnectionPropertiesInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProps(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ConnectionFactory, T3, T4, InnerConnectionConnectionPropertiesInputFactory> WithProps<T1, T2, T3, T4>(this CombinedResult<T1, T2, ConnectionFactory, T3, T4> combinedResult, Action<Humidifier.DataZone.ConnectionTypes.ConnectionPropertiesInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProps(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ConnectionFactory, T4, InnerConnectionConnectionPropertiesInputFactory> WithProps<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ConnectionFactory, T4> combinedResult, Action<Humidifier.DataZone.ConnectionTypes.ConnectionPropertiesInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProps(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, ConnectionFactory, InnerConnectionConnectionPropertiesInputFactory> WithProps<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ConnectionFactory> combinedResult, Action<Humidifier.DataZone.ConnectionTypes.ConnectionPropertiesInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProps(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<ConnectionFactory, T1, InnerConnectionAwsLocationFactory> WithAwsLocation<T1>(this CombinedResult<ConnectionFactory, T1> combinedResult, Action<Humidifier.DataZone.ConnectionTypes.AwsLocation> subFactoryAction = null) => new (combinedResult, combinedResult, WithAwsLocation(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ConnectionFactory, InnerConnectionAwsLocationFactory> WithAwsLocation<T1>(this CombinedResult<T1, ConnectionFactory> combinedResult, Action<Humidifier.DataZone.ConnectionTypes.AwsLocation> subFactoryAction = null) => new (combinedResult, combinedResult, WithAwsLocation(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<ConnectionFactory, T1, T2, InnerConnectionAwsLocationFactory> WithAwsLocation<T1, T2>(this CombinedResult<ConnectionFactory, T1, T2> combinedResult, Action<Humidifier.DataZone.ConnectionTypes.AwsLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAwsLocation(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ConnectionFactory, T2, InnerConnectionAwsLocationFactory> WithAwsLocation<T1, T2>(this CombinedResult<T1, ConnectionFactory, T2> combinedResult, Action<Humidifier.DataZone.ConnectionTypes.AwsLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAwsLocation(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ConnectionFactory, InnerConnectionAwsLocationFactory> WithAwsLocation<T1, T2>(this CombinedResult<T1, T2, ConnectionFactory> combinedResult, Action<Humidifier.DataZone.ConnectionTypes.AwsLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAwsLocation(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<ConnectionFactory, T1, T2, T3, InnerConnectionAwsLocationFactory> WithAwsLocation<T1, T2, T3>(this CombinedResult<ConnectionFactory, T1, T2, T3> combinedResult, Action<Humidifier.DataZone.ConnectionTypes.AwsLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAwsLocation(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ConnectionFactory, T2, T3, InnerConnectionAwsLocationFactory> WithAwsLocation<T1, T2, T3>(this CombinedResult<T1, ConnectionFactory, T2, T3> combinedResult, Action<Humidifier.DataZone.ConnectionTypes.AwsLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAwsLocation(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ConnectionFactory, T3, InnerConnectionAwsLocationFactory> WithAwsLocation<T1, T2, T3>(this CombinedResult<T1, T2, ConnectionFactory, T3> combinedResult, Action<Humidifier.DataZone.ConnectionTypes.AwsLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAwsLocation(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ConnectionFactory, InnerConnectionAwsLocationFactory> WithAwsLocation<T1, T2, T3>(this CombinedResult<T1, T2, T3, ConnectionFactory> combinedResult, Action<Humidifier.DataZone.ConnectionTypes.AwsLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAwsLocation(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<ConnectionFactory, T1, T2, T3, T4, InnerConnectionAwsLocationFactory> WithAwsLocation<T1, T2, T3, T4>(this CombinedResult<ConnectionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DataZone.ConnectionTypes.AwsLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAwsLocation(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ConnectionFactory, T2, T3, T4, InnerConnectionAwsLocationFactory> WithAwsLocation<T1, T2, T3, T4>(this CombinedResult<T1, ConnectionFactory, T2, T3, T4> combinedResult, Action<Humidifier.DataZone.ConnectionTypes.AwsLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAwsLocation(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ConnectionFactory, T3, T4, InnerConnectionAwsLocationFactory> WithAwsLocation<T1, T2, T3, T4>(this CombinedResult<T1, T2, ConnectionFactory, T3, T4> combinedResult, Action<Humidifier.DataZone.ConnectionTypes.AwsLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAwsLocation(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ConnectionFactory, T4, InnerConnectionAwsLocationFactory> WithAwsLocation<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ConnectionFactory, T4> combinedResult, Action<Humidifier.DataZone.ConnectionTypes.AwsLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAwsLocation(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, ConnectionFactory, InnerConnectionAwsLocationFactory> WithAwsLocation<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ConnectionFactory> combinedResult, Action<Humidifier.DataZone.ConnectionTypes.AwsLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAwsLocation(combinedResult.T5, subFactoryAction).T2);
}
