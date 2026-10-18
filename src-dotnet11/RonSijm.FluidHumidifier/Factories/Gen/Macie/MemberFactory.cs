// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Macie;

public class MemberFactory(string resourceName = null, Action<Humidifier.Macie.Member> factoryAction = null) : ResourceFactory<Humidifier.Macie.Member>(resourceName)
{

    protected override Humidifier.Macie.Member Create()
    {
        var memberResult = CreateMember();
        factoryAction?.Invoke(memberResult);

        return memberResult;
    }

    private Humidifier.Macie.Member CreateMember()
    {
        var memberResult = new Humidifier.Macie.Member
        {
            GivenName = InputResourceName,
        };

        return memberResult;
    }

} // End Of Class

public static class MemberFactoryExtensions
{
}
