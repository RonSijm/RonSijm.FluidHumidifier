// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ElastiCache;

public class SecurityGroupIngressFactory(string resourceName = null, Action<Humidifier.ElastiCache.SecurityGroupIngress> factoryAction = null) : ResourceFactory<Humidifier.ElastiCache.SecurityGroupIngress>(resourceName)
{

    protected override Humidifier.ElastiCache.SecurityGroupIngress Create()
    {
        var securityGroupIngressResult = CreateSecurityGroupIngress();
        factoryAction?.Invoke(securityGroupIngressResult);

        return securityGroupIngressResult;
    }

    private Humidifier.ElastiCache.SecurityGroupIngress CreateSecurityGroupIngress()
    {
        var securityGroupIngressResult = new Humidifier.ElastiCache.SecurityGroupIngress
        {
            GivenName = InputResourceName,
        };

        return securityGroupIngressResult;
    }

} // End Of Class

public static class SecurityGroupIngressFactoryExtensions
{
}
