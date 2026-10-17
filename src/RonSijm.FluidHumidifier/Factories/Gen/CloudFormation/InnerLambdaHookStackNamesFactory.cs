// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFormation;

public class InnerLambdaHookStackNamesFactory(Action<Humidifier.CloudFormation.LambdaHookTypes.StackNames> factoryAction = null) : SubResourceFactory<Humidifier.CloudFormation.LambdaHookTypes.StackNames>
{

    protected override Humidifier.CloudFormation.LambdaHookTypes.StackNames Create()
    {
        var stackNamesResult = CreateStackNames();
        factoryAction?.Invoke(stackNamesResult);

        return stackNamesResult;
    }

    private Humidifier.CloudFormation.LambdaHookTypes.StackNames CreateStackNames()
    {
        var stackNamesResult = new Humidifier.CloudFormation.LambdaHookTypes.StackNames();

        return stackNamesResult;
    }

} // End Of Class

public static class InnerLambdaHookStackNamesFactoryExtensions
{
}
