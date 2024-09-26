// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.KinesisAnalyticsV2;

public class InnerApplicationApplicationCodeConfigurationFactory(Action<Humidifier.KinesisAnalyticsV2.ApplicationTypes.ApplicationCodeConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.KinesisAnalyticsV2.ApplicationTypes.ApplicationCodeConfiguration>
{

    internal InnerApplicationCodeContentFactory CodeContentFactory { get; set; }

    protected override Humidifier.KinesisAnalyticsV2.ApplicationTypes.ApplicationCodeConfiguration Create()
    {
        var applicationCodeConfigurationResult = CreateApplicationCodeConfiguration();
        factoryAction?.Invoke(applicationCodeConfigurationResult);

        return applicationCodeConfigurationResult;
    }

    private Humidifier.KinesisAnalyticsV2.ApplicationTypes.ApplicationCodeConfiguration CreateApplicationCodeConfiguration()
    {
        var applicationCodeConfigurationResult = new Humidifier.KinesisAnalyticsV2.ApplicationTypes.ApplicationCodeConfiguration();

        return applicationCodeConfigurationResult;
    }
    public override void CreateChildren(Humidifier.KinesisAnalyticsV2.ApplicationTypes.ApplicationCodeConfiguration result)
    {
        base.CreateChildren(result);

        result.CodeContent ??= CodeContentFactory?.Build();
    }

} // End Of Class

public static class InnerApplicationApplicationCodeConfigurationFactoryExtensions
{
    public static CombinedResult<InnerApplicationApplicationCodeConfigurationFactory, InnerApplicationCodeContentFactory> WithCodeContent(this InnerApplicationApplicationCodeConfigurationFactory parentFactory, Action<Humidifier.KinesisAnalyticsV2.ApplicationTypes.CodeContent> subFactoryAction = null)
    {
        parentFactory.CodeContentFactory = new InnerApplicationCodeContentFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CodeContentFactory);
    }

    public static CombinedResult<InnerApplicationApplicationCodeConfigurationFactory, T1, InnerApplicationCodeContentFactory> WithCodeContent<T1>(this CombinedResult<InnerApplicationApplicationCodeConfigurationFactory, T1> combinedResult, Action<Humidifier.KinesisAnalyticsV2.ApplicationTypes.CodeContent> subFactoryAction = null) => new (combinedResult, combinedResult, WithCodeContent(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerApplicationApplicationCodeConfigurationFactory, InnerApplicationCodeContentFactory> WithCodeContent<T1>(this CombinedResult<T1, InnerApplicationApplicationCodeConfigurationFactory> combinedResult, Action<Humidifier.KinesisAnalyticsV2.ApplicationTypes.CodeContent> subFactoryAction = null) => new (combinedResult, combinedResult, WithCodeContent(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerApplicationApplicationCodeConfigurationFactory, T1, T2, InnerApplicationCodeContentFactory> WithCodeContent<T1, T2>(this CombinedResult<InnerApplicationApplicationCodeConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.KinesisAnalyticsV2.ApplicationTypes.CodeContent> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCodeContent(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerApplicationApplicationCodeConfigurationFactory, T2, InnerApplicationCodeContentFactory> WithCodeContent<T1, T2>(this CombinedResult<T1, InnerApplicationApplicationCodeConfigurationFactory, T2> combinedResult, Action<Humidifier.KinesisAnalyticsV2.ApplicationTypes.CodeContent> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCodeContent(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerApplicationApplicationCodeConfigurationFactory, InnerApplicationCodeContentFactory> WithCodeContent<T1, T2>(this CombinedResult<T1, T2, InnerApplicationApplicationCodeConfigurationFactory> combinedResult, Action<Humidifier.KinesisAnalyticsV2.ApplicationTypes.CodeContent> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCodeContent(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerApplicationApplicationCodeConfigurationFactory, T1, T2, T3, InnerApplicationCodeContentFactory> WithCodeContent<T1, T2, T3>(this CombinedResult<InnerApplicationApplicationCodeConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.KinesisAnalyticsV2.ApplicationTypes.CodeContent> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCodeContent(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerApplicationApplicationCodeConfigurationFactory, T2, T3, InnerApplicationCodeContentFactory> WithCodeContent<T1, T2, T3>(this CombinedResult<T1, InnerApplicationApplicationCodeConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.KinesisAnalyticsV2.ApplicationTypes.CodeContent> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCodeContent(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerApplicationApplicationCodeConfigurationFactory, T3, InnerApplicationCodeContentFactory> WithCodeContent<T1, T2, T3>(this CombinedResult<T1, T2, InnerApplicationApplicationCodeConfigurationFactory, T3> combinedResult, Action<Humidifier.KinesisAnalyticsV2.ApplicationTypes.CodeContent> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCodeContent(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerApplicationApplicationCodeConfigurationFactory, InnerApplicationCodeContentFactory> WithCodeContent<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerApplicationApplicationCodeConfigurationFactory> combinedResult, Action<Humidifier.KinesisAnalyticsV2.ApplicationTypes.CodeContent> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCodeContent(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerApplicationApplicationCodeConfigurationFactory, T1, T2, T3, T4, InnerApplicationCodeContentFactory> WithCodeContent<T1, T2, T3, T4>(this CombinedResult<InnerApplicationApplicationCodeConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.KinesisAnalyticsV2.ApplicationTypes.CodeContent> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCodeContent(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerApplicationApplicationCodeConfigurationFactory, T2, T3, T4, InnerApplicationCodeContentFactory> WithCodeContent<T1, T2, T3, T4>(this CombinedResult<T1, InnerApplicationApplicationCodeConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.KinesisAnalyticsV2.ApplicationTypes.CodeContent> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCodeContent(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerApplicationApplicationCodeConfigurationFactory, T3, T4, InnerApplicationCodeContentFactory> WithCodeContent<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerApplicationApplicationCodeConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.KinesisAnalyticsV2.ApplicationTypes.CodeContent> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCodeContent(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerApplicationApplicationCodeConfigurationFactory, T4, InnerApplicationCodeContentFactory> WithCodeContent<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerApplicationApplicationCodeConfigurationFactory, T4> combinedResult, Action<Humidifier.KinesisAnalyticsV2.ApplicationTypes.CodeContent> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCodeContent(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerApplicationApplicationCodeConfigurationFactory, InnerApplicationCodeContentFactory> WithCodeContent<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerApplicationApplicationCodeConfigurationFactory> combinedResult, Action<Humidifier.KinesisAnalyticsV2.ApplicationTypes.CodeContent> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCodeContent(combinedResult.T5, subFactoryAction));
}
