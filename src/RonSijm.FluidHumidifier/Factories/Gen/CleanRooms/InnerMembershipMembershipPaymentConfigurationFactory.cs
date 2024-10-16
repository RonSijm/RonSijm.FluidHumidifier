// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CleanRooms;

public class InnerMembershipMembershipPaymentConfigurationFactory(Action<Humidifier.CleanRooms.MembershipTypes.MembershipPaymentConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.CleanRooms.MembershipTypes.MembershipPaymentConfiguration>
{

    internal InnerMembershipMembershipQueryComputePaymentConfigFactory QueryComputeFactory { get; set; }

    protected override Humidifier.CleanRooms.MembershipTypes.MembershipPaymentConfiguration Create()
    {
        var membershipPaymentConfigurationResult = CreateMembershipPaymentConfiguration();
        factoryAction?.Invoke(membershipPaymentConfigurationResult);

        return membershipPaymentConfigurationResult;
    }

    private Humidifier.CleanRooms.MembershipTypes.MembershipPaymentConfiguration CreateMembershipPaymentConfiguration()
    {
        var membershipPaymentConfigurationResult = new Humidifier.CleanRooms.MembershipTypes.MembershipPaymentConfiguration();

        return membershipPaymentConfigurationResult;
    }
    public override void CreateChildren(Humidifier.CleanRooms.MembershipTypes.MembershipPaymentConfiguration result)
    {
        base.CreateChildren(result);

        result.QueryCompute ??= QueryComputeFactory?.Build();
    }

} // End Of Class

public static class InnerMembershipMembershipPaymentConfigurationFactoryExtensions
{
    public static CombinedResult<InnerMembershipMembershipPaymentConfigurationFactory, InnerMembershipMembershipQueryComputePaymentConfigFactory> WithQueryCompute(this InnerMembershipMembershipPaymentConfigurationFactory parentFactory, Action<Humidifier.CleanRooms.MembershipTypes.MembershipQueryComputePaymentConfig> subFactoryAction = null)
    {
        parentFactory.QueryComputeFactory = new InnerMembershipMembershipQueryComputePaymentConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.QueryComputeFactory);
    }

    public static CombinedResult<InnerMembershipMembershipPaymentConfigurationFactory, T1, InnerMembershipMembershipQueryComputePaymentConfigFactory> WithQueryCompute<T1>(this CombinedResult<InnerMembershipMembershipPaymentConfigurationFactory, T1> combinedResult, Action<Humidifier.CleanRooms.MembershipTypes.MembershipQueryComputePaymentConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithQueryCompute(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerMembershipMembershipPaymentConfigurationFactory, InnerMembershipMembershipQueryComputePaymentConfigFactory> WithQueryCompute<T1>(this CombinedResult<T1, InnerMembershipMembershipPaymentConfigurationFactory> combinedResult, Action<Humidifier.CleanRooms.MembershipTypes.MembershipQueryComputePaymentConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithQueryCompute(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerMembershipMembershipPaymentConfigurationFactory, T1, T2, InnerMembershipMembershipQueryComputePaymentConfigFactory> WithQueryCompute<T1, T2>(this CombinedResult<InnerMembershipMembershipPaymentConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.CleanRooms.MembershipTypes.MembershipQueryComputePaymentConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithQueryCompute(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerMembershipMembershipPaymentConfigurationFactory, T2, InnerMembershipMembershipQueryComputePaymentConfigFactory> WithQueryCompute<T1, T2>(this CombinedResult<T1, InnerMembershipMembershipPaymentConfigurationFactory, T2> combinedResult, Action<Humidifier.CleanRooms.MembershipTypes.MembershipQueryComputePaymentConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithQueryCompute(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerMembershipMembershipPaymentConfigurationFactory, InnerMembershipMembershipQueryComputePaymentConfigFactory> WithQueryCompute<T1, T2>(this CombinedResult<T1, T2, InnerMembershipMembershipPaymentConfigurationFactory> combinedResult, Action<Humidifier.CleanRooms.MembershipTypes.MembershipQueryComputePaymentConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithQueryCompute(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerMembershipMembershipPaymentConfigurationFactory, T1, T2, T3, InnerMembershipMembershipQueryComputePaymentConfigFactory> WithQueryCompute<T1, T2, T3>(this CombinedResult<InnerMembershipMembershipPaymentConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.CleanRooms.MembershipTypes.MembershipQueryComputePaymentConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithQueryCompute(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerMembershipMembershipPaymentConfigurationFactory, T2, T3, InnerMembershipMembershipQueryComputePaymentConfigFactory> WithQueryCompute<T1, T2, T3>(this CombinedResult<T1, InnerMembershipMembershipPaymentConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.CleanRooms.MembershipTypes.MembershipQueryComputePaymentConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithQueryCompute(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerMembershipMembershipPaymentConfigurationFactory, T3, InnerMembershipMembershipQueryComputePaymentConfigFactory> WithQueryCompute<T1, T2, T3>(this CombinedResult<T1, T2, InnerMembershipMembershipPaymentConfigurationFactory, T3> combinedResult, Action<Humidifier.CleanRooms.MembershipTypes.MembershipQueryComputePaymentConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithQueryCompute(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerMembershipMembershipPaymentConfigurationFactory, InnerMembershipMembershipQueryComputePaymentConfigFactory> WithQueryCompute<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerMembershipMembershipPaymentConfigurationFactory> combinedResult, Action<Humidifier.CleanRooms.MembershipTypes.MembershipQueryComputePaymentConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithQueryCompute(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerMembershipMembershipPaymentConfigurationFactory, T1, T2, T3, T4, InnerMembershipMembershipQueryComputePaymentConfigFactory> WithQueryCompute<T1, T2, T3, T4>(this CombinedResult<InnerMembershipMembershipPaymentConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CleanRooms.MembershipTypes.MembershipQueryComputePaymentConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithQueryCompute(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerMembershipMembershipPaymentConfigurationFactory, T2, T3, T4, InnerMembershipMembershipQueryComputePaymentConfigFactory> WithQueryCompute<T1, T2, T3, T4>(this CombinedResult<T1, InnerMembershipMembershipPaymentConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.CleanRooms.MembershipTypes.MembershipQueryComputePaymentConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithQueryCompute(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerMembershipMembershipPaymentConfigurationFactory, T3, T4, InnerMembershipMembershipQueryComputePaymentConfigFactory> WithQueryCompute<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerMembershipMembershipPaymentConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.CleanRooms.MembershipTypes.MembershipQueryComputePaymentConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithQueryCompute(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerMembershipMembershipPaymentConfigurationFactory, T4, InnerMembershipMembershipQueryComputePaymentConfigFactory> WithQueryCompute<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerMembershipMembershipPaymentConfigurationFactory, T4> combinedResult, Action<Humidifier.CleanRooms.MembershipTypes.MembershipQueryComputePaymentConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithQueryCompute(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerMembershipMembershipPaymentConfigurationFactory, InnerMembershipMembershipQueryComputePaymentConfigFactory> WithQueryCompute<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerMembershipMembershipPaymentConfigurationFactory> combinedResult, Action<Humidifier.CleanRooms.MembershipTypes.MembershipQueryComputePaymentConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithQueryCompute(combinedResult.T5, subFactoryAction));
}
