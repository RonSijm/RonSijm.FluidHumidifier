// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ResourceGroups;

public class InnerGroupQueryFactory(Action<Humidifier.ResourceGroups.GroupTypes.Query> factoryAction = null) : SubResourceFactory<Humidifier.ResourceGroups.GroupTypes.Query>
{

    protected override Humidifier.ResourceGroups.GroupTypes.Query Create()
    {
        var queryResult = CreateQuery();
        factoryAction?.Invoke(queryResult);

        return queryResult;
    }

    private Humidifier.ResourceGroups.GroupTypes.Query CreateQuery()
    {
        var queryResult = new Humidifier.ResourceGroups.GroupTypes.Query();

        return queryResult;
    }

} // End Of Class

public static class InnerGroupQueryFactoryExtensions
{
}
