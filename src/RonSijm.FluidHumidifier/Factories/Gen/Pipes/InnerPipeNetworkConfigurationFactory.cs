// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Pipes;

public class InnerPipeNetworkConfigurationFactory(Action<Humidifier.Pipes.PipeTypes.NetworkConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Pipes.PipeTypes.NetworkConfiguration>
{

    internal InnerPipeAwsVpcConfigurationFactory AwsvpcConfigurationFactory { get; set; }

    protected override Humidifier.Pipes.PipeTypes.NetworkConfiguration Create()
    {
        var networkConfigurationResult = CreateNetworkConfiguration();
        factoryAction?.Invoke(networkConfigurationResult);

        return networkConfigurationResult;
    }

    private Humidifier.Pipes.PipeTypes.NetworkConfiguration CreateNetworkConfiguration()
    {
        var networkConfigurationResult = new Humidifier.Pipes.PipeTypes.NetworkConfiguration();

        return networkConfigurationResult;
    }
    public override void CreateChildren(Humidifier.Pipes.PipeTypes.NetworkConfiguration result)
    {
        base.CreateChildren(result);

        result.AwsvpcConfiguration ??= AwsvpcConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerPipeNetworkConfigurationFactoryExtensions
{
    public static CombinedResult<InnerPipeNetworkConfigurationFactory, InnerPipeAwsVpcConfigurationFactory> WithAwsvpcConfiguration(this InnerPipeNetworkConfigurationFactory parentFactory, Action<Humidifier.Pipes.PipeTypes.AwsVpcConfiguration> subFactoryAction = null)
    {
        parentFactory.AwsvpcConfigurationFactory = new InnerPipeAwsVpcConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AwsvpcConfigurationFactory);
    }

    public static CombinedResult<InnerPipeNetworkConfigurationFactory, T1, InnerPipeAwsVpcConfigurationFactory> WithAwsvpcConfiguration<T1>(this CombinedResult<InnerPipeNetworkConfigurationFactory, T1> combinedResult, Action<Humidifier.Pipes.PipeTypes.AwsVpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithAwsvpcConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPipeNetworkConfigurationFactory, InnerPipeAwsVpcConfigurationFactory> WithAwsvpcConfiguration<T1>(this CombinedResult<T1, InnerPipeNetworkConfigurationFactory> combinedResult, Action<Humidifier.Pipes.PipeTypes.AwsVpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithAwsvpcConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerPipeNetworkConfigurationFactory, T1, T2, InnerPipeAwsVpcConfigurationFactory> WithAwsvpcConfiguration<T1, T2>(this CombinedResult<InnerPipeNetworkConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.Pipes.PipeTypes.AwsVpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAwsvpcConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPipeNetworkConfigurationFactory, T2, InnerPipeAwsVpcConfigurationFactory> WithAwsvpcConfiguration<T1, T2>(this CombinedResult<T1, InnerPipeNetworkConfigurationFactory, T2> combinedResult, Action<Humidifier.Pipes.PipeTypes.AwsVpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAwsvpcConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPipeNetworkConfigurationFactory, InnerPipeAwsVpcConfigurationFactory> WithAwsvpcConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerPipeNetworkConfigurationFactory> combinedResult, Action<Humidifier.Pipes.PipeTypes.AwsVpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAwsvpcConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerPipeNetworkConfigurationFactory, T1, T2, T3, InnerPipeAwsVpcConfigurationFactory> WithAwsvpcConfiguration<T1, T2, T3>(this CombinedResult<InnerPipeNetworkConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Pipes.PipeTypes.AwsVpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAwsvpcConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPipeNetworkConfigurationFactory, T2, T3, InnerPipeAwsVpcConfigurationFactory> WithAwsvpcConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerPipeNetworkConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.Pipes.PipeTypes.AwsVpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAwsvpcConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPipeNetworkConfigurationFactory, T3, InnerPipeAwsVpcConfigurationFactory> WithAwsvpcConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerPipeNetworkConfigurationFactory, T3> combinedResult, Action<Humidifier.Pipes.PipeTypes.AwsVpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAwsvpcConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerPipeNetworkConfigurationFactory, InnerPipeAwsVpcConfigurationFactory> WithAwsvpcConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerPipeNetworkConfigurationFactory> combinedResult, Action<Humidifier.Pipes.PipeTypes.AwsVpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAwsvpcConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerPipeNetworkConfigurationFactory, T1, T2, T3, T4, InnerPipeAwsVpcConfigurationFactory> WithAwsvpcConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerPipeNetworkConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Pipes.PipeTypes.AwsVpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAwsvpcConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPipeNetworkConfigurationFactory, T2, T3, T4, InnerPipeAwsVpcConfigurationFactory> WithAwsvpcConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerPipeNetworkConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Pipes.PipeTypes.AwsVpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAwsvpcConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPipeNetworkConfigurationFactory, T3, T4, InnerPipeAwsVpcConfigurationFactory> WithAwsvpcConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerPipeNetworkConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.Pipes.PipeTypes.AwsVpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAwsvpcConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerPipeNetworkConfigurationFactory, T4, InnerPipeAwsVpcConfigurationFactory> WithAwsvpcConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerPipeNetworkConfigurationFactory, T4> combinedResult, Action<Humidifier.Pipes.PipeTypes.AwsVpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAwsvpcConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerPipeNetworkConfigurationFactory, InnerPipeAwsVpcConfigurationFactory> WithAwsvpcConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerPipeNetworkConfigurationFactory> combinedResult, Action<Humidifier.Pipes.PipeTypes.AwsVpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAwsvpcConfiguration(combinedResult.T5, subFactoryAction));
}
