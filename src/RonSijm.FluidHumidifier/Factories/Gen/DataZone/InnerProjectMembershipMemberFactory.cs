// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataZone;

public class InnerProjectMembershipMemberFactory(Action<Humidifier.DataZone.ProjectMembershipTypes.Member> factoryAction = null) : SubResourceFactory<Humidifier.DataZone.ProjectMembershipTypes.Member>
{

    protected override Humidifier.DataZone.ProjectMembershipTypes.Member Create()
    {
        var memberResult = CreateMember();
        factoryAction?.Invoke(memberResult);

        return memberResult;
    }

    private Humidifier.DataZone.ProjectMembershipTypes.Member CreateMember()
    {
        var memberResult = new Humidifier.DataZone.ProjectMembershipTypes.Member();

        return memberResult;
    }

} // End Of Class

public static class InnerProjectMembershipMemberFactoryExtensions
{
}
