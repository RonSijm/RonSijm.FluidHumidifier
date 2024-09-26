// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Greengrass;

public class InnerCoreDefinitionCoreDefinitionVersionFactory(Action<Humidifier.Greengrass.CoreDefinitionTypes.CoreDefinitionVersion> factoryAction = null) : SubResourceFactory<Humidifier.Greengrass.CoreDefinitionTypes.CoreDefinitionVersion>
{

    internal List<InnerCoreDefinitionCoreFactory> CoresFactories { get; set; } = [];

    protected override Humidifier.Greengrass.CoreDefinitionTypes.CoreDefinitionVersion Create()
    {
        var coreDefinitionVersionResult = CreateCoreDefinitionVersion();
        factoryAction?.Invoke(coreDefinitionVersionResult);

        return coreDefinitionVersionResult;
    }

    private Humidifier.Greengrass.CoreDefinitionTypes.CoreDefinitionVersion CreateCoreDefinitionVersion()
    {
        var coreDefinitionVersionResult = new Humidifier.Greengrass.CoreDefinitionTypes.CoreDefinitionVersion();

        return coreDefinitionVersionResult;
    }
    public override void CreateChildren(Humidifier.Greengrass.CoreDefinitionTypes.CoreDefinitionVersion result)
    {
        base.CreateChildren(result);

        result.Cores = CoresFactories.Any() ? CoresFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class InnerCoreDefinitionCoreDefinitionVersionFactoryExtensions
{
    public static CombinedResult<InnerCoreDefinitionCoreDefinitionVersionFactory, InnerCoreDefinitionCoreFactory> WithCores(this InnerCoreDefinitionCoreDefinitionVersionFactory parentFactory, Action<Humidifier.Greengrass.CoreDefinitionTypes.Core> subFactoryAction = null)
    {
        var factory = new InnerCoreDefinitionCoreFactory(subFactoryAction);
        parentFactory.CoresFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<InnerCoreDefinitionCoreDefinitionVersionFactory, T1, InnerCoreDefinitionCoreFactory> WithCores<T1>(this CombinedResult<InnerCoreDefinitionCoreDefinitionVersionFactory, T1> combinedResult, Action<Humidifier.Greengrass.CoreDefinitionTypes.Core> subFactoryAction = null) => new (combinedResult, combinedResult, WithCores(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCoreDefinitionCoreDefinitionVersionFactory, InnerCoreDefinitionCoreFactory> WithCores<T1>(this CombinedResult<T1, InnerCoreDefinitionCoreDefinitionVersionFactory> combinedResult, Action<Humidifier.Greengrass.CoreDefinitionTypes.Core> subFactoryAction = null) => new (combinedResult, combinedResult, WithCores(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerCoreDefinitionCoreDefinitionVersionFactory, T1, T2, InnerCoreDefinitionCoreFactory> WithCores<T1, T2>(this CombinedResult<InnerCoreDefinitionCoreDefinitionVersionFactory, T1, T2> combinedResult, Action<Humidifier.Greengrass.CoreDefinitionTypes.Core> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCores(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCoreDefinitionCoreDefinitionVersionFactory, T2, InnerCoreDefinitionCoreFactory> WithCores<T1, T2>(this CombinedResult<T1, InnerCoreDefinitionCoreDefinitionVersionFactory, T2> combinedResult, Action<Humidifier.Greengrass.CoreDefinitionTypes.Core> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCores(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerCoreDefinitionCoreDefinitionVersionFactory, InnerCoreDefinitionCoreFactory> WithCores<T1, T2>(this CombinedResult<T1, T2, InnerCoreDefinitionCoreDefinitionVersionFactory> combinedResult, Action<Humidifier.Greengrass.CoreDefinitionTypes.Core> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCores(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerCoreDefinitionCoreDefinitionVersionFactory, T1, T2, T3, InnerCoreDefinitionCoreFactory> WithCores<T1, T2, T3>(this CombinedResult<InnerCoreDefinitionCoreDefinitionVersionFactory, T1, T2, T3> combinedResult, Action<Humidifier.Greengrass.CoreDefinitionTypes.Core> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCores(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCoreDefinitionCoreDefinitionVersionFactory, T2, T3, InnerCoreDefinitionCoreFactory> WithCores<T1, T2, T3>(this CombinedResult<T1, InnerCoreDefinitionCoreDefinitionVersionFactory, T2, T3> combinedResult, Action<Humidifier.Greengrass.CoreDefinitionTypes.Core> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCores(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerCoreDefinitionCoreDefinitionVersionFactory, T3, InnerCoreDefinitionCoreFactory> WithCores<T1, T2, T3>(this CombinedResult<T1, T2, InnerCoreDefinitionCoreDefinitionVersionFactory, T3> combinedResult, Action<Humidifier.Greengrass.CoreDefinitionTypes.Core> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCores(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerCoreDefinitionCoreDefinitionVersionFactory, InnerCoreDefinitionCoreFactory> WithCores<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerCoreDefinitionCoreDefinitionVersionFactory> combinedResult, Action<Humidifier.Greengrass.CoreDefinitionTypes.Core> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCores(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerCoreDefinitionCoreDefinitionVersionFactory, T1, T2, T3, T4, InnerCoreDefinitionCoreFactory> WithCores<T1, T2, T3, T4>(this CombinedResult<InnerCoreDefinitionCoreDefinitionVersionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Greengrass.CoreDefinitionTypes.Core> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCores(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCoreDefinitionCoreDefinitionVersionFactory, T2, T3, T4, InnerCoreDefinitionCoreFactory> WithCores<T1, T2, T3, T4>(this CombinedResult<T1, InnerCoreDefinitionCoreDefinitionVersionFactory, T2, T3, T4> combinedResult, Action<Humidifier.Greengrass.CoreDefinitionTypes.Core> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCores(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerCoreDefinitionCoreDefinitionVersionFactory, T3, T4, InnerCoreDefinitionCoreFactory> WithCores<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerCoreDefinitionCoreDefinitionVersionFactory, T3, T4> combinedResult, Action<Humidifier.Greengrass.CoreDefinitionTypes.Core> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCores(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerCoreDefinitionCoreDefinitionVersionFactory, T4, InnerCoreDefinitionCoreFactory> WithCores<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerCoreDefinitionCoreDefinitionVersionFactory, T4> combinedResult, Action<Humidifier.Greengrass.CoreDefinitionTypes.Core> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCores(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerCoreDefinitionCoreDefinitionVersionFactory, InnerCoreDefinitionCoreFactory> WithCores<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerCoreDefinitionCoreDefinitionVersionFactory> combinedResult, Action<Humidifier.Greengrass.CoreDefinitionTypes.Core> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCores(combinedResult.T5, subFactoryAction));
}
