// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IVS;

public class InnerRecordingConfigurationRenditionConfigurationFactory(Action<Humidifier.IVS.RecordingConfigurationTypes.RenditionConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.IVS.RecordingConfigurationTypes.RenditionConfiguration>
{

    protected override Humidifier.IVS.RecordingConfigurationTypes.RenditionConfiguration Create()
    {
        var renditionConfigurationResult = CreateRenditionConfiguration();
        factoryAction?.Invoke(renditionConfigurationResult);

        return renditionConfigurationResult;
    }

    private Humidifier.IVS.RecordingConfigurationTypes.RenditionConfiguration CreateRenditionConfiguration()
    {
        var renditionConfigurationResult = new Humidifier.IVS.RecordingConfigurationTypes.RenditionConfiguration();

        return renditionConfigurationResult;
    }

} // End Of Class

public static class InnerRecordingConfigurationRenditionConfigurationFactoryExtensions
{
}
