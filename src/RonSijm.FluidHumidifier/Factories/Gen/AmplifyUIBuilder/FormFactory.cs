// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AmplifyUIBuilder;

public class FormFactory(string resourceName = null, Action<Humidifier.AmplifyUIBuilder.Form> factoryAction = null) : ResourceFactory<Humidifier.AmplifyUIBuilder.Form>(resourceName)
{

    internal InnerFormFormCTAFactory CtaFactory { get; set; }

    internal InnerFormFormDataTypeConfigFactory DataTypeFactory { get; set; }

    internal InnerFormFormStyleFactory StyleFactory { get; set; }

    protected override Humidifier.AmplifyUIBuilder.Form Create()
    {
        var formResult = CreateForm();
        factoryAction?.Invoke(formResult);

        return formResult;
    }

    private Humidifier.AmplifyUIBuilder.Form CreateForm()
    {
        var formResult = new Humidifier.AmplifyUIBuilder.Form
        {
            GivenName = InputResourceName,
        };

        return formResult;
    }
    public override void CreateChildren(Humidifier.AmplifyUIBuilder.Form result)
    {
        base.CreateChildren(result);

        result.Cta ??= CtaFactory?.Build();
        result.DataType ??= DataTypeFactory?.Build();
        result.Style ??= StyleFactory?.Build();
    }

} // End Of Class

