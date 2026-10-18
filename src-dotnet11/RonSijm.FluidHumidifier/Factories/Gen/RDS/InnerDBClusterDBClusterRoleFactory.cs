// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.RDS;

public class InnerDBClusterDBClusterRoleFactory(Action<Humidifier.RDS.DBClusterTypes.DBClusterRole> factoryAction = null) : SubResourceFactory<Humidifier.RDS.DBClusterTypes.DBClusterRole>
{

    protected override Humidifier.RDS.DBClusterTypes.DBClusterRole Create()
    {
        var dBClusterRoleResult = CreateDBClusterRole();
        factoryAction?.Invoke(dBClusterRoleResult);

        return dBClusterRoleResult;
    }

    private Humidifier.RDS.DBClusterTypes.DBClusterRole CreateDBClusterRole()
    {
        var dBClusterRoleResult = new Humidifier.RDS.DBClusterTypes.DBClusterRole();

        return dBClusterRoleResult;
    }

} // End Of Class

public static class InnerDBClusterDBClusterRoleFactoryExtensions
{
}
