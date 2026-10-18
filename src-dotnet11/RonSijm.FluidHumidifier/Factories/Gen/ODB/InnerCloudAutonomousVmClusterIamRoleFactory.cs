// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ODB;

public class InnerCloudAutonomousVmClusterIamRoleFactory(Action<Humidifier.ODB.CloudAutonomousVmClusterTypes.IamRole> factoryAction = null) : SubResourceFactory<Humidifier.ODB.CloudAutonomousVmClusterTypes.IamRole>
{

    protected override Humidifier.ODB.CloudAutonomousVmClusterTypes.IamRole Create()
    {
        var iamRoleResult = CreateIamRole();
        factoryAction?.Invoke(iamRoleResult);

        return iamRoleResult;
    }

    private Humidifier.ODB.CloudAutonomousVmClusterTypes.IamRole CreateIamRole()
    {
        var iamRoleResult = new Humidifier.ODB.CloudAutonomousVmClusterTypes.IamRole();

        return iamRoleResult;
    }

} // End Of Class

public static class InnerCloudAutonomousVmClusterIamRoleFactoryExtensions
{
}