public static class FormFactoryExtensions
{
    public static CombinedResult<FormFactory, InnerFormFormCTAFactory> WithCta(this FormFactory parentFactory, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormCTA> subFactoryAction = null)
    {
        parentFactory.CtaFactory = new InnerFormFormCTAFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CtaFactory);
    }

    public static CombinedResult<FormFactory, InnerFormFormDataTypeConfigFactory> WithDataType(this FormFactory parentFactory, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormDataTypeConfig> subFactoryAction = null)
    {
        parentFactory.DataTypeFactory = new InnerFormFormDataTypeConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DataTypeFactory);
    }

    public static CombinedResult<FormFactory, InnerFormFormStyleFactory> WithStyle(this FormFactory parentFactory, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormStyle> subFactoryAction = null)
    {
        parentFactory.StyleFactory = new InnerFormFormStyleFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.StyleFactory);
    }

    public static CombinedResult<FormFactory, T1, InnerFormFormCTAFactory> WithCta<T1>(this CombinedResult<FormFactory, T1> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormCTA> subFactoryAction = null) => new (combinedResult, combinedResult, WithCta(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FormFactory, InnerFormFormCTAFactory> WithCta<T1>(this CombinedResult<T1, FormFactory> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormCTA> subFactoryAction = null) => new (combinedResult, combinedResult, WithCta(combinedResult.T2, subFactoryAction));
    public static CombinedResult<FormFactory, T1, T2, InnerFormFormCTAFactory> WithCta<T1, T2>(this CombinedResult<FormFactory, T1, T2> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormCTA> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCta(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FormFactory, T2, InnerFormFormCTAFactory> WithCta<T1, T2>(this CombinedResult<T1, FormFactory, T2> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormCTA> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCta(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FormFactory, InnerFormFormCTAFactory> WithCta<T1, T2>(this CombinedResult<T1, T2, FormFactory> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormCTA> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCta(combinedResult.T3, subFactoryAction));
    public static CombinedResult<FormFactory, T1, T2, T3, InnerFormFormCTAFactory> WithCta<T1, T2, T3>(this CombinedResult<FormFactory, T1, T2, T3> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormCTA> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCta(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FormFactory, T2, T3, InnerFormFormCTAFactory> WithCta<T1, T2, T3>(this CombinedResult<T1, FormFactory, T2, T3> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormCTA> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCta(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FormFactory, T3, InnerFormFormCTAFactory> WithCta<T1, T2, T3>(this CombinedResult<T1, T2, FormFactory, T3> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormCTA> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCta(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, FormFactory, InnerFormFormCTAFactory> WithCta<T1, T2, T3>(this CombinedResult<T1, T2, T3, FormFactory> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormCTA> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCta(combinedResult.T4, subFactoryAction));
    public static CombinedResult<FormFactory, T1, T2, T3, T4, InnerFormFormCTAFactory> WithCta<T1, T2, T3, T4>(this CombinedResult<FormFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormCTA> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCta(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FormFactory, T2, T3, T4, InnerFormFormCTAFactory> WithCta<T1, T2, T3, T4>(this CombinedResult<T1, FormFactory, T2, T3, T4> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormCTA> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCta(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FormFactory, T3, T4, InnerFormFormCTAFactory> WithCta<T1, T2, T3, T4>(this CombinedResult<T1, T2, FormFactory, T3, T4> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormCTA> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCta(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, FormFactory, T4, InnerFormFormCTAFactory> WithCta<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, FormFactory, T4> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormCTA> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCta(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, FormFactory, InnerFormFormCTAFactory> WithCta<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, FormFactory> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormCTA> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCta(combinedResult.T5, subFactoryAction));
    public static CombinedResult<FormFactory, T1, InnerFormFormDataTypeConfigFactory> WithDataType<T1>(this CombinedResult<FormFactory, T1> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormDataTypeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithDataType(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FormFactory, InnerFormFormDataTypeConfigFactory> WithDataType<T1>(this CombinedResult<T1, FormFactory> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormDataTypeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithDataType(combinedResult.T2, subFactoryAction));
    public static CombinedResult<FormFactory, T1, T2, InnerFormFormDataTypeConfigFactory> WithDataType<T1, T2>(this CombinedResult<FormFactory, T1, T2> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormDataTypeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDataType(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FormFactory, T2, InnerFormFormDataTypeConfigFactory> WithDataType<T1, T2>(this CombinedResult<T1, FormFactory, T2> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormDataTypeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDataType(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FormFactory, InnerFormFormDataTypeConfigFactory> WithDataType<T1, T2>(this CombinedResult<T1, T2, FormFactory> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormDataTypeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDataType(combinedResult.T3, subFactoryAction));
    public static CombinedResult<FormFactory, T1, T2, T3, InnerFormFormDataTypeConfigFactory> WithDataType<T1, T2, T3>(this CombinedResult<FormFactory, T1, T2, T3> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormDataTypeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataType(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FormFactory, T2, T3, InnerFormFormDataTypeConfigFactory> WithDataType<T1, T2, T3>(this CombinedResult<T1, FormFactory, T2, T3> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormDataTypeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataType(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FormFactory, T3, InnerFormFormDataTypeConfigFactory> WithDataType<T1, T2, T3>(this CombinedResult<T1, T2, FormFactory, T3> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormDataTypeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataType(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, FormFactory, InnerFormFormDataTypeConfigFactory> WithDataType<T1, T2, T3>(this CombinedResult<T1, T2, T3, FormFactory> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormDataTypeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataType(combinedResult.T4, subFactoryAction));
    public static CombinedResult<FormFactory, T1, T2, T3, T4, InnerFormFormDataTypeConfigFactory> WithDataType<T1, T2, T3, T4>(this CombinedResult<FormFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormDataTypeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataType(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FormFactory, T2, T3, T4, InnerFormFormDataTypeConfigFactory> WithDataType<T1, T2, T3, T4>(this CombinedResult<T1, FormFactory, T2, T3, T4> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormDataTypeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataType(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FormFactory, T3, T4, InnerFormFormDataTypeConfigFactory> WithDataType<T1, T2, T3, T4>(this CombinedResult<T1, T2, FormFactory, T3, T4> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormDataTypeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataType(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, FormFactory, T4, InnerFormFormDataTypeConfigFactory> WithDataType<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, FormFactory, T4> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormDataTypeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataType(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, FormFactory, InnerFormFormDataTypeConfigFactory> WithDataType<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, FormFactory> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormDataTypeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataType(combinedResult.T5, subFactoryAction));
    public static CombinedResult<FormFactory, T1, InnerFormFormStyleFactory> WithStyle<T1>(this CombinedResult<FormFactory, T1> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormStyle> subFactoryAction = null) => new (combinedResult, combinedResult, WithStyle(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FormFactory, InnerFormFormStyleFactory> WithStyle<T1>(this CombinedResult<T1, FormFactory> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormStyle> subFactoryAction = null) => new (combinedResult, combinedResult, WithStyle(combinedResult.T2, subFactoryAction));
    public static CombinedResult<FormFactory, T1, T2, InnerFormFormStyleFactory> WithStyle<T1, T2>(this CombinedResult<FormFactory, T1, T2> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormStyle> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStyle(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FormFactory, T2, InnerFormFormStyleFactory> WithStyle<T1, T2>(this CombinedResult<T1, FormFactory, T2> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormStyle> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStyle(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FormFactory, InnerFormFormStyleFactory> WithStyle<T1, T2>(this CombinedResult<T1, T2, FormFactory> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormStyle> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStyle(combinedResult.T3, subFactoryAction));
    public static CombinedResult<FormFactory, T1, T2, T3, InnerFormFormStyleFactory> WithStyle<T1, T2, T3>(this CombinedResult<FormFactory, T1, T2, T3> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormStyle> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStyle(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FormFactory, T2, T3, InnerFormFormStyleFactory> WithStyle<T1, T2, T3>(this CombinedResult<T1, FormFactory, T2, T3> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormStyle> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStyle(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FormFactory, T3, InnerFormFormStyleFactory> WithStyle<T1, T2, T3>(this CombinedResult<T1, T2, FormFactory, T3> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormStyle> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStyle(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, FormFactory, InnerFormFormStyleFactory> WithStyle<T1, T2, T3>(this CombinedResult<T1, T2, T3, FormFactory> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormStyle> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStyle(combinedResult.T4, subFactoryAction));
    public static CombinedResult<FormFactory, T1, T2, T3, T4, InnerFormFormStyleFactory> WithStyle<T1, T2, T3, T4>(this CombinedResult<FormFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormStyle> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStyle(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FormFactory, T2, T3, T4, InnerFormFormStyleFactory> WithStyle<T1, T2, T3, T4>(this CombinedResult<T1, FormFactory, T2, T3, T4> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormStyle> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStyle(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FormFactory, T3, T4, InnerFormFormStyleFactory> WithStyle<T1, T2, T3, T4>(this CombinedResult<T1, T2, FormFactory, T3, T4> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormStyle> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStyle(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, FormFactory, T4, InnerFormFormStyleFactory> WithStyle<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, FormFactory, T4> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormStyle> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStyle(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, FormFactory, InnerFormFormStyleFactory> WithStyle<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, FormFactory> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormStyle> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStyle(combinedResult.T5, subFactoryAction));
}
