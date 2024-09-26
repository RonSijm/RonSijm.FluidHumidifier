// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GreengrassV2;

public class DeploymentFactory(string resourceName = null, Action<Humidifier.GreengrassV2.Deployment> factoryAction = null) : ResourceFactory<Humidifier.GreengrassV2.Deployment>(resourceName)
{

    internal InnerDeploymentDeploymentIoTJobConfigurationFactory IotJobConfigurationFactory { get; set; }

    internal InnerDeploymentDeploymentPoliciesFactory DeploymentPoliciesFactory { get; set; }

    protected override Humidifier.GreengrassV2.Deployment Create()
    {
        var deploymentResult = CreateDeployment();
        factoryAction?.Invoke(deploymentResult);

        return deploymentResult;
    }

    private Humidifier.GreengrassV2.Deployment CreateDeployment()
    {
        var deploymentResult = new Humidifier.GreengrassV2.Deployment
        {
            GivenName = InputResourceName,
        };

        return deploymentResult;
    }
    public override void CreateChildren(Humidifier.GreengrassV2.Deployment result)
    {
        base.CreateChildren(result);

        result.IotJobConfiguration ??= IotJobConfigurationFactory?.Build();
        result.DeploymentPolicies ??= DeploymentPoliciesFactory?.Build();
    }

} // End Of Class

