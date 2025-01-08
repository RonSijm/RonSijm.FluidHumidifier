// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Wisdom;

public class InnerMessageTemplateSmsMessageTemplateContentBodyFactory(Action<Humidifier.Wisdom.MessageTemplateTypes.SmsMessageTemplateContentBody> factoryAction = null) : SubResourceFactory<Humidifier.Wisdom.MessageTemplateTypes.SmsMessageTemplateContentBody>
{

    internal InnerMessageTemplateMessageTemplateBodyContentProviderFactory PlainTextFactory { get; set; }

    protected override Humidifier.Wisdom.MessageTemplateTypes.SmsMessageTemplateContentBody Create()
    {
        var smsMessageTemplateContentBodyResult = CreateSmsMessageTemplateContentBody();
        factoryAction?.Invoke(smsMessageTemplateContentBodyResult);

        return smsMessageTemplateContentBodyResult;
    }

    private Humidifier.Wisdom.MessageTemplateTypes.SmsMessageTemplateContentBody CreateSmsMessageTemplateContentBody()
    {
        var smsMessageTemplateContentBodyResult = new Humidifier.Wisdom.MessageTemplateTypes.SmsMessageTemplateContentBody();

        return smsMessageTemplateContentBodyResult;
    }
    public override void CreateChildren(Humidifier.Wisdom.MessageTemplateTypes.SmsMessageTemplateContentBody result)
    {
        base.CreateChildren(result);

        result.PlainText ??= PlainTextFactory?.Build();
    }

} // End Of Class

