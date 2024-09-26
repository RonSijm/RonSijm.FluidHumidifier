// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ImageBuilder;

public class InnerImagePipelineScheduleFactory(Action<Humidifier.ImageBuilder.ImagePipelineTypes.Schedule> factoryAction = null) : SubResourceFactory<Humidifier.ImageBuilder.ImagePipelineTypes.Schedule>
{

    protected override Humidifier.ImageBuilder.ImagePipelineTypes.Schedule Create()
    {
        var scheduleResult = CreateSchedule();
        factoryAction?.Invoke(scheduleResult);

        return scheduleResult;
    }

    private Humidifier.ImageBuilder.ImagePipelineTypes.Schedule CreateSchedule()
    {
        var scheduleResult = new Humidifier.ImageBuilder.ImagePipelineTypes.Schedule();

        return scheduleResult;
    }

} // End Of Class

public static class InnerImagePipelineScheduleFactoryExtensions
{
}
