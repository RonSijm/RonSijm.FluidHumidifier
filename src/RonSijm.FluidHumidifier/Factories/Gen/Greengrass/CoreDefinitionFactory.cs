// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Greengrass;

public class CoreDefinitionFactory(string resourceName = null, Action<Humidifier.Greengrass.CoreDefinition> factoryAction = null) : ResourceFactory<Humidifier.Greengrass.CoreDefinition>(resourceName)
{

    internal InnerCoreDefinitionCoreDefinitionVersionFactory InitialVersionFactory { get; set; }

    protected override Humidifier.Greengrass.CoreDefinition Create()
    {
        var coreDefinitionResult = CreateCoreDefinition();
        factoryAction?.Invoke(coreDefinitionResult);

        return coreDefinitionResult;
    }

    private Humidifier.Greengrass.CoreDefinition CreateCoreDefinition()
    {
        var coreDefinitionResult = new Humidifier.Greengrass.CoreDefinition
        {
            GivenName = InputResourceName,
        };

        return coreDefinitionResult;
    }
    public override void CreateChildren(Humidifier.Greengrass.CoreDefinition result)
    {
        base.CreateChildren(result);

        result.InitialVersion ??= InitialVersionFactory?.Build();
    }

} // End Of Class

public static class CoreDefinitionFactoryExtensions
{
    public static CombinedResult<CoreDefinitionFactory, InnerCoreDefinitionCoreDefinitionVersionFactory> WithInitialVersion(this CoreDefinitionFactory parentFactory, Action<Humidifier.Greengrass.CoreDefinitionTypes.CoreDefinitionVersion> subFactoryAction = null)
    {
        parentFactory.InitialVersionFactory = new InnerCoreDefinitionCoreDefinitionVersionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.InitialVersionFactory);
    }

    public static CombinedResult<CoreDefinitionFactory, T1, InnerCoreDefinitionCoreDefinitionVersionFactory> WithInitialVersion<T1>(this CombinedResult<CoreDefinitionFactory, T1> combinedResult, Action<Humidifier.Greengrass.CoreDefinitionTypes.CoreDefinitionVersion> subFactoryAction = null) => new (combinedResult, combinedResult, WithInitialVersion(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CoreDefinitionFactory, InnerCoreDefinitionCoreDefinitionVersionFactory> WithInitialVersion<T1>(this CombinedResult<T1, CoreDefinitionFactory> combinedResult, Action<Humidifier.Greengrass.CoreDefinitionTypes.CoreDefinitionVersion> subFactoryAction = null) => new (combinedResult, combinedResult, WithInitialVersion(combinedResult.T2, subFactoryAction));
    public static CombinedResult<CoreDefinitionFactory, T1, T2, InnerCoreDefinitionCoreDefinitionVersionFactory> WithInitialVersion<T1, T2>(this CombinedResult<CoreDefinitionFactory, T1, T2> combinedResult, Action<Humidifier.Greengrass.CoreDefinitionTypes.CoreDefinitionVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInitialVersion(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CoreDefinitionFactory, T2, InnerCoreDefinitionCoreDefinitionVersionFactory> WithInitialVersion<T1, T2>(this CombinedResult<T1, CoreDefinitionFactory, T2> combinedResult, Action<Humidifier.Greengrass.CoreDefinitionTypes.CoreDefinitionVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInitialVersion(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, CoreDefinitionFactory, InnerCoreDefinitionCoreDefinitionVersionFactory> WithInitialVersion<T1, T2>(this CombinedResult<T1, T2, CoreDefinitionFactory> combinedResult, Action<Humidifier.Greengrass.CoreDefinitionTypes.CoreDefinitionVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInitialVersion(combinedResult.T3, subFactoryAction));
    public static CombinedResult<CoreDefinitionFactory, T1, T2, T3, InnerCoreDefinitionCoreDefinitionVersionFactory> WithInitialVersion<T1, T2, T3>(this CombinedResult<CoreDefinitionFactory, T1, T2, T3> combinedResult, Action<Humidifier.Greengrass.CoreDefinitionTypes.CoreDefinitionVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInitialVersion(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CoreDefinitionFactory, T2, T3, InnerCoreDefinitionCoreDefinitionVersionFactory> WithInitialVersion<T1, T2, T3>(this CombinedResult<T1, CoreDefinitionFactory, T2, T3> combinedResult, Action<Humidifier.Greengrass.CoreDefinitionTypes.CoreDefinitionVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInitialVersion(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, CoreDefinitionFactory, T3, InnerCoreDefinitionCoreDefinitionVersionFactory> WithInitialVersion<T1, T2, T3>(this CombinedResult<T1, T2, CoreDefinitionFactory, T3> combinedResult, Action<Humidifier.Greengrass.CoreDefinitionTypes.CoreDefinitionVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInitialVersion(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, CoreDefinitionFactory, InnerCoreDefinitionCoreDefinitionVersionFactory> WithInitialVersion<T1, T2, T3>(this CombinedResult<T1, T2, T3, CoreDefinitionFactory> combinedResult, Action<Humidifier.Greengrass.CoreDefinitionTypes.CoreDefinitionVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInitialVersion(combinedResult.T4, subFactoryAction));
    public static CombinedResult<CoreDefinitionFactory, T1, T2, T3, T4, InnerCoreDefinitionCoreDefinitionVersionFactory> WithInitialVersion<T1, T2, T3, T4>(this CombinedResult<CoreDefinitionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Greengrass.CoreDefinitionTypes.CoreDefinitionVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInitialVersion(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CoreDefinitionFactory, T2, T3, T4, InnerCoreDefinitionCoreDefinitionVersionFactory> WithInitialVersion<T1, T2, T3, T4>(this CombinedResult<T1, CoreDefinitionFactory, T2, T3, T4> combinedResult, Action<Humidifier.Greengrass.CoreDefinitionTypes.CoreDefinitionVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInitialVersion(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, CoreDefinitionFactory, T3, T4, InnerCoreDefinitionCoreDefinitionVersionFactory> WithInitialVersion<T1, T2, T3, T4>(this CombinedResult<T1, T2, CoreDefinitionFactory, T3, T4> combinedResult, Action<Humidifier.Greengrass.CoreDefinitionTypes.CoreDefinitionVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInitialVersion(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, CoreDefinitionFactory, T4, InnerCoreDefinitionCoreDefinitionVersionFactory> WithInitialVersion<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, CoreDefinitionFactory, T4> combinedResult, Action<Humidifier.Greengrass.CoreDefinitionTypes.CoreDefinitionVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInitialVersion(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, CoreDefinitionFactory, InnerCoreDefinitionCoreDefinitionVersionFactory> WithInitialVersion<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, CoreDefinitionFactory> combinedResult, Action<Humidifier.Greengrass.CoreDefinitionTypes.CoreDefinitionVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInitialVersion(combinedResult.T5, subFactoryAction));
}
