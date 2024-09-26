// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Kendra;

public class InnerIndexSearchFactory(Action<Humidifier.Kendra.IndexTypes.Search> factoryAction = null) : SubResourceFactory<Humidifier.Kendra.IndexTypes.Search>
{

    protected override Humidifier.Kendra.IndexTypes.Search Create()
    {
        var searchResult = CreateSearch();
        factoryAction?.Invoke(searchResult);

        return searchResult;
    }

    private Humidifier.Kendra.IndexTypes.Search CreateSearch()
    {
        var searchResult = new Humidifier.Kendra.IndexTypes.Search();

        return searchResult;
    }

} // End Of Class

public static class InnerIndexSearchFactoryExtensions
{
}
