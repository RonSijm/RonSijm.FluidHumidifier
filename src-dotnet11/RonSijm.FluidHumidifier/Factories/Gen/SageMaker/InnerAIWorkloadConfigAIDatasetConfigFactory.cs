// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerAIWorkloadConfigAIDatasetConfigFactory(Action<Humidifier.SageMaker.AIWorkloadConfigTypes.AIDatasetConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.AIWorkloadConfigTypes.AIDatasetConfig>
{

    protected override Humidifier.SageMaker.AIWorkloadConfigTypes.AIDatasetConfig Create()
    {
        var aIDatasetConfigResult = CreateAIDatasetConfig();
        factoryAction?.Invoke(aIDatasetConfigResult);

        return aIDatasetConfigResult;
    }

    private Humidifier.SageMaker.AIWorkloadConfigTypes.AIDatasetConfig CreateAIDatasetConfig()
    {
        var aIDatasetConfigResult = new Humidifier.SageMaker.AIWorkloadConfigTypes.AIDatasetConfig();

        return aIDatasetConfigResult;
    }

} // End Of Class

public static class InnerAIWorkloadConfigAIDatasetConfigFactoryExtensions
{
}
