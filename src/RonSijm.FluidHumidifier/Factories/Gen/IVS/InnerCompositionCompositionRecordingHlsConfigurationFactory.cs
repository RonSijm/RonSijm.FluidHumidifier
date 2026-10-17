// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IVS;

public class InnerCompositionCompositionRecordingHlsConfigurationFactory(Action<Humidifier.IVS.CompositionTypes.CompositionRecordingHlsConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.IVS.CompositionTypes.CompositionRecordingHlsConfiguration>
{

    protected override Humidifier.IVS.CompositionTypes.CompositionRecordingHlsConfiguration Create()
    {
        var compositionRecordingHlsConfigurationResult = CreateCompositionRecordingHlsConfiguration();
        factoryAction?.Invoke(compositionRecordingHlsConfigurationResult);

        return compositionRecordingHlsConfigurationResult;
    }

    private Humidifier.IVS.CompositionTypes.CompositionRecordingHlsConfiguration CreateCompositionRecordingHlsConfiguration()
    {
        var compositionRecordingHlsConfigurationResult = new Humidifier.IVS.CompositionTypes.CompositionRecordingHlsConfiguration();

        return compositionRecordingHlsConfigurationResult;
    }

} // End Of Class

public static class InnerCompositionCompositionRecordingHlsConfigurationFactoryExtensions
{
}
