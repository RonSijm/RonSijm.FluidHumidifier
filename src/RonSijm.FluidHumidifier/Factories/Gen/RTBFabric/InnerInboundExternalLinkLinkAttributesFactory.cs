// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.RTBFabric;

public class InnerInboundExternalLinkLinkAttributesFactory(Action<Humidifier.RTBFabric.InboundExternalLinkTypes.LinkAttributes> factoryAction = null) : SubResourceFactory<Humidifier.RTBFabric.InboundExternalLinkTypes.LinkAttributes>
{

    protected override Humidifier.RTBFabric.InboundExternalLinkTypes.LinkAttributes Create()
    {
        var linkAttributesResult = CreateLinkAttributes();
        factoryAction?.Invoke(linkAttributesResult);

        return linkAttributesResult;
    }

    private Humidifier.RTBFabric.InboundExternalLinkTypes.LinkAttributes CreateLinkAttributes()
    {
        var linkAttributesResult = new Humidifier.RTBFabric.InboundExternalLinkTypes.LinkAttributes();

        return linkAttributesResult;
    }

} // End Of Class

public static class InnerInboundExternalLinkLinkAttributesFactoryExtensions
{
}
