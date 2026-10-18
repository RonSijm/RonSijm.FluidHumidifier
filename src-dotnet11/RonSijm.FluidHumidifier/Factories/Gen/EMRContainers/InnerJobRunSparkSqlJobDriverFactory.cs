// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EMRContainers;

public class InnerJobRunSparkSqlJobDriverFactory(Action<Humidifier.EMRContainers.JobRunTypes.SparkSqlJobDriver> factoryAction = null) : SubResourceFactory<Humidifier.EMRContainers.JobRunTypes.SparkSqlJobDriver>
{

    protected override Humidifier.EMRContainers.JobRunTypes.SparkSqlJobDriver Create()
    {
        var sparkSqlJobDriverResult = CreateSparkSqlJobDriver();
        factoryAction?.Invoke(sparkSqlJobDriverResult);

        return sparkSqlJobDriverResult;
    }

    private Humidifier.EMRContainers.JobRunTypes.SparkSqlJobDriver CreateSparkSqlJobDriver()
    {
        var sparkSqlJobDriverResult = new Humidifier.EMRContainers.JobRunTypes.SparkSqlJobDriver();

        return sparkSqlJobDriverResult;
    }

} // End Of Class

public static class InnerJobRunSparkSqlJobDriverFactoryExtensions
{
}
