// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CodeDeploy;

public class InnerDeploymentGroupTagFilterFactory(Action<Humidifier.CodeDeploy.DeploymentGroupTypes.TagFilter> factoryAction = null) : SubResourceFactory<Humidifier.CodeDeploy.DeploymentGroupTypes.TagFilter>
{

    protected override Humidifier.CodeDeploy.DeploymentGroupTypes.TagFilter Create()
    {
        var tagFilterResult = CreateTagFilter();
        factoryAction?.Invoke(tagFilterResult);

        return tagFilterResult;
    }

    private Humidifier.CodeDeploy.DeploymentGroupTypes.TagFilter CreateTagFilter()
    {
        var tagFilterResult = new Humidifier.CodeDeploy.DeploymentGroupTypes.TagFilter();

        return tagFilterResult;
    }

} // End Of Class

public static class InnerDeploymentGroupTagFilterFactoryExtensions
{
}
