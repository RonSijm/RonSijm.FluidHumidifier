// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Config;

public class ConformancePackFactory(string resourceName = null, Action<Humidifier.Config.ConformancePack> factoryAction = null) : ResourceFactory<Humidifier.Config.ConformancePack>(resourceName)
{

    internal List<InnerConformancePackConformancePackInputParameterFactory> ConformancePackInputParametersFactories { get; set; } = [];

    internal InnerConformancePackTemplateSSMDocumentDetailsFactory TemplateSSMDocumentDetailsFactory { get; set; }

    protected override Humidifier.Config.ConformancePack Create()
    {
        var conformancePackResult = CreateConformancePack();
        factoryAction?.Invoke(conformancePackResult);

        return conformancePackResult;
    }

    private Humidifier.Config.ConformancePack CreateConformancePack()
    {
        var conformancePackResult = new Humidifier.Config.ConformancePack
        {
            GivenName = InputResourceName,
        };

        return conformancePackResult;
    }
    public override void CreateChildren(Humidifier.Config.ConformancePack result)
    {
        base.CreateChildren(result);

        result.ConformancePackInputParameters = ConformancePackInputParametersFactories.Any() ? ConformancePackInputParametersFactories.Select(x => x.Build()).ToList() : null;
        result.TemplateSSMDocumentDetails ??= TemplateSSMDocumentDetailsFactory?.Build();
    }

} // End Of Class

public static class ConformancePackFactoryExtensions
{
    public static CombinedResult<ConformancePackFactory, InnerConformancePackConformancePackInputParameterFactory> WithConformancePackInputParameters(this ConformancePackFactory parentFactory, Action<Humidifier.Config.ConformancePackTypes.ConformancePackInputParameter> subFactoryAction = null)
    {
        var factory = new InnerConformancePackConformancePackInputParameterFactory(subFactoryAction);
        parentFactory.ConformancePackInputParametersFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<ConformancePackFactory, InnerConformancePackTemplateSSMDocumentDetailsFactory> WithTemplateSSMDocumentDetails(this ConformancePackFactory parentFactory, Action<Humidifier.Config.ConformancePackTypes.TemplateSSMDocumentDetails> subFactoryAction = null)
    {
        parentFactory.TemplateSSMDocumentDetailsFactory = new InnerConformancePackTemplateSSMDocumentDetailsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.TemplateSSMDocumentDetailsFactory);
    }

