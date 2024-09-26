// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ElasticBeanstalk;

public class ApplicationVersionFactory(string resourceName = null, Action<Humidifier.ElasticBeanstalk.ApplicationVersion> factoryAction = null) : ResourceFactory<Humidifier.ElasticBeanstalk.ApplicationVersion>(resourceName)
{

    internal InnerApplicationVersionSourceBundleFactory SourceBundleFactory { get; set; }

    protected override Humidifier.ElasticBeanstalk.ApplicationVersion Create()
    {
        var applicationVersionResult = CreateApplicationVersion();
        factoryAction?.Invoke(applicationVersionResult);

        return applicationVersionResult;
    }

    private Humidifier.ElasticBeanstalk.ApplicationVersion CreateApplicationVersion()
    {
        var applicationVersionResult = new Humidifier.ElasticBeanstalk.ApplicationVersion
        {
            GivenName = InputResourceName,
        };

        return applicationVersionResult;
    }
    public override void CreateChildren(Humidifier.ElasticBeanstalk.ApplicationVersion result)
    {
        base.CreateChildren(result);

        result.SourceBundle ??= SourceBundleFactory?.Build();
    }

} // End Of Class

public static class ApplicationVersionFactoryExtensions
{
    public static CombinedResult<ApplicationVersionFactory, InnerApplicationVersionSourceBundleFactory> WithSourceBundle(this ApplicationVersionFactory parentFactory, Action<Humidifier.ElasticBeanstalk.ApplicationVersionTypes.SourceBundle> subFactoryAction = null)
    {
        parentFactory.SourceBundleFactory = new InnerApplicationVersionSourceBundleFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SourceBundleFactory);
    }

    public static CombinedResult<ApplicationVersionFactory, T1, InnerApplicationVersionSourceBundleFactory> WithSourceBundle<T1>(this CombinedResult<ApplicationVersionFactory, T1> combinedResult, Action<Humidifier.ElasticBeanstalk.ApplicationVersionTypes.SourceBundle> subFactoryAction = null) => new (combinedResult, combinedResult, WithSourceBundle(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ApplicationVersionFactory, InnerApplicationVersionSourceBundleFactory> WithSourceBundle<T1>(this CombinedResult<T1, ApplicationVersionFactory> combinedResult, Action<Humidifier.ElasticBeanstalk.ApplicationVersionTypes.SourceBundle> subFactoryAction = null) => new (combinedResult, combinedResult, WithSourceBundle(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ApplicationVersionFactory, T1, T2, InnerApplicationVersionSourceBundleFactory> WithSourceBundle<T1, T2>(this CombinedResult<ApplicationVersionFactory, T1, T2> combinedResult, Action<Humidifier.ElasticBeanstalk.ApplicationVersionTypes.SourceBundle> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSourceBundle(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ApplicationVersionFactory, T2, InnerApplicationVersionSourceBundleFactory> WithSourceBundle<T1, T2>(this CombinedResult<T1, ApplicationVersionFactory, T2> combinedResult, Action<Humidifier.ElasticBeanstalk.ApplicationVersionTypes.SourceBundle> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSourceBundle(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ApplicationVersionFactory, InnerApplicationVersionSourceBundleFactory> WithSourceBundle<T1, T2>(this CombinedResult<T1, T2, ApplicationVersionFactory> combinedResult, Action<Humidifier.ElasticBeanstalk.ApplicationVersionTypes.SourceBundle> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSourceBundle(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ApplicationVersionFactory, T1, T2, T3, InnerApplicationVersionSourceBundleFactory> WithSourceBundle<T1, T2, T3>(this CombinedResult<ApplicationVersionFactory, T1, T2, T3> combinedResult, Action<Humidifier.ElasticBeanstalk.ApplicationVersionTypes.SourceBundle> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSourceBundle(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ApplicationVersionFactory, T2, T3, InnerApplicationVersionSourceBundleFactory> WithSourceBundle<T1, T2, T3>(this CombinedResult<T1, ApplicationVersionFactory, T2, T3> combinedResult, Action<Humidifier.ElasticBeanstalk.ApplicationVersionTypes.SourceBundle> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSourceBundle(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ApplicationVersionFactory, T3, InnerApplicationVersionSourceBundleFactory> WithSourceBundle<T1, T2, T3>(this CombinedResult<T1, T2, ApplicationVersionFactory, T3> combinedResult, Action<Humidifier.ElasticBeanstalk.ApplicationVersionTypes.SourceBundle> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSourceBundle(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ApplicationVersionFactory, InnerApplicationVersionSourceBundleFactory> WithSourceBundle<T1, T2, T3>(this CombinedResult<T1, T2, T3, ApplicationVersionFactory> combinedResult, Action<Humidifier.ElasticBeanstalk.ApplicationVersionTypes.SourceBundle> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSourceBundle(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ApplicationVersionFactory, T1, T2, T3, T4, InnerApplicationVersionSourceBundleFactory> WithSourceBundle<T1, T2, T3, T4>(this CombinedResult<ApplicationVersionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ElasticBeanstalk.ApplicationVersionTypes.SourceBundle> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourceBundle(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ApplicationVersionFactory, T2, T3, T4, InnerApplicationVersionSourceBundleFactory> WithSourceBundle<T1, T2, T3, T4>(this CombinedResult<T1, ApplicationVersionFactory, T2, T3, T4> combinedResult, Action<Humidifier.ElasticBeanstalk.ApplicationVersionTypes.SourceBundle> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourceBundle(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ApplicationVersionFactory, T3, T4, InnerApplicationVersionSourceBundleFactory> WithSourceBundle<T1, T2, T3, T4>(this CombinedResult<T1, T2, ApplicationVersionFactory, T3, T4> combinedResult, Action<Humidifier.ElasticBeanstalk.ApplicationVersionTypes.SourceBundle> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourceBundle(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ApplicationVersionFactory, T4, InnerApplicationVersionSourceBundleFactory> WithSourceBundle<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ApplicationVersionFactory, T4> combinedResult, Action<Humidifier.ElasticBeanstalk.ApplicationVersionTypes.SourceBundle> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourceBundle(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ApplicationVersionFactory, InnerApplicationVersionSourceBundleFactory> WithSourceBundle<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ApplicationVersionFactory> combinedResult, Action<Humidifier.ElasticBeanstalk.ApplicationVersionTypes.SourceBundle> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourceBundle(combinedResult.T5, subFactoryAction));
}
