// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.RedshiftServerless;

public class InnerWorkgroupPerformanceTargetFactory(Action<Humidifier.RedshiftServerless.WorkgroupTypes.PerformanceTarget> factoryAction = null) : SubResourceFactory<Humidifier.RedshiftServerless.WorkgroupTypes.PerformanceTarget>
{

    protected override Humidifier.RedshiftServerless.WorkgroupTypes.PerformanceTarget Create()
    {
        var performanceTargetResult = CreatePerformanceTarget();
        factoryAction?.Invoke(performanceTargetResult);

        return performanceTargetResult;
    }

    private Humidifier.RedshiftServerless.WorkgroupTypes.PerformanceTarget CreatePerformanceTarget()
    {
        var performanceTargetResult = new Humidifier.RedshiftServerless.WorkgroupTypes.PerformanceTarget();

        return performanceTargetResult;
    }

} // End Of Class

public static class InnerWorkgroupPerformanceTargetFactoryExtensions
{
}
