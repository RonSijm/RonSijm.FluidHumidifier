// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CleanRooms;

public class InnerMembershipProtectedJobS3OutputConfigurationInputFactory(Action<Humidifier.CleanRooms.MembershipTypes.ProtectedJobS3OutputConfigurationInput> factoryAction = null) : SubResourceFactory<Humidifier.CleanRooms.MembershipTypes.ProtectedJobS3OutputConfigurationInput>
{

    protected override Humidifier.CleanRooms.MembershipTypes.ProtectedJobS3OutputConfigurationInput Create()
    {
        var protectedJobS3OutputConfigurationInputResult = CreateProtectedJobS3OutputConfigurationInput();
        factoryAction?.Invoke(protectedJobS3OutputConfigurationInputResult);

        return protectedJobS3OutputConfigurationInputResult;
    }

    private Humidifier.CleanRooms.MembershipTypes.ProtectedJobS3OutputConfigurationInput CreateProtectedJobS3OutputConfigurationInput()
    {
        var protectedJobS3OutputConfigurationInputResult = new Humidifier.CleanRooms.MembershipTypes.ProtectedJobS3OutputConfigurationInput();

        return protectedJobS3OutputConfigurationInputResult;
    }

} // End Of Class

public static class InnerMembershipProtectedJobS3OutputConfigurationInputFactoryExtensions
{
}
