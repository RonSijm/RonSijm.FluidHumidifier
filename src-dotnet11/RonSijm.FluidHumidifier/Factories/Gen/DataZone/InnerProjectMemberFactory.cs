// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataZone;

public class InnerProjectMemberFactory(Action<Humidifier.DataZone.ProjectTypes.Member> factoryAction = null) : SubResourceFactory<Humidifier.DataZone.ProjectTypes.Member>
{

    protected override Humidifier.DataZone.ProjectTypes.Member Create()
    {
        var memberResult = CreateMember();
        factoryAction?.Invoke(memberResult);

        return memberResult;
    }

    private Humidifier.DataZone.ProjectTypes.Member CreateMember()
    {
        var memberResult = new Humidifier.DataZone.ProjectTypes.Member();

        return memberResult;
    }

} // End Of Class

public static class InnerProjectMemberFactoryExtensions
{
}
