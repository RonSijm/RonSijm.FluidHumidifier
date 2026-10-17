// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ARCRegionSwitch;

public class InnerPlanTriggerFactory(Action<Humidifier.ARCRegionSwitch.PlanTypes.Trigger> factoryAction = null) : SubResourceFactory<Humidifier.ARCRegionSwitch.PlanTypes.Trigger>
{

    protected override Humidifier.ARCRegionSwitch.PlanTypes.Trigger Create()
    {
        var triggerResult = CreateTrigger();
        factoryAction?.Invoke(triggerResult);

        return triggerResult;
    }

    private Humidifier.ARCRegionSwitch.PlanTypes.Trigger CreateTrigger()
    {
        var triggerResult = new Humidifier.ARCRegionSwitch.PlanTypes.Trigger();

        return triggerResult;
    }

} // End Of Class

public static class InnerPlanTriggerFactoryExtensions
{
}
