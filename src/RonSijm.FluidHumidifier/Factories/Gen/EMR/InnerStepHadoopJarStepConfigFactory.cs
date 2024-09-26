// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EMR;

public class InnerStepHadoopJarStepConfigFactory(Action<Humidifier.EMR.StepTypes.HadoopJarStepConfig> factoryAction = null) : SubResourceFactory<Humidifier.EMR.StepTypes.HadoopJarStepConfig>
{

    protected override Humidifier.EMR.StepTypes.HadoopJarStepConfig Create()
    {
        var hadoopJarStepConfigResult = CreateHadoopJarStepConfig();
        factoryAction?.Invoke(hadoopJarStepConfigResult);

        return hadoopJarStepConfigResult;
    }

    private Humidifier.EMR.StepTypes.HadoopJarStepConfig CreateHadoopJarStepConfig()
    {
        var hadoopJarStepConfigResult = new Humidifier.EMR.StepTypes.HadoopJarStepConfig();

        return hadoopJarStepConfigResult;
    }

} // End Of Class

public static class InnerStepHadoopJarStepConfigFactoryExtensions
{
}
