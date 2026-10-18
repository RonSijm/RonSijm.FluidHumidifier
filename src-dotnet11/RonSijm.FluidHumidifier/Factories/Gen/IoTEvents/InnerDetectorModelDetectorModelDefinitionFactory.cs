// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTEvents;

public class InnerDetectorModelDetectorModelDefinitionFactory(Action<Humidifier.IoTEvents.DetectorModelTypes.DetectorModelDefinition> factoryAction = null) : SubResourceFactory<Humidifier.IoTEvents.DetectorModelTypes.DetectorModelDefinition>
{

    protected override Humidifier.IoTEvents.DetectorModelTypes.DetectorModelDefinition Create()
    {
        var detectorModelDefinitionResult = CreateDetectorModelDefinition();
        factoryAction?.Invoke(detectorModelDefinitionResult);

        return detectorModelDefinitionResult;
    }

    private Humidifier.IoTEvents.DetectorModelTypes.DetectorModelDefinition CreateDetectorModelDefinition()
    {
        var detectorModelDefinitionResult = new Humidifier.IoTEvents.DetectorModelTypes.DetectorModelDefinition();

        return detectorModelDefinitionResult;
    }

} // End Of Class

public static class InnerDetectorModelDetectorModelDefinitionFactoryExtensions
{
}
