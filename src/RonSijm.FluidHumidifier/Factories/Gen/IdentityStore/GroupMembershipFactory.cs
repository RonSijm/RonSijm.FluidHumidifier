// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IdentityStore;

public class GroupMembershipFactory(string resourceName = null, Action<Humidifier.IdentityStore.GroupMembership> factoryAction = null) : ResourceFactory<Humidifier.IdentityStore.GroupMembership>(resourceName)
{

    internal InnerGroupMembershipMemberIdFactory MemberIdFactory { get; set; }

    protected override Humidifier.IdentityStore.GroupMembership Create()
    {
        var groupMembershipResult = CreateGroupMembership();
        factoryAction?.Invoke(groupMembershipResult);

        return groupMembershipResult;
    }

    private Humidifier.IdentityStore.GroupMembership CreateGroupMembership()
    {
        var groupMembershipResult = new Humidifier.IdentityStore.GroupMembership
        {
            GivenName = InputResourceName,
        };

        return groupMembershipResult;
    }
    public override void CreateChildren(Humidifier.IdentityStore.GroupMembership result)
    {
        base.CreateChildren(result);

        result.MemberId ??= MemberIdFactory?.Build();
    }

} // End Of Class

public static class GroupMembershipFactoryExtensions
{
    public static CombinedResult<GroupMembershipFactory, InnerGroupMembershipMemberIdFactory> WithMemberId(this GroupMembershipFactory parentFactory, Action<Humidifier.IdentityStore.GroupMembershipTypes.MemberId> subFactoryAction = null)
    {
        parentFactory.MemberIdFactory = new InnerGroupMembershipMemberIdFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.MemberIdFactory);
    }

    public static CombinedResult<GroupMembershipFactory, T1, InnerGroupMembershipMemberIdFactory> WithMemberId<T1>(this CombinedResult<GroupMembershipFactory, T1> combinedResult, Action<Humidifier.IdentityStore.GroupMembershipTypes.MemberId> subFactoryAction = null) => new (combinedResult, combinedResult, WithMemberId(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, GroupMembershipFactory, InnerGroupMembershipMemberIdFactory> WithMemberId<T1>(this CombinedResult<T1, GroupMembershipFactory> combinedResult, Action<Humidifier.IdentityStore.GroupMembershipTypes.MemberId> subFactoryAction = null) => new (combinedResult, combinedResult, WithMemberId(combinedResult.T2, subFactoryAction));
    public static CombinedResult<GroupMembershipFactory, T1, T2, InnerGroupMembershipMemberIdFactory> WithMemberId<T1, T2>(this CombinedResult<GroupMembershipFactory, T1, T2> combinedResult, Action<Humidifier.IdentityStore.GroupMembershipTypes.MemberId> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMemberId(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, GroupMembershipFactory, T2, InnerGroupMembershipMemberIdFactory> WithMemberId<T1, T2>(this CombinedResult<T1, GroupMembershipFactory, T2> combinedResult, Action<Humidifier.IdentityStore.GroupMembershipTypes.MemberId> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMemberId(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, GroupMembershipFactory, InnerGroupMembershipMemberIdFactory> WithMemberId<T1, T2>(this CombinedResult<T1, T2, GroupMembershipFactory> combinedResult, Action<Humidifier.IdentityStore.GroupMembershipTypes.MemberId> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMemberId(combinedResult.T3, subFactoryAction));
    public static CombinedResult<GroupMembershipFactory, T1, T2, T3, InnerGroupMembershipMemberIdFactory> WithMemberId<T1, T2, T3>(this CombinedResult<GroupMembershipFactory, T1, T2, T3> combinedResult, Action<Humidifier.IdentityStore.GroupMembershipTypes.MemberId> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMemberId(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, GroupMembershipFactory, T2, T3, InnerGroupMembershipMemberIdFactory> WithMemberId<T1, T2, T3>(this CombinedResult<T1, GroupMembershipFactory, T2, T3> combinedResult, Action<Humidifier.IdentityStore.GroupMembershipTypes.MemberId> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMemberId(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, GroupMembershipFactory, T3, InnerGroupMembershipMemberIdFactory> WithMemberId<T1, T2, T3>(this CombinedResult<T1, T2, GroupMembershipFactory, T3> combinedResult, Action<Humidifier.IdentityStore.GroupMembershipTypes.MemberId> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMemberId(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, GroupMembershipFactory, InnerGroupMembershipMemberIdFactory> WithMemberId<T1, T2, T3>(this CombinedResult<T1, T2, T3, GroupMembershipFactory> combinedResult, Action<Humidifier.IdentityStore.GroupMembershipTypes.MemberId> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMemberId(combinedResult.T4, subFactoryAction));
    public static CombinedResult<GroupMembershipFactory, T1, T2, T3, T4, InnerGroupMembershipMemberIdFactory> WithMemberId<T1, T2, T3, T4>(this CombinedResult<GroupMembershipFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IdentityStore.GroupMembershipTypes.MemberId> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMemberId(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, GroupMembershipFactory, T2, T3, T4, InnerGroupMembershipMemberIdFactory> WithMemberId<T1, T2, T3, T4>(this CombinedResult<T1, GroupMembershipFactory, T2, T3, T4> combinedResult, Action<Humidifier.IdentityStore.GroupMembershipTypes.MemberId> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMemberId(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, GroupMembershipFactory, T3, T4, InnerGroupMembershipMemberIdFactory> WithMemberId<T1, T2, T3, T4>(this CombinedResult<T1, T2, GroupMembershipFactory, T3, T4> combinedResult, Action<Humidifier.IdentityStore.GroupMembershipTypes.MemberId> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMemberId(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, GroupMembershipFactory, T4, InnerGroupMembershipMemberIdFactory> WithMemberId<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, GroupMembershipFactory, T4> combinedResult, Action<Humidifier.IdentityStore.GroupMembershipTypes.MemberId> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMemberId(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, GroupMembershipFactory, InnerGroupMembershipMemberIdFactory> WithMemberId<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, GroupMembershipFactory> combinedResult, Action<Humidifier.IdentityStore.GroupMembershipTypes.MemberId> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMemberId(combinedResult.T5, subFactoryAction));
}
