// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.RAM;

public class ResourceShareFactory(string resourceName = null, Action<Humidifier.RAM.ResourceShare> factoryAction = null) : ResourceFactory<Humidifier.RAM.ResourceShare>(resourceName)
{

    internal InnerResourceShareResourceShareConfigurationFactory ResourceShareConfigurationFactory { get; set; }

    protected override Humidifier.RAM.ResourceShare Create()
    {
        var resourceShareResult = CreateResourceShare();
        factoryAction?.Invoke(resourceShareResult);

        return resourceShareResult;
    }

    private Humidifier.RAM.ResourceShare CreateResourceShare()
    {
        var resourceShareResult = new Humidifier.RAM.ResourceShare
        {
            GivenName = InputResourceName,
        };

        return resourceShareResult;
    }
    public override void CreateChildren(Humidifier.RAM.ResourceShare result)
    {
        base.CreateChildren(result);

        result.ResourceShareConfiguration ??= ResourceShareConfigurationFactory?.Build();
    }

} // End Of Class

public static class ResourceShareFactoryExtensions
{
    public static CombinedResult<ResourceShareFactory, InnerResourceShareResourceShareConfigurationFactory> WithResourceShareConfiguration(this ResourceShareFactory parentFactory, Action<Humidifier.RAM.ResourceShareTypes.ResourceShareConfiguration> subFactoryAction = null)
    {
        parentFactory.ResourceShareConfigurationFactory = new InnerResourceShareResourceShareConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ResourceShareConfigurationFactory);
    }

    public static CombinedResult<ResourceShareFactory, T1, InnerResourceShareResourceShareConfigurationFactory> WithResourceShareConfiguration<T1>(this CombinedResult<ResourceShareFactory, T1> combinedResult, Action<Humidifier.RAM.ResourceShareTypes.ResourceShareConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithResourceShareConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ResourceShareFactory, InnerResourceShareResourceShareConfigurationFactory> WithResourceShareConfiguration<T1>(this CombinedResult<T1, ResourceShareFactory> combinedResult, Action<Humidifier.RAM.ResourceShareTypes.ResourceShareConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithResourceShareConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<ResourceShareFactory, T1, T2, InnerResourceShareResourceShareConfigurationFactory> WithResourceShareConfiguration<T1, T2>(this CombinedResult<ResourceShareFactory, T1, T2> combinedResult, Action<Humidifier.RAM.ResourceShareTypes.ResourceShareConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithResourceShareConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ResourceShareFactory, T2, InnerResourceShareResourceShareConfigurationFactory> WithResourceShareConfiguration<T1, T2>(this CombinedResult<T1, ResourceShareFactory, T2> combinedResult, Action<Humidifier.RAM.ResourceShareTypes.ResourceShareConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithResourceShareConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ResourceShareFactory, InnerResourceShareResourceShareConfigurationFactory> WithResourceShareConfiguration<T1, T2>(this CombinedResult<T1, T2, ResourceShareFactory> combinedResult, Action<Humidifier.RAM.ResourceShareTypes.ResourceShareConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithResourceShareConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<ResourceShareFactory, T1, T2, T3, InnerResourceShareResourceShareConfigurationFactory> WithResourceShareConfiguration<T1, T2, T3>(this CombinedResult<ResourceShareFactory, T1, T2, T3> combinedResult, Action<Humidifier.RAM.ResourceShareTypes.ResourceShareConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResourceShareConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ResourceShareFactory, T2, T3, InnerResourceShareResourceShareConfigurationFactory> WithResourceShareConfiguration<T1, T2, T3>(this CombinedResult<T1, ResourceShareFactory, T2, T3> combinedResult, Action<Humidifier.RAM.ResourceShareTypes.ResourceShareConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResourceShareConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ResourceShareFactory, T3, InnerResourceShareResourceShareConfigurationFactory> WithResourceShareConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, ResourceShareFactory, T3> combinedResult, Action<Humidifier.RAM.ResourceShareTypes.ResourceShareConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResourceShareConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ResourceShareFactory, InnerResourceShareResourceShareConfigurationFactory> WithResourceShareConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, ResourceShareFactory> combinedResult, Action<Humidifier.RAM.ResourceShareTypes.ResourceShareConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResourceShareConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<ResourceShareFactory, T1, T2, T3, T4, InnerResourceShareResourceShareConfigurationFactory> WithResourceShareConfiguration<T1, T2, T3, T4>(this CombinedResult<ResourceShareFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.RAM.ResourceShareTypes.ResourceShareConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceShareConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ResourceShareFactory, T2, T3, T4, InnerResourceShareResourceShareConfigurationFactory> WithResourceShareConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, ResourceShareFactory, T2, T3, T4> combinedResult, Action<Humidifier.RAM.ResourceShareTypes.ResourceShareConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceShareConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ResourceShareFactory, T3, T4, InnerResourceShareResourceShareConfigurationFactory> WithResourceShareConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, ResourceShareFactory, T3, T4> combinedResult, Action<Humidifier.RAM.ResourceShareTypes.ResourceShareConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceShareConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ResourceShareFactory, T4, InnerResourceShareResourceShareConfigurationFactory> WithResourceShareConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ResourceShareFactory, T4> combinedResult, Action<Humidifier.RAM.ResourceShareTypes.ResourceShareConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceShareConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, ResourceShareFactory, InnerResourceShareResourceShareConfigurationFactory> WithResourceShareConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ResourceShareFactory> combinedResult, Action<Humidifier.RAM.ResourceShareTypes.ResourceShareConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceShareConfiguration(combinedResult.T5, subFactoryAction).T2);
}
