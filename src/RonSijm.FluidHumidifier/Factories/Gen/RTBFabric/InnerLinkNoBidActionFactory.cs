// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.RTBFabric;

public class InnerLinkNoBidActionFactory(Action<Humidifier.RTBFabric.LinkTypes.NoBidAction> factoryAction = null) : SubResourceFactory<Humidifier.RTBFabric.LinkTypes.NoBidAction>
{

    protected override Humidifier.RTBFabric.LinkTypes.NoBidAction Create()
    {
        var noBidActionResult = CreateNoBidAction();
        factoryAction?.Invoke(noBidActionResult);

        return noBidActionResult;
    }

    private Humidifier.RTBFabric.LinkTypes.NoBidAction CreateNoBidAction()
    {
        var noBidActionResult = new Humidifier.RTBFabric.LinkTypes.NoBidAction();

        return noBidActionResult;
    }

} // End Of Class

public static class InnerLinkNoBidActionFactoryExtensions
{
}
