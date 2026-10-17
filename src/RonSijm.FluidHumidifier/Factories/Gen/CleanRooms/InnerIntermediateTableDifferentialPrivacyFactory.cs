// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CleanRooms;

public class InnerIntermediateTableDifferentialPrivacyFactory(Action<Humidifier.CleanRooms.IntermediateTableTypes.DifferentialPrivacy> factoryAction = null) : SubResourceFactory<Humidifier.CleanRooms.IntermediateTableTypes.DifferentialPrivacy>
{

    protected override Humidifier.CleanRooms.IntermediateTableTypes.DifferentialPrivacy Create()
    {
        var differentialPrivacyResult = CreateDifferentialPrivacy();
        factoryAction?.Invoke(differentialPrivacyResult);

        return differentialPrivacyResult;
    }

    private Humidifier.CleanRooms.IntermediateTableTypes.DifferentialPrivacy CreateDifferentialPrivacy()
    {
        var differentialPrivacyResult = new Humidifier.CleanRooms.IntermediateTableTypes.DifferentialPrivacy();

        return differentialPrivacyResult;
    }

} // End Of Class

public static class InnerIntermediateTableDifferentialPrivacyFactoryExtensions
{
}
