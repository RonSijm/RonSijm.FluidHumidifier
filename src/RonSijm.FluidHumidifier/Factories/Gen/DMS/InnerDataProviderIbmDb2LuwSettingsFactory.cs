// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DMS;

public class InnerDataProviderIbmDb2LuwSettingsFactory(Action<Humidifier.DMS.DataProviderTypes.IbmDb2LuwSettings> factoryAction = null) : SubResourceFactory<Humidifier.DMS.DataProviderTypes.IbmDb2LuwSettings>
{

    protected override Humidifier.DMS.DataProviderTypes.IbmDb2LuwSettings Create()
    {
        var ibmDb2LuwSettingsResult = CreateIbmDb2LuwSettings();
        factoryAction?.Invoke(ibmDb2LuwSettingsResult);

        return ibmDb2LuwSettingsResult;
    }

    private Humidifier.DMS.DataProviderTypes.IbmDb2LuwSettings CreateIbmDb2LuwSettings()
    {
        var ibmDb2LuwSettingsResult = new Humidifier.DMS.DataProviderTypes.IbmDb2LuwSettings();

        return ibmDb2LuwSettingsResult;
    }

} // End Of Class

public static class InnerDataProviderIbmDb2LuwSettingsFactoryExtensions
{
}
