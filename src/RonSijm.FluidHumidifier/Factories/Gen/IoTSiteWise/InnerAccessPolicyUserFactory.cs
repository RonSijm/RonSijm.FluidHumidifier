// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTSiteWise;

public class InnerAccessPolicyUserFactory(Action<Humidifier.IoTSiteWise.AccessPolicyTypes.User> factoryAction = null) : SubResourceFactory<Humidifier.IoTSiteWise.AccessPolicyTypes.User>
{

    protected override Humidifier.IoTSiteWise.AccessPolicyTypes.User Create()
    {
        var userResult = CreateUser();
        factoryAction?.Invoke(userResult);

        return userResult;
    }

    private Humidifier.IoTSiteWise.AccessPolicyTypes.User CreateUser()
    {
        var userResult = new Humidifier.IoTSiteWise.AccessPolicyTypes.User();

        return userResult;
    }

} // End Of Class

public static class InnerAccessPolicyUserFactoryExtensions
{
}
