// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class InnerAccountAuditConfigurationDeviceCertAgeAuditCheckConfigurationFactory(Action<Humidifier.IoT.AccountAuditConfigurationTypes.DeviceCertAgeAuditCheckConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.IoT.AccountAuditConfigurationTypes.DeviceCertAgeAuditCheckConfiguration>
{

    internal InnerAccountAuditConfigurationCertAgeCheckCustomConfigurationFactory ConfigurationFactory { get; set; }

    protected override Humidifier.IoT.AccountAuditConfigurationTypes.DeviceCertAgeAuditCheckConfiguration Create()
    {
        var deviceCertAgeAuditCheckConfigurationResult = CreateDeviceCertAgeAuditCheckConfiguration();
        factoryAction?.Invoke(deviceCertAgeAuditCheckConfigurationResult);

        return deviceCertAgeAuditCheckConfigurationResult;
    }

    private Humidifier.IoT.AccountAuditConfigurationTypes.DeviceCertAgeAuditCheckConfiguration CreateDeviceCertAgeAuditCheckConfiguration()
    {
        var deviceCertAgeAuditCheckConfigurationResult = new Humidifier.IoT.AccountAuditConfigurationTypes.DeviceCertAgeAuditCheckConfiguration();

        return deviceCertAgeAuditCheckConfigurationResult;
    }
    public override void CreateChildren(Humidifier.IoT.AccountAuditConfigurationTypes.DeviceCertAgeAuditCheckConfiguration result)
    {
        base.CreateChildren(result);

        result.Configuration ??= ConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerAccountAuditConfigurationDeviceCertAgeAuditCheckConfigurationFactoryExtensions
{
    public static CombinedResult<InnerAccountAuditConfigurationDeviceCertAgeAuditCheckConfigurationFactory, InnerAccountAuditConfigurationCertAgeCheckCustomConfigurationFactory> WithConfiguration(this InnerAccountAuditConfigurationDeviceCertAgeAuditCheckConfigurationFactory parentFactory, Action<Humidifier.IoT.AccountAuditConfigurationTypes.CertAgeCheckCustomConfiguration> subFactoryAction = null)
    {
        parentFactory.ConfigurationFactory = new InnerAccountAuditConfigurationCertAgeCheckCustomConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ConfigurationFactory);
    }

    public static CombinedResult<InnerAccountAuditConfigurationDeviceCertAgeAuditCheckConfigurationFactory, T1, InnerAccountAuditConfigurationCertAgeCheckCustomConfigurationFactory> WithConfiguration<T1>(this CombinedResult<InnerAccountAuditConfigurationDeviceCertAgeAuditCheckConfigurationFactory, T1> combinedResult, Action<Humidifier.IoT.AccountAuditConfigurationTypes.CertAgeCheckCustomConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAccountAuditConfigurationDeviceCertAgeAuditCheckConfigurationFactory, InnerAccountAuditConfigurationCertAgeCheckCustomConfigurationFactory> WithConfiguration<T1>(this CombinedResult<T1, InnerAccountAuditConfigurationDeviceCertAgeAuditCheckConfigurationFactory> combinedResult, Action<Humidifier.IoT.AccountAuditConfigurationTypes.CertAgeCheckCustomConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerAccountAuditConfigurationDeviceCertAgeAuditCheckConfigurationFactory, T1, T2, InnerAccountAuditConfigurationCertAgeCheckCustomConfigurationFactory> WithConfiguration<T1, T2>(this CombinedResult<InnerAccountAuditConfigurationDeviceCertAgeAuditCheckConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.IoT.AccountAuditConfigurationTypes.CertAgeCheckCustomConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAccountAuditConfigurationDeviceCertAgeAuditCheckConfigurationFactory, T2, InnerAccountAuditConfigurationCertAgeCheckCustomConfigurationFactory> WithConfiguration<T1, T2>(this CombinedResult<T1, InnerAccountAuditConfigurationDeviceCertAgeAuditCheckConfigurationFactory, T2> combinedResult, Action<Humidifier.IoT.AccountAuditConfigurationTypes.CertAgeCheckCustomConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAccountAuditConfigurationDeviceCertAgeAuditCheckConfigurationFactory, InnerAccountAuditConfigurationCertAgeCheckCustomConfigurationFactory> WithConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerAccountAuditConfigurationDeviceCertAgeAuditCheckConfigurationFactory> combinedResult, Action<Humidifier.IoT.AccountAuditConfigurationTypes.CertAgeCheckCustomConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerAccountAuditConfigurationDeviceCertAgeAuditCheckConfigurationFactory, T1, T2, T3, InnerAccountAuditConfigurationCertAgeCheckCustomConfigurationFactory> WithConfiguration<T1, T2, T3>(this CombinedResult<InnerAccountAuditConfigurationDeviceCertAgeAuditCheckConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoT.AccountAuditConfigurationTypes.CertAgeCheckCustomConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAccountAuditConfigurationDeviceCertAgeAuditCheckConfigurationFactory, T2, T3, InnerAccountAuditConfigurationCertAgeCheckCustomConfigurationFactory> WithConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerAccountAuditConfigurationDeviceCertAgeAuditCheckConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.IoT.AccountAuditConfigurationTypes.CertAgeCheckCustomConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAccountAuditConfigurationDeviceCertAgeAuditCheckConfigurationFactory, T3, InnerAccountAuditConfigurationCertAgeCheckCustomConfigurationFactory> WithConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerAccountAuditConfigurationDeviceCertAgeAuditCheckConfigurationFactory, T3> combinedResult, Action<Humidifier.IoT.AccountAuditConfigurationTypes.CertAgeCheckCustomConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerAccountAuditConfigurationDeviceCertAgeAuditCheckConfigurationFactory, InnerAccountAuditConfigurationCertAgeCheckCustomConfigurationFactory> WithConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerAccountAuditConfigurationDeviceCertAgeAuditCheckConfigurationFactory> combinedResult, Action<Humidifier.IoT.AccountAuditConfigurationTypes.CertAgeCheckCustomConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerAccountAuditConfigurationDeviceCertAgeAuditCheckConfigurationFactory, T1, T2, T3, T4, InnerAccountAuditConfigurationCertAgeCheckCustomConfigurationFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerAccountAuditConfigurationDeviceCertAgeAuditCheckConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoT.AccountAuditConfigurationTypes.CertAgeCheckCustomConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAccountAuditConfigurationDeviceCertAgeAuditCheckConfigurationFactory, T2, T3, T4, InnerAccountAuditConfigurationCertAgeCheckCustomConfigurationFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerAccountAuditConfigurationDeviceCertAgeAuditCheckConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoT.AccountAuditConfigurationTypes.CertAgeCheckCustomConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAccountAuditConfigurationDeviceCertAgeAuditCheckConfigurationFactory, T3, T4, InnerAccountAuditConfigurationCertAgeCheckCustomConfigurationFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerAccountAuditConfigurationDeviceCertAgeAuditCheckConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.IoT.AccountAuditConfigurationTypes.CertAgeCheckCustomConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerAccountAuditConfigurationDeviceCertAgeAuditCheckConfigurationFactory, T4, InnerAccountAuditConfigurationCertAgeCheckCustomConfigurationFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerAccountAuditConfigurationDeviceCertAgeAuditCheckConfigurationFactory, T4> combinedResult, Action<Humidifier.IoT.AccountAuditConfigurationTypes.CertAgeCheckCustomConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerAccountAuditConfigurationDeviceCertAgeAuditCheckConfigurationFactory, InnerAccountAuditConfigurationCertAgeCheckCustomConfigurationFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerAccountAuditConfigurationDeviceCertAgeAuditCheckConfigurationFactory> combinedResult, Action<Humidifier.IoT.AccountAuditConfigurationTypes.CertAgeCheckCustomConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T5, subFactoryAction).T2);
}
