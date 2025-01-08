// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Chatbot;

public class CustomActionFactory(string resourceName = null, Action<Humidifier.Chatbot.CustomAction> factoryAction = null) : ResourceFactory<Humidifier.Chatbot.CustomAction>(resourceName)
{

    internal List<InnerCustomActionCustomActionAttachmentFactory> AttachmentsFactories { get; set; } = [];

    internal InnerCustomActionCustomActionDefinitionFactory DefinitionFactory { get; set; }

    protected override Humidifier.Chatbot.CustomAction Create()
    {
        var customActionResult = CreateCustomAction();
        factoryAction?.Invoke(customActionResult);

        return customActionResult;
    }

    private Humidifier.Chatbot.CustomAction CreateCustomAction()
    {
        var customActionResult = new Humidifier.Chatbot.CustomAction
        {
            GivenName = InputResourceName,
        };

        return customActionResult;
    }
    public override void CreateChildren(Humidifier.Chatbot.CustomAction result)
    {
        base.CreateChildren(result);

        result.Attachments = AttachmentsFactories.Any() ? AttachmentsFactories.Select(x => x.Build()).ToList() : null;
        result.Definition ??= DefinitionFactory?.Build();
    }

} // End Of Class

public static class CustomActionFactoryExtensions
{
    public static CombinedResult<CustomActionFactory, InnerCustomActionCustomActionAttachmentFactory> WithAttachments(this CustomActionFactory parentFactory, Action<Humidifier.Chatbot.CustomActionTypes.CustomActionAttachment> subFactoryAction = null)
    {
        var factory = new InnerCustomActionCustomActionAttachmentFactory(subFactoryAction);
        parentFactory.AttachmentsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<CustomActionFactory, InnerCustomActionCustomActionDefinitionFactory> WithDefinition(this CustomActionFactory parentFactory, Action<Humidifier.Chatbot.CustomActionTypes.CustomActionDefinition> subFactoryAction = null)
    {
        parentFactory.DefinitionFactory = new InnerCustomActionCustomActionDefinitionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DefinitionFactory);
    }