public static class InnerMessageTemplateSmsMessageTemplateContentBodyFactoryExtensions
{
    public static CombinedResult<InnerMessageTemplateSmsMessageTemplateContentBodyFactory, InnerMessageTemplateMessageTemplateBodyContentProviderFactory> WithPlainText(this InnerMessageTemplateSmsMessageTemplateContentBodyFactory parentFactory, Action<Humidifier.Wisdom.MessageTemplateTypes.MessageTemplateBodyContentProvider> subFactoryAction = null)
    {
        parentFactory.PlainTextFactory = new InnerMessageTemplateMessageTemplateBodyContentProviderFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.PlainTextFactory);
    }

    public static CombinedResult<InnerMessageTemplateSmsMessageTemplateContentBodyFactory, T1, InnerMessageTemplateMessageTemplateBodyContentProviderFactory> WithPlainText<T1>(this CombinedResult<InnerMessageTemplateSmsMessageTemplateContentBodyFactory, T1> combinedResult, Action<Humidifier.Wisdom.MessageTemplateTypes.MessageTemplateBodyContentProvider> subFactoryAction = null) => new (combinedResult, combinedResult, WithPlainText(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerMessageTemplateSmsMessageTemplateContentBodyFactory, InnerMessageTemplateMessageTemplateBodyContentProviderFactory> WithPlainText<T1>(this CombinedResult<T1, InnerMessageTemplateSmsMessageTemplateContentBodyFactory> combinedResult, Action<Humidifier.Wisdom.MessageTemplateTypes.MessageTemplateBodyContentProvider> subFactoryAction = null) => new (combinedResult, combinedResult, WithPlainText(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerMessageTemplateSmsMessageTemplateContentBodyFactory, T1, T2, InnerMessageTemplateMessageTemplateBodyContentProviderFactory> WithPlainText<T1, T2>(this CombinedResult<InnerMessageTemplateSmsMessageTemplateContentBodyFactory, T1, T2> combinedResult, Action<Humidifier.Wisdom.MessageTemplateTypes.MessageTemplateBodyContentProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPlainText(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerMessageTemplateSmsMessageTemplateContentBodyFactory, T2, InnerMessageTemplateMessageTemplateBodyContentProviderFactory> WithPlainText<T1, T2>(this CombinedResult<T1, InnerMessageTemplateSmsMessageTemplateContentBodyFactory, T2> combinedResult, Action<Humidifier.Wisdom.MessageTemplateTypes.MessageTemplateBodyContentProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPlainText(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerMessageTemplateSmsMessageTemplateContentBodyFactory, InnerMessageTemplateMessageTemplateBodyContentProviderFactory> WithPlainText<T1, T2>(this CombinedResult<T1, T2, InnerMessageTemplateSmsMessageTemplateContentBodyFactory> combinedResult, Action<Humidifier.Wisdom.MessageTemplateTypes.MessageTemplateBodyContentProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPlainText(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerMessageTemplateSmsMessageTemplateContentBodyFactory, T1, T2, T3, InnerMessageTemplateMessageTemplateBodyContentProviderFactory> WithPlainText<T1, T2, T3>(this CombinedResult<InnerMessageTemplateSmsMessageTemplateContentBodyFactory, T1, T2, T3> combinedResult, Action<Humidifier.Wisdom.MessageTemplateTypes.MessageTemplateBodyContentProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPlainText(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerMessageTemplateSmsMessageTemplateContentBodyFactory, T2, T3, InnerMessageTemplateMessageTemplateBodyContentProviderFactory> WithPlainText<T1, T2, T3>(this CombinedResult<T1, InnerMessageTemplateSmsMessageTemplateContentBodyFactory, T2, T3> combinedResult, Action<Humidifier.Wisdom.MessageTemplateTypes.MessageTemplateBodyContentProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPlainText(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerMessageTemplateSmsMessageTemplateContentBodyFactory, T3, InnerMessageTemplateMessageTemplateBodyContentProviderFactory> WithPlainText<T1, T2, T3>(this CombinedResult<T1, T2, InnerMessageTemplateSmsMessageTemplateContentBodyFactory, T3> combinedResult, Action<Humidifier.Wisdom.MessageTemplateTypes.MessageTemplateBodyContentProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPlainText(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerMessageTemplateSmsMessageTemplateContentBodyFactory, InnerMessageTemplateMessageTemplateBodyContentProviderFactory> WithPlainText<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerMessageTemplateSmsMessageTemplateContentBodyFactory> combinedResult, Action<Humidifier.Wisdom.MessageTemplateTypes.MessageTemplateBodyContentProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPlainText(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerMessageTemplateSmsMessageTemplateContentBodyFactory, T1, T2, T3, T4, InnerMessageTemplateMessageTemplateBodyContentProviderFactory> WithPlainText<T1, T2, T3, T4>(this CombinedResult<InnerMessageTemplateSmsMessageTemplateContentBodyFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Wisdom.MessageTemplateTypes.MessageTemplateBodyContentProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPlainText(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerMessageTemplateSmsMessageTemplateContentBodyFactory, T2, T3, T4, InnerMessageTemplateMessageTemplateBodyContentProviderFactory> WithPlainText<T1, T2, T3, T4>(this CombinedResult<T1, InnerMessageTemplateSmsMessageTemplateContentBodyFactory, T2, T3, T4> combinedResult, Action<Humidifier.Wisdom.MessageTemplateTypes.MessageTemplateBodyContentProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPlainText(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerMessageTemplateSmsMessageTemplateContentBodyFactory, T3, T4, InnerMessageTemplateMessageTemplateBodyContentProviderFactory> WithPlainText<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerMessageTemplateSmsMessageTemplateContentBodyFactory, T3, T4> combinedResult, Action<Humidifier.Wisdom.MessageTemplateTypes.MessageTemplateBodyContentProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPlainText(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerMessageTemplateSmsMessageTemplateContentBodyFactory, T4, InnerMessageTemplateMessageTemplateBodyContentProviderFactory> WithPlainText<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerMessageTemplateSmsMessageTemplateContentBodyFactory, T4> combinedResult, Action<Humidifier.Wisdom.MessageTemplateTypes.MessageTemplateBodyContentProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPlainText(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerMessageTemplateSmsMessageTemplateContentBodyFactory, InnerMessageTemplateMessageTemplateBodyContentProviderFactory> WithPlainText<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerMessageTemplateSmsMessageTemplateContentBodyFactory> combinedResult, Action<Humidifier.Wisdom.MessageTemplateTypes.MessageTemplateBodyContentProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPlainText(combinedResult.T5, subFactoryAction));
}
