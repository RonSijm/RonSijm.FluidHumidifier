// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ElastiCache;

public class SecurityGroupFactory(string resourceName = null, Action<Humidifier.ElastiCache.SecurityGroup> factoryAction = null) : ResourceFactory<Humidifier.ElastiCache.SecurityGroup>(resourceName)
{

    protected override Humidifier.ElastiCache.SecurityGroup Create()
    {
        var securityGroupResult = CreateSecurityGroup();
        factoryAction?.Invoke(securityGroupResult);

        return securityGroupResult;
    }

    private Humidifier.ElastiCache.SecurityGroup CreateSecurityGroup()
    {
        var securityGroupResult = new Humidifier.ElastiCache.SecurityGroup
        {
            GivenName = InputResourceName,
        };

        return securityGroupResult;
    }

} // End Of Class

public static class SecurityGroupFactoryExtensions
{
}
