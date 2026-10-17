// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.NeptuneGraph;

public class InnerGraphNeptuneImportOptionsFactory(Action<Humidifier.NeptuneGraph.GraphTypes.NeptuneImportOptions> factoryAction = null) : SubResourceFactory<Humidifier.NeptuneGraph.GraphTypes.NeptuneImportOptions>
{

    protected override Humidifier.NeptuneGraph.GraphTypes.NeptuneImportOptions Create()
    {
        var neptuneImportOptionsResult = CreateNeptuneImportOptions();
        factoryAction?.Invoke(neptuneImportOptionsResult);

        return neptuneImportOptionsResult;
    }

    private Humidifier.NeptuneGraph.GraphTypes.NeptuneImportOptions CreateNeptuneImportOptions()
    {
        var neptuneImportOptionsResult = new Humidifier.NeptuneGraph.GraphTypes.NeptuneImportOptions();

        return neptuneImportOptionsResult;
    }

} // End Of Class

public static class InnerGraphNeptuneImportOptionsFactoryExtensions
{
}
