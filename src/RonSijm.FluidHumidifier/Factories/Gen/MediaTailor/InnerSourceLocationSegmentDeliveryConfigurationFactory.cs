// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaTailor;

public class InnerSourceLocationSegmentDeliveryConfigurationFactory(Action<Humidifier.MediaTailor.SourceLocationTypes.SegmentDeliveryConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.MediaTailor.SourceLocationTypes.SegmentDeliveryConfiguration>
{

    protected override Humidifier.MediaTailor.SourceLocationTypes.SegmentDeliveryConfiguration Create()
    {
        var segmentDeliveryConfigurationResult = CreateSegmentDeliveryConfiguration();
        factoryAction?.Invoke(segmentDeliveryConfigurationResult);

        return segmentDeliveryConfigurationResult;
    }

    private Humidifier.MediaTailor.SourceLocationTypes.SegmentDeliveryConfiguration CreateSegmentDeliveryConfiguration()
    {
        var segmentDeliveryConfigurationResult = new Humidifier.MediaTailor.SourceLocationTypes.SegmentDeliveryConfiguration();

        return segmentDeliveryConfigurationResult;
    }

} // End Of Class

public static class InnerSourceLocationSegmentDeliveryConfigurationFactoryExtensions
{
}
