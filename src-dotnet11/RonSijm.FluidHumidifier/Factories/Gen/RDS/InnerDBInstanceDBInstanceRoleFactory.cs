// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.RDS;

public class InnerDBInstanceDBInstanceRoleFactory(Action<Humidifier.RDS.DBInstanceTypes.DBInstanceRole> factoryAction = null) : SubResourceFactory<Humidifier.RDS.DBInstanceTypes.DBInstanceRole>
{

    protected override Humidifier.RDS.DBInstanceTypes.DBInstanceRole Create()
    {
        var dBInstanceRoleResult = CreateDBInstanceRole();
        factoryAction?.Invoke(dBInstanceRoleResult);

        return dBInstanceRoleResult;
    }

    private Humidifier.RDS.DBInstanceTypes.DBInstanceRole CreateDBInstanceRole()
    {
        var dBInstanceRoleResult = new Humidifier.RDS.DBInstanceTypes.DBInstanceRole();

        return dBInstanceRoleResult;
    }

} // End Of Class

public static class InnerDBInstanceDBInstanceRoleFactoryExtensions
{
}
