// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DMS;

public class InnerEndpointNeptuneSettingsFactory(Action<Humidifier.DMS.EndpointTypes.NeptuneSettings> factoryAction = null) : SubResourceFactory<Humidifier.DMS.EndpointTypes.NeptuneSettings>
{

    protected override Humidifier.DMS.EndpointTypes.NeptuneSettings Create()
    {
        var neptuneSettingsResult = CreateNeptuneSettings();
        factoryAction?.Invoke(neptuneSettingsResult);

        return neptuneSettingsResult;
    }

    private Humidifier.DMS.EndpointTypes.NeptuneSettings CreateNeptuneSettings()
    {
        var neptuneSettingsResult = new Humidifier.DMS.EndpointTypes.NeptuneSettings();

        return neptuneSettingsResult;
    }

} // End Of Class

public static class InnerEndpointNeptuneSettingsFactoryExtensions
{
}
