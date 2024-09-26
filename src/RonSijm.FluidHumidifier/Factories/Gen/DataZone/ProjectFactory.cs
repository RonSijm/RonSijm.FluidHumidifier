// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataZone;

public class ProjectFactory(string resourceName = null, Action<Humidifier.DataZone.Project> factoryAction = null) : ResourceFactory<Humidifier.DataZone.Project>(resourceName)
{

    protected override Humidifier.DataZone.Project Create()
    {
        var projectResult = CreateProject();
        factoryAction?.Invoke(projectResult);

        return projectResult;
    }

    private Humidifier.DataZone.Project CreateProject()
    {
        var projectResult = new Humidifier.DataZone.Project
        {
            GivenName = InputResourceName,
        };

        return projectResult;
    }

} // End Of Class

public static class ProjectFactoryExtensions
{
}
