// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Shield;

public class InnerProtectionActionFactory(Action<Humidifier.Shield.ProtectionTypes.Action> factoryAction = null) : SubResourceFactory<Humidifier.Shield.ProtectionTypes.Action>
{

    protected override Humidifier.Shield.ProtectionTypes.Action Create()
    {
        var actionResult = CreateAction();
        factoryAction?.Invoke(actionResult);

        return actionResult;
    }

    private Humidifier.Shield.ProtectionTypes.Action CreateAction()
    {
        var actionResult = new Humidifier.Shield.ProtectionTypes.Action();

        return actionResult;
    }

} // End Of Class

public static class InnerProtectionActionFactoryExtensions
{
}
