// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DMS;

public class InnerDataProviderSybaseAseSettingsFactory(Action<Humidifier.DMS.DataProviderTypes.SybaseAseSettings> factoryAction = null) : SubResourceFactory<Humidifier.DMS.DataProviderTypes.SybaseAseSettings>
{

    protected override Humidifier.DMS.DataProviderTypes.SybaseAseSettings Create()
    {
        var sybaseAseSettingsResult = CreateSybaseAseSettings();
        factoryAction?.Invoke(sybaseAseSettingsResult);

        return sybaseAseSettingsResult;
    }

    private Humidifier.DMS.DataProviderTypes.SybaseAseSettings CreateSybaseAseSettings()
    {
        var sybaseAseSettingsResult = new Humidifier.DMS.DataProviderTypes.SybaseAseSettings();

        return sybaseAseSettingsResult;
    }

} // End Of Class

public static class InnerDataProviderSybaseAseSettingsFactoryExtensions
{
}
