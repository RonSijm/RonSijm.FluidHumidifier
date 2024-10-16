// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CodeBuild;

public class InnerProjectProjectFleetFactory(Action<Humidifier.CodeBuild.ProjectTypes.ProjectFleet> factoryAction = null) : SubResourceFactory<Humidifier.CodeBuild.ProjectTypes.ProjectFleet>
{

    protected override Humidifier.CodeBuild.ProjectTypes.ProjectFleet Create()
    {
        var projectFleetResult = CreateProjectFleet();
        factoryAction?.Invoke(projectFleetResult);

        return projectFleetResult;
    }

    private Humidifier.CodeBuild.ProjectTypes.ProjectFleet CreateProjectFleet()
    {
        var projectFleetResult = new Humidifier.CodeBuild.ProjectTypes.ProjectFleet();

        return projectFleetResult;
    }

} // End Of Class

public static class InnerProjectProjectFleetFactoryExtensions
{
}
