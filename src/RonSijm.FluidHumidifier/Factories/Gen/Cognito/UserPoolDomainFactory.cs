// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Cognito;

public class UserPoolDomainFactory(string resourceName = null, Action<Humidifier.Cognito.UserPoolDomain> factoryAction = null) : ResourceFactory<Humidifier.Cognito.UserPoolDomain>(resourceName)
{

    internal InnerUserPoolDomainCustomDomainConfigTypeFactory CustomDomainConfigFactory { get; set; }

    protected override Humidifier.Cognito.UserPoolDomain Create()
    {
        var userPoolDomainResult = CreateUserPoolDomain();
        factoryAction?.Invoke(userPoolDomainResult);

        return userPoolDomainResult;
    }

    private Humidifier.Cognito.UserPoolDomain CreateUserPoolDomain()
    {
        var userPoolDomainResult = new Humidifier.Cognito.UserPoolDomain
        {
            GivenName = InputResourceName,
        };

        return userPoolDomainResult;
    }
    public override void CreateChildren(Humidifier.Cognito.UserPoolDomain result)
    {
        base.CreateChildren(result);

        result.CustomDomainConfig ??= CustomDomainConfigFactory?.Build();
    }

} // End Of Class

public static class UserPoolDomainFactoryExtensions
{
    public static CombinedResult<UserPoolDomainFactory, InnerUserPoolDomainCustomDomainConfigTypeFactory> WithCustomDomainConfig(this UserPoolDomainFactory parentFactory, Action<Humidifier.Cognito.UserPoolDomainTypes.CustomDomainConfigType> subFactoryAction = null)
    {
        parentFactory.CustomDomainConfigFactory = new InnerUserPoolDomainCustomDomainConfigTypeFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CustomDomainConfigFactory);
    }

    public static CombinedResult<UserPoolDomainFactory, T1, InnerUserPoolDomainCustomDomainConfigTypeFactory> WithCustomDomainConfig<T1>(this CombinedResult<UserPoolDomainFactory, T1> combinedResult, Action<Humidifier.Cognito.UserPoolDomainTypes.CustomDomainConfigType> subFactoryAction = null) => new (combinedResult, combinedResult, WithCustomDomainConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, UserPoolDomainFactory, InnerUserPoolDomainCustomDomainConfigTypeFactory> WithCustomDomainConfig<T1>(this CombinedResult<T1, UserPoolDomainFactory> combinedResult, Action<Humidifier.Cognito.UserPoolDomainTypes.CustomDomainConfigType> subFactoryAction = null) => new (combinedResult, combinedResult, WithCustomDomainConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<UserPoolDomainFactory, T1, T2, InnerUserPoolDomainCustomDomainConfigTypeFactory> WithCustomDomainConfig<T1, T2>(this CombinedResult<UserPoolDomainFactory, T1, T2> combinedResult, Action<Humidifier.Cognito.UserPoolDomainTypes.CustomDomainConfigType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCustomDomainConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, UserPoolDomainFactory, T2, InnerUserPoolDomainCustomDomainConfigTypeFactory> WithCustomDomainConfig<T1, T2>(this CombinedResult<T1, UserPoolDomainFactory, T2> combinedResult, Action<Humidifier.Cognito.UserPoolDomainTypes.CustomDomainConfigType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCustomDomainConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, UserPoolDomainFactory, InnerUserPoolDomainCustomDomainConfigTypeFactory> WithCustomDomainConfig<T1, T2>(this CombinedResult<T1, T2, UserPoolDomainFactory> combinedResult, Action<Humidifier.Cognito.UserPoolDomainTypes.CustomDomainConfigType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCustomDomainConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<UserPoolDomainFactory, T1, T2, T3, InnerUserPoolDomainCustomDomainConfigTypeFactory> WithCustomDomainConfig<T1, T2, T3>(this CombinedResult<UserPoolDomainFactory, T1, T2, T3> combinedResult, Action<Humidifier.Cognito.UserPoolDomainTypes.CustomDomainConfigType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomDomainConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, UserPoolDomainFactory, T2, T3, InnerUserPoolDomainCustomDomainConfigTypeFactory> WithCustomDomainConfig<T1, T2, T3>(this CombinedResult<T1, UserPoolDomainFactory, T2, T3> combinedResult, Action<Humidifier.Cognito.UserPoolDomainTypes.CustomDomainConfigType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomDomainConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, UserPoolDomainFactory, T3, InnerUserPoolDomainCustomDomainConfigTypeFactory> WithCustomDomainConfig<T1, T2, T3>(this CombinedResult<T1, T2, UserPoolDomainFactory, T3> combinedResult, Action<Humidifier.Cognito.UserPoolDomainTypes.CustomDomainConfigType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomDomainConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, UserPoolDomainFactory, InnerUserPoolDomainCustomDomainConfigTypeFactory> WithCustomDomainConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, UserPoolDomainFactory> combinedResult, Action<Humidifier.Cognito.UserPoolDomainTypes.CustomDomainConfigType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomDomainConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<UserPoolDomainFactory, T1, T2, T3, T4, InnerUserPoolDomainCustomDomainConfigTypeFactory> WithCustomDomainConfig<T1, T2, T3, T4>(this CombinedResult<UserPoolDomainFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Cognito.UserPoolDomainTypes.CustomDomainConfigType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomDomainConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, UserPoolDomainFactory, T2, T3, T4, InnerUserPoolDomainCustomDomainConfigTypeFactory> WithCustomDomainConfig<T1, T2, T3, T4>(this CombinedResult<T1, UserPoolDomainFactory, T2, T3, T4> combinedResult, Action<Humidifier.Cognito.UserPoolDomainTypes.CustomDomainConfigType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomDomainConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, UserPoolDomainFactory, T3, T4, InnerUserPoolDomainCustomDomainConfigTypeFactory> WithCustomDomainConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, UserPoolDomainFactory, T3, T4> combinedResult, Action<Humidifier.Cognito.UserPoolDomainTypes.CustomDomainConfigType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomDomainConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, UserPoolDomainFactory, T4, InnerUserPoolDomainCustomDomainConfigTypeFactory> WithCustomDomainConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, UserPoolDomainFactory, T4> combinedResult, Action<Humidifier.Cognito.UserPoolDomainTypes.CustomDomainConfigType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomDomainConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, UserPoolDomainFactory, InnerUserPoolDomainCustomDomainConfigTypeFactory> WithCustomDomainConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, UserPoolDomainFactory> combinedResult, Action<Humidifier.Cognito.UserPoolDomainTypes.CustomDomainConfigType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomDomainConfig(combinedResult.T5, subFactoryAction));
}
