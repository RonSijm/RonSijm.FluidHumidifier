// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.OpenSearchServerless;

public class SecurityConfigFactory(string resourceName = null, Action<Humidifier.OpenSearchServerless.SecurityConfig> factoryAction = null) : ResourceFactory<Humidifier.OpenSearchServerless.SecurityConfig>(resourceName)
{

    internal InnerSecurityConfigSamlConfigOptionsFactory SamlOptionsFactory { get; set; }

    protected override Humidifier.OpenSearchServerless.SecurityConfig Create()
    {
        var securityConfigResult = CreateSecurityConfig();
        factoryAction?.Invoke(securityConfigResult);

        return securityConfigResult;
    }

    private Humidifier.OpenSearchServerless.SecurityConfig CreateSecurityConfig()
    {
        var securityConfigResult = new Humidifier.OpenSearchServerless.SecurityConfig
        {
            GivenName = InputResourceName,
        };

        return securityConfigResult;
    }
    public override void CreateChildren(Humidifier.OpenSearchServerless.SecurityConfig result)
    {
        base.CreateChildren(result);

        result.SamlOptions ??= SamlOptionsFactory?.Build();
    }

} // End Of Class

public static class SecurityConfigFactoryExtensions
{
    public static CombinedResult<SecurityConfigFactory, InnerSecurityConfigSamlConfigOptionsFactory> WithSamlOptions(this SecurityConfigFactory parentFactory, Action<Humidifier.OpenSearchServerless.SecurityConfigTypes.SamlConfigOptions> subFactoryAction = null)
    {
        parentFactory.SamlOptionsFactory = new InnerSecurityConfigSamlConfigOptionsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SamlOptionsFactory);
    }

    public static CombinedResult<SecurityConfigFactory, T1, InnerSecurityConfigSamlConfigOptionsFactory> WithSamlOptions<T1>(this CombinedResult<SecurityConfigFactory, T1> combinedResult, Action<Humidifier.OpenSearchServerless.SecurityConfigTypes.SamlConfigOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithSamlOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SecurityConfigFactory, InnerSecurityConfigSamlConfigOptionsFactory> WithSamlOptions<T1>(this CombinedResult<T1, SecurityConfigFactory> combinedResult, Action<Humidifier.OpenSearchServerless.SecurityConfigTypes.SamlConfigOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithSamlOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<SecurityConfigFactory, T1, T2, InnerSecurityConfigSamlConfigOptionsFactory> WithSamlOptions<T1, T2>(this CombinedResult<SecurityConfigFactory, T1, T2> combinedResult, Action<Humidifier.OpenSearchServerless.SecurityConfigTypes.SamlConfigOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSamlOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SecurityConfigFactory, T2, InnerSecurityConfigSamlConfigOptionsFactory> WithSamlOptions<T1, T2>(this CombinedResult<T1, SecurityConfigFactory, T2> combinedResult, Action<Humidifier.OpenSearchServerless.SecurityConfigTypes.SamlConfigOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSamlOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SecurityConfigFactory, InnerSecurityConfigSamlConfigOptionsFactory> WithSamlOptions<T1, T2>(this CombinedResult<T1, T2, SecurityConfigFactory> combinedResult, Action<Humidifier.OpenSearchServerless.SecurityConfigTypes.SamlConfigOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSamlOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<SecurityConfigFactory, T1, T2, T3, InnerSecurityConfigSamlConfigOptionsFactory> WithSamlOptions<T1, T2, T3>(this CombinedResult<SecurityConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.OpenSearchServerless.SecurityConfigTypes.SamlConfigOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSamlOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SecurityConfigFactory, T2, T3, InnerSecurityConfigSamlConfigOptionsFactory> WithSamlOptions<T1, T2, T3>(this CombinedResult<T1, SecurityConfigFactory, T2, T3> combinedResult, Action<Humidifier.OpenSearchServerless.SecurityConfigTypes.SamlConfigOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSamlOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SecurityConfigFactory, T3, InnerSecurityConfigSamlConfigOptionsFactory> WithSamlOptions<T1, T2, T3>(this CombinedResult<T1, T2, SecurityConfigFactory, T3> combinedResult, Action<Humidifier.OpenSearchServerless.SecurityConfigTypes.SamlConfigOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSamlOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, SecurityConfigFactory, InnerSecurityConfigSamlConfigOptionsFactory> WithSamlOptions<T1, T2, T3>(this CombinedResult<T1, T2, T3, SecurityConfigFactory> combinedResult, Action<Humidifier.OpenSearchServerless.SecurityConfigTypes.SamlConfigOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSamlOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<SecurityConfigFactory, T1, T2, T3, T4, InnerSecurityConfigSamlConfigOptionsFactory> WithSamlOptions<T1, T2, T3, T4>(this CombinedResult<SecurityConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.OpenSearchServerless.SecurityConfigTypes.SamlConfigOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSamlOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SecurityConfigFactory, T2, T3, T4, InnerSecurityConfigSamlConfigOptionsFactory> WithSamlOptions<T1, T2, T3, T4>(this CombinedResult<T1, SecurityConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.OpenSearchServerless.SecurityConfigTypes.SamlConfigOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSamlOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SecurityConfigFactory, T3, T4, InnerSecurityConfigSamlConfigOptionsFactory> WithSamlOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, SecurityConfigFactory, T3, T4> combinedResult, Action<Humidifier.OpenSearchServerless.SecurityConfigTypes.SamlConfigOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSamlOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, SecurityConfigFactory, T4, InnerSecurityConfigSamlConfigOptionsFactory> WithSamlOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, SecurityConfigFactory, T4> combinedResult, Action<Humidifier.OpenSearchServerless.SecurityConfigTypes.SamlConfigOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSamlOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, SecurityConfigFactory, InnerSecurityConfigSamlConfigOptionsFactory> WithSamlOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, SecurityConfigFactory> combinedResult, Action<Humidifier.OpenSearchServerless.SecurityConfigTypes.SamlConfigOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSamlOptions(combinedResult.T5, subFactoryAction));
}
