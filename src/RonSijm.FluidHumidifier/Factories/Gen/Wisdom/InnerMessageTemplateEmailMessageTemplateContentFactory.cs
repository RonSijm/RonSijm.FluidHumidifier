// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Wisdom;

public class InnerMessageTemplateEmailMessageTemplateContentFactory(Action<Humidifier.Wisdom.MessageTemplateTypes.EmailMessageTemplateContent> factoryAction = null) : SubResourceFactory<Humidifier.Wisdom.MessageTemplateTypes.EmailMessageTemplateContent>
{

    internal InnerMessageTemplateEmailMessageTemplateContentBodyFactory BodyFactory { get; set; }

    protected override Humidifier.Wisdom.MessageTemplateTypes.EmailMessageTemplateContent Create()
    {
        var emailMessageTemplateContentResult = CreateEmailMessageTemplateContent();
        factoryAction?.Invoke(emailMessageTemplateContentResult);

        return emailMessageTemplateContentResult;
    }

    private Humidifier.Wisdom.MessageTemplateTypes.EmailMessageTemplateContent CreateEmailMessageTemplateContent()
    {
        var emailMessageTemplateContentResult = new Humidifier.Wisdom.MessageTemplateTypes.EmailMessageTemplateContent();

        return emailMessageTemplateContentResult;
    }
    public override void CreateChildren(Humidifier.Wisdom.MessageTemplateTypes.EmailMessageTemplateContent result)
    {
        base.CreateChildren(result);

        result.Body ??= BodyFactory?.Build();
    }

} // End Of Class

