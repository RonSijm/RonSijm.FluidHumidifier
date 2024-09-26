// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ApiGateway;

public class DomainNameFactory(string resourceName = null, Action<Humidifier.ApiGateway.DomainName> factoryAction = null) : ResourceFactory<Humidifier.ApiGateway.DomainName>(resourceName)
{

    internal InnerDomainNameMutualTlsAuthenticationFactory MutualTlsAuthenticationFactory { get; set; }

    internal InnerDomainNameEndpointConfigurationFactory EndpointConfigurationFactory { get; set; }

    protected override Humidifier.ApiGateway.DomainName Create()
    {
        var domainNameResult = CreateDomainName();
        factoryAction?.Invoke(domainNameResult);

        return domainNameResult;
    }

    private Humidifier.ApiGateway.DomainName CreateDomainName()
    {
        var domainNameResult = new Humidifier.ApiGateway.DomainName
        {
            GivenName = InputResourceName,
        };

        return domainNameResult;
    }
    public override void CreateChildren(Humidifier.ApiGateway.DomainName result)
    {
        base.CreateChildren(result);

        result.MutualTlsAuthentication ??= MutualTlsAuthenticationFactory?.Build();
        result.EndpointConfiguration ??= EndpointConfigurationFactory?.Build();
    }

} // End Of Class

