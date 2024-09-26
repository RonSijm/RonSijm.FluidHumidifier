// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DMS;

public class InnerEndpointIbmDb2SettingsFactory(Action<Humidifier.DMS.EndpointTypes.IbmDb2Settings> factoryAction = null) : SubResourceFactory<Humidifier.DMS.EndpointTypes.IbmDb2Settings>
{

    protected override Humidifier.DMS.EndpointTypes.IbmDb2Settings Create()
    {
        var ibmDb2SettingsResult = CreateIbmDb2Settings();
        factoryAction?.Invoke(ibmDb2SettingsResult);

        return ibmDb2SettingsResult;
    }

    private Humidifier.DMS.EndpointTypes.IbmDb2Settings CreateIbmDb2Settings()
    {
        var ibmDb2SettingsResult = new Humidifier.DMS.EndpointTypes.IbmDb2Settings();

        return ibmDb2SettingsResult;
    }

} // End Of Class

public static class InnerEndpointIbmDb2SettingsFactoryExtensions
{
}
