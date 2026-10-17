// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CleanRooms;

public class InnerConfiguredTableComparisonControlsFactory(Action<Humidifier.CleanRooms.ConfiguredTableTypes.ComparisonControls> factoryAction = null) : SubResourceFactory<Humidifier.CleanRooms.ConfiguredTableTypes.ComparisonControls>
{

    protected override Humidifier.CleanRooms.ConfiguredTableTypes.ComparisonControls Create()
    {
        var comparisonControlsResult = CreateComparisonControls();
        factoryAction?.Invoke(comparisonControlsResult);

        return comparisonControlsResult;
    }

    private Humidifier.CleanRooms.ConfiguredTableTypes.ComparisonControls CreateComparisonControls()
    {
        var comparisonControlsResult = new Humidifier.CleanRooms.ConfiguredTableTypes.ComparisonControls();

        return comparisonControlsResult;
    }

} // End Of Class

public static class InnerConfiguredTableComparisonControlsFactoryExtensions
{
}
