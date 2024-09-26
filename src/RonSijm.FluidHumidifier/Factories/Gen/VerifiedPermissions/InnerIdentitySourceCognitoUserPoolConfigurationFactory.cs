// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.VerifiedPermissions;

public class InnerIdentitySourceCognitoUserPoolConfigurationFactory(Action<Humidifier.VerifiedPermissions.IdentitySourceTypes.CognitoUserPoolConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.VerifiedPermissions.IdentitySourceTypes.CognitoUserPoolConfiguration>
{

    internal InnerIdentitySourceCognitoGroupConfigurationFactory GroupConfigurationFactory { get; set; }

    protected override Humidifier.VerifiedPermissions.IdentitySourceTypes.CognitoUserPoolConfiguration Create()
    {
        var cognitoUserPoolConfigurationResult = CreateCognitoUserPoolConfiguration();
        factoryAction?.Invoke(cognitoUserPoolConfigurationResult);

        return cognitoUserPoolConfigurationResult;
    }

    private Humidifier.VerifiedPermissions.IdentitySourceTypes.CognitoUserPoolConfiguration CreateCognitoUserPoolConfiguration()
    {
        var cognitoUserPoolConfigurationResult = new Humidifier.VerifiedPermissions.IdentitySourceTypes.CognitoUserPoolConfiguration();

        return cognitoUserPoolConfigurationResult;
    }
    public override void CreateChildren(Humidifier.VerifiedPermissions.IdentitySourceTypes.CognitoUserPoolConfiguration result)
    {
        base.CreateChildren(result);

        result.GroupConfiguration ??= GroupConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerIdentitySourceCognitoUserPoolConfigurationFactoryExtensions
{
    public static CombinedResult<InnerIdentitySourceCognitoUserPoolConfigurationFactory, InnerIdentitySourceCognitoGroupConfigurationFactory> WithGroupConfiguration(this InnerIdentitySourceCognitoUserPoolConfigurationFactory parentFactory, Action<Humidifier.VerifiedPermissions.IdentitySourceTypes.CognitoGroupConfiguration> subFactoryAction = null)
    {
        parentFactory.GroupConfigurationFactory = new InnerIdentitySourceCognitoGroupConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.GroupConfigurationFactory);
    }

    public static CombinedResult<InnerIdentitySourceCognitoUserPoolConfigurationFactory, T1, InnerIdentitySourceCognitoGroupConfigurationFactory> WithGroupConfiguration<T1>(this CombinedResult<InnerIdentitySourceCognitoUserPoolConfigurationFactory, T1> combinedResult, Action<Humidifier.VerifiedPermissions.IdentitySourceTypes.CognitoGroupConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithGroupConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerIdentitySourceCognitoUserPoolConfigurationFactory, InnerIdentitySourceCognitoGroupConfigurationFactory> WithGroupConfiguration<T1>(this CombinedResult<T1, InnerIdentitySourceCognitoUserPoolConfigurationFactory> combinedResult, Action<Humidifier.VerifiedPermissions.IdentitySourceTypes.CognitoGroupConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithGroupConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerIdentitySourceCognitoUserPoolConfigurationFactory, T1, T2, InnerIdentitySourceCognitoGroupConfigurationFactory> WithGroupConfiguration<T1, T2>(this CombinedResult<InnerIdentitySourceCognitoUserPoolConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.VerifiedPermissions.IdentitySourceTypes.CognitoGroupConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGroupConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerIdentitySourceCognitoUserPoolConfigurationFactory, T2, InnerIdentitySourceCognitoGroupConfigurationFactory> WithGroupConfiguration<T1, T2>(this CombinedResult<T1, InnerIdentitySourceCognitoUserPoolConfigurationFactory, T2> combinedResult, Action<Humidifier.VerifiedPermissions.IdentitySourceTypes.CognitoGroupConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGroupConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerIdentitySourceCognitoUserPoolConfigurationFactory, InnerIdentitySourceCognitoGroupConfigurationFactory> WithGroupConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerIdentitySourceCognitoUserPoolConfigurationFactory> combinedResult, Action<Humidifier.VerifiedPermissions.IdentitySourceTypes.CognitoGroupConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGroupConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerIdentitySourceCognitoUserPoolConfigurationFactory, T1, T2, T3, InnerIdentitySourceCognitoGroupConfigurationFactory> WithGroupConfiguration<T1, T2, T3>(this CombinedResult<InnerIdentitySourceCognitoUserPoolConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.VerifiedPermissions.IdentitySourceTypes.CognitoGroupConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGroupConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerIdentitySourceCognitoUserPoolConfigurationFactory, T2, T3, InnerIdentitySourceCognitoGroupConfigurationFactory> WithGroupConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerIdentitySourceCognitoUserPoolConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.VerifiedPermissions.IdentitySourceTypes.CognitoGroupConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGroupConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerIdentitySourceCognitoUserPoolConfigurationFactory, T3, InnerIdentitySourceCognitoGroupConfigurationFactory> WithGroupConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerIdentitySourceCognitoUserPoolConfigurationFactory, T3> combinedResult, Action<Humidifier.VerifiedPermissions.IdentitySourceTypes.CognitoGroupConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGroupConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerIdentitySourceCognitoUserPoolConfigurationFactory, InnerIdentitySourceCognitoGroupConfigurationFactory> WithGroupConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerIdentitySourceCognitoUserPoolConfigurationFactory> combinedResult, Action<Humidifier.VerifiedPermissions.IdentitySourceTypes.CognitoGroupConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGroupConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerIdentitySourceCognitoUserPoolConfigurationFactory, T1, T2, T3, T4, InnerIdentitySourceCognitoGroupConfigurationFactory> WithGroupConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerIdentitySourceCognitoUserPoolConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.VerifiedPermissions.IdentitySourceTypes.CognitoGroupConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGroupConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerIdentitySourceCognitoUserPoolConfigurationFactory, T2, T3, T4, InnerIdentitySourceCognitoGroupConfigurationFactory> WithGroupConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerIdentitySourceCognitoUserPoolConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.VerifiedPermissions.IdentitySourceTypes.CognitoGroupConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGroupConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerIdentitySourceCognitoUserPoolConfigurationFactory, T3, T4, InnerIdentitySourceCognitoGroupConfigurationFactory> WithGroupConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerIdentitySourceCognitoUserPoolConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.VerifiedPermissions.IdentitySourceTypes.CognitoGroupConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGroupConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerIdentitySourceCognitoUserPoolConfigurationFactory, T4, InnerIdentitySourceCognitoGroupConfigurationFactory> WithGroupConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerIdentitySourceCognitoUserPoolConfigurationFactory, T4> combinedResult, Action<Humidifier.VerifiedPermissions.IdentitySourceTypes.CognitoGroupConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGroupConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerIdentitySourceCognitoUserPoolConfigurationFactory, InnerIdentitySourceCognitoGroupConfigurationFactory> WithGroupConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerIdentitySourceCognitoUserPoolConfigurationFactory> combinedResult, Action<Humidifier.VerifiedPermissions.IdentitySourceTypes.CognitoGroupConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGroupConfiguration(combinedResult.T5, subFactoryAction));
}
