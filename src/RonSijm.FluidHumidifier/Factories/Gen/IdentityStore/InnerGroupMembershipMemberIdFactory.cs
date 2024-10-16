// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IdentityStore;

public class InnerGroupMembershipMemberIdFactory(Action<Humidifier.IdentityStore.GroupMembershipTypes.MemberId> factoryAction = null) : SubResourceFactory<Humidifier.IdentityStore.GroupMembershipTypes.MemberId>
{

    protected override Humidifier.IdentityStore.GroupMembershipTypes.MemberId Create()
    {
        var memberIdResult = CreateMemberId();
        factoryAction?.Invoke(memberIdResult);

        return memberIdResult;
    }

    private Humidifier.IdentityStore.GroupMembershipTypes.MemberId CreateMemberId()
    {
        var memberIdResult = new Humidifier.IdentityStore.GroupMembershipTypes.MemberId();

        return memberIdResult;
    }

} // End Of Class

public static class InnerGroupMembershipMemberIdFactoryExtensions
{
}
