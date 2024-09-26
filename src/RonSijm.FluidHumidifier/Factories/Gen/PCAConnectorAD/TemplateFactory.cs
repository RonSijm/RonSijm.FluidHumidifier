// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.PCAConnectorAD;

public class TemplateFactory(string resourceName = null, Action<Humidifier.PCAConnectorAD.Template> factoryAction = null) : ResourceFactory<Humidifier.PCAConnectorAD.Template>(resourceName)
{

    internal InnerTemplateTemplateDefinitionFactory DefinitionFactory { get; set; }

    protected override Humidifier.PCAConnectorAD.Template Create()
    {
        var templateResult = CreateTemplate();
        factoryAction?.Invoke(templateResult);

        return templateResult;
    }

    private Humidifier.PCAConnectorAD.Template CreateTemplate()
    {
        var templateResult = new Humidifier.PCAConnectorAD.Template
        {
            GivenName = InputResourceName,
        };

        return templateResult;
    }
    public override void CreateChildren(Humidifier.PCAConnectorAD.Template result)
    {
        base.CreateChildren(result);

        result.Definition ??= DefinitionFactory?.Build();
    }

} // End Of Class

public static class TemplateFactoryExtensions
{
    public static CombinedResult<TemplateFactory, InnerTemplateTemplateDefinitionFactory> WithDefinition(this TemplateFactory parentFactory, Action<Humidifier.PCAConnectorAD.TemplateTypes.TemplateDefinition> subFactoryAction = null)
    {
        parentFactory.DefinitionFactory = new InnerTemplateTemplateDefinitionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DefinitionFactory);
    }

    public static CombinedResult<TemplateFactory, T1, InnerTemplateTemplateDefinitionFactory> WithDefinition<T1>(this CombinedResult<TemplateFactory, T1> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.TemplateDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, WithDefinition(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TemplateFactory, InnerTemplateTemplateDefinitionFactory> WithDefinition<T1>(this CombinedResult<T1, TemplateFactory> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.TemplateDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, WithDefinition(combinedResult.T2, subFactoryAction));
    public static CombinedResult<TemplateFactory, T1, T2, InnerTemplateTemplateDefinitionFactory> WithDefinition<T1, T2>(this CombinedResult<TemplateFactory, T1, T2> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.TemplateDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefinition(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TemplateFactory, T2, InnerTemplateTemplateDefinitionFactory> WithDefinition<T1, T2>(this CombinedResult<T1, TemplateFactory, T2> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.TemplateDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefinition(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TemplateFactory, InnerTemplateTemplateDefinitionFactory> WithDefinition<T1, T2>(this CombinedResult<T1, T2, TemplateFactory> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.TemplateDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefinition(combinedResult.T3, subFactoryAction));
    public static CombinedResult<TemplateFactory, T1, T2, T3, InnerTemplateTemplateDefinitionFactory> WithDefinition<T1, T2, T3>(this CombinedResult<TemplateFactory, T1, T2, T3> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.TemplateDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefinition(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TemplateFactory, T2, T3, InnerTemplateTemplateDefinitionFactory> WithDefinition<T1, T2, T3>(this CombinedResult<T1, TemplateFactory, T2, T3> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.TemplateDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefinition(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TemplateFactory, T3, InnerTemplateTemplateDefinitionFactory> WithDefinition<T1, T2, T3>(this CombinedResult<T1, T2, TemplateFactory, T3> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.TemplateDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefinition(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, TemplateFactory, InnerTemplateTemplateDefinitionFactory> WithDefinition<T1, T2, T3>(this CombinedResult<T1, T2, T3, TemplateFactory> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.TemplateDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefinition(combinedResult.T4, subFactoryAction));
    public static CombinedResult<TemplateFactory, T1, T2, T3, T4, InnerTemplateTemplateDefinitionFactory> WithDefinition<T1, T2, T3, T4>(this CombinedResult<TemplateFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.TemplateDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefinition(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TemplateFactory, T2, T3, T4, InnerTemplateTemplateDefinitionFactory> WithDefinition<T1, T2, T3, T4>(this CombinedResult<T1, TemplateFactory, T2, T3, T4> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.TemplateDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefinition(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TemplateFactory, T3, T4, InnerTemplateTemplateDefinitionFactory> WithDefinition<T1, T2, T3, T4>(this CombinedResult<T1, T2, TemplateFactory, T3, T4> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.TemplateDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefinition(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, TemplateFactory, T4, InnerTemplateTemplateDefinitionFactory> WithDefinition<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, TemplateFactory, T4> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.TemplateDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefinition(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, TemplateFactory, InnerTemplateTemplateDefinitionFactory> WithDefinition<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, TemplateFactory> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.TemplateDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefinition(combinedResult.T5, subFactoryAction));
}
