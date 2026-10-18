// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EMRServerless;

public class InnerJobRunSparkSubmitFactory(Action<Humidifier.EMRServerless.JobRunTypes.SparkSubmit> factoryAction = null) : SubResourceFactory<Humidifier.EMRServerless.JobRunTypes.SparkSubmit>
{

    protected override Humidifier.EMRServerless.JobRunTypes.SparkSubmit Create()
    {
        var sparkSubmitResult = CreateSparkSubmit();
        factoryAction?.Invoke(sparkSubmitResult);

        return sparkSubmitResult;
    }

    private Humidifier.EMRServerless.JobRunTypes.SparkSubmit CreateSparkSubmit()
    {
        var sparkSubmitResult = new Humidifier.EMRServerless.JobRunTypes.SparkSubmit();

        return sparkSubmitResult;
    }

} // End Of Class

public static class InnerJobRunSparkSubmitFactoryExtensions
{
}
