// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.RDS;

public class DBSecurityGroupFactory(string resourceName = null, Action<Humidifier.RDS.DBSecurityGroup> factoryAction = null) : ResourceFactory<Humidifier.RDS.DBSecurityGroup>(resourceName)
{

    internal List<InnerDBSecurityGroupIngressFactory> DBSecurityGroupIngressFactories { get; set; } = [];

    protected override Humidifier.RDS.DBSecurityGroup Create()
    {
        var dBSecurityGroupResult = CreateDBSecurityGroup();
        factoryAction?.Invoke(dBSecurityGroupResult);

        return dBSecurityGroupResult;
    }

    private Humidifier.RDS.DBSecurityGroup CreateDBSecurityGroup()
    {
        var dBSecurityGroupResult = new Humidifier.RDS.DBSecurityGroup
        {
            GivenName = InputResourceName,
        };

        return dBSecurityGroupResult;
    }
    public override void CreateChildren(Humidifier.RDS.DBSecurityGroup result)
    {
        base.CreateChildren(result);

        result.DBSecurityGroupIngress = DBSecurityGroupIngressFactories.Any() ? DBSecurityGroupIngressFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class DBSecurityGroupFactoryExtensions
{
    public static CombinedResult<DBSecurityGroupFactory, InnerDBSecurityGroupIngressFactory> WithDBSecurityGroupIngress(this DBSecurityGroupFactory parentFactory, Action<Humidifier.RDS.DBSecurityGroupTypes.Ingress> subFactoryAction = null)
    {
        var factory = new InnerDBSecurityGroupIngressFactory(subFactoryAction);
        parentFactory.DBSecurityGroupIngressFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<DBSecurityGroupFactory, T1, InnerDBSecurityGroupIngressFactory> WithDBSecurityGroupIngress<T1>(this CombinedResult<DBSecurityGroupFactory, T1> combinedResult, Action<Humidifier.RDS.DBSecurityGroupTypes.Ingress> subFactoryAction = null) => new (combinedResult, combinedResult, WithDBSecurityGroupIngress(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DBSecurityGroupFactory, InnerDBSecurityGroupIngressFactory> WithDBSecurityGroupIngress<T1>(this CombinedResult<T1, DBSecurityGroupFactory> combinedResult, Action<Humidifier.RDS.DBSecurityGroupTypes.Ingress> subFactoryAction = null) => new (combinedResult, combinedResult, WithDBSecurityGroupIngress(combinedResult.T2, subFactoryAction));
    public static CombinedResult<DBSecurityGroupFactory, T1, T2, InnerDBSecurityGroupIngressFactory> WithDBSecurityGroupIngress<T1, T2>(this CombinedResult<DBSecurityGroupFactory, T1, T2> combinedResult, Action<Humidifier.RDS.DBSecurityGroupTypes.Ingress> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDBSecurityGroupIngress(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DBSecurityGroupFactory, T2, InnerDBSecurityGroupIngressFactory> WithDBSecurityGroupIngress<T1, T2>(this CombinedResult<T1, DBSecurityGroupFactory, T2> combinedResult, Action<Humidifier.RDS.DBSecurityGroupTypes.Ingress> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDBSecurityGroupIngress(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DBSecurityGroupFactory, InnerDBSecurityGroupIngressFactory> WithDBSecurityGroupIngress<T1, T2>(this CombinedResult<T1, T2, DBSecurityGroupFactory> combinedResult, Action<Humidifier.RDS.DBSecurityGroupTypes.Ingress> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDBSecurityGroupIngress(combinedResult.T3, subFactoryAction));
    public static CombinedResult<DBSecurityGroupFactory, T1, T2, T3, InnerDBSecurityGroupIngressFactory> WithDBSecurityGroupIngress<T1, T2, T3>(this CombinedResult<DBSecurityGroupFactory, T1, T2, T3> combinedResult, Action<Humidifier.RDS.DBSecurityGroupTypes.Ingress> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDBSecurityGroupIngress(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DBSecurityGroupFactory, T2, T3, InnerDBSecurityGroupIngressFactory> WithDBSecurityGroupIngress<T1, T2, T3>(this CombinedResult<T1, DBSecurityGroupFactory, T2, T3> combinedResult, Action<Humidifier.RDS.DBSecurityGroupTypes.Ingress> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDBSecurityGroupIngress(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DBSecurityGroupFactory, T3, InnerDBSecurityGroupIngressFactory> WithDBSecurityGroupIngress<T1, T2, T3>(this CombinedResult<T1, T2, DBSecurityGroupFactory, T3> combinedResult, Action<Humidifier.RDS.DBSecurityGroupTypes.Ingress> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDBSecurityGroupIngress(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DBSecurityGroupFactory, InnerDBSecurityGroupIngressFactory> WithDBSecurityGroupIngress<T1, T2, T3>(this CombinedResult<T1, T2, T3, DBSecurityGroupFactory> combinedResult, Action<Humidifier.RDS.DBSecurityGroupTypes.Ingress> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDBSecurityGroupIngress(combinedResult.T4, subFactoryAction));
    public static CombinedResult<DBSecurityGroupFactory, T1, T2, T3, T4, InnerDBSecurityGroupIngressFactory> WithDBSecurityGroupIngress<T1, T2, T3, T4>(this CombinedResult<DBSecurityGroupFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.RDS.DBSecurityGroupTypes.Ingress> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDBSecurityGroupIngress(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DBSecurityGroupFactory, T2, T3, T4, InnerDBSecurityGroupIngressFactory> WithDBSecurityGroupIngress<T1, T2, T3, T4>(this CombinedResult<T1, DBSecurityGroupFactory, T2, T3, T4> combinedResult, Action<Humidifier.RDS.DBSecurityGroupTypes.Ingress> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDBSecurityGroupIngress(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DBSecurityGroupFactory, T3, T4, InnerDBSecurityGroupIngressFactory> WithDBSecurityGroupIngress<T1, T2, T3, T4>(this CombinedResult<T1, T2, DBSecurityGroupFactory, T3, T4> combinedResult, Action<Humidifier.RDS.DBSecurityGroupTypes.Ingress> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDBSecurityGroupIngress(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DBSecurityGroupFactory, T4, InnerDBSecurityGroupIngressFactory> WithDBSecurityGroupIngress<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, DBSecurityGroupFactory, T4> combinedResult, Action<Humidifier.RDS.DBSecurityGroupTypes.Ingress> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDBSecurityGroupIngress(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, DBSecurityGroupFactory, InnerDBSecurityGroupIngressFactory> WithDBSecurityGroupIngress<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, DBSecurityGroupFactory> combinedResult, Action<Humidifier.RDS.DBSecurityGroupTypes.Ingress> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDBSecurityGroupIngress(combinedResult.T5, subFactoryAction));
}
