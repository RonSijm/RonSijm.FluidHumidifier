// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class CapacityProviderFactory(string resourceName = null, Action<Humidifier.BedrockAgentCore.CapacityProvider> factoryAction = null) : ResourceFactory<Humidifier.BedrockAgentCore.CapacityProvider>(resourceName)
{

    internal InnerCapacityProviderPermissionsConfigurationFactory PermissionsConfigurationFactory { get; set; }

    internal InnerCapacityProviderComputeConfigurationFactory ComputeConfigurationFactory { get; set; }

    protected override Humidifier.BedrockAgentCore.CapacityProvider Create()
    {
        var capacityProviderResult = CreateCapacityProvider();
        factoryAction?.Invoke(capacityProviderResult);

        return capacityProviderResult;
    }

    private Humidifier.BedrockAgentCore.CapacityProvider CreateCapacityProvider()
    {
        var capacityProviderResult = new Humidifier.BedrockAgentCore.CapacityProvider
        {
            GivenName = InputResourceName,
        };

        return capacityProviderResult;
    }
    public override void CreateChildren(Humidifier.BedrockAgentCore.CapacityProvider result)
    {
        base.CreateChildren(result);

        result.PermissionsConfiguration ??= PermissionsConfigurationFactory?.Build();
        result.ComputeConfiguration ??= ComputeConfigurationFactory?.Build();
    }

} // End Of Class

