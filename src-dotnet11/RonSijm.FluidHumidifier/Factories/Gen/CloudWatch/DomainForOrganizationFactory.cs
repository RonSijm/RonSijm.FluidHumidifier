// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudWatch;

public class DomainForOrganizationFactory(string resourceName = null, Action<Humidifier.CloudWatch.DomainForOrganization> factoryAction = null) : ResourceFactory<Humidifier.CloudWatch.DomainForOrganization>(resourceName)
{

    internal InnerDomainForOrganizationIdentityProviderConfigurationFactory IdentityProviderConfigurationFactory { get; set; }

    protected override Humidifier.CloudWatch.DomainForOrganization Create()
    {
        var domainForOrganizationResult = CreateDomainForOrganization();
        factoryAction?.Invoke(domainForOrganizationResult);

        return domainForOrganizationResult;
    }

    private Humidifier.CloudWatch.DomainForOrganization CreateDomainForOrganization()
    {
        var domainForOrganizationResult = new Humidifier.CloudWatch.DomainForOrganization
        {
            GivenName = InputResourceName,
        };

        return domainForOrganizationResult;
    }
    public override void CreateChildren(Humidifier.CloudWatch.DomainForOrganization result)
    {
        base.CreateChildren(result);

        result.IdentityProviderConfiguration ??= IdentityProviderConfigurationFactory?.Build();
    }

} // End Of Class

public static class DomainForOrganizationFactoryExtensions
{
    public static CombinedResult<DomainForOrganizationFactory, InnerDomainForOrganizationIdentityProviderConfigurationFactory> WithIdentityProviderConfiguration(this DomainForOrganizationFactory parentFactory, Action<Humidifier.CloudWatch.DomainForOrganizationTypes.IdentityProviderConfiguration> subFactoryAction = null)
    {
        parentFactory.IdentityProviderConfigurationFactory = new InnerDomainForOrganizationIdentityProviderConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.IdentityProviderConfigurationFactory);
    }

    public static CombinedResult<DomainForOrganizationFactory, T1, InnerDomainForOrganizationIdentityProviderConfigurationFactory> WithIdentityProviderConfiguration<T1>(this CombinedResult<DomainForOrganizationFactory, T1> combinedResult, Action<Humidifier.CloudWatch.DomainForOrganizationTypes.IdentityProviderConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithIdentityProviderConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, DomainForOrganizationFactory, InnerDomainForOrganizationIdentityProviderConfigurationFactory> WithIdentityProviderConfiguration<T1>(this CombinedResult<T1, DomainForOrganizationFactory> combinedResult, Action<Humidifier.CloudWatch.DomainForOrganizationTypes.IdentityProviderConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithIdentityProviderConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<DomainForOrganizationFactory, T1, T2, InnerDomainForOrganizationIdentityProviderConfigurationFactory> WithIdentityProviderConfiguration<T1, T2>(this CombinedResult<DomainForOrganizationFactory, T1, T2> combinedResult, Action<Humidifier.CloudWatch.DomainForOrganizationTypes.IdentityProviderConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIdentityProviderConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, DomainForOrganizationFactory, T2, InnerDomainForOrganizationIdentityProviderConfigurationFactory> WithIdentityProviderConfiguration<T1, T2>(this CombinedResult<T1, DomainForOrganizationFactory, T2> combinedResult, Action<Humidifier.CloudWatch.DomainForOrganizationTypes.IdentityProviderConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIdentityProviderConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, DomainForOrganizationFactory, InnerDomainForOrganizationIdentityProviderConfigurationFactory> WithIdentityProviderConfiguration<T1, T2>(this CombinedResult<T1, T2, DomainForOrganizationFactory> combinedResult, Action<Humidifier.CloudWatch.DomainForOrganizationTypes.IdentityProviderConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIdentityProviderConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<DomainForOrganizationFactory, T1, T2, T3, InnerDomainForOrganizationIdentityProviderConfigurationFactory> WithIdentityProviderConfiguration<T1, T2, T3>(this CombinedResult<DomainForOrganizationFactory, T1, T2, T3> combinedResult, Action<Humidifier.CloudWatch.DomainForOrganizationTypes.IdentityProviderConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIdentityProviderConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, DomainForOrganizationFactory, T2, T3, InnerDomainForOrganizationIdentityProviderConfigurationFactory> WithIdentityProviderConfiguration<T1, T2, T3>(this CombinedResult<T1, DomainForOrganizationFactory, T2, T3> combinedResult, Action<Humidifier.CloudWatch.DomainForOrganizationTypes.IdentityProviderConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIdentityProviderConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, DomainForOrganizationFactory, T3, InnerDomainForOrganizationIdentityProviderConfigurationFactory> WithIdentityProviderConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, DomainForOrganizationFactory, T3> combinedResult, Action<Humidifier.CloudWatch.DomainForOrganizationTypes.IdentityProviderConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIdentityProviderConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, DomainForOrganizationFactory, InnerDomainForOrganizationIdentityProviderConfigurationFactory> WithIdentityProviderConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, DomainForOrganizationFactory> combinedResult, Action<Humidifier.CloudWatch.DomainForOrganizationTypes.IdentityProviderConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIdentityProviderConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<DomainForOrganizationFactory, T1, T2, T3, T4, InnerDomainForOrganizationIdentityProviderConfigurationFactory> WithIdentityProviderConfiguration<T1, T2, T3, T4>(this CombinedResult<DomainForOrganizationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CloudWatch.DomainForOrganizationTypes.IdentityProviderConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdentityProviderConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, DomainForOrganizationFactory, T2, T3, T4, InnerDomainForOrganizationIdentityProviderConfigurationFactory> WithIdentityProviderConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, DomainForOrganizationFactory, T2, T3, T4> combinedResult, Action<Humidifier.CloudWatch.DomainForOrganizationTypes.IdentityProviderConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdentityProviderConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, DomainForOrganizationFactory, T3, T4, InnerDomainForOrganizationIdentityProviderConfigurationFactory> WithIdentityProviderConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, DomainForOrganizationFactory, T3, T4> combinedResult, Action<Humidifier.CloudWatch.DomainForOrganizationTypes.IdentityProviderConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdentityProviderConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, DomainForOrganizationFactory, T4, InnerDomainForOrganizationIdentityProviderConfigurationFactory> WithIdentityProviderConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, DomainForOrganizationFactory, T4> combinedResult, Action<Humidifier.CloudWatch.DomainForOrganizationTypes.IdentityProviderConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdentityProviderConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, DomainForOrganizationFactory, InnerDomainForOrganizationIdentityProviderConfigurationFactory> WithIdentityProviderConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, DomainForOrganizationFactory> combinedResult, Action<Humidifier.CloudWatch.DomainForOrganizationTypes.IdentityProviderConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdentityProviderConfiguration(combinedResult.T5, subFactoryAction).T2);
}
