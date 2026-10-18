// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MGN;

public class InnerNetworkMigrationDefinitionSourceConfigurationFactory(Action<Humidifier.MGN.NetworkMigrationDefinitionTypes.SourceConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.MGN.NetworkMigrationDefinitionTypes.SourceConfiguration>
{

    internal InnerNetworkMigrationDefinitionSourceS3ConfigurationFactory SourceS3ConfigurationFactory { get; set; }

    protected override Humidifier.MGN.NetworkMigrationDefinitionTypes.SourceConfiguration Create()
    {
        var sourceConfigurationResult = CreateSourceConfiguration();
        factoryAction?.Invoke(sourceConfigurationResult);

        return sourceConfigurationResult;
    }

    private Humidifier.MGN.NetworkMigrationDefinitionTypes.SourceConfiguration CreateSourceConfiguration()
    {
        var sourceConfigurationResult = new Humidifier.MGN.NetworkMigrationDefinitionTypes.SourceConfiguration();

        return sourceConfigurationResult;
    }
    public override void CreateChildren(Humidifier.MGN.NetworkMigrationDefinitionTypes.SourceConfiguration result)
    {
        base.CreateChildren(result);

        result.SourceS3Configuration ??= SourceS3ConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerNetworkMigrationDefinitionSourceConfigurationFactoryExtensions
{
    public static CombinedResult<InnerNetworkMigrationDefinitionSourceConfigurationFactory, InnerNetworkMigrationDefinitionSourceS3ConfigurationFactory> WithSourceS3Configuration(this InnerNetworkMigrationDefinitionSourceConfigurationFactory parentFactory, Action<Humidifier.MGN.NetworkMigrationDefinitionTypes.SourceS3Configuration> subFactoryAction = null)
    {
        parentFactory.SourceS3ConfigurationFactory = new InnerNetworkMigrationDefinitionSourceS3ConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SourceS3ConfigurationFactory);
    }

    public static CombinedResult<InnerNetworkMigrationDefinitionSourceConfigurationFactory, T1, InnerNetworkMigrationDefinitionSourceS3ConfigurationFactory> WithSourceS3Configuration<T1>(this CombinedResult<InnerNetworkMigrationDefinitionSourceConfigurationFactory, T1> combinedResult, Action<Humidifier.MGN.NetworkMigrationDefinitionTypes.SourceS3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, WithSourceS3Configuration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerNetworkMigrationDefinitionSourceConfigurationFactory, InnerNetworkMigrationDefinitionSourceS3ConfigurationFactory> WithSourceS3Configuration<T1>(this CombinedResult<T1, InnerNetworkMigrationDefinitionSourceConfigurationFactory> combinedResult, Action<Humidifier.MGN.NetworkMigrationDefinitionTypes.SourceS3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, WithSourceS3Configuration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerNetworkMigrationDefinitionSourceConfigurationFactory, T1, T2, InnerNetworkMigrationDefinitionSourceS3ConfigurationFactory> WithSourceS3Configuration<T1, T2>(this CombinedResult<InnerNetworkMigrationDefinitionSourceConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.MGN.NetworkMigrationDefinitionTypes.SourceS3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSourceS3Configuration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerNetworkMigrationDefinitionSourceConfigurationFactory, T2, InnerNetworkMigrationDefinitionSourceS3ConfigurationFactory> WithSourceS3Configuration<T1, T2>(this CombinedResult<T1, InnerNetworkMigrationDefinitionSourceConfigurationFactory, T2> combinedResult, Action<Humidifier.MGN.NetworkMigrationDefinitionTypes.SourceS3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSourceS3Configuration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerNetworkMigrationDefinitionSourceConfigurationFactory, InnerNetworkMigrationDefinitionSourceS3ConfigurationFactory> WithSourceS3Configuration<T1, T2>(this CombinedResult<T1, T2, InnerNetworkMigrationDefinitionSourceConfigurationFactory> combinedResult, Action<Humidifier.MGN.NetworkMigrationDefinitionTypes.SourceS3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSourceS3Configuration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerNetworkMigrationDefinitionSourceConfigurationFactory, T1, T2, T3, InnerNetworkMigrationDefinitionSourceS3ConfigurationFactory> WithSourceS3Configuration<T1, T2, T3>(this CombinedResult<InnerNetworkMigrationDefinitionSourceConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.MGN.NetworkMigrationDefinitionTypes.SourceS3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSourceS3Configuration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerNetworkMigrationDefinitionSourceConfigurationFactory, T2, T3, InnerNetworkMigrationDefinitionSourceS3ConfigurationFactory> WithSourceS3Configuration<T1, T2, T3>(this CombinedResult<T1, InnerNetworkMigrationDefinitionSourceConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.MGN.NetworkMigrationDefinitionTypes.SourceS3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSourceS3Configuration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerNetworkMigrationDefinitionSourceConfigurationFactory, T3, InnerNetworkMigrationDefinitionSourceS3ConfigurationFactory> WithSourceS3Configuration<T1, T2, T3>(this CombinedResult<T1, T2, InnerNetworkMigrationDefinitionSourceConfigurationFactory, T3> combinedResult, Action<Humidifier.MGN.NetworkMigrationDefinitionTypes.SourceS3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSourceS3Configuration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerNetworkMigrationDefinitionSourceConfigurationFactory, InnerNetworkMigrationDefinitionSourceS3ConfigurationFactory> WithSourceS3Configuration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerNetworkMigrationDefinitionSourceConfigurationFactory> combinedResult, Action<Humidifier.MGN.NetworkMigrationDefinitionTypes.SourceS3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSourceS3Configuration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerNetworkMigrationDefinitionSourceConfigurationFactory, T1, T2, T3, T4, InnerNetworkMigrationDefinitionSourceS3ConfigurationFactory> WithSourceS3Configuration<T1, T2, T3, T4>(this CombinedResult<InnerNetworkMigrationDefinitionSourceConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MGN.NetworkMigrationDefinitionTypes.SourceS3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourceS3Configuration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerNetworkMigrationDefinitionSourceConfigurationFactory, T2, T3, T4, InnerNetworkMigrationDefinitionSourceS3ConfigurationFactory> WithSourceS3Configuration<T1, T2, T3, T4>(this CombinedResult<T1, InnerNetworkMigrationDefinitionSourceConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.MGN.NetworkMigrationDefinitionTypes.SourceS3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourceS3Configuration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerNetworkMigrationDefinitionSourceConfigurationFactory, T3, T4, InnerNetworkMigrationDefinitionSourceS3ConfigurationFactory> WithSourceS3Configuration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerNetworkMigrationDefinitionSourceConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.MGN.NetworkMigrationDefinitionTypes.SourceS3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourceS3Configuration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerNetworkMigrationDefinitionSourceConfigurationFactory, T4, InnerNetworkMigrationDefinitionSourceS3ConfigurationFactory> WithSourceS3Configuration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerNetworkMigrationDefinitionSourceConfigurationFactory, T4> combinedResult, Action<Humidifier.MGN.NetworkMigrationDefinitionTypes.SourceS3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourceS3Configuration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerNetworkMigrationDefinitionSourceConfigurationFactory, InnerNetworkMigrationDefinitionSourceS3ConfigurationFactory> WithSourceS3Configuration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerNetworkMigrationDefinitionSourceConfigurationFactory> combinedResult, Action<Humidifier.MGN.NetworkMigrationDefinitionTypes.SourceS3Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourceS3Configuration(combinedResult.T5, subFactoryAction).T2);
}
