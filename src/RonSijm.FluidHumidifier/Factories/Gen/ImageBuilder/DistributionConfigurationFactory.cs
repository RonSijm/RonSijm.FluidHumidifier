// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ImageBuilder;

public class DistributionConfigurationFactory(string resourceName = null, Action<Humidifier.ImageBuilder.DistributionConfiguration> factoryAction = null) : ResourceFactory<Humidifier.ImageBuilder.DistributionConfiguration>(resourceName)
{

    internal List<InnerDistributionConfigurationDistributionFactory> DistributionsFactories { get; set; } = [];

    protected override Humidifier.ImageBuilder.DistributionConfiguration Create()
    {
        var distributionConfigurationResult = CreateDistributionConfiguration();
        factoryAction?.Invoke(distributionConfigurationResult);

        return distributionConfigurationResult;
    }

    private Humidifier.ImageBuilder.DistributionConfiguration CreateDistributionConfiguration()
    {
        var distributionConfigurationResult = new Humidifier.ImageBuilder.DistributionConfiguration
        {
            GivenName = InputResourceName,
        };

        return distributionConfigurationResult;
    }
    public override void CreateChildren(Humidifier.ImageBuilder.DistributionConfiguration result)
    {
        base.CreateChildren(result);

        result.Distributions = DistributionsFactories.Any() ? DistributionsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class DistributionConfigurationFactoryExtensions
{
    public static CombinedResult<DistributionConfigurationFactory, InnerDistributionConfigurationDistributionFactory> WithDistributions(this DistributionConfigurationFactory parentFactory, Action<Humidifier.ImageBuilder.DistributionConfigurationTypes.Distribution> subFactoryAction = null)
    {
        var factory = new InnerDistributionConfigurationDistributionFactory(subFactoryAction);
        parentFactory.DistributionsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<DistributionConfigurationFactory, T1, InnerDistributionConfigurationDistributionFactory> WithDistributions<T1>(this CombinedResult<DistributionConfigurationFactory, T1> combinedResult, Action<Humidifier.ImageBuilder.DistributionConfigurationTypes.Distribution> subFactoryAction = null) => new (combinedResult, combinedResult, WithDistributions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DistributionConfigurationFactory, InnerDistributionConfigurationDistributionFactory> WithDistributions<T1>(this CombinedResult<T1, DistributionConfigurationFactory> combinedResult, Action<Humidifier.ImageBuilder.DistributionConfigurationTypes.Distribution> subFactoryAction = null) => new (combinedResult, combinedResult, WithDistributions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<DistributionConfigurationFactory, T1, T2, InnerDistributionConfigurationDistributionFactory> WithDistributions<T1, T2>(this CombinedResult<DistributionConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.ImageBuilder.DistributionConfigurationTypes.Distribution> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDistributions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DistributionConfigurationFactory, T2, InnerDistributionConfigurationDistributionFactory> WithDistributions<T1, T2>(this CombinedResult<T1, DistributionConfigurationFactory, T2> combinedResult, Action<Humidifier.ImageBuilder.DistributionConfigurationTypes.Distribution> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDistributions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DistributionConfigurationFactory, InnerDistributionConfigurationDistributionFactory> WithDistributions<T1, T2>(this CombinedResult<T1, T2, DistributionConfigurationFactory> combinedResult, Action<Humidifier.ImageBuilder.DistributionConfigurationTypes.Distribution> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDistributions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<DistributionConfigurationFactory, T1, T2, T3, InnerDistributionConfigurationDistributionFactory> WithDistributions<T1, T2, T3>(this CombinedResult<DistributionConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.ImageBuilder.DistributionConfigurationTypes.Distribution> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDistributions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DistributionConfigurationFactory, T2, T3, InnerDistributionConfigurationDistributionFactory> WithDistributions<T1, T2, T3>(this CombinedResult<T1, DistributionConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.ImageBuilder.DistributionConfigurationTypes.Distribution> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDistributions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DistributionConfigurationFactory, T3, InnerDistributionConfigurationDistributionFactory> WithDistributions<T1, T2, T3>(this CombinedResult<T1, T2, DistributionConfigurationFactory, T3> combinedResult, Action<Humidifier.ImageBuilder.DistributionConfigurationTypes.Distribution> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDistributions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DistributionConfigurationFactory, InnerDistributionConfigurationDistributionFactory> WithDistributions<T1, T2, T3>(this CombinedResult<T1, T2, T3, DistributionConfigurationFactory> combinedResult, Action<Humidifier.ImageBuilder.DistributionConfigurationTypes.Distribution> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDistributions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<DistributionConfigurationFactory, T1, T2, T3, T4, InnerDistributionConfigurationDistributionFactory> WithDistributions<T1, T2, T3, T4>(this CombinedResult<DistributionConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ImageBuilder.DistributionConfigurationTypes.Distribution> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDistributions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DistributionConfigurationFactory, T2, T3, T4, InnerDistributionConfigurationDistributionFactory> WithDistributions<T1, T2, T3, T4>(this CombinedResult<T1, DistributionConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.ImageBuilder.DistributionConfigurationTypes.Distribution> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDistributions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DistributionConfigurationFactory, T3, T4, InnerDistributionConfigurationDistributionFactory> WithDistributions<T1, T2, T3, T4>(this CombinedResult<T1, T2, DistributionConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.ImageBuilder.DistributionConfigurationTypes.Distribution> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDistributions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DistributionConfigurationFactory, T4, InnerDistributionConfigurationDistributionFactory> WithDistributions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, DistributionConfigurationFactory, T4> combinedResult, Action<Humidifier.ImageBuilder.DistributionConfigurationTypes.Distribution> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDistributions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, DistributionConfigurationFactory, InnerDistributionConfigurationDistributionFactory> WithDistributions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, DistributionConfigurationFactory> combinedResult, Action<Humidifier.ImageBuilder.DistributionConfigurationTypes.Distribution> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDistributions(combinedResult.T5, subFactoryAction));
}
