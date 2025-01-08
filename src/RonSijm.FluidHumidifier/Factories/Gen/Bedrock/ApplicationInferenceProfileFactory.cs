// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class ApplicationInferenceProfileFactory(string resourceName = null, Action<Humidifier.Bedrock.ApplicationInferenceProfile> factoryAction = null) : ResourceFactory<Humidifier.Bedrock.ApplicationInferenceProfile>(resourceName)
{

    internal InnerApplicationInferenceProfileInferenceProfileModelSourceFactory ModelSourceFactory { get; set; }

    protected override Humidifier.Bedrock.ApplicationInferenceProfile Create()
    {
        var applicationInferenceProfileResult = CreateApplicationInferenceProfile();
        factoryAction?.Invoke(applicationInferenceProfileResult);

        return applicationInferenceProfileResult;
    }

    private Humidifier.Bedrock.ApplicationInferenceProfile CreateApplicationInferenceProfile()
    {
        var applicationInferenceProfileResult = new Humidifier.Bedrock.ApplicationInferenceProfile
        {
            GivenName = InputResourceName,
        };

        return applicationInferenceProfileResult;
    }
    public override void CreateChildren(Humidifier.Bedrock.ApplicationInferenceProfile result)
    {
        base.CreateChildren(result);

        result.ModelSource ??= ModelSourceFactory?.Build();
    }

} // End Of Class

public static class ApplicationInferenceProfileFactoryExtensions
{
    public static CombinedResult<ApplicationInferenceProfileFactory, InnerApplicationInferenceProfileInferenceProfileModelSourceFactory> WithModelSource(this ApplicationInferenceProfileFactory parentFactory, Action<Humidifier.Bedrock.ApplicationInferenceProfileTypes.InferenceProfileModelSource> subFactoryAction = null)
    {
        parentFactory.ModelSourceFactory = new InnerApplicationInferenceProfileInferenceProfileModelSourceFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ModelSourceFactory);
    }

    public static CombinedResult<ApplicationInferenceProfileFactory, T1, InnerApplicationInferenceProfileInferenceProfileModelSourceFactory> WithModelSource<T1>(this CombinedResult<ApplicationInferenceProfileFactory, T1> combinedResult, Action<Humidifier.Bedrock.ApplicationInferenceProfileTypes.InferenceProfileModelSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithModelSource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ApplicationInferenceProfileFactory, InnerApplicationInferenceProfileInferenceProfileModelSourceFactory> WithModelSource<T1>(this CombinedResult<T1, ApplicationInferenceProfileFactory> combinedResult, Action<Humidifier.Bedrock.ApplicationInferenceProfileTypes.InferenceProfileModelSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithModelSource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ApplicationInferenceProfileFactory, T1, T2, InnerApplicationInferenceProfileInferenceProfileModelSourceFactory> WithModelSource<T1, T2>(this CombinedResult<ApplicationInferenceProfileFactory, T1, T2> combinedResult, Action<Humidifier.Bedrock.ApplicationInferenceProfileTypes.InferenceProfileModelSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithModelSource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ApplicationInferenceProfileFactory, T2, InnerApplicationInferenceProfileInferenceProfileModelSourceFactory> WithModelSource<T1, T2>(this CombinedResult<T1, ApplicationInferenceProfileFactory, T2> combinedResult, Action<Humidifier.Bedrock.ApplicationInferenceProfileTypes.InferenceProfileModelSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithModelSource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ApplicationInferenceProfileFactory, InnerApplicationInferenceProfileInferenceProfileModelSourceFactory> WithModelSource<T1, T2>(this CombinedResult<T1, T2, ApplicationInferenceProfileFactory> combinedResult, Action<Humidifier.Bedrock.ApplicationInferenceProfileTypes.InferenceProfileModelSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithModelSource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ApplicationInferenceProfileFactory, T1, T2, T3, InnerApplicationInferenceProfileInferenceProfileModelSourceFactory> WithModelSource<T1, T2, T3>(this CombinedResult<ApplicationInferenceProfileFactory, T1, T2, T3> combinedResult, Action<Humidifier.Bedrock.ApplicationInferenceProfileTypes.InferenceProfileModelSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithModelSource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ApplicationInferenceProfileFactory, T2, T3, InnerApplicationInferenceProfileInferenceProfileModelSourceFactory> WithModelSource<T1, T2, T3>(this CombinedResult<T1, ApplicationInferenceProfileFactory, T2, T3> combinedResult, Action<Humidifier.Bedrock.ApplicationInferenceProfileTypes.InferenceProfileModelSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithModelSource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ApplicationInferenceProfileFactory, T3, InnerApplicationInferenceProfileInferenceProfileModelSourceFactory> WithModelSource<T1, T2, T3>(this CombinedResult<T1, T2, ApplicationInferenceProfileFactory, T3> combinedResult, Action<Humidifier.Bedrock.ApplicationInferenceProfileTypes.InferenceProfileModelSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithModelSource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ApplicationInferenceProfileFactory, InnerApplicationInferenceProfileInferenceProfileModelSourceFactory> WithModelSource<T1, T2, T3>(this CombinedResult<T1, T2, T3, ApplicationInferenceProfileFactory> combinedResult, Action<Humidifier.Bedrock.ApplicationInferenceProfileTypes.InferenceProfileModelSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithModelSource(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ApplicationInferenceProfileFactory, T1, T2, T3, T4, InnerApplicationInferenceProfileInferenceProfileModelSourceFactory> WithModelSource<T1, T2, T3, T4>(this CombinedResult<ApplicationInferenceProfileFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Bedrock.ApplicationInferenceProfileTypes.InferenceProfileModelSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithModelSource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ApplicationInferenceProfileFactory, T2, T3, T4, InnerApplicationInferenceProfileInferenceProfileModelSourceFactory> WithModelSource<T1, T2, T3, T4>(this CombinedResult<T1, ApplicationInferenceProfileFactory, T2, T3, T4> combinedResult, Action<Humidifier.Bedrock.ApplicationInferenceProfileTypes.InferenceProfileModelSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithModelSource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ApplicationInferenceProfileFactory, T3, T4, InnerApplicationInferenceProfileInferenceProfileModelSourceFactory> WithModelSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, ApplicationInferenceProfileFactory, T3, T4> combinedResult, Action<Humidifier.Bedrock.ApplicationInferenceProfileTypes.InferenceProfileModelSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithModelSource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ApplicationInferenceProfileFactory, T4, InnerApplicationInferenceProfileInferenceProfileModelSourceFactory> WithModelSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ApplicationInferenceProfileFactory, T4> combinedResult, Action<Humidifier.Bedrock.ApplicationInferenceProfileTypes.InferenceProfileModelSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithModelSource(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ApplicationInferenceProfileFactory, InnerApplicationInferenceProfileInferenceProfileModelSourceFactory> WithModelSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ApplicationInferenceProfileFactory> combinedResult, Action<Humidifier.Bedrock.ApplicationInferenceProfileTypes.InferenceProfileModelSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithModelSource(combinedResult.T5, subFactoryAction));
}
