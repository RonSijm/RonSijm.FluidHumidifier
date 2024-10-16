// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.OpsWorks;

public class InnerLayerAutoScalingThresholdsFactory(Action<Humidifier.OpsWorks.LayerTypes.AutoScalingThresholds> factoryAction = null) : SubResourceFactory<Humidifier.OpsWorks.LayerTypes.AutoScalingThresholds>
{

    protected override Humidifier.OpsWorks.LayerTypes.AutoScalingThresholds Create()
    {
        var autoScalingThresholdsResult = CreateAutoScalingThresholds();
        factoryAction?.Invoke(autoScalingThresholdsResult);

        return autoScalingThresholdsResult;
    }

    private Humidifier.OpsWorks.LayerTypes.AutoScalingThresholds CreateAutoScalingThresholds()
    {
        var autoScalingThresholdsResult = new Humidifier.OpsWorks.LayerTypes.AutoScalingThresholds();

        return autoScalingThresholdsResult;
    }

} // End Of Class

public static class InnerLayerAutoScalingThresholdsFactoryExtensions
{
}
