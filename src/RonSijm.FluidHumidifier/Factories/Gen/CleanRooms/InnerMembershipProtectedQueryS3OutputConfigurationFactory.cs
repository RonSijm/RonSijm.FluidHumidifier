// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CleanRooms;

public class InnerMembershipProtectedQueryS3OutputConfigurationFactory(Action<Humidifier.CleanRooms.MembershipTypes.ProtectedQueryS3OutputConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.CleanRooms.MembershipTypes.ProtectedQueryS3OutputConfiguration>
{

    protected override Humidifier.CleanRooms.MembershipTypes.ProtectedQueryS3OutputConfiguration Create()
    {
        var protectedQueryS3OutputConfigurationResult = CreateProtectedQueryS3OutputConfiguration();
        factoryAction?.Invoke(protectedQueryS3OutputConfigurationResult);

        return protectedQueryS3OutputConfigurationResult;
    }

    private Humidifier.CleanRooms.MembershipTypes.ProtectedQueryS3OutputConfiguration CreateProtectedQueryS3OutputConfiguration()
    {
        var protectedQueryS3OutputConfigurationResult = new Humidifier.CleanRooms.MembershipTypes.ProtectedQueryS3OutputConfiguration();

        return protectedQueryS3OutputConfigurationResult;
    }

} // End Of Class

public static class InnerMembershipProtectedQueryS3OutputConfigurationFactoryExtensions
{
}
