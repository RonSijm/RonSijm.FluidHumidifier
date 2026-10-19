// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SES;

public class InnerTenantReputationEntityFactory(Action<Humidifier.SES.TenantTypes.ReputationEntity> factoryAction = null) : SubResourceFactory<Humidifier.SES.TenantTypes.ReputationEntity>
{

    internal InnerTenantReputationPolicyFactory PolicyFactory { get; set; }

    protected override Humidifier.SES.TenantTypes.ReputationEntity Create()
    {
        var reputationEntityResult = CreateReputationEntity();
        factoryAction?.Invoke(reputationEntityResult);

        return reputationEntityResult;
    }

    private Humidifier.SES.TenantTypes.ReputationEntity CreateReputationEntity()
    {
        var reputationEntityResult = new Humidifier.SES.TenantTypes.ReputationEntity();

        return reputationEntityResult;
    }
    public override void CreateChildren(Humidifier.SES.TenantTypes.ReputationEntity result)
    {
        base.CreateChildren(result);

        result.Policy ??= PolicyFactory?.Build();
    }

} // End Of Class

public static class InnerTenantReputationEntityFactoryExtensions
{
    public static CombinedResult<InnerTenantReputationEntityFactory, InnerTenantReputationPolicyFactory> WithPolicy(this InnerTenantReputationEntityFactory parentFactory, Action<Humidifier.SES.TenantTypes.ReputationPolicy> subFactoryAction = null)
    {
        parentFactory.PolicyFactory = new InnerTenantReputationPolicyFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.PolicyFactory);
    }

    public static CombinedResult<InnerTenantReputationEntityFactory, T1, InnerTenantReputationPolicyFactory> WithPolicy<T1>(this CombinedResult<InnerTenantReputationEntityFactory, T1> combinedResult, Action<Humidifier.SES.TenantTypes.ReputationPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, WithPolicy(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerTenantReputationEntityFactory, InnerTenantReputationPolicyFactory> WithPolicy<T1>(this CombinedResult<T1, InnerTenantReputationEntityFactory> combinedResult, Action<Humidifier.SES.TenantTypes.ReputationPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, WithPolicy(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerTenantReputationEntityFactory, T1, T2, InnerTenantReputationPolicyFactory> WithPolicy<T1, T2>(this CombinedResult<InnerTenantReputationEntityFactory, T1, T2> combinedResult, Action<Humidifier.SES.TenantTypes.ReputationPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPolicy(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerTenantReputationEntityFactory, T2, InnerTenantReputationPolicyFactory> WithPolicy<T1, T2>(this CombinedResult<T1, InnerTenantReputationEntityFactory, T2> combinedResult, Action<Humidifier.SES.TenantTypes.ReputationPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPolicy(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerTenantReputationEntityFactory, InnerTenantReputationPolicyFactory> WithPolicy<T1, T2>(this CombinedResult<T1, T2, InnerTenantReputationEntityFactory> combinedResult, Action<Humidifier.SES.TenantTypes.ReputationPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPolicy(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerTenantReputationEntityFactory, T1, T2, T3, InnerTenantReputationPolicyFactory> WithPolicy<T1, T2, T3>(this CombinedResult<InnerTenantReputationEntityFactory, T1, T2, T3> combinedResult, Action<Humidifier.SES.TenantTypes.ReputationPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPolicy(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerTenantReputationEntityFactory, T2, T3, InnerTenantReputationPolicyFactory> WithPolicy<T1, T2, T3>(this CombinedResult<T1, InnerTenantReputationEntityFactory, T2, T3> combinedResult, Action<Humidifier.SES.TenantTypes.ReputationPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPolicy(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerTenantReputationEntityFactory, T3, InnerTenantReputationPolicyFactory> WithPolicy<T1, T2, T3>(this CombinedResult<T1, T2, InnerTenantReputationEntityFactory, T3> combinedResult, Action<Humidifier.SES.TenantTypes.ReputationPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPolicy(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerTenantReputationEntityFactory, InnerTenantReputationPolicyFactory> WithPolicy<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerTenantReputationEntityFactory> combinedResult, Action<Humidifier.SES.TenantTypes.ReputationPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPolicy(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerTenantReputationEntityFactory, T1, T2, T3, T4, InnerTenantReputationPolicyFactory> WithPolicy<T1, T2, T3, T4>(this CombinedResult<InnerTenantReputationEntityFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SES.TenantTypes.ReputationPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPolicy(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerTenantReputationEntityFactory, T2, T3, T4, InnerTenantReputationPolicyFactory> WithPolicy<T1, T2, T3, T4>(this CombinedResult<T1, InnerTenantReputationEntityFactory, T2, T3, T4> combinedResult, Action<Humidifier.SES.TenantTypes.ReputationPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPolicy(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerTenantReputationEntityFactory, T3, T4, InnerTenantReputationPolicyFactory> WithPolicy<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerTenantReputationEntityFactory, T3, T4> combinedResult, Action<Humidifier.SES.TenantTypes.ReputationPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPolicy(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerTenantReputationEntityFactory, T4, InnerTenantReputationPolicyFactory> WithPolicy<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerTenantReputationEntityFactory, T4> combinedResult, Action<Humidifier.SES.TenantTypes.ReputationPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPolicy(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerTenantReputationEntityFactory, InnerTenantReputationPolicyFactory> WithPolicy<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerTenantReputationEntityFactory> combinedResult, Action<Humidifier.SES.TenantTypes.ReputationPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPolicy(combinedResult.T5, subFactoryAction).T2);
}
