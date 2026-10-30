// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudWatch;

public class InnerDomainForOrganizationIdentityProviderConfigurationFactory(Action<Humidifier.CloudWatch.DomainForOrganizationTypes.IdentityProviderConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.CloudWatch.DomainForOrganizationTypes.IdentityProviderConfiguration>
{

    internal InnerDomainForOrganizationIdentityCenterConfigurationFactory IdentityCenterConfigurationFactory { get; set; }

    protected override Humidifier.CloudWatch.DomainForOrganizationTypes.IdentityProviderConfiguration Create()
    {
        var identityProviderConfigurationResult = CreateIdentityProviderConfiguration();
        factoryAction?.Invoke(identityProviderConfigurationResult);

        return identityProviderConfigurationResult;
    }

    private Humidifier.CloudWatch.DomainForOrganizationTypes.IdentityProviderConfiguration CreateIdentityProviderConfiguration()
    {
        var identityProviderConfigurationResult = new Humidifier.CloudWatch.DomainForOrganizationTypes.IdentityProviderConfiguration();

        return identityProviderConfigurationResult;
    }
    public override void CreateChildren(Humidifier.CloudWatch.DomainForOrganizationTypes.IdentityProviderConfiguration result)
    {
        base.CreateChildren(result);

        result.IdentityCenterConfiguration ??= IdentityCenterConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerDomainForOrganizationIdentityProviderConfigurationFactoryExtensions
{
    public static CombinedResult<InnerDomainForOrganizationIdentityProviderConfigurationFactory, InnerDomainForOrganizationIdentityCenterConfigurationFactory> WithIdentityCenterConfiguration(this InnerDomainForOrganizationIdentityProviderConfigurationFactory parentFactory, Action<Humidifier.CloudWatch.DomainForOrganizationTypes.IdentityCenterConfiguration> subFactoryAction = null)
    {
        parentFactory.IdentityCenterConfigurationFactory = new InnerDomainForOrganizationIdentityCenterConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.IdentityCenterConfigurationFactory);
    }

    public static CombinedResult<InnerDomainForOrganizationIdentityProviderConfigurationFactory, T1, InnerDomainForOrganizationIdentityCenterConfigurationFactory> WithIdentityCenterConfiguration<T1>(this CombinedResult<InnerDomainForOrganizationIdentityProviderConfigurationFactory, T1> combinedResult, Action<Humidifier.CloudWatch.DomainForOrganizationTypes.IdentityCenterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithIdentityCenterConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDomainForOrganizationIdentityProviderConfigurationFactory, InnerDomainForOrganizationIdentityCenterConfigurationFactory> WithIdentityCenterConfiguration<T1>(this CombinedResult<T1, InnerDomainForOrganizationIdentityProviderConfigurationFactory> combinedResult, Action<Humidifier.CloudWatch.DomainForOrganizationTypes.IdentityCenterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithIdentityCenterConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerDomainForOrganizationIdentityProviderConfigurationFactory, T1, T2, InnerDomainForOrganizationIdentityCenterConfigurationFactory> WithIdentityCenterConfiguration<T1, T2>(this CombinedResult<InnerDomainForOrganizationIdentityProviderConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.CloudWatch.DomainForOrganizationTypes.IdentityCenterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIdentityCenterConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDomainForOrganizationIdentityProviderConfigurationFactory, T2, InnerDomainForOrganizationIdentityCenterConfigurationFactory> WithIdentityCenterConfiguration<T1, T2>(this CombinedResult<T1, InnerDomainForOrganizationIdentityProviderConfigurationFactory, T2> combinedResult, Action<Humidifier.CloudWatch.DomainForOrganizationTypes.IdentityCenterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIdentityCenterConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDomainForOrganizationIdentityProviderConfigurationFactory, InnerDomainForOrganizationIdentityCenterConfigurationFactory> WithIdentityCenterConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerDomainForOrganizationIdentityProviderConfigurationFactory> combinedResult, Action<Humidifier.CloudWatch.DomainForOrganizationTypes.IdentityCenterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIdentityCenterConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerDomainForOrganizationIdentityProviderConfigurationFactory, T1, T2, T3, InnerDomainForOrganizationIdentityCenterConfigurationFactory> WithIdentityCenterConfiguration<T1, T2, T3>(this CombinedResult<InnerDomainForOrganizationIdentityProviderConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.CloudWatch.DomainForOrganizationTypes.IdentityCenterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIdentityCenterConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDomainForOrganizationIdentityProviderConfigurationFactory, T2, T3, InnerDomainForOrganizationIdentityCenterConfigurationFactory> WithIdentityCenterConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerDomainForOrganizationIdentityProviderConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.CloudWatch.DomainForOrganizationTypes.IdentityCenterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIdentityCenterConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDomainForOrganizationIdentityProviderConfigurationFactory, T3, InnerDomainForOrganizationIdentityCenterConfigurationFactory> WithIdentityCenterConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerDomainForOrganizationIdentityProviderConfigurationFactory, T3> combinedResult, Action<Humidifier.CloudWatch.DomainForOrganizationTypes.IdentityCenterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIdentityCenterConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerDomainForOrganizationIdentityProviderConfigurationFactory, InnerDomainForOrganizationIdentityCenterConfigurationFactory> WithIdentityCenterConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDomainForOrganizationIdentityProviderConfigurationFactory> combinedResult, Action<Humidifier.CloudWatch.DomainForOrganizationTypes.IdentityCenterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIdentityCenterConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerDomainForOrganizationIdentityProviderConfigurationFactory, T1, T2, T3, T4, InnerDomainForOrganizationIdentityCenterConfigurationFactory> WithIdentityCenterConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerDomainForOrganizationIdentityProviderConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CloudWatch.DomainForOrganizationTypes.IdentityCenterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdentityCenterConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDomainForOrganizationIdentityProviderConfigurationFactory, T2, T3, T4, InnerDomainForOrganizationIdentityCenterConfigurationFactory> WithIdentityCenterConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerDomainForOrganizationIdentityProviderConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.CloudWatch.DomainForOrganizationTypes.IdentityCenterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdentityCenterConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDomainForOrganizationIdentityProviderConfigurationFactory, T3, T4, InnerDomainForOrganizationIdentityCenterConfigurationFactory> WithIdentityCenterConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDomainForOrganizationIdentityProviderConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.CloudWatch.DomainForOrganizationTypes.IdentityCenterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdentityCenterConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerDomainForOrganizationIdentityProviderConfigurationFactory, T4, InnerDomainForOrganizationIdentityCenterConfigurationFactory> WithIdentityCenterConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDomainForOrganizationIdentityProviderConfigurationFactory, T4> combinedResult, Action<Humidifier.CloudWatch.DomainForOrganizationTypes.IdentityCenterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdentityCenterConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerDomainForOrganizationIdentityProviderConfigurationFactory, InnerDomainForOrganizationIdentityCenterConfigurationFactory> WithIdentityCenterConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDomainForOrganizationIdentityProviderConfigurationFactory> combinedResult, Action<Humidifier.CloudWatch.DomainForOrganizationTypes.IdentityCenterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdentityCenterConfiguration(combinedResult.T5, subFactoryAction).T2);
}
