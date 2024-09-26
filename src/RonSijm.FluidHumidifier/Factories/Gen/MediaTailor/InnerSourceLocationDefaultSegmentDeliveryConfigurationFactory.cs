// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaTailor;

public class InnerSourceLocationDefaultSegmentDeliveryConfigurationFactory(Action<Humidifier.MediaTailor.SourceLocationTypes.DefaultSegmentDeliveryConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.MediaTailor.SourceLocationTypes.DefaultSegmentDeliveryConfiguration>
{

    protected override Humidifier.MediaTailor.SourceLocationTypes.DefaultSegmentDeliveryConfiguration Create()
    {
        var defaultSegmentDeliveryConfigurationResult = CreateDefaultSegmentDeliveryConfiguration();
        factoryAction?.Invoke(defaultSegmentDeliveryConfigurationResult);

        return defaultSegmentDeliveryConfigurationResult;
    }

    private Humidifier.MediaTailor.SourceLocationTypes.DefaultSegmentDeliveryConfiguration CreateDefaultSegmentDeliveryConfiguration()
    {
        var defaultSegmentDeliveryConfigurationResult = new Humidifier.MediaTailor.SourceLocationTypes.DefaultSegmentDeliveryConfiguration();

        return defaultSegmentDeliveryConfigurationResult;
    }

} // End Of Class

public static class InnerSourceLocationDefaultSegmentDeliveryConfigurationFactoryExtensions
{
}
