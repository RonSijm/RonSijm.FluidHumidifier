// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerAutoMLJobEmrServerlessComputeConfigFactory(Action<Humidifier.SageMaker.AutoMLJobTypes.EmrServerlessComputeConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.AutoMLJobTypes.EmrServerlessComputeConfig>
{

    protected override Humidifier.SageMaker.AutoMLJobTypes.EmrServerlessComputeConfig Create()
    {
        var emrServerlessComputeConfigResult = CreateEmrServerlessComputeConfig();
        factoryAction?.Invoke(emrServerlessComputeConfigResult);

        return emrServerlessComputeConfigResult;
    }

    private Humidifier.SageMaker.AutoMLJobTypes.EmrServerlessComputeConfig CreateEmrServerlessComputeConfig()
    {
        var emrServerlessComputeConfigResult = new Humidifier.SageMaker.AutoMLJobTypes.EmrServerlessComputeConfig();

        return emrServerlessComputeConfigResult;
    }

} // End Of Class

public static class InnerAutoMLJobEmrServerlessComputeConfigFactoryExtensions
{
}
