// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerSecurityGroupEgressFactory(Action<Humidifier.EC2.SecurityGroupTypes.Egress> factoryAction = null) : SubResourceFactory<Humidifier.EC2.SecurityGroupTypes.Egress>
{

    protected override Humidifier.EC2.SecurityGroupTypes.Egress Create()
    {
        var egressResult = CreateEgress();
        factoryAction?.Invoke(egressResult);

        return egressResult;
    }

    private Humidifier.EC2.SecurityGroupTypes.Egress CreateEgress()
    {
        var egressResult = new Humidifier.EC2.SecurityGroupTypes.Egress();

        return egressResult;
    }

} // End Of Class

public static class InnerSecurityGroupEgressFactoryExtensions
{
}
