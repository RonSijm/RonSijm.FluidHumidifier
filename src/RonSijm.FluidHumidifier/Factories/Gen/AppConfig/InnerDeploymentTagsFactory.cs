// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppConfig;

public class InnerDeploymentTagsFactory(Action<Humidifier.AppConfig.DeploymentTypes.Tags> factoryAction = null) : SubResourceFactory<Humidifier.AppConfig.DeploymentTypes.Tags>
{

    protected override Humidifier.AppConfig.DeploymentTypes.Tags Create()
    {
        var tagsResult = CreateTags();
        factoryAction?.Invoke(tagsResult);

        return tagsResult;
    }

    private Humidifier.AppConfig.DeploymentTypes.Tags CreateTags()
    {
        var tagsResult = new Humidifier.AppConfig.DeploymentTypes.Tags();

        return tagsResult;
    }

} // End Of Class

public static class InnerDeploymentTagsFactoryExtensions
{
}
