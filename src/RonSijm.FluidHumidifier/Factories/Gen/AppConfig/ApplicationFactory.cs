// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppConfig;

public class ApplicationFactory(string resourceName = null, Action<Humidifier.AppConfig.Application> factoryAction = null) : ResourceFactory<Humidifier.AppConfig.Application>(resourceName)
{

    internal List<InnerApplicationTagsFactory> TagsFactories { get; set; } = [];

    protected override Humidifier.AppConfig.Application Create()
    {
        var applicationResult = CreateApplication();
        factoryAction?.Invoke(applicationResult);

        return applicationResult;
    }

    private Humidifier.AppConfig.Application CreateApplication()
    {
        var applicationResult = new Humidifier.AppConfig.Application
        {
            GivenName = InputResourceName,
        };

        return applicationResult;
    }
    public override void CreateChildren(Humidifier.AppConfig.Application result)
    {
        base.CreateChildren(result);

        result.Tags = TagsFactories.Any() ? TagsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class ApplicationFactoryExtensions
{
    public static CombinedResult<ApplicationFactory, InnerApplicationTagsFactory> WithTags(this ApplicationFactory parentFactory, Action<Humidifier.AppConfig.ApplicationTypes.Tags> subFactoryAction = null)
    {
        var factory = new InnerApplicationTagsFactory(subFactoryAction);
        parentFactory.TagsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<ApplicationFactory, T1, InnerApplicationTagsFactory> WithTags<T1>(this CombinedResult<ApplicationFactory, T1> combinedResult, Action<Humidifier.AppConfig.ApplicationTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ApplicationFactory, InnerApplicationTagsFactory> WithTags<T1>(this CombinedResult<T1, ApplicationFactory> combinedResult, Action<Humidifier.AppConfig.ApplicationTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ApplicationFactory, T1, T2, InnerApplicationTagsFactory> WithTags<T1, T2>(this CombinedResult<ApplicationFactory, T1, T2> combinedResult, Action<Humidifier.AppConfig.ApplicationTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ApplicationFactory, T2, InnerApplicationTagsFactory> WithTags<T1, T2>(this CombinedResult<T1, ApplicationFactory, T2> combinedResult, Action<Humidifier.AppConfig.ApplicationTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ApplicationFactory, InnerApplicationTagsFactory> WithTags<T1, T2>(this CombinedResult<T1, T2, ApplicationFactory> combinedResult, Action<Humidifier.AppConfig.ApplicationTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ApplicationFactory, T1, T2, T3, InnerApplicationTagsFactory> WithTags<T1, T2, T3>(this CombinedResult<ApplicationFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppConfig.ApplicationTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ApplicationFactory, T2, T3, InnerApplicationTagsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, ApplicationFactory, T2, T3> combinedResult, Action<Humidifier.AppConfig.ApplicationTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ApplicationFactory, T3, InnerApplicationTagsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, ApplicationFactory, T3> combinedResult, Action<Humidifier.AppConfig.ApplicationTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ApplicationFactory, InnerApplicationTagsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, T3, ApplicationFactory> combinedResult, Action<Humidifier.AppConfig.ApplicationTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ApplicationFactory, T1, T2, T3, T4, InnerApplicationTagsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<ApplicationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppConfig.ApplicationTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ApplicationFactory, T2, T3, T4, InnerApplicationTagsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, ApplicationFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppConfig.ApplicationTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ApplicationFactory, T3, T4, InnerApplicationTagsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, ApplicationFactory, T3, T4> combinedResult, Action<Humidifier.AppConfig.ApplicationTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ApplicationFactory, T4, InnerApplicationTagsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ApplicationFactory, T4> combinedResult, Action<Humidifier.AppConfig.ApplicationTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ApplicationFactory, InnerApplicationTagsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ApplicationFactory> combinedResult, Action<Humidifier.AppConfig.ApplicationTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T5, subFactoryAction));
}
