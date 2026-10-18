// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerTrainingJobInfraCheckConfigFactory(Action<Humidifier.SageMaker.TrainingJobTypes.InfraCheckConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.TrainingJobTypes.InfraCheckConfig>
{

    protected override Humidifier.SageMaker.TrainingJobTypes.InfraCheckConfig Create()
    {
        var infraCheckConfigResult = CreateInfraCheckConfig();
        factoryAction?.Invoke(infraCheckConfigResult);

        return infraCheckConfigResult;
    }

    private Humidifier.SageMaker.TrainingJobTypes.InfraCheckConfig CreateInfraCheckConfig()
    {
        var infraCheckConfigResult = new Humidifier.SageMaker.TrainingJobTypes.InfraCheckConfig();

        return infraCheckConfigResult;
    }

} // End Of Class

public static class InnerTrainingJobInfraCheckConfigFactoryExtensions
{
}
