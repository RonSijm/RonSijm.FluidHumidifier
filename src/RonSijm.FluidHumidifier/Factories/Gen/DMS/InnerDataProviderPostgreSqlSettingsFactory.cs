// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DMS;

public class InnerDataProviderPostgreSqlSettingsFactory(Action<Humidifier.DMS.DataProviderTypes.PostgreSqlSettings> factoryAction = null) : SubResourceFactory<Humidifier.DMS.DataProviderTypes.PostgreSqlSettings>
{

    protected override Humidifier.DMS.DataProviderTypes.PostgreSqlSettings Create()
    {
        var postgreSqlSettingsResult = CreatePostgreSqlSettings();
        factoryAction?.Invoke(postgreSqlSettingsResult);

        return postgreSqlSettingsResult;
    }

    private Humidifier.DMS.DataProviderTypes.PostgreSqlSettings CreatePostgreSqlSettings()
    {
        var postgreSqlSettingsResult = new Humidifier.DMS.DataProviderTypes.PostgreSqlSettings();

        return postgreSqlSettingsResult;
    }

} // End Of Class

public static class InnerDataProviderPostgreSqlSettingsFactoryExtensions
{
}
