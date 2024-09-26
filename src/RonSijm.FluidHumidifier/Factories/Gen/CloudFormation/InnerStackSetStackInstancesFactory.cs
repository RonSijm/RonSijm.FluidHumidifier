// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFormation;

public class InnerStackSetStackInstancesFactory(Action<Humidifier.CloudFormation.StackSetTypes.StackInstances> factoryAction = null) : SubResourceFactory<Humidifier.CloudFormation.StackSetTypes.StackInstances>
{

    internal InnerStackSetDeploymentTargetsFactory DeploymentTargetsFactory { get; set; }

    protected override Humidifier.CloudFormation.StackSetTypes.StackInstances Create()
    {
        var stackInstancesResult = CreateStackInstances();
        factoryAction?.Invoke(stackInstancesResult);

        return stackInstancesResult;
    }

    private Humidifier.CloudFormation.StackSetTypes.StackInstances CreateStackInstances()
    {
        var stackInstancesResult = new Humidifier.CloudFormation.StackSetTypes.StackInstances();

        return stackInstancesResult;
    }
    public override void CreateChildren(Humidifier.CloudFormation.StackSetTypes.StackInstances result)
    {
        base.CreateChildren(result);

        result.DeploymentTargets ??= DeploymentTargetsFactory?.Build();
    }

} // End Of Class

public static class InnerStackSetStackInstancesFactoryExtensions
{
    public static CombinedResult<InnerStackSetStackInstancesFactory, InnerStackSetDeploymentTargetsFactory> WithDeploymentTargets(this InnerStackSetStackInstancesFactory parentFactory, Action<Humidifier.CloudFormation.StackSetTypes.DeploymentTargets> subFactoryAction = null)
    {
        parentFactory.DeploymentTargetsFactory = new InnerStackSetDeploymentTargetsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DeploymentTargetsFactory);
    }

    public static CombinedResult<InnerStackSetStackInstancesFactory, T1, InnerStackSetDeploymentTargetsFactory> WithDeploymentTargets<T1>(this CombinedResult<InnerStackSetStackInstancesFactory, T1> combinedResult, Action<Humidifier.CloudFormation.StackSetTypes.DeploymentTargets> subFactoryAction = null) => new (combinedResult, combinedResult, WithDeploymentTargets(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerStackSetStackInstancesFactory, InnerStackSetDeploymentTargetsFactory> WithDeploymentTargets<T1>(this CombinedResult<T1, InnerStackSetStackInstancesFactory> combinedResult, Action<Humidifier.CloudFormation.StackSetTypes.DeploymentTargets> subFactoryAction = null) => new (combinedResult, combinedResult, WithDeploymentTargets(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerStackSetStackInstancesFactory, T1, T2, InnerStackSetDeploymentTargetsFactory> WithDeploymentTargets<T1, T2>(this CombinedResult<InnerStackSetStackInstancesFactory, T1, T2> combinedResult, Action<Humidifier.CloudFormation.StackSetTypes.DeploymentTargets> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDeploymentTargets(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerStackSetStackInstancesFactory, T2, InnerStackSetDeploymentTargetsFactory> WithDeploymentTargets<T1, T2>(this CombinedResult<T1, InnerStackSetStackInstancesFactory, T2> combinedResult, Action<Humidifier.CloudFormation.StackSetTypes.DeploymentTargets> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDeploymentTargets(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerStackSetStackInstancesFactory, InnerStackSetDeploymentTargetsFactory> WithDeploymentTargets<T1, T2>(this CombinedResult<T1, T2, InnerStackSetStackInstancesFactory> combinedResult, Action<Humidifier.CloudFormation.StackSetTypes.DeploymentTargets> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDeploymentTargets(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerStackSetStackInstancesFactory, T1, T2, T3, InnerStackSetDeploymentTargetsFactory> WithDeploymentTargets<T1, T2, T3>(this CombinedResult<InnerStackSetStackInstancesFactory, T1, T2, T3> combinedResult, Action<Humidifier.CloudFormation.StackSetTypes.DeploymentTargets> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDeploymentTargets(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerStackSetStackInstancesFactory, T2, T3, InnerStackSetDeploymentTargetsFactory> WithDeploymentTargets<T1, T2, T3>(this CombinedResult<T1, InnerStackSetStackInstancesFactory, T2, T3> combinedResult, Action<Humidifier.CloudFormation.StackSetTypes.DeploymentTargets> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDeploymentTargets(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerStackSetStackInstancesFactory, T3, InnerStackSetDeploymentTargetsFactory> WithDeploymentTargets<T1, T2, T3>(this CombinedResult<T1, T2, InnerStackSetStackInstancesFactory, T3> combinedResult, Action<Humidifier.CloudFormation.StackSetTypes.DeploymentTargets> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDeploymentTargets(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerStackSetStackInstancesFactory, InnerStackSetDeploymentTargetsFactory> WithDeploymentTargets<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerStackSetStackInstancesFactory> combinedResult, Action<Humidifier.CloudFormation.StackSetTypes.DeploymentTargets> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDeploymentTargets(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerStackSetStackInstancesFactory, T1, T2, T3, T4, InnerStackSetDeploymentTargetsFactory> WithDeploymentTargets<T1, T2, T3, T4>(this CombinedResult<InnerStackSetStackInstancesFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CloudFormation.StackSetTypes.DeploymentTargets> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDeploymentTargets(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerStackSetStackInstancesFactory, T2, T3, T4, InnerStackSetDeploymentTargetsFactory> WithDeploymentTargets<T1, T2, T3, T4>(this CombinedResult<T1, InnerStackSetStackInstancesFactory, T2, T3, T4> combinedResult, Action<Humidifier.CloudFormation.StackSetTypes.DeploymentTargets> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDeploymentTargets(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerStackSetStackInstancesFactory, T3, T4, InnerStackSetDeploymentTargetsFactory> WithDeploymentTargets<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerStackSetStackInstancesFactory, T3, T4> combinedResult, Action<Humidifier.CloudFormation.StackSetTypes.DeploymentTargets> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDeploymentTargets(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerStackSetStackInstancesFactory, T4, InnerStackSetDeploymentTargetsFactory> WithDeploymentTargets<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerStackSetStackInstancesFactory, T4> combinedResult, Action<Humidifier.CloudFormation.StackSetTypes.DeploymentTargets> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDeploymentTargets(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerStackSetStackInstancesFactory, InnerStackSetDeploymentTargetsFactory> WithDeploymentTargets<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerStackSetStackInstancesFactory> combinedResult, Action<Humidifier.CloudFormation.StackSetTypes.DeploymentTargets> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDeploymentTargets(combinedResult.T5, subFactoryAction));
}
