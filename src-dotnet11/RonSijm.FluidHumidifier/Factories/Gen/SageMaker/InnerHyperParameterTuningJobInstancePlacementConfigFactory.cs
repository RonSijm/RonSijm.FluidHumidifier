// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerHyperParameterTuningJobInstancePlacementConfigFactory(Action<Humidifier.SageMaker.HyperParameterTuningJobTypes.InstancePlacementConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.HyperParameterTuningJobTypes.InstancePlacementConfig>
{

    protected override Humidifier.SageMaker.HyperParameterTuningJobTypes.InstancePlacementConfig Create()
    {
        var instancePlacementConfigResult = CreateInstancePlacementConfig();
        factoryAction?.Invoke(instancePlacementConfigResult);

        return instancePlacementConfigResult;
    }

    private Humidifier.SageMaker.HyperParameterTuningJobTypes.InstancePlacementConfig CreateInstancePlacementConfig()
    {
        var instancePlacementConfigResult = new Humidifier.SageMaker.HyperParameterTuningJobTypes.InstancePlacementConfig();

        return instancePlacementConfigResult;
    }

} // End Of Class

public static class InnerHyperParameterTuningJobInstancePlacementConfigFactoryExtensions
{
}
