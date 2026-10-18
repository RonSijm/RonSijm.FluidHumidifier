// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EMRContainers;

public class InnerJobTemplateSparkSqlJobDriverFactory(Action<Humidifier.EMRContainers.JobTemplateTypes.SparkSqlJobDriver> factoryAction = null) : SubResourceFactory<Humidifier.EMRContainers.JobTemplateTypes.SparkSqlJobDriver>
{

    protected override Humidifier.EMRContainers.JobTemplateTypes.SparkSqlJobDriver Create()
    {
        var sparkSqlJobDriverResult = CreateSparkSqlJobDriver();
        factoryAction?.Invoke(sparkSqlJobDriverResult);

        return sparkSqlJobDriverResult;
    }

    private Humidifier.EMRContainers.JobTemplateTypes.SparkSqlJobDriver CreateSparkSqlJobDriver()
    {
        var sparkSqlJobDriverResult = new Humidifier.EMRContainers.JobTemplateTypes.SparkSqlJobDriver();

        return sparkSqlJobDriverResult;
    }

} // End Of Class

public static class InnerJobTemplateSparkSqlJobDriverFactoryExtensions
{
}
