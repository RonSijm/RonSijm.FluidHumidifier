// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EntityResolution;

public class InnerMatchingWorkflowMatchingConfigFactory(Action<Humidifier.EntityResolution.MatchingWorkflowTypes.MatchingConfig> factoryAction = null) : SubResourceFactory<Humidifier.EntityResolution.MatchingWorkflowTypes.MatchingConfig>
{

    protected override Humidifier.EntityResolution.MatchingWorkflowTypes.MatchingConfig Create()
    {
        var matchingConfigResult = CreateMatchingConfig();
        factoryAction?.Invoke(matchingConfigResult);

        return matchingConfigResult;
    }

    private Humidifier.EntityResolution.MatchingWorkflowTypes.MatchingConfig CreateMatchingConfig()
    {
        var matchingConfigResult = new Humidifier.EntityResolution.MatchingWorkflowTypes.MatchingConfig();

        return matchingConfigResult;
    }

} // End Of Class

public static class InnerMatchingWorkflowMatchingConfigFactoryExtensions
{
}
