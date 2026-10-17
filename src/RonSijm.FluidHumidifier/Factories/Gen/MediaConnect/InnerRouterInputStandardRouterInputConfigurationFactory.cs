// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class InnerRouterInputStandardRouterInputConfigurationFactory(Action<Humidifier.MediaConnect.RouterInputTypes.StandardRouterInputConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.MediaConnect.RouterInputTypes.StandardRouterInputConfiguration>
{

    internal InnerRouterInputRouterInputProtocolConfigurationFactory ProtocolConfigurationFactory { get; set; }

    protected override Humidifier.MediaConnect.RouterInputTypes.StandardRouterInputConfiguration Create()
    {
        var standardRouterInputConfigurationResult = CreateStandardRouterInputConfiguration();
        factoryAction?.Invoke(standardRouterInputConfigurationResult);

        return standardRouterInputConfigurationResult;
    }

    private Humidifier.MediaConnect.RouterInputTypes.StandardRouterInputConfiguration CreateStandardRouterInputConfiguration()
    {
        var standardRouterInputConfigurationResult = new Humidifier.MediaConnect.RouterInputTypes.StandardRouterInputConfiguration();

        return standardRouterInputConfigurationResult;
    }
    public override void CreateChildren(Humidifier.MediaConnect.RouterInputTypes.StandardRouterInputConfiguration result)
    {
        base.CreateChildren(result);

        result.ProtocolConfiguration ??= ProtocolConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerRouterInputStandardRouterInputConfigurationFactoryExtensions
{
    public static CombinedResult<InnerRouterInputStandardRouterInputConfigurationFactory, InnerRouterInputRouterInputProtocolConfigurationFactory> WithProtocolConfiguration(this InnerRouterInputStandardRouterInputConfigurationFactory parentFactory, Action<Humidifier.MediaConnect.RouterInputTypes.RouterInputProtocolConfiguration> subFactoryAction = null)
    {
        parentFactory.ProtocolConfigurationFactory = new InnerRouterInputRouterInputProtocolConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ProtocolConfigurationFactory);
    }

    public static CombinedResult<InnerRouterInputStandardRouterInputConfigurationFactory, T1, InnerRouterInputRouterInputProtocolConfigurationFactory> WithProtocolConfiguration<T1>(this CombinedResult<InnerRouterInputStandardRouterInputConfigurationFactory, T1> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.RouterInputProtocolConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithProtocolConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRouterInputStandardRouterInputConfigurationFactory, InnerRouterInputRouterInputProtocolConfigurationFactory> WithProtocolConfiguration<T1>(this CombinedResult<T1, InnerRouterInputStandardRouterInputConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.RouterInputProtocolConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithProtocolConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerRouterInputStandardRouterInputConfigurationFactory, T1, T2, InnerRouterInputRouterInputProtocolConfigurationFactory> WithProtocolConfiguration<T1, T2>(this CombinedResult<InnerRouterInputStandardRouterInputConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.RouterInputProtocolConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithProtocolConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRouterInputStandardRouterInputConfigurationFactory, T2, InnerRouterInputRouterInputProtocolConfigurationFactory> WithProtocolConfiguration<T1, T2>(this CombinedResult<T1, InnerRouterInputStandardRouterInputConfigurationFactory, T2> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.RouterInputProtocolConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithProtocolConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRouterInputStandardRouterInputConfigurationFactory, InnerRouterInputRouterInputProtocolConfigurationFactory> WithProtocolConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerRouterInputStandardRouterInputConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.RouterInputProtocolConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithProtocolConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerRouterInputStandardRouterInputConfigurationFactory, T1, T2, T3, InnerRouterInputRouterInputProtocolConfigurationFactory> WithProtocolConfiguration<T1, T2, T3>(this CombinedResult<InnerRouterInputStandardRouterInputConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.RouterInputProtocolConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProtocolConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRouterInputStandardRouterInputConfigurationFactory, T2, T3, InnerRouterInputRouterInputProtocolConfigurationFactory> WithProtocolConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerRouterInputStandardRouterInputConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.RouterInputProtocolConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProtocolConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRouterInputStandardRouterInputConfigurationFactory, T3, InnerRouterInputRouterInputProtocolConfigurationFactory> WithProtocolConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerRouterInputStandardRouterInputConfigurationFactory, T3> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.RouterInputProtocolConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProtocolConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerRouterInputStandardRouterInputConfigurationFactory, InnerRouterInputRouterInputProtocolConfigurationFactory> WithProtocolConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerRouterInputStandardRouterInputConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.RouterInputProtocolConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProtocolConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerRouterInputStandardRouterInputConfigurationFactory, T1, T2, T3, T4, InnerRouterInputRouterInputProtocolConfigurationFactory> WithProtocolConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerRouterInputStandardRouterInputConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.RouterInputProtocolConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProtocolConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRouterInputStandardRouterInputConfigurationFactory, T2, T3, T4, InnerRouterInputRouterInputProtocolConfigurationFactory> WithProtocolConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerRouterInputStandardRouterInputConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.RouterInputProtocolConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProtocolConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRouterInputStandardRouterInputConfigurationFactory, T3, T4, InnerRouterInputRouterInputProtocolConfigurationFactory> WithProtocolConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerRouterInputStandardRouterInputConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.RouterInputProtocolConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProtocolConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerRouterInputStandardRouterInputConfigurationFactory, T4, InnerRouterInputRouterInputProtocolConfigurationFactory> WithProtocolConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerRouterInputStandardRouterInputConfigurationFactory, T4> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.RouterInputProtocolConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProtocolConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerRouterInputStandardRouterInputConfigurationFactory, InnerRouterInputRouterInputProtocolConfigurationFactory> WithProtocolConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerRouterInputStandardRouterInputConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.RouterInputTypes.RouterInputProtocolConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProtocolConfiguration(combinedResult.T5, subFactoryAction).T2);
}
