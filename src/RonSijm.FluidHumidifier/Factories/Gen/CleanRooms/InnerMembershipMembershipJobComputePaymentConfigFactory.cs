// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CleanRooms;

public class InnerMembershipMembershipJobComputePaymentConfigFactory(Action<Humidifier.CleanRooms.MembershipTypes.MembershipJobComputePaymentConfig> factoryAction = null) : SubResourceFactory<Humidifier.CleanRooms.MembershipTypes.MembershipJobComputePaymentConfig>
{

    protected override Humidifier.CleanRooms.MembershipTypes.MembershipJobComputePaymentConfig Create()
    {
        var membershipJobComputePaymentConfigResult = CreateMembershipJobComputePaymentConfig();
        factoryAction?.Invoke(membershipJobComputePaymentConfigResult);

        return membershipJobComputePaymentConfigResult;
    }

    private Humidifier.CleanRooms.MembershipTypes.MembershipJobComputePaymentConfig CreateMembershipJobComputePaymentConfig()
    {
        var membershipJobComputePaymentConfigResult = new Humidifier.CleanRooms.MembershipTypes.MembershipJobComputePaymentConfig();

        return membershipJobComputePaymentConfigResult;
    }

} // End Of Class

public static class InnerMembershipMembershipJobComputePaymentConfigFactoryExtensions
{
}
