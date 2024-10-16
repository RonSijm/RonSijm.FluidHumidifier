// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.VoiceID;

public class DomainFactory(string resourceName = null, Action<Humidifier.VoiceID.Domain> factoryAction = null) : ResourceFactory<Humidifier.VoiceID.Domain>(resourceName)
{

    internal InnerDomainServerSideEncryptionConfigurationFactory ServerSideEncryptionConfigurationFactory { get; set; }

    protected override Humidifier.VoiceID.Domain Create()
    {
        var domainResult = CreateDomain();
        factoryAction?.Invoke(domainResult);

        return domainResult;
    }

    private Humidifier.VoiceID.Domain CreateDomain()
    {
        var domainResult = new Humidifier.VoiceID.Domain
        {
            GivenName = InputResourceName,
        };

        return domainResult;
    }
    public override void CreateChildren(Humidifier.VoiceID.Domain result)
    {
        base.CreateChildren(result);

        result.ServerSideEncryptionConfiguration ??= ServerSideEncryptionConfigurationFactory?.Build();
    }

} // End Of Class

public static class DomainFactoryExtensions
{
    public static CombinedResult<DomainFactory, InnerDomainServerSideEncryptionConfigurationFactory> WithServerSideEncryptionConfiguration(this DomainFactory parentFactory, Action<Humidifier.VoiceID.DomainTypes.ServerSideEncryptionConfiguration> subFactoryAction = null)
    {
        parentFactory.ServerSideEncryptionConfigurationFactory = new InnerDomainServerSideEncryptionConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ServerSideEncryptionConfigurationFactory);
    }

    public static CombinedResult<DomainFactory, T1, InnerDomainServerSideEncryptionConfigurationFactory> WithServerSideEncryptionConfiguration<T1>(this CombinedResult<DomainFactory, T1> combinedResult, Action<Humidifier.VoiceID.DomainTypes.ServerSideEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithServerSideEncryptionConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DomainFactory, InnerDomainServerSideEncryptionConfigurationFactory> WithServerSideEncryptionConfiguration<T1>(this CombinedResult<T1, DomainFactory> combinedResult, Action<Humidifier.VoiceID.DomainTypes.ServerSideEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithServerSideEncryptionConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<DomainFactory, T1, T2, InnerDomainServerSideEncryptionConfigurationFactory> WithServerSideEncryptionConfiguration<T1, T2>(this CombinedResult<DomainFactory, T1, T2> combinedResult, Action<Humidifier.VoiceID.DomainTypes.ServerSideEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithServerSideEncryptionConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DomainFactory, T2, InnerDomainServerSideEncryptionConfigurationFactory> WithServerSideEncryptionConfiguration<T1, T2>(this CombinedResult<T1, DomainFactory, T2> combinedResult, Action<Humidifier.VoiceID.DomainTypes.ServerSideEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithServerSideEncryptionConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DomainFactory, InnerDomainServerSideEncryptionConfigurationFactory> WithServerSideEncryptionConfiguration<T1, T2>(this CombinedResult<T1, T2, DomainFactory> combinedResult, Action<Humidifier.VoiceID.DomainTypes.ServerSideEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithServerSideEncryptionConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<DomainFactory, T1, T2, T3, InnerDomainServerSideEncryptionConfigurationFactory> WithServerSideEncryptionConfiguration<T1, T2, T3>(this CombinedResult<DomainFactory, T1, T2, T3> combinedResult, Action<Humidifier.VoiceID.DomainTypes.ServerSideEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithServerSideEncryptionConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DomainFactory, T2, T3, InnerDomainServerSideEncryptionConfigurationFactory> WithServerSideEncryptionConfiguration<T1, T2, T3>(this CombinedResult<T1, DomainFactory, T2, T3> combinedResult, Action<Humidifier.VoiceID.DomainTypes.ServerSideEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithServerSideEncryptionConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DomainFactory, T3, InnerDomainServerSideEncryptionConfigurationFactory> WithServerSideEncryptionConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, DomainFactory, T3> combinedResult, Action<Humidifier.VoiceID.DomainTypes.ServerSideEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithServerSideEncryptionConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DomainFactory, InnerDomainServerSideEncryptionConfigurationFactory> WithServerSideEncryptionConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, DomainFactory> combinedResult, Action<Humidifier.VoiceID.DomainTypes.ServerSideEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithServerSideEncryptionConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<DomainFactory, T1, T2, T3, T4, InnerDomainServerSideEncryptionConfigurationFactory> WithServerSideEncryptionConfiguration<T1, T2, T3, T4>(this CombinedResult<DomainFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.VoiceID.DomainTypes.ServerSideEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithServerSideEncryptionConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DomainFactory, T2, T3, T4, InnerDomainServerSideEncryptionConfigurationFactory> WithServerSideEncryptionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, DomainFactory, T2, T3, T4> combinedResult, Action<Humidifier.VoiceID.DomainTypes.ServerSideEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithServerSideEncryptionConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DomainFactory, T3, T4, InnerDomainServerSideEncryptionConfigurationFactory> WithServerSideEncryptionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, DomainFactory, T3, T4> combinedResult, Action<Humidifier.VoiceID.DomainTypes.ServerSideEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithServerSideEncryptionConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DomainFactory, T4, InnerDomainServerSideEncryptionConfigurationFactory> WithServerSideEncryptionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, DomainFactory, T4> combinedResult, Action<Humidifier.VoiceID.DomainTypes.ServerSideEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithServerSideEncryptionConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, DomainFactory, InnerDomainServerSideEncryptionConfigurationFactory> WithServerSideEncryptionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, DomainFactory> combinedResult, Action<Humidifier.VoiceID.DomainTypes.ServerSideEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithServerSideEncryptionConfiguration(combinedResult.T5, subFactoryAction));
}
