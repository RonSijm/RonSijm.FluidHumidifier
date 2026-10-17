// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.FIS;

public class ActionFactory(string resourceName = null, Action<Humidifier.FIS.Action> factoryAction = null) : ResourceFactory<Humidifier.FIS.Action>(resourceName)
{

    protected override Humidifier.FIS.Action Create()
    {
        var actionResult = CreateAction();
        factoryAction?.Invoke(actionResult);

        return actionResult;
    }

    private Humidifier.FIS.Action CreateAction()
    {
        var actionResult = new Humidifier.FIS.Action
        {
            GivenName = InputResourceName,
        };

        return actionResult;
    }

} // End Of Class

public static class ActionFactoryExtensions
{
}
