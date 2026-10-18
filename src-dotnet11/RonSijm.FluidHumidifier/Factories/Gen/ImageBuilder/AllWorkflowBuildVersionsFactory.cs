// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ImageBuilder;

public class AllWorkflowBuildVersionsFactory(string resourceName = null, Action<Humidifier.ImageBuilder.AllWorkflowBuildVersions> factoryAction = null) : ResourceFactory<Humidifier.ImageBuilder.AllWorkflowBuildVersions>(resourceName)
{

    protected override Humidifier.ImageBuilder.AllWorkflowBuildVersions Create()
    {
        var allWorkflowBuildVersionsResult = CreateAllWorkflowBuildVersions();
        factoryAction?.Invoke(allWorkflowBuildVersionsResult);

        return allWorkflowBuildVersionsResult;
    }

    private Humidifier.ImageBuilder.AllWorkflowBuildVersions CreateAllWorkflowBuildVersions()
    {
        var allWorkflowBuildVersionsResult = new Humidifier.ImageBuilder.AllWorkflowBuildVersions
        {
            GivenName = InputResourceName,
        };

        return allWorkflowBuildVersionsResult;
    }

} // End Of Class

public static class AllWorkflowBuildVersionsFactoryExtensions
{
}
