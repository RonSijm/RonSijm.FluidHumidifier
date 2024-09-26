// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECS;

public class InnerTaskSetNetworkConfigurationFactory(Action<Humidifier.ECS.TaskSetTypes.NetworkConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.ECS.TaskSetTypes.NetworkConfiguration>
{

    internal InnerTaskSetAwsVpcConfigurationFactory AwsVpcConfigurationFactory { get; set; }

    protected override Humidifier.ECS.TaskSetTypes.NetworkConfiguration Create()
    {
        var networkConfigurationResult = CreateNetworkConfiguration();
        factoryAction?.Invoke(networkConfigurationResult);

        return networkConfigurationResult;
    }

    private Humidifier.ECS.TaskSetTypes.NetworkConfiguration CreateNetworkConfiguration()
    {
        var networkConfigurationResult = new Humidifier.ECS.TaskSetTypes.NetworkConfiguration();

        return networkConfigurationResult;
    }
    public override void CreateChildren(Humidifier.ECS.TaskSetTypes.NetworkConfiguration result)
    {
        base.CreateChildren(result);

        result.AwsVpcConfiguration ??= AwsVpcConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerTaskSetNetworkConfigurationFactoryExtensions
{
    public static CombinedResult<InnerTaskSetNetworkConfigurationFactory, InnerTaskSetAwsVpcConfigurationFactory> WithAwsVpcConfiguration(this InnerTaskSetNetworkConfigurationFactory parentFactory, Action<Humidifier.ECS.TaskSetTypes.AwsVpcConfiguration> subFactoryAction = null)
    {
        parentFactory.AwsVpcConfigurationFactory = new InnerTaskSetAwsVpcConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AwsVpcConfigurationFactory);
    }

    public static CombinedResult<InnerTaskSetNetworkConfigurationFactory, T1, InnerTaskSetAwsVpcConfigurationFactory> WithAwsVpcConfiguration<T1>(this CombinedResult<InnerTaskSetNetworkConfigurationFactory, T1> combinedResult, Action<Humidifier.ECS.TaskSetTypes.AwsVpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithAwsVpcConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTaskSetNetworkConfigurationFactory, InnerTaskSetAwsVpcConfigurationFactory> WithAwsVpcConfiguration<T1>(this CombinedResult<T1, InnerTaskSetNetworkConfigurationFactory> combinedResult, Action<Humidifier.ECS.TaskSetTypes.AwsVpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithAwsVpcConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerTaskSetNetworkConfigurationFactory, T1, T2, InnerTaskSetAwsVpcConfigurationFactory> WithAwsVpcConfiguration<T1, T2>(this CombinedResult<InnerTaskSetNetworkConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.ECS.TaskSetTypes.AwsVpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAwsVpcConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTaskSetNetworkConfigurationFactory, T2, InnerTaskSetAwsVpcConfigurationFactory> WithAwsVpcConfiguration<T1, T2>(this CombinedResult<T1, InnerTaskSetNetworkConfigurationFactory, T2> combinedResult, Action<Humidifier.ECS.TaskSetTypes.AwsVpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAwsVpcConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTaskSetNetworkConfigurationFactory, InnerTaskSetAwsVpcConfigurationFactory> WithAwsVpcConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerTaskSetNetworkConfigurationFactory> combinedResult, Action<Humidifier.ECS.TaskSetTypes.AwsVpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAwsVpcConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerTaskSetNetworkConfigurationFactory, T1, T2, T3, InnerTaskSetAwsVpcConfigurationFactory> WithAwsVpcConfiguration<T1, T2, T3>(this CombinedResult<InnerTaskSetNetworkConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.ECS.TaskSetTypes.AwsVpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAwsVpcConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTaskSetNetworkConfigurationFactory, T2, T3, InnerTaskSetAwsVpcConfigurationFactory> WithAwsVpcConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerTaskSetNetworkConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.ECS.TaskSetTypes.AwsVpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAwsVpcConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTaskSetNetworkConfigurationFactory, T3, InnerTaskSetAwsVpcConfigurationFactory> WithAwsVpcConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerTaskSetNetworkConfigurationFactory, T3> combinedResult, Action<Humidifier.ECS.TaskSetTypes.AwsVpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAwsVpcConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTaskSetNetworkConfigurationFactory, InnerTaskSetAwsVpcConfigurationFactory> WithAwsVpcConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerTaskSetNetworkConfigurationFactory> combinedResult, Action<Humidifier.ECS.TaskSetTypes.AwsVpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAwsVpcConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerTaskSetNetworkConfigurationFactory, T1, T2, T3, T4, InnerTaskSetAwsVpcConfigurationFactory> WithAwsVpcConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerTaskSetNetworkConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ECS.TaskSetTypes.AwsVpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAwsVpcConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTaskSetNetworkConfigurationFactory, T2, T3, T4, InnerTaskSetAwsVpcConfigurationFactory> WithAwsVpcConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerTaskSetNetworkConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.ECS.TaskSetTypes.AwsVpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAwsVpcConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTaskSetNetworkConfigurationFactory, T3, T4, InnerTaskSetAwsVpcConfigurationFactory> WithAwsVpcConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerTaskSetNetworkConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.ECS.TaskSetTypes.AwsVpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAwsVpcConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTaskSetNetworkConfigurationFactory, T4, InnerTaskSetAwsVpcConfigurationFactory> WithAwsVpcConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerTaskSetNetworkConfigurationFactory, T4> combinedResult, Action<Humidifier.ECS.TaskSetTypes.AwsVpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAwsVpcConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerTaskSetNetworkConfigurationFactory, InnerTaskSetAwsVpcConfigurationFactory> WithAwsVpcConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerTaskSetNetworkConfigurationFactory> combinedResult, Action<Humidifier.ECS.TaskSetTypes.AwsVpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAwsVpcConfiguration(combinedResult.T5, subFactoryAction));
}
