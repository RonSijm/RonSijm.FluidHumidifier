// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppConfig;

public class InnerDeploymentStrategyTagsFactory(Action<Humidifier.AppConfig.DeploymentStrategyTypes.Tags> factoryAction = null) : SubResourceFactory<Humidifier.AppConfig.DeploymentStrategyTypes.Tags>
{

    protected override Humidifier.AppConfig.DeploymentStrategyTypes.Tags Create()
    {
        var tagsResult = CreateTags();
        factoryAction?.Invoke(tagsResult);

        return tagsResult;
    }

    private Humidifier.AppConfig.DeploymentStrategyTypes.Tags CreateTags()
    {
        var tagsResult = new Humidifier.AppConfig.DeploymentStrategyTypes.Tags();

        return tagsResult;
    }

} // End Of Class

public static class InnerDeploymentStrategyTagsFactoryExtensions
{
}
