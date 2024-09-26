// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFormation;

public class InnerStackSetOperationPreferencesFactory(Action<Humidifier.CloudFormation.StackSetTypes.OperationPreferences> factoryAction = null) : SubResourceFactory<Humidifier.CloudFormation.StackSetTypes.OperationPreferences>
{

    protected override Humidifier.CloudFormation.StackSetTypes.OperationPreferences Create()
    {
        var operationPreferencesResult = CreateOperationPreferences();
        factoryAction?.Invoke(operationPreferencesResult);

        return operationPreferencesResult;
    }

    private Humidifier.CloudFormation.StackSetTypes.OperationPreferences CreateOperationPreferences()
    {
        var operationPreferencesResult = new Humidifier.CloudFormation.StackSetTypes.OperationPreferences();

        return operationPreferencesResult;
    }

} // End Of Class

public static class InnerStackSetOperationPreferencesFactoryExtensions
{
}