public static class DomainNameFactoryExtensions
{
    public static CombinedResult<DomainNameFactory, InnerDomainNameMutualTlsAuthenticationFactory> WithMutualTlsAuthentication(this DomainNameFactory parentFactory, Action<Humidifier.ApiGateway.DomainNameTypes.MutualTlsAuthentication> subFactoryAction = null)
    {
        parentFactory.MutualTlsAuthenticationFactory = new InnerDomainNameMutualTlsAuthenticationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.MutualTlsAuthenticationFactory);
    }

    public static CombinedResult<DomainNameFactory, InnerDomainNameEndpointConfigurationFactory> WithEndpointConfiguration(this DomainNameFactory parentFactory, Action<Humidifier.ApiGateway.DomainNameTypes.EndpointConfiguration> subFactoryAction = null)
    {
        parentFactory.EndpointConfigurationFactory = new InnerDomainNameEndpointConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EndpointConfigurationFactory);
    }

    public static CombinedResult<DomainNameFactory, T1, InnerDomainNameMutualTlsAuthenticationFactory> WithMutualTlsAuthentication<T1>(this CombinedResult<DomainNameFactory, T1> combinedResult, Action<Humidifier.ApiGateway.DomainNameTypes.MutualTlsAuthentication> subFactoryAction = null) => new (combinedResult, combinedResult, WithMutualTlsAuthentication(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DomainNameFactory, InnerDomainNameMutualTlsAuthenticationFactory> WithMutualTlsAuthentication<T1>(this CombinedResult<T1, DomainNameFactory> combinedResult, Action<Humidifier.ApiGateway.DomainNameTypes.MutualTlsAuthentication> subFactoryAction = null) => new (combinedResult, combinedResult, WithMutualTlsAuthentication(combinedResult.T2, subFactoryAction));
    public static CombinedResult<DomainNameFactory, T1, T2, InnerDomainNameMutualTlsAuthenticationFactory> WithMutualTlsAuthentication<T1, T2>(this CombinedResult<DomainNameFactory, T1, T2> combinedResult, Action<Humidifier.ApiGateway.DomainNameTypes.MutualTlsAuthentication> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMutualTlsAuthentication(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DomainNameFactory, T2, InnerDomainNameMutualTlsAuthenticationFactory> WithMutualTlsAuthentication<T1, T2>(this CombinedResult<T1, DomainNameFactory, T2> combinedResult, Action<Humidifier.ApiGateway.DomainNameTypes.MutualTlsAuthentication> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMutualTlsAuthentication(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DomainNameFactory, InnerDomainNameMutualTlsAuthenticationFactory> WithMutualTlsAuthentication<T1, T2>(this CombinedResult<T1, T2, DomainNameFactory> combinedResult, Action<Humidifier.ApiGateway.DomainNameTypes.MutualTlsAuthentication> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMutualTlsAuthentication(combinedResult.T3, subFactoryAction));
    public static CombinedResult<DomainNameFactory, T1, T2, T3, InnerDomainNameMutualTlsAuthenticationFactory> WithMutualTlsAuthentication<T1, T2, T3>(this CombinedResult<DomainNameFactory, T1, T2, T3> combinedResult, Action<Humidifier.ApiGateway.DomainNameTypes.MutualTlsAuthentication> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMutualTlsAuthentication(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DomainNameFactory, T2, T3, InnerDomainNameMutualTlsAuthenticationFactory> WithMutualTlsAuthentication<T1, T2, T3>(this CombinedResult<T1, DomainNameFactory, T2, T3> combinedResult, Action<Humidifier.ApiGateway.DomainNameTypes.MutualTlsAuthentication> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMutualTlsAuthentication(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DomainNameFactory, T3, InnerDomainNameMutualTlsAuthenticationFactory> WithMutualTlsAuthentication<T1, T2, T3>(this CombinedResult<T1, T2, DomainNameFactory, T3> combinedResult, Action<Humidifier.ApiGateway.DomainNameTypes.MutualTlsAuthentication> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMutualTlsAuthentication(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DomainNameFactory, InnerDomainNameMutualTlsAuthenticationFactory> WithMutualTlsAuthentication<T1, T2, T3>(this CombinedResult<T1, T2, T3, DomainNameFactory> combinedResult, Action<Humidifier.ApiGateway.DomainNameTypes.MutualTlsAuthentication> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMutualTlsAuthentication(combinedResult.T4, subFactoryAction));
    public static CombinedResult<DomainNameFactory, T1, T2, T3, T4, InnerDomainNameMutualTlsAuthenticationFactory> WithMutualTlsAuthentication<T1, T2, T3, T4>(this CombinedResult<DomainNameFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ApiGateway.DomainNameTypes.MutualTlsAuthentication> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMutualTlsAuthentication(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DomainNameFactory, T2, T3, T4, InnerDomainNameMutualTlsAuthenticationFactory> WithMutualTlsAuthentication<T1, T2, T3, T4>(this CombinedResult<T1, DomainNameFactory, T2, T3, T4> combinedResult, Action<Humidifier.ApiGateway.DomainNameTypes.MutualTlsAuthentication> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMutualTlsAuthentication(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DomainNameFactory, T3, T4, InnerDomainNameMutualTlsAuthenticationFactory> WithMutualTlsAuthentication<T1, T2, T3, T4>(this CombinedResult<T1, T2, DomainNameFactory, T3, T4> combinedResult, Action<Humidifier.ApiGateway.DomainNameTypes.MutualTlsAuthentication> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMutualTlsAuthentication(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DomainNameFactory, T4, InnerDomainNameMutualTlsAuthenticationFactory> WithMutualTlsAuthentication<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, DomainNameFactory, T4> combinedResult, Action<Humidifier.ApiGateway.DomainNameTypes.MutualTlsAuthentication> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMutualTlsAuthentication(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, DomainNameFactory, InnerDomainNameMutualTlsAuthenticationFactory> WithMutualTlsAuthentication<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, DomainNameFactory> combinedResult, Action<Humidifier.ApiGateway.DomainNameTypes.MutualTlsAuthentication> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMutualTlsAuthentication(combinedResult.T5, subFactoryAction));
    public static CombinedResult<DomainNameFactory, T1, InnerDomainNameEndpointConfigurationFactory> WithEndpointConfiguration<T1>(this CombinedResult<DomainNameFactory, T1> combinedResult, Action<Humidifier.ApiGateway.DomainNameTypes.EndpointConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithEndpointConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DomainNameFactory, InnerDomainNameEndpointConfigurationFactory> WithEndpointConfiguration<T1>(this CombinedResult<T1, DomainNameFactory> combinedResult, Action<Humidifier.ApiGateway.DomainNameTypes.EndpointConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithEndpointConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<DomainNameFactory, T1, T2, InnerDomainNameEndpointConfigurationFactory> WithEndpointConfiguration<T1, T2>(this CombinedResult<DomainNameFactory, T1, T2> combinedResult, Action<Humidifier.ApiGateway.DomainNameTypes.EndpointConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEndpointConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DomainNameFactory, T2, InnerDomainNameEndpointConfigurationFactory> WithEndpointConfiguration<T1, T2>(this CombinedResult<T1, DomainNameFactory, T2> combinedResult, Action<Humidifier.ApiGateway.DomainNameTypes.EndpointConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEndpointConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DomainNameFactory, InnerDomainNameEndpointConfigurationFactory> WithEndpointConfiguration<T1, T2>(this CombinedResult<T1, T2, DomainNameFactory> combinedResult, Action<Humidifier.ApiGateway.DomainNameTypes.EndpointConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEndpointConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<DomainNameFactory, T1, T2, T3, InnerDomainNameEndpointConfigurationFactory> WithEndpointConfiguration<T1, T2, T3>(this CombinedResult<DomainNameFactory, T1, T2, T3> combinedResult, Action<Humidifier.ApiGateway.DomainNameTypes.EndpointConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEndpointConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DomainNameFactory, T2, T3, InnerDomainNameEndpointConfigurationFactory> WithEndpointConfiguration<T1, T2, T3>(this CombinedResult<T1, DomainNameFactory, T2, T3> combinedResult, Action<Humidifier.ApiGateway.DomainNameTypes.EndpointConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEndpointConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DomainNameFactory, T3, InnerDomainNameEndpointConfigurationFactory> WithEndpointConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, DomainNameFactory, T3> combinedResult, Action<Humidifier.ApiGateway.DomainNameTypes.EndpointConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEndpointConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DomainNameFactory, InnerDomainNameEndpointConfigurationFactory> WithEndpointConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, DomainNameFactory> combinedResult, Action<Humidifier.ApiGateway.DomainNameTypes.EndpointConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEndpointConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<DomainNameFactory, T1, T2, T3, T4, InnerDomainNameEndpointConfigurationFactory> WithEndpointConfiguration<T1, T2, T3, T4>(this CombinedResult<DomainNameFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ApiGateway.DomainNameTypes.EndpointConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEndpointConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DomainNameFactory, T2, T3, T4, InnerDomainNameEndpointConfigurationFactory> WithEndpointConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, DomainNameFactory, T2, T3, T4> combinedResult, Action<Humidifier.ApiGateway.DomainNameTypes.EndpointConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEndpointConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DomainNameFactory, T3, T4, InnerDomainNameEndpointConfigurationFactory> WithEndpointConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, DomainNameFactory, T3, T4> combinedResult, Action<Humidifier.ApiGateway.DomainNameTypes.EndpointConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEndpointConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DomainNameFactory, T4, InnerDomainNameEndpointConfigurationFactory> WithEndpointConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, DomainNameFactory, T4> combinedResult, Action<Humidifier.ApiGateway.DomainNameTypes.EndpointConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEndpointConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, DomainNameFactory, InnerDomainNameEndpointConfigurationFactory> WithEndpointConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, DomainNameFactory> combinedResult, Action<Humidifier.ApiGateway.DomainNameTypes.EndpointConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEndpointConfiguration(combinedResult.T5, subFactoryAction));
}
