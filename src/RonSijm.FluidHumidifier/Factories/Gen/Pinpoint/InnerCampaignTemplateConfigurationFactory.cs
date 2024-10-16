// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Pinpoint;

public class InnerCampaignTemplateConfigurationFactory(Action<Humidifier.Pinpoint.CampaignTypes.TemplateConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Pinpoint.CampaignTypes.TemplateConfiguration>
{

    internal InnerCampaignTemplateFactory SMSTemplateFactory { get; set; }

    internal InnerCampaignTemplateFactory EmailTemplateFactory { get; set; }

    internal InnerCampaignTemplateFactory PushTemplateFactory { get; set; }

    internal InnerCampaignTemplateFactory VoiceTemplateFactory { get; set; }

    protected override Humidifier.Pinpoint.CampaignTypes.TemplateConfiguration Create()
    {
        var templateConfigurationResult = CreateTemplateConfiguration();
        factoryAction?.Invoke(templateConfigurationResult);

        return templateConfigurationResult;
    }

    private Humidifier.Pinpoint.CampaignTypes.TemplateConfiguration CreateTemplateConfiguration()
    {
        var templateConfigurationResult = new Humidifier.Pinpoint.CampaignTypes.TemplateConfiguration();

        return templateConfigurationResult;
    }
    public override void CreateChildren(Humidifier.Pinpoint.CampaignTypes.TemplateConfiguration result)
    {
        base.CreateChildren(result);

        result.SMSTemplate ??= SMSTemplateFactory?.Build();
        result.EmailTemplate ??= EmailTemplateFactory?.Build();
        result.PushTemplate ??= PushTemplateFactory?.Build();
        result.VoiceTemplate ??= VoiceTemplateFactory?.Build();
    }

} // End Of Class

public static class InnerCampaignTemplateConfigurationFactoryExtensions
{
    public static CombinedResult<InnerCampaignTemplateConfigurationFactory, InnerCampaignTemplateFactory> WithSMSTemplate(this InnerCampaignTemplateConfigurationFactory parentFactory, Action<Humidifier.Pinpoint.CampaignTypes.Template> subFactoryAction = null)
    {
        parentFactory.SMSTemplateFactory = new InnerCampaignTemplateFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SMSTemplateFactory);
    }

    public static CombinedResult<InnerCampaignTemplateConfigurationFactory, InnerCampaignTemplateFactory> WithEmailTemplate(this InnerCampaignTemplateConfigurationFactory parentFactory, Action<Humidifier.Pinpoint.CampaignTypes.Template> subFactoryAction = null)
    {
        parentFactory.EmailTemplateFactory = new InnerCampaignTemplateFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EmailTemplateFactory);
    }

    public static CombinedResult<InnerCampaignTemplateConfigurationFactory, InnerCampaignTemplateFactory> WithPushTemplate(this InnerCampaignTemplateConfigurationFactory parentFactory, Action<Humidifier.Pinpoint.CampaignTypes.Template> subFactoryAction = null)
    {
        parentFactory.PushTemplateFactory = new InnerCampaignTemplateFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.PushTemplateFactory);
    }

    public static CombinedResult<InnerCampaignTemplateConfigurationFactory, InnerCampaignTemplateFactory> WithVoiceTemplate(this InnerCampaignTemplateConfigurationFactory parentFactory, Action<Humidifier.Pinpoint.CampaignTypes.Template> subFactoryAction = null)
    {
        parentFactory.VoiceTemplateFactory = new InnerCampaignTemplateFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.VoiceTemplateFactory);
    }

    public static CombinedResult<InnerCampaignTemplateConfigurationFactory, T1, InnerCampaignTemplateFactory> WithSMSTemplate<T1>(this CombinedResult<InnerCampaignTemplateConfigurationFactory, T1> combinedResult, Action<Humidifier.Pinpoint.CampaignTypes.Template> subFactoryAction = null) => new (combinedResult, combinedResult, WithSMSTemplate(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCampaignTemplateConfigurationFactory, InnerCampaignTemplateFactory> WithSMSTemplate<T1>(this CombinedResult<T1, InnerCampaignTemplateConfigurationFactory> combinedResult, Action<Humidifier.Pinpoint.CampaignTypes.Template> subFactoryAction = null) => new (combinedResult, combinedResult, WithSMSTemplate(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerCampaignTemplateConfigurationFactory, T1, T2, InnerCampaignTemplateFactory> WithSMSTemplate<T1, T2>(this CombinedResult<InnerCampaignTemplateConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.Pinpoint.CampaignTypes.Template> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSMSTemplate(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCampaignTemplateConfigurationFactory, T2, InnerCampaignTemplateFactory> WithSMSTemplate<T1, T2>(this CombinedResult<T1, InnerCampaignTemplateConfigurationFactory, T2> combinedResult, Action<Humidifier.Pinpoint.CampaignTypes.Template> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSMSTemplate(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerCampaignTemplateConfigurationFactory, InnerCampaignTemplateFactory> WithSMSTemplate<T1, T2>(this CombinedResult<T1, T2, InnerCampaignTemplateConfigurationFactory> combinedResult, Action<Humidifier.Pinpoint.CampaignTypes.Template> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSMSTemplate(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerCampaignTemplateConfigurationFactory, T1, T2, T3, InnerCampaignTemplateFactory> WithSMSTemplate<T1, T2, T3>(this CombinedResult<InnerCampaignTemplateConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Pinpoint.CampaignTypes.Template> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSMSTemplate(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCampaignTemplateConfigurationFactory, T2, T3, InnerCampaignTemplateFactory> WithSMSTemplate<T1, T2, T3>(this CombinedResult<T1, InnerCampaignTemplateConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.Pinpoint.CampaignTypes.Template> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSMSTemplate(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerCampaignTemplateConfigurationFactory, T3, InnerCampaignTemplateFactory> WithSMSTemplate<T1, T2, T3>(this CombinedResult<T1, T2, InnerCampaignTemplateConfigurationFactory, T3> combinedResult, Action<Humidifier.Pinpoint.CampaignTypes.Template> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSMSTemplate(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerCampaignTemplateConfigurationFactory, InnerCampaignTemplateFactory> WithSMSTemplate<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerCampaignTemplateConfigurationFactory> combinedResult, Action<Humidifier.Pinpoint.CampaignTypes.Template> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSMSTemplate(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerCampaignTemplateConfigurationFactory, T1, T2, T3, T4, InnerCampaignTemplateFactory> WithSMSTemplate<T1, T2, T3, T4>(this CombinedResult<InnerCampaignTemplateConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Pinpoint.CampaignTypes.Template> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSMSTemplate(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCampaignTemplateConfigurationFactory, T2, T3, T4, InnerCampaignTemplateFactory> WithSMSTemplate<T1, T2, T3, T4>(this CombinedResult<T1, InnerCampaignTemplateConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Pinpoint.CampaignTypes.Template> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSMSTemplate(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerCampaignTemplateConfigurationFactory, T3, T4, InnerCampaignTemplateFactory> WithSMSTemplate<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerCampaignTemplateConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.Pinpoint.CampaignTypes.Template> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSMSTemplate(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerCampaignTemplateConfigurationFactory, T4, InnerCampaignTemplateFactory> WithSMSTemplate<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerCampaignTemplateConfigurationFactory, T4> combinedResult, Action<Humidifier.Pinpoint.CampaignTypes.Template> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSMSTemplate(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerCampaignTemplateConfigurationFactory, InnerCampaignTemplateFactory> WithSMSTemplate<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerCampaignTemplateConfigurationFactory> combinedResult, Action<Humidifier.Pinpoint.CampaignTypes.Template> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSMSTemplate(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerCampaignTemplateConfigurationFactory, T1, InnerCampaignTemplateFactory> WithEmailTemplate<T1>(this CombinedResult<InnerCampaignTemplateConfigurationFactory, T1> combinedResult, Action<Humidifier.Pinpoint.CampaignTypes.Template> subFactoryAction = null) => new (combinedResult, combinedResult, WithEmailTemplate(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCampaignTemplateConfigurationFactory, InnerCampaignTemplateFactory> WithEmailTemplate<T1>(this CombinedResult<T1, InnerCampaignTemplateConfigurationFactory> combinedResult, Action<Humidifier.Pinpoint.CampaignTypes.Template> subFactoryAction = null) => new (combinedResult, combinedResult, WithEmailTemplate(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerCampaignTemplateConfigurationFactory, T1, T2, InnerCampaignTemplateFactory> WithEmailTemplate<T1, T2>(this CombinedResult<InnerCampaignTemplateConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.Pinpoint.CampaignTypes.Template> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEmailTemplate(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCampaignTemplateConfigurationFactory, T2, InnerCampaignTemplateFactory> WithEmailTemplate<T1, T2>(this CombinedResult<T1, InnerCampaignTemplateConfigurationFactory, T2> combinedResult, Action<Humidifier.Pinpoint.CampaignTypes.Template> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEmailTemplate(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerCampaignTemplateConfigurationFactory, InnerCampaignTemplateFactory> WithEmailTemplate<T1, T2>(this CombinedResult<T1, T2, InnerCampaignTemplateConfigurationFactory> combinedResult, Action<Humidifier.Pinpoint.CampaignTypes.Template> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEmailTemplate(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerCampaignTemplateConfigurationFactory, T1, T2, T3, InnerCampaignTemplateFactory> WithEmailTemplate<T1, T2, T3>(this CombinedResult<InnerCampaignTemplateConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Pinpoint.CampaignTypes.Template> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEmailTemplate(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCampaignTemplateConfigurationFactory, T2, T3, InnerCampaignTemplateFactory> WithEmailTemplate<T1, T2, T3>(this CombinedResult<T1, InnerCampaignTemplateConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.Pinpoint.CampaignTypes.Template> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEmailTemplate(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerCampaignTemplateConfigurationFactory, T3, InnerCampaignTemplateFactory> WithEmailTemplate<T1, T2, T3>(this CombinedResult<T1, T2, InnerCampaignTemplateConfigurationFactory, T3> combinedResult, Action<Humidifier.Pinpoint.CampaignTypes.Template> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEmailTemplate(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerCampaignTemplateConfigurationFactory, InnerCampaignTemplateFactory> WithEmailTemplate<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerCampaignTemplateConfigurationFactory> combinedResult, Action<Humidifier.Pinpoint.CampaignTypes.Template> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEmailTemplate(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerCampaignTemplateConfigurationFactory, T1, T2, T3, T4, InnerCampaignTemplateFactory> WithEmailTemplate<T1, T2, T3, T4>(this CombinedResult<InnerCampaignTemplateConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Pinpoint.CampaignTypes.Template> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEmailTemplate(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCampaignTemplateConfigurationFactory, T2, T3, T4, InnerCampaignTemplateFactory> WithEmailTemplate<T1, T2, T3, T4>(this CombinedResult<T1, InnerCampaignTemplateConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Pinpoint.CampaignTypes.Template> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEmailTemplate(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerCampaignTemplateConfigurationFactory, T3, T4, InnerCampaignTemplateFactory> WithEmailTemplate<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerCampaignTemplateConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.Pinpoint.CampaignTypes.Template> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEmailTemplate(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerCampaignTemplateConfigurationFactory, T4, InnerCampaignTemplateFactory> WithEmailTemplate<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerCampaignTemplateConfigurationFactory, T4> combinedResult, Action<Humidifier.Pinpoint.CampaignTypes.Template> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEmailTemplate(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerCampaignTemplateConfigurationFactory, InnerCampaignTemplateFactory> WithEmailTemplate<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerCampaignTemplateConfigurationFactory> combinedResult, Action<Humidifier.Pinpoint.CampaignTypes.Template> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEmailTemplate(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerCampaignTemplateConfigurationFactory, T1, InnerCampaignTemplateFactory> WithPushTemplate<T1>(this CombinedResult<InnerCampaignTemplateConfigurationFactory, T1> combinedResult, Action<Humidifier.Pinpoint.CampaignTypes.Template> subFactoryAction = null) => new (combinedResult, combinedResult, WithPushTemplate(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCampaignTemplateConfigurationFactory, InnerCampaignTemplateFactory> WithPushTemplate<T1>(this CombinedResult<T1, InnerCampaignTemplateConfigurationFactory> combinedResult, Action<Humidifier.Pinpoint.CampaignTypes.Template> subFactoryAction = null) => new (combinedResult, combinedResult, WithPushTemplate(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerCampaignTemplateConfigurationFactory, T1, T2, InnerCampaignTemplateFactory> WithPushTemplate<T1, T2>(this CombinedResult<InnerCampaignTemplateConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.Pinpoint.CampaignTypes.Template> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPushTemplate(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCampaignTemplateConfigurationFactory, T2, InnerCampaignTemplateFactory> WithPushTemplate<T1, T2>(this CombinedResult<T1, InnerCampaignTemplateConfigurationFactory, T2> combinedResult, Action<Humidifier.Pinpoint.CampaignTypes.Template> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPushTemplate(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerCampaignTemplateConfigurationFactory, InnerCampaignTemplateFactory> WithPushTemplate<T1, T2>(this CombinedResult<T1, T2, InnerCampaignTemplateConfigurationFactory> combinedResult, Action<Humidifier.Pinpoint.CampaignTypes.Template> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPushTemplate(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerCampaignTemplateConfigurationFactory, T1, T2, T3, InnerCampaignTemplateFactory> WithPushTemplate<T1, T2, T3>(this CombinedResult<InnerCampaignTemplateConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Pinpoint.CampaignTypes.Template> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPushTemplate(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCampaignTemplateConfigurationFactory, T2, T3, InnerCampaignTemplateFactory> WithPushTemplate<T1, T2, T3>(this CombinedResult<T1, InnerCampaignTemplateConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.Pinpoint.CampaignTypes.Template> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPushTemplate(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerCampaignTemplateConfigurationFactory, T3, InnerCampaignTemplateFactory> WithPushTemplate<T1, T2, T3>(this CombinedResult<T1, T2, InnerCampaignTemplateConfigurationFactory, T3> combinedResult, Action<Humidifier.Pinpoint.CampaignTypes.Template> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPushTemplate(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerCampaignTemplateConfigurationFactory, InnerCampaignTemplateFactory> WithPushTemplate<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerCampaignTemplateConfigurationFactory> combinedResult, Action<Humidifier.Pinpoint.CampaignTypes.Template> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPushTemplate(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerCampaignTemplateConfigurationFactory, T1, T2, T3, T4, InnerCampaignTemplateFactory> WithPushTemplate<T1, T2, T3, T4>(this CombinedResult<InnerCampaignTemplateConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Pinpoint.CampaignTypes.Template> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPushTemplate(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCampaignTemplateConfigurationFactory, T2, T3, T4, InnerCampaignTemplateFactory> WithPushTemplate<T1, T2, T3, T4>(this CombinedResult<T1, InnerCampaignTemplateConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Pinpoint.CampaignTypes.Template> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPushTemplate(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerCampaignTemplateConfigurationFactory, T3, T4, InnerCampaignTemplateFactory> WithPushTemplate<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerCampaignTemplateConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.Pinpoint.CampaignTypes.Template> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPushTemplate(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerCampaignTemplateConfigurationFactory, T4, InnerCampaignTemplateFactory> WithPushTemplate<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerCampaignTemplateConfigurationFactory, T4> combinedResult, Action<Humidifier.Pinpoint.CampaignTypes.Template> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPushTemplate(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerCampaignTemplateConfigurationFactory, InnerCampaignTemplateFactory> WithPushTemplate<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerCampaignTemplateConfigurationFactory> combinedResult, Action<Humidifier.Pinpoint.CampaignTypes.Template> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPushTemplate(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerCampaignTemplateConfigurationFactory, T1, InnerCampaignTemplateFactory> WithVoiceTemplate<T1>(this CombinedResult<InnerCampaignTemplateConfigurationFactory, T1> combinedResult, Action<Humidifier.Pinpoint.CampaignTypes.Template> subFactoryAction = null) => new (combinedResult, combinedResult, WithVoiceTemplate(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCampaignTemplateConfigurationFactory, InnerCampaignTemplateFactory> WithVoiceTemplate<T1>(this CombinedResult<T1, InnerCampaignTemplateConfigurationFactory> combinedResult, Action<Humidifier.Pinpoint.CampaignTypes.Template> subFactoryAction = null) => new (combinedResult, combinedResult, WithVoiceTemplate(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerCampaignTemplateConfigurationFactory, T1, T2, InnerCampaignTemplateFactory> WithVoiceTemplate<T1, T2>(this CombinedResult<InnerCampaignTemplateConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.Pinpoint.CampaignTypes.Template> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVoiceTemplate(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCampaignTemplateConfigurationFactory, T2, InnerCampaignTemplateFactory> WithVoiceTemplate<T1, T2>(this CombinedResult<T1, InnerCampaignTemplateConfigurationFactory, T2> combinedResult, Action<Humidifier.Pinpoint.CampaignTypes.Template> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVoiceTemplate(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerCampaignTemplateConfigurationFactory, InnerCampaignTemplateFactory> WithVoiceTemplate<T1, T2>(this CombinedResult<T1, T2, InnerCampaignTemplateConfigurationFactory> combinedResult, Action<Humidifier.Pinpoint.CampaignTypes.Template> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVoiceTemplate(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerCampaignTemplateConfigurationFactory, T1, T2, T3, InnerCampaignTemplateFactory> WithVoiceTemplate<T1, T2, T3>(this CombinedResult<InnerCampaignTemplateConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Pinpoint.CampaignTypes.Template> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVoiceTemplate(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCampaignTemplateConfigurationFactory, T2, T3, InnerCampaignTemplateFactory> WithVoiceTemplate<T1, T2, T3>(this CombinedResult<T1, InnerCampaignTemplateConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.Pinpoint.CampaignTypes.Template> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVoiceTemplate(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerCampaignTemplateConfigurationFactory, T3, InnerCampaignTemplateFactory> WithVoiceTemplate<T1, T2, T3>(this CombinedResult<T1, T2, InnerCampaignTemplateConfigurationFactory, T3> combinedResult, Action<Humidifier.Pinpoint.CampaignTypes.Template> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVoiceTemplate(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerCampaignTemplateConfigurationFactory, InnerCampaignTemplateFactory> WithVoiceTemplate<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerCampaignTemplateConfigurationFactory> combinedResult, Action<Humidifier.Pinpoint.CampaignTypes.Template> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVoiceTemplate(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerCampaignTemplateConfigurationFactory, T1, T2, T3, T4, InnerCampaignTemplateFactory> WithVoiceTemplate<T1, T2, T3, T4>(this CombinedResult<InnerCampaignTemplateConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Pinpoint.CampaignTypes.Template> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVoiceTemplate(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCampaignTemplateConfigurationFactory, T2, T3, T4, InnerCampaignTemplateFactory> WithVoiceTemplate<T1, T2, T3, T4>(this CombinedResult<T1, InnerCampaignTemplateConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Pinpoint.CampaignTypes.Template> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVoiceTemplate(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerCampaignTemplateConfigurationFactory, T3, T4, InnerCampaignTemplateFactory> WithVoiceTemplate<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerCampaignTemplateConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.Pinpoint.CampaignTypes.Template> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVoiceTemplate(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerCampaignTemplateConfigurationFactory, T4, InnerCampaignTemplateFactory> WithVoiceTemplate<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerCampaignTemplateConfigurationFactory, T4> combinedResult, Action<Humidifier.Pinpoint.CampaignTypes.Template> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVoiceTemplate(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerCampaignTemplateConfigurationFactory, InnerCampaignTemplateFactory> WithVoiceTemplate<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerCampaignTemplateConfigurationFactory> combinedResult, Action<Humidifier.Pinpoint.CampaignTypes.Template> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVoiceTemplate(combinedResult.T5, subFactoryAction));
}
