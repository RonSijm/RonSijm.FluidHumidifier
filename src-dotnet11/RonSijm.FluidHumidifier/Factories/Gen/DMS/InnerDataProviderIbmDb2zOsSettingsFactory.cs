// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DMS;

public class InnerDataProviderIbmDb2zOsSettingsFactory(Action<Humidifier.DMS.DataProviderTypes.IbmDb2zOsSettings> factoryAction = null) : SubResourceFactory<Humidifier.DMS.DataProviderTypes.IbmDb2zOsSettings>
{

    protected override Humidifier.DMS.DataProviderTypes.IbmDb2zOsSettings Create()
    {
        var ibmDb2zOsSettingsResult = CreateIbmDb2zOsSettings();
        factoryAction?.Invoke(ibmDb2zOsSettingsResult);

        return ibmDb2zOsSettingsResult;
    }

    private Humidifier.DMS.DataProviderTypes.IbmDb2zOsSettings CreateIbmDb2zOsSettings()
    {
        var ibmDb2zOsSettingsResult = new Humidifier.DMS.DataProviderTypes.IbmDb2zOsSettings();

        return ibmDb2zOsSettingsResult;
    }

} // End Of Class

public static class InnerDataProviderIbmDb2zOsSettingsFactoryExtensions
{
}
