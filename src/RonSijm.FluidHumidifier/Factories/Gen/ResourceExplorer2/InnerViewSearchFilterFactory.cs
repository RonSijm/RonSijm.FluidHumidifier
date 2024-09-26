// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ResourceExplorer2;

public class InnerViewSearchFilterFactory(Action<Humidifier.ResourceExplorer2.ViewTypes.SearchFilter> factoryAction = null) : SubResourceFactory<Humidifier.ResourceExplorer2.ViewTypes.SearchFilter>
{

    protected override Humidifier.ResourceExplorer2.ViewTypes.SearchFilter Create()
    {
        var searchFilterResult = CreateSearchFilter();
        factoryAction?.Invoke(searchFilterResult);

        return searchFilterResult;
    }

    private Humidifier.ResourceExplorer2.ViewTypes.SearchFilter CreateSearchFilter()
    {
        var searchFilterResult = new Humidifier.ResourceExplorer2.ViewTypes.SearchFilter();

        return searchFilterResult;
    }

} // End Of Class

public static class InnerViewSearchFilterFactoryExtensions
{
}
