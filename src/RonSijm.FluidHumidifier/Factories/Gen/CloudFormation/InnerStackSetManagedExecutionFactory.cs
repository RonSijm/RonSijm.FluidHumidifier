// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFormation;

public class InnerStackSetManagedExecutionFactory(Action<Humidifier.CloudFormation.StackSetTypes.ManagedExecution> factoryAction = null) : SubResourceFactory<Humidifier.CloudFormation.StackSetTypes.ManagedExecution>
{

    protected override Humidifier.CloudFormation.StackSetTypes.ManagedExecution Create()
    {
        var managedExecutionResult = CreateManagedExecution();
        factoryAction?.Invoke(managedExecutionResult);

        return managedExecutionResult;
    }

    private Humidifier.CloudFormation.StackSetTypes.ManagedExecution CreateManagedExecution()
    {
        var managedExecutionResult = new Humidifier.CloudFormation.StackSetTypes.ManagedExecution();

        return managedExecutionResult;
    }

} // End Of Class

public static class InnerStackSetManagedExecutionFactoryExtensions
{
}
