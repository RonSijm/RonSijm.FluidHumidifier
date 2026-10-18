// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Evidently;

public class InnerLaunchExecutionStatusObjectFactory(Action<Humidifier.Evidently.LaunchTypes.ExecutionStatusObject> factoryAction = null) : SubResourceFactory<Humidifier.Evidently.LaunchTypes.ExecutionStatusObject>
{

    protected override Humidifier.Evidently.LaunchTypes.ExecutionStatusObject Create()
    {
        var executionStatusObjectResult = CreateExecutionStatusObject();
        factoryAction?.Invoke(executionStatusObjectResult);

        return executionStatusObjectResult;
    }

    private Humidifier.Evidently.LaunchTypes.ExecutionStatusObject CreateExecutionStatusObject()
    {
        var executionStatusObjectResult = new Humidifier.Evidently.LaunchTypes.ExecutionStatusObject();

        return executionStatusObjectResult;
    }

} // End Of Class

public static class InnerLaunchExecutionStatusObjectFactoryExtensions
{
}
