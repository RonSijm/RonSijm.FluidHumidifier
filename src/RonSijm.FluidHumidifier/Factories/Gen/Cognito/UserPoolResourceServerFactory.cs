// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Cognito;

public class UserPoolResourceServerFactory(string resourceName = null, Action<Humidifier.Cognito.UserPoolResourceServer> factoryAction = null) : ResourceFactory<Humidifier.Cognito.UserPoolResourceServer>(resourceName)
{

    internal List<InnerUserPoolResourceServerResourceServerScopeTypeFactory> ScopesFactories { get; set; } = [];

    protected override Humidifier.Cognito.UserPoolResourceServer Create()
    {
        var userPoolResourceServerResult = CreateUserPoolResourceServer();
        factoryAction?.Invoke(userPoolResourceServerResult);

        return userPoolResourceServerResult;
    }

    private Humidifier.Cognito.UserPoolResourceServer CreateUserPoolResourceServer()
    {
        var userPoolResourceServerResult = new Humidifier.Cognito.UserPoolResourceServer
        {
            GivenName = InputResourceName,
        };

        return userPoolResourceServerResult;
    }
    public override void CreateChildren(Humidifier.Cognito.UserPoolResourceServer result)
    {
        base.CreateChildren(result);

        result.Scopes = ScopesFactories.Any() ? ScopesFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class UserPoolResourceServerFactoryExtensions
{
    public static CombinedResult<UserPoolResourceServerFactory, InnerUserPoolResourceServerResourceServerScopeTypeFactory> WithScopes(this UserPoolResourceServerFactory parentFactory, Action<Humidifier.Cognito.UserPoolResourceServerTypes.ResourceServerScopeType> subFactoryAction = null)
    {
        var factory = new InnerUserPoolResourceServerResourceServerScopeTypeFactory(subFactoryAction);
        parentFactory.ScopesFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<UserPoolResourceServerFactory, T1, InnerUserPoolResourceServerResourceServerScopeTypeFactory> WithScopes<T1>(this CombinedResult<UserPoolResourceServerFactory, T1> combinedResult, Action<Humidifier.Cognito.UserPoolResourceServerTypes.ResourceServerScopeType> subFactoryAction = null) => new (combinedResult, combinedResult, WithScopes(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, UserPoolResourceServerFactory, InnerUserPoolResourceServerResourceServerScopeTypeFactory> WithScopes<T1>(this CombinedResult<T1, UserPoolResourceServerFactory> combinedResult, Action<Humidifier.Cognito.UserPoolResourceServerTypes.ResourceServerScopeType> subFactoryAction = null) => new (combinedResult, combinedResult, WithScopes(combinedResult.T2, subFactoryAction));
    public static CombinedResult<UserPoolResourceServerFactory, T1, T2, InnerUserPoolResourceServerResourceServerScopeTypeFactory> WithScopes<T1, T2>(this CombinedResult<UserPoolResourceServerFactory, T1, T2> combinedResult, Action<Humidifier.Cognito.UserPoolResourceServerTypes.ResourceServerScopeType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScopes(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, UserPoolResourceServerFactory, T2, InnerUserPoolResourceServerResourceServerScopeTypeFactory> WithScopes<T1, T2>(this CombinedResult<T1, UserPoolResourceServerFactory, T2> combinedResult, Action<Humidifier.Cognito.UserPoolResourceServerTypes.ResourceServerScopeType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScopes(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, UserPoolResourceServerFactory, InnerUserPoolResourceServerResourceServerScopeTypeFactory> WithScopes<T1, T2>(this CombinedResult<T1, T2, UserPoolResourceServerFactory> combinedResult, Action<Humidifier.Cognito.UserPoolResourceServerTypes.ResourceServerScopeType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScopes(combinedResult.T3, subFactoryAction));
    public static CombinedResult<UserPoolResourceServerFactory, T1, T2, T3, InnerUserPoolResourceServerResourceServerScopeTypeFactory> WithScopes<T1, T2, T3>(this CombinedResult<UserPoolResourceServerFactory, T1, T2, T3> combinedResult, Action<Humidifier.Cognito.UserPoolResourceServerTypes.ResourceServerScopeType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScopes(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, UserPoolResourceServerFactory, T2, T3, InnerUserPoolResourceServerResourceServerScopeTypeFactory> WithScopes<T1, T2, T3>(this CombinedResult<T1, UserPoolResourceServerFactory, T2, T3> combinedResult, Action<Humidifier.Cognito.UserPoolResourceServerTypes.ResourceServerScopeType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScopes(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, UserPoolResourceServerFactory, T3, InnerUserPoolResourceServerResourceServerScopeTypeFactory> WithScopes<T1, T2, T3>(this CombinedResult<T1, T2, UserPoolResourceServerFactory, T3> combinedResult, Action<Humidifier.Cognito.UserPoolResourceServerTypes.ResourceServerScopeType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScopes(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, UserPoolResourceServerFactory, InnerUserPoolResourceServerResourceServerScopeTypeFactory> WithScopes<T1, T2, T3>(this CombinedResult<T1, T2, T3, UserPoolResourceServerFactory> combinedResult, Action<Humidifier.Cognito.UserPoolResourceServerTypes.ResourceServerScopeType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScopes(combinedResult.T4, subFactoryAction));
    public static CombinedResult<UserPoolResourceServerFactory, T1, T2, T3, T4, InnerUserPoolResourceServerResourceServerScopeTypeFactory> WithScopes<T1, T2, T3, T4>(this CombinedResult<UserPoolResourceServerFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Cognito.UserPoolResourceServerTypes.ResourceServerScopeType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScopes(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, UserPoolResourceServerFactory, T2, T3, T4, InnerUserPoolResourceServerResourceServerScopeTypeFactory> WithScopes<T1, T2, T3, T4>(this CombinedResult<T1, UserPoolResourceServerFactory, T2, T3, T4> combinedResult, Action<Humidifier.Cognito.UserPoolResourceServerTypes.ResourceServerScopeType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScopes(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, UserPoolResourceServerFactory, T3, T4, InnerUserPoolResourceServerResourceServerScopeTypeFactory> WithScopes<T1, T2, T3, T4>(this CombinedResult<T1, T2, UserPoolResourceServerFactory, T3, T4> combinedResult, Action<Humidifier.Cognito.UserPoolResourceServerTypes.ResourceServerScopeType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScopes(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, UserPoolResourceServerFactory, T4, InnerUserPoolResourceServerResourceServerScopeTypeFactory> WithScopes<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, UserPoolResourceServerFactory, T4> combinedResult, Action<Humidifier.Cognito.UserPoolResourceServerTypes.ResourceServerScopeType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScopes(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, UserPoolResourceServerFactory, InnerUserPoolResourceServerResourceServerScopeTypeFactory> WithScopes<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, UserPoolResourceServerFactory> combinedResult, Action<Humidifier.Cognito.UserPoolResourceServerTypes.ResourceServerScopeType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScopes(combinedResult.T5, subFactoryAction));
}