public static class DeploymentFactoryExtensions
{
    public static CombinedResult<DeploymentFactory, InnerDeploymentDeploymentIoTJobConfigurationFactory> WithIotJobConfiguration(this DeploymentFactory parentFactory, Action<Humidifier.GreengrassV2.DeploymentTypes.DeploymentIoTJobConfiguration> subFactoryAction = null)
    {
        parentFactory.IotJobConfigurationFactory = new InnerDeploymentDeploymentIoTJobConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.IotJobConfigurationFactory);
    }

    public static CombinedResult<DeploymentFactory, InnerDeploymentDeploymentPoliciesFactory> WithDeploymentPolicies(this DeploymentFactory parentFactory, Action<Humidifier.GreengrassV2.DeploymentTypes.DeploymentPolicies> subFactoryAction = null)
    {
        parentFactory.DeploymentPoliciesFactory = new InnerDeploymentDeploymentPoliciesFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DeploymentPoliciesFactory);
    }

    public static CombinedResult<DeploymentFactory, T1, InnerDeploymentDeploymentIoTJobConfigurationFactory> WithIotJobConfiguration<T1>(this CombinedResult<DeploymentFactory, T1> combinedResult, Action<Humidifier.GreengrassV2.DeploymentTypes.DeploymentIoTJobConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithIotJobConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DeploymentFactory, InnerDeploymentDeploymentIoTJobConfigurationFactory> WithIotJobConfiguration<T1>(this CombinedResult<T1, DeploymentFactory> combinedResult, Action<Humidifier.GreengrassV2.DeploymentTypes.DeploymentIoTJobConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithIotJobConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<DeploymentFactory, T1, T2, InnerDeploymentDeploymentIoTJobConfigurationFactory> WithIotJobConfiguration<T1, T2>(this CombinedResult<DeploymentFactory, T1, T2> combinedResult, Action<Humidifier.GreengrassV2.DeploymentTypes.DeploymentIoTJobConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIotJobConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DeploymentFactory, T2, InnerDeploymentDeploymentIoTJobConfigurationFactory> WithIotJobConfiguration<T1, T2>(this CombinedResult<T1, DeploymentFactory, T2> combinedResult, Action<Humidifier.GreengrassV2.DeploymentTypes.DeploymentIoTJobConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIotJobConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DeploymentFactory, InnerDeploymentDeploymentIoTJobConfigurationFactory> WithIotJobConfiguration<T1, T2>(this CombinedResult<T1, T2, DeploymentFactory> combinedResult, Action<Humidifier.GreengrassV2.DeploymentTypes.DeploymentIoTJobConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIotJobConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<DeploymentFactory, T1, T2, T3, InnerDeploymentDeploymentIoTJobConfigurationFactory> WithIotJobConfiguration<T1, T2, T3>(this CombinedResult<DeploymentFactory, T1, T2, T3> combinedResult, Action<Humidifier.GreengrassV2.DeploymentTypes.DeploymentIoTJobConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIotJobConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DeploymentFactory, T2, T3, InnerDeploymentDeploymentIoTJobConfigurationFactory> WithIotJobConfiguration<T1, T2, T3>(this CombinedResult<T1, DeploymentFactory, T2, T3> combinedResult, Action<Humidifier.GreengrassV2.DeploymentTypes.DeploymentIoTJobConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIotJobConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DeploymentFactory, T3, InnerDeploymentDeploymentIoTJobConfigurationFactory> WithIotJobConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, DeploymentFactory, T3> combinedResult, Action<Humidifier.GreengrassV2.DeploymentTypes.DeploymentIoTJobConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIotJobConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DeploymentFactory, InnerDeploymentDeploymentIoTJobConfigurationFactory> WithIotJobConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, DeploymentFactory> combinedResult, Action<Humidifier.GreengrassV2.DeploymentTypes.DeploymentIoTJobConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIotJobConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<DeploymentFactory, T1, T2, T3, T4, InnerDeploymentDeploymentIoTJobConfigurationFactory> WithIotJobConfiguration<T1, T2, T3, T4>(this CombinedResult<DeploymentFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.GreengrassV2.DeploymentTypes.DeploymentIoTJobConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIotJobConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DeploymentFactory, T2, T3, T4, InnerDeploymentDeploymentIoTJobConfigurationFactory> WithIotJobConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, DeploymentFactory, T2, T3, T4> combinedResult, Action<Humidifier.GreengrassV2.DeploymentTypes.DeploymentIoTJobConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIotJobConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DeploymentFactory, T3, T4, InnerDeploymentDeploymentIoTJobConfigurationFactory> WithIotJobConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, DeploymentFactory, T3, T4> combinedResult, Action<Humidifier.GreengrassV2.DeploymentTypes.DeploymentIoTJobConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIotJobConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DeploymentFactory, T4, InnerDeploymentDeploymentIoTJobConfigurationFactory> WithIotJobConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, DeploymentFactory, T4> combinedResult, Action<Humidifier.GreengrassV2.DeploymentTypes.DeploymentIoTJobConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIotJobConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, DeploymentFactory, InnerDeploymentDeploymentIoTJobConfigurationFactory> WithIotJobConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, DeploymentFactory> combinedResult, Action<Humidifier.GreengrassV2.DeploymentTypes.DeploymentIoTJobConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIotJobConfiguration(combinedResult.T5, subFactoryAction));
    public static CombinedResult<DeploymentFactory, T1, InnerDeploymentDeploymentPoliciesFactory> WithDeploymentPolicies<T1>(this CombinedResult<DeploymentFactory, T1> combinedResult, Action<Humidifier.GreengrassV2.DeploymentTypes.DeploymentPolicies> subFactoryAction = null) => new (combinedResult, combinedResult, WithDeploymentPolicies(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DeploymentFactory, InnerDeploymentDeploymentPoliciesFactory> WithDeploymentPolicies<T1>(this CombinedResult<T1, DeploymentFactory> combinedResult, Action<Humidifier.GreengrassV2.DeploymentTypes.DeploymentPolicies> subFactoryAction = null) => new (combinedResult, combinedResult, WithDeploymentPolicies(combinedResult.T2, subFactoryAction));
    public static CombinedResult<DeploymentFactory, T1, T2, InnerDeploymentDeploymentPoliciesFactory> WithDeploymentPolicies<T1, T2>(this CombinedResult<DeploymentFactory, T1, T2> combinedResult, Action<Humidifier.GreengrassV2.DeploymentTypes.DeploymentPolicies> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDeploymentPolicies(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DeploymentFactory, T2, InnerDeploymentDeploymentPoliciesFactory> WithDeploymentPolicies<T1, T2>(this CombinedResult<T1, DeploymentFactory, T2> combinedResult, Action<Humidifier.GreengrassV2.DeploymentTypes.DeploymentPolicies> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDeploymentPolicies(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DeploymentFactory, InnerDeploymentDeploymentPoliciesFactory> WithDeploymentPolicies<T1, T2>(this CombinedResult<T1, T2, DeploymentFactory> combinedResult, Action<Humidifier.GreengrassV2.DeploymentTypes.DeploymentPolicies> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDeploymentPolicies(combinedResult.T3, subFactoryAction));
    public static CombinedResult<DeploymentFactory, T1, T2, T3, InnerDeploymentDeploymentPoliciesFactory> WithDeploymentPolicies<T1, T2, T3>(this CombinedResult<DeploymentFactory, T1, T2, T3> combinedResult, Action<Humidifier.GreengrassV2.DeploymentTypes.DeploymentPolicies> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDeploymentPolicies(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DeploymentFactory, T2, T3, InnerDeploymentDeploymentPoliciesFactory> WithDeploymentPolicies<T1, T2, T3>(this CombinedResult<T1, DeploymentFactory, T2, T3> combinedResult, Action<Humidifier.GreengrassV2.DeploymentTypes.DeploymentPolicies> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDeploymentPolicies(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DeploymentFactory, T3, InnerDeploymentDeploymentPoliciesFactory> WithDeploymentPolicies<T1, T2, T3>(this CombinedResult<T1, T2, DeploymentFactory, T3> combinedResult, Action<Humidifier.GreengrassV2.DeploymentTypes.DeploymentPolicies> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDeploymentPolicies(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DeploymentFactory, InnerDeploymentDeploymentPoliciesFactory> WithDeploymentPolicies<T1, T2, T3>(this CombinedResult<T1, T2, T3, DeploymentFactory> combinedResult, Action<Humidifier.GreengrassV2.DeploymentTypes.DeploymentPolicies> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDeploymentPolicies(combinedResult.T4, subFactoryAction));
    public static CombinedResult<DeploymentFactory, T1, T2, T3, T4, InnerDeploymentDeploymentPoliciesFactory> WithDeploymentPolicies<T1, T2, T3, T4>(this CombinedResult<DeploymentFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.GreengrassV2.DeploymentTypes.DeploymentPolicies> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDeploymentPolicies(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DeploymentFactory, T2, T3, T4, InnerDeploymentDeploymentPoliciesFactory> WithDeploymentPolicies<T1, T2, T3, T4>(this CombinedResult<T1, DeploymentFactory, T2, T3, T4> combinedResult, Action<Humidifier.GreengrassV2.DeploymentTypes.DeploymentPolicies> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDeploymentPolicies(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DeploymentFactory, T3, T4, InnerDeploymentDeploymentPoliciesFactory> WithDeploymentPolicies<T1, T2, T3, T4>(this CombinedResult<T1, T2, DeploymentFactory, T3, T4> combinedResult, Action<Humidifier.GreengrassV2.DeploymentTypes.DeploymentPolicies> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDeploymentPolicies(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DeploymentFactory, T4, InnerDeploymentDeploymentPoliciesFactory> WithDeploymentPolicies<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, DeploymentFactory, T4> combinedResult, Action<Humidifier.GreengrassV2.DeploymentTypes.DeploymentPolicies> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDeploymentPolicies(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, DeploymentFactory, InnerDeploymentDeploymentPoliciesFactory> WithDeploymentPolicies<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, DeploymentFactory> combinedResult, Action<Humidifier.GreengrassV2.DeploymentTypes.DeploymentPolicies> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDeploymentPolicies(combinedResult.T5, subFactoryAction));
}
