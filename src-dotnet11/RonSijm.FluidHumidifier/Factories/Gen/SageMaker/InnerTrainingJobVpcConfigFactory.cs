// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerTrainingJobVpcConfigFactory(Action<Humidifier.SageMaker.TrainingJobTypes.VpcConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.TrainingJobTypes.VpcConfig>
{

    protected override Humidifier.SageMaker.TrainingJobTypes.VpcConfig Create()
    {
        var vpcConfigResult = CreateVpcConfig();
        factoryAction?.Invoke(vpcConfigResult);

        return vpcConfigResult;
    }

    private Humidifier.SageMaker.TrainingJobTypes.VpcConfig CreateVpcConfig()
    {
        var vpcConfigResult = new Humidifier.SageMaker.TrainingJobTypes.VpcConfig();

        return vpcConfigResult;
    }

} // End Of Class

public static class InnerTrainingJobVpcConfigFactoryExtensions
{
}
