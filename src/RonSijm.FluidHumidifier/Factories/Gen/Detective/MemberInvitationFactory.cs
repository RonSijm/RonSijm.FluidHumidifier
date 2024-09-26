// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Detective;

public class MemberInvitationFactory(string resourceName = null, Action<Humidifier.Detective.MemberInvitation> factoryAction = null) : ResourceFactory<Humidifier.Detective.MemberInvitation>(resourceName)
{

    protected override Humidifier.Detective.MemberInvitation Create()
    {
        var memberInvitationResult = CreateMemberInvitation();
        factoryAction?.Invoke(memberInvitationResult);

        return memberInvitationResult;
    }

    private Humidifier.Detective.MemberInvitation CreateMemberInvitation()
    {
        var memberInvitationResult = new Humidifier.Detective.MemberInvitation
        {
            GivenName = InputResourceName,
        };

        return memberInvitationResult;
    }

} // End Of Class

public static class MemberInvitationFactoryExtensions
{
}
