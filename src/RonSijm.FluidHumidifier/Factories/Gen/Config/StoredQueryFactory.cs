// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Config;

public class StoredQueryFactory(string resourceName = null, Action<Humidifier.Config.StoredQuery> factoryAction = null) : ResourceFactory<Humidifier.Config.StoredQuery>(resourceName)
{

    protected override Humidifier.Config.StoredQuery Create()
    {
        var storedQueryResult = CreateStoredQuery();
        factoryAction?.Invoke(storedQueryResult);

        return storedQueryResult;
    }

    private Humidifier.Config.StoredQuery CreateStoredQuery()
    {
        var storedQueryResult = new Humidifier.Config.StoredQuery
        {
            GivenName = InputResourceName,
        };

        return storedQueryResult;
    }

} // End Of Class

public static class StoredQueryFactoryExtensions
{
}
