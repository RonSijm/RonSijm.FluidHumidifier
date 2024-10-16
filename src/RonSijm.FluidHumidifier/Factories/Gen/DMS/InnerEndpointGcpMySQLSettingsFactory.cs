// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DMS;

public class InnerEndpointGcpMySQLSettingsFactory(Action<Humidifier.DMS.EndpointTypes.GcpMySQLSettings> factoryAction = null) : SubResourceFactory<Humidifier.DMS.EndpointTypes.GcpMySQLSettings>
{

    protected override Humidifier.DMS.EndpointTypes.GcpMySQLSettings Create()
    {
        var gcpMySQLSettingsResult = CreateGcpMySQLSettings();
        factoryAction?.Invoke(gcpMySQLSettingsResult);

        return gcpMySQLSettingsResult;
    }

    private Humidifier.DMS.EndpointTypes.GcpMySQLSettings CreateGcpMySQLSettings()
    {
        var gcpMySQLSettingsResult = new Humidifier.DMS.EndpointTypes.GcpMySQLSettings();

        return gcpMySQLSettingsResult;
    }

} // End Of Class

public static class InnerEndpointGcpMySQLSettingsFactoryExtensions
{
}
