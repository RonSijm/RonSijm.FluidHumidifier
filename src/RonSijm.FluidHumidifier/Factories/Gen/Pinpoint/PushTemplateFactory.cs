// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Pinpoint;

public class PushTemplateFactory(string resourceName = null, Action<Humidifier.Pinpoint.PushTemplate> factoryAction = null) : ResourceFactory<Humidifier.Pinpoint.PushTemplate>(resourceName)
{

    internal InnerPushTemplateAndroidPushNotificationTemplateFactory GCMFactory { get; set; }

    internal InnerPushTemplateAndroidPushNotificationTemplateFactory BaiduFactory { get; set; }

    internal InnerPushTemplateAndroidPushNotificationTemplateFactory ADMFactory { get; set; }

    internal InnerPushTemplateAPNSPushNotificationTemplateFactory APNSFactory { get; set; }

    internal InnerPushTemplateDefaultPushNotificationTemplateFactory DefaultFactory { get; set; }

    protected override Humidifier.Pinpoint.PushTemplate Create()
    {
        var pushTemplateResult = CreatePushTemplate();
        factoryAction?.Invoke(pushTemplateResult);

        return pushTemplateResult;
    }

    private Humidifier.Pinpoint.PushTemplate CreatePushTemplate()
    {
        var pushTemplateResult = new Humidifier.Pinpoint.PushTemplate
        {
            GivenName = InputResourceName,
        };

        return pushTemplateResult;
    }
    public override void CreateChildren(Humidifier.Pinpoint.PushTemplate result)
    {
        base.CreateChildren(result);

        result.GCM ??= GCMFactory?.Build();
        result.Baidu ??= BaiduFactory?.Build();
        result.ADM ??= ADMFactory?.Build();
        result.APNS ??= APNSFactory?.Build();
        result.Default ??= DefaultFactory?.Build();
    }

} // End Of Class

