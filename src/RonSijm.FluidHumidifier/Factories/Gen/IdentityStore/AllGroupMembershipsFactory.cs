// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IdentityStore;

public class AllGroupMembershipsFactory(string resourceName = null, Action<Humidifier.IdentityStore.AllGroupMemberships> factoryAction = null) : ResourceFactory<Humidifier.IdentityStore.AllGroupMemberships>(resourceName)
{

    internal InnerAllGroupMembershipsMemberIdFactory MemberIdFactory { get; set; }

    protected override Humidifier.IdentityStore.AllGroupMemberships Create()
    {
        var allGroupMembershipsResult = CreateAllGroupMemberships();
        factoryAction?.Invoke(allGroupMembershipsResult);

        return allGroupMembershipsResult;
    }

    private Humidifier.IdentityStore.AllGroupMemberships CreateAllGroupMemberships()
    {
        var allGroupMembershipsResult = new Humidifier.IdentityStore.AllGroupMemberships
        {
            GivenName = InputResourceName,
        };

        return allGroupMembershipsResult;
    }
    public override void CreateChildren(Humidifier.IdentityStore.AllGroupMemberships result)
    {
        base.CreateChildren(result);

        result.MemberId ??= MemberIdFactory?.Build();
    }

} // End Of Class

public static class AllGroupMembershipsFactoryExtensions
{
    public static CombinedResult<AllGroupMembershipsFactory, InnerAllGroupMembershipsMemberIdFactory> WithMemberId(this AllGroupMembershipsFactory parentFactory, Action<Humidifier.IdentityStore.AllGroupMembershipsTypes.MemberId> subFactoryAction = null)
    {
        parentFactory.MemberIdFactory = new InnerAllGroupMembershipsMemberIdFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.MemberIdFactory);
    }

    public static CombinedResult<AllGroupMembershipsFactory, T1, InnerAllGroupMembershipsMemberIdFactory> WithMemberId<T1>(this CombinedResult<AllGroupMembershipsFactory, T1> combinedResult, Action<Humidifier.IdentityStore.AllGroupMembershipsTypes.MemberId> subFactoryAction = null) => new (combinedResult, combinedResult, WithMemberId(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AllGroupMembershipsFactory, InnerAllGroupMembershipsMemberIdFactory> WithMemberId<T1>(this CombinedResult<T1, AllGroupMembershipsFactory> combinedResult, Action<Humidifier.IdentityStore.AllGroupMembershipsTypes.MemberId> subFactoryAction = null) => new (combinedResult, combinedResult, WithMemberId(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<AllGroupMembershipsFactory, T1, T2, InnerAllGroupMembershipsMemberIdFactory> WithMemberId<T1, T2>(this CombinedResult<AllGroupMembershipsFactory, T1, T2> combinedResult, Action<Humidifier.IdentityStore.AllGroupMembershipsTypes.MemberId> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMemberId(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AllGroupMembershipsFactory, T2, InnerAllGroupMembershipsMemberIdFactory> WithMemberId<T1, T2>(this CombinedResult<T1, AllGroupMembershipsFactory, T2> combinedResult, Action<Humidifier.IdentityStore.AllGroupMembershipsTypes.MemberId> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMemberId(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AllGroupMembershipsFactory, InnerAllGroupMembershipsMemberIdFactory> WithMemberId<T1, T2>(this CombinedResult<T1, T2, AllGroupMembershipsFactory> combinedResult, Action<Humidifier.IdentityStore.AllGroupMembershipsTypes.MemberId> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMemberId(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<AllGroupMembershipsFactory, T1, T2, T3, InnerAllGroupMembershipsMemberIdFactory> WithMemberId<T1, T2, T3>(this CombinedResult<AllGroupMembershipsFactory, T1, T2, T3> combinedResult, Action<Humidifier.IdentityStore.AllGroupMembershipsTypes.MemberId> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMemberId(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AllGroupMembershipsFactory, T2, T3, InnerAllGroupMembershipsMemberIdFactory> WithMemberId<T1, T2, T3>(this CombinedResult<T1, AllGroupMembershipsFactory, T2, T3> combinedResult, Action<Humidifier.IdentityStore.AllGroupMembershipsTypes.MemberId> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMemberId(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AllGroupMembershipsFactory, T3, InnerAllGroupMembershipsMemberIdFactory> WithMemberId<T1, T2, T3>(this CombinedResult<T1, T2, AllGroupMembershipsFactory, T3> combinedResult, Action<Humidifier.IdentityStore.AllGroupMembershipsTypes.MemberId> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMemberId(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, AllGroupMembershipsFactory, InnerAllGroupMembershipsMemberIdFactory> WithMemberId<T1, T2, T3>(this CombinedResult<T1, T2, T3, AllGroupMembershipsFactory> combinedResult, Action<Humidifier.IdentityStore.AllGroupMembershipsTypes.MemberId> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMemberId(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<AllGroupMembershipsFactory, T1, T2, T3, T4, InnerAllGroupMembershipsMemberIdFactory> WithMemberId<T1, T2, T3, T4>(this CombinedResult<AllGroupMembershipsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IdentityStore.AllGroupMembershipsTypes.MemberId> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMemberId(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AllGroupMembershipsFactory, T2, T3, T4, InnerAllGroupMembershipsMemberIdFactory> WithMemberId<T1, T2, T3, T4>(this CombinedResult<T1, AllGroupMembershipsFactory, T2, T3, T4> combinedResult, Action<Humidifier.IdentityStore.AllGroupMembershipsTypes.MemberId> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMemberId(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AllGroupMembershipsFactory, T3, T4, InnerAllGroupMembershipsMemberIdFactory> WithMemberId<T1, T2, T3, T4>(this CombinedResult<T1, T2, AllGroupMembershipsFactory, T3, T4> combinedResult, Action<Humidifier.IdentityStore.AllGroupMembershipsTypes.MemberId> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMemberId(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, AllGroupMembershipsFactory, T4, InnerAllGroupMembershipsMemberIdFactory> WithMemberId<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, AllGroupMembershipsFactory, T4> combinedResult, Action<Humidifier.IdentityStore.AllGroupMembershipsTypes.MemberId> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMemberId(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, AllGroupMembershipsFactory, InnerAllGroupMembershipsMemberIdFactory> WithMemberId<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, AllGroupMembershipsFactory> combinedResult, Action<Humidifier.IdentityStore.AllGroupMembershipsTypes.MemberId> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMemberId(combinedResult.T5, subFactoryAction).T2);
}
