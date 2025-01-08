// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFormation;

public class InnerGuardHookStackNamesFactory(Action<Humidifier.CloudFormation.GuardHookTypes.StackNames> factoryAction = null) : SubResourceFactory<Humidifier.CloudFormation.GuardHookTypes.StackNames>
{

    protected override Humidifier.CloudFormation.GuardHookTypes.StackNames Create()
    {
        var stackNamesResult = CreateStackNames();
        factoryAction?.Invoke(stackNamesResult);

        return stackNamesResult;
    }

    private Humidifier.CloudFormation.GuardHookTypes.StackNames CreateStackNames()
    {
        var stackNamesResult = new Humidifier.CloudFormation.GuardHookTypes.StackNames();

        return stackNamesResult;
    }

} // End Of Class

public static class InnerGuardHookStackNamesFactoryExtensions
{
}
