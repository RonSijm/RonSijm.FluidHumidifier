// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BackupSearch;

public class InnerSearchJobSearchScopeFactory(Action<Humidifier.BackupSearch.SearchJobTypes.SearchScope> factoryAction = null) : SubResourceFactory<Humidifier.BackupSearch.SearchJobTypes.SearchScope>
{

    protected override Humidifier.BackupSearch.SearchJobTypes.SearchScope Create()
    {
        var searchScopeResult = CreateSearchScope();
        factoryAction?.Invoke(searchScopeResult);

        return searchScopeResult;
    }

    private Humidifier.BackupSearch.SearchJobTypes.SearchScope CreateSearchScope()
    {
        var searchScopeResult = new Humidifier.BackupSearch.SearchJobTypes.SearchScope();

        return searchScopeResult;
    }

} // End Of Class

public static class InnerSearchJobSearchScopeFactoryExtensions
{
}
