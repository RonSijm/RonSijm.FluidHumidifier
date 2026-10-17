// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class InnerAccountAuditConfigurationDeviceCertExpirationAuditCheckConfigurationFactory(Action<Humidifier.IoT.AccountAuditConfigurationTypes.DeviceCertExpirationAuditCheckConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.IoT.AccountAuditConfigurationTypes.DeviceCertExpirationAuditCheckConfiguration>
{

    internal InnerAccountAuditConfigurationCertExpirationCheckCustomConfigurationFactory ConfigurationFactory { get; set; }

    protected override Humidifier.IoT.AccountAuditConfigurationTypes.DeviceCertExpirationAuditCheckConfiguration Create()
    {
        var deviceCertExpirationAuditCheckConfigurationResult = CreateDeviceCertExpirationAuditCheckConfiguration();
        factoryAction?.Invoke(deviceCertExpirationAuditCheckConfigurationResult);

        return deviceCertExpirationAuditCheckConfigurationResult;
    }

    private Humidifier.IoT.AccountAuditConfigurationTypes.DeviceCertExpirationAuditCheckConfiguration CreateDeviceCertExpirationAuditCheckConfiguration()
    {
        var deviceCertExpirationAuditCheckConfigurationResult = new Humidifier.IoT.AccountAuditConfigurationTypes.DeviceCertExpirationAuditCheckConfiguration();

        return deviceCertExpirationAuditCheckConfigurationResult;
    }
    public override void CreateChildren(Humidifier.IoT.AccountAuditConfigurationTypes.DeviceCertExpirationAuditCheckConfiguration result)
    {
        base.CreateChildren(result);

        result.Configuration ??= ConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerAccountAuditConfigurationDeviceCertExpirationAuditCheckConfigurationFactoryExtensions
{
    public static CombinedResult<InnerAccountAuditConfigurationDeviceCertExpirationAuditCheckConfigurationFactory, InnerAccountAuditConfigurationCertExpirationCheckCustomConfigurationFactory> WithConfiguration(this InnerAccountAuditConfigurationDeviceCertExpirationAuditCheckConfigurationFactory parentFactory, Action<Humidifier.IoT.AccountAuditConfigurationTypes.CertExpirationCheckCustomConfiguration> subFactoryAction = null)
    {
        parentFactory.ConfigurationFactory = new InnerAccountAuditConfigurationCertExpirationCheckCustomConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ConfigurationFactory);
    }

    public static CombinedResult<InnerAccountAuditConfigurationDeviceCertExpirationAuditCheckConfigurationFactory, T1, InnerAccountAuditConfigurationCertExpirationCheckCustomConfigurationFactory> WithConfiguration<T1>(this CombinedResult<InnerAccountAuditConfigurationDeviceCertExpirationAuditCheckConfigurationFactory, T1> combinedResult, Action<Humidifier.IoT.AccountAuditConfigurationTypes.CertExpirationCheckCustomConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAccountAuditConfigurationDeviceCertExpirationAuditCheckConfigurationFactory, InnerAccountAuditConfigurationCertExpirationCheckCustomConfigurationFactory> WithConfiguration<T1>(this CombinedResult<T1, InnerAccountAuditConfigurationDeviceCertExpirationAuditCheckConfigurationFactory> combinedResult, Action<Humidifier.IoT.AccountAuditConfigurationTypes.CertExpirationCheckCustomConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerAccountAuditConfigurationDeviceCertExpirationAuditCheckConfigurationFactory, T1, T2, InnerAccountAuditConfigurationCertExpirationCheckCustomConfigurationFactory> WithConfiguration<T1, T2>(this CombinedResult<InnerAccountAuditConfigurationDeviceCertExpirationAuditCheckConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.IoT.AccountAuditConfigurationTypes.CertExpirationCheckCustomConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAccountAuditConfigurationDeviceCertExpirationAuditCheckConfigurationFactory, T2, InnerAccountAuditConfigurationCertExpirationCheckCustomConfigurationFactory> WithConfiguration<T1, T2>(this CombinedResult<T1, InnerAccountAuditConfigurationDeviceCertExpirationAuditCheckConfigurationFactory, T2> combinedResult, Action<Humidifier.IoT.AccountAuditConfigurationTypes.CertExpirationCheckCustomConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAccountAuditConfigurationDeviceCertExpirationAuditCheckConfigurationFactory, InnerAccountAuditConfigurationCertExpirationCheckCustomConfigurationFactory> WithConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerAccountAuditConfigurationDeviceCertExpirationAuditCheckConfigurationFactory> combinedResult, Action<Humidifier.IoT.AccountAuditConfigurationTypes.CertExpirationCheckCustomConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerAccountAuditConfigurationDeviceCertExpirationAuditCheckConfigurationFactory, T1, T2, T3, InnerAccountAuditConfigurationCertExpirationCheckCustomConfigurationFactory> WithConfiguration<T1, T2, T3>(this CombinedResult<InnerAccountAuditConfigurationDeviceCertExpirationAuditCheckConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoT.AccountAuditConfigurationTypes.CertExpirationCheckCustomConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAccountAuditConfigurationDeviceCertExpirationAuditCheckConfigurationFactory, T2, T3, InnerAccountAuditConfigurationCertExpirationCheckCustomConfigurationFactory> WithConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerAccountAuditConfigurationDeviceCertExpirationAuditCheckConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.IoT.AccountAuditConfigurationTypes.CertExpirationCheckCustomConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAccountAuditConfigurationDeviceCertExpirationAuditCheckConfigurationFactory, T3, InnerAccountAuditConfigurationCertExpirationCheckCustomConfigurationFactory> WithConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerAccountAuditConfigurationDeviceCertExpirationAuditCheckConfigurationFactory, T3> combinedResult, Action<Humidifier.IoT.AccountAuditConfigurationTypes.CertExpirationCheckCustomConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerAccountAuditConfigurationDeviceCertExpirationAuditCheckConfigurationFactory, InnerAccountAuditConfigurationCertExpirationCheckCustomConfigurationFactory> WithConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerAccountAuditConfigurationDeviceCertExpirationAuditCheckConfigurationFactory> combinedResult, Action<Humidifier.IoT.AccountAuditConfigurationTypes.CertExpirationCheckCustomConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerAccountAuditConfigurationDeviceCertExpirationAuditCheckConfigurationFactory, T1, T2, T3, T4, InnerAccountAuditConfigurationCertExpirationCheckCustomConfigurationFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerAccountAuditConfigurationDeviceCertExpirationAuditCheckConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoT.AccountAuditConfigurationTypes.CertExpirationCheckCustomConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAccountAuditConfigurationDeviceCertExpirationAuditCheckConfigurationFactory, T2, T3, T4, InnerAccountAuditConfigurationCertExpirationCheckCustomConfigurationFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerAccountAuditConfigurationDeviceCertExpirationAuditCheckConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoT.AccountAuditConfigurationTypes.CertExpirationCheckCustomConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAccountAuditConfigurationDeviceCertExpirationAuditCheckConfigurationFactory, T3, T4, InnerAccountAuditConfigurationCertExpirationCheckCustomConfigurationFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerAccountAuditConfigurationDeviceCertExpirationAuditCheckConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.IoT.AccountAuditConfigurationTypes.CertExpirationCheckCustomConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerAccountAuditConfigurationDeviceCertExpirationAuditCheckConfigurationFactory, T4, InnerAccountAuditConfigurationCertExpirationCheckCustomConfigurationFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerAccountAuditConfigurationDeviceCertExpirationAuditCheckConfigurationFactory, T4> combinedResult, Action<Humidifier.IoT.AccountAuditConfigurationTypes.CertExpirationCheckCustomConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerAccountAuditConfigurationDeviceCertExpirationAuditCheckConfigurationFactory, InnerAccountAuditConfigurationCertExpirationCheckCustomConfigurationFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerAccountAuditConfigurationDeviceCertExpirationAuditCheckConfigurationFactory> combinedResult, Action<Humidifier.IoT.AccountAuditConfigurationTypes.CertExpirationCheckCustomConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T5, subFactoryAction).T2);
}
