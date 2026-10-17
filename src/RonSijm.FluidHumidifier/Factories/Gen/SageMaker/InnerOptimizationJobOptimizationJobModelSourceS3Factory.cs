// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerOptimizationJobOptimizationJobModelSourceS3Factory(Action<Humidifier.SageMaker.OptimizationJobTypes.OptimizationJobModelSourceS3> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.OptimizationJobTypes.OptimizationJobModelSourceS3>
{

    protected override Humidifier.SageMaker.OptimizationJobTypes.OptimizationJobModelSourceS3 Create()
    {
        var optimizationJobModelSourceS3Result = CreateOptimizationJobModelSourceS3();
        factoryAction?.Invoke(optimizationJobModelSourceS3Result);

        return optimizationJobModelSourceS3Result;
    }

    private Humidifier.SageMaker.OptimizationJobTypes.OptimizationJobModelSourceS3 CreateOptimizationJobModelSourceS3()
    {
        var optimizationJobModelSourceS3Result = new Humidifier.SageMaker.OptimizationJobTypes.OptimizationJobModelSourceS3();

        return optimizationJobModelSourceS3Result;
    }

} // End Of Class

public static class InnerOptimizationJobOptimizationJobModelSourceS3FactoryExtensions
{
}
