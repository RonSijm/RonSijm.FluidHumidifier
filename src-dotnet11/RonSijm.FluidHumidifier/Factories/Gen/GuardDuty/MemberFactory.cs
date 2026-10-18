// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GuardDuty;

public class MemberFactory(string resourceName = null, Action<Humidifier.GuardDuty.Member> factoryAction = null) : ResourceFactory<Humidifier.GuardDuty.Member>(resourceName)
{

    protected override Humidifier.GuardDuty.Member Create()
    {
        var memberResult = CreateMember();
        factoryAction?.Invoke(memberResult);

        return memberResult;
    }

    private Humidifier.GuardDuty.Member CreateMember()
    {
        var memberResult = new Humidifier.GuardDuty.Member
        {
            GivenName = InputResourceName,
        };

        return memberResult;
    }

} // End Of Class

public static class MemberFactoryExtensions
{
}
