// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CleanRooms;

public class InnerConfiguredTableDifferentialPrivacyFactory(Action<Humidifier.CleanRooms.ConfiguredTableTypes.DifferentialPrivacy> factoryAction = null) : SubResourceFactory<Humidifier.CleanRooms.ConfiguredTableTypes.DifferentialPrivacy>
{

    protected override Humidifier.CleanRooms.ConfiguredTableTypes.DifferentialPrivacy Create()
    {
        var differentialPrivacyResult = CreateDifferentialPrivacy();
        factoryAction?.Invoke(differentialPrivacyResult);

        return differentialPrivacyResult;
    }

    private Humidifier.CleanRooms.ConfiguredTableTypes.DifferentialPrivacy CreateDifferentialPrivacy()
    {
        var differentialPrivacyResult = new Humidifier.CleanRooms.ConfiguredTableTypes.DifferentialPrivacy();

        return differentialPrivacyResult;
    }

} // End Of Class

public static class InnerConfiguredTableDifferentialPrivacyFactoryExtensions
{
}