public static class PushTemplateFactoryExtensions
{
    public static CombinedResult<PushTemplateFactory, InnerPushTemplateAndroidPushNotificationTemplateFactory> WithGCM(this PushTemplateFactory parentFactory, Action<Humidifier.Pinpoint.PushTemplateTypes.AndroidPushNotificationTemplate> subFactoryAction = null)
    {
        parentFactory.GCMFactory = new InnerPushTemplateAndroidPushNotificationTemplateFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.GCMFactory);
    }

    public static CombinedResult<PushTemplateFactory, InnerPushTemplateAndroidPushNotificationTemplateFactory> WithBaidu(this PushTemplateFactory parentFactory, Action<Humidifier.Pinpoint.PushTemplateTypes.AndroidPushNotificationTemplate> subFactoryAction = null)
    {
        parentFactory.BaiduFactory = new InnerPushTemplateAndroidPushNotificationTemplateFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.BaiduFactory);
    }

    public static CombinedResult<PushTemplateFactory, InnerPushTemplateAndroidPushNotificationTemplateFactory> WithADM(this PushTemplateFactory parentFactory, Action<Humidifier.Pinpoint.PushTemplateTypes.AndroidPushNotificationTemplate> subFactoryAction = null)
    {
        parentFactory.ADMFactory = new InnerPushTemplateAndroidPushNotificationTemplateFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ADMFactory);
    }

    public static CombinedResult<PushTemplateFactory, InnerPushTemplateAPNSPushNotificationTemplateFactory> WithAPNS(this PushTemplateFactory parentFactory, Action<Humidifier.Pinpoint.PushTemplateTypes.APNSPushNotificationTemplate> subFactoryAction = null)
    {
        parentFactory.APNSFactory = new InnerPushTemplateAPNSPushNotificationTemplateFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.APNSFactory);
    }

    public static CombinedResult<PushTemplateFactory, InnerPushTemplateDefaultPushNotificationTemplateFactory> WithDefault(this PushTemplateFactory parentFactory, Action<Humidifier.Pinpoint.PushTemplateTypes.DefaultPushNotificationTemplate> subFactoryAction = null)
    {
        parentFactory.DefaultFactory = new InnerPushTemplateDefaultPushNotificationTemplateFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DefaultFactory);
    }

    public static CombinedResult<PushTemplateFactory, T1, InnerPushTemplateAndroidPushNotificationTemplateFactory> WithGCM<T1>(this CombinedResult<PushTemplateFactory, T1> combinedResult, Action<Humidifier.Pinpoint.PushTemplateTypes.AndroidPushNotificationTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, WithGCM(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PushTemplateFactory, InnerPushTemplateAndroidPushNotificationTemplateFactory> WithGCM<T1>(this CombinedResult<T1, PushTemplateFactory> combinedResult, Action<Humidifier.Pinpoint.PushTemplateTypes.AndroidPushNotificationTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, WithGCM(combinedResult.T2, subFactoryAction));
    public static CombinedResult<PushTemplateFactory, T1, T2, InnerPushTemplateAndroidPushNotificationTemplateFactory> WithGCM<T1, T2>(this CombinedResult<PushTemplateFactory, T1, T2> combinedResult, Action<Humidifier.Pinpoint.PushTemplateTypes.AndroidPushNotificationTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGCM(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PushTemplateFactory, T2, InnerPushTemplateAndroidPushNotificationTemplateFactory> WithGCM<T1, T2>(this CombinedResult<T1, PushTemplateFactory, T2> combinedResult, Action<Humidifier.Pinpoint.PushTemplateTypes.AndroidPushNotificationTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGCM(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PushTemplateFactory, InnerPushTemplateAndroidPushNotificationTemplateFactory> WithGCM<T1, T2>(this CombinedResult<T1, T2, PushTemplateFactory> combinedResult, Action<Humidifier.Pinpoint.PushTemplateTypes.AndroidPushNotificationTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGCM(combinedResult.T3, subFactoryAction));
    public static CombinedResult<PushTemplateFactory, T1, T2, T3, InnerPushTemplateAndroidPushNotificationTemplateFactory> WithGCM<T1, T2, T3>(this CombinedResult<PushTemplateFactory, T1, T2, T3> combinedResult, Action<Humidifier.Pinpoint.PushTemplateTypes.AndroidPushNotificationTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGCM(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PushTemplateFactory, T2, T3, InnerPushTemplateAndroidPushNotificationTemplateFactory> WithGCM<T1, T2, T3>(this CombinedResult<T1, PushTemplateFactory, T2, T3> combinedResult, Action<Humidifier.Pinpoint.PushTemplateTypes.AndroidPushNotificationTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGCM(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PushTemplateFactory, T3, InnerPushTemplateAndroidPushNotificationTemplateFactory> WithGCM<T1, T2, T3>(this CombinedResult<T1, T2, PushTemplateFactory, T3> combinedResult, Action<Humidifier.Pinpoint.PushTemplateTypes.AndroidPushNotificationTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGCM(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, PushTemplateFactory, InnerPushTemplateAndroidPushNotificationTemplateFactory> WithGCM<T1, T2, T3>(this CombinedResult<T1, T2, T3, PushTemplateFactory> combinedResult, Action<Humidifier.Pinpoint.PushTemplateTypes.AndroidPushNotificationTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGCM(combinedResult.T4, subFactoryAction));
    public static CombinedResult<PushTemplateFactory, T1, T2, T3, T4, InnerPushTemplateAndroidPushNotificationTemplateFactory> WithGCM<T1, T2, T3, T4>(this CombinedResult<PushTemplateFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Pinpoint.PushTemplateTypes.AndroidPushNotificationTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGCM(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PushTemplateFactory, T2, T3, T4, InnerPushTemplateAndroidPushNotificationTemplateFactory> WithGCM<T1, T2, T3, T4>(this CombinedResult<T1, PushTemplateFactory, T2, T3, T4> combinedResult, Action<Humidifier.Pinpoint.PushTemplateTypes.AndroidPushNotificationTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGCM(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PushTemplateFactory, T3, T4, InnerPushTemplateAndroidPushNotificationTemplateFactory> WithGCM<T1, T2, T3, T4>(this CombinedResult<T1, T2, PushTemplateFactory, T3, T4> combinedResult, Action<Humidifier.Pinpoint.PushTemplateTypes.AndroidPushNotificationTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGCM(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, PushTemplateFactory, T4, InnerPushTemplateAndroidPushNotificationTemplateFactory> WithGCM<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, PushTemplateFactory, T4> combinedResult, Action<Humidifier.Pinpoint.PushTemplateTypes.AndroidPushNotificationTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGCM(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, PushTemplateFactory, InnerPushTemplateAndroidPushNotificationTemplateFactory> WithGCM<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, PushTemplateFactory> combinedResult, Action<Humidifier.Pinpoint.PushTemplateTypes.AndroidPushNotificationTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGCM(combinedResult.T5, subFactoryAction));
    public static CombinedResult<PushTemplateFactory, T1, InnerPushTemplateAndroidPushNotificationTemplateFactory> WithBaidu<T1>(this CombinedResult<PushTemplateFactory, T1> combinedResult, Action<Humidifier.Pinpoint.PushTemplateTypes.AndroidPushNotificationTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, WithBaidu(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PushTemplateFactory, InnerPushTemplateAndroidPushNotificationTemplateFactory> WithBaidu<T1>(this CombinedResult<T1, PushTemplateFactory> combinedResult, Action<Humidifier.Pinpoint.PushTemplateTypes.AndroidPushNotificationTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, WithBaidu(combinedResult.T2, subFactoryAction));
    public static CombinedResult<PushTemplateFactory, T1, T2, InnerPushTemplateAndroidPushNotificationTemplateFactory> WithBaidu<T1, T2>(this CombinedResult<PushTemplateFactory, T1, T2> combinedResult, Action<Humidifier.Pinpoint.PushTemplateTypes.AndroidPushNotificationTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBaidu(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PushTemplateFactory, T2, InnerPushTemplateAndroidPushNotificationTemplateFactory> WithBaidu<T1, T2>(this CombinedResult<T1, PushTemplateFactory, T2> combinedResult, Action<Humidifier.Pinpoint.PushTemplateTypes.AndroidPushNotificationTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBaidu(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PushTemplateFactory, InnerPushTemplateAndroidPushNotificationTemplateFactory> WithBaidu<T1, T2>(this CombinedResult<T1, T2, PushTemplateFactory> combinedResult, Action<Humidifier.Pinpoint.PushTemplateTypes.AndroidPushNotificationTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBaidu(combinedResult.T3, subFactoryAction));
    public static CombinedResult<PushTemplateFactory, T1, T2, T3, InnerPushTemplateAndroidPushNotificationTemplateFactory> WithBaidu<T1, T2, T3>(this CombinedResult<PushTemplateFactory, T1, T2, T3> combinedResult, Action<Humidifier.Pinpoint.PushTemplateTypes.AndroidPushNotificationTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBaidu(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PushTemplateFactory, T2, T3, InnerPushTemplateAndroidPushNotificationTemplateFactory> WithBaidu<T1, T2, T3>(this CombinedResult<T1, PushTemplateFactory, T2, T3> combinedResult, Action<Humidifier.Pinpoint.PushTemplateTypes.AndroidPushNotificationTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBaidu(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PushTemplateFactory, T3, InnerPushTemplateAndroidPushNotificationTemplateFactory> WithBaidu<T1, T2, T3>(this CombinedResult<T1, T2, PushTemplateFactory, T3> combinedResult, Action<Humidifier.Pinpoint.PushTemplateTypes.AndroidPushNotificationTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBaidu(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, PushTemplateFactory, InnerPushTemplateAndroidPushNotificationTemplateFactory> WithBaidu<T1, T2, T3>(this CombinedResult<T1, T2, T3, PushTemplateFactory> combinedResult, Action<Humidifier.Pinpoint.PushTemplateTypes.AndroidPushNotificationTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBaidu(combinedResult.T4, subFactoryAction));
    public static CombinedResult<PushTemplateFactory, T1, T2, T3, T4, InnerPushTemplateAndroidPushNotificationTemplateFactory> WithBaidu<T1, T2, T3, T4>(this CombinedResult<PushTemplateFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Pinpoint.PushTemplateTypes.AndroidPushNotificationTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBaidu(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PushTemplateFactory, T2, T3, T4, InnerPushTemplateAndroidPushNotificationTemplateFactory> WithBaidu<T1, T2, T3, T4>(this CombinedResult<T1, PushTemplateFactory, T2, T3, T4> combinedResult, Action<Humidifier.Pinpoint.PushTemplateTypes.AndroidPushNotificationTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBaidu(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PushTemplateFactory, T3, T4, InnerPushTemplateAndroidPushNotificationTemplateFactory> WithBaidu<T1, T2, T3, T4>(this CombinedResult<T1, T2, PushTemplateFactory, T3, T4> combinedResult, Action<Humidifier.Pinpoint.PushTemplateTypes.AndroidPushNotificationTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBaidu(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, PushTemplateFactory, T4, InnerPushTemplateAndroidPushNotificationTemplateFactory> WithBaidu<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, PushTemplateFactory, T4> combinedResult, Action<Humidifier.Pinpoint.PushTemplateTypes.AndroidPushNotificationTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBaidu(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, PushTemplateFactory, InnerPushTemplateAndroidPushNotificationTemplateFactory> WithBaidu<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, PushTemplateFactory> combinedResult, Action<Humidifier.Pinpoint.PushTemplateTypes.AndroidPushNotificationTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBaidu(combinedResult.T5, subFactoryAction));
    public static CombinedResult<PushTemplateFactory, T1, InnerPushTemplateAndroidPushNotificationTemplateFactory> WithADM<T1>(this CombinedResult<PushTemplateFactory, T1> combinedResult, Action<Humidifier.Pinpoint.PushTemplateTypes.AndroidPushNotificationTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, WithADM(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PushTemplateFactory, InnerPushTemplateAndroidPushNotificationTemplateFactory> WithADM<T1>(this CombinedResult<T1, PushTemplateFactory> combinedResult, Action<Humidifier.Pinpoint.PushTemplateTypes.AndroidPushNotificationTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, WithADM(combinedResult.T2, subFactoryAction));
    public static CombinedResult<PushTemplateFactory, T1, T2, InnerPushTemplateAndroidPushNotificationTemplateFactory> WithADM<T1, T2>(this CombinedResult<PushTemplateFactory, T1, T2> combinedResult, Action<Humidifier.Pinpoint.PushTemplateTypes.AndroidPushNotificationTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithADM(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PushTemplateFactory, T2, InnerPushTemplateAndroidPushNotificationTemplateFactory> WithADM<T1, T2>(this CombinedResult<T1, PushTemplateFactory, T2> combinedResult, Action<Humidifier.Pinpoint.PushTemplateTypes.AndroidPushNotificationTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithADM(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PushTemplateFactory, InnerPushTemplateAndroidPushNotificationTemplateFactory> WithADM<T1, T2>(this CombinedResult<T1, T2, PushTemplateFactory> combinedResult, Action<Humidifier.Pinpoint.PushTemplateTypes.AndroidPushNotificationTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithADM(combinedResult.T3, subFactoryAction));
    public static CombinedResult<PushTemplateFactory, T1, T2, T3, InnerPushTemplateAndroidPushNotificationTemplateFactory> WithADM<T1, T2, T3>(this CombinedResult<PushTemplateFactory, T1, T2, T3> combinedResult, Action<Humidifier.Pinpoint.PushTemplateTypes.AndroidPushNotificationTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithADM(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PushTemplateFactory, T2, T3, InnerPushTemplateAndroidPushNotificationTemplateFactory> WithADM<T1, T2, T3>(this CombinedResult<T1, PushTemplateFactory, T2, T3> combinedResult, Action<Humidifier.Pinpoint.PushTemplateTypes.AndroidPushNotificationTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithADM(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PushTemplateFactory, T3, InnerPushTemplateAndroidPushNotificationTemplateFactory> WithADM<T1, T2, T3>(this CombinedResult<T1, T2, PushTemplateFactory, T3> combinedResult, Action<Humidifier.Pinpoint.PushTemplateTypes.AndroidPushNotificationTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithADM(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, PushTemplateFactory, InnerPushTemplateAndroidPushNotificationTemplateFactory> WithADM<T1, T2, T3>(this CombinedResult<T1, T2, T3, PushTemplateFactory> combinedResult, Action<Humidifier.Pinpoint.PushTemplateTypes.AndroidPushNotificationTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithADM(combinedResult.T4, subFactoryAction));
    public static CombinedResult<PushTemplateFactory, T1, T2, T3, T4, InnerPushTemplateAndroidPushNotificationTemplateFactory> WithADM<T1, T2, T3, T4>(this CombinedResult<PushTemplateFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Pinpoint.PushTemplateTypes.AndroidPushNotificationTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithADM(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PushTemplateFactory, T2, T3, T4, InnerPushTemplateAndroidPushNotificationTemplateFactory> WithADM<T1, T2, T3, T4>(this CombinedResult<T1, PushTemplateFactory, T2, T3, T4> combinedResult, Action<Humidifier.Pinpoint.PushTemplateTypes.AndroidPushNotificationTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithADM(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PushTemplateFactory, T3, T4, InnerPushTemplateAndroidPushNotificationTemplateFactory> WithADM<T1, T2, T3, T4>(this CombinedResult<T1, T2, PushTemplateFactory, T3, T4> combinedResult, Action<Humidifier.Pinpoint.PushTemplateTypes.AndroidPushNotificationTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithADM(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, PushTemplateFactory, T4, InnerPushTemplateAndroidPushNotificationTemplateFactory> WithADM<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, PushTemplateFactory, T4> combinedResult, Action<Humidifier.Pinpoint.PushTemplateTypes.AndroidPushNotificationTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithADM(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, PushTemplateFactory, InnerPushTemplateAndroidPushNotificationTemplateFactory> WithADM<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, PushTemplateFactory> combinedResult, Action<Humidifier.Pinpoint.PushTemplateTypes.AndroidPushNotificationTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithADM(combinedResult.T5, subFactoryAction));
    public static CombinedResult<PushTemplateFactory, T1, InnerPushTemplateAPNSPushNotificationTemplateFactory> WithAPNS<T1>(this CombinedResult<PushTemplateFactory, T1> combinedResult, Action<Humidifier.Pinpoint.PushTemplateTypes.APNSPushNotificationTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, WithAPNS(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PushTemplateFactory, InnerPushTemplateAPNSPushNotificationTemplateFactory> WithAPNS<T1>(this CombinedResult<T1, PushTemplateFactory> combinedResult, Action<Humidifier.Pinpoint.PushTemplateTypes.APNSPushNotificationTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, WithAPNS(combinedResult.T2, subFactoryAction));
    public static CombinedResult<PushTemplateFactory, T1, T2, InnerPushTemplateAPNSPushNotificationTemplateFactory> WithAPNS<T1, T2>(this CombinedResult<PushTemplateFactory, T1, T2> combinedResult, Action<Humidifier.Pinpoint.PushTemplateTypes.APNSPushNotificationTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAPNS(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PushTemplateFactory, T2, InnerPushTemplateAPNSPushNotificationTemplateFactory> WithAPNS<T1, T2>(this CombinedResult<T1, PushTemplateFactory, T2> combinedResult, Action<Humidifier.Pinpoint.PushTemplateTypes.APNSPushNotificationTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAPNS(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PushTemplateFactory, InnerPushTemplateAPNSPushNotificationTemplateFactory> WithAPNS<T1, T2>(this CombinedResult<T1, T2, PushTemplateFactory> combinedResult, Action<Humidifier.Pinpoint.PushTemplateTypes.APNSPushNotificationTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAPNS(combinedResult.T3, subFactoryAction));
    public static CombinedResult<PushTemplateFactory, T1, T2, T3, InnerPushTemplateAPNSPushNotificationTemplateFactory> WithAPNS<T1, T2, T3>(this CombinedResult<PushTemplateFactory, T1, T2, T3> combinedResult, Action<Humidifier.Pinpoint.PushTemplateTypes.APNSPushNotificationTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAPNS(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PushTemplateFactory, T2, T3, InnerPushTemplateAPNSPushNotificationTemplateFactory> WithAPNS<T1, T2, T3>(this CombinedResult<T1, PushTemplateFactory, T2, T3> combinedResult, Action<Humidifier.Pinpoint.PushTemplateTypes.APNSPushNotificationTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAPNS(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PushTemplateFactory, T3, InnerPushTemplateAPNSPushNotificationTemplateFactory> WithAPNS<T1, T2, T3>(this CombinedResult<T1, T2, PushTemplateFactory, T3> combinedResult, Action<Humidifier.Pinpoint.PushTemplateTypes.APNSPushNotificationTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAPNS(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, PushTemplateFactory, InnerPushTemplateAPNSPushNotificationTemplateFactory> WithAPNS<T1, T2, T3>(this CombinedResult<T1, T2, T3, PushTemplateFactory> combinedResult, Action<Humidifier.Pinpoint.PushTemplateTypes.APNSPushNotificationTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAPNS(combinedResult.T4, subFactoryAction));
    public static CombinedResult<PushTemplateFactory, T1, T2, T3, T4, InnerPushTemplateAPNSPushNotificationTemplateFactory> WithAPNS<T1, T2, T3, T4>(this CombinedResult<PushTemplateFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Pinpoint.PushTemplateTypes.APNSPushNotificationTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAPNS(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PushTemplateFactory, T2, T3, T4, InnerPushTemplateAPNSPushNotificationTemplateFactory> WithAPNS<T1, T2, T3, T4>(this CombinedResult<T1, PushTemplateFactory, T2, T3, T4> combinedResult, Action<Humidifier.Pinpoint.PushTemplateTypes.APNSPushNotificationTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAPNS(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PushTemplateFactory, T3, T4, InnerPushTemplateAPNSPushNotificationTemplateFactory> WithAPNS<T1, T2, T3, T4>(this CombinedResult<T1, T2, PushTemplateFactory, T3, T4> combinedResult, Action<Humidifier.Pinpoint.PushTemplateTypes.APNSPushNotificationTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAPNS(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, PushTemplateFactory, T4, InnerPushTemplateAPNSPushNotificationTemplateFactory> WithAPNS<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, PushTemplateFactory, T4> combinedResult, Action<Humidifier.Pinpoint.PushTemplateTypes.APNSPushNotificationTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAPNS(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, PushTemplateFactory, InnerPushTemplateAPNSPushNotificationTemplateFactory> WithAPNS<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, PushTemplateFactory> combinedResult, Action<Humidifier.Pinpoint.PushTemplateTypes.APNSPushNotificationTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAPNS(combinedResult.T5, subFactoryAction));
    public static CombinedResult<PushTemplateFactory, T1, InnerPushTemplateDefaultPushNotificationTemplateFactory> WithDefault<T1>(this CombinedResult<PushTemplateFactory, T1> combinedResult, Action<Humidifier.Pinpoint.PushTemplateTypes.DefaultPushNotificationTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, WithDefault(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PushTemplateFactory, InnerPushTemplateDefaultPushNotificationTemplateFactory> WithDefault<T1>(this CombinedResult<T1, PushTemplateFactory> combinedResult, Action<Humidifier.Pinpoint.PushTemplateTypes.DefaultPushNotificationTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, WithDefault(combinedResult.T2, subFactoryAction));
    public static CombinedResult<PushTemplateFactory, T1, T2, InnerPushTemplateDefaultPushNotificationTemplateFactory> WithDefault<T1, T2>(this CombinedResult<PushTemplateFactory, T1, T2> combinedResult, Action<Humidifier.Pinpoint.PushTemplateTypes.DefaultPushNotificationTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefault(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PushTemplateFactory, T2, InnerPushTemplateDefaultPushNotificationTemplateFactory> WithDefault<T1, T2>(this CombinedResult<T1, PushTemplateFactory, T2> combinedResult, Action<Humidifier.Pinpoint.PushTemplateTypes.DefaultPushNotificationTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefault(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PushTemplateFactory, InnerPushTemplateDefaultPushNotificationTemplateFactory> WithDefault<T1, T2>(this CombinedResult<T1, T2, PushTemplateFactory> combinedResult, Action<Humidifier.Pinpoint.PushTemplateTypes.DefaultPushNotificationTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefault(combinedResult.T3, subFactoryAction));
    public static CombinedResult<PushTemplateFactory, T1, T2, T3, InnerPushTemplateDefaultPushNotificationTemplateFactory> WithDefault<T1, T2, T3>(this CombinedResult<PushTemplateFactory, T1, T2, T3> combinedResult, Action<Humidifier.Pinpoint.PushTemplateTypes.DefaultPushNotificationTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefault(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PushTemplateFactory, T2, T3, InnerPushTemplateDefaultPushNotificationTemplateFactory> WithDefault<T1, T2, T3>(this CombinedResult<T1, PushTemplateFactory, T2, T3> combinedResult, Action<Humidifier.Pinpoint.PushTemplateTypes.DefaultPushNotificationTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefault(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PushTemplateFactory, T3, InnerPushTemplateDefaultPushNotificationTemplateFactory> WithDefault<T1, T2, T3>(this CombinedResult<T1, T2, PushTemplateFactory, T3> combinedResult, Action<Humidifier.Pinpoint.PushTemplateTypes.DefaultPushNotificationTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefault(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, PushTemplateFactory, InnerPushTemplateDefaultPushNotificationTemplateFactory> WithDefault<T1, T2, T3>(this CombinedResult<T1, T2, T3, PushTemplateFactory> combinedResult, Action<Humidifier.Pinpoint.PushTemplateTypes.DefaultPushNotificationTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefault(combinedResult.T4, subFactoryAction));
    public static CombinedResult<PushTemplateFactory, T1, T2, T3, T4, InnerPushTemplateDefaultPushNotificationTemplateFactory> WithDefault<T1, T2, T3, T4>(this CombinedResult<PushTemplateFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Pinpoint.PushTemplateTypes.DefaultPushNotificationTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefault(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PushTemplateFactory, T2, T3, T4, InnerPushTemplateDefaultPushNotificationTemplateFactory> WithDefault<T1, T2, T3, T4>(this CombinedResult<T1, PushTemplateFactory, T2, T3, T4> combinedResult, Action<Humidifier.Pinpoint.PushTemplateTypes.DefaultPushNotificationTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefault(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PushTemplateFactory, T3, T4, InnerPushTemplateDefaultPushNotificationTemplateFactory> WithDefault<T1, T2, T3, T4>(this CombinedResult<T1, T2, PushTemplateFactory, T3, T4> combinedResult, Action<Humidifier.Pinpoint.PushTemplateTypes.DefaultPushNotificationTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefault(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, PushTemplateFactory, T4, InnerPushTemplateDefaultPushNotificationTemplateFactory> WithDefault<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, PushTemplateFactory, T4> combinedResult, Action<Humidifier.Pinpoint.PushTemplateTypes.DefaultPushNotificationTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefault(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, PushTemplateFactory, InnerPushTemplateDefaultPushNotificationTemplateFactory> WithDefault<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, PushTemplateFactory> combinedResult, Action<Humidifier.Pinpoint.PushTemplateTypes.DefaultPushNotificationTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefault(combinedResult.T5, subFactoryAction));
}
