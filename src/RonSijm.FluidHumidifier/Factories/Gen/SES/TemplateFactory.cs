// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SES;

public class TemplateFactory(string resourceName = null, Action<Humidifier.SES.Template> factoryAction = null) : ResourceFactory<Humidifier.SES.Template>(resourceName)
{

    internal InnerTemplateTemplateFactory Template_Factory { get; set; }

    protected override Humidifier.SES.Template Create()
    {
        var templateResult = CreateTemplate();
        factoryAction?.Invoke(templateResult);

        return templateResult;
    }

    private Humidifier.SES.Template CreateTemplate()
    {
        var templateResult = new Humidifier.SES.Template
        {
            GivenName = InputResourceName,
        };

        return templateResult;
    }
    public override void CreateChildren(Humidifier.SES.Template result)
    {
        base.CreateChildren(result);

        result.Template_ ??= Template_Factory?.Build();
    }

} // End Of Class

public static class TemplateFactoryExtensions
{
    public static CombinedResult<TemplateFactory, InnerTemplateTemplateFactory> WithTemplate_(this TemplateFactory parentFactory, Action<Humidifier.SES.TemplateTypes.Template> subFactoryAction = null)
    {
        parentFactory.Template_Factory = new InnerTemplateTemplateFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.Template_Factory);
    }

    public static CombinedResult<TemplateFactory, T1, InnerTemplateTemplateFactory> WithTemplate_<T1>(this CombinedResult<TemplateFactory, T1> combinedResult, Action<Humidifier.SES.TemplateTypes.Template> subFactoryAction = null) => new (combinedResult, combinedResult, WithTemplate_(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TemplateFactory, InnerTemplateTemplateFactory> WithTemplate_<T1>(this CombinedResult<T1, TemplateFactory> combinedResult, Action<Humidifier.SES.TemplateTypes.Template> subFactoryAction = null) => new (combinedResult, combinedResult, WithTemplate_(combinedResult.T2, subFactoryAction));
    public static CombinedResult<TemplateFactory, T1, T2, InnerTemplateTemplateFactory> WithTemplate_<T1, T2>(this CombinedResult<TemplateFactory, T1, T2> combinedResult, Action<Humidifier.SES.TemplateTypes.Template> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTemplate_(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TemplateFactory, T2, InnerTemplateTemplateFactory> WithTemplate_<T1, T2>(this CombinedResult<T1, TemplateFactory, T2> combinedResult, Action<Humidifier.SES.TemplateTypes.Template> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTemplate_(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TemplateFactory, InnerTemplateTemplateFactory> WithTemplate_<T1, T2>(this CombinedResult<T1, T2, TemplateFactory> combinedResult, Action<Humidifier.SES.TemplateTypes.Template> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTemplate_(combinedResult.T3, subFactoryAction));
    public static CombinedResult<TemplateFactory, T1, T2, T3, InnerTemplateTemplateFactory> WithTemplate_<T1, T2, T3>(this CombinedResult<TemplateFactory, T1, T2, T3> combinedResult, Action<Humidifier.SES.TemplateTypes.Template> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTemplate_(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TemplateFactory, T2, T3, InnerTemplateTemplateFactory> WithTemplate_<T1, T2, T3>(this CombinedResult<T1, TemplateFactory, T2, T3> combinedResult, Action<Humidifier.SES.TemplateTypes.Template> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTemplate_(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TemplateFactory, T3, InnerTemplateTemplateFactory> WithTemplate_<T1, T2, T3>(this CombinedResult<T1, T2, TemplateFactory, T3> combinedResult, Action<Humidifier.SES.TemplateTypes.Template> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTemplate_(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, TemplateFactory, InnerTemplateTemplateFactory> WithTemplate_<T1, T2, T3>(this CombinedResult<T1, T2, T3, TemplateFactory> combinedResult, Action<Humidifier.SES.TemplateTypes.Template> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTemplate_(combinedResult.T4, subFactoryAction));
    public static CombinedResult<TemplateFactory, T1, T2, T3, T4, InnerTemplateTemplateFactory> WithTemplate_<T1, T2, T3, T4>(this CombinedResult<TemplateFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SES.TemplateTypes.Template> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTemplate_(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TemplateFactory, T2, T3, T4, InnerTemplateTemplateFactory> WithTemplate_<T1, T2, T3, T4>(this CombinedResult<T1, TemplateFactory, T2, T3, T4> combinedResult, Action<Humidifier.SES.TemplateTypes.Template> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTemplate_(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TemplateFactory, T3, T4, InnerTemplateTemplateFactory> WithTemplate_<T1, T2, T3, T4>(this CombinedResult<T1, T2, TemplateFactory, T3, T4> combinedResult, Action<Humidifier.SES.TemplateTypes.Template> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTemplate_(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, TemplateFactory, T4, InnerTemplateTemplateFactory> WithTemplate_<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, TemplateFactory, T4> combinedResult, Action<Humidifier.SES.TemplateTypes.Template> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTemplate_(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, TemplateFactory, InnerTemplateTemplateFactory> WithTemplate_<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, TemplateFactory> combinedResult, Action<Humidifier.SES.TemplateTypes.Template> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTemplate_(combinedResult.T5, subFactoryAction));
}
