// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CleanRooms;

public class InnerConfiguredTableAthenaTableReferenceFactory(Action<Humidifier.CleanRooms.ConfiguredTableTypes.AthenaTableReference> factoryAction = null) : SubResourceFactory<Humidifier.CleanRooms.ConfiguredTableTypes.AthenaTableReference>
{

    protected override Humidifier.CleanRooms.ConfiguredTableTypes.AthenaTableReference Create()
    {
        var athenaTableReferenceResult = CreateAthenaTableReference();
        factoryAction?.Invoke(athenaTableReferenceResult);

        return athenaTableReferenceResult;
    }

    private Humidifier.CleanRooms.ConfiguredTableTypes.AthenaTableReference CreateAthenaTableReference()
    {
        var athenaTableReferenceResult = new Humidifier.CleanRooms.ConfiguredTableTypes.AthenaTableReference();

        return athenaTableReferenceResult;
    }

} // End Of Class

public static class InnerConfiguredTableAthenaTableReferenceFactoryExtensions
{
}
