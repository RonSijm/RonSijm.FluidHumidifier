// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.LookoutVision;

public class ProjectFactory(string resourceName = null, Action<Humidifier.LookoutVision.Project> factoryAction = null) : ResourceFactory<Humidifier.LookoutVision.Project>(resourceName)
{

    protected override Humidifier.LookoutVision.Project Create()
    {
        var projectResult = CreateProject();
        factoryAction?.Invoke(projectResult);

        return projectResult;
    }

    private Humidifier.LookoutVision.Project CreateProject()
    {
        var projectResult = new Humidifier.LookoutVision.Project
        {
            GivenName = InputResourceName,
        };

        return projectResult;
    }

} // End Of Class

public static class ProjectFactoryExtensions
{
}
