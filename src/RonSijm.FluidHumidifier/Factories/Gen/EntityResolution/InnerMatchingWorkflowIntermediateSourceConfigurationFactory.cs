// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EntityResolution;

public class InnerMatchingWorkflowIntermediateSourceConfigurationFactory(Action<Humidifier.EntityResolution.MatchingWorkflowTypes.IntermediateSourceConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.EntityResolution.MatchingWorkflowTypes.IntermediateSourceConfiguration>
{

    protected override Humidifier.EntityResolution.MatchingWorkflowTypes.IntermediateSourceConfiguration Create()
    {
        var intermediateSourceConfigurationResult = CreateIntermediateSourceConfiguration();
        factoryAction?.Invoke(intermediateSourceConfigurationResult);

        return intermediateSourceConfigurationResult;
    }

    private Humidifier.EntityResolution.MatchingWorkflowTypes.IntermediateSourceConfiguration CreateIntermediateSourceConfiguration()
    {
        var intermediateSourceConfigurationResult = new Humidifier.EntityResolution.MatchingWorkflowTypes.IntermediateSourceConfiguration();

        return intermediateSourceConfigurationResult;
    }

} // End Of Class

public static class InnerMatchingWorkflowIntermediateSourceConfigurationFactoryExtensions
{
}
