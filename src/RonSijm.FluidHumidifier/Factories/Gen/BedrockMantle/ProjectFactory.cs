// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockMantle;

public class ProjectFactory(string resourceName = null, Action<Humidifier.BedrockMantle.Project> factoryAction = null) : ResourceFactory<Humidifier.BedrockMantle.Project>(resourceName)
{

    protected override Humidifier.BedrockMantle.Project Create()
    {
        var projectResult = CreateProject();
        factoryAction?.Invoke(projectResult);

        return projectResult;
    }

    private Humidifier.BedrockMantle.Project CreateProject()
    {
        var projectResult = new Humidifier.BedrockMantle.Project
        {
            GivenName = InputResourceName,
        };

        return projectResult;
    }

} // End Of Class

public static class ProjectFactoryExtensions
{
}
