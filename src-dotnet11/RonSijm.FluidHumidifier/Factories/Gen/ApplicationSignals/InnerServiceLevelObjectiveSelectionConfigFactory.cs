// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ApplicationSignals;

public class InnerServiceLevelObjectiveSelectionConfigFactory(Action<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.SelectionConfig> factoryAction = null) : SubResourceFactory<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.SelectionConfig>
{

    protected override Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.SelectionConfig Create()
    {
        var selectionConfigResult = CreateSelectionConfig();
        factoryAction?.Invoke(selectionConfigResult);

        return selectionConfigResult;
    }

    private Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.SelectionConfig CreateSelectionConfig()
    {
        var selectionConfigResult = new Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.SelectionConfig();

        return selectionConfigResult;
    }

} // End Of Class

public static class InnerServiceLevelObjectiveSelectionConfigFactoryExtensions
{
}
