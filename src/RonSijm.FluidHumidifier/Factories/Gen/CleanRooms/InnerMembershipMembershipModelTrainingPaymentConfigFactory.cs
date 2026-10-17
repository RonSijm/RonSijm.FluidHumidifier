// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CleanRooms;

public class InnerMembershipMembershipModelTrainingPaymentConfigFactory(Action<Humidifier.CleanRooms.MembershipTypes.MembershipModelTrainingPaymentConfig> factoryAction = null) : SubResourceFactory<Humidifier.CleanRooms.MembershipTypes.MembershipModelTrainingPaymentConfig>
{

    protected override Humidifier.CleanRooms.MembershipTypes.MembershipModelTrainingPaymentConfig Create()
    {
        var membershipModelTrainingPaymentConfigResult = CreateMembershipModelTrainingPaymentConfig();
        factoryAction?.Invoke(membershipModelTrainingPaymentConfigResult);

        return membershipModelTrainingPaymentConfigResult;
    }

    private Humidifier.CleanRooms.MembershipTypes.MembershipModelTrainingPaymentConfig CreateMembershipModelTrainingPaymentConfig()
    {
        var membershipModelTrainingPaymentConfigResult = new Humidifier.CleanRooms.MembershipTypes.MembershipModelTrainingPaymentConfig();

        return membershipModelTrainingPaymentConfigResult;
    }

} // End Of Class

public static class InnerMembershipMembershipModelTrainingPaymentConfigFactoryExtensions
{
}
