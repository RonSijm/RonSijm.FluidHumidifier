// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerSecurityGroupIngressFactory(Action<Humidifier.EC2.SecurityGroupTypes.Ingress> factoryAction = null) : SubResourceFactory<Humidifier.EC2.SecurityGroupTypes.Ingress>
{

    protected override Humidifier.EC2.SecurityGroupTypes.Ingress Create()
    {
        var ingressResult = CreateIngress();
        factoryAction?.Invoke(ingressResult);

        return ingressResult;
    }

    private Humidifier.EC2.SecurityGroupTypes.Ingress CreateIngress()
    {
        var ingressResult = new Humidifier.EC2.SecurityGroupTypes.Ingress();

        return ingressResult;
    }

} // End Of Class

public static class InnerSecurityGroupIngressFactoryExtensions
{
}
