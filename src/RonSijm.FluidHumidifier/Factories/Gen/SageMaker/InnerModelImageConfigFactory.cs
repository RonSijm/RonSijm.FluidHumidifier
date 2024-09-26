// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerModelImageConfigFactory(Action<Humidifier.SageMaker.ModelTypes.ImageConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ModelTypes.ImageConfig>
{

    internal InnerModelRepositoryAuthConfigFactory RepositoryAuthConfigFactory { get; set; }

    protected override Humidifier.SageMaker.ModelTypes.ImageConfig Create()
    {
        var imageConfigResult = CreateImageConfig();
        factoryAction?.Invoke(imageConfigResult);

        return imageConfigResult;
    }

    private Humidifier.SageMaker.ModelTypes.ImageConfig CreateImageConfig()
    {
        var imageConfigResult = new Humidifier.SageMaker.ModelTypes.ImageConfig();

        return imageConfigResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.ModelTypes.ImageConfig result)
    {
        base.CreateChildren(result);

        result.RepositoryAuthConfig ??= RepositoryAuthConfigFactory?.Build();
    }

} // End Of Class

public static class InnerModelImageConfigFactoryExtensions
{
    public static CombinedResult<InnerModelImageConfigFactory, InnerModelRepositoryAuthConfigFactory> WithRepositoryAuthConfig(this InnerModelImageConfigFactory parentFactory, Action<Humidifier.SageMaker.ModelTypes.RepositoryAuthConfig> subFactoryAction = null)
    {
        parentFactory.RepositoryAuthConfigFactory = new InnerModelRepositoryAuthConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.RepositoryAuthConfigFactory);
    }

    public static CombinedResult<InnerModelImageConfigFactory, T1, InnerModelRepositoryAuthConfigFactory> WithRepositoryAuthConfig<T1>(this CombinedResult<InnerModelImageConfigFactory, T1> combinedResult, Action<Humidifier.SageMaker.ModelTypes.RepositoryAuthConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithRepositoryAuthConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelImageConfigFactory, InnerModelRepositoryAuthConfigFactory> WithRepositoryAuthConfig<T1>(this CombinedResult<T1, InnerModelImageConfigFactory> combinedResult, Action<Humidifier.SageMaker.ModelTypes.RepositoryAuthConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithRepositoryAuthConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerModelImageConfigFactory, T1, T2, InnerModelRepositoryAuthConfigFactory> WithRepositoryAuthConfig<T1, T2>(this CombinedResult<InnerModelImageConfigFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.ModelTypes.RepositoryAuthConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRepositoryAuthConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelImageConfigFactory, T2, InnerModelRepositoryAuthConfigFactory> WithRepositoryAuthConfig<T1, T2>(this CombinedResult<T1, InnerModelImageConfigFactory, T2> combinedResult, Action<Humidifier.SageMaker.ModelTypes.RepositoryAuthConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRepositoryAuthConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerModelImageConfigFactory, InnerModelRepositoryAuthConfigFactory> WithRepositoryAuthConfig<T1, T2>(this CombinedResult<T1, T2, InnerModelImageConfigFactory> combinedResult, Action<Humidifier.SageMaker.ModelTypes.RepositoryAuthConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRepositoryAuthConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerModelImageConfigFactory, T1, T2, T3, InnerModelRepositoryAuthConfigFactory> WithRepositoryAuthConfig<T1, T2, T3>(this CombinedResult<InnerModelImageConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.ModelTypes.RepositoryAuthConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRepositoryAuthConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelImageConfigFactory, T2, T3, InnerModelRepositoryAuthConfigFactory> WithRepositoryAuthConfig<T1, T2, T3>(this CombinedResult<T1, InnerModelImageConfigFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.ModelTypes.RepositoryAuthConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRepositoryAuthConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerModelImageConfigFactory, T3, InnerModelRepositoryAuthConfigFactory> WithRepositoryAuthConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerModelImageConfigFactory, T3> combinedResult, Action<Humidifier.SageMaker.ModelTypes.RepositoryAuthConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRepositoryAuthConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerModelImageConfigFactory, InnerModelRepositoryAuthConfigFactory> WithRepositoryAuthConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerModelImageConfigFactory> combinedResult, Action<Humidifier.SageMaker.ModelTypes.RepositoryAuthConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRepositoryAuthConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerModelImageConfigFactory, T1, T2, T3, T4, InnerModelRepositoryAuthConfigFactory> WithRepositoryAuthConfig<T1, T2, T3, T4>(this CombinedResult<InnerModelImageConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelTypes.RepositoryAuthConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRepositoryAuthConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelImageConfigFactory, T2, T3, T4, InnerModelRepositoryAuthConfigFactory> WithRepositoryAuthConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerModelImageConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelTypes.RepositoryAuthConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRepositoryAuthConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerModelImageConfigFactory, T3, T4, InnerModelRepositoryAuthConfigFactory> WithRepositoryAuthConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerModelImageConfigFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelTypes.RepositoryAuthConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRepositoryAuthConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerModelImageConfigFactory, T4, InnerModelRepositoryAuthConfigFactory> WithRepositoryAuthConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerModelImageConfigFactory, T4> combinedResult, Action<Humidifier.SageMaker.ModelTypes.RepositoryAuthConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRepositoryAuthConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerModelImageConfigFactory, InnerModelRepositoryAuthConfigFactory> WithRepositoryAuthConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerModelImageConfigFactory> combinedResult, Action<Humidifier.SageMaker.ModelTypes.RepositoryAuthConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRepositoryAuthConfig(combinedResult.T5, subFactoryAction));
}
