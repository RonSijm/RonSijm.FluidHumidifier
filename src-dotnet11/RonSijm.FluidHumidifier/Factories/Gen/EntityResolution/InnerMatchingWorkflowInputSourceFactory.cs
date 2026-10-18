// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EntityResolution;

public class InnerMatchingWorkflowInputSourceFactory(Action<Humidifier.EntityResolution.MatchingWorkflowTypes.InputSource> factoryAction = null) : SubResourceFactory<Humidifier.EntityResolution.MatchingWorkflowTypes.InputSource>
{

    protected override Humidifier.EntityResolution.MatchingWorkflowTypes.InputSource Create()
    {
        var inputSourceResult = CreateInputSource();
        factoryAction?.Invoke(inputSourceResult);

        return inputSourceResult;
    }

    private Humidifier.EntityResolution.MatchingWorkflowTypes.InputSource CreateInputSource()
    {
        var inputSourceResult = new Humidifier.EntityResolution.MatchingWorkflowTypes.InputSource();

        return inputSourceResult;
    }

} // End Of Class

public static class InnerMatchingWorkflowInputSourceFactoryExtensions
{
}
