// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Greengrass;

public class CoreDefinitionVersionFactory(string resourceName = null, Action<Humidifier.Greengrass.CoreDefinitionVersion> factoryAction = null) : ResourceFactory<Humidifier.Greengrass.CoreDefinitionVersion>(resourceName)
{

    internal List<InnerCoreDefinitionVersionCoreFactory> CoresFactories { get; set; } = [];

    protected override Humidifier.Greengrass.CoreDefinitionVersion Create()
    {
        var coreDefinitionVersionResult = CreateCoreDefinitionVersion();
        factoryAction?.Invoke(coreDefinitionVersionResult);

        return coreDefinitionVersionResult;
    }

    private Humidifier.Greengrass.CoreDefinitionVersion CreateCoreDefinitionVersion()
    {
        var coreDefinitionVersionResult = new Humidifier.Greengrass.CoreDefinitionVersion
        {
            GivenName = InputResourceName,
        };

        return coreDefinitionVersionResult;
    }
    public override void CreateChildren(Humidifier.Greengrass.CoreDefinitionVersion result)
    {
        base.CreateChildren(result);

        result.Cores = CoresFactories.Any() ? CoresFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class CoreDefinitionVersionFactoryExtensions
{
    public static CombinedResult<CoreDefinitionVersionFactory, InnerCoreDefinitionVersionCoreFactory> WithCores(this CoreDefinitionVersionFactory parentFactory, Action<Humidifier.Greengrass.CoreDefinitionVersionTypes.Core> subFactoryAction = null)
    {
        var factory = new InnerCoreDefinitionVersionCoreFactory(subFactoryAction);
        parentFactory.CoresFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<CoreDefinitionVersionFactory, T1, InnerCoreDefinitionVersionCoreFactory> WithCores<T1>(this CombinedResult<CoreDefinitionVersionFactory, T1> combinedResult, Action<Humidifier.Greengrass.CoreDefinitionVersionTypes.Core> subFactoryAction = null) => new (combinedResult, combinedResult, WithCores(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CoreDefinitionVersionFactory, InnerCoreDefinitionVersionCoreFactory> WithCores<T1>(this CombinedResult<T1, CoreDefinitionVersionFactory> combinedResult, Action<Humidifier.Greengrass.CoreDefinitionVersionTypes.Core> subFactoryAction = null) => new (combinedResult, combinedResult, WithCores(combinedResult.T2, subFactoryAction));
    public static CombinedResult<CoreDefinitionVersionFactory, T1, T2, InnerCoreDefinitionVersionCoreFactory> WithCores<T1, T2>(this CombinedResult<CoreDefinitionVersionFactory, T1, T2> combinedResult, Action<Humidifier.Greengrass.CoreDefinitionVersionTypes.Core> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCores(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CoreDefinitionVersionFactory, T2, InnerCoreDefinitionVersionCoreFactory> WithCores<T1, T2>(this CombinedResult<T1, CoreDefinitionVersionFactory, T2> combinedResult, Action<Humidifier.Greengrass.CoreDefinitionVersionTypes.Core> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCores(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, CoreDefinitionVersionFactory, InnerCoreDefinitionVersionCoreFactory> WithCores<T1, T2>(this CombinedResult<T1, T2, CoreDefinitionVersionFactory> combinedResult, Action<Humidifier.Greengrass.CoreDefinitionVersionTypes.Core> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCores(combinedResult.T3, subFactoryAction));
    public static CombinedResult<CoreDefinitionVersionFactory, T1, T2, T3, InnerCoreDefinitionVersionCoreFactory> WithCores<T1, T2, T3>(this CombinedResult<CoreDefinitionVersionFactory, T1, T2, T3> combinedResult, Action<Humidifier.Greengrass.CoreDefinitionVersionTypes.Core> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCores(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CoreDefinitionVersionFactory, T2, T3, InnerCoreDefinitionVersionCoreFactory> WithCores<T1, T2, T3>(this CombinedResult<T1, CoreDefinitionVersionFactory, T2, T3> combinedResult, Action<Humidifier.Greengrass.CoreDefinitionVersionTypes.Core> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCores(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, CoreDefinitionVersionFactory, T3, InnerCoreDefinitionVersionCoreFactory> WithCores<T1, T2, T3>(this CombinedResult<T1, T2, CoreDefinitionVersionFactory, T3> combinedResult, Action<Humidifier.Greengrass.CoreDefinitionVersionTypes.Core> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCores(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, CoreDefinitionVersionFactory, InnerCoreDefinitionVersionCoreFactory> WithCores<T1, T2, T3>(this CombinedResult<T1, T2, T3, CoreDefinitionVersionFactory> combinedResult, Action<Humidifier.Greengrass.CoreDefinitionVersionTypes.Core> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCores(combinedResult.T4, subFactoryAction));
    public static CombinedResult<CoreDefinitionVersionFactory, T1, T2, T3, T4, InnerCoreDefinitionVersionCoreFactory> WithCores<T1, T2, T3, T4>(this CombinedResult<CoreDefinitionVersionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Greengrass.CoreDefinitionVersionTypes.Core> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCores(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CoreDefinitionVersionFactory, T2, T3, T4, InnerCoreDefinitionVersionCoreFactory> WithCores<T1, T2, T3, T4>(this CombinedResult<T1, CoreDefinitionVersionFactory, T2, T3, T4> combinedResult, Action<Humidifier.Greengrass.CoreDefinitionVersionTypes.Core> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCores(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, CoreDefinitionVersionFactory, T3, T4, InnerCoreDefinitionVersionCoreFactory> WithCores<T1, T2, T3, T4>(this CombinedResult<T1, T2, CoreDefinitionVersionFactory, T3, T4> combinedResult, Action<Humidifier.Greengrass.CoreDefinitionVersionTypes.Core> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCores(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, CoreDefinitionVersionFactory, T4, InnerCoreDefinitionVersionCoreFactory> WithCores<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, CoreDefinitionVersionFactory, T4> combinedResult, Action<Humidifier.Greengrass.CoreDefinitionVersionTypes.Core> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCores(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, CoreDefinitionVersionFactory, InnerCoreDefinitionVersionCoreFactory> WithCores<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, CoreDefinitionVersionFactory> combinedResult, Action<Humidifier.Greengrass.CoreDefinitionVersionTypes.Core> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCores(combinedResult.T5, subFactoryAction));
}
