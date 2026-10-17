// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class InnerRouterOutputStandardRouterOutputConfigurationFactory(Action<Humidifier.MediaConnect.RouterOutputTypes.StandardRouterOutputConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.MediaConnect.RouterOutputTypes.StandardRouterOutputConfiguration>
{

    internal InnerRouterOutputRouterOutputProtocolConfigurationFactory ProtocolConfigurationFactory { get; set; }

    protected override Humidifier.MediaConnect.RouterOutputTypes.StandardRouterOutputConfiguration Create()
    {
        var standardRouterOutputConfigurationResult = CreateStandardRouterOutputConfiguration();
        factoryAction?.Invoke(standardRouterOutputConfigurationResult);

        return standardRouterOutputConfigurationResult;
    }

    private Humidifier.MediaConnect.RouterOutputTypes.StandardRouterOutputConfiguration CreateStandardRouterOutputConfiguration()
    {
        var standardRouterOutputConfigurationResult = new Humidifier.MediaConnect.RouterOutputTypes.StandardRouterOutputConfiguration();

        return standardRouterOutputConfigurationResult;
    }
    public override void CreateChildren(Humidifier.MediaConnect.RouterOutputTypes.StandardRouterOutputConfiguration result)
    {
        base.CreateChildren(result);

        result.ProtocolConfiguration ??= ProtocolConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerRouterOutputStandardRouterOutputConfigurationFactoryExtensions
{
    public static CombinedResult<InnerRouterOutputStandardRouterOutputConfigurationFactory, InnerRouterOutputRouterOutputProtocolConfigurationFactory> WithProtocolConfiguration(this InnerRouterOutputStandardRouterOutputConfigurationFactory parentFactory, Action<Humidifier.MediaConnect.RouterOutputTypes.RouterOutputProtocolConfiguration> subFactoryAction = null)
    {
        parentFactory.ProtocolConfigurationFactory = new InnerRouterOutputRouterOutputProtocolConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ProtocolConfigurationFactory);
    }

    public static CombinedResult<InnerRouterOutputStandardRouterOutputConfigurationFactory, T1, InnerRouterOutputRouterOutputProtocolConfigurationFactory> WithProtocolConfiguration<T1>(this CombinedResult<InnerRouterOutputStandardRouterOutputConfigurationFactory, T1> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.RouterOutputProtocolConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithProtocolConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRouterOutputStandardRouterOutputConfigurationFactory, InnerRouterOutputRouterOutputProtocolConfigurationFactory> WithProtocolConfiguration<T1>(this CombinedResult<T1, InnerRouterOutputStandardRouterOutputConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.RouterOutputProtocolConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithProtocolConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerRouterOutputStandardRouterOutputConfigurationFactory, T1, T2, InnerRouterOutputRouterOutputProtocolConfigurationFactory> WithProtocolConfiguration<T1, T2>(this CombinedResult<InnerRouterOutputStandardRouterOutputConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.RouterOutputProtocolConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithProtocolConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRouterOutputStandardRouterOutputConfigurationFactory, T2, InnerRouterOutputRouterOutputProtocolConfigurationFactory> WithProtocolConfiguration<T1, T2>(this CombinedResult<T1, InnerRouterOutputStandardRouterOutputConfigurationFactory, T2> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.RouterOutputProtocolConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithProtocolConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRouterOutputStandardRouterOutputConfigurationFactory, InnerRouterOutputRouterOutputProtocolConfigurationFactory> WithProtocolConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerRouterOutputStandardRouterOutputConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.RouterOutputProtocolConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithProtocolConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerRouterOutputStandardRouterOutputConfigurationFactory, T1, T2, T3, InnerRouterOutputRouterOutputProtocolConfigurationFactory> WithProtocolConfiguration<T1, T2, T3>(this CombinedResult<InnerRouterOutputStandardRouterOutputConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.RouterOutputProtocolConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProtocolConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRouterOutputStandardRouterOutputConfigurationFactory, T2, T3, InnerRouterOutputRouterOutputProtocolConfigurationFactory> WithProtocolConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerRouterOutputStandardRouterOutputConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.RouterOutputProtocolConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProtocolConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRouterOutputStandardRouterOutputConfigurationFactory, T3, InnerRouterOutputRouterOutputProtocolConfigurationFactory> WithProtocolConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerRouterOutputStandardRouterOutputConfigurationFactory, T3> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.RouterOutputProtocolConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProtocolConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerRouterOutputStandardRouterOutputConfigurationFactory, InnerRouterOutputRouterOutputProtocolConfigurationFactory> WithProtocolConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerRouterOutputStandardRouterOutputConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.RouterOutputProtocolConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProtocolConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerRouterOutputStandardRouterOutputConfigurationFactory, T1, T2, T3, T4, InnerRouterOutputRouterOutputProtocolConfigurationFactory> WithProtocolConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerRouterOutputStandardRouterOutputConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.RouterOutputProtocolConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProtocolConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRouterOutputStandardRouterOutputConfigurationFactory, T2, T3, T4, InnerRouterOutputRouterOutputProtocolConfigurationFactory> WithProtocolConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerRouterOutputStandardRouterOutputConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.RouterOutputProtocolConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProtocolConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRouterOutputStandardRouterOutputConfigurationFactory, T3, T4, InnerRouterOutputRouterOutputProtocolConfigurationFactory> WithProtocolConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerRouterOutputStandardRouterOutputConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.RouterOutputProtocolConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProtocolConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerRouterOutputStandardRouterOutputConfigurationFactory, T4, InnerRouterOutputRouterOutputProtocolConfigurationFactory> WithProtocolConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerRouterOutputStandardRouterOutputConfigurationFactory, T4> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.RouterOutputProtocolConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProtocolConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerRouterOutputStandardRouterOutputConfigurationFactory, InnerRouterOutputRouterOutputProtocolConfigurationFactory> WithProtocolConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerRouterOutputStandardRouterOutputConfigurationFactory> combinedResult, Action<Humidifier.MediaConnect.RouterOutputTypes.RouterOutputProtocolConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProtocolConfiguration(combinedResult.T5, subFactoryAction).T2);
}