    public static CombinedResult<ConformancePackFactory, T1, InnerConformancePackConformancePackInputParameterFactory> WithConformancePackInputParameters<T1>(this CombinedResult<ConformancePackFactory, T1> combinedResult, Action<Humidifier.Config.ConformancePackTypes.ConformancePackInputParameter> subFactoryAction = null) => new (combinedResult, combinedResult, WithConformancePackInputParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConformancePackFactory, InnerConformancePackConformancePackInputParameterFactory> WithConformancePackInputParameters<T1>(this CombinedResult<T1, ConformancePackFactory> combinedResult, Action<Humidifier.Config.ConformancePackTypes.ConformancePackInputParameter> subFactoryAction = null) => new (combinedResult, combinedResult, WithConformancePackInputParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ConformancePackFactory, T1, T2, InnerConformancePackConformancePackInputParameterFactory> WithConformancePackInputParameters<T1, T2>(this CombinedResult<ConformancePackFactory, T1, T2> combinedResult, Action<Humidifier.Config.ConformancePackTypes.ConformancePackInputParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConformancePackInputParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConformancePackFactory, T2, InnerConformancePackConformancePackInputParameterFactory> WithConformancePackInputParameters<T1, T2>(this CombinedResult<T1, ConformancePackFactory, T2> combinedResult, Action<Humidifier.Config.ConformancePackTypes.ConformancePackInputParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConformancePackInputParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ConformancePackFactory, InnerConformancePackConformancePackInputParameterFactory> WithConformancePackInputParameters<T1, T2>(this CombinedResult<T1, T2, ConformancePackFactory> combinedResult, Action<Humidifier.Config.ConformancePackTypes.ConformancePackInputParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConformancePackInputParameters(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ConformancePackFactory, T1, T2, T3, InnerConformancePackConformancePackInputParameterFactory> WithConformancePackInputParameters<T1, T2, T3>(this CombinedResult<ConformancePackFactory, T1, T2, T3> combinedResult, Action<Humidifier.Config.ConformancePackTypes.ConformancePackInputParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConformancePackInputParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConformancePackFactory, T2, T3, InnerConformancePackConformancePackInputParameterFactory> WithConformancePackInputParameters<T1, T2, T3>(this CombinedResult<T1, ConformancePackFactory, T2, T3> combinedResult, Action<Humidifier.Config.ConformancePackTypes.ConformancePackInputParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConformancePackInputParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ConformancePackFactory, T3, InnerConformancePackConformancePackInputParameterFactory> WithConformancePackInputParameters<T1, T2, T3>(this CombinedResult<T1, T2, ConformancePackFactory, T3> combinedResult, Action<Humidifier.Config.ConformancePackTypes.ConformancePackInputParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConformancePackInputParameters(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ConformancePackFactory, InnerConformancePackConformancePackInputParameterFactory> WithConformancePackInputParameters<T1, T2, T3>(this CombinedResult<T1, T2, T3, ConformancePackFactory> combinedResult, Action<Humidifier.Config.ConformancePackTypes.ConformancePackInputParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConformancePackInputParameters(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ConformancePackFactory, T1, T2, T3, T4, InnerConformancePackConformancePackInputParameterFactory> WithConformancePackInputParameters<T1, T2, T3, T4>(this CombinedResult<ConformancePackFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Config.ConformancePackTypes.ConformancePackInputParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConformancePackInputParameters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConformancePackFactory, T2, T3, T4, InnerConformancePackConformancePackInputParameterFactory> WithConformancePackInputParameters<T1, T2, T3, T4>(this CombinedResult<T1, ConformancePackFactory, T2, T3, T4> combinedResult, Action<Humidifier.Config.ConformancePackTypes.ConformancePackInputParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConformancePackInputParameters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ConformancePackFactory, T3, T4, InnerConformancePackConformancePackInputParameterFactory> WithConformancePackInputParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, ConformancePackFactory, T3, T4> combinedResult, Action<Humidifier.Config.ConformancePackTypes.ConformancePackInputParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConformancePackInputParameters(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ConformancePackFactory, T4, InnerConformancePackConformancePackInputParameterFactory> WithConformancePackInputParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ConformancePackFactory, T4> combinedResult, Action<Humidifier.Config.ConformancePackTypes.ConformancePackInputParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConformancePackInputParameters(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ConformancePackFactory, InnerConformancePackConformancePackInputParameterFactory> WithConformancePackInputParameters<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ConformancePackFactory> combinedResult, Action<Humidifier.Config.ConformancePackTypes.ConformancePackInputParameter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConformancePackInputParameters(combinedResult.T5, subFactoryAction));
    public static CombinedResult<ConformancePackFactory, T1, InnerConformancePackTemplateSSMDocumentDetailsFactory> WithTemplateSSMDocumentDetails<T1>(this CombinedResult<ConformancePackFactory, T1> combinedResult, Action<Humidifier.Config.ConformancePackTypes.TemplateSSMDocumentDetails> subFactoryAction = null) => new (combinedResult, combinedResult, WithTemplateSSMDocumentDetails(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConformancePackFactory, InnerConformancePackTemplateSSMDocumentDetailsFactory> WithTemplateSSMDocumentDetails<T1>(this CombinedResult<T1, ConformancePackFactory> combinedResult, Action<Humidifier.Config.ConformancePackTypes.TemplateSSMDocumentDetails> subFactoryAction = null) => new (combinedResult, combinedResult, WithTemplateSSMDocumentDetails(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ConformancePackFactory, T1, T2, InnerConformancePackTemplateSSMDocumentDetailsFactory> WithTemplateSSMDocumentDetails<T1, T2>(this CombinedResult<ConformancePackFactory, T1, T2> combinedResult, Action<Humidifier.Config.ConformancePackTypes.TemplateSSMDocumentDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTemplateSSMDocumentDetails(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConformancePackFactory, T2, InnerConformancePackTemplateSSMDocumentDetailsFactory> WithTemplateSSMDocumentDetails<T1, T2>(this CombinedResult<T1, ConformancePackFactory, T2> combinedResult, Action<Humidifier.Config.ConformancePackTypes.TemplateSSMDocumentDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTemplateSSMDocumentDetails(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ConformancePackFactory, InnerConformancePackTemplateSSMDocumentDetailsFactory> WithTemplateSSMDocumentDetails<T1, T2>(this CombinedResult<T1, T2, ConformancePackFactory> combinedResult, Action<Humidifier.Config.ConformancePackTypes.TemplateSSMDocumentDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTemplateSSMDocumentDetails(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ConformancePackFactory, T1, T2, T3, InnerConformancePackTemplateSSMDocumentDetailsFactory> WithTemplateSSMDocumentDetails<T1, T2, T3>(this CombinedResult<ConformancePackFactory, T1, T2, T3> combinedResult, Action<Humidifier.Config.ConformancePackTypes.TemplateSSMDocumentDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTemplateSSMDocumentDetails(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConformancePackFactory, T2, T3, InnerConformancePackTemplateSSMDocumentDetailsFactory> WithTemplateSSMDocumentDetails<T1, T2, T3>(this CombinedResult<T1, ConformancePackFactory, T2, T3> combinedResult, Action<Humidifier.Config.ConformancePackTypes.TemplateSSMDocumentDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTemplateSSMDocumentDetails(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ConformancePackFactory, T3, InnerConformancePackTemplateSSMDocumentDetailsFactory> WithTemplateSSMDocumentDetails<T1, T2, T3>(this CombinedResult<T1, T2, ConformancePackFactory, T3> combinedResult, Action<Humidifier.Config.ConformancePackTypes.TemplateSSMDocumentDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTemplateSSMDocumentDetails(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ConformancePackFactory, InnerConformancePackTemplateSSMDocumentDetailsFactory> WithTemplateSSMDocumentDetails<T1, T2, T3>(this CombinedResult<T1, T2, T3, ConformancePackFactory> combinedResult, Action<Humidifier.Config.ConformancePackTypes.TemplateSSMDocumentDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTemplateSSMDocumentDetails(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ConformancePackFactory, T1, T2, T3, T4, InnerConformancePackTemplateSSMDocumentDetailsFactory> WithTemplateSSMDocumentDetails<T1, T2, T3, T4>(this CombinedResult<ConformancePackFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Config.ConformancePackTypes.TemplateSSMDocumentDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTemplateSSMDocumentDetails(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ConformancePackFactory, T2, T3, T4, InnerConformancePackTemplateSSMDocumentDetailsFactory> WithTemplateSSMDocumentDetails<T1, T2, T3, T4>(this CombinedResult<T1, ConformancePackFactory, T2, T3, T4> combinedResult, Action<Humidifier.Config.ConformancePackTypes.TemplateSSMDocumentDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTemplateSSMDocumentDetails(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ConformancePackFactory, T3, T4, InnerConformancePackTemplateSSMDocumentDetailsFactory> WithTemplateSSMDocumentDetails<T1, T2, T3, T4>(this CombinedResult<T1, T2, ConformancePackFactory, T3, T4> combinedResult, Action<Humidifier.Config.ConformancePackTypes.TemplateSSMDocumentDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTemplateSSMDocumentDetails(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ConformancePackFactory, T4, InnerConformancePackTemplateSSMDocumentDetailsFactory> WithTemplateSSMDocumentDetails<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ConformancePackFactory, T4> combinedResult, Action<Humidifier.Config.ConformancePackTypes.TemplateSSMDocumentDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTemplateSSMDocumentDetails(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ConformancePackFactory, InnerConformancePackTemplateSSMDocumentDetailsFactory> WithTemplateSSMDocumentDetails<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ConformancePackFactory> combinedResult, Action<Humidifier.Config.ConformancePackTypes.TemplateSSMDocumentDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTemplateSSMDocumentDetails(combinedResult.T5, subFactoryAction));
}
