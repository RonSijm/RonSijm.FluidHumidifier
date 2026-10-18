// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.RTBFabric;

public class InnerOutboundExternalLinkLinkAttributesFactory(Action<Humidifier.RTBFabric.OutboundExternalLinkTypes.LinkAttributes> factoryAction = null) : SubResourceFactory<Humidifier.RTBFabric.OutboundExternalLinkTypes.LinkAttributes>
{

    protected override Humidifier.RTBFabric.OutboundExternalLinkTypes.LinkAttributes Create()
    {
        var linkAttributesResult = CreateLinkAttributes();
        factoryAction?.Invoke(linkAttributesResult);

        return linkAttributesResult;
    }

    private Humidifier.RTBFabric.OutboundExternalLinkTypes.LinkAttributes CreateLinkAttributes()
    {
        var linkAttributesResult = new Humidifier.RTBFabric.OutboundExternalLinkTypes.LinkAttributes();

        return linkAttributesResult;
    }

} // End Of Class

public static class InnerOutboundExternalLinkLinkAttributesFactoryExtensions
{
}
