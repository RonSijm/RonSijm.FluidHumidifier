// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CleanRooms;

public class InnerMembershipMembershipModelInferencePaymentConfigFactory(Action<Humidifier.CleanRooms.MembershipTypes.MembershipModelInferencePaymentConfig> factoryAction = null) : SubResourceFactory<Humidifier.CleanRooms.MembershipTypes.MembershipModelInferencePaymentConfig>
{

    protected override Humidifier.CleanRooms.MembershipTypes.MembershipModelInferencePaymentConfig Create()
    {
        var membershipModelInferencePaymentConfigResult = CreateMembershipModelInferencePaymentConfig();
        factoryAction?.Invoke(membershipModelInferencePaymentConfigResult);

        return membershipModelInferencePaymentConfigResult;
    }

    private Humidifier.CleanRooms.MembershipTypes.MembershipModelInferencePaymentConfig CreateMembershipModelInferencePaymentConfig()
    {
        var membershipModelInferencePaymentConfigResult = new Humidifier.CleanRooms.MembershipTypes.MembershipModelInferencePaymentConfig();

        return membershipModelInferencePaymentConfigResult;
    }

} // End Of Class

public static class InnerMembershipMembershipModelInferencePaymentConfigFactoryExtensions
{
}
