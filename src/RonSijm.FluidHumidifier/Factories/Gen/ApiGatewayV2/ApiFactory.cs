// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ApiGatewayV2;

public class ApiFactory(string resourceName = null, Action<Humidifier.ApiGatewayV2.Api> factoryAction = null) : ResourceFactory<Humidifier.ApiGatewayV2.Api>(resourceName)
{

    internal InnerApiBodyS3LocationFactory BodyS3LocationFactory { get; set; }

    internal InnerApiCorsFactory CorsConfigurationFactory { get; set; }

    protected override Humidifier.ApiGatewayV2.Api Create()
    {
        var apiResult = CreateApi();
        factoryAction?.Invoke(apiResult);

        return apiResult;
    }

    private Humidifier.ApiGatewayV2.Api CreateApi()
    {
        var apiResult = new Humidifier.ApiGatewayV2.Api
        {
            GivenName = InputResourceName,
        };

        return apiResult;
    }
    public override void CreateChildren(Humidifier.ApiGatewayV2.Api result)
    {
        base.CreateChildren(result);

        result.BodyS3Location ??= BodyS3LocationFactory?.Build();
        result.CorsConfiguration ??= CorsConfigurationFactory?.Build();
    }

} // End Of Class

public static class ApiFactoryExtensions
{
    public static CombinedResult<ApiFactory, InnerApiBodyS3LocationFactory> WithBodyS3Location(this ApiFactory parentFactory, Action<Humidifier.ApiGatewayV2.ApiTypes.BodyS3Location> subFactoryAction = null)
    {
        parentFactory.BodyS3LocationFactory = new InnerApiBodyS3LocationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.BodyS3LocationFactory);
    }

    public static CombinedResult<ApiFactory, InnerApiCorsFactory> WithCorsConfiguration(this ApiFactory parentFactory, Action<Humidifier.ApiGatewayV2.ApiTypes.Cors> subFactoryAction = null)
    {
        parentFactory.CorsConfigurationFactory = new InnerApiCorsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CorsConfigurationFactory);
    }

    public static CombinedResult<ApiFactory, T1, InnerApiBodyS3LocationFactory> WithBodyS3Location<T1>(this CombinedResult<ApiFactory, T1> combinedResult, Action<Humidifier.ApiGatewayV2.ApiTypes.BodyS3Location> subFactoryAction = null) => new (combinedResult, combinedResult, WithBodyS3Location(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ApiFactory, InnerApiBodyS3LocationFactory> WithBodyS3Location<T1>(this CombinedResult<T1, ApiFactory> combinedResult, Action<Humidifier.ApiGatewayV2.ApiTypes.BodyS3Location> subFactoryAction = null) => new (combinedResult, combinedResult, WithBodyS3Location(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ApiFactory, T1, T2, InnerApiBodyS3LocationFactory> WithBodyS3Location<T1, T2>(this CombinedResult<ApiFactory, T1, T2> combinedResult, Action<Humidifier.ApiGatewayV2.ApiTypes.BodyS3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBodyS3Location(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ApiFactory, T2, InnerApiBodyS3LocationFactory> WithBodyS3Location<T1, T2>(this CombinedResult<T1, ApiFactory, T2> combinedResult, Action<Humidifier.ApiGatewayV2.ApiTypes.BodyS3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBodyS3Location(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ApiFactory, InnerApiBodyS3LocationFactory> WithBodyS3Location<T1, T2>(this CombinedResult<T1, T2, ApiFactory> combinedResult, Action<Humidifier.ApiGatewayV2.ApiTypes.BodyS3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBodyS3Location(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ApiFactory, T1, T2, T3, InnerApiBodyS3LocationFactory> WithBodyS3Location<T1, T2, T3>(this CombinedResult<ApiFactory, T1, T2, T3> combinedResult, Action<Humidifier.ApiGatewayV2.ApiTypes.BodyS3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBodyS3Location(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ApiFactory, T2, T3, InnerApiBodyS3LocationFactory> WithBodyS3Location<T1, T2, T3>(this CombinedResult<T1, ApiFactory, T2, T3> combinedResult, Action<Humidifier.ApiGatewayV2.ApiTypes.BodyS3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBodyS3Location(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ApiFactory, T3, InnerApiBodyS3LocationFactory> WithBodyS3Location<T1, T2, T3>(this CombinedResult<T1, T2, ApiFactory, T3> combinedResult, Action<Humidifier.ApiGatewayV2.ApiTypes.BodyS3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBodyS3Location(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ApiFactory, InnerApiBodyS3LocationFactory> WithBodyS3Location<T1, T2, T3>(this CombinedResult<T1, T2, T3, ApiFactory> combinedResult, Action<Humidifier.ApiGatewayV2.ApiTypes.BodyS3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBodyS3Location(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ApiFactory, T1, T2, T3, T4, InnerApiBodyS3LocationFactory> WithBodyS3Location<T1, T2, T3, T4>(this CombinedResult<ApiFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ApiGatewayV2.ApiTypes.BodyS3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBodyS3Location(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ApiFactory, T2, T3, T4, InnerApiBodyS3LocationFactory> WithBodyS3Location<T1, T2, T3, T4>(this CombinedResult<T1, ApiFactory, T2, T3, T4> combinedResult, Action<Humidifier.ApiGatewayV2.ApiTypes.BodyS3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBodyS3Location(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ApiFactory, T3, T4, InnerApiBodyS3LocationFactory> WithBodyS3Location<T1, T2, T3, T4>(this CombinedResult<T1, T2, ApiFactory, T3, T4> combinedResult, Action<Humidifier.ApiGatewayV2.ApiTypes.BodyS3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBodyS3Location(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ApiFactory, T4, InnerApiBodyS3LocationFactory> WithBodyS3Location<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ApiFactory, T4> combinedResult, Action<Humidifier.ApiGatewayV2.ApiTypes.BodyS3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBodyS3Location(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ApiFactory, InnerApiBodyS3LocationFactory> WithBodyS3Location<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ApiFactory> combinedResult, Action<Humidifier.ApiGatewayV2.ApiTypes.BodyS3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBodyS3Location(combinedResult.T5, subFactoryAction));
    public static CombinedResult<ApiFactory, T1, InnerApiCorsFactory> WithCorsConfiguration<T1>(this CombinedResult<ApiFactory, T1> combinedResult, Action<Humidifier.ApiGatewayV2.ApiTypes.Cors> subFactoryAction = null) => new (combinedResult, combinedResult, WithCorsConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ApiFactory, InnerApiCorsFactory> WithCorsConfiguration<T1>(this CombinedResult<T1, ApiFactory> combinedResult, Action<Humidifier.ApiGatewayV2.ApiTypes.Cors> subFactoryAction = null) => new (combinedResult, combinedResult, WithCorsConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ApiFactory, T1, T2, InnerApiCorsFactory> WithCorsConfiguration<T1, T2>(this CombinedResult<ApiFactory, T1, T2> combinedResult, Action<Humidifier.ApiGatewayV2.ApiTypes.Cors> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCorsConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ApiFactory, T2, InnerApiCorsFactory> WithCorsConfiguration<T1, T2>(this CombinedResult<T1, ApiFactory, T2> combinedResult, Action<Humidifier.ApiGatewayV2.ApiTypes.Cors> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCorsConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ApiFactory, InnerApiCorsFactory> WithCorsConfiguration<T1, T2>(this CombinedResult<T1, T2, ApiFactory> combinedResult, Action<Humidifier.ApiGatewayV2.ApiTypes.Cors> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCorsConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ApiFactory, T1, T2, T3, InnerApiCorsFactory> WithCorsConfiguration<T1, T2, T3>(this CombinedResult<ApiFactory, T1, T2, T3> combinedResult, Action<Humidifier.ApiGatewayV2.ApiTypes.Cors> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCorsConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ApiFactory, T2, T3, InnerApiCorsFactory> WithCorsConfiguration<T1, T2, T3>(this CombinedResult<T1, ApiFactory, T2, T3> combinedResult, Action<Humidifier.ApiGatewayV2.ApiTypes.Cors> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCorsConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ApiFactory, T3, InnerApiCorsFactory> WithCorsConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, ApiFactory, T3> combinedResult, Action<Humidifier.ApiGatewayV2.ApiTypes.Cors> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCorsConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ApiFactory, InnerApiCorsFactory> WithCorsConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, ApiFactory> combinedResult, Action<Humidifier.ApiGatewayV2.ApiTypes.Cors> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCorsConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ApiFactory, T1, T2, T3, T4, InnerApiCorsFactory> WithCorsConfiguration<T1, T2, T3, T4>(this CombinedResult<ApiFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ApiGatewayV2.ApiTypes.Cors> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCorsConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ApiFactory, T2, T3, T4, InnerApiCorsFactory> WithCorsConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, ApiFactory, T2, T3, T4> combinedResult, Action<Humidifier.ApiGatewayV2.ApiTypes.Cors> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCorsConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ApiFactory, T3, T4, InnerApiCorsFactory> WithCorsConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, ApiFactory, T3, T4> combinedResult, Action<Humidifier.ApiGatewayV2.ApiTypes.Cors> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCorsConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ApiFactory, T4, InnerApiCorsFactory> WithCorsConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ApiFactory, T4> combinedResult, Action<Humidifier.ApiGatewayV2.ApiTypes.Cors> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCorsConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ApiFactory, InnerApiCorsFactory> WithCorsConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ApiFactory> combinedResult, Action<Humidifier.ApiGatewayV2.ApiTypes.Cors> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCorsConfiguration(combinedResult.T5, subFactoryAction));
}
