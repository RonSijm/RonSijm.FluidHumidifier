// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Neptune;

public class InnerDBClusterDBClusterRoleFactory(Action<Humidifier.Neptune.DBClusterTypes.DBClusterRole> factoryAction = null) : SubResourceFactory<Humidifier.Neptune.DBClusterTypes.DBClusterRole>
{

    protected override Humidifier.Neptune.DBClusterTypes.DBClusterRole Create()
    {
        var dBClusterRoleResult = CreateDBClusterRole();
        factoryAction?.Invoke(dBClusterRoleResult);

        return dBClusterRoleResult;
    }

    private Humidifier.Neptune.DBClusterTypes.DBClusterRole CreateDBClusterRole()
    {
        var dBClusterRoleResult = new Humidifier.Neptune.DBClusterTypes.DBClusterRole();

        return dBClusterRoleResult;
    }

} // End Of Class

public static class InnerDBClusterDBClusterRoleFactoryExtensions
{
}
