// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AutoScalingPlans;

public class InnerScalingPlanApplicationSourceFactory(Action<Humidifier.AutoScalingPlans.ScalingPlanTypes.ApplicationSource> factoryAction = null) : SubResourceFactory<Humidifier.AutoScalingPlans.ScalingPlanTypes.ApplicationSource>
{

    protected override Humidifier.AutoScalingPlans.ScalingPlanTypes.ApplicationSource Create()
    {
        var applicationSourceResult = CreateApplicationSource();
        factoryAction?.Invoke(applicationSourceResult);

        return applicationSourceResult;
    }

    private Humidifier.AutoScalingPlans.ScalingPlanTypes.ApplicationSource CreateApplicationSource()
    {
        var applicationSourceResult = new Humidifier.AutoScalingPlans.ScalingPlanTypes.ApplicationSource();

        return applicationSourceResult;
    }

} // End Of Class

public static class InnerScalingPlanApplicationSourceFactoryExtensions
{
}
