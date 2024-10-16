// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTAnalytics;

public class InnerPipelineDeviceShadowEnrichFactory(Action<Humidifier.IoTAnalytics.PipelineTypes.DeviceShadowEnrich> factoryAction = null) : SubResourceFactory<Humidifier.IoTAnalytics.PipelineTypes.DeviceShadowEnrich>
{

    protected override Humidifier.IoTAnalytics.PipelineTypes.DeviceShadowEnrich Create()
    {
        var deviceShadowEnrichResult = CreateDeviceShadowEnrich();
        factoryAction?.Invoke(deviceShadowEnrichResult);

        return deviceShadowEnrichResult;
    }

    private Humidifier.IoTAnalytics.PipelineTypes.DeviceShadowEnrich CreateDeviceShadowEnrich()
    {
        var deviceShadowEnrichResult = new Humidifier.IoTAnalytics.PipelineTypes.DeviceShadowEnrich();

        return deviceShadowEnrichResult;
    }

} // End Of Class

public static class InnerPipelineDeviceShadowEnrichFactoryExtensions
{
}
