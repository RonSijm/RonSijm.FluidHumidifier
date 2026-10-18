// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.RDS;

public class ReservedDBInstanceFactory(string resourceName = null, Action<Humidifier.RDS.ReservedDBInstance> factoryAction = null) : ResourceFactory<Humidifier.RDS.ReservedDBInstance>(resourceName)
{

    protected override Humidifier.RDS.ReservedDBInstance Create()
    {
        var reservedDBInstanceResult = CreateReservedDBInstance();
        factoryAction?.Invoke(reservedDBInstanceResult);

        return reservedDBInstanceResult;
    }

    private Humidifier.RDS.ReservedDBInstance CreateReservedDBInstance()
    {
        var reservedDBInstanceResult = new Humidifier.RDS.ReservedDBInstance
        {
            GivenName = InputResourceName,
        };

        return reservedDBInstanceResult;
    }

} // End Of Class

public static class ReservedDBInstanceFactoryExtensions
{
}
