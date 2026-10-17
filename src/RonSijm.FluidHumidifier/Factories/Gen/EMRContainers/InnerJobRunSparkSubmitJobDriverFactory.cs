// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EMRContainers;

public class InnerJobRunSparkSubmitJobDriverFactory(Action<Humidifier.EMRContainers.JobRunTypes.SparkSubmitJobDriver> factoryAction = null) : SubResourceFactory<Humidifier.EMRContainers.JobRunTypes.SparkSubmitJobDriver>
{

    protected override Humidifier.EMRContainers.JobRunTypes.SparkSubmitJobDriver Create()
    {
        var sparkSubmitJobDriverResult = CreateSparkSubmitJobDriver();
        factoryAction?.Invoke(sparkSubmitJobDriverResult);

        return sparkSubmitJobDriverResult;
    }

    private Humidifier.EMRContainers.JobRunTypes.SparkSubmitJobDriver CreateSparkSubmitJobDriver()
    {
        var sparkSubmitJobDriverResult = new Humidifier.EMRContainers.JobRunTypes.SparkSubmitJobDriver();

        return sparkSubmitJobDriverResult;
    }

} // End Of Class

public static class InnerJobRunSparkSubmitJobDriverFactoryExtensions
{
}
