// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTSiteWise;

public class InnerAccessPolicyIamUserFactory(Action<Humidifier.IoTSiteWise.AccessPolicyTypes.IamUser> factoryAction = null) : SubResourceFactory<Humidifier.IoTSiteWise.AccessPolicyTypes.IamUser>
{

    protected override Humidifier.IoTSiteWise.AccessPolicyTypes.IamUser Create()
    {
        var iamUserResult = CreateIamUser();
        factoryAction?.Invoke(iamUserResult);

        return iamUserResult;
    }

    private Humidifier.IoTSiteWise.AccessPolicyTypes.IamUser CreateIamUser()
    {
        var iamUserResult = new Humidifier.IoTSiteWise.AccessPolicyTypes.IamUser();

        return iamUserResult;
    }

} // End Of Class

public static class InnerAccessPolicyIamUserFactoryExtensions
{
}
