// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Wisdom;

public class InnerMessageTemplateSmsMessageTemplateContentFactory(Action<Humidifier.Wisdom.MessageTemplateTypes.SmsMessageTemplateContent> factoryAction = null) : SubResourceFactory<Humidifier.Wisdom.MessageTemplateTypes.SmsMessageTemplateContent>
{

    internal InnerMessageTemplateSmsMessageTemplateContentBodyFactory BodyFactory { get; set; }

    protected override Humidifier.Wisdom.MessageTemplateTypes.SmsMessageTemplateContent Create()
    {
        var smsMessageTemplateContentResult = CreateSmsMessageTemplateContent();
        factoryAction?.Invoke(smsMessageTemplateContentResult);

        return smsMessageTemplateContentResult;
    }

    private Humidifier.Wisdom.MessageTemplateTypes.SmsMessageTemplateContent CreateSmsMessageTemplateContent()
    {
        var smsMessageTemplateContentResult = new Humidifier.Wisdom.MessageTemplateTypes.SmsMessageTemplateContent();

        return smsMessageTemplateContentResult;
    }
    public override void CreateChildren(Humidifier.Wisdom.MessageTemplateTypes.SmsMessageTemplateContent result)
    {
        base.CreateChildren(result);

        result.Body ??= BodyFactory?.Build();
    }

} // End Of Class

public static class InnerMessageTemplateSmsMessageTemplateContentFactoryExtensions
{
    public static CombinedResult<InnerMessageTemplateSmsMessageTemplateContentFactory, InnerMessageTemplateSmsMessageTemplateContentBodyFactory> WithBody(this InnerMessageTemplateSmsMessageTemplateContentFactory parentFactory, Action<Humidifier.Wisdom.MessageTemplateTypes.SmsMessageTemplateContentBody> subFactoryAction = null)
    {
        parentFactory.BodyFactory = new InnerMessageTemplateSmsMessageTemplateContentBodyFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.BodyFactory);
    }

    public static CombinedResult<InnerMessageTemplateSmsMessageTemplateContentFactory, T1, InnerMessageTemplateSmsMessageTemplateContentBodyFactory> WithBody<T1>(this CombinedResult<InnerMessageTemplateSmsMessageTemplateContentFactory, T1> combinedResult, Action<Humidifier.Wisdom.MessageTemplateTypes.SmsMessageTemplateContentBody> subFactoryAction = null) => new (combinedResult, combinedResult, WithBody(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerMessageTemplateSmsMessageTemplateContentFactory, InnerMessageTemplateSmsMessageTemplateContentBodyFactory> WithBody<T1>(this CombinedResult<T1, InnerMessageTemplateSmsMessageTemplateContentFactory> combinedResult, Action<Humidifier.Wisdom.MessageTemplateTypes.SmsMessageTemplateContentBody> subFactoryAction = null) => new (combinedResult, combinedResult, WithBody(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerMessageTemplateSmsMessageTemplateContentFactory, T1, T2, InnerMessageTemplateSmsMessageTemplateContentBodyFactory> WithBody<T1, T2>(this CombinedResult<InnerMessageTemplateSmsMessageTemplateContentFactory, T1, T2> combinedResult, Action<Humidifier.Wisdom.MessageTemplateTypes.SmsMessageTemplateContentBody> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBody(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerMessageTemplateSmsMessageTemplateContentFactory, T2, InnerMessageTemplateSmsMessageTemplateContentBodyFactory> WithBody<T1, T2>(this CombinedResult<T1, InnerMessageTemplateSmsMessageTemplateContentFactory, T2> combinedResult, Action<Humidifier.Wisdom.MessageTemplateTypes.SmsMessageTemplateContentBody> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBody(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerMessageTemplateSmsMessageTemplateContentFactory, InnerMessageTemplateSmsMessageTemplateContentBodyFactory> WithBody<T1, T2>(this CombinedResult<T1, T2, InnerMessageTemplateSmsMessageTemplateContentFactory> combinedResult, Action<Humidifier.Wisdom.MessageTemplateTypes.SmsMessageTemplateContentBody> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBody(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerMessageTemplateSmsMessageTemplateContentFactory, T1, T2, T3, InnerMessageTemplateSmsMessageTemplateContentBodyFactory> WithBody<T1, T2, T3>(this CombinedResult<InnerMessageTemplateSmsMessageTemplateContentFactory, T1, T2, T3> combinedResult, Action<Humidifier.Wisdom.MessageTemplateTypes.SmsMessageTemplateContentBody> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBody(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerMessageTemplateSmsMessageTemplateContentFactory, T2, T3, InnerMessageTemplateSmsMessageTemplateContentBodyFactory> WithBody<T1, T2, T3>(this CombinedResult<T1, InnerMessageTemplateSmsMessageTemplateContentFactory, T2, T3> combinedResult, Action<Humidifier.Wisdom.MessageTemplateTypes.SmsMessageTemplateContentBody> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBody(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerMessageTemplateSmsMessageTemplateContentFactory, T3, InnerMessageTemplateSmsMessageTemplateContentBodyFactory> WithBody<T1, T2, T3>(this CombinedResult<T1, T2, InnerMessageTemplateSmsMessageTemplateContentFactory, T3> combinedResult, Action<Humidifier.Wisdom.MessageTemplateTypes.SmsMessageTemplateContentBody> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBody(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerMessageTemplateSmsMessageTemplateContentFactory, InnerMessageTemplateSmsMessageTemplateContentBodyFactory> WithBody<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerMessageTemplateSmsMessageTemplateContentFactory> combinedResult, Action<Humidifier.Wisdom.MessageTemplateTypes.SmsMessageTemplateContentBody> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBody(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerMessageTemplateSmsMessageTemplateContentFactory, T1, T2, T3, T4, InnerMessageTemplateSmsMessageTemplateContentBodyFactory> WithBody<T1, T2, T3, T4>(this CombinedResult<InnerMessageTemplateSmsMessageTemplateContentFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Wisdom.MessageTemplateTypes.SmsMessageTemplateContentBody> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBody(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerMessageTemplateSmsMessageTemplateContentFactory, T2, T3, T4, InnerMessageTemplateSmsMessageTemplateContentBodyFactory> WithBody<T1, T2, T3, T4>(this CombinedResult<T1, InnerMessageTemplateSmsMessageTemplateContentFactory, T2, T3, T4> combinedResult, Action<Humidifier.Wisdom.MessageTemplateTypes.SmsMessageTemplateContentBody> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBody(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerMessageTemplateSmsMessageTemplateContentFactory, T3, T4, InnerMessageTemplateSmsMessageTemplateContentBodyFactory> WithBody<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerMessageTemplateSmsMessageTemplateContentFactory, T3, T4> combinedResult, Action<Humidifier.Wisdom.MessageTemplateTypes.SmsMessageTemplateContentBody> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBody(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerMessageTemplateSmsMessageTemplateContentFactory, T4, InnerMessageTemplateSmsMessageTemplateContentBodyFactory> WithBody<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerMessageTemplateSmsMessageTemplateContentFactory, T4> combinedResult, Action<Humidifier.Wisdom.MessageTemplateTypes.SmsMessageTemplateContentBody> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBody(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerMessageTemplateSmsMessageTemplateContentFactory, InnerMessageTemplateSmsMessageTemplateContentBodyFactory> WithBody<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerMessageTemplateSmsMessageTemplateContentFactory> combinedResult, Action<Humidifier.Wisdom.MessageTemplateTypes.SmsMessageTemplateContentBody> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBody(combinedResult.T5, subFactoryAction));
}