public static class InnerMessageTemplateEmailMessageTemplateContentFactoryExtensions
{
    public static CombinedResult<InnerMessageTemplateEmailMessageTemplateContentFactory, InnerMessageTemplateEmailMessageTemplateContentBodyFactory> WithBody(this InnerMessageTemplateEmailMessageTemplateContentFactory parentFactory, Action<Humidifier.Wisdom.MessageTemplateTypes.EmailMessageTemplateContentBody> subFactoryAction = null)
    {
        parentFactory.BodyFactory = new InnerMessageTemplateEmailMessageTemplateContentBodyFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.BodyFactory);
    }

    public static CombinedResult<InnerMessageTemplateEmailMessageTemplateContentFactory, T1, InnerMessageTemplateEmailMessageTemplateContentBodyFactory> WithBody<T1>(this CombinedResult<InnerMessageTemplateEmailMessageTemplateContentFactory, T1> combinedResult, Action<Humidifier.Wisdom.MessageTemplateTypes.EmailMessageTemplateContentBody> subFactoryAction = null) => new (combinedResult, combinedResult, WithBody(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerMessageTemplateEmailMessageTemplateContentFactory, InnerMessageTemplateEmailMessageTemplateContentBodyFactory> WithBody<T1>(this CombinedResult<T1, InnerMessageTemplateEmailMessageTemplateContentFactory> combinedResult, Action<Humidifier.Wisdom.MessageTemplateTypes.EmailMessageTemplateContentBody> subFactoryAction = null) => new (combinedResult, combinedResult, WithBody(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerMessageTemplateEmailMessageTemplateContentFactory, T1, T2, InnerMessageTemplateEmailMessageTemplateContentBodyFactory> WithBody<T1, T2>(this CombinedResult<InnerMessageTemplateEmailMessageTemplateContentFactory, T1, T2> combinedResult, Action<Humidifier.Wisdom.MessageTemplateTypes.EmailMessageTemplateContentBody> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBody(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerMessageTemplateEmailMessageTemplateContentFactory, T2, InnerMessageTemplateEmailMessageTemplateContentBodyFactory> WithBody<T1, T2>(this CombinedResult<T1, InnerMessageTemplateEmailMessageTemplateContentFactory, T2> combinedResult, Action<Humidifier.Wisdom.MessageTemplateTypes.EmailMessageTemplateContentBody> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBody(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerMessageTemplateEmailMessageTemplateContentFactory, InnerMessageTemplateEmailMessageTemplateContentBodyFactory> WithBody<T1, T2>(this CombinedResult<T1, T2, InnerMessageTemplateEmailMessageTemplateContentFactory> combinedResult, Action<Humidifier.Wisdom.MessageTemplateTypes.EmailMessageTemplateContentBody> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBody(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerMessageTemplateEmailMessageTemplateContentFactory, T1, T2, T3, InnerMessageTemplateEmailMessageTemplateContentBodyFactory> WithBody<T1, T2, T3>(this CombinedResult<InnerMessageTemplateEmailMessageTemplateContentFactory, T1, T2, T3> combinedResult, Action<Humidifier.Wisdom.MessageTemplateTypes.EmailMessageTemplateContentBody> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBody(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerMessageTemplateEmailMessageTemplateContentFactory, T2, T3, InnerMessageTemplateEmailMessageTemplateContentBodyFactory> WithBody<T1, T2, T3>(this CombinedResult<T1, InnerMessageTemplateEmailMessageTemplateContentFactory, T2, T3> combinedResult, Action<Humidifier.Wisdom.MessageTemplateTypes.EmailMessageTemplateContentBody> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBody(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerMessageTemplateEmailMessageTemplateContentFactory, T3, InnerMessageTemplateEmailMessageTemplateContentBodyFactory> WithBody<T1, T2, T3>(this CombinedResult<T1, T2, InnerMessageTemplateEmailMessageTemplateContentFactory, T3> combinedResult, Action<Humidifier.Wisdom.MessageTemplateTypes.EmailMessageTemplateContentBody> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBody(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerMessageTemplateEmailMessageTemplateContentFactory, InnerMessageTemplateEmailMessageTemplateContentBodyFactory> WithBody<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerMessageTemplateEmailMessageTemplateContentFactory> combinedResult, Action<Humidifier.Wisdom.MessageTemplateTypes.EmailMessageTemplateContentBody> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBody(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerMessageTemplateEmailMessageTemplateContentFactory, T1, T2, T3, T4, InnerMessageTemplateEmailMessageTemplateContentBodyFactory> WithBody<T1, T2, T3, T4>(this CombinedResult<InnerMessageTemplateEmailMessageTemplateContentFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Wisdom.MessageTemplateTypes.EmailMessageTemplateContentBody> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBody(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerMessageTemplateEmailMessageTemplateContentFactory, T2, T3, T4, InnerMessageTemplateEmailMessageTemplateContentBodyFactory> WithBody<T1, T2, T3, T4>(this CombinedResult<T1, InnerMessageTemplateEmailMessageTemplateContentFactory, T2, T3, T4> combinedResult, Action<Humidifier.Wisdom.MessageTemplateTypes.EmailMessageTemplateContentBody> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBody(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerMessageTemplateEmailMessageTemplateContentFactory, T3, T4, InnerMessageTemplateEmailMessageTemplateContentBodyFactory> WithBody<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerMessageTemplateEmailMessageTemplateContentFactory, T3, T4> combinedResult, Action<Humidifier.Wisdom.MessageTemplateTypes.EmailMessageTemplateContentBody> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBody(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerMessageTemplateEmailMessageTemplateContentFactory, T4, InnerMessageTemplateEmailMessageTemplateContentBodyFactory> WithBody<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerMessageTemplateEmailMessageTemplateContentFactory, T4> combinedResult, Action<Humidifier.Wisdom.MessageTemplateTypes.EmailMessageTemplateContentBody> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBody(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerMessageTemplateEmailMessageTemplateContentFactory, InnerMessageTemplateEmailMessageTemplateContentBodyFactory> WithBody<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerMessageTemplateEmailMessageTemplateContentFactory> combinedResult, Action<Humidifier.Wisdom.MessageTemplateTypes.EmailMessageTemplateContentBody> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBody(combinedResult.T5, subFactoryAction));
}
