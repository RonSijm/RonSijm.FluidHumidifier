// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAFv2;

public class InnerWebACLOverrideActionFactory(Action<Humidifier.WAFv2.WebACLTypes.OverrideAction> factoryAction = null) : SubResourceFactory<Humidifier.WAFv2.WebACLTypes.OverrideAction>
{

    protected override Humidifier.WAFv2.WebACLTypes.OverrideAction Create()
    {
        var overrideActionResult = CreateOverrideAction();
        factoryAction?.Invoke(overrideActionResult);

        return overrideActionResult;
    }

    private Humidifier.WAFv2.WebACLTypes.OverrideAction CreateOverrideAction()
    {
        var overrideActionResult = new Humidifier.WAFv2.WebACLTypes.OverrideAction();

        return overrideActionResult;
    }

} // End Of Class

public static class InnerWebACLOverrideActionFactoryExtensions
{
}
