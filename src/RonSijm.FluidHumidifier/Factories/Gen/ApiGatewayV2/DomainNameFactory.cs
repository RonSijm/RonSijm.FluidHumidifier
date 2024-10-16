// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ApiGatewayV2;

public class DomainNameFactory(string resourceName = null, Action<Humidifier.ApiGatewayV2.DomainName> factoryAction = null) : ResourceFactory<Humidifier.ApiGatewayV2.DomainName>(resourceName)
{

    internal List<InnerDomainNameDomainNameConfigurationFactory> DomainNameConfigurationsFactories { get; set; } = [];

    internal InnerDomainNameMutualTlsAuthenticationFactory MutualTlsAuthenticationFactory { get; set; }

    protected override Humidifier.ApiGatewayV2.DomainName Create()
    {
        var domainNameResult = CreateDomainName();
        factoryAction?.Invoke(domainNameResult);

        return domainNameResult;
    }

    private Humidifier.ApiGatewayV2.DomainName CreateDomainName()
    {
        var domainNameResult = new Humidifier.ApiGatewayV2.DomainName
        {
            GivenName = InputResourceName,
        };

        return domainNameResult;
    }
    public override void CreateChildren(Humidifier.ApiGatewayV2.DomainName result)
    {
        base.CreateChildren(result);

        result.DomainNameConfigurations = DomainNameConfigurationsFactories.Any() ? DomainNameConfigurationsFactories.Select(x => x.Build()).ToList() : null;
        result.MutualTlsAuthentication ??= MutualTlsAuthenticationFactory?.Build();
    }

} // End Of Class

public static class DomainNameFactoryExtensions
{
    public static CombinedResult<DomainNameFactory, InnerDomainNameDomainNameConfigurationFactory> WithDomainNameConfigurations(this DomainNameFactory parentFactory, Action<Humidifier.ApiGatewayV2.DomainNameTypes.DomainNameConfiguration> subFactoryAction = null)
    {
        var factory = new InnerDomainNameDomainNameConfigurationFactory(subFactoryAction);
        parentFactory.DomainNameConfigurationsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<DomainNameFactory, InnerDomainNameMutualTlsAuthenticationFactory> WithMutualTlsAuthentication(this DomainNameFactory parentFactory, Action<Humidifier.ApiGatewayV2.DomainNameTypes.MutualTlsAuthentication> subFactoryAction = null)
    {
        parentFactory.MutualTlsAuthenticationFactory = new InnerDomainNameMutualTlsAuthenticationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.MutualTlsAuthenticationFactory);
    }

