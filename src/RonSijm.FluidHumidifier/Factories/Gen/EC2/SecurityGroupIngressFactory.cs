// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class SecurityGroupIngressFactory(string resourceName = null, Action<Humidifier.EC2.SecurityGroupIngress> factoryAction = null) : ResourceFactory<Humidifier.EC2.SecurityGroupIngress>(resourceName)
{

    protected override Humidifier.EC2.SecurityGroupIngress Create()
    {
        var securityGroupIngressResult = CreateSecurityGroupIngress();
        factoryAction?.Invoke(securityGroupIngressResult);

        return securityGroupIngressResult;
    }

    private Humidifier.EC2.SecurityGroupIngress CreateSecurityGroupIngress()
    {
        var securityGroupIngressResult = new Humidifier.EC2.SecurityGroupIngress
        {
            GivenName = InputResourceName,
        };

        return securityGroupIngressResult;
    }

} // End Of Class

public static class SecurityGroupIngressFactoryExtensions
{
}
