// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EntityResolution;

public class InnerMatchingWorkflowOutputSourceFactory(Action<Humidifier.EntityResolution.MatchingWorkflowTypes.OutputSource> factoryAction = null) : SubResourceFactory<Humidifier.EntityResolution.MatchingWorkflowTypes.OutputSource>
{

    protected override Humidifier.EntityResolution.MatchingWorkflowTypes.OutputSource Create()
    {
        var outputSourceResult = CreateOutputSource();
        factoryAction?.Invoke(outputSourceResult);

        return outputSourceResult;
    }

    private Humidifier.EntityResolution.MatchingWorkflowTypes.OutputSource CreateOutputSource()
    {
        var outputSourceResult = new Humidifier.EntityResolution.MatchingWorkflowTypes.OutputSource();

        return outputSourceResult;
    }

} // End Of Class

public static class InnerMatchingWorkflowOutputSourceFactoryExtensions
{
}