    public static CombinedResult<CustomActionFactory, T1, InnerCustomActionCustomActionAttachmentFactory> WithAttachments<T1>(this CombinedResult<CustomActionFactory, T1> combinedResult, Action<Humidifier.Chatbot.CustomActionTypes.CustomActionAttachment> subFactoryAction = null) => new (combinedResult, combinedResult, WithAttachments(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CustomActionFactory, InnerCustomActionCustomActionAttachmentFactory> WithAttachments<T1>(this CombinedResult<T1, CustomActionFactory> combinedResult, Action<Humidifier.Chatbot.CustomActionTypes.CustomActionAttachment> subFactoryAction = null) => new (combinedResult, combinedResult, WithAttachments(combinedResult.T2, subFactoryAction));
    public static CombinedResult<CustomActionFactory, T1, T2, InnerCustomActionCustomActionAttachmentFactory> WithAttachments<T1, T2>(this CombinedResult<CustomActionFactory, T1, T2> combinedResult, Action<Humidifier.Chatbot.CustomActionTypes.CustomActionAttachment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAttachments(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CustomActionFactory, T2, InnerCustomActionCustomActionAttachmentFactory> WithAttachments<T1, T2>(this CombinedResult<T1, CustomActionFactory, T2> combinedResult, Action<Humidifier.Chatbot.CustomActionTypes.CustomActionAttachment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAttachments(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, CustomActionFactory, InnerCustomActionCustomActionAttachmentFactory> WithAttachments<T1, T2>(this CombinedResult<T1, T2, CustomActionFactory> combinedResult, Action<Humidifier.Chatbot.CustomActionTypes.CustomActionAttachment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAttachments(combinedResult.T3, subFactoryAction));
    public static CombinedResult<CustomActionFactory, T1, T2, T3, InnerCustomActionCustomActionAttachmentFactory> WithAttachments<T1, T2, T3>(this CombinedResult<CustomActionFactory, T1, T2, T3> combinedResult, Action<Humidifier.Chatbot.CustomActionTypes.CustomActionAttachment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAttachments(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CustomActionFactory, T2, T3, InnerCustomActionCustomActionAttachmentFactory> WithAttachments<T1, T2, T3>(this CombinedResult<T1, CustomActionFactory, T2, T3> combinedResult, Action<Humidifier.Chatbot.CustomActionTypes.CustomActionAttachment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAttachments(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, CustomActionFactory, T3, InnerCustomActionCustomActionAttachmentFactory> WithAttachments<T1, T2, T3>(this CombinedResult<T1, T2, CustomActionFactory, T3> combinedResult, Action<Humidifier.Chatbot.CustomActionTypes.CustomActionAttachment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAttachments(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, CustomActionFactory, InnerCustomActionCustomActionAttachmentFactory> WithAttachments<T1, T2, T3>(this CombinedResult<T1, T2, T3, CustomActionFactory> combinedResult, Action<Humidifier.Chatbot.CustomActionTypes.CustomActionAttachment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAttachments(combinedResult.T4, subFactoryAction));
    public static CombinedResult<CustomActionFactory, T1, T2, T3, T4, InnerCustomActionCustomActionAttachmentFactory> WithAttachments<T1, T2, T3, T4>(this CombinedResult<CustomActionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Chatbot.CustomActionTypes.CustomActionAttachment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAttachments(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CustomActionFactory, T2, T3, T4, InnerCustomActionCustomActionAttachmentFactory> WithAttachments<T1, T2, T3, T4>(this CombinedResult<T1, CustomActionFactory, T2, T3, T4> combinedResult, Action<Humidifier.Chatbot.CustomActionTypes.CustomActionAttachment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAttachments(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, CustomActionFactory, T3, T4, InnerCustomActionCustomActionAttachmentFactory> WithAttachments<T1, T2, T3, T4>(this CombinedResult<T1, T2, CustomActionFactory, T3, T4> combinedResult, Action<Humidifier.Chatbot.CustomActionTypes.CustomActionAttachment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAttachments(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, CustomActionFactory, T4, InnerCustomActionCustomActionAttachmentFactory> WithAttachments<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, CustomActionFactory, T4> combinedResult, Action<Humidifier.Chatbot.CustomActionTypes.CustomActionAttachment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAttachments(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, CustomActionFactory, InnerCustomActionCustomActionAttachmentFactory> WithAttachments<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, CustomActionFactory> combinedResult, Action<Humidifier.Chatbot.CustomActionTypes.CustomActionAttachment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAttachments(combinedResult.T5, subFactoryAction));
    public static CombinedResult<CustomActionFactory, T1, InnerCustomActionCustomActionDefinitionFactory> WithDefinition<T1>(this CombinedResult<CustomActionFactory, T1> combinedResult, Action<Humidifier.Chatbot.CustomActionTypes.CustomActionDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, WithDefinition(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CustomActionFactory, InnerCustomActionCustomActionDefinitionFactory> WithDefinition<T1>(this CombinedResult<T1, CustomActionFactory> combinedResult, Action<Humidifier.Chatbot.CustomActionTypes.CustomActionDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, WithDefinition(combinedResult.T2, subFactoryAction));
    public static CombinedResult<CustomActionFactory, T1, T2, InnerCustomActionCustomActionDefinitionFactory> WithDefinition<T1, T2>(this CombinedResult<CustomActionFactory, T1, T2> combinedResult, Action<Humidifier.Chatbot.CustomActionTypes.CustomActionDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefinition(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CustomActionFactory, T2, InnerCustomActionCustomActionDefinitionFactory> WithDefinition<T1, T2>(this CombinedResult<T1, CustomActionFactory, T2> combinedResult, Action<Humidifier.Chatbot.CustomActionTypes.CustomActionDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefinition(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, CustomActionFactory, InnerCustomActionCustomActionDefinitionFactory> WithDefinition<T1, T2>(this CombinedResult<T1, T2, CustomActionFactory> combinedResult, Action<Humidifier.Chatbot.CustomActionTypes.CustomActionDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefinition(combinedResult.T3, subFactoryAction));
    public static CombinedResult<CustomActionFactory, T1, T2, T3, InnerCustomActionCustomActionDefinitionFactory> WithDefinition<T1, T2, T3>(this CombinedResult<CustomActionFactory, T1, T2, T3> combinedResult, Action<Humidifier.Chatbot.CustomActionTypes.CustomActionDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefinition(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CustomActionFactory, T2, T3, InnerCustomActionCustomActionDefinitionFactory> WithDefinition<T1, T2, T3>(this CombinedResult<T1, CustomActionFactory, T2, T3> combinedResult, Action<Humidifier.Chatbot.CustomActionTypes.CustomActionDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefinition(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, CustomActionFactory, T3, InnerCustomActionCustomActionDefinitionFactory> WithDefinition<T1, T2, T3>(this CombinedResult<T1, T2, CustomActionFactory, T3> combinedResult, Action<Humidifier.Chatbot.CustomActionTypes.CustomActionDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefinition(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, CustomActionFactory, InnerCustomActionCustomActionDefinitionFactory> WithDefinition<T1, T2, T3>(this CombinedResult<T1, T2, T3, CustomActionFactory> combinedResult, Action<Humidifier.Chatbot.CustomActionTypes.CustomActionDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefinition(combinedResult.T4, subFactoryAction));
    public static CombinedResult<CustomActionFactory, T1, T2, T3, T4, InnerCustomActionCustomActionDefinitionFactory> WithDefinition<T1, T2, T3, T4>(this CombinedResult<CustomActionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Chatbot.CustomActionTypes.CustomActionDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefinition(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CustomActionFactory, T2, T3, T4, InnerCustomActionCustomActionDefinitionFactory> WithDefinition<T1, T2, T3, T4>(this CombinedResult<T1, CustomActionFactory, T2, T3, T4> combinedResult, Action<Humidifier.Chatbot.CustomActionTypes.CustomActionDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefinition(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, CustomActionFactory, T3, T4, InnerCustomActionCustomActionDefinitionFactory> WithDefinition<T1, T2, T3, T4>(this CombinedResult<T1, T2, CustomActionFactory, T3, T4> combinedResult, Action<Humidifier.Chatbot.CustomActionTypes.CustomActionDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefinition(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, CustomActionFactory, T4, InnerCustomActionCustomActionDefinitionFactory> WithDefinition<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, CustomActionFactory, T4> combinedResult, Action<Humidifier.Chatbot.CustomActionTypes.CustomActionDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefinition(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, CustomActionFactory, InnerCustomActionCustomActionDefinitionFactory> WithDefinition<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, CustomActionFactory> combinedResult, Action<Humidifier.Chatbot.CustomActionTypes.CustomActionDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefinition(combinedResult.T5, subFactoryAction));
}
