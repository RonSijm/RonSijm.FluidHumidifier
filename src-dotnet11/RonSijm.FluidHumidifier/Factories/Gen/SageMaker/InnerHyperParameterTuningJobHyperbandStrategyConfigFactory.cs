// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerHyperParameterTuningJobHyperbandStrategyConfigFactory(Action<Humidifier.SageMaker.HyperParameterTuningJobTypes.HyperbandStrategyConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.HyperParameterTuningJobTypes.HyperbandStrategyConfig>
{

    protected override Humidifier.SageMaker.HyperParameterTuningJobTypes.HyperbandStrategyConfig Create()
    {
        var hyperbandStrategyConfigResult = CreateHyperbandStrategyConfig();
        factoryAction?.Invoke(hyperbandStrategyConfigResult);

        return hyperbandStrategyConfigResult;
    }

    private Humidifier.SageMaker.HyperParameterTuningJobTypes.HyperbandStrategyConfig CreateHyperbandStrategyConfig()
    {
        var hyperbandStrategyConfigResult = new Humidifier.SageMaker.HyperParameterTuningJobTypes.HyperbandStrategyConfig();

        return hyperbandStrategyConfigResult;
    }

} // End Of Class

public static class InnerHyperParameterTuningJobHyperbandStrategyConfigFactoryExtensions
{
}
