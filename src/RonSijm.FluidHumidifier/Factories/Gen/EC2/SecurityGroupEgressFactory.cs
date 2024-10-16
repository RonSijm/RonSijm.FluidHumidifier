// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class SecurityGroupEgressFactory(string resourceName = null, Action<Humidifier.EC2.SecurityGroupEgress> factoryAction = null) : ResourceFactory<Humidifier.EC2.SecurityGroupEgress>(resourceName)
{

    protected override Humidifier.EC2.SecurityGroupEgress Create()
    {
        var securityGroupEgressResult = CreateSecurityGroupEgress();
        factoryAction?.Invoke(securityGroupEgressResult);

        return securityGroupEgressResult;
    }

    private Humidifier.EC2.SecurityGroupEgress CreateSecurityGroupEgress()
    {
        var securityGroupEgressResult = new Humidifier.EC2.SecurityGroupEgress
        {
            GivenName = InputResourceName,
        };

        return securityGroupEgressResult;
    }

} // End Of Class

public static class SecurityGroupEgressFactoryExtensions
{
}
