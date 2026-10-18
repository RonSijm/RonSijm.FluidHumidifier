// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EMRContainers;

public class InnerSecurityConfigurationInTransitEncryptionConfigurationFactory(Action<Humidifier.EMRContainers.SecurityConfigurationTypes.InTransitEncryptionConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.EMRContainers.SecurityConfigurationTypes.InTransitEncryptionConfiguration>
{

    internal InnerSecurityConfigurationTLSCertificateConfigurationFactory TLSCertificateConfigurationFactory { get; set; }

    protected override Humidifier.EMRContainers.SecurityConfigurationTypes.InTransitEncryptionConfiguration Create()
    {
        var inTransitEncryptionConfigurationResult = CreateInTransitEncryptionConfiguration();
        factoryAction?.Invoke(inTransitEncryptionConfigurationResult);

        return inTransitEncryptionConfigurationResult;
    }

    private Humidifier.EMRContainers.SecurityConfigurationTypes.InTransitEncryptionConfiguration CreateInTransitEncryptionConfiguration()
    {
        var inTransitEncryptionConfigurationResult = new Humidifier.EMRContainers.SecurityConfigurationTypes.InTransitEncryptionConfiguration();

        return inTransitEncryptionConfigurationResult;
    }
    public override void CreateChildren(Humidifier.EMRContainers.SecurityConfigurationTypes.InTransitEncryptionConfiguration result)
    {
        base.CreateChildren(result);

        result.TLSCertificateConfiguration ??= TLSCertificateConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerSecurityConfigurationInTransitEncryptionConfigurationFactoryExtensions
{
    public static CombinedResult<InnerSecurityConfigurationInTransitEncryptionConfigurationFactory, InnerSecurityConfigurationTLSCertificateConfigurationFactory> WithTLSCertificateConfiguration(this InnerSecurityConfigurationInTransitEncryptionConfigurationFactory parentFactory, Action<Humidifier.EMRContainers.SecurityConfigurationTypes.TLSCertificateConfiguration> subFactoryAction = null)
    {
        parentFactory.TLSCertificateConfigurationFactory = new InnerSecurityConfigurationTLSCertificateConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.TLSCertificateConfigurationFactory);
    }

    public static CombinedResult<InnerSecurityConfigurationInTransitEncryptionConfigurationFactory, T1, InnerSecurityConfigurationTLSCertificateConfigurationFactory> WithTLSCertificateConfiguration<T1>(this CombinedResult<InnerSecurityConfigurationInTransitEncryptionConfigurationFactory, T1> combinedResult, Action<Humidifier.EMRContainers.SecurityConfigurationTypes.TLSCertificateConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithTLSCertificateConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerSecurityConfigurationInTransitEncryptionConfigurationFactory, InnerSecurityConfigurationTLSCertificateConfigurationFactory> WithTLSCertificateConfiguration<T1>(this CombinedResult<T1, InnerSecurityConfigurationInTransitEncryptionConfigurationFactory> combinedResult, Action<Humidifier.EMRContainers.SecurityConfigurationTypes.TLSCertificateConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithTLSCertificateConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerSecurityConfigurationInTransitEncryptionConfigurationFactory, T1, T2, InnerSecurityConfigurationTLSCertificateConfigurationFactory> WithTLSCertificateConfiguration<T1, T2>(this CombinedResult<InnerSecurityConfigurationInTransitEncryptionConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.EMRContainers.SecurityConfigurationTypes.TLSCertificateConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTLSCertificateConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerSecurityConfigurationInTransitEncryptionConfigurationFactory, T2, InnerSecurityConfigurationTLSCertificateConfigurationFactory> WithTLSCertificateConfiguration<T1, T2>(this CombinedResult<T1, InnerSecurityConfigurationInTransitEncryptionConfigurationFactory, T2> combinedResult, Action<Humidifier.EMRContainers.SecurityConfigurationTypes.TLSCertificateConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTLSCertificateConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerSecurityConfigurationInTransitEncryptionConfigurationFactory, InnerSecurityConfigurationTLSCertificateConfigurationFactory> WithTLSCertificateConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerSecurityConfigurationInTransitEncryptionConfigurationFactory> combinedResult, Action<Humidifier.EMRContainers.SecurityConfigurationTypes.TLSCertificateConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTLSCertificateConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerSecurityConfigurationInTransitEncryptionConfigurationFactory, T1, T2, T3, InnerSecurityConfigurationTLSCertificateConfigurationFactory> WithTLSCertificateConfiguration<T1, T2, T3>(this CombinedResult<InnerSecurityConfigurationInTransitEncryptionConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.EMRContainers.SecurityConfigurationTypes.TLSCertificateConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTLSCertificateConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerSecurityConfigurationInTransitEncryptionConfigurationFactory, T2, T3, InnerSecurityConfigurationTLSCertificateConfigurationFactory> WithTLSCertificateConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerSecurityConfigurationInTransitEncryptionConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.EMRContainers.SecurityConfigurationTypes.TLSCertificateConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTLSCertificateConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerSecurityConfigurationInTransitEncryptionConfigurationFactory, T3, InnerSecurityConfigurationTLSCertificateConfigurationFactory> WithTLSCertificateConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerSecurityConfigurationInTransitEncryptionConfigurationFactory, T3> combinedResult, Action<Humidifier.EMRContainers.SecurityConfigurationTypes.TLSCertificateConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTLSCertificateConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerSecurityConfigurationInTransitEncryptionConfigurationFactory, InnerSecurityConfigurationTLSCertificateConfigurationFactory> WithTLSCertificateConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerSecurityConfigurationInTransitEncryptionConfigurationFactory> combinedResult, Action<Humidifier.EMRContainers.SecurityConfigurationTypes.TLSCertificateConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTLSCertificateConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerSecurityConfigurationInTransitEncryptionConfigurationFactory, T1, T2, T3, T4, InnerSecurityConfigurationTLSCertificateConfigurationFactory> WithTLSCertificateConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerSecurityConfigurationInTransitEncryptionConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EMRContainers.SecurityConfigurationTypes.TLSCertificateConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTLSCertificateConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerSecurityConfigurationInTransitEncryptionConfigurationFactory, T2, T3, T4, InnerSecurityConfigurationTLSCertificateConfigurationFactory> WithTLSCertificateConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerSecurityConfigurationInTransitEncryptionConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.EMRContainers.SecurityConfigurationTypes.TLSCertificateConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTLSCertificateConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerSecurityConfigurationInTransitEncryptionConfigurationFactory, T3, T4, InnerSecurityConfigurationTLSCertificateConfigurationFactory> WithTLSCertificateConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerSecurityConfigurationInTransitEncryptionConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.EMRContainers.SecurityConfigurationTypes.TLSCertificateConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTLSCertificateConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerSecurityConfigurationInTransitEncryptionConfigurationFactory, T4, InnerSecurityConfigurationTLSCertificateConfigurationFactory> WithTLSCertificateConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerSecurityConfigurationInTransitEncryptionConfigurationFactory, T4> combinedResult, Action<Humidifier.EMRContainers.SecurityConfigurationTypes.TLSCertificateConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTLSCertificateConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerSecurityConfigurationInTransitEncryptionConfigurationFactory, InnerSecurityConfigurationTLSCertificateConfigurationFactory> WithTLSCertificateConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerSecurityConfigurationInTransitEncryptionConfigurationFactory> combinedResult, Action<Humidifier.EMRContainers.SecurityConfigurationTypes.TLSCertificateConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTLSCertificateConfiguration(combinedResult.T5, subFactoryAction).T2);
}
