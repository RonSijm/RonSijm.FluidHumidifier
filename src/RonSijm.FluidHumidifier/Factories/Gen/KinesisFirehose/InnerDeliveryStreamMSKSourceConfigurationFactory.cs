// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.KinesisFirehose;

public class InnerDeliveryStreamMSKSourceConfigurationFactory(Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.MSKSourceConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.KinesisFirehose.DeliveryStreamTypes.MSKSourceConfiguration>
{

    internal InnerDeliveryStreamAuthenticationConfigurationFactory AuthenticationConfigurationFactory { get; set; }

    protected override Humidifier.KinesisFirehose.DeliveryStreamTypes.MSKSourceConfiguration Create()
    {
        var mSKSourceConfigurationResult = CreateMSKSourceConfiguration();
        factoryAction?.Invoke(mSKSourceConfigurationResult);

        return mSKSourceConfigurationResult;
    }

    private Humidifier.KinesisFirehose.DeliveryStreamTypes.MSKSourceConfiguration CreateMSKSourceConfiguration()
    {
        var mSKSourceConfigurationResult = new Humidifier.KinesisFirehose.DeliveryStreamTypes.MSKSourceConfiguration();

        return mSKSourceConfigurationResult;
    }
    public override void CreateChildren(Humidifier.KinesisFirehose.DeliveryStreamTypes.MSKSourceConfiguration result)
    {
        base.CreateChildren(result);

        result.AuthenticationConfiguration ??= AuthenticationConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerDeliveryStreamMSKSourceConfigurationFactoryExtensions
{
    public static CombinedResult<InnerDeliveryStreamMSKSourceConfigurationFactory, InnerDeliveryStreamAuthenticationConfigurationFactory> WithAuthenticationConfiguration(this InnerDeliveryStreamMSKSourceConfigurationFactory parentFactory, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.AuthenticationConfiguration> subFactoryAction = null)
    {
        parentFactory.AuthenticationConfigurationFactory = new InnerDeliveryStreamAuthenticationConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AuthenticationConfigurationFactory);
    }

    public static CombinedResult<InnerDeliveryStreamMSKSourceConfigurationFactory, T1, InnerDeliveryStreamAuthenticationConfigurationFactory> WithAuthenticationConfiguration<T1>(this CombinedResult<InnerDeliveryStreamMSKSourceConfigurationFactory, T1> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.AuthenticationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithAuthenticationConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDeliveryStreamMSKSourceConfigurationFactory, InnerDeliveryStreamAuthenticationConfigurationFactory> WithAuthenticationConfiguration<T1>(this CombinedResult<T1, InnerDeliveryStreamMSKSourceConfigurationFactory> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.AuthenticationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithAuthenticationConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDeliveryStreamMSKSourceConfigurationFactory, T1, T2, InnerDeliveryStreamAuthenticationConfigurationFactory> WithAuthenticationConfiguration<T1, T2>(this CombinedResult<InnerDeliveryStreamMSKSourceConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.AuthenticationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAuthenticationConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDeliveryStreamMSKSourceConfigurationFactory, T2, InnerDeliveryStreamAuthenticationConfigurationFactory> WithAuthenticationConfiguration<T1, T2>(this CombinedResult<T1, InnerDeliveryStreamMSKSourceConfigurationFactory, T2> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.AuthenticationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAuthenticationConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDeliveryStreamMSKSourceConfigurationFactory, InnerDeliveryStreamAuthenticationConfigurationFactory> WithAuthenticationConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerDeliveryStreamMSKSourceConfigurationFactory> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.AuthenticationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAuthenticationConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDeliveryStreamMSKSourceConfigurationFactory, T1, T2, T3, InnerDeliveryStreamAuthenticationConfigurationFactory> WithAuthenticationConfiguration<T1, T2, T3>(this CombinedResult<InnerDeliveryStreamMSKSourceConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.AuthenticationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuthenticationConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDeliveryStreamMSKSourceConfigurationFactory, T2, T3, InnerDeliveryStreamAuthenticationConfigurationFactory> WithAuthenticationConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerDeliveryStreamMSKSourceConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.AuthenticationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuthenticationConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDeliveryStreamMSKSourceConfigurationFactory, T3, InnerDeliveryStreamAuthenticationConfigurationFactory> WithAuthenticationConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerDeliveryStreamMSKSourceConfigurationFactory, T3> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.AuthenticationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuthenticationConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDeliveryStreamMSKSourceConfigurationFactory, InnerDeliveryStreamAuthenticationConfigurationFactory> WithAuthenticationConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDeliveryStreamMSKSourceConfigurationFactory> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.AuthenticationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuthenticationConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDeliveryStreamMSKSourceConfigurationFactory, T1, T2, T3, T4, InnerDeliveryStreamAuthenticationConfigurationFactory> WithAuthenticationConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerDeliveryStreamMSKSourceConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.AuthenticationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthenticationConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDeliveryStreamMSKSourceConfigurationFactory, T2, T3, T4, InnerDeliveryStreamAuthenticationConfigurationFactory> WithAuthenticationConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerDeliveryStreamMSKSourceConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.AuthenticationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthenticationConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDeliveryStreamMSKSourceConfigurationFactory, T3, T4, InnerDeliveryStreamAuthenticationConfigurationFactory> WithAuthenticationConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDeliveryStreamMSKSourceConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.AuthenticationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthenticationConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDeliveryStreamMSKSourceConfigurationFactory, T4, InnerDeliveryStreamAuthenticationConfigurationFactory> WithAuthenticationConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDeliveryStreamMSKSourceConfigurationFactory, T4> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.AuthenticationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthenticationConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDeliveryStreamMSKSourceConfigurationFactory, InnerDeliveryStreamAuthenticationConfigurationFactory> WithAuthenticationConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDeliveryStreamMSKSourceConfigurationFactory> combinedResult, Action<Humidifier.KinesisFirehose.DeliveryStreamTypes.AuthenticationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthenticationConfiguration(combinedResult.T5, subFactoryAction));
}
