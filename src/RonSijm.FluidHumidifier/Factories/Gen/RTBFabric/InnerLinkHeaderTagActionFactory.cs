// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.RTBFabric;

public class InnerLinkHeaderTagActionFactory(Action<Humidifier.RTBFabric.LinkTypes.HeaderTagAction> factoryAction = null) : SubResourceFactory<Humidifier.RTBFabric.LinkTypes.HeaderTagAction>
{

    protected override Humidifier.RTBFabric.LinkTypes.HeaderTagAction Create()
    {
        var headerTagActionResult = CreateHeaderTagAction();
        factoryAction?.Invoke(headerTagActionResult);

        return headerTagActionResult;
    }

    private Humidifier.RTBFabric.LinkTypes.HeaderTagAction CreateHeaderTagAction()
    {
        var headerTagActionResult = new Humidifier.RTBFabric.LinkTypes.HeaderTagAction();

        return headerTagActionResult;
    }

} // End Of Class

public static class InnerLinkHeaderTagActionFactoryExtensions
{
}
