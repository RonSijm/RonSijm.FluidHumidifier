// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAFv2;

public class InnerWebACLMonetizeActionFactory(Action<Humidifier.WAFv2.WebACLTypes.MonetizeAction> factoryAction = null) : SubResourceFactory<Humidifier.WAFv2.WebACLTypes.MonetizeAction>
{

    protected override Humidifier.WAFv2.WebACLTypes.MonetizeAction Create()
    {
        var monetizeActionResult = CreateMonetizeAction();
        factoryAction?.Invoke(monetizeActionResult);

        return monetizeActionResult;
    }

    private Humidifier.WAFv2.WebACLTypes.MonetizeAction CreateMonetizeAction()
    {
        var monetizeActionResult = new Humidifier.WAFv2.WebACLTypes.MonetizeAction();

        return monetizeActionResult;
    }

} // End Of Class

public static class InnerWebACLMonetizeActionFactoryExtensions
{
}
