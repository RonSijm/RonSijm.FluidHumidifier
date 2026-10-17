// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ODB;

public class InnerCloudVmClusterIamRoleFactory(Action<Humidifier.ODB.CloudVmClusterTypes.IamRole> factoryAction = null) : SubResourceFactory<Humidifier.ODB.CloudVmClusterTypes.IamRole>
{

    protected override Humidifier.ODB.CloudVmClusterTypes.IamRole Create()
    {
        var iamRoleResult = CreateIamRole();
        factoryAction?.Invoke(iamRoleResult);

        return iamRoleResult;
    }

    private Humidifier.ODB.CloudVmClusterTypes.IamRole CreateIamRole()
    {
        var iamRoleResult = new Humidifier.ODB.CloudVmClusterTypes.IamRole();

        return iamRoleResult;
    }

} // End Of Class

public static class InnerCloudVmClusterIamRoleFactoryExtensions
{
}
