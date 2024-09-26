// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class SecurityGroupFactory(string resourceName = null, Action<Humidifier.EC2.SecurityGroup> factoryAction = null) : ResourceFactory<Humidifier.EC2.SecurityGroup>(resourceName)
{

    internal List<InnerSecurityGroupIngressFactory> SecurityGroupIngressFactories { get; set; } = [];

    internal List<InnerSecurityGroupEgressFactory> SecurityGroupEgressFactories { get; set; } = [];

    protected override Humidifier.EC2.SecurityGroup Create()
    {
        var securityGroupResult = CreateSecurityGroup();
        factoryAction?.Invoke(securityGroupResult);

        return securityGroupResult;
    }

    private Humidifier.EC2.SecurityGroup CreateSecurityGroup()
    {
        var securityGroupResult = new Humidifier.EC2.SecurityGroup
        {
            GivenName = InputResourceName,
        };

        return securityGroupResult;
    }
    public override void CreateChildren(Humidifier.EC2.SecurityGroup result)
    {
        base.CreateChildren(result);

        result.SecurityGroupIngress = SecurityGroupIngressFactories.Any() ? SecurityGroupIngressFactories.Select(x => x.Build()).ToList() : null;
        result.SecurityGroupEgress = SecurityGroupEgressFactories.Any() ? SecurityGroupEgressFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class SecurityGroupFactoryExtensions
{
    public static CombinedResult<SecurityGroupFactory, InnerSecurityGroupIngressFactory> WithSecurityGroupIngress(this SecurityGroupFactory parentFactory, Action<Humidifier.EC2.SecurityGroupTypes.Ingress> subFactoryAction = null)
    {
        var factory = new InnerSecurityGroupIngressFactory(subFactoryAction);
        parentFactory.SecurityGroupIngressFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<SecurityGroupFactory, InnerSecurityGroupEgressFactory> WithSecurityGroupEgress(this SecurityGroupFactory parentFactory, Action<Humidifier.EC2.SecurityGroupTypes.Egress> subFactoryAction = null)
    {
        var factory = new InnerSecurityGroupEgressFactory(subFactoryAction);
        parentFactory.SecurityGroupEgressFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<SecurityGroupFactory, T1, InnerSecurityGroupIngressFactory> WithSecurityGroupIngress<T1>(this CombinedResult<SecurityGroupFactory, T1> combinedResult, Action<Humidifier.EC2.SecurityGroupTypes.Ingress> subFactoryAction = null) => new (combinedResult, combinedResult, WithSecurityGroupIngress(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SecurityGroupFactory, InnerSecurityGroupIngressFactory> WithSecurityGroupIngress<T1>(this CombinedResult<T1, SecurityGroupFactory> combinedResult, Action<Humidifier.EC2.SecurityGroupTypes.Ingress> subFactoryAction = null) => new (combinedResult, combinedResult, WithSecurityGroupIngress(combinedResult.T2, subFactoryAction));
    public static CombinedResult<SecurityGroupFactory, T1, T2, InnerSecurityGroupIngressFactory> WithSecurityGroupIngress<T1, T2>(this CombinedResult<SecurityGroupFactory, T1, T2> combinedResult, Action<Humidifier.EC2.SecurityGroupTypes.Ingress> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSecurityGroupIngress(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SecurityGroupFactory, T2, InnerSecurityGroupIngressFactory> WithSecurityGroupIngress<T1, T2>(this CombinedResult<T1, SecurityGroupFactory, T2> combinedResult, Action<Humidifier.EC2.SecurityGroupTypes.Ingress> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSecurityGroupIngress(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SecurityGroupFactory, InnerSecurityGroupIngressFactory> WithSecurityGroupIngress<T1, T2>(this CombinedResult<T1, T2, SecurityGroupFactory> combinedResult, Action<Humidifier.EC2.SecurityGroupTypes.Ingress> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSecurityGroupIngress(combinedResult.T3, subFactoryAction));
    public static CombinedResult<SecurityGroupFactory, T1, T2, T3, InnerSecurityGroupIngressFactory> WithSecurityGroupIngress<T1, T2, T3>(this CombinedResult<SecurityGroupFactory, T1, T2, T3> combinedResult, Action<Humidifier.EC2.SecurityGroupTypes.Ingress> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSecurityGroupIngress(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SecurityGroupFactory, T2, T3, InnerSecurityGroupIngressFactory> WithSecurityGroupIngress<T1, T2, T3>(this CombinedResult<T1, SecurityGroupFactory, T2, T3> combinedResult, Action<Humidifier.EC2.SecurityGroupTypes.Ingress> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSecurityGroupIngress(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SecurityGroupFactory, T3, InnerSecurityGroupIngressFactory> WithSecurityGroupIngress<T1, T2, T3>(this CombinedResult<T1, T2, SecurityGroupFactory, T3> combinedResult, Action<Humidifier.EC2.SecurityGroupTypes.Ingress> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSecurityGroupIngress(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, SecurityGroupFactory, InnerSecurityGroupIngressFactory> WithSecurityGroupIngress<T1, T2, T3>(this CombinedResult<T1, T2, T3, SecurityGroupFactory> combinedResult, Action<Humidifier.EC2.SecurityGroupTypes.Ingress> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSecurityGroupIngress(combinedResult.T4, subFactoryAction));
    public static CombinedResult<SecurityGroupFactory, T1, T2, T3, T4, InnerSecurityGroupIngressFactory> WithSecurityGroupIngress<T1, T2, T3, T4>(this CombinedResult<SecurityGroupFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EC2.SecurityGroupTypes.Ingress> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSecurityGroupIngress(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SecurityGroupFactory, T2, T3, T4, InnerSecurityGroupIngressFactory> WithSecurityGroupIngress<T1, T2, T3, T4>(this CombinedResult<T1, SecurityGroupFactory, T2, T3, T4> combinedResult, Action<Humidifier.EC2.SecurityGroupTypes.Ingress> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSecurityGroupIngress(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SecurityGroupFactory, T3, T4, InnerSecurityGroupIngressFactory> WithSecurityGroupIngress<T1, T2, T3, T4>(this CombinedResult<T1, T2, SecurityGroupFactory, T3, T4> combinedResult, Action<Humidifier.EC2.SecurityGroupTypes.Ingress> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSecurityGroupIngress(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, SecurityGroupFactory, T4, InnerSecurityGroupIngressFactory> WithSecurityGroupIngress<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, SecurityGroupFactory, T4> combinedResult, Action<Humidifier.EC2.SecurityGroupTypes.Ingress> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSecurityGroupIngress(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, SecurityGroupFactory, InnerSecurityGroupIngressFactory> WithSecurityGroupIngress<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, SecurityGroupFactory> combinedResult, Action<Humidifier.EC2.SecurityGroupTypes.Ingress> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSecurityGroupIngress(combinedResult.T5, subFactoryAction));
    public static CombinedResult<SecurityGroupFactory, T1, InnerSecurityGroupEgressFactory> WithSecurityGroupEgress<T1>(this CombinedResult<SecurityGroupFactory, T1> combinedResult, Action<Humidifier.EC2.SecurityGroupTypes.Egress> subFactoryAction = null) => new (combinedResult, combinedResult, WithSecurityGroupEgress(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SecurityGroupFactory, InnerSecurityGroupEgressFactory> WithSecurityGroupEgress<T1>(this CombinedResult<T1, SecurityGroupFactory> combinedResult, Action<Humidifier.EC2.SecurityGroupTypes.Egress> subFactoryAction = null) => new (combinedResult, combinedResult, WithSecurityGroupEgress(combinedResult.T2, subFactoryAction));
    public static CombinedResult<SecurityGroupFactory, T1, T2, InnerSecurityGroupEgressFactory> WithSecurityGroupEgress<T1, T2>(this CombinedResult<SecurityGroupFactory, T1, T2> combinedResult, Action<Humidifier.EC2.SecurityGroupTypes.Egress> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSecurityGroupEgress(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SecurityGroupFactory, T2, InnerSecurityGroupEgressFactory> WithSecurityGroupEgress<T1, T2>(this CombinedResult<T1, SecurityGroupFactory, T2> combinedResult, Action<Humidifier.EC2.SecurityGroupTypes.Egress> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSecurityGroupEgress(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SecurityGroupFactory, InnerSecurityGroupEgressFactory> WithSecurityGroupEgress<T1, T2>(this CombinedResult<T1, T2, SecurityGroupFactory> combinedResult, Action<Humidifier.EC2.SecurityGroupTypes.Egress> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSecurityGroupEgress(combinedResult.T3, subFactoryAction));
    public static CombinedResult<SecurityGroupFactory, T1, T2, T3, InnerSecurityGroupEgressFactory> WithSecurityGroupEgress<T1, T2, T3>(this CombinedResult<SecurityGroupFactory, T1, T2, T3> combinedResult, Action<Humidifier.EC2.SecurityGroupTypes.Egress> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSecurityGroupEgress(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SecurityGroupFactory, T2, T3, InnerSecurityGroupEgressFactory> WithSecurityGroupEgress<T1, T2, T3>(this CombinedResult<T1, SecurityGroupFactory, T2, T3> combinedResult, Action<Humidifier.EC2.SecurityGroupTypes.Egress> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSecurityGroupEgress(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SecurityGroupFactory, T3, InnerSecurityGroupEgressFactory> WithSecurityGroupEgress<T1, T2, T3>(this CombinedResult<T1, T2, SecurityGroupFactory, T3> combinedResult, Action<Humidifier.EC2.SecurityGroupTypes.Egress> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSecurityGroupEgress(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, SecurityGroupFactory, InnerSecurityGroupEgressFactory> WithSecurityGroupEgress<T1, T2, T3>(this CombinedResult<T1, T2, T3, SecurityGroupFactory> combinedResult, Action<Humidifier.EC2.SecurityGroupTypes.Egress> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSecurityGroupEgress(combinedResult.T4, subFactoryAction));
    public static CombinedResult<SecurityGroupFactory, T1, T2, T3, T4, InnerSecurityGroupEgressFactory> WithSecurityGroupEgress<T1, T2, T3, T4>(this CombinedResult<SecurityGroupFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EC2.SecurityGroupTypes.Egress> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSecurityGroupEgress(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SecurityGroupFactory, T2, T3, T4, InnerSecurityGroupEgressFactory> WithSecurityGroupEgress<T1, T2, T3, T4>(this CombinedResult<T1, SecurityGroupFactory, T2, T3, T4> combinedResult, Action<Humidifier.EC2.SecurityGroupTypes.Egress> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSecurityGroupEgress(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SecurityGroupFactory, T3, T4, InnerSecurityGroupEgressFactory> WithSecurityGroupEgress<T1, T2, T3, T4>(this CombinedResult<T1, T2, SecurityGroupFactory, T3, T4> combinedResult, Action<Humidifier.EC2.SecurityGroupTypes.Egress> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSecurityGroupEgress(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, SecurityGroupFactory, T4, InnerSecurityGroupEgressFactory> WithSecurityGroupEgress<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, SecurityGroupFactory, T4> combinedResult, Action<Humidifier.EC2.SecurityGroupTypes.Egress> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSecurityGroupEgress(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, SecurityGroupFactory, InnerSecurityGroupEgressFactory> WithSecurityGroupEgress<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, SecurityGroupFactory> combinedResult, Action<Humidifier.EC2.SecurityGroupTypes.Egress> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSecurityGroupEgress(combinedResult.T5, subFactoryAction));
}
