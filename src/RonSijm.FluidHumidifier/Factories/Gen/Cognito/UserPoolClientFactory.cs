// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Cognito;

public class UserPoolClientFactory(string resourceName = null, Action<Humidifier.Cognito.UserPoolClient> factoryAction = null) : ResourceFactory<Humidifier.Cognito.UserPoolClient>(resourceName)
{

    internal InnerUserPoolClientAnalyticsConfigurationFactory AnalyticsConfigurationFactory { get; set; }

    internal InnerUserPoolClientTokenValidityUnitsFactory TokenValidityUnitsFactory { get; set; }

    protected override Humidifier.Cognito.UserPoolClient Create()
    {
        var userPoolClientResult = CreateUserPoolClient();
        factoryAction?.Invoke(userPoolClientResult);

        return userPoolClientResult;
    }

    private Humidifier.Cognito.UserPoolClient CreateUserPoolClient()
    {
        var userPoolClientResult = new Humidifier.Cognito.UserPoolClient
        {
            GivenName = InputResourceName,
        };

        return userPoolClientResult;
    }
    public override void CreateChildren(Humidifier.Cognito.UserPoolClient result)
    {
        base.CreateChildren(result);

        result.AnalyticsConfiguration ??= AnalyticsConfigurationFactory?.Build();
        result.TokenValidityUnits ??= TokenValidityUnitsFactory?.Build();
    }

} // End Of Class

