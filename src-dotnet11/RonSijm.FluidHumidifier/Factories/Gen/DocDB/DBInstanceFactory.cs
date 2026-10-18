// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DocDB;

public class DBInstanceFactory(string resourceName = null, Action<Humidifier.DocDB.DBInstance> factoryAction = null) : ResourceFactory<Humidifier.DocDB.DBInstance>(resourceName)
{

    protected override Humidifier.DocDB.DBInstance Create()
    {
        var dBInstanceResult = CreateDBInstance();
        factoryAction?.Invoke(dBInstanceResult);

        return dBInstanceResult;
    }

    private Humidifier.DocDB.DBInstance CreateDBInstance()
    {
        var dBInstanceResult = new Humidifier.DocDB.DBInstance
        {
            GivenName = InputResourceName,
        };

        return dBInstanceResult;
    }

} // End Of Class

public static class DBInstanceFactoryExtensions
{
}
