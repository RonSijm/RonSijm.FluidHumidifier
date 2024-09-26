// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.OpsWorks;

public class InnerInstanceTimeBasedAutoScalingFactory(Action<Humidifier.OpsWorks.InstanceTypes.TimeBasedAutoScaling> factoryAction = null) : SubResourceFactory<Humidifier.OpsWorks.InstanceTypes.TimeBasedAutoScaling>
{

    protected override Humidifier.OpsWorks.InstanceTypes.TimeBasedAutoScaling Create()
    {
        var timeBasedAutoScalingResult = CreateTimeBasedAutoScaling();
        factoryAction?.Invoke(timeBasedAutoScalingResult);

        return timeBasedAutoScalingResult;
    }

    private Humidifier.OpsWorks.InstanceTypes.TimeBasedAutoScaling CreateTimeBasedAutoScaling()
    {
        var timeBasedAutoScalingResult = new Humidifier.OpsWorks.InstanceTypes.TimeBasedAutoScaling();

        return timeBasedAutoScalingResult;
    }

} // End Of Class

public static class InnerInstanceTimeBasedAutoScalingFactoryExtensions
{
}
