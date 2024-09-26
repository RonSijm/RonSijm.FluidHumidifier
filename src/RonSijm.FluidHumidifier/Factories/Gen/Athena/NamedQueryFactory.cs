// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Athena;

public class NamedQueryFactory(string resourceName = null, Action<Humidifier.Athena.NamedQuery> factoryAction = null) : ResourceFactory<Humidifier.Athena.NamedQuery>(resourceName)
{

    protected override Humidifier.Athena.NamedQuery Create()
    {
        var namedQueryResult = CreateNamedQuery();
        factoryAction?.Invoke(namedQueryResult);

        return namedQueryResult;
    }

    private Humidifier.Athena.NamedQuery CreateNamedQuery()
    {
        var namedQueryResult = new Humidifier.Athena.NamedQuery
        {
            GivenName = InputResourceName,
        };

        return namedQueryResult;
    }

} // End Of Class

public static class NamedQueryFactoryExtensions
{
}
