// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ImageBuilder;

public class InnerDistributionConfigurationContainerDistributionConfigurationFactory(Action<Humidifier.ImageBuilder.DistributionConfigurationTypes.ContainerDistributionConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.ImageBuilder.DistributionConfigurationTypes.ContainerDistributionConfiguration>
{

    internal InnerDistributionConfigurationTargetContainerRepositoryFactory TargetRepositoryFactory { get; set; }

    protected override Humidifier.ImageBuilder.DistributionConfigurationTypes.ContainerDistributionConfiguration Create()
    {
        var containerDistributionConfigurationResult = CreateContainerDistributionConfiguration();
        factoryAction?.Invoke(containerDistributionConfigurationResult);

        return containerDistributionConfigurationResult;
    }

    private Humidifier.ImageBuilder.DistributionConfigurationTypes.ContainerDistributionConfiguration CreateContainerDistributionConfiguration()
    {
        var containerDistributionConfigurationResult = new Humidifier.ImageBuilder.DistributionConfigurationTypes.ContainerDistributionConfiguration();

        return containerDistributionConfigurationResult;
    }
    public override void CreateChildren(Humidifier.ImageBuilder.DistributionConfigurationTypes.ContainerDistributionConfiguration result)
    {
        base.CreateChildren(result);

        result.TargetRepository ??= TargetRepositoryFactory?.Build();
    }

} // End Of Class

public static class InnerDistributionConfigurationContainerDistributionConfigurationFactoryExtensions
{
    public static CombinedResult<InnerDistributionConfigurationContainerDistributionConfigurationFactory, InnerDistributionConfigurationTargetContainerRepositoryFactory> WithTargetRepository(this InnerDistributionConfigurationContainerDistributionConfigurationFactory parentFactory, Action<Humidifier.ImageBuilder.DistributionConfigurationTypes.TargetContainerRepository> subFactoryAction = null)
    {
        parentFactory.TargetRepositoryFactory = new InnerDistributionConfigurationTargetContainerRepositoryFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.TargetRepositoryFactory);
    }

    public static CombinedResult<InnerDistributionConfigurationContainerDistributionConfigurationFactory, T1, InnerDistributionConfigurationTargetContainerRepositoryFactory> WithTargetRepository<T1>(this CombinedResult<InnerDistributionConfigurationContainerDistributionConfigurationFactory, T1> combinedResult, Action<Humidifier.ImageBuilder.DistributionConfigurationTypes.TargetContainerRepository> subFactoryAction = null) => new (combinedResult, combinedResult, WithTargetRepository(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDistributionConfigurationContainerDistributionConfigurationFactory, InnerDistributionConfigurationTargetContainerRepositoryFactory> WithTargetRepository<T1>(this CombinedResult<T1, InnerDistributionConfigurationContainerDistributionConfigurationFactory> combinedResult, Action<Humidifier.ImageBuilder.DistributionConfigurationTypes.TargetContainerRepository> subFactoryAction = null) => new (combinedResult, combinedResult, WithTargetRepository(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDistributionConfigurationContainerDistributionConfigurationFactory, T1, T2, InnerDistributionConfigurationTargetContainerRepositoryFactory> WithTargetRepository<T1, T2>(this CombinedResult<InnerDistributionConfigurationContainerDistributionConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.ImageBuilder.DistributionConfigurationTypes.TargetContainerRepository> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTargetRepository(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDistributionConfigurationContainerDistributionConfigurationFactory, T2, InnerDistributionConfigurationTargetContainerRepositoryFactory> WithTargetRepository<T1, T2>(this CombinedResult<T1, InnerDistributionConfigurationContainerDistributionConfigurationFactory, T2> combinedResult, Action<Humidifier.ImageBuilder.DistributionConfigurationTypes.TargetContainerRepository> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTargetRepository(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDistributionConfigurationContainerDistributionConfigurationFactory, InnerDistributionConfigurationTargetContainerRepositoryFactory> WithTargetRepository<T1, T2>(this CombinedResult<T1, T2, InnerDistributionConfigurationContainerDistributionConfigurationFactory> combinedResult, Action<Humidifier.ImageBuilder.DistributionConfigurationTypes.TargetContainerRepository> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTargetRepository(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDistributionConfigurationContainerDistributionConfigurationFactory, T1, T2, T3, InnerDistributionConfigurationTargetContainerRepositoryFactory> WithTargetRepository<T1, T2, T3>(this CombinedResult<InnerDistributionConfigurationContainerDistributionConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.ImageBuilder.DistributionConfigurationTypes.TargetContainerRepository> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargetRepository(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDistributionConfigurationContainerDistributionConfigurationFactory, T2, T3, InnerDistributionConfigurationTargetContainerRepositoryFactory> WithTargetRepository<T1, T2, T3>(this CombinedResult<T1, InnerDistributionConfigurationContainerDistributionConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.ImageBuilder.DistributionConfigurationTypes.TargetContainerRepository> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargetRepository(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDistributionConfigurationContainerDistributionConfigurationFactory, T3, InnerDistributionConfigurationTargetContainerRepositoryFactory> WithTargetRepository<T1, T2, T3>(this CombinedResult<T1, T2, InnerDistributionConfigurationContainerDistributionConfigurationFactory, T3> combinedResult, Action<Humidifier.ImageBuilder.DistributionConfigurationTypes.TargetContainerRepository> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargetRepository(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDistributionConfigurationContainerDistributionConfigurationFactory, InnerDistributionConfigurationTargetContainerRepositoryFactory> WithTargetRepository<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDistributionConfigurationContainerDistributionConfigurationFactory> combinedResult, Action<Humidifier.ImageBuilder.DistributionConfigurationTypes.TargetContainerRepository> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargetRepository(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDistributionConfigurationContainerDistributionConfigurationFactory, T1, T2, T3, T4, InnerDistributionConfigurationTargetContainerRepositoryFactory> WithTargetRepository<T1, T2, T3, T4>(this CombinedResult<InnerDistributionConfigurationContainerDistributionConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ImageBuilder.DistributionConfigurationTypes.TargetContainerRepository> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargetRepository(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDistributionConfigurationContainerDistributionConfigurationFactory, T2, T3, T4, InnerDistributionConfigurationTargetContainerRepositoryFactory> WithTargetRepository<T1, T2, T3, T4>(this CombinedResult<T1, InnerDistributionConfigurationContainerDistributionConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.ImageBuilder.DistributionConfigurationTypes.TargetContainerRepository> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargetRepository(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDistributionConfigurationContainerDistributionConfigurationFactory, T3, T4, InnerDistributionConfigurationTargetContainerRepositoryFactory> WithTargetRepository<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDistributionConfigurationContainerDistributionConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.ImageBuilder.DistributionConfigurationTypes.TargetContainerRepository> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargetRepository(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDistributionConfigurationContainerDistributionConfigurationFactory, T4, InnerDistributionConfigurationTargetContainerRepositoryFactory> WithTargetRepository<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDistributionConfigurationContainerDistributionConfigurationFactory, T4> combinedResult, Action<Humidifier.ImageBuilder.DistributionConfigurationTypes.TargetContainerRepository> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargetRepository(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDistributionConfigurationContainerDistributionConfigurationFactory, InnerDistributionConfigurationTargetContainerRepositoryFactory> WithTargetRepository<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDistributionConfigurationContainerDistributionConfigurationFactory> combinedResult, Action<Humidifier.ImageBuilder.DistributionConfigurationTypes.TargetContainerRepository> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargetRepository(combinedResult.T5, subFactoryAction));
}
