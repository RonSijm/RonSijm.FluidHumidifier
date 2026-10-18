// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Oam;

public class InnerLinkLinkFilterFactory(Action<Humidifier.Oam.LinkTypes.LinkFilter> factoryAction = null) : SubResourceFactory<Humidifier.Oam.LinkTypes.LinkFilter>
{

    protected override Humidifier.Oam.LinkTypes.LinkFilter Create()
    {
        var linkFilterResult = CreateLinkFilter();
        factoryAction?.Invoke(linkFilterResult);

        return linkFilterResult;
    }

    private Humidifier.Oam.LinkTypes.LinkFilter CreateLinkFilter()
    {
        var linkFilterResult = new Humidifier.Oam.LinkTypes.LinkFilter();

        return linkFilterResult;
    }

} // End Of Class

public static class InnerLinkLinkFilterFactoryExtensions
{
}
