// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFormation;

public class WaitConditionFactory(string resourceName = null, Action<Humidifier.CloudFormation.WaitCondition> factoryAction = null) : ResourceFactory<Humidifier.CloudFormation.WaitCondition>(resourceName)
{

    protected override Humidifier.CloudFormation.WaitCondition Create()
    {
        var waitConditionResult = CreateWaitCondition();
        factoryAction?.Invoke(waitConditionResult);

        return waitConditionResult;
    }

    private Humidifier.CloudFormation.WaitCondition CreateWaitCondition()
    {
        var waitConditionResult = new Humidifier.CloudFormation.WaitCondition
        {
            GivenName = InputResourceName,
        };

        return waitConditionResult;
    }

} // End Of Class

public static class WaitConditionFactoryExtensions
{
}
