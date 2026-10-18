// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CleanRooms;

public class InnerMembershipMembershipSyntheticDataGenerationPaymentConfigFactory(Action<Humidifier.CleanRooms.MembershipTypes.MembershipSyntheticDataGenerationPaymentConfig> factoryAction = null) : SubResourceFactory<Humidifier.CleanRooms.MembershipTypes.MembershipSyntheticDataGenerationPaymentConfig>
{

    protected override Humidifier.CleanRooms.MembershipTypes.MembershipSyntheticDataGenerationPaymentConfig Create()
    {
        var membershipSyntheticDataGenerationPaymentConfigResult = CreateMembershipSyntheticDataGenerationPaymentConfig();
        factoryAction?.Invoke(membershipSyntheticDataGenerationPaymentConfigResult);

        return membershipSyntheticDataGenerationPaymentConfigResult;
    }

    private Humidifier.CleanRooms.MembershipTypes.MembershipSyntheticDataGenerationPaymentConfig CreateMembershipSyntheticDataGenerationPaymentConfig()
    {
        var membershipSyntheticDataGenerationPaymentConfigResult = new Humidifier.CleanRooms.MembershipTypes.MembershipSyntheticDataGenerationPaymentConfig();

        return membershipSyntheticDataGenerationPaymentConfigResult;
    }

} // End Of Class

public static class InnerMembershipMembershipSyntheticDataGenerationPaymentConfigFactoryExtensions
{
}
