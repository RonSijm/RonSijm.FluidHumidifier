// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAFRegional;

public class InnerWebACLActionFactory(Action<Humidifier.WAFRegional.WebACLTypes.Action> factoryAction = null) : SubResourceFactory<Humidifier.WAFRegional.WebACLTypes.Action>
{

    protected override Humidifier.WAFRegional.WebACLTypes.Action Create()
    {
        var actionResult = CreateAction();
        factoryAction?.Invoke(actionResult);

        return actionResult;
    }

    private Humidifier.WAFRegional.WebACLTypes.Action CreateAction()
    {
        var actionResult = new Humidifier.WAFRegional.WebACLTypes.Action();

        return actionResult;
    }

} // End Of Class

public static class InnerWebACLActionFactoryExtensions
{
}
