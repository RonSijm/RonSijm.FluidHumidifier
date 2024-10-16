// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppRunner;

public class InnerServiceImageRepositoryFactory(Action<Humidifier.AppRunner.ServiceTypes.ImageRepository> factoryAction = null) : SubResourceFactory<Humidifier.AppRunner.ServiceTypes.ImageRepository>
{

    internal InnerServiceImageConfigurationFactory ImageConfigurationFactory { get; set; }

    protected override Humidifier.AppRunner.ServiceTypes.ImageRepository Create()
    {
        var imageRepositoryResult = CreateImageRepository();
        factoryAction?.Invoke(imageRepositoryResult);

        return imageRepositoryResult;
    }

    private Humidifier.AppRunner.ServiceTypes.ImageRepository CreateImageRepository()
    {
        var imageRepositoryResult = new Humidifier.AppRunner.ServiceTypes.ImageRepository();

        return imageRepositoryResult;
    }
    public override void CreateChildren(Humidifier.AppRunner.ServiceTypes.ImageRepository result)
    {
        base.CreateChildren(result);

        result.ImageConfiguration ??= ImageConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerServiceImageRepositoryFactoryExtensions
{
    public static CombinedResult<InnerServiceImageRepositoryFactory, InnerServiceImageConfigurationFactory> WithImageConfiguration(this InnerServiceImageRepositoryFactory parentFactory, Action<Humidifier.AppRunner.ServiceTypes.ImageConfiguration> subFactoryAction = null)
    {
        parentFactory.ImageConfigurationFactory = new InnerServiceImageConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ImageConfigurationFactory);
    }

    public static CombinedResult<InnerServiceImageRepositoryFactory, T1, InnerServiceImageConfigurationFactory> WithImageConfiguration<T1>(this CombinedResult<InnerServiceImageRepositoryFactory, T1> combinedResult, Action<Humidifier.AppRunner.ServiceTypes.ImageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithImageConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerServiceImageRepositoryFactory, InnerServiceImageConfigurationFactory> WithImageConfiguration<T1>(this CombinedResult<T1, InnerServiceImageRepositoryFactory> combinedResult, Action<Humidifier.AppRunner.ServiceTypes.ImageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithImageConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerServiceImageRepositoryFactory, T1, T2, InnerServiceImageConfigurationFactory> WithImageConfiguration<T1, T2>(this CombinedResult<InnerServiceImageRepositoryFactory, T1, T2> combinedResult, Action<Humidifier.AppRunner.ServiceTypes.ImageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithImageConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerServiceImageRepositoryFactory, T2, InnerServiceImageConfigurationFactory> WithImageConfiguration<T1, T2>(this CombinedResult<T1, InnerServiceImageRepositoryFactory, T2> combinedResult, Action<Humidifier.AppRunner.ServiceTypes.ImageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithImageConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerServiceImageRepositoryFactory, InnerServiceImageConfigurationFactory> WithImageConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerServiceImageRepositoryFactory> combinedResult, Action<Humidifier.AppRunner.ServiceTypes.ImageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithImageConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerServiceImageRepositoryFactory, T1, T2, T3, InnerServiceImageConfigurationFactory> WithImageConfiguration<T1, T2, T3>(this CombinedResult<InnerServiceImageRepositoryFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppRunner.ServiceTypes.ImageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithImageConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerServiceImageRepositoryFactory, T2, T3, InnerServiceImageConfigurationFactory> WithImageConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerServiceImageRepositoryFactory, T2, T3> combinedResult, Action<Humidifier.AppRunner.ServiceTypes.ImageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithImageConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerServiceImageRepositoryFactory, T3, InnerServiceImageConfigurationFactory> WithImageConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerServiceImageRepositoryFactory, T3> combinedResult, Action<Humidifier.AppRunner.ServiceTypes.ImageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithImageConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerServiceImageRepositoryFactory, InnerServiceImageConfigurationFactory> WithImageConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerServiceImageRepositoryFactory> combinedResult, Action<Humidifier.AppRunner.ServiceTypes.ImageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithImageConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerServiceImageRepositoryFactory, T1, T2, T3, T4, InnerServiceImageConfigurationFactory> WithImageConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerServiceImageRepositoryFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppRunner.ServiceTypes.ImageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithImageConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerServiceImageRepositoryFactory, T2, T3, T4, InnerServiceImageConfigurationFactory> WithImageConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerServiceImageRepositoryFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppRunner.ServiceTypes.ImageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithImageConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerServiceImageRepositoryFactory, T3, T4, InnerServiceImageConfigurationFactory> WithImageConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerServiceImageRepositoryFactory, T3, T4> combinedResult, Action<Humidifier.AppRunner.ServiceTypes.ImageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithImageConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerServiceImageRepositoryFactory, T4, InnerServiceImageConfigurationFactory> WithImageConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerServiceImageRepositoryFactory, T4> combinedResult, Action<Humidifier.AppRunner.ServiceTypes.ImageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithImageConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerServiceImageRepositoryFactory, InnerServiceImageConfigurationFactory> WithImageConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerServiceImageRepositoryFactory> combinedResult, Action<Humidifier.AppRunner.ServiceTypes.ImageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithImageConfiguration(combinedResult.T5, subFactoryAction));
}
