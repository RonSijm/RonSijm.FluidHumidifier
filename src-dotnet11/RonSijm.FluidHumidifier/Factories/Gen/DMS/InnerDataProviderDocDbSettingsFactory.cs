// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DMS;

public class InnerDataProviderDocDbSettingsFactory(Action<Humidifier.DMS.DataProviderTypes.DocDbSettings> factoryAction = null) : SubResourceFactory<Humidifier.DMS.DataProviderTypes.DocDbSettings>
{

    protected override Humidifier.DMS.DataProviderTypes.DocDbSettings Create()
    {
        var docDbSettingsResult = CreateDocDbSettings();
        factoryAction?.Invoke(docDbSettingsResult);

        return docDbSettingsResult;
    }

    private Humidifier.DMS.DataProviderTypes.DocDbSettings CreateDocDbSettings()
    {
        var docDbSettingsResult = new Humidifier.DMS.DataProviderTypes.DocDbSettings();

        return docDbSettingsResult;
    }

} // End Of Class

public static class InnerDataProviderDocDbSettingsFactoryExtensions
{
}
