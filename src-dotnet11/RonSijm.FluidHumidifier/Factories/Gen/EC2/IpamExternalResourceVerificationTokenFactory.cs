// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class IpamExternalResourceVerificationTokenFactory(string resourceName = null, Action<Humidifier.EC2.IpamExternalResourceVerificationToken> factoryAction = null) : ResourceFactory<Humidifier.EC2.IpamExternalResourceVerificationToken>(resourceName)
{

    protected override Humidifier.EC2.IpamExternalResourceVerificationToken Create()
    {
        var ipamExternalResourceVerificationTokenResult = CreateIpamExternalResourceVerificationToken();
        factoryAction?.Invoke(ipamExternalResourceVerificationTokenResult);

        return ipamExternalResourceVerificationTokenResult;
    }

    private Humidifier.EC2.IpamExternalResourceVerificationToken CreateIpamExternalResourceVerificationToken()
    {
        var ipamExternalResourceVerificationTokenResult = new Humidifier.EC2.IpamExternalResourceVerificationToken
        {
            GivenName = InputResourceName,
        };

        return ipamExternalResourceVerificationTokenResult;
    }

} // End Of Class

public static class IpamExternalResourceVerificationTokenFactoryExtensions
{
}
