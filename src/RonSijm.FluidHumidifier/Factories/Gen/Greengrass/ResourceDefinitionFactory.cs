// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Greengrass;

public class ResourceDefinitionFactory(string resourceName = null, Action<Humidifier.Greengrass.ResourceDefinition> factoryAction = null) : ResourceFactory<Humidifier.Greengrass.ResourceDefinition>(resourceName)
{

    internal InnerResourceDefinitionResourceDefinitionVersionFactory InitialVersionFactory { get; set; }

    protected override Humidifier.Greengrass.ResourceDefinition Create()
    {
        var resourceDefinitionResult = CreateResourceDefinition();
        factoryAction?.Invoke(resourceDefinitionResult);

        return resourceDefinitionResult;
    }

    private Humidifier.Greengrass.ResourceDefinition CreateResourceDefinition()
    {
        var resourceDefinitionResult = new Humidifier.Greengrass.ResourceDefinition
        {
            GivenName = InputResourceName,
        };

        return resourceDefinitionResult;
    }
    public override void CreateChildren(Humidifier.Greengrass.ResourceDefinition result)
    {
        base.CreateChildren(result);

        result.InitialVersion ??= InitialVersionFactory?.Build();
    }

} // End Of Class

public static class ResourceDefinitionFactoryExtensions
{
    public static CombinedResult<ResourceDefinitionFactory, InnerResourceDefinitionResourceDefinitionVersionFactory> WithInitialVersion(this ResourceDefinitionFactory parentFactory, Action<Humidifier.Greengrass.ResourceDefinitionTypes.ResourceDefinitionVersion> subFactoryAction = null)
    {
        parentFactory.InitialVersionFactory = new InnerResourceDefinitionResourceDefinitionVersionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.InitialVersionFactory);
    }

    public static CombinedResult<ResourceDefinitionFactory, T1, InnerResourceDefinitionResourceDefinitionVersionFactory> WithInitialVersion<T1>(this CombinedResult<ResourceDefinitionFactory, T1> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionTypes.ResourceDefinitionVersion> subFactoryAction = null) => new (combinedResult, combinedResult, WithInitialVersion(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ResourceDefinitionFactory, InnerResourceDefinitionResourceDefinitionVersionFactory> WithInitialVersion<T1>(this CombinedResult<T1, ResourceDefinitionFactory> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionTypes.ResourceDefinitionVersion> subFactoryAction = null) => new (combinedResult, combinedResult, WithInitialVersion(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ResourceDefinitionFactory, T1, T2, InnerResourceDefinitionResourceDefinitionVersionFactory> WithInitialVersion<T1, T2>(this CombinedResult<ResourceDefinitionFactory, T1, T2> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionTypes.ResourceDefinitionVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInitialVersion(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ResourceDefinitionFactory, T2, InnerResourceDefinitionResourceDefinitionVersionFactory> WithInitialVersion<T1, T2>(this CombinedResult<T1, ResourceDefinitionFactory, T2> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionTypes.ResourceDefinitionVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInitialVersion(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ResourceDefinitionFactory, InnerResourceDefinitionResourceDefinitionVersionFactory> WithInitialVersion<T1, T2>(this CombinedResult<T1, T2, ResourceDefinitionFactory> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionTypes.ResourceDefinitionVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInitialVersion(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ResourceDefinitionFactory, T1, T2, T3, InnerResourceDefinitionResourceDefinitionVersionFactory> WithInitialVersion<T1, T2, T3>(this CombinedResult<ResourceDefinitionFactory, T1, T2, T3> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionTypes.ResourceDefinitionVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInitialVersion(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ResourceDefinitionFactory, T2, T3, InnerResourceDefinitionResourceDefinitionVersionFactory> WithInitialVersion<T1, T2, T3>(this CombinedResult<T1, ResourceDefinitionFactory, T2, T3> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionTypes.ResourceDefinitionVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInitialVersion(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ResourceDefinitionFactory, T3, InnerResourceDefinitionResourceDefinitionVersionFactory> WithInitialVersion<T1, T2, T3>(this CombinedResult<T1, T2, ResourceDefinitionFactory, T3> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionTypes.ResourceDefinitionVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInitialVersion(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ResourceDefinitionFactory, InnerResourceDefinitionResourceDefinitionVersionFactory> WithInitialVersion<T1, T2, T3>(this CombinedResult<T1, T2, T3, ResourceDefinitionFactory> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionTypes.ResourceDefinitionVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInitialVersion(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ResourceDefinitionFactory, T1, T2, T3, T4, InnerResourceDefinitionResourceDefinitionVersionFactory> WithInitialVersion<T1, T2, T3, T4>(this CombinedResult<ResourceDefinitionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionTypes.ResourceDefinitionVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInitialVersion(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ResourceDefinitionFactory, T2, T3, T4, InnerResourceDefinitionResourceDefinitionVersionFactory> WithInitialVersion<T1, T2, T3, T4>(this CombinedResult<T1, ResourceDefinitionFactory, T2, T3, T4> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionTypes.ResourceDefinitionVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInitialVersion(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ResourceDefinitionFactory, T3, T4, InnerResourceDefinitionResourceDefinitionVersionFactory> WithInitialVersion<T1, T2, T3, T4>(this CombinedResult<T1, T2, ResourceDefinitionFactory, T3, T4> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionTypes.ResourceDefinitionVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInitialVersion(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ResourceDefinitionFactory, T4, InnerResourceDefinitionResourceDefinitionVersionFactory> WithInitialVersion<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ResourceDefinitionFactory, T4> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionTypes.ResourceDefinitionVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInitialVersion(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ResourceDefinitionFactory, InnerResourceDefinitionResourceDefinitionVersionFactory> WithInitialVersion<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ResourceDefinitionFactory> combinedResult, Action<Humidifier.Greengrass.ResourceDefinitionTypes.ResourceDefinitionVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInitialVersion(combinedResult.T5, subFactoryAction));
}
