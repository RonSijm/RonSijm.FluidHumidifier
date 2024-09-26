// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Pinpoint;

public class InAppTemplateFactory(string resourceName = null, Action<Humidifier.Pinpoint.InAppTemplate> factoryAction = null) : ResourceFactory<Humidifier.Pinpoint.InAppTemplate>(resourceName)
{

    internal List<InnerInAppTemplateInAppMessageContentFactory> ContentFactories { get; set; } = [];

    protected override Humidifier.Pinpoint.InAppTemplate Create()
    {
        var inAppTemplateResult = CreateInAppTemplate();
        factoryAction?.Invoke(inAppTemplateResult);

        return inAppTemplateResult;
    }

    private Humidifier.Pinpoint.InAppTemplate CreateInAppTemplate()
    {
        var inAppTemplateResult = new Humidifier.Pinpoint.InAppTemplate
        {
            GivenName = InputResourceName,
        };

        return inAppTemplateResult;
    }
    public override void CreateChildren(Humidifier.Pinpoint.InAppTemplate result)
    {
        base.CreateChildren(result);

        result.Content = ContentFactories.Any() ? ContentFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class InAppTemplateFactoryExtensions
{
    public static CombinedResult<InAppTemplateFactory, InnerInAppTemplateInAppMessageContentFactory> WithContent(this InAppTemplateFactory parentFactory, Action<Humidifier.Pinpoint.InAppTemplateTypes.InAppMessageContent> subFactoryAction = null)
    {
        var factory = new InnerInAppTemplateInAppMessageContentFactory(subFactoryAction);
        parentFactory.ContentFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<InAppTemplateFactory, T1, InnerInAppTemplateInAppMessageContentFactory> WithContent<T1>(this CombinedResult<InAppTemplateFactory, T1> combinedResult, Action<Humidifier.Pinpoint.InAppTemplateTypes.InAppMessageContent> subFactoryAction = null) => new (combinedResult, combinedResult, WithContent(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InAppTemplateFactory, InnerInAppTemplateInAppMessageContentFactory> WithContent<T1>(this CombinedResult<T1, InAppTemplateFactory> combinedResult, Action<Humidifier.Pinpoint.InAppTemplateTypes.InAppMessageContent> subFactoryAction = null) => new (combinedResult, combinedResult, WithContent(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InAppTemplateFactory, T1, T2, InnerInAppTemplateInAppMessageContentFactory> WithContent<T1, T2>(this CombinedResult<InAppTemplateFactory, T1, T2> combinedResult, Action<Humidifier.Pinpoint.InAppTemplateTypes.InAppMessageContent> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithContent(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InAppTemplateFactory, T2, InnerInAppTemplateInAppMessageContentFactory> WithContent<T1, T2>(this CombinedResult<T1, InAppTemplateFactory, T2> combinedResult, Action<Humidifier.Pinpoint.InAppTemplateTypes.InAppMessageContent> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithContent(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InAppTemplateFactory, InnerInAppTemplateInAppMessageContentFactory> WithContent<T1, T2>(this CombinedResult<T1, T2, InAppTemplateFactory> combinedResult, Action<Humidifier.Pinpoint.InAppTemplateTypes.InAppMessageContent> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithContent(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InAppTemplateFactory, T1, T2, T3, InnerInAppTemplateInAppMessageContentFactory> WithContent<T1, T2, T3>(this CombinedResult<InAppTemplateFactory, T1, T2, T3> combinedResult, Action<Humidifier.Pinpoint.InAppTemplateTypes.InAppMessageContent> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithContent(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InAppTemplateFactory, T2, T3, InnerInAppTemplateInAppMessageContentFactory> WithContent<T1, T2, T3>(this CombinedResult<T1, InAppTemplateFactory, T2, T3> combinedResult, Action<Humidifier.Pinpoint.InAppTemplateTypes.InAppMessageContent> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithContent(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InAppTemplateFactory, T3, InnerInAppTemplateInAppMessageContentFactory> WithContent<T1, T2, T3>(this CombinedResult<T1, T2, InAppTemplateFactory, T3> combinedResult, Action<Humidifier.Pinpoint.InAppTemplateTypes.InAppMessageContent> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithContent(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InAppTemplateFactory, InnerInAppTemplateInAppMessageContentFactory> WithContent<T1, T2, T3>(this CombinedResult<T1, T2, T3, InAppTemplateFactory> combinedResult, Action<Humidifier.Pinpoint.InAppTemplateTypes.InAppMessageContent> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithContent(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InAppTemplateFactory, T1, T2, T3, T4, InnerInAppTemplateInAppMessageContentFactory> WithContent<T1, T2, T3, T4>(this CombinedResult<InAppTemplateFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Pinpoint.InAppTemplateTypes.InAppMessageContent> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContent(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InAppTemplateFactory, T2, T3, T4, InnerInAppTemplateInAppMessageContentFactory> WithContent<T1, T2, T3, T4>(this CombinedResult<T1, InAppTemplateFactory, T2, T3, T4> combinedResult, Action<Humidifier.Pinpoint.InAppTemplateTypes.InAppMessageContent> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContent(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InAppTemplateFactory, T3, T4, InnerInAppTemplateInAppMessageContentFactory> WithContent<T1, T2, T3, T4>(this CombinedResult<T1, T2, InAppTemplateFactory, T3, T4> combinedResult, Action<Humidifier.Pinpoint.InAppTemplateTypes.InAppMessageContent> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContent(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InAppTemplateFactory, T4, InnerInAppTemplateInAppMessageContentFactory> WithContent<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InAppTemplateFactory, T4> combinedResult, Action<Humidifier.Pinpoint.InAppTemplateTypes.InAppMessageContent> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContent(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InAppTemplateFactory, InnerInAppTemplateInAppMessageContentFactory> WithContent<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InAppTemplateFactory> combinedResult, Action<Humidifier.Pinpoint.InAppTemplateTypes.InAppMessageContent> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContent(combinedResult.T5, subFactoryAction));
}
