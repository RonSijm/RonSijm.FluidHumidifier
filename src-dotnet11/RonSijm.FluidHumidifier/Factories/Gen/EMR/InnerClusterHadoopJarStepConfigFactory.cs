// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EMR;

public class InnerClusterHadoopJarStepConfigFactory(Action<Humidifier.EMR.ClusterTypes.HadoopJarStepConfig> factoryAction = null) : SubResourceFactory<Humidifier.EMR.ClusterTypes.HadoopJarStepConfig>
{

    protected override Humidifier.EMR.ClusterTypes.HadoopJarStepConfig Create()
    {
        var hadoopJarStepConfigResult = CreateHadoopJarStepConfig();
        factoryAction?.Invoke(hadoopJarStepConfigResult);

        return hadoopJarStepConfigResult;
    }

    private Humidifier.EMR.ClusterTypes.HadoopJarStepConfig CreateHadoopJarStepConfig()
    {
        var hadoopJarStepConfigResult = new Humidifier.EMR.ClusterTypes.HadoopJarStepConfig();

        return hadoopJarStepConfigResult;
    }

} // End Of Class

public static class InnerClusterHadoopJarStepConfigFactoryExtensions
{
}
