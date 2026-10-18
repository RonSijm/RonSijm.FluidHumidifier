// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CleanRooms;

public class InnerIntermediateTableComparisonControlsFactory(Action<Humidifier.CleanRooms.IntermediateTableTypes.ComparisonControls> factoryAction = null) : SubResourceFactory<Humidifier.CleanRooms.IntermediateTableTypes.ComparisonControls>
{

    protected override Humidifier.CleanRooms.IntermediateTableTypes.ComparisonControls Create()
    {
        var comparisonControlsResult = CreateComparisonControls();
        factoryAction?.Invoke(comparisonControlsResult);

        return comparisonControlsResult;
    }

    private Humidifier.CleanRooms.IntermediateTableTypes.ComparisonControls CreateComparisonControls()
    {
        var comparisonControlsResult = new Humidifier.CleanRooms.IntermediateTableTypes.ComparisonControls();

        return comparisonControlsResult;
    }

} // End Of Class

public static class InnerIntermediateTableComparisonControlsFactoryExtensions
{
}
