// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerCapacityProviderComputeConfigurationFactory(Action<Humidifier.BedrockAgentCore.CapacityProviderTypes.ComputeConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.CapacityProviderTypes.ComputeConfiguration>
{

    internal InnerCapacityProviderEc2ConfigurationFactory Ec2ConfigurationFactory { get; set; }

    protected override Humidifier.BedrockAgentCore.CapacityProviderTypes.ComputeConfiguration Create()
    {
        var computeConfigurationResult = CreateComputeConfiguration();
        factoryAction?.Invoke(computeConfigurationResult);

        return computeConfigurationResult;
    }

    private Humidifier.BedrockAgentCore.CapacityProviderTypes.ComputeConfiguration CreateComputeConfiguration()
    {
        var computeConfigurationResult = new Humidifier.BedrockAgentCore.CapacityProviderTypes.ComputeConfiguration();

        return computeConfigurationResult;
    }
    public override void CreateChildren(Humidifier.BedrockAgentCore.CapacityProviderTypes.ComputeConfiguration result)
    {
        base.CreateChildren(result);

        result.Ec2Configuration ??= Ec2ConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerCapacityProviderComputeConfigurationFactoryExtensions
{
    public static CombinedResult<InnerCapacityProviderComputeConfigurationFactory, InnerCapacityProviderEc2ConfigurationFactory> WithEc2Configuration(this InnerCapacityProviderComputeConfigurationFactory parentFactory, Action<Humidifier.BedrockAgentCore.CapacityProviderTypes.Ec2Configuration> subFactoryAction = null)
    {
        parentFactory.Ec2ConfigurationFactory = new InnerCapacityProviderEc2ConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.Ec2ConfigurationFactory);
    }

    public static CombinedResult<InnerCapacityProviderComputeConfigurationFactory, T1, InnerCapacityProviderEc2ConfigurationFactory> WithEc2Configuration<T1>(this CombinedResult<InnerCapacityProviderComputeConfigurationFactory, T1> combinedResult, Action<Humidifier.BedrockAgentCore.CapacityProviderTypes.Ec2Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, WithEc2Configuration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCapacityProviderComputeConfigurationFactory, InnerCapacityProviderEc2ConfigurationFactory> WithEc2Configuration<T1>(this CombinedResult<T1, InnerCapacityProviderComputeConfigurationFactory> combinedResult, Action<Humidifier.BedrockAgentCore.CapacityProviderTypes.Ec2Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, WithEc2Configuration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerCapacityProviderComputeConfigurationFactory, T1, T2, InnerCapacityProviderEc2ConfigurationFactory> WithEc2Configuration<T1, T2>(this CombinedResult<InnerCapacityProviderComputeConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.BedrockAgentCore.CapacityProviderTypes.Ec2Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEc2Configuration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCapacityProviderComputeConfigurationFactory, T2, InnerCapacityProviderEc2ConfigurationFactory> WithEc2Configuration<T1, T2>(this CombinedResult<T1, InnerCapacityProviderComputeConfigurationFactory, T2> combinedResult, Action<Humidifier.BedrockAgentCore.CapacityProviderTypes.Ec2Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEc2Configuration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerCapacityProviderComputeConfigurationFactory, InnerCapacityProviderEc2ConfigurationFactory> WithEc2Configuration<T1, T2>(this CombinedResult<T1, T2, InnerCapacityProviderComputeConfigurationFactory> combinedResult, Action<Humidifier.BedrockAgentCore.CapacityProviderTypes.Ec2Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEc2Configuration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerCapacityProviderComputeConfigurationFactory, T1, T2, T3, InnerCapacityProviderEc2ConfigurationFactory> WithEc2Configuration<T1, T2, T3>(this CombinedResult<InnerCapacityProviderComputeConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.CapacityProviderTypes.Ec2Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEc2Configuration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCapacityProviderComputeConfigurationFactory, T2, T3, InnerCapacityProviderEc2ConfigurationFactory> WithEc2Configuration<T1, T2, T3>(this CombinedResult<T1, InnerCapacityProviderComputeConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.CapacityProviderTypes.Ec2Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEc2Configuration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerCapacityProviderComputeConfigurationFactory, T3, InnerCapacityProviderEc2ConfigurationFactory> WithEc2Configuration<T1, T2, T3>(this CombinedResult<T1, T2, InnerCapacityProviderComputeConfigurationFactory, T3> combinedResult, Action<Humidifier.BedrockAgentCore.CapacityProviderTypes.Ec2Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEc2Configuration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerCapacityProviderComputeConfigurationFactory, InnerCapacityProviderEc2ConfigurationFactory> WithEc2Configuration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerCapacityProviderComputeConfigurationFactory> combinedResult, Action<Humidifier.BedrockAgentCore.CapacityProviderTypes.Ec2Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEc2Configuration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerCapacityProviderComputeConfigurationFactory, T1, T2, T3, T4, InnerCapacityProviderEc2ConfigurationFactory> WithEc2Configuration<T1, T2, T3, T4>(this CombinedResult<InnerCapacityProviderComputeConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.CapacityProviderTypes.Ec2Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEc2Configuration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCapacityProviderComputeConfigurationFactory, T2, T3, T4, InnerCapacityProviderEc2ConfigurationFactory> WithEc2Configuration<T1, T2, T3, T4>(this CombinedResult<T1, InnerCapacityProviderComputeConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.CapacityProviderTypes.Ec2Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEc2Configuration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerCapacityProviderComputeConfigurationFactory, T3, T4, InnerCapacityProviderEc2ConfigurationFactory> WithEc2Configuration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerCapacityProviderComputeConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.CapacityProviderTypes.Ec2Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEc2Configuration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerCapacityProviderComputeConfigurationFactory, T4, InnerCapacityProviderEc2ConfigurationFactory> WithEc2Configuration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerCapacityProviderComputeConfigurationFactory, T4> combinedResult, Action<Humidifier.BedrockAgentCore.CapacityProviderTypes.Ec2Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEc2Configuration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerCapacityProviderComputeConfigurationFactory, InnerCapacityProviderEc2ConfigurationFactory> WithEc2Configuration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerCapacityProviderComputeConfigurationFactory> combinedResult, Action<Humidifier.BedrockAgentCore.CapacityProviderTypes.Ec2Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEc2Configuration(combinedResult.T5, subFactoryAction).T2);
}
