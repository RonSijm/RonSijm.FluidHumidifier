// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerHyperParameterTuningJobOutputDataConfigFactory(Action<Humidifier.SageMaker.HyperParameterTuningJobTypes.OutputDataConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.HyperParameterTuningJobTypes.OutputDataConfig>
{

    protected override Humidifier.SageMaker.HyperParameterTuningJobTypes.OutputDataConfig Create()
    {
        var outputDataConfigResult = CreateOutputDataConfig();
        factoryAction?.Invoke(outputDataConfigResult);

        return outputDataConfigResult;
    }

    private Humidifier.SageMaker.HyperParameterTuningJobTypes.OutputDataConfig CreateOutputDataConfig()
    {
        var outputDataConfigResult = new Humidifier.SageMaker.HyperParameterTuningJobTypes.OutputDataConfig();

        return outputDataConfigResult;
    }

} // End Of Class

public static class InnerHyperParameterTuningJobOutputDataConfigFactoryExtensions
{
}
