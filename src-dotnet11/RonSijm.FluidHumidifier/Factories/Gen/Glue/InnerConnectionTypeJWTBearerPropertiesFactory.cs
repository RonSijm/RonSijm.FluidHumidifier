// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Glue;

public class InnerConnectionTypeJWTBearerPropertiesFactory(Action<Humidifier.Glue.ConnectionTypeTypes.JWTBearerProperties> factoryAction = null) : SubResourceFactory<Humidifier.Glue.ConnectionTypeTypes.JWTBearerProperties>
{

    internal InnerConnectionTypeSecretConnectorPropertyFactory JwtTokenFactory { get; set; }

    internal InnerConnectionTypeConnectorPropertyFactory TokenUrlFactory { get; set; }

    protected override Humidifier.Glue.ConnectionTypeTypes.JWTBearerProperties Create()
    {
        var jWTBearerPropertiesResult = CreateJWTBearerProperties();
        factoryAction?.Invoke(jWTBearerPropertiesResult);

        return jWTBearerPropertiesResult;
    }

    private Humidifier.Glue.ConnectionTypeTypes.JWTBearerProperties CreateJWTBearerProperties()
    {
        var jWTBearerPropertiesResult = new Humidifier.Glue.ConnectionTypeTypes.JWTBearerProperties();

        return jWTBearerPropertiesResult;
    }
    public override void CreateChildren(Humidifier.Glue.ConnectionTypeTypes.JWTBearerProperties result)
    {
        base.CreateChildren(result);

        result.JwtToken ??= JwtTokenFactory?.Build();
        result.TokenUrl ??= TokenUrlFactory?.Build();
    }

} // End Of Class

