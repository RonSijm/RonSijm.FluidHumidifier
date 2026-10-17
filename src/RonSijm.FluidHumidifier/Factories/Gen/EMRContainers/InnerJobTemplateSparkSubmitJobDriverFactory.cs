// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EMRContainers;

public class InnerJobTemplateSparkSubmitJobDriverFactory(Action<Humidifier.EMRContainers.JobTemplateTypes.SparkSubmitJobDriver> factoryAction = null) : SubResourceFactory<Humidifier.EMRContainers.JobTemplateTypes.SparkSubmitJobDriver>
{

    protected override Humidifier.EMRContainers.JobTemplateTypes.SparkSubmitJobDriver Create()
    {
        var sparkSubmitJobDriverResult = CreateSparkSubmitJobDriver();
        factoryAction?.Invoke(sparkSubmitJobDriverResult);

        return sparkSubmitJobDriverResult;
    }

    private Humidifier.EMRContainers.JobTemplateTypes.SparkSubmitJobDriver CreateSparkSubmitJobDriver()
    {
        var sparkSubmitJobDriverResult = new Humidifier.EMRContainers.JobTemplateTypes.SparkSubmitJobDriver();

        return sparkSubmitJobDriverResult;
    }

} // End Of Class

public static class InnerJobTemplateSparkSubmitJobDriverFactoryExtensions
{
}
