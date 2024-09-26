// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CodeDeploy;

public class InnerDeploymentGroupDeploymentFactory(Action<Humidifier.CodeDeploy.DeploymentGroupTypes.Deployment> factoryAction = null) : SubResourceFactory<Humidifier.CodeDeploy.DeploymentGroupTypes.Deployment>
{

    internal InnerDeploymentGroupRevisionLocationFactory RevisionFactory { get; set; }

    protected override Humidifier.CodeDeploy.DeploymentGroupTypes.Deployment Create()
    {
        var deploymentResult = CreateDeployment();
        factoryAction?.Invoke(deploymentResult);

        return deploymentResult;
    }

    private Humidifier.CodeDeploy.DeploymentGroupTypes.Deployment CreateDeployment()
    {
        var deploymentResult = new Humidifier.CodeDeploy.DeploymentGroupTypes.Deployment();

        return deploymentResult;
    }
    public override void CreateChildren(Humidifier.CodeDeploy.DeploymentGroupTypes.Deployment result)
    {
        base.CreateChildren(result);

        result.Revision ??= RevisionFactory?.Build();
    }

} // End Of Class

public static class InnerDeploymentGroupDeploymentFactoryExtensions
{
    public static CombinedResult<InnerDeploymentGroupDeploymentFactory, InnerDeploymentGroupRevisionLocationFactory> WithRevision(this InnerDeploymentGroupDeploymentFactory parentFactory, Action<Humidifier.CodeDeploy.DeploymentGroupTypes.RevisionLocation> subFactoryAction = null)
    {
        parentFactory.RevisionFactory = new InnerDeploymentGroupRevisionLocationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.RevisionFactory);
    }

    public static CombinedResult<InnerDeploymentGroupDeploymentFactory, T1, InnerDeploymentGroupRevisionLocationFactory> WithRevision<T1>(this CombinedResult<InnerDeploymentGroupDeploymentFactory, T1> combinedResult, Action<Humidifier.CodeDeploy.DeploymentGroupTypes.RevisionLocation> subFactoryAction = null) => new (combinedResult, combinedResult, WithRevision(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDeploymentGroupDeploymentFactory, InnerDeploymentGroupRevisionLocationFactory> WithRevision<T1>(this CombinedResult<T1, InnerDeploymentGroupDeploymentFactory> combinedResult, Action<Humidifier.CodeDeploy.DeploymentGroupTypes.RevisionLocation> subFactoryAction = null) => new (combinedResult, combinedResult, WithRevision(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDeploymentGroupDeploymentFactory, T1, T2, InnerDeploymentGroupRevisionLocationFactory> WithRevision<T1, T2>(this CombinedResult<InnerDeploymentGroupDeploymentFactory, T1, T2> combinedResult, Action<Humidifier.CodeDeploy.DeploymentGroupTypes.RevisionLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRevision(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDeploymentGroupDeploymentFactory, T2, InnerDeploymentGroupRevisionLocationFactory> WithRevision<T1, T2>(this CombinedResult<T1, InnerDeploymentGroupDeploymentFactory, T2> combinedResult, Action<Humidifier.CodeDeploy.DeploymentGroupTypes.RevisionLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRevision(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDeploymentGroupDeploymentFactory, InnerDeploymentGroupRevisionLocationFactory> WithRevision<T1, T2>(this CombinedResult<T1, T2, InnerDeploymentGroupDeploymentFactory> combinedResult, Action<Humidifier.CodeDeploy.DeploymentGroupTypes.RevisionLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRevision(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDeploymentGroupDeploymentFactory, T1, T2, T3, InnerDeploymentGroupRevisionLocationFactory> WithRevision<T1, T2, T3>(this CombinedResult<InnerDeploymentGroupDeploymentFactory, T1, T2, T3> combinedResult, Action<Humidifier.CodeDeploy.DeploymentGroupTypes.RevisionLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRevision(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDeploymentGroupDeploymentFactory, T2, T3, InnerDeploymentGroupRevisionLocationFactory> WithRevision<T1, T2, T3>(this CombinedResult<T1, InnerDeploymentGroupDeploymentFactory, T2, T3> combinedResult, Action<Humidifier.CodeDeploy.DeploymentGroupTypes.RevisionLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRevision(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDeploymentGroupDeploymentFactory, T3, InnerDeploymentGroupRevisionLocationFactory> WithRevision<T1, T2, T3>(this CombinedResult<T1, T2, InnerDeploymentGroupDeploymentFactory, T3> combinedResult, Action<Humidifier.CodeDeploy.DeploymentGroupTypes.RevisionLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRevision(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDeploymentGroupDeploymentFactory, InnerDeploymentGroupRevisionLocationFactory> WithRevision<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDeploymentGroupDeploymentFactory> combinedResult, Action<Humidifier.CodeDeploy.DeploymentGroupTypes.RevisionLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRevision(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDeploymentGroupDeploymentFactory, T1, T2, T3, T4, InnerDeploymentGroupRevisionLocationFactory> WithRevision<T1, T2, T3, T4>(this CombinedResult<InnerDeploymentGroupDeploymentFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CodeDeploy.DeploymentGroupTypes.RevisionLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRevision(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDeploymentGroupDeploymentFactory, T2, T3, T4, InnerDeploymentGroupRevisionLocationFactory> WithRevision<T1, T2, T3, T4>(this CombinedResult<T1, InnerDeploymentGroupDeploymentFactory, T2, T3, T4> combinedResult, Action<Humidifier.CodeDeploy.DeploymentGroupTypes.RevisionLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRevision(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDeploymentGroupDeploymentFactory, T3, T4, InnerDeploymentGroupRevisionLocationFactory> WithRevision<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDeploymentGroupDeploymentFactory, T3, T4> combinedResult, Action<Humidifier.CodeDeploy.DeploymentGroupTypes.RevisionLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRevision(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDeploymentGroupDeploymentFactory, T4, InnerDeploymentGroupRevisionLocationFactory> WithRevision<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDeploymentGroupDeploymentFactory, T4> combinedResult, Action<Humidifier.CodeDeploy.DeploymentGroupTypes.RevisionLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRevision(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDeploymentGroupDeploymentFactory, InnerDeploymentGroupRevisionLocationFactory> WithRevision<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDeploymentGroupDeploymentFactory> combinedResult, Action<Humidifier.CodeDeploy.DeploymentGroupTypes.RevisionLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRevision(combinedResult.T5, subFactoryAction));
}
