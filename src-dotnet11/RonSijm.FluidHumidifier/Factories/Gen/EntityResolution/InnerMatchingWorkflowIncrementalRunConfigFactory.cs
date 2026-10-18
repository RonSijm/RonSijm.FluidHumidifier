// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EntityResolution;

public class InnerMatchingWorkflowIncrementalRunConfigFactory(Action<Humidifier.EntityResolution.MatchingWorkflowTypes.IncrementalRunConfig> factoryAction = null) : SubResourceFactory<Humidifier.EntityResolution.MatchingWorkflowTypes.IncrementalRunConfig>
{

    protected override Humidifier.EntityResolution.MatchingWorkflowTypes.IncrementalRunConfig Create()
    {
        var incrementalRunConfigResult = CreateIncrementalRunConfig();
        factoryAction?.Invoke(incrementalRunConfigResult);

        return incrementalRunConfigResult;
    }

    private Humidifier.EntityResolution.MatchingWorkflowTypes.IncrementalRunConfig CreateIncrementalRunConfig()
    {
        var incrementalRunConfigResult = new Humidifier.EntityResolution.MatchingWorkflowTypes.IncrementalRunConfig();

        return incrementalRunConfigResult;
    }

} // End Of Class

public static class InnerMatchingWorkflowIncrementalRunConfigFactoryExtensions
{
}
