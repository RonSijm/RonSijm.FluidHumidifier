// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.RDS;

public class InnerDBSecurityGroupIngressFactory(Action<Humidifier.RDS.DBSecurityGroupTypes.Ingress> factoryAction = null) : SubResourceFactory<Humidifier.RDS.DBSecurityGroupTypes.Ingress>
{

    protected override Humidifier.RDS.DBSecurityGroupTypes.Ingress Create()
    {
        var ingressResult = CreateIngress();
        factoryAction?.Invoke(ingressResult);

        return ingressResult;
    }

    private Humidifier.RDS.DBSecurityGroupTypes.Ingress CreateIngress()
    {
        var ingressResult = new Humidifier.RDS.DBSecurityGroupTypes.Ingress();

        return ingressResult;
    }

} // End Of Class

public static class InnerDBSecurityGroupIngressFactoryExtensions
{
}
