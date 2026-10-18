// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CleanRooms;

public class InnerMembershipMembershipQueryComputePaymentConfigFactory(Action<Humidifier.CleanRooms.MembershipTypes.MembershipQueryComputePaymentConfig> factoryAction = null) : SubResourceFactory<Humidifier.CleanRooms.MembershipTypes.MembershipQueryComputePaymentConfig>
{

    protected override Humidifier.CleanRooms.MembershipTypes.MembershipQueryComputePaymentConfig Create()
    {
        var membershipQueryComputePaymentConfigResult = CreateMembershipQueryComputePaymentConfig();
        factoryAction?.Invoke(membershipQueryComputePaymentConfigResult);

        return membershipQueryComputePaymentConfigResult;
    }

    private Humidifier.CleanRooms.MembershipTypes.MembershipQueryComputePaymentConfig CreateMembershipQueryComputePaymentConfig()
    {
        var membershipQueryComputePaymentConfigResult = new Humidifier.CleanRooms.MembershipTypes.MembershipQueryComputePaymentConfig();

        return membershipQueryComputePaymentConfigResult;
    }

} // End Of Class

public static class InnerMembershipMembershipQueryComputePaymentConfigFactoryExtensions
{
}
