// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DMS;

public class InnerDataProviderMongoDbSettingsFactory(Action<Humidifier.DMS.DataProviderTypes.MongoDbSettings> factoryAction = null) : SubResourceFactory<Humidifier.DMS.DataProviderTypes.MongoDbSettings>
{

    protected override Humidifier.DMS.DataProviderTypes.MongoDbSettings Create()
    {
        var mongoDbSettingsResult = CreateMongoDbSettings();
        factoryAction?.Invoke(mongoDbSettingsResult);

        return mongoDbSettingsResult;
    }

    private Humidifier.DMS.DataProviderTypes.MongoDbSettings CreateMongoDbSettings()
    {
        var mongoDbSettingsResult = new Humidifier.DMS.DataProviderTypes.MongoDbSettings();

        return mongoDbSettingsResult;
    }

} // End Of Class

public static class InnerDataProviderMongoDbSettingsFactoryExtensions
{
}
