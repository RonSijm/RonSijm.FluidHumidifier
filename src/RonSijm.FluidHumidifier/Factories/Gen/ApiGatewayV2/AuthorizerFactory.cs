// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ApiGatewayV2;

public class AuthorizerFactory(string resourceName = null, Action<Humidifier.ApiGatewayV2.Authorizer> factoryAction = null) : ResourceFactory<Humidifier.ApiGatewayV2.Authorizer>(resourceName)
{

    internal InnerAuthorizerJWTConfigurationFactory JwtConfigurationFactory { get; set; }

    protected override Humidifier.ApiGatewayV2.Authorizer Create()
    {
        var authorizerResult = CreateAuthorizer();
        factoryAction?.Invoke(authorizerResult);

        return authorizerResult;
    }

    private Humidifier.ApiGatewayV2.Authorizer CreateAuthorizer()
    {
        var authorizerResult = new Humidifier.ApiGatewayV2.Authorizer
        {
            GivenName = InputResourceName,
        };

        return authorizerResult;
    }
    public override void CreateChildren(Humidifier.ApiGatewayV2.Authorizer result)
    {
        base.CreateChildren(result);

        result.JwtConfiguration ??= JwtConfigurationFactory?.Build();
    }

} // End Of Class

public static class AuthorizerFactoryExtensions
{
    public static CombinedResult<AuthorizerFactory, InnerAuthorizerJWTConfigurationFactory> WithJwtConfiguration(this AuthorizerFactory parentFactory, Action<Humidifier.ApiGatewayV2.AuthorizerTypes.JWTConfiguration> subFactoryAction = null)
    {
        parentFactory.JwtConfigurationFactory = new InnerAuthorizerJWTConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.JwtConfigurationFactory);
    }

    public static CombinedResult<AuthorizerFactory, T1, InnerAuthorizerJWTConfigurationFactory> WithJwtConfiguration<T1>(this CombinedResult<AuthorizerFactory, T1> combinedResult, Action<Humidifier.ApiGatewayV2.AuthorizerTypes.JWTConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithJwtConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AuthorizerFactory, InnerAuthorizerJWTConfigurationFactory> WithJwtConfiguration<T1>(this CombinedResult<T1, AuthorizerFactory> combinedResult, Action<Humidifier.ApiGatewayV2.AuthorizerTypes.JWTConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithJwtConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<AuthorizerFactory, T1, T2, InnerAuthorizerJWTConfigurationFactory> WithJwtConfiguration<T1, T2>(this CombinedResult<AuthorizerFactory, T1, T2> combinedResult, Action<Humidifier.ApiGatewayV2.AuthorizerTypes.JWTConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithJwtConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AuthorizerFactory, T2, InnerAuthorizerJWTConfigurationFactory> WithJwtConfiguration<T1, T2>(this CombinedResult<T1, AuthorizerFactory, T2> combinedResult, Action<Humidifier.ApiGatewayV2.AuthorizerTypes.JWTConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithJwtConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AuthorizerFactory, InnerAuthorizerJWTConfigurationFactory> WithJwtConfiguration<T1, T2>(this CombinedResult<T1, T2, AuthorizerFactory> combinedResult, Action<Humidifier.ApiGatewayV2.AuthorizerTypes.JWTConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithJwtConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<AuthorizerFactory, T1, T2, T3, InnerAuthorizerJWTConfigurationFactory> WithJwtConfiguration<T1, T2, T3>(this CombinedResult<AuthorizerFactory, T1, T2, T3> combinedResult, Action<Humidifier.ApiGatewayV2.AuthorizerTypes.JWTConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithJwtConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AuthorizerFactory, T2, T3, InnerAuthorizerJWTConfigurationFactory> WithJwtConfiguration<T1, T2, T3>(this CombinedResult<T1, AuthorizerFactory, T2, T3> combinedResult, Action<Humidifier.ApiGatewayV2.AuthorizerTypes.JWTConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithJwtConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AuthorizerFactory, T3, InnerAuthorizerJWTConfigurationFactory> WithJwtConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, AuthorizerFactory, T3> combinedResult, Action<Humidifier.ApiGatewayV2.AuthorizerTypes.JWTConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithJwtConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, AuthorizerFactory, InnerAuthorizerJWTConfigurationFactory> WithJwtConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, AuthorizerFactory> combinedResult, Action<Humidifier.ApiGatewayV2.AuthorizerTypes.JWTConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithJwtConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<AuthorizerFactory, T1, T2, T3, T4, InnerAuthorizerJWTConfigurationFactory> WithJwtConfiguration<T1, T2, T3, T4>(this CombinedResult<AuthorizerFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ApiGatewayV2.AuthorizerTypes.JWTConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithJwtConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AuthorizerFactory, T2, T3, T4, InnerAuthorizerJWTConfigurationFactory> WithJwtConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, AuthorizerFactory, T2, T3, T4> combinedResult, Action<Humidifier.ApiGatewayV2.AuthorizerTypes.JWTConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithJwtConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AuthorizerFactory, T3, T4, InnerAuthorizerJWTConfigurationFactory> WithJwtConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, AuthorizerFactory, T3, T4> combinedResult, Action<Humidifier.ApiGatewayV2.AuthorizerTypes.JWTConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithJwtConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, AuthorizerFactory, T4, InnerAuthorizerJWTConfigurationFactory> WithJwtConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, AuthorizerFactory, T4> combinedResult, Action<Humidifier.ApiGatewayV2.AuthorizerTypes.JWTConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithJwtConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, AuthorizerFactory, InnerAuthorizerJWTConfigurationFactory> WithJwtConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, AuthorizerFactory> combinedResult, Action<Humidifier.ApiGatewayV2.AuthorizerTypes.JWTConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithJwtConfiguration(combinedResult.T5, subFactoryAction));
}
