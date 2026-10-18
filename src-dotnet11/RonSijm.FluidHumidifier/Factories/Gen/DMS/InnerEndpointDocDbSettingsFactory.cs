// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DMS;

public class InnerEndpointDocDbSettingsFactory(Action<Humidifier.DMS.EndpointTypes.DocDbSettings> factoryAction = null) : SubResourceFactory<Humidifier.DMS.EndpointTypes.DocDbSettings>
{

    protected override Humidifier.DMS.EndpointTypes.DocDbSettings Create()
    {
        var docDbSettingsResult = CreateDocDbSettings();
        factoryAction?.Invoke(docDbSettingsResult);

        return docDbSettingsResult;
    }

    private Humidifier.DMS.EndpointTypes.DocDbSettings CreateDocDbSettings()
    {
        var docDbSettingsResult = new Humidifier.DMS.EndpointTypes.DocDbSettings();

        return docDbSettingsResult;
    }

} // End Of Class

public static class InnerEndpointDocDbSettingsFactoryExtensions
{
}
