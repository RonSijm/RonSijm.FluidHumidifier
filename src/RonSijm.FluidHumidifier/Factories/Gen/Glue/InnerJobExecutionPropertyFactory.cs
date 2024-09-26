// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Glue;

public class InnerJobExecutionPropertyFactory(Action<Humidifier.Glue.JobTypes.ExecutionProperty> factoryAction = null) : SubResourceFactory<Humidifier.Glue.JobTypes.ExecutionProperty>
{

    protected override Humidifier.Glue.JobTypes.ExecutionProperty Create()
    {
        var executionPropertyResult = CreateExecutionProperty();
        factoryAction?.Invoke(executionPropertyResult);

        return executionPropertyResult;
    }

    private Humidifier.Glue.JobTypes.ExecutionProperty CreateExecutionProperty()
    {
        var executionPropertyResult = new Humidifier.Glue.JobTypes.ExecutionProperty();

        return executionPropertyResult;
    }

} // End Of Class

public static class InnerJobExecutionPropertyFactoryExtensions
{
}
