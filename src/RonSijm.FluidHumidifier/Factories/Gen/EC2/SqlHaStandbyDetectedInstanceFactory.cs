// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class SqlHaStandbyDetectedInstanceFactory(string resourceName = null, Action<Humidifier.EC2.SqlHaStandbyDetectedInstance> factoryAction = null) : ResourceFactory<Humidifier.EC2.SqlHaStandbyDetectedInstance>(resourceName)
{

    protected override Humidifier.EC2.SqlHaStandbyDetectedInstance Create()
    {
        var sqlHaStandbyDetectedInstanceResult = CreateSqlHaStandbyDetectedInstance();
        factoryAction?.Invoke(sqlHaStandbyDetectedInstanceResult);

        return sqlHaStandbyDetectedInstanceResult;
    }

    private Humidifier.EC2.SqlHaStandbyDetectedInstance CreateSqlHaStandbyDetectedInstance()
    {
        var sqlHaStandbyDetectedInstanceResult = new Humidifier.EC2.SqlHaStandbyDetectedInstance
        {
            GivenName = InputResourceName,
        };

        return sqlHaStandbyDetectedInstanceResult;
    }

} // End Of Class

public static class SqlHaStandbyDetectedInstanceFactoryExtensions
{
}
