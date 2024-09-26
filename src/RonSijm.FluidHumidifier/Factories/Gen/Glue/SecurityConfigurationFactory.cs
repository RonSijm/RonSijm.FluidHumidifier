// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Glue;

public class SecurityConfigurationFactory(string resourceName = null, Action<Humidifier.Glue.SecurityConfiguration> factoryAction = null) : ResourceFactory<Humidifier.Glue.SecurityConfiguration>(resourceName)
{

    internal InnerSecurityConfigurationEncryptionConfigurationFactory EncryptionConfigurationFactory { get; set; }

    protected override Humidifier.Glue.SecurityConfiguration Create()
    {
        var securityConfigurationResult = CreateSecurityConfiguration();
        factoryAction?.Invoke(securityConfigurationResult);

        return securityConfigurationResult;
    }

    private Humidifier.Glue.SecurityConfiguration CreateSecurityConfiguration()
    {
        var securityConfigurationResult = new Humidifier.Glue.SecurityConfiguration
        {
            GivenName = InputResourceName,
        };

        return securityConfigurationResult;
    }
    public override void CreateChildren(Humidifier.Glue.SecurityConfiguration result)
    {
        base.CreateChildren(result);

        result.EncryptionConfiguration ??= EncryptionConfigurationFactory?.Build();
    }

} // End Of Class

public static class SecurityConfigurationFactoryExtensions
{
    public static CombinedResult<SecurityConfigurationFactory, InnerSecurityConfigurationEncryptionConfigurationFactory> WithEncryptionConfiguration(this SecurityConfigurationFactory parentFactory, Action<Humidifier.Glue.SecurityConfigurationTypes.EncryptionConfiguration> subFactoryAction = null)
    {
        parentFactory.EncryptionConfigurationFactory = new InnerSecurityConfigurationEncryptionConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EncryptionConfigurationFactory);
    }

    public static CombinedResult<SecurityConfigurationFactory, T1, InnerSecurityConfigurationEncryptionConfigurationFactory> WithEncryptionConfiguration<T1>(this CombinedResult<SecurityConfigurationFactory, T1> combinedResult, Action<Humidifier.Glue.SecurityConfigurationTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SecurityConfigurationFactory, InnerSecurityConfigurationEncryptionConfigurationFactory> WithEncryptionConfiguration<T1>(this CombinedResult<T1, SecurityConfigurationFactory> combinedResult, Action<Humidifier.Glue.SecurityConfigurationTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<SecurityConfigurationFactory, T1, T2, InnerSecurityConfigurationEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2>(this CombinedResult<SecurityConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.Glue.SecurityConfigurationTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SecurityConfigurationFactory, T2, InnerSecurityConfigurationEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2>(this CombinedResult<T1, SecurityConfigurationFactory, T2> combinedResult, Action<Humidifier.Glue.SecurityConfigurationTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SecurityConfigurationFactory, InnerSecurityConfigurationEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2>(this CombinedResult<T1, T2, SecurityConfigurationFactory> combinedResult, Action<Humidifier.Glue.SecurityConfigurationTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<SecurityConfigurationFactory, T1, T2, T3, InnerSecurityConfigurationEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3>(this CombinedResult<SecurityConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Glue.SecurityConfigurationTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SecurityConfigurationFactory, T2, T3, InnerSecurityConfigurationEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3>(this CombinedResult<T1, SecurityConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.Glue.SecurityConfigurationTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SecurityConfigurationFactory, T3, InnerSecurityConfigurationEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, SecurityConfigurationFactory, T3> combinedResult, Action<Humidifier.Glue.SecurityConfigurationTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, SecurityConfigurationFactory, InnerSecurityConfigurationEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, SecurityConfigurationFactory> combinedResult, Action<Humidifier.Glue.SecurityConfigurationTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<SecurityConfigurationFactory, T1, T2, T3, T4, InnerSecurityConfigurationEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3, T4>(this CombinedResult<SecurityConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Glue.SecurityConfigurationTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SecurityConfigurationFactory, T2, T3, T4, InnerSecurityConfigurationEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, SecurityConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Glue.SecurityConfigurationTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SecurityConfigurationFactory, T3, T4, InnerSecurityConfigurationEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, SecurityConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.Glue.SecurityConfigurationTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, SecurityConfigurationFactory, T4, InnerSecurityConfigurationEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, SecurityConfigurationFactory, T4> combinedResult, Action<Humidifier.Glue.SecurityConfigurationTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, SecurityConfigurationFactory, InnerSecurityConfigurationEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, SecurityConfigurationFactory> combinedResult, Action<Humidifier.Glue.SecurityConfigurationTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T5, subFactoryAction));
}
