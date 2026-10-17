// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CodeConnections;

public class HostFactory(string resourceName = null, Action<Humidifier.CodeConnections.Host> factoryAction = null) : ResourceFactory<Humidifier.CodeConnections.Host>(resourceName)
{

    internal InnerHostVpcConfigurationFactory VpcConfigurationFactory { get; set; }

    protected override Humidifier.CodeConnections.Host Create()
    {
        var hostResult = CreateHost();
        factoryAction?.Invoke(hostResult);

        return hostResult;
    }

    private Humidifier.CodeConnections.Host CreateHost()
    {
        var hostResult = new Humidifier.CodeConnections.Host
        {
            GivenName = InputResourceName,
        };

        return hostResult;
    }
    public override void CreateChildren(Humidifier.CodeConnections.Host result)
    {
        base.CreateChildren(result);

        result.VpcConfiguration ??= VpcConfigurationFactory?.Build();
    }

} // End Of Class

public static class HostFactoryExtensions
{
    public static CombinedResult<HostFactory, InnerHostVpcConfigurationFactory> WithVpcConfiguration(this HostFactory parentFactory, Action<Humidifier.CodeConnections.HostTypes.VpcConfiguration> subFactoryAction = null)
    {
        parentFactory.VpcConfigurationFactory = new InnerHostVpcConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.VpcConfigurationFactory);
    }

    public static CombinedResult<HostFactory, T1, InnerHostVpcConfigurationFactory> WithVpcConfiguration<T1>(this CombinedResult<HostFactory, T1> combinedResult, Action<Humidifier.CodeConnections.HostTypes.VpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, HostFactory, InnerHostVpcConfigurationFactory> WithVpcConfiguration<T1>(this CombinedResult<T1, HostFactory> combinedResult, Action<Humidifier.CodeConnections.HostTypes.VpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<HostFactory, T1, T2, InnerHostVpcConfigurationFactory> WithVpcConfiguration<T1, T2>(this CombinedResult<HostFactory, T1, T2> combinedResult, Action<Humidifier.CodeConnections.HostTypes.VpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, HostFactory, T2, InnerHostVpcConfigurationFactory> WithVpcConfiguration<T1, T2>(this CombinedResult<T1, HostFactory, T2> combinedResult, Action<Humidifier.CodeConnections.HostTypes.VpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, HostFactory, InnerHostVpcConfigurationFactory> WithVpcConfiguration<T1, T2>(this CombinedResult<T1, T2, HostFactory> combinedResult, Action<Humidifier.CodeConnections.HostTypes.VpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<HostFactory, T1, T2, T3, InnerHostVpcConfigurationFactory> WithVpcConfiguration<T1, T2, T3>(this CombinedResult<HostFactory, T1, T2, T3> combinedResult, Action<Humidifier.CodeConnections.HostTypes.VpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, HostFactory, T2, T3, InnerHostVpcConfigurationFactory> WithVpcConfiguration<T1, T2, T3>(this CombinedResult<T1, HostFactory, T2, T3> combinedResult, Action<Humidifier.CodeConnections.HostTypes.VpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, HostFactory, T3, InnerHostVpcConfigurationFactory> WithVpcConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, HostFactory, T3> combinedResult, Action<Humidifier.CodeConnections.HostTypes.VpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, HostFactory, InnerHostVpcConfigurationFactory> WithVpcConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, HostFactory> combinedResult, Action<Humidifier.CodeConnections.HostTypes.VpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<HostFactory, T1, T2, T3, T4, InnerHostVpcConfigurationFactory> WithVpcConfiguration<T1, T2, T3, T4>(this CombinedResult<HostFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CodeConnections.HostTypes.VpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, HostFactory, T2, T3, T4, InnerHostVpcConfigurationFactory> WithVpcConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, HostFactory, T2, T3, T4> combinedResult, Action<Humidifier.CodeConnections.HostTypes.VpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, HostFactory, T3, T4, InnerHostVpcConfigurationFactory> WithVpcConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, HostFactory, T3, T4> combinedResult, Action<Humidifier.CodeConnections.HostTypes.VpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, HostFactory, T4, InnerHostVpcConfigurationFactory> WithVpcConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, HostFactory, T4> combinedResult, Action<Humidifier.CodeConnections.HostTypes.VpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, HostFactory, InnerHostVpcConfigurationFactory> WithVpcConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, HostFactory> combinedResult, Action<Humidifier.CodeConnections.HostTypes.VpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T5, subFactoryAction).T2);
}
