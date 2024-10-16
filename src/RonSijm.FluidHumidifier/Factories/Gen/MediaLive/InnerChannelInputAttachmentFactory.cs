// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaLive;

public class InnerChannelInputAttachmentFactory(Action<Humidifier.MediaLive.ChannelTypes.InputAttachment> factoryAction = null) : SubResourceFactory<Humidifier.MediaLive.ChannelTypes.InputAttachment>
{

    internal InnerChannelAutomaticInputFailoverSettingsFactory AutomaticInputFailoverSettingsFactory { get; set; }

    internal InnerChannelInputSettingsFactory InputSettingsFactory { get; set; }

    protected override Humidifier.MediaLive.ChannelTypes.InputAttachment Create()
    {
        var inputAttachmentResult = CreateInputAttachment();
        factoryAction?.Invoke(inputAttachmentResult);

        return inputAttachmentResult;
    }

    private Humidifier.MediaLive.ChannelTypes.InputAttachment CreateInputAttachment()
    {
        var inputAttachmentResult = new Humidifier.MediaLive.ChannelTypes.InputAttachment();

        return inputAttachmentResult;
    }
    public override void CreateChildren(Humidifier.MediaLive.ChannelTypes.InputAttachment result)
    {
        base.CreateChildren(result);

        result.AutomaticInputFailoverSettings ??= AutomaticInputFailoverSettingsFactory?.Build();
        result.InputSettings ??= InputSettingsFactory?.Build();
    }

} // End Of Class

