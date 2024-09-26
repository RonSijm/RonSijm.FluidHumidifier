// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFormation;

public class StackFactory(string resourceName = null, Action<Humidifier.CloudFormation.Stack> factoryAction = null) : ResourceFactory<Humidifier.CloudFormation.Stack>(resourceName)
{

    protected override Humidifier.CloudFormation.Stack Create()
    {
        var stackResult = CreateStack();
        factoryAction?.Invoke(stackResult);

        return stackResult;
    }

    private Humidifier.CloudFormation.Stack CreateStack()
    {
        var stackResult = new Humidifier.CloudFormation.Stack
        {
            GivenName = InputResourceName,
        };

        return stackResult;
    }

} // End Of Class

public static class StackFactoryExtensions
{
}
