// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Neptune;

public class DBInstanceFactory(string resourceName = null, Action<Humidifier.Neptune.DBInstance> factoryAction = null) : ResourceFactory<Humidifier.Neptune.DBInstance>(resourceName)
{

    protected override Humidifier.Neptune.DBInstance Create()
    {
        var dBInstanceResult = CreateDBInstance();
        factoryAction?.Invoke(dBInstanceResult);

        return dBInstanceResult;
    }

    private Humidifier.Neptune.DBInstance CreateDBInstance()
    {
        var dBInstanceResult = new Humidifier.Neptune.DBInstance
        {
            GivenName = InputResourceName,
        };

        return dBInstanceResult;
    }

} // End Of Class

public static class DBInstanceFactoryExtensions
{
}
