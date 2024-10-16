// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DMS;

public class InnerEndpointPostgreSqlSettingsFactory(Action<Humidifier.DMS.EndpointTypes.PostgreSqlSettings> factoryAction = null) : SubResourceFactory<Humidifier.DMS.EndpointTypes.PostgreSqlSettings>
{

    protected override Humidifier.DMS.EndpointTypes.PostgreSqlSettings Create()
    {
        var postgreSqlSettingsResult = CreatePostgreSqlSettings();
        factoryAction?.Invoke(postgreSqlSettingsResult);

        return postgreSqlSettingsResult;
    }

    private Humidifier.DMS.EndpointTypes.PostgreSqlSettings CreatePostgreSqlSettings()
    {
        var postgreSqlSettingsResult = new Humidifier.DMS.EndpointTypes.PostgreSqlSettings();

        return postgreSqlSettingsResult;
    }

} // End Of Class

public static class InnerEndpointPostgreSqlSettingsFactoryExtensions
{
}
