// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFormation;

public class WaitConditionHandleFactory(string resourceName = null, Action<Humidifier.CloudFormation.WaitConditionHandle> factoryAction = null) : ResourceFactory<Humidifier.CloudFormation.WaitConditionHandle>(resourceName)
{

    protected override Humidifier.CloudFormation.WaitConditionHandle Create()
    {
        var waitConditionHandleResult = CreateWaitConditionHandle();
        factoryAction?.Invoke(waitConditionHandleResult);

        return waitConditionHandleResult;
    }

    private Humidifier.CloudFormation.WaitConditionHandle CreateWaitConditionHandle()
    {
        var waitConditionHandleResult = new Humidifier.CloudFormation.WaitConditionHandle
        {
            GivenName = InputResourceName,
        };

        return waitConditionHandleResult;
    }

} // End Of Class

public static class WaitConditionHandleFactoryExtensions
{
}