public static class CapacityProviderFactoryExtensions
{
    public static CombinedResult<CapacityProviderFactory, InnerCapacityProviderPermissionsConfigurationFactory> WithPermissionsConfiguration(this CapacityProviderFactory parentFactory, Action<Humidifier.BedrockAgentCore.CapacityProviderTypes.PermissionsConfiguration> subFactoryAction = null)
    {
        parentFactory.PermissionsConfigurationFactory = new InnerCapacityProviderPermissionsConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.PermissionsConfigurationFactory);
    }

    public static CombinedResult<CapacityProviderFactory, InnerCapacityProviderComputeConfigurationFactory> WithComputeConfiguration(this CapacityProviderFactory parentFactory, Action<Humidifier.BedrockAgentCore.CapacityProviderTypes.ComputeConfiguration> subFactoryAction = null)
    {
        parentFactory.ComputeConfigurationFactory = new InnerCapacityProviderComputeConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ComputeConfigurationFactory);
    }

    public static CombinedResult<CapacityProviderFactory, T1, InnerCapacityProviderPermissionsConfigurationFactory> WithPermissionsConfiguration<T1>(this CombinedResult<CapacityProviderFactory, T1> combinedResult, Action<Humidifier.BedrockAgentCore.CapacityProviderTypes.PermissionsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithPermissionsConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, CapacityProviderFactory, InnerCapacityProviderPermissionsConfigurationFactory> WithPermissionsConfiguration<T1>(this CombinedResult<T1, CapacityProviderFactory> combinedResult, Action<Humidifier.BedrockAgentCore.CapacityProviderTypes.PermissionsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithPermissionsConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<CapacityProviderFactory, T1, T2, InnerCapacityProviderPermissionsConfigurationFactory> WithPermissionsConfiguration<T1, T2>(this CombinedResult<CapacityProviderFactory, T1, T2> combinedResult, Action<Humidifier.BedrockAgentCore.CapacityProviderTypes.PermissionsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPermissionsConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, CapacityProviderFactory, T2, InnerCapacityProviderPermissionsConfigurationFactory> WithPermissionsConfiguration<T1, T2>(this CombinedResult<T1, CapacityProviderFactory, T2> combinedResult, Action<Humidifier.BedrockAgentCore.CapacityProviderTypes.PermissionsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPermissionsConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, CapacityProviderFactory, InnerCapacityProviderPermissionsConfigurationFactory> WithPermissionsConfiguration<T1, T2>(this CombinedResult<T1, T2, CapacityProviderFactory> combinedResult, Action<Humidifier.BedrockAgentCore.CapacityProviderTypes.PermissionsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPermissionsConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<CapacityProviderFactory, T1, T2, T3, InnerCapacityProviderPermissionsConfigurationFactory> WithPermissionsConfiguration<T1, T2, T3>(this CombinedResult<CapacityProviderFactory, T1, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.CapacityProviderTypes.PermissionsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPermissionsConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, CapacityProviderFactory, T2, T3, InnerCapacityProviderPermissionsConfigurationFactory> WithPermissionsConfiguration<T1, T2, T3>(this CombinedResult<T1, CapacityProviderFactory, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.CapacityProviderTypes.PermissionsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPermissionsConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, CapacityProviderFactory, T3, InnerCapacityProviderPermissionsConfigurationFactory> WithPermissionsConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, CapacityProviderFactory, T3> combinedResult, Action<Humidifier.BedrockAgentCore.CapacityProviderTypes.PermissionsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPermissionsConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, CapacityProviderFactory, InnerCapacityProviderPermissionsConfigurationFactory> WithPermissionsConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, CapacityProviderFactory> combinedResult, Action<Humidifier.BedrockAgentCore.CapacityProviderTypes.PermissionsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPermissionsConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<CapacityProviderFactory, T1, T2, T3, T4, InnerCapacityProviderPermissionsConfigurationFactory> WithPermissionsConfiguration<T1, T2, T3, T4>(this CombinedResult<CapacityProviderFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.CapacityProviderTypes.PermissionsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPermissionsConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, CapacityProviderFactory, T2, T3, T4, InnerCapacityProviderPermissionsConfigurationFactory> WithPermissionsConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, CapacityProviderFactory, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.CapacityProviderTypes.PermissionsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPermissionsConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, CapacityProviderFactory, T3, T4, InnerCapacityProviderPermissionsConfigurationFactory> WithPermissionsConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, CapacityProviderFactory, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.CapacityProviderTypes.PermissionsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPermissionsConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, CapacityProviderFactory, T4, InnerCapacityProviderPermissionsConfigurationFactory> WithPermissionsConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, CapacityProviderFactory, T4> combinedResult, Action<Humidifier.BedrockAgentCore.CapacityProviderTypes.PermissionsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPermissionsConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, CapacityProviderFactory, InnerCapacityProviderPermissionsConfigurationFactory> WithPermissionsConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, CapacityProviderFactory> combinedResult, Action<Humidifier.BedrockAgentCore.CapacityProviderTypes.PermissionsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPermissionsConfiguration(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<CapacityProviderFactory, T1, InnerCapacityProviderComputeConfigurationFactory> WithComputeConfiguration<T1>(this CombinedResult<CapacityProviderFactory, T1> combinedResult, Action<Humidifier.BedrockAgentCore.CapacityProviderTypes.ComputeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithComputeConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, CapacityProviderFactory, InnerCapacityProviderComputeConfigurationFactory> WithComputeConfiguration<T1>(this CombinedResult<T1, CapacityProviderFactory> combinedResult, Action<Humidifier.BedrockAgentCore.CapacityProviderTypes.ComputeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithComputeConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<CapacityProviderFactory, T1, T2, InnerCapacityProviderComputeConfigurationFactory> WithComputeConfiguration<T1, T2>(this CombinedResult<CapacityProviderFactory, T1, T2> combinedResult, Action<Humidifier.BedrockAgentCore.CapacityProviderTypes.ComputeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithComputeConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, CapacityProviderFactory, T2, InnerCapacityProviderComputeConfigurationFactory> WithComputeConfiguration<T1, T2>(this CombinedResult<T1, CapacityProviderFactory, T2> combinedResult, Action<Humidifier.BedrockAgentCore.CapacityProviderTypes.ComputeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithComputeConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, CapacityProviderFactory, InnerCapacityProviderComputeConfigurationFactory> WithComputeConfiguration<T1, T2>(this CombinedResult<T1, T2, CapacityProviderFactory> combinedResult, Action<Humidifier.BedrockAgentCore.CapacityProviderTypes.ComputeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithComputeConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<CapacityProviderFactory, T1, T2, T3, InnerCapacityProviderComputeConfigurationFactory> WithComputeConfiguration<T1, T2, T3>(this CombinedResult<CapacityProviderFactory, T1, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.CapacityProviderTypes.ComputeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithComputeConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, CapacityProviderFactory, T2, T3, InnerCapacityProviderComputeConfigurationFactory> WithComputeConfiguration<T1, T2, T3>(this CombinedResult<T1, CapacityProviderFactory, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.CapacityProviderTypes.ComputeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithComputeConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, CapacityProviderFactory, T3, InnerCapacityProviderComputeConfigurationFactory> WithComputeConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, CapacityProviderFactory, T3> combinedResult, Action<Humidifier.BedrockAgentCore.CapacityProviderTypes.ComputeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithComputeConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, CapacityProviderFactory, InnerCapacityProviderComputeConfigurationFactory> WithComputeConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, CapacityProviderFactory> combinedResult, Action<Humidifier.BedrockAgentCore.CapacityProviderTypes.ComputeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithComputeConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<CapacityProviderFactory, T1, T2, T3, T4, InnerCapacityProviderComputeConfigurationFactory> WithComputeConfiguration<T1, T2, T3, T4>(this CombinedResult<CapacityProviderFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.CapacityProviderTypes.ComputeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithComputeConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, CapacityProviderFactory, T2, T3, T4, InnerCapacityProviderComputeConfigurationFactory> WithComputeConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, CapacityProviderFactory, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.CapacityProviderTypes.ComputeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithComputeConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, CapacityProviderFactory, T3, T4, InnerCapacityProviderComputeConfigurationFactory> WithComputeConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, CapacityProviderFactory, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.CapacityProviderTypes.ComputeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithComputeConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, CapacityProviderFactory, T4, InnerCapacityProviderComputeConfigurationFactory> WithComputeConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, CapacityProviderFactory, T4> combinedResult, Action<Humidifier.BedrockAgentCore.CapacityProviderTypes.ComputeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithComputeConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, CapacityProviderFactory, InnerCapacityProviderComputeConfigurationFactory> WithComputeConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, CapacityProviderFactory> combinedResult, Action<Humidifier.BedrockAgentCore.CapacityProviderTypes.ComputeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithComputeConfiguration(combinedResult.T5, subFactoryAction).T2);
}
