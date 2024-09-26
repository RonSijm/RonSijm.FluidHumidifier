// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.RDS;

public class DBSecurityGroupIngressFactory(string resourceName = null, Action<Humidifier.RDS.DBSecurityGroupIngress> factoryAction = null) : ResourceFactory<Humidifier.RDS.DBSecurityGroupIngress>(resourceName)
{

    protected override Humidifier.RDS.DBSecurityGroupIngress Create()
    {
        var dBSecurityGroupIngressResult = CreateDBSecurityGroupIngress();
        factoryAction?.Invoke(dBSecurityGroupIngressResult);

        return dBSecurityGroupIngressResult;
    }

    private Humidifier.RDS.DBSecurityGroupIngress CreateDBSecurityGroupIngress()
    {
        var dBSecurityGroupIngressResult = new Humidifier.RDS.DBSecurityGroupIngress
        {
            GivenName = InputResourceName,
        };

        return dBSecurityGroupIngressResult;
    }

} // End Of Class

public static class DBSecurityGroupIngressFactoryExtensions
{
}
