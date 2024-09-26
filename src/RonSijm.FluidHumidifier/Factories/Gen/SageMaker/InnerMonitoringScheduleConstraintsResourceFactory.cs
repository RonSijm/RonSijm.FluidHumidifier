// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerMonitoringScheduleConstraintsResourceFactory(Action<Humidifier.SageMaker.MonitoringScheduleTypes.ConstraintsResource> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.MonitoringScheduleTypes.ConstraintsResource>
{

    protected override Humidifier.SageMaker.MonitoringScheduleTypes.ConstraintsResource Create()
    {
        var constraintsResourceResult = CreateConstraintsResource();
        factoryAction?.Invoke(constraintsResourceResult);

        return constraintsResourceResult;
    }

    private Humidifier.SageMaker.MonitoringScheduleTypes.ConstraintsResource CreateConstraintsResource()
    {
        var constraintsResourceResult = new Humidifier.SageMaker.MonitoringScheduleTypes.ConstraintsResource();

        return constraintsResourceResult;
    }

} // End Of Class

public static class InnerMonitoringScheduleConstraintsResourceFactoryExtensions
{
}
