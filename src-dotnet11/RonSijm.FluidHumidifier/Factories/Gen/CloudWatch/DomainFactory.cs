// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudWatch;

public class DomainFactory(string resourceName = null, Action<Humidifier.CloudWatch.Domain> factoryAction = null) : ResourceFactory<Humidifier.CloudWatch.Domain>(resourceName)
{

    internal InnerDomainIdentityProviderConfigurationFactory IdentityProviderConfigurationFactory { get; set; }

    protected override Humidifier.CloudWatch.Domain Create()
    {
        var domainResult = CreateDomain();
        factoryAction?.Invoke(domainResult);

        return domainResult;
    }

    private Humidifier.CloudWatch.Domain CreateDomain()
    {
        var domainResult = new Humidifier.CloudWatch.Domain
        {
            GivenName = InputResourceName,
        };

        return domainResult;
    }
    public override void CreateChildren(Humidifier.CloudWatch.Domain result)
    {
        base.CreateChildren(result);

        result.IdentityProviderConfiguration ??= IdentityProviderConfigurationFactory?.Build();
    }

} // End Of Class

public static class DomainFactoryExtensions
{
    public static CombinedResult<DomainFactory, InnerDomainIdentityProviderConfigurationFactory> WithIdentityProviderConfiguration(this DomainFactory parentFactory, Action<Humidifier.CloudWatch.DomainTypes.IdentityProviderConfiguration> subFactoryAction = null)
    {
        parentFactory.IdentityProviderConfigurationFactory = new InnerDomainIdentityProviderConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.IdentityProviderConfigurationFactory);
    }

    public static CombinedResult<DomainFactory, T1, InnerDomainIdentityProviderConfigurationFactory> WithIdentityProviderConfiguration<T1>(this CombinedResult<DomainFactory, T1> combinedResult, Action<Humidifier.CloudWatch.DomainTypes.IdentityProviderConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithIdentityProviderConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, DomainFactory, InnerDomainIdentityProviderConfigurationFactory> WithIdentityProviderConfiguration<T1>(this CombinedResult<T1, DomainFactory> combinedResult, Action<Humidifier.CloudWatch.DomainTypes.IdentityProviderConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithIdentityProviderConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<DomainFactory, T1, T2, InnerDomainIdentityProviderConfigurationFactory> WithIdentityProviderConfiguration<T1, T2>(this CombinedResult<DomainFactory, T1, T2> combinedResult, Action<Humidifier.CloudWatch.DomainTypes.IdentityProviderConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIdentityProviderConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, DomainFactory, T2, InnerDomainIdentityProviderConfigurationFactory> WithIdentityProviderConfiguration<T1, T2>(this CombinedResult<T1, DomainFactory, T2> combinedResult, Action<Humidifier.CloudWatch.DomainTypes.IdentityProviderConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIdentityProviderConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, DomainFactory, InnerDomainIdentityProviderConfigurationFactory> WithIdentityProviderConfiguration<T1, T2>(this CombinedResult<T1, T2, DomainFactory> combinedResult, Action<Humidifier.CloudWatch.DomainTypes.IdentityProviderConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIdentityProviderConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<DomainFactory, T1, T2, T3, InnerDomainIdentityProviderConfigurationFactory> WithIdentityProviderConfiguration<T1, T2, T3>(this CombinedResult<DomainFactory, T1, T2, T3> combinedResult, Action<Humidifier.CloudWatch.DomainTypes.IdentityProviderConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIdentityProviderConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, DomainFactory, T2, T3, InnerDomainIdentityProviderConfigurationFactory> WithIdentityProviderConfiguration<T1, T2, T3>(this CombinedResult<T1, DomainFactory, T2, T3> combinedResult, Action<Humidifier.CloudWatch.DomainTypes.IdentityProviderConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIdentityProviderConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, DomainFactory, T3, InnerDomainIdentityProviderConfigurationFactory> WithIdentityProviderConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, DomainFactory, T3> combinedResult, Action<Humidifier.CloudWatch.DomainTypes.IdentityProviderConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIdentityProviderConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, DomainFactory, InnerDomainIdentityProviderConfigurationFactory> WithIdentityProviderConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, DomainFactory> combinedResult, Action<Humidifier.CloudWatch.DomainTypes.IdentityProviderConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIdentityProviderConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<DomainFactory, T1, T2, T3, T4, InnerDomainIdentityProviderConfigurationFactory> WithIdentityProviderConfiguration<T1, T2, T3, T4>(this CombinedResult<DomainFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CloudWatch.DomainTypes.IdentityProviderConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdentityProviderConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, DomainFactory, T2, T3, T4, InnerDomainIdentityProviderConfigurationFactory> WithIdentityProviderConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, DomainFactory, T2, T3, T4> combinedResult, Action<Humidifier.CloudWatch.DomainTypes.IdentityProviderConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdentityProviderConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, DomainFactory, T3, T4, InnerDomainIdentityProviderConfigurationFactory> WithIdentityProviderConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, DomainFactory, T3, T4> combinedResult, Action<Humidifier.CloudWatch.DomainTypes.IdentityProviderConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdentityProviderConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, DomainFactory, T4, InnerDomainIdentityProviderConfigurationFactory> WithIdentityProviderConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, DomainFactory, T4> combinedResult, Action<Humidifier.CloudWatch.DomainTypes.IdentityProviderConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdentityProviderConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, DomainFactory, InnerDomainIdentityProviderConfigurationFactory> WithIdentityProviderConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, DomainFactory> combinedResult, Action<Humidifier.CloudWatch.DomainTypes.IdentityProviderConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdentityProviderConfiguration(combinedResult.T5, subFactoryAction).T2);
}
