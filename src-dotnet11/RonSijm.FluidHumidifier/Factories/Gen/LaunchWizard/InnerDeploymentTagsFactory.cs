// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.LaunchWizard;

public class InnerDeploymentTagsFactory(Action<Humidifier.LaunchWizard.DeploymentTypes.Tags> factoryAction = null) : SubResourceFactory<Humidifier.LaunchWizard.DeploymentTypes.Tags>
{

    protected override Humidifier.LaunchWizard.DeploymentTypes.Tags Create()
    {
        var tagsResult = CreateTags();
        factoryAction?.Invoke(tagsResult);

        return tagsResult;
    }

    private Humidifier.LaunchWizard.DeploymentTypes.Tags CreateTags()
    {
        var tagsResult = new Humidifier.LaunchWizard.DeploymentTypes.Tags();

        return tagsResult;
    }

} // End Of Class

public static class InnerDeploymentTagsFactoryExtensions
{
}
