// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DMS;

public class InnerEndpointSybaseSettingsFactory(Action<Humidifier.DMS.EndpointTypes.SybaseSettings> factoryAction = null) : SubResourceFactory<Humidifier.DMS.EndpointTypes.SybaseSettings>
{

    protected override Humidifier.DMS.EndpointTypes.SybaseSettings Create()
    {
        var sybaseSettingsResult = CreateSybaseSettings();
        factoryAction?.Invoke(sybaseSettingsResult);

        return sybaseSettingsResult;
    }

    private Humidifier.DMS.EndpointTypes.SybaseSettings CreateSybaseSettings()
    {
        var sybaseSettingsResult = new Humidifier.DMS.EndpointTypes.SybaseSettings();

        return sybaseSettingsResult;
    }

} // End Of Class

public static class InnerEndpointSybaseSettingsFactoryExtensions
{
}
