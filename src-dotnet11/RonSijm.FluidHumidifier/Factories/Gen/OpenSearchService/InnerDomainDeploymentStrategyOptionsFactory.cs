// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.OpenSearchService;

public class InnerDomainDeploymentStrategyOptionsFactory(Action<Humidifier.OpenSearchService.DomainTypes.DeploymentStrategyOptions> factoryAction = null) : SubResourceFactory<Humidifier.OpenSearchService.DomainTypes.DeploymentStrategyOptions>
{

    protected override Humidifier.OpenSearchService.DomainTypes.DeploymentStrategyOptions Create()
    {
        var deploymentStrategyOptionsResult = CreateDeploymentStrategyOptions();
        factoryAction?.Invoke(deploymentStrategyOptionsResult);

        return deploymentStrategyOptionsResult;
    }

    private Humidifier.OpenSearchService.DomainTypes.DeploymentStrategyOptions CreateDeploymentStrategyOptions()
    {
        var deploymentStrategyOptionsResult = new Humidifier.OpenSearchService.DomainTypes.DeploymentStrategyOptions();

        return deploymentStrategyOptionsResult;
    }

} // End Of Class

public static class InnerDomainDeploymentStrategyOptionsFactoryExtensions
{
}