public static class InnerConnectionTypeJWTBearerPropertiesFactoryExtensions
{
    public static CombinedResult<InnerConnectionTypeJWTBearerPropertiesFactory, InnerConnectionTypeSecretConnectorPropertyFactory> WithJwtToken(this InnerConnectionTypeJWTBearerPropertiesFactory parentFactory, Action<Humidifier.Glue.ConnectionTypeTypes.SecretConnectorProperty> subFactoryAction = null)
    {
        parentFactory.JwtTokenFactory = new InnerConnectionTypeSecretConnectorPropertyFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.JwtTokenFactory);
    }

    public static CombinedResult<InnerConnectionTypeJWTBearerPropertiesFactory, InnerConnectionTypeConnectorPropertyFactory> WithTokenUrl(this InnerConnectionTypeJWTBearerPropertiesFactory parentFactory, Action<Humidifier.Glue.ConnectionTypeTypes.ConnectorProperty> subFactoryAction = null)
    {
        parentFactory.TokenUrlFactory = new InnerConnectionTypeConnectorPropertyFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.TokenUrlFactory);
    }

    public static CombinedResult<InnerConnectionTypeJWTBearerPropertiesFactory, T1, InnerConnectionTypeSecretConnectorPropertyFactory> WithJwtToken<T1>(this CombinedResult<InnerConnectionTypeJWTBearerPropertiesFactory, T1> combinedResult, Action<Humidifier.Glue.ConnectionTypeTypes.SecretConnectorProperty> subFactoryAction = null) => new (combinedResult, combinedResult, WithJwtToken(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerConnectionTypeJWTBearerPropertiesFactory, InnerConnectionTypeSecretConnectorPropertyFactory> WithJwtToken<T1>(this CombinedResult<T1, InnerConnectionTypeJWTBearerPropertiesFactory> combinedResult, Action<Humidifier.Glue.ConnectionTypeTypes.SecretConnectorProperty> subFactoryAction = null) => new (combinedResult, combinedResult, WithJwtToken(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerConnectionTypeJWTBearerPropertiesFactory, T1, T2, InnerConnectionTypeSecretConnectorPropertyFactory> WithJwtToken<T1, T2>(this CombinedResult<InnerConnectionTypeJWTBearerPropertiesFactory, T1, T2> combinedResult, Action<Humidifier.Glue.ConnectionTypeTypes.SecretConnectorProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithJwtToken(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerConnectionTypeJWTBearerPropertiesFactory, T2, InnerConnectionTypeSecretConnectorPropertyFactory> WithJwtToken<T1, T2>(this CombinedResult<T1, InnerConnectionTypeJWTBearerPropertiesFactory, T2> combinedResult, Action<Humidifier.Glue.ConnectionTypeTypes.SecretConnectorProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithJwtToken(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerConnectionTypeJWTBearerPropertiesFactory, InnerConnectionTypeSecretConnectorPropertyFactory> WithJwtToken<T1, T2>(this CombinedResult<T1, T2, InnerConnectionTypeJWTBearerPropertiesFactory> combinedResult, Action<Humidifier.Glue.ConnectionTypeTypes.SecretConnectorProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithJwtToken(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerConnectionTypeJWTBearerPropertiesFactory, T1, T2, T3, InnerConnectionTypeSecretConnectorPropertyFactory> WithJwtToken<T1, T2, T3>(this CombinedResult<InnerConnectionTypeJWTBearerPropertiesFactory, T1, T2, T3> combinedResult, Action<Humidifier.Glue.ConnectionTypeTypes.SecretConnectorProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithJwtToken(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerConnectionTypeJWTBearerPropertiesFactory, T2, T3, InnerConnectionTypeSecretConnectorPropertyFactory> WithJwtToken<T1, T2, T3>(this CombinedResult<T1, InnerConnectionTypeJWTBearerPropertiesFactory, T2, T3> combinedResult, Action<Humidifier.Glue.ConnectionTypeTypes.SecretConnectorProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithJwtToken(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerConnectionTypeJWTBearerPropertiesFactory, T3, InnerConnectionTypeSecretConnectorPropertyFactory> WithJwtToken<T1, T2, T3>(this CombinedResult<T1, T2, InnerConnectionTypeJWTBearerPropertiesFactory, T3> combinedResult, Action<Humidifier.Glue.ConnectionTypeTypes.SecretConnectorProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithJwtToken(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerConnectionTypeJWTBearerPropertiesFactory, InnerConnectionTypeSecretConnectorPropertyFactory> WithJwtToken<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerConnectionTypeJWTBearerPropertiesFactory> combinedResult, Action<Humidifier.Glue.ConnectionTypeTypes.SecretConnectorProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithJwtToken(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerConnectionTypeJWTBearerPropertiesFactory, T1, T2, T3, T4, InnerConnectionTypeSecretConnectorPropertyFactory> WithJwtToken<T1, T2, T3, T4>(this CombinedResult<InnerConnectionTypeJWTBearerPropertiesFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Glue.ConnectionTypeTypes.SecretConnectorProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithJwtToken(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerConnectionTypeJWTBearerPropertiesFactory, T2, T3, T4, InnerConnectionTypeSecretConnectorPropertyFactory> WithJwtToken<T1, T2, T3, T4>(this CombinedResult<T1, InnerConnectionTypeJWTBearerPropertiesFactory, T2, T3, T4> combinedResult, Action<Humidifier.Glue.ConnectionTypeTypes.SecretConnectorProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithJwtToken(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerConnectionTypeJWTBearerPropertiesFactory, T3, T4, InnerConnectionTypeSecretConnectorPropertyFactory> WithJwtToken<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerConnectionTypeJWTBearerPropertiesFactory, T3, T4> combinedResult, Action<Humidifier.Glue.ConnectionTypeTypes.SecretConnectorProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithJwtToken(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerConnectionTypeJWTBearerPropertiesFactory, T4, InnerConnectionTypeSecretConnectorPropertyFactory> WithJwtToken<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerConnectionTypeJWTBearerPropertiesFactory, T4> combinedResult, Action<Humidifier.Glue.ConnectionTypeTypes.SecretConnectorProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithJwtToken(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerConnectionTypeJWTBearerPropertiesFactory, InnerConnectionTypeSecretConnectorPropertyFactory> WithJwtToken<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerConnectionTypeJWTBearerPropertiesFactory> combinedResult, Action<Humidifier.Glue.ConnectionTypeTypes.SecretConnectorProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithJwtToken(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<InnerConnectionTypeJWTBearerPropertiesFactory, T1, InnerConnectionTypeConnectorPropertyFactory> WithTokenUrl<T1>(this CombinedResult<InnerConnectionTypeJWTBearerPropertiesFactory, T1> combinedResult, Action<Humidifier.Glue.ConnectionTypeTypes.ConnectorProperty> subFactoryAction = null) => new (combinedResult, combinedResult, WithTokenUrl(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerConnectionTypeJWTBearerPropertiesFactory, InnerConnectionTypeConnectorPropertyFactory> WithTokenUrl<T1>(this CombinedResult<T1, InnerConnectionTypeJWTBearerPropertiesFactory> combinedResult, Action<Humidifier.Glue.ConnectionTypeTypes.ConnectorProperty> subFactoryAction = null) => new (combinedResult, combinedResult, WithTokenUrl(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerConnectionTypeJWTBearerPropertiesFactory, T1, T2, InnerConnectionTypeConnectorPropertyFactory> WithTokenUrl<T1, T2>(this CombinedResult<InnerConnectionTypeJWTBearerPropertiesFactory, T1, T2> combinedResult, Action<Humidifier.Glue.ConnectionTypeTypes.ConnectorProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTokenUrl(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerConnectionTypeJWTBearerPropertiesFactory, T2, InnerConnectionTypeConnectorPropertyFactory> WithTokenUrl<T1, T2>(this CombinedResult<T1, InnerConnectionTypeJWTBearerPropertiesFactory, T2> combinedResult, Action<Humidifier.Glue.ConnectionTypeTypes.ConnectorProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTokenUrl(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerConnectionTypeJWTBearerPropertiesFactory, InnerConnectionTypeConnectorPropertyFactory> WithTokenUrl<T1, T2>(this CombinedResult<T1, T2, InnerConnectionTypeJWTBearerPropertiesFactory> combinedResult, Action<Humidifier.Glue.ConnectionTypeTypes.ConnectorProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTokenUrl(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerConnectionTypeJWTBearerPropertiesFactory, T1, T2, T3, InnerConnectionTypeConnectorPropertyFactory> WithTokenUrl<T1, T2, T3>(this CombinedResult<InnerConnectionTypeJWTBearerPropertiesFactory, T1, T2, T3> combinedResult, Action<Humidifier.Glue.ConnectionTypeTypes.ConnectorProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTokenUrl(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerConnectionTypeJWTBearerPropertiesFactory, T2, T3, InnerConnectionTypeConnectorPropertyFactory> WithTokenUrl<T1, T2, T3>(this CombinedResult<T1, InnerConnectionTypeJWTBearerPropertiesFactory, T2, T3> combinedResult, Action<Humidifier.Glue.ConnectionTypeTypes.ConnectorProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTokenUrl(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerConnectionTypeJWTBearerPropertiesFactory, T3, InnerConnectionTypeConnectorPropertyFactory> WithTokenUrl<T1, T2, T3>(this CombinedResult<T1, T2, InnerConnectionTypeJWTBearerPropertiesFactory, T3> combinedResult, Action<Humidifier.Glue.ConnectionTypeTypes.ConnectorProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTokenUrl(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerConnectionTypeJWTBearerPropertiesFactory, InnerConnectionTypeConnectorPropertyFactory> WithTokenUrl<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerConnectionTypeJWTBearerPropertiesFactory> combinedResult, Action<Humidifier.Glue.ConnectionTypeTypes.ConnectorProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTokenUrl(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerConnectionTypeJWTBearerPropertiesFactory, T1, T2, T3, T4, InnerConnectionTypeConnectorPropertyFactory> WithTokenUrl<T1, T2, T3, T4>(this CombinedResult<InnerConnectionTypeJWTBearerPropertiesFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Glue.ConnectionTypeTypes.ConnectorProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTokenUrl(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerConnectionTypeJWTBearerPropertiesFactory, T2, T3, T4, InnerConnectionTypeConnectorPropertyFactory> WithTokenUrl<T1, T2, T3, T4>(this CombinedResult<T1, InnerConnectionTypeJWTBearerPropertiesFactory, T2, T3, T4> combinedResult, Action<Humidifier.Glue.ConnectionTypeTypes.ConnectorProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTokenUrl(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerConnectionTypeJWTBearerPropertiesFactory, T3, T4, InnerConnectionTypeConnectorPropertyFactory> WithTokenUrl<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerConnectionTypeJWTBearerPropertiesFactory, T3, T4> combinedResult, Action<Humidifier.Glue.ConnectionTypeTypes.ConnectorProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTokenUrl(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerConnectionTypeJWTBearerPropertiesFactory, T4, InnerConnectionTypeConnectorPropertyFactory> WithTokenUrl<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerConnectionTypeJWTBearerPropertiesFactory, T4> combinedResult, Action<Humidifier.Glue.ConnectionTypeTypes.ConnectorProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTokenUrl(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerConnectionTypeJWTBearerPropertiesFactory, InnerConnectionTypeConnectorPropertyFactory> WithTokenUrl<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerConnectionTypeJWTBearerPropertiesFactory> combinedResult, Action<Humidifier.Glue.ConnectionTypeTypes.ConnectorProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTokenUrl(combinedResult.T5, subFactoryAction).T2);
}
