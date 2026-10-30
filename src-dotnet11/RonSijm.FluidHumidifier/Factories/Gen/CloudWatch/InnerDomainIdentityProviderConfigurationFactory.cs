// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudWatch;

public class InnerDomainIdentityProviderConfigurationFactory(Action<Humidifier.CloudWatch.DomainTypes.IdentityProviderConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.CloudWatch.DomainTypes.IdentityProviderConfiguration>
{

    internal InnerDomainIdentityCenterConfigurationFactory IdentityCenterConfigurationFactory { get; set; }

    protected override Humidifier.CloudWatch.DomainTypes.IdentityProviderConfiguration Create()
    {
        var identityProviderConfigurationResult = CreateIdentityProviderConfiguration();
        factoryAction?.Invoke(identityProviderConfigurationResult);

        return identityProviderConfigurationResult;
    }

    private Humidifier.CloudWatch.DomainTypes.IdentityProviderConfiguration CreateIdentityProviderConfiguration()
    {
        var identityProviderConfigurationResult = new Humidifier.CloudWatch.DomainTypes.IdentityProviderConfiguration();

        return identityProviderConfigurationResult;
    }
    public override void CreateChildren(Humidifier.CloudWatch.DomainTypes.IdentityProviderConfiguration result)
    {
        base.CreateChildren(result);

        result.IdentityCenterConfiguration ??= IdentityCenterConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerDomainIdentityProviderConfigurationFactoryExtensions
{
    public static CombinedResult<InnerDomainIdentityProviderConfigurationFactory, InnerDomainIdentityCenterConfigurationFactory> WithIdentityCenterConfiguration(this InnerDomainIdentityProviderConfigurationFactory parentFactory, Action<Humidifier.CloudWatch.DomainTypes.IdentityCenterConfiguration> subFactoryAction = null)
    {
        parentFactory.IdentityCenterConfigurationFactory = new InnerDomainIdentityCenterConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.IdentityCenterConfigurationFactory);
    }

    public static CombinedResult<InnerDomainIdentityProviderConfigurationFactory, T1, InnerDomainIdentityCenterConfigurationFactory> WithIdentityCenterConfiguration<T1>(this CombinedResult<InnerDomainIdentityProviderConfigurationFactory, T1> combinedResult, Action<Humidifier.CloudWatch.DomainTypes.IdentityCenterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithIdentityCenterConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDomainIdentityProviderConfigurationFactory, InnerDomainIdentityCenterConfigurationFactory> WithIdentityCenterConfiguration<T1>(this CombinedResult<T1, InnerDomainIdentityProviderConfigurationFactory> combinedResult, Action<Humidifier.CloudWatch.DomainTypes.IdentityCenterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithIdentityCenterConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerDomainIdentityProviderConfigurationFactory, T1, T2, InnerDomainIdentityCenterConfigurationFactory> WithIdentityCenterConfiguration<T1, T2>(this CombinedResult<InnerDomainIdentityProviderConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.CloudWatch.DomainTypes.IdentityCenterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIdentityCenterConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDomainIdentityProviderConfigurationFactory, T2, InnerDomainIdentityCenterConfigurationFactory> WithIdentityCenterConfiguration<T1, T2>(this CombinedResult<T1, InnerDomainIdentityProviderConfigurationFactory, T2> combinedResult, Action<Humidifier.CloudWatch.DomainTypes.IdentityCenterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIdentityCenterConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDomainIdentityProviderConfigurationFactory, InnerDomainIdentityCenterConfigurationFactory> WithIdentityCenterConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerDomainIdentityProviderConfigurationFactory> combinedResult, Action<Humidifier.CloudWatch.DomainTypes.IdentityCenterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIdentityCenterConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerDomainIdentityProviderConfigurationFactory, T1, T2, T3, InnerDomainIdentityCenterConfigurationFactory> WithIdentityCenterConfiguration<T1, T2, T3>(this CombinedResult<InnerDomainIdentityProviderConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.CloudWatch.DomainTypes.IdentityCenterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIdentityCenterConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDomainIdentityProviderConfigurationFactory, T2, T3, InnerDomainIdentityCenterConfigurationFactory> WithIdentityCenterConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerDomainIdentityProviderConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.CloudWatch.DomainTypes.IdentityCenterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIdentityCenterConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDomainIdentityProviderConfigurationFactory, T3, InnerDomainIdentityCenterConfigurationFactory> WithIdentityCenterConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerDomainIdentityProviderConfigurationFactory, T3> combinedResult, Action<Humidifier.CloudWatch.DomainTypes.IdentityCenterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIdentityCenterConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerDomainIdentityProviderConfigurationFactory, InnerDomainIdentityCenterConfigurationFactory> WithIdentityCenterConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDomainIdentityProviderConfigurationFactory> combinedResult, Action<Humidifier.CloudWatch.DomainTypes.IdentityCenterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIdentityCenterConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerDomainIdentityProviderConfigurationFactory, T1, T2, T3, T4, InnerDomainIdentityCenterConfigurationFactory> WithIdentityCenterConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerDomainIdentityProviderConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CloudWatch.DomainTypes.IdentityCenterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdentityCenterConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDomainIdentityProviderConfigurationFactory, T2, T3, T4, InnerDomainIdentityCenterConfigurationFactory> WithIdentityCenterConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerDomainIdentityProviderConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.CloudWatch.DomainTypes.IdentityCenterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdentityCenterConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDomainIdentityProviderConfigurationFactory, T3, T4, InnerDomainIdentityCenterConfigurationFactory> WithIdentityCenterConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDomainIdentityProviderConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.CloudWatch.DomainTypes.IdentityCenterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdentityCenterConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerDomainIdentityProviderConfigurationFactory, T4, InnerDomainIdentityCenterConfigurationFactory> WithIdentityCenterConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDomainIdentityProviderConfigurationFactory, T4> combinedResult, Action<Humidifier.CloudWatch.DomainTypes.IdentityCenterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdentityCenterConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerDomainIdentityProviderConfigurationFactory, InnerDomainIdentityCenterConfigurationFactory> WithIdentityCenterConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDomainIdentityProviderConfigurationFactory> combinedResult, Action<Humidifier.CloudWatch.DomainTypes.IdentityCenterConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdentityCenterConfiguration(combinedResult.T5, subFactoryAction).T2);
}
