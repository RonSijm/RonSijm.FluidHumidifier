// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.RTBFabric;

public class InnerLinkLinkAttributesFactory(Action<Humidifier.RTBFabric.LinkTypes.LinkAttributes> factoryAction = null) : SubResourceFactory<Humidifier.RTBFabric.LinkTypes.LinkAttributes>
{

    protected override Humidifier.RTBFabric.LinkTypes.LinkAttributes Create()
    {
        var linkAttributesResult = CreateLinkAttributes();
        factoryAction?.Invoke(linkAttributesResult);

        return linkAttributesResult;
    }

    private Humidifier.RTBFabric.LinkTypes.LinkAttributes CreateLinkAttributes()
    {
        var linkAttributesResult = new Humidifier.RTBFabric.LinkTypes.LinkAttributes();

        return linkAttributesResult;
    }

} // End Of Class

public static class InnerLinkLinkAttributesFactoryExtensions
{
}
