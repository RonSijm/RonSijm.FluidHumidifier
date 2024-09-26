// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DMS;

public class InnerEndpointRedisSettingsFactory(Action<Humidifier.DMS.EndpointTypes.RedisSettings> factoryAction = null) : SubResourceFactory<Humidifier.DMS.EndpointTypes.RedisSettings>
{

    protected override Humidifier.DMS.EndpointTypes.RedisSettings Create()
    {
        var redisSettingsResult = CreateRedisSettings();
        factoryAction?.Invoke(redisSettingsResult);

        return redisSettingsResult;
    }

    private Humidifier.DMS.EndpointTypes.RedisSettings CreateRedisSettings()
    {
        var redisSettingsResult = new Humidifier.DMS.EndpointTypes.RedisSettings();

        return redisSettingsResult;
    }

} // End Of Class

public static class InnerEndpointRedisSettingsFactoryExtensions
{
}
