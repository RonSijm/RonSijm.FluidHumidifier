// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTSiteWise;

public class InnerAccessPolicyIamRoleFactory(Action<Humidifier.IoTSiteWise.AccessPolicyTypes.IamRole> factoryAction = null) : SubResourceFactory<Humidifier.IoTSiteWise.AccessPolicyTypes.IamRole>
{

    protected override Humidifier.IoTSiteWise.AccessPolicyTypes.IamRole Create()
    {
        var iamRoleResult = CreateIamRole();
        factoryAction?.Invoke(iamRoleResult);

        return iamRoleResult;
    }

    private Humidifier.IoTSiteWise.AccessPolicyTypes.IamRole CreateIamRole()
    {
        var iamRoleResult = new Humidifier.IoTSiteWise.AccessPolicyTypes.IamRole();

        return iamRoleResult;
    }

} // End Of Class

public static class InnerAccessPolicyIamRoleFactoryExtensions
{
}
