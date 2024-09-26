// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerLaunchTemplateInstanceMarketOptionsFactory(Action<Humidifier.EC2.LaunchTemplateTypes.InstanceMarketOptions> factoryAction = null) : SubResourceFactory<Humidifier.EC2.LaunchTemplateTypes.InstanceMarketOptions>
{

    internal InnerLaunchTemplateSpotOptionsFactory SpotOptionsFactory { get; set; }

    protected override Humidifier.EC2.LaunchTemplateTypes.InstanceMarketOptions Create()
    {
        var instanceMarketOptionsResult = CreateInstanceMarketOptions();
        factoryAction?.Invoke(instanceMarketOptionsResult);

        return instanceMarketOptionsResult;
    }

    private Humidifier.EC2.LaunchTemplateTypes.InstanceMarketOptions CreateInstanceMarketOptions()
    {
        var instanceMarketOptionsResult = new Humidifier.EC2.LaunchTemplateTypes.InstanceMarketOptions();

        return instanceMarketOptionsResult;
    }
    public override void CreateChildren(Humidifier.EC2.LaunchTemplateTypes.InstanceMarketOptions result)
    {
        base.CreateChildren(result);

        result.SpotOptions ??= SpotOptionsFactory?.Build();
    }

} // End Of Class

public static class InnerLaunchTemplateInstanceMarketOptionsFactoryExtensions
{
    public static CombinedResult<InnerLaunchTemplateInstanceMarketOptionsFactory, InnerLaunchTemplateSpotOptionsFactory> WithSpotOptions(this InnerLaunchTemplateInstanceMarketOptionsFactory parentFactory, Action<Humidifier.EC2.LaunchTemplateTypes.SpotOptions> subFactoryAction = null)
    {
        parentFactory.SpotOptionsFactory = new InnerLaunchTemplateSpotOptionsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SpotOptionsFactory);
    }

    public static CombinedResult<InnerLaunchTemplateInstanceMarketOptionsFactory, T1, InnerLaunchTemplateSpotOptionsFactory> WithSpotOptions<T1>(this CombinedResult<InnerLaunchTemplateInstanceMarketOptionsFactory, T1> combinedResult, Action<Humidifier.EC2.LaunchTemplateTypes.SpotOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithSpotOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerLaunchTemplateInstanceMarketOptionsFactory, InnerLaunchTemplateSpotOptionsFactory> WithSpotOptions<T1>(this CombinedResult<T1, InnerLaunchTemplateInstanceMarketOptionsFactory> combinedResult, Action<Humidifier.EC2.LaunchTemplateTypes.SpotOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithSpotOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerLaunchTemplateInstanceMarketOptionsFactory, T1, T2, InnerLaunchTemplateSpotOptionsFactory> WithSpotOptions<T1, T2>(this CombinedResult<InnerLaunchTemplateInstanceMarketOptionsFactory, T1, T2> combinedResult, Action<Humidifier.EC2.LaunchTemplateTypes.SpotOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSpotOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerLaunchTemplateInstanceMarketOptionsFactory, T2, InnerLaunchTemplateSpotOptionsFactory> WithSpotOptions<T1, T2>(this CombinedResult<T1, InnerLaunchTemplateInstanceMarketOptionsFactory, T2> combinedResult, Action<Humidifier.EC2.LaunchTemplateTypes.SpotOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSpotOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerLaunchTemplateInstanceMarketOptionsFactory, InnerLaunchTemplateSpotOptionsFactory> WithSpotOptions<T1, T2>(this CombinedResult<T1, T2, InnerLaunchTemplateInstanceMarketOptionsFactory> combinedResult, Action<Humidifier.EC2.LaunchTemplateTypes.SpotOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSpotOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerLaunchTemplateInstanceMarketOptionsFactory, T1, T2, T3, InnerLaunchTemplateSpotOptionsFactory> WithSpotOptions<T1, T2, T3>(this CombinedResult<InnerLaunchTemplateInstanceMarketOptionsFactory, T1, T2, T3> combinedResult, Action<Humidifier.EC2.LaunchTemplateTypes.SpotOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSpotOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerLaunchTemplateInstanceMarketOptionsFactory, T2, T3, InnerLaunchTemplateSpotOptionsFactory> WithSpotOptions<T1, T2, T3>(this CombinedResult<T1, InnerLaunchTemplateInstanceMarketOptionsFactory, T2, T3> combinedResult, Action<Humidifier.EC2.LaunchTemplateTypes.SpotOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSpotOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerLaunchTemplateInstanceMarketOptionsFactory, T3, InnerLaunchTemplateSpotOptionsFactory> WithSpotOptions<T1, T2, T3>(this CombinedResult<T1, T2, InnerLaunchTemplateInstanceMarketOptionsFactory, T3> combinedResult, Action<Humidifier.EC2.LaunchTemplateTypes.SpotOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSpotOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerLaunchTemplateInstanceMarketOptionsFactory, InnerLaunchTemplateSpotOptionsFactory> WithSpotOptions<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerLaunchTemplateInstanceMarketOptionsFactory> combinedResult, Action<Humidifier.EC2.LaunchTemplateTypes.SpotOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSpotOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerLaunchTemplateInstanceMarketOptionsFactory, T1, T2, T3, T4, InnerLaunchTemplateSpotOptionsFactory> WithSpotOptions<T1, T2, T3, T4>(this CombinedResult<InnerLaunchTemplateInstanceMarketOptionsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EC2.LaunchTemplateTypes.SpotOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpotOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerLaunchTemplateInstanceMarketOptionsFactory, T2, T3, T4, InnerLaunchTemplateSpotOptionsFactory> WithSpotOptions<T1, T2, T3, T4>(this CombinedResult<T1, InnerLaunchTemplateInstanceMarketOptionsFactory, T2, T3, T4> combinedResult, Action<Humidifier.EC2.LaunchTemplateTypes.SpotOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpotOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerLaunchTemplateInstanceMarketOptionsFactory, T3, T4, InnerLaunchTemplateSpotOptionsFactory> WithSpotOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerLaunchTemplateInstanceMarketOptionsFactory, T3, T4> combinedResult, Action<Humidifier.EC2.LaunchTemplateTypes.SpotOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpotOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerLaunchTemplateInstanceMarketOptionsFactory, T4, InnerLaunchTemplateSpotOptionsFactory> WithSpotOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerLaunchTemplateInstanceMarketOptionsFactory, T4> combinedResult, Action<Humidifier.EC2.LaunchTemplateTypes.SpotOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpotOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerLaunchTemplateInstanceMarketOptionsFactory, InnerLaunchTemplateSpotOptionsFactory> WithSpotOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerLaunchTemplateInstanceMarketOptionsFactory> combinedResult, Action<Humidifier.EC2.LaunchTemplateTypes.SpotOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpotOptions(combinedResult.T5, subFactoryAction));
}
