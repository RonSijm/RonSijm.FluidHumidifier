// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Rekognition;

public class ProjectFactory(string resourceName = null, Action<Humidifier.Rekognition.Project> factoryAction = null) : ResourceFactory<Humidifier.Rekognition.Project>(resourceName)
{

    protected override Humidifier.Rekognition.Project Create()
    {
        var projectResult = CreateProject();
        factoryAction?.Invoke(projectResult);

        return projectResult;
    }

    private Humidifier.Rekognition.Project CreateProject()
    {
        var projectResult = new Humidifier.Rekognition.Project
        {
            GivenName = InputResourceName,
        };

        return projectResult;
    }

} // End Of Class

public static class ProjectFactoryExtensions
{
}
