// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerAIWorkloadConfigWorkloadSpecFactory(Action<Humidifier.SageMaker.AIWorkloadConfigTypes.WorkloadSpec> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.AIWorkloadConfigTypes.WorkloadSpec>
{

    protected override Humidifier.SageMaker.AIWorkloadConfigTypes.WorkloadSpec Create()
    {
        var workloadSpecResult = CreateWorkloadSpec();
        factoryAction?.Invoke(workloadSpecResult);

        return workloadSpecResult;
    }

    private Humidifier.SageMaker.AIWorkloadConfigTypes.WorkloadSpec CreateWorkloadSpec()
    {
        var workloadSpecResult = new Humidifier.SageMaker.AIWorkloadConfigTypes.WorkloadSpec();

        return workloadSpecResult;
    }

} // End Of Class

public static class InnerAIWorkloadConfigWorkloadSpecFactoryExtensions
{
}