    public static CombinedResult<DomainNameFactory, T1, InnerDomainNameDomainNameConfigurationFactory> WithDomainNameConfigurations<T1>(this CombinedResult<DomainNameFactory, T1> combinedResult, Action<Humidifier.ApiGatewayV2.DomainNameTypes.DomainNameConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithDomainNameConfigurations(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DomainNameFactory, InnerDomainNameDomainNameConfigurationFactory> WithDomainNameConfigurations<T1>(this CombinedResult<T1, DomainNameFactory> combinedResult, Action<Humidifier.ApiGatewayV2.DomainNameTypes.DomainNameConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithDomainNameConfigurations(combinedResult.T2, subFactoryAction));
    public static CombinedResult<DomainNameFactory, T1, T2, InnerDomainNameDomainNameConfigurationFactory> WithDomainNameConfigurations<T1, T2>(this CombinedResult<DomainNameFactory, T1, T2> combinedResult, Action<Humidifier.ApiGatewayV2.DomainNameTypes.DomainNameConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDomainNameConfigurations(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DomainNameFactory, T2, InnerDomainNameDomainNameConfigurationFactory> WithDomainNameConfigurations<T1, T2>(this CombinedResult<T1, DomainNameFactory, T2> combinedResult, Action<Humidifier.ApiGatewayV2.DomainNameTypes.DomainNameConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDomainNameConfigurations(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DomainNameFactory, InnerDomainNameDomainNameConfigurationFactory> WithDomainNameConfigurations<T1, T2>(this CombinedResult<T1, T2, DomainNameFactory> combinedResult, Action<Humidifier.ApiGatewayV2.DomainNameTypes.DomainNameConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDomainNameConfigurations(combinedResult.T3, subFactoryAction));
    public static CombinedResult<DomainNameFactory, T1, T2, T3, InnerDomainNameDomainNameConfigurationFactory> WithDomainNameConfigurations<T1, T2, T3>(this CombinedResult<DomainNameFactory, T1, T2, T3> combinedResult, Action<Humidifier.ApiGatewayV2.DomainNameTypes.DomainNameConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDomainNameConfigurations(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DomainNameFactory, T2, T3, InnerDomainNameDomainNameConfigurationFactory> WithDomainNameConfigurations<T1, T2, T3>(this CombinedResult<T1, DomainNameFactory, T2, T3> combinedResult, Action<Humidifier.ApiGatewayV2.DomainNameTypes.DomainNameConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDomainNameConfigurations(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DomainNameFactory, T3, InnerDomainNameDomainNameConfigurationFactory> WithDomainNameConfigurations<T1, T2, T3>(this CombinedResult<T1, T2, DomainNameFactory, T3> combinedResult, Action<Humidifier.ApiGatewayV2.DomainNameTypes.DomainNameConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDomainNameConfigurations(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DomainNameFactory, InnerDomainNameDomainNameConfigurationFactory> WithDomainNameConfigurations<T1, T2, T3>(this CombinedResult<T1, T2, T3, DomainNameFactory> combinedResult, Action<Humidifier.ApiGatewayV2.DomainNameTypes.DomainNameConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDomainNameConfigurations(combinedResult.T4, subFactoryAction));
    public static CombinedResult<DomainNameFactory, T1, T2, T3, T4, InnerDomainNameDomainNameConfigurationFactory> WithDomainNameConfigurations<T1, T2, T3, T4>(this CombinedResult<DomainNameFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ApiGatewayV2.DomainNameTypes.DomainNameConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDomainNameConfigurations(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DomainNameFactory, T2, T3, T4, InnerDomainNameDomainNameConfigurationFactory> WithDomainNameConfigurations<T1, T2, T3, T4>(this CombinedResult<T1, DomainNameFactory, T2, T3, T4> combinedResult, Action<Humidifier.ApiGatewayV2.DomainNameTypes.DomainNameConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDomainNameConfigurations(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DomainNameFactory, T3, T4, InnerDomainNameDomainNameConfigurationFactory> WithDomainNameConfigurations<T1, T2, T3, T4>(this CombinedResult<T1, T2, DomainNameFactory, T3, T4> combinedResult, Action<Humidifier.ApiGatewayV2.DomainNameTypes.DomainNameConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDomainNameConfigurations(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DomainNameFactory, T4, InnerDomainNameDomainNameConfigurationFactory> WithDomainNameConfigurations<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, DomainNameFactory, T4> combinedResult, Action<Humidifier.ApiGatewayV2.DomainNameTypes.DomainNameConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDomainNameConfigurations(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, DomainNameFactory, InnerDomainNameDomainNameConfigurationFactory> WithDomainNameConfigurations<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, DomainNameFactory> combinedResult, Action<Humidifier.ApiGatewayV2.DomainNameTypes.DomainNameConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDomainNameConfigurations(combinedResult.T5, subFactoryAction));
    public static CombinedResult<DomainNameFactory, T1, InnerDomainNameMutualTlsAuthenticationFactory> WithMutualTlsAuthentication<T1>(this CombinedResult<DomainNameFactory, T1> combinedResult, Action<Humidifier.ApiGatewayV2.DomainNameTypes.MutualTlsAuthentication> subFactoryAction = null) => new (combinedResult, combinedResult, WithMutualTlsAuthentication(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DomainNameFactory, InnerDomainNameMutualTlsAuthenticationFactory> WithMutualTlsAuthentication<T1>(this CombinedResult<T1, DomainNameFactory> combinedResult, Action<Humidifier.ApiGatewayV2.DomainNameTypes.MutualTlsAuthentication> subFactoryAction = null) => new (combinedResult, combinedResult, WithMutualTlsAuthentication(combinedResult.T2, subFactoryAction));
    public static CombinedResult<DomainNameFactory, T1, T2, InnerDomainNameMutualTlsAuthenticationFactory> WithMutualTlsAuthentication<T1, T2>(this CombinedResult<DomainNameFactory, T1, T2> combinedResult, Action<Humidifier.ApiGatewayV2.DomainNameTypes.MutualTlsAuthentication> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMutualTlsAuthentication(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DomainNameFactory, T2, InnerDomainNameMutualTlsAuthenticationFactory> WithMutualTlsAuthentication<T1, T2>(this CombinedResult<T1, DomainNameFactory, T2> combinedResult, Action<Humidifier.ApiGatewayV2.DomainNameTypes.MutualTlsAuthentication> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMutualTlsAuthentication(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DomainNameFactory, InnerDomainNameMutualTlsAuthenticationFactory> WithMutualTlsAuthentication<T1, T2>(this CombinedResult<T1, T2, DomainNameFactory> combinedResult, Action<Humidifier.ApiGatewayV2.DomainNameTypes.MutualTlsAuthentication> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMutualTlsAuthentication(combinedResult.T3, subFactoryAction));
    public static CombinedResult<DomainNameFactory, T1, T2, T3, InnerDomainNameMutualTlsAuthenticationFactory> WithMutualTlsAuthentication<T1, T2, T3>(this CombinedResult<DomainNameFactory, T1, T2, T3> combinedResult, Action<Humidifier.ApiGatewayV2.DomainNameTypes.MutualTlsAuthentication> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMutualTlsAuthentication(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DomainNameFactory, T2, T3, InnerDomainNameMutualTlsAuthenticationFactory> WithMutualTlsAuthentication<T1, T2, T3>(this CombinedResult<T1, DomainNameFactory, T2, T3> combinedResult, Action<Humidifier.ApiGatewayV2.DomainNameTypes.MutualTlsAuthentication> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMutualTlsAuthentication(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DomainNameFactory, T3, InnerDomainNameMutualTlsAuthenticationFactory> WithMutualTlsAuthentication<T1, T2, T3>(this CombinedResult<T1, T2, DomainNameFactory, T3> combinedResult, Action<Humidifier.ApiGatewayV2.DomainNameTypes.MutualTlsAuthentication> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMutualTlsAuthentication(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DomainNameFactory, InnerDomainNameMutualTlsAuthenticationFactory> WithMutualTlsAuthentication<T1, T2, T3>(this CombinedResult<T1, T2, T3, DomainNameFactory> combinedResult, Action<Humidifier.ApiGatewayV2.DomainNameTypes.MutualTlsAuthentication> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMutualTlsAuthentication(combinedResult.T4, subFactoryAction));
    public static CombinedResult<DomainNameFactory, T1, T2, T3, T4, InnerDomainNameMutualTlsAuthenticationFactory> WithMutualTlsAuthentication<T1, T2, T3, T4>(this CombinedResult<DomainNameFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ApiGatewayV2.DomainNameTypes.MutualTlsAuthentication> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMutualTlsAuthentication(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DomainNameFactory, T2, T3, T4, InnerDomainNameMutualTlsAuthenticationFactory> WithMutualTlsAuthentication<T1, T2, T3, T4>(this CombinedResult<T1, DomainNameFactory, T2, T3, T4> combinedResult, Action<Humidifier.ApiGatewayV2.DomainNameTypes.MutualTlsAuthentication> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMutualTlsAuthentication(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DomainNameFactory, T3, T4, InnerDomainNameMutualTlsAuthenticationFactory> WithMutualTlsAuthentication<T1, T2, T3, T4>(this CombinedResult<T1, T2, DomainNameFactory, T3, T4> combinedResult, Action<Humidifier.ApiGatewayV2.DomainNameTypes.MutualTlsAuthentication> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMutualTlsAuthentication(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DomainNameFactory, T4, InnerDomainNameMutualTlsAuthenticationFactory> WithMutualTlsAuthentication<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, DomainNameFactory, T4> combinedResult, Action<Humidifier.ApiGatewayV2.DomainNameTypes.MutualTlsAuthentication> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMutualTlsAuthentication(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, DomainNameFactory, InnerDomainNameMutualTlsAuthenticationFactory> WithMutualTlsAuthentication<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, DomainNameFactory> combinedResult, Action<Humidifier.ApiGatewayV2.DomainNameTypes.MutualTlsAuthentication> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMutualTlsAuthentication(combinedResult.T5, subFactoryAction));
}
