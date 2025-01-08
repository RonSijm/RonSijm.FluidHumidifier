// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.KinesisFirehose;

public class InnerDeliveryStreamDatabaseSourceAuthenticationConfigurationFactory(Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.DatabaseSourceAuthenticationConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.KinesisFirehose.DeliveryStreamTypes.DatabaseSourceAuthenticationConfiguration>
{

    internal InnerDeliveryStreamSecretsManagerConfigurationFactory SecretsManagerConfigurationFactory { get; set; }

    protected override Humidifier.KinesisFirehose.DeliveryStreamTypes.DatabaseSourceAuthenticationConfiguration Create()
    {
        var databaseSourceAuthenticationConfigurationResult = CreateDatabaseSourceAuthenticationConfiguration();
        factoryAction?.Invoke(databaseSourceAuthenticationConfigurationResult);

        return databaseSourceAuthenticationConfigurationResult;
    }

    private Humidifier.KinesisFirehose.DeliveryStreamTypes.DatabaseSourceAuthenticationConfiguration CreateDatabaseSourceAuthenticationConfiguration()
    {
        var databaseSourceAuthenticationConfigurationResult = new Humidifier.KinesisFirehose.DeliveryStreamTypes.DatabaseSourceAuthenticationConfiguration();

        return databaseSourceAuthenticationConfigurationResult;
    }
    public override void CreateChildren(Humidifier.KinesisFirehose.DeliveryStreamTypes.DatabaseSourceAuthenticationConfiguration result)
    {
        base.CreateChildren(result);

        result.SecretsManagerConfiguration ??= SecretsManagerConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerDeliveryStreamDatabaseSourceAuthenticationConfigurationFactoryExtensions
{
    public static CombinedResult<InnerDeliveryStreamDatabaseSourceAuthenticationConfigurationFactory, InnerDeliveryStreamSecretsManagerConfigurationFactory> WithSecretsManagerConfiguration(this InnerDeliveryStreamDatabaseSourceAuthenticationConfigurationFactory parentFactory, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.SecretsManagerConfiguration> subFactoryAction = null)
    {
        parentFactory.SecretsManagerConfigurationFactory = new InnerDeliveryStreamSecretsManagerConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SecretsManagerConfigurationFactory);
    }

    public static CombinedResult<InnerDeliveryStreamDatabaseSourceAuthenticationConfigurationFactory, T1, InnerDeliveryStreamSecretsManagerConfigurationFactory> WithSecretsManagerConfiguration<T1>(this CombinedResult<InnerDeliveryStreamDatabaseSourceAuthenticationConfigurationFactory, T1> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.SecretsManagerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithSecretsManagerConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDeliveryStreamDatabaseSourceAuthenticationConfigurationFactory, InnerDeliveryStreamSecretsManagerConfigurationFactory> WithSecretsManagerConfiguration<T1>(this CombinedResult<T1, InnerDeliveryStreamDatabaseSourceAuthenticationConfigurationFactory> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.SecretsManagerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithSecretsManagerConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDeliveryStreamDatabaseSourceAuthenticationConfigurationFactory, T1, T2, InnerDeliveryStreamSecretsManagerConfigurationFactory> WithSecretsManagerConfiguration<T1, T2>(this CombinedResult<InnerDeliveryStreamDatabaseSourceAuthenticationConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.SecretsManagerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSecretsManagerConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDeliveryStreamDatabaseSourceAuthenticationConfigurationFactory, T2, InnerDeliveryStreamSecretsManagerConfigurationFactory> WithSecretsManagerConfiguration<T1, T2>(this CombinedResult<T1, InnerDeliveryStreamDatabaseSourceAuthenticationConfigurationFactory, T2> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.SecretsManagerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSecretsManagerConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDeliveryStreamDatabaseSourceAuthenticationConfigurationFactory, InnerDeliveryStreamSecretsManagerConfigurationFactory> WithSecretsManagerConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerDeliveryStreamDatabaseSourceAuthenticationConfigurationFactory> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.SecretsManagerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSecretsManagerConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDeliveryStreamDatabaseSourceAuthenticationConfigurationFactory, T1, T2, T3, InnerDeliveryStreamSecretsManagerConfigurationFactory> WithSecretsManagerConfiguration<T1, T2, T3>(this CombinedResult<InnerDeliveryStreamDatabaseSourceAuthenticationConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.SecretsManagerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSecretsManagerConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDeliveryStreamDatabaseSourceAuthenticationConfigurationFactory, T2, T3, InnerDeliveryStreamSecretsManagerConfigurationFactory> WithSecretsManagerConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerDeliveryStreamDatabaseSourceAuthenticationConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.SecretsManagerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSecretsManagerConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDeliveryStreamDatabaseSourceAuthenticationConfigurationFactory, T3, InnerDeliveryStreamSecretsManagerConfigurationFactory> WithSecretsManagerConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerDeliveryStreamDatabaseSourceAuthenticationConfigurationFactory, T3> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.SecretsManagerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSecretsManagerConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDeliveryStreamDatabaseSourceAuthenticationConfigurationFactory, InnerDeliveryStreamSecretsManagerConfigurationFactory> WithSecretsManagerConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDeliveryStreamDatabaseSourceAuthenticationConfigurationFactory> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.SecretsManagerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSecretsManagerConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDeliveryStreamDatabaseSourceAuthenticationConfigurationFactory, T1, T2, T3, T4, InnerDeliveryStreamSecretsManagerConfigurationFactory> WithSecretsManagerConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerDeliveryStreamDatabaseSourceAuthenticationConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.SecretsManagerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSecretsManagerConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDeliveryStreamDatabaseSourceAuthenticationConfigurationFactory, T2, T3, T4, InnerDeliveryStreamSecretsManagerConfigurationFactory> WithSecretsManagerConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerDeliveryStreamDatabaseSourceAuthenticationConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.SecretsManagerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSecretsManagerConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDeliveryStreamDatabaseSourceAuthenticationConfigurationFactory, T3, T4, InnerDeliveryStreamSecretsManagerConfigurationFactory> WithSecretsManagerConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDeliveryStreamDatabaseSourceAuthenticationConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.SecretsManagerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSecretsManagerConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDeliveryStreamDatabaseSourceAuthenticationConfigurationFactory, T4, InnerDeliveryStreamSecretsManagerConfigurationFactory> WithSecretsManagerConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDeliveryStreamDatabaseSourceAuthenticationConfigurationFactory, T4> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.SecretsManagerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSecretsManagerConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDeliveryStreamDatabaseSourceAuthenticationConfigurationFactory, InnerDeliveryStreamSecretsManagerConfigurationFactory> WithSecretsManagerConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDeliveryStreamDatabaseSourceAuthenticationConfigurationFactory> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.SecretsManagerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSecretsManagerConfiguration(combinedResult.T5, subFactoryAction));
}
