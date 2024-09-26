// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTSiteWise;

public class ProjectFactory(string resourceName = null, Action<Humidifier.IoTSiteWise.Project> factoryAction = null) : ResourceFactory<Humidifier.IoTSiteWise.Project>(resourceName)
{

    protected override Humidifier.IoTSiteWise.Project Create()
    {
        var projectResult = CreateProject();
        factoryAction?.Invoke(projectResult);

        return projectResult;
    }

    private Humidifier.IoTSiteWise.Project CreateProject()
    {
        var projectResult = new Humidifier.IoTSiteWise.Project
        {
            GivenName = InputResourceName,
        };

        return projectResult;
    }

} // End Of Class

public static class ProjectFactoryExtensions
{
}
