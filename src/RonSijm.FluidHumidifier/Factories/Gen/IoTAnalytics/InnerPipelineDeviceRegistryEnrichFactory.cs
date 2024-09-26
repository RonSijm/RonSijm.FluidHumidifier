// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTAnalytics;

public class InnerPipelineDeviceRegistryEnrichFactory(Action<Humidifier.IoTAnalytics.PipelineTypes.DeviceRegistryEnrich> factoryAction = null) : SubResourceFactory<Humidifier.IoTAnalytics.PipelineTypes.DeviceRegistryEnrich>
{

    protected override Humidifier.IoTAnalytics.PipelineTypes.DeviceRegistryEnrich Create()
    {
        var deviceRegistryEnrichResult = CreateDeviceRegistryEnrich();
        factoryAction?.Invoke(deviceRegistryEnrichResult);

        return deviceRegistryEnrichResult;
    }

    private Humidifier.IoTAnalytics.PipelineTypes.DeviceRegistryEnrich CreateDeviceRegistryEnrich()
    {
        var deviceRegistryEnrichResult = new Humidifier.IoTAnalytics.PipelineTypes.DeviceRegistryEnrich();

        return deviceRegistryEnrichResult;
    }

} // End Of Class

public static class InnerPipelineDeviceRegistryEnrichFactoryExtensions
{
}
