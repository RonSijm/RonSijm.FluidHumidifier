// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SecurityHub;

public class ActionTargetFactory(string resourceName = null, Action<Humidifier.SecurityHub.ActionTarget> factoryAction = null) : ResourceFactory<Humidifier.SecurityHub.ActionTarget>(resourceName)
{

    protected override Humidifier.SecurityHub.ActionTarget Create()
    {
        var actionTargetResult = CreateActionTarget();
        factoryAction?.Invoke(actionTargetResult);

        return actionTargetResult;
    }

    private Humidifier.SecurityHub.ActionTarget CreateActionTarget()
    {
        var actionTargetResult = new Humidifier.SecurityHub.ActionTarget
        {
            GivenName = InputResourceName,
        };

        return actionTargetResult;
    }

} // End Of Class

public static class ActionTargetFactoryExtensions
{
}
