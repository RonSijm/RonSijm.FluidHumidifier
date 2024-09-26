// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ApiGateway;

public class RestApiFactory(string resourceName = null, Action<Humidifier.ApiGateway.RestApi> factoryAction = null) : ResourceFactory<Humidifier.ApiGateway.RestApi>(resourceName)
{

    internal InnerRestApiS3LocationFactory BodyS3LocationFactory { get; set; }

    internal InnerRestApiEndpointConfigurationFactory EndpointConfigurationFactory { get; set; }

    protected override Humidifier.ApiGateway.RestApi Create()
    {
        var restApiResult = CreateRestApi();
        factoryAction?.Invoke(restApiResult);

        return restApiResult;
    }

    private Humidifier.ApiGateway.RestApi CreateRestApi()
    {
        var restApiResult = new Humidifier.ApiGateway.RestApi
        {
            GivenName = InputResourceName,
        };

        return restApiResult;
    }
    public override void CreateChildren(Humidifier.ApiGateway.RestApi result)
    {
        base.CreateChildren(result);

        result.BodyS3Location ??= BodyS3LocationFactory?.Build();
        result.EndpointConfiguration ??= EndpointConfigurationFactory?.Build();
    }

} // End Of Class

public static class RestApiFactoryExtensions
{
    public static CombinedResult<RestApiFactory, InnerRestApiS3LocationFactory> WithBodyS3Location(this RestApiFactory parentFactory, Action<Humidifier.ApiGateway.RestApiTypes.S3Location> subFactoryAction = null)
    {
        parentFactory.BodyS3LocationFactory = new InnerRestApiS3LocationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.BodyS3LocationFactory);
    }

    public static CombinedResult<RestApiFactory, InnerRestApiEndpointConfigurationFactory> WithEndpointConfiguration(this RestApiFactory parentFactory, Action<Humidifier.ApiGateway.RestApiTypes.EndpointConfiguration> subFactoryAction = null)
    {
        parentFactory.EndpointConfigurationFactory = new InnerRestApiEndpointConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EndpointConfigurationFactory);
    }

    public static CombinedResult<RestApiFactory, T1, InnerRestApiS3LocationFactory> WithBodyS3Location<T1>(this CombinedResult<RestApiFactory, T1> combinedResult, Action<Humidifier.ApiGateway.RestApiTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, WithBodyS3Location(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RestApiFactory, InnerRestApiS3LocationFactory> WithBodyS3Location<T1>(this CombinedResult<T1, RestApiFactory> combinedResult, Action<Humidifier.ApiGateway.RestApiTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, WithBodyS3Location(combinedResult.T2, subFactoryAction));
    public static CombinedResult<RestApiFactory, T1, T2, InnerRestApiS3LocationFactory> WithBodyS3Location<T1, T2>(this CombinedResult<RestApiFactory, T1, T2> combinedResult, Action<Humidifier.ApiGateway.RestApiTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBodyS3Location(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RestApiFactory, T2, InnerRestApiS3LocationFactory> WithBodyS3Location<T1, T2>(this CombinedResult<T1, RestApiFactory, T2> combinedResult, Action<Humidifier.ApiGateway.RestApiTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBodyS3Location(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, RestApiFactory, InnerRestApiS3LocationFactory> WithBodyS3Location<T1, T2>(this CombinedResult<T1, T2, RestApiFactory> combinedResult, Action<Humidifier.ApiGateway.RestApiTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBodyS3Location(combinedResult.T3, subFactoryAction));
    public static CombinedResult<RestApiFactory, T1, T2, T3, InnerRestApiS3LocationFactory> WithBodyS3Location<T1, T2, T3>(this CombinedResult<RestApiFactory, T1, T2, T3> combinedResult, Action<Humidifier.ApiGateway.RestApiTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBodyS3Location(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RestApiFactory, T2, T3, InnerRestApiS3LocationFactory> WithBodyS3Location<T1, T2, T3>(this CombinedResult<T1, RestApiFactory, T2, T3> combinedResult, Action<Humidifier.ApiGateway.RestApiTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBodyS3Location(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, RestApiFactory, T3, InnerRestApiS3LocationFactory> WithBodyS3Location<T1, T2, T3>(this CombinedResult<T1, T2, RestApiFactory, T3> combinedResult, Action<Humidifier.ApiGateway.RestApiTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBodyS3Location(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, RestApiFactory, InnerRestApiS3LocationFactory> WithBodyS3Location<T1, T2, T3>(this CombinedResult<T1, T2, T3, RestApiFactory> combinedResult, Action<Humidifier.ApiGateway.RestApiTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBodyS3Location(combinedResult.T4, subFactoryAction));
    public static CombinedResult<RestApiFactory, T1, T2, T3, T4, InnerRestApiS3LocationFactory> WithBodyS3Location<T1, T2, T3, T4>(this CombinedResult<RestApiFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ApiGateway.RestApiTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBodyS3Location(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RestApiFactory, T2, T3, T4, InnerRestApiS3LocationFactory> WithBodyS3Location<T1, T2, T3, T4>(this CombinedResult<T1, RestApiFactory, T2, T3, T4> combinedResult, Action<Humidifier.ApiGateway.RestApiTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBodyS3Location(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, RestApiFactory, T3, T4, InnerRestApiS3LocationFactory> WithBodyS3Location<T1, T2, T3, T4>(this CombinedResult<T1, T2, RestApiFactory, T3, T4> combinedResult, Action<Humidifier.ApiGateway.RestApiTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBodyS3Location(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, RestApiFactory, T4, InnerRestApiS3LocationFactory> WithBodyS3Location<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, RestApiFactory, T4> combinedResult, Action<Humidifier.ApiGateway.RestApiTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBodyS3Location(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, RestApiFactory, InnerRestApiS3LocationFactory> WithBodyS3Location<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, RestApiFactory> combinedResult, Action<Humidifier.ApiGateway.RestApiTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBodyS3Location(combinedResult.T5, subFactoryAction));
    public static CombinedResult<RestApiFactory, T1, InnerRestApiEndpointConfigurationFactory> WithEndpointConfiguration<T1>(this CombinedResult<RestApiFactory, T1> combinedResult, Action<Humidifier.ApiGateway.RestApiTypes.EndpointConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithEndpointConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RestApiFactory, InnerRestApiEndpointConfigurationFactory> WithEndpointConfiguration<T1>(this CombinedResult<T1, RestApiFactory> combinedResult, Action<Humidifier.ApiGateway.RestApiTypes.EndpointConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithEndpointConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<RestApiFactory, T1, T2, InnerRestApiEndpointConfigurationFactory> WithEndpointConfiguration<T1, T2>(this CombinedResult<RestApiFactory, T1, T2> combinedResult, Action<Humidifier.ApiGateway.RestApiTypes.EndpointConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEndpointConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RestApiFactory, T2, InnerRestApiEndpointConfigurationFactory> WithEndpointConfiguration<T1, T2>(this CombinedResult<T1, RestApiFactory, T2> combinedResult, Action<Humidifier.ApiGateway.RestApiTypes.EndpointConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEndpointConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, RestApiFactory, InnerRestApiEndpointConfigurationFactory> WithEndpointConfiguration<T1, T2>(this CombinedResult<T1, T2, RestApiFactory> combinedResult, Action<Humidifier.ApiGateway.RestApiTypes.EndpointConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEndpointConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<RestApiFactory, T1, T2, T3, InnerRestApiEndpointConfigurationFactory> WithEndpointConfiguration<T1, T2, T3>(this CombinedResult<RestApiFactory, T1, T2, T3> combinedResult, Action<Humidifier.ApiGateway.RestApiTypes.EndpointConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEndpointConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RestApiFactory, T2, T3, InnerRestApiEndpointConfigurationFactory> WithEndpointConfiguration<T1, T2, T3>(this CombinedResult<T1, RestApiFactory, T2, T3> combinedResult, Action<Humidifier.ApiGateway.RestApiTypes.EndpointConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEndpointConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, RestApiFactory, T3, InnerRestApiEndpointConfigurationFactory> WithEndpointConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, RestApiFactory, T3> combinedResult, Action<Humidifier.ApiGateway.RestApiTypes.EndpointConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEndpointConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, RestApiFactory, InnerRestApiEndpointConfigurationFactory> WithEndpointConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, RestApiFactory> combinedResult, Action<Humidifier.ApiGateway.RestApiTypes.EndpointConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEndpointConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<RestApiFactory, T1, T2, T3, T4, InnerRestApiEndpointConfigurationFactory> WithEndpointConfiguration<T1, T2, T3, T4>(this CombinedResult<RestApiFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ApiGateway.RestApiTypes.EndpointConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEndpointConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RestApiFactory, T2, T3, T4, InnerRestApiEndpointConfigurationFactory> WithEndpointConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, RestApiFactory, T2, T3, T4> combinedResult, Action<Humidifier.ApiGateway.RestApiTypes.EndpointConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEndpointConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, RestApiFactory, T3, T4, InnerRestApiEndpointConfigurationFactory> WithEndpointConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, RestApiFactory, T3, T4> combinedResult, Action<Humidifier.ApiGateway.RestApiTypes.EndpointConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEndpointConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, RestApiFactory, T4, InnerRestApiEndpointConfigurationFactory> WithEndpointConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, RestApiFactory, T4> combinedResult, Action<Humidifier.ApiGateway.RestApiTypes.EndpointConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEndpointConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, RestApiFactory, InnerRestApiEndpointConfigurationFactory> WithEndpointConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, RestApiFactory> combinedResult, Action<Humidifier.ApiGateway.RestApiTypes.EndpointConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEndpointConfiguration(combinedResult.T5, subFactoryAction));
}
