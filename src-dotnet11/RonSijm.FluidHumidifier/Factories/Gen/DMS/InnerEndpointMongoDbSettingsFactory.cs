// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DMS;

public class InnerEndpointMongoDbSettingsFactory(Action<Humidifier.DMS.EndpointTypes.MongoDbSettings> factoryAction = null) : SubResourceFactory<Humidifier.DMS.EndpointTypes.MongoDbSettings>
{

    protected override Humidifier.DMS.EndpointTypes.MongoDbSettings Create()
    {
        var mongoDbSettingsResult = CreateMongoDbSettings();
        factoryAction?.Invoke(mongoDbSettingsResult);

        return mongoDbSettingsResult;
    }

    private Humidifier.DMS.EndpointTypes.MongoDbSettings CreateMongoDbSettings()
    {
        var mongoDbSettingsResult = new Humidifier.DMS.EndpointTypes.MongoDbSettings();

        return mongoDbSettingsResult;
    }

} // End Of Class

public static class InnerEndpointMongoDbSettingsFactoryExtensions
{
}