public static class InnerChannelInputAttachmentFactoryExtensions
{
    public static CombinedResult<InnerChannelInputAttachmentFactory, InnerChannelAutomaticInputFailoverSettingsFactory> WithAutomaticInputFailoverSettings(this InnerChannelInputAttachmentFactory parentFactory, Action<Humidifier.MediaLive.ChannelTypes.AutomaticInputFailoverSettings> subFactoryAction = null)
    {
        parentFactory.AutomaticInputFailoverSettingsFactory = new InnerChannelAutomaticInputFailoverSettingsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AutomaticInputFailoverSettingsFactory);
    }

    public static CombinedResult<InnerChannelInputAttachmentFactory, InnerChannelInputSettingsFactory> WithInputSettings(this InnerChannelInputAttachmentFactory parentFactory, Action<Humidifier.MediaLive.ChannelTypes.InputSettings> subFactoryAction = null)
    {
        parentFactory.InputSettingsFactory = new InnerChannelInputSettingsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.InputSettingsFactory);
    }

    public static CombinedResult<InnerChannelInputAttachmentFactory, T1, InnerChannelAutomaticInputFailoverSettingsFactory> WithAutomaticInputFailoverSettings<T1>(this CombinedResult<InnerChannelInputAttachmentFactory, T1> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.AutomaticInputFailoverSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithAutomaticInputFailoverSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerChannelInputAttachmentFactory, InnerChannelAutomaticInputFailoverSettingsFactory> WithAutomaticInputFailoverSettings<T1>(this CombinedResult<T1, InnerChannelInputAttachmentFactory> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.AutomaticInputFailoverSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithAutomaticInputFailoverSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerChannelInputAttachmentFactory, T1, T2, InnerChannelAutomaticInputFailoverSettingsFactory> WithAutomaticInputFailoverSettings<T1, T2>(this CombinedResult<InnerChannelInputAttachmentFactory, T1, T2> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.AutomaticInputFailoverSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAutomaticInputFailoverSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerChannelInputAttachmentFactory, T2, InnerChannelAutomaticInputFailoverSettingsFactory> WithAutomaticInputFailoverSettings<T1, T2>(this CombinedResult<T1, InnerChannelInputAttachmentFactory, T2> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.AutomaticInputFailoverSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAutomaticInputFailoverSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerChannelInputAttachmentFactory, InnerChannelAutomaticInputFailoverSettingsFactory> WithAutomaticInputFailoverSettings<T1, T2>(this CombinedResult<T1, T2, InnerChannelInputAttachmentFactory> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.AutomaticInputFailoverSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAutomaticInputFailoverSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerChannelInputAttachmentFactory, T1, T2, T3, InnerChannelAutomaticInputFailoverSettingsFactory> WithAutomaticInputFailoverSettings<T1, T2, T3>(this CombinedResult<InnerChannelInputAttachmentFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.AutomaticInputFailoverSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAutomaticInputFailoverSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerChannelInputAttachmentFactory, T2, T3, InnerChannelAutomaticInputFailoverSettingsFactory> WithAutomaticInputFailoverSettings<T1, T2, T3>(this CombinedResult<T1, InnerChannelInputAttachmentFactory, T2, T3> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.AutomaticInputFailoverSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAutomaticInputFailoverSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerChannelInputAttachmentFactory, T3, InnerChannelAutomaticInputFailoverSettingsFactory> WithAutomaticInputFailoverSettings<T1, T2, T3>(this CombinedResult<T1, T2, InnerChannelInputAttachmentFactory, T3> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.AutomaticInputFailoverSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAutomaticInputFailoverSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerChannelInputAttachmentFactory, InnerChannelAutomaticInputFailoverSettingsFactory> WithAutomaticInputFailoverSettings<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerChannelInputAttachmentFactory> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.AutomaticInputFailoverSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAutomaticInputFailoverSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerChannelInputAttachmentFactory, T1, T2, T3, T4, InnerChannelAutomaticInputFailoverSettingsFactory> WithAutomaticInputFailoverSettings<T1, T2, T3, T4>(this CombinedResult<InnerChannelInputAttachmentFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.AutomaticInputFailoverSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAutomaticInputFailoverSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerChannelInputAttachmentFactory, T2, T3, T4, InnerChannelAutomaticInputFailoverSettingsFactory> WithAutomaticInputFailoverSettings<T1, T2, T3, T4>(this CombinedResult<T1, InnerChannelInputAttachmentFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.AutomaticInputFailoverSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAutomaticInputFailoverSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerChannelInputAttachmentFactory, T3, T4, InnerChannelAutomaticInputFailoverSettingsFactory> WithAutomaticInputFailoverSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerChannelInputAttachmentFactory, T3, T4> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.AutomaticInputFailoverSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAutomaticInputFailoverSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerChannelInputAttachmentFactory, T4, InnerChannelAutomaticInputFailoverSettingsFactory> WithAutomaticInputFailoverSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerChannelInputAttachmentFactory, T4> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.AutomaticInputFailoverSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAutomaticInputFailoverSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerChannelInputAttachmentFactory, InnerChannelAutomaticInputFailoverSettingsFactory> WithAutomaticInputFailoverSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerChannelInputAttachmentFactory> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.AutomaticInputFailoverSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAutomaticInputFailoverSettings(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerChannelInputAttachmentFactory, T1, InnerChannelInputSettingsFactory> WithInputSettings<T1>(this CombinedResult<InnerChannelInputAttachmentFactory, T1> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.InputSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithInputSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerChannelInputAttachmentFactory, InnerChannelInputSettingsFactory> WithInputSettings<T1>(this CombinedResult<T1, InnerChannelInputAttachmentFactory> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.InputSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithInputSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerChannelInputAttachmentFactory, T1, T2, InnerChannelInputSettingsFactory> WithInputSettings<T1, T2>(this CombinedResult<InnerChannelInputAttachmentFactory, T1, T2> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.InputSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInputSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerChannelInputAttachmentFactory, T2, InnerChannelInputSettingsFactory> WithInputSettings<T1, T2>(this CombinedResult<T1, InnerChannelInputAttachmentFactory, T2> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.InputSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInputSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerChannelInputAttachmentFactory, InnerChannelInputSettingsFactory> WithInputSettings<T1, T2>(this CombinedResult<T1, T2, InnerChannelInputAttachmentFactory> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.InputSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInputSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerChannelInputAttachmentFactory, T1, T2, T3, InnerChannelInputSettingsFactory> WithInputSettings<T1, T2, T3>(this CombinedResult<InnerChannelInputAttachmentFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.InputSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInputSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerChannelInputAttachmentFactory, T2, T3, InnerChannelInputSettingsFactory> WithInputSettings<T1, T2, T3>(this CombinedResult<T1, InnerChannelInputAttachmentFactory, T2, T3> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.InputSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInputSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerChannelInputAttachmentFactory, T3, InnerChannelInputSettingsFactory> WithInputSettings<T1, T2, T3>(this CombinedResult<T1, T2, InnerChannelInputAttachmentFactory, T3> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.InputSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInputSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerChannelInputAttachmentFactory, InnerChannelInputSettingsFactory> WithInputSettings<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerChannelInputAttachmentFactory> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.InputSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInputSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerChannelInputAttachmentFactory, T1, T2, T3, T4, InnerChannelInputSettingsFactory> WithInputSettings<T1, T2, T3, T4>(this CombinedResult<InnerChannelInputAttachmentFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.InputSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInputSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerChannelInputAttachmentFactory, T2, T3, T4, InnerChannelInputSettingsFactory> WithInputSettings<T1, T2, T3, T4>(this CombinedResult<T1, InnerChannelInputAttachmentFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.InputSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInputSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerChannelInputAttachmentFactory, T3, T4, InnerChannelInputSettingsFactory> WithInputSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerChannelInputAttachmentFactory, T3, T4> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.InputSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInputSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerChannelInputAttachmentFactory, T4, InnerChannelInputSettingsFactory> WithInputSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerChannelInputAttachmentFactory, T4> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.InputSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInputSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerChannelInputAttachmentFactory, InnerChannelInputSettingsFactory> WithInputSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerChannelInputAttachmentFactory> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.InputSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInputSettings(combinedResult.T5, subFactoryAction));
}