public static class UserPoolClientFactoryExtensions
{
    public static CombinedResult<UserPoolClientFactory, InnerUserPoolClientAnalyticsConfigurationFactory> WithAnalyticsConfiguration(this UserPoolClientFactory parentFactory, Action<Humidifier.Cognito.UserPoolClientTypes.AnalyticsConfiguration> subFactoryAction = null)
    {
        parentFactory.AnalyticsConfigurationFactory = new InnerUserPoolClientAnalyticsConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AnalyticsConfigurationFactory);
    }

    public static CombinedResult<UserPoolClientFactory, InnerUserPoolClientTokenValidityUnitsFactory> WithTokenValidityUnits(this UserPoolClientFactory parentFactory, Action<Humidifier.Cognito.UserPoolClientTypes.TokenValidityUnits> subFactoryAction = null)
    {
        parentFactory.TokenValidityUnitsFactory = new InnerUserPoolClientTokenValidityUnitsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.TokenValidityUnitsFactory);
    }

    public static CombinedResult<UserPoolClientFactory, T1, InnerUserPoolClientAnalyticsConfigurationFactory> WithAnalyticsConfiguration<T1>(this CombinedResult<UserPoolClientFactory, T1> combinedResult, Action<Humidifier.Cognito.UserPoolClientTypes.AnalyticsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithAnalyticsConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, UserPoolClientFactory, InnerUserPoolClientAnalyticsConfigurationFactory> WithAnalyticsConfiguration<T1>(this CombinedResult<T1, UserPoolClientFactory> combinedResult, Action<Humidifier.Cognito.UserPoolClientTypes.AnalyticsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithAnalyticsConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<UserPoolClientFactory, T1, T2, InnerUserPoolClientAnalyticsConfigurationFactory> WithAnalyticsConfiguration<T1, T2>(this CombinedResult<UserPoolClientFactory, T1, T2> combinedResult, Action<Humidifier.Cognito.UserPoolClientTypes.AnalyticsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAnalyticsConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, UserPoolClientFactory, T2, InnerUserPoolClientAnalyticsConfigurationFactory> WithAnalyticsConfiguration<T1, T2>(this CombinedResult<T1, UserPoolClientFactory, T2> combinedResult, Action<Humidifier.Cognito.UserPoolClientTypes.AnalyticsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAnalyticsConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, UserPoolClientFactory, InnerUserPoolClientAnalyticsConfigurationFactory> WithAnalyticsConfiguration<T1, T2>(this CombinedResult<T1, T2, UserPoolClientFactory> combinedResult, Action<Humidifier.Cognito.UserPoolClientTypes.AnalyticsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAnalyticsConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<UserPoolClientFactory, T1, T2, T3, InnerUserPoolClientAnalyticsConfigurationFactory> WithAnalyticsConfiguration<T1, T2, T3>(this CombinedResult<UserPoolClientFactory, T1, T2, T3> combinedResult, Action<Humidifier.Cognito.UserPoolClientTypes.AnalyticsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAnalyticsConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, UserPoolClientFactory, T2, T3, InnerUserPoolClientAnalyticsConfigurationFactory> WithAnalyticsConfiguration<T1, T2, T3>(this CombinedResult<T1, UserPoolClientFactory, T2, T3> combinedResult, Action<Humidifier.Cognito.UserPoolClientTypes.AnalyticsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAnalyticsConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, UserPoolClientFactory, T3, InnerUserPoolClientAnalyticsConfigurationFactory> WithAnalyticsConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, UserPoolClientFactory, T3> combinedResult, Action<Humidifier.Cognito.UserPoolClientTypes.AnalyticsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAnalyticsConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, UserPoolClientFactory, InnerUserPoolClientAnalyticsConfigurationFactory> WithAnalyticsConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, UserPoolClientFactory> combinedResult, Action<Humidifier.Cognito.UserPoolClientTypes.AnalyticsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAnalyticsConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<UserPoolClientFactory, T1, T2, T3, T4, InnerUserPoolClientAnalyticsConfigurationFactory> WithAnalyticsConfiguration<T1, T2, T3, T4>(this CombinedResult<UserPoolClientFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Cognito.UserPoolClientTypes.AnalyticsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAnalyticsConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, UserPoolClientFactory, T2, T3, T4, InnerUserPoolClientAnalyticsConfigurationFactory> WithAnalyticsConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, UserPoolClientFactory, T2, T3, T4> combinedResult, Action<Humidifier.Cognito.UserPoolClientTypes.AnalyticsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAnalyticsConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, UserPoolClientFactory, T3, T4, InnerUserPoolClientAnalyticsConfigurationFactory> WithAnalyticsConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, UserPoolClientFactory, T3, T4> combinedResult, Action<Humidifier.Cognito.UserPoolClientTypes.AnalyticsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAnalyticsConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, UserPoolClientFactory, T4, InnerUserPoolClientAnalyticsConfigurationFactory> WithAnalyticsConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, UserPoolClientFactory, T4> combinedResult, Action<Humidifier.Cognito.UserPoolClientTypes.AnalyticsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAnalyticsConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, UserPoolClientFactory, InnerUserPoolClientAnalyticsConfigurationFactory> WithAnalyticsConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, UserPoolClientFactory> combinedResult, Action<Humidifier.Cognito.UserPoolClientTypes.AnalyticsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAnalyticsConfiguration(combinedResult.T5, subFactoryAction));
    public static CombinedResult<UserPoolClientFactory, T1, InnerUserPoolClientTokenValidityUnitsFactory> WithTokenValidityUnits<T1>(this CombinedResult<UserPoolClientFactory, T1> combinedResult, Action<Humidifier.Cognito.UserPoolClientTypes.TokenValidityUnits> subFactoryAction = null) => new (combinedResult, combinedResult, WithTokenValidityUnits(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, UserPoolClientFactory, InnerUserPoolClientTokenValidityUnitsFactory> WithTokenValidityUnits<T1>(this CombinedResult<T1, UserPoolClientFactory> combinedResult, Action<Humidifier.Cognito.UserPoolClientTypes.TokenValidityUnits> subFactoryAction = null) => new (combinedResult, combinedResult, WithTokenValidityUnits(combinedResult.T2, subFactoryAction));
    public static CombinedResult<UserPoolClientFactory, T1, T2, InnerUserPoolClientTokenValidityUnitsFactory> WithTokenValidityUnits<T1, T2>(this CombinedResult<UserPoolClientFactory, T1, T2> combinedResult, Action<Humidifier.Cognito.UserPoolClientTypes.TokenValidityUnits> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTokenValidityUnits(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, UserPoolClientFactory, T2, InnerUserPoolClientTokenValidityUnitsFactory> WithTokenValidityUnits<T1, T2>(this CombinedResult<T1, UserPoolClientFactory, T2> combinedResult, Action<Humidifier.Cognito.UserPoolClientTypes.TokenValidityUnits> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTokenValidityUnits(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, UserPoolClientFactory, InnerUserPoolClientTokenValidityUnitsFactory> WithTokenValidityUnits<T1, T2>(this CombinedResult<T1, T2, UserPoolClientFactory> combinedResult, Action<Humidifier.Cognito.UserPoolClientTypes.TokenValidityUnits> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTokenValidityUnits(combinedResult.T3, subFactoryAction));
    public static CombinedResult<UserPoolClientFactory, T1, T2, T3, InnerUserPoolClientTokenValidityUnitsFactory> WithTokenValidityUnits<T1, T2, T3>(this CombinedResult<UserPoolClientFactory, T1, T2, T3> combinedResult, Action<Humidifier.Cognito.UserPoolClientTypes.TokenValidityUnits> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTokenValidityUnits(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, UserPoolClientFactory, T2, T3, InnerUserPoolClientTokenValidityUnitsFactory> WithTokenValidityUnits<T1, T2, T3>(this CombinedResult<T1, UserPoolClientFactory, T2, T3> combinedResult, Action<Humidifier.Cognito.UserPoolClientTypes.TokenValidityUnits> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTokenValidityUnits(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, UserPoolClientFactory, T3, InnerUserPoolClientTokenValidityUnitsFactory> WithTokenValidityUnits<T1, T2, T3>(this CombinedResult<T1, T2, UserPoolClientFactory, T3> combinedResult, Action<Humidifier.Cognito.UserPoolClientTypes.TokenValidityUnits> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTokenValidityUnits(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, UserPoolClientFactory, InnerUserPoolClientTokenValidityUnitsFactory> WithTokenValidityUnits<T1, T2, T3>(this CombinedResult<T1, T2, T3, UserPoolClientFactory> combinedResult, Action<Humidifier.Cognito.UserPoolClientTypes.TokenValidityUnits> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTokenValidityUnits(combinedResult.T4, subFactoryAction));
    public static CombinedResult<UserPoolClientFactory, T1, T2, T3, T4, InnerUserPoolClientTokenValidityUnitsFactory> WithTokenValidityUnits<T1, T2, T3, T4>(this CombinedResult<UserPoolClientFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Cognito.UserPoolClientTypes.TokenValidityUnits> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTokenValidityUnits(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, UserPoolClientFactory, T2, T3, T4, InnerUserPoolClientTokenValidityUnitsFactory> WithTokenValidityUnits<T1, T2, T3, T4>(this CombinedResult<T1, UserPoolClientFactory, T2, T3, T4> combinedResult, Action<Humidifier.Cognito.UserPoolClientTypes.TokenValidityUnits> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTokenValidityUnits(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, UserPoolClientFactory, T3, T4, InnerUserPoolClientTokenValidityUnitsFactory> WithTokenValidityUnits<T1, T2, T3, T4>(this CombinedResult<T1, T2, UserPoolClientFactory, T3, T4> combinedResult, Action<Humidifier.Cognito.UserPoolClientTypes.TokenValidityUnits> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTokenValidityUnits(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, UserPoolClientFactory, T4, InnerUserPoolClientTokenValidityUnitsFactory> WithTokenValidityUnits<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, UserPoolClientFactory, T4> combinedResult, Action<Humidifier.Cognito.UserPoolClientTypes.TokenValidityUnits> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTokenValidityUnits(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, UserPoolClientFactory, InnerUserPoolClientTokenValidityUnitsFactory> WithTokenValidityUnits<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, UserPoolClientFactory> combinedResult, Action<Humidifier.Cognito.UserPoolClientTypes.TokenValidityUnits> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTokenValidityUnits(combinedResult.T5, subFactoryAction));
}
