// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerClusterPatchScheduleFactory(Action<Humidifier.SageMaker.ClusterTypes.PatchSchedule> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ClusterTypes.PatchSchedule>
{

    protected override Humidifier.SageMaker.ClusterTypes.PatchSchedule Create()
    {
        var patchScheduleResult = CreatePatchSchedule();
        factoryAction?.Invoke(patchScheduleResult);

        return patchScheduleResult;
    }

    private Humidifier.SageMaker.ClusterTypes.PatchSchedule CreatePatchSchedule()
    {
        var patchScheduleResult = new Humidifier.SageMaker.ClusterTypes.PatchSchedule();

        return patchScheduleResult;
    }

} // End Of Class

public static class InnerClusterPatchScheduleFactoryExtensions
{
}
