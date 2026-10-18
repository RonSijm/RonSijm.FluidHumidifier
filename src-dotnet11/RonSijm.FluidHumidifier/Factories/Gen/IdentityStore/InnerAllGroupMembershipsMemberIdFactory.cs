// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IdentityStore;

public class InnerAllGroupMembershipsMemberIdFactory(Action<Humidifier.IdentityStore.AllGroupMembershipsTypes.MemberId> factoryAction = null) : SubResourceFactory<Humidifier.IdentityStore.AllGroupMembershipsTypes.MemberId>
{

    protected override Humidifier.IdentityStore.AllGroupMembershipsTypes.MemberId Create()
    {
        var memberIdResult = CreateMemberId();
        factoryAction?.Invoke(memberIdResult);

        return memberIdResult;
    }

    private Humidifier.IdentityStore.AllGroupMembershipsTypes.MemberId CreateMemberId()
    {
        var memberIdResult = new Humidifier.IdentityStore.AllGroupMembershipsTypes.MemberId();

        return memberIdResult;
    }

} // End Of Class

public static class InnerAllGroupMembershipsMemberIdFactoryExtensions
{
}
