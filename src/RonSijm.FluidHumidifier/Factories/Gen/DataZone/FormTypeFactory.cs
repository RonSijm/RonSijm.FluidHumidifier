// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataZone;

public class FormTypeFactory(string resourceName = null, Action<Humidifier.DataZone.FormType> factoryAction = null) : ResourceFactory<Humidifier.DataZone.FormType>(resourceName)
{

    internal InnerFormTypeModelFactory ModelFactory { get; set; }

    protected override Humidifier.DataZone.FormType Create()
    {
        var formTypeResult = CreateFormType();
        factoryAction?.Invoke(formTypeResult);

        return formTypeResult;
    }

    private Humidifier.DataZone.FormType CreateFormType()
    {
        var formTypeResult = new Humidifier.DataZone.FormType
        {
            GivenName = InputResourceName,
        };

        return formTypeResult;
    }
    public override void CreateChildren(Humidifier.DataZone.FormType result)
    {
        base.CreateChildren(result);

        result.Model ??= ModelFactory?.Build();
    }

} // End Of Class

public static class FormTypeFactoryExtensions
{
    public static CombinedResult<FormTypeFactory, InnerFormTypeModelFactory> WithModel(this FormTypeFactory parentFactory, Action<Humidifier.DataZone.FormTypeTypes.Model> subFactoryAction = null)
    {
        parentFactory.ModelFactory = new InnerFormTypeModelFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ModelFactory);
    }

    public static CombinedResult<FormTypeFactory, T1, InnerFormTypeModelFactory> WithModel<T1>(this CombinedResult<FormTypeFactory, T1> combinedResult, Action<Humidifier.DataZone.FormTypeTypes.Model> subFactoryAction = null) => new (combinedResult, combinedResult, WithModel(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, FormTypeFactory, InnerFormTypeModelFactory> WithModel<T1>(this CombinedResult<T1, FormTypeFactory> combinedResult, Action<Humidifier.DataZone.FormTypeTypes.Model> subFactoryAction = null) => new (combinedResult, combinedResult, WithModel(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<FormTypeFactory, T1, T2, InnerFormTypeModelFactory> WithModel<T1, T2>(this CombinedResult<FormTypeFactory, T1, T2> combinedResult, Action<Humidifier.DataZone.FormTypeTypes.Model> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithModel(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, FormTypeFactory, T2, InnerFormTypeModelFactory> WithModel<T1, T2>(this CombinedResult<T1, FormTypeFactory, T2> combinedResult, Action<Humidifier.DataZone.FormTypeTypes.Model> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithModel(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, FormTypeFactory, InnerFormTypeModelFactory> WithModel<T1, T2>(this CombinedResult<T1, T2, FormTypeFactory> combinedResult, Action<Humidifier.DataZone.FormTypeTypes.Model> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithModel(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<FormTypeFactory, T1, T2, T3, InnerFormTypeModelFactory> WithModel<T1, T2, T3>(this CombinedResult<FormTypeFactory, T1, T2, T3> combinedResult, Action<Humidifier.DataZone.FormTypeTypes.Model> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithModel(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, FormTypeFactory, T2, T3, InnerFormTypeModelFactory> WithModel<T1, T2, T3>(this CombinedResult<T1, FormTypeFactory, T2, T3> combinedResult, Action<Humidifier.DataZone.FormTypeTypes.Model> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithModel(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, FormTypeFactory, T3, InnerFormTypeModelFactory> WithModel<T1, T2, T3>(this CombinedResult<T1, T2, FormTypeFactory, T3> combinedResult, Action<Humidifier.DataZone.FormTypeTypes.Model> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithModel(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, FormTypeFactory, InnerFormTypeModelFactory> WithModel<T1, T2, T3>(this CombinedResult<T1, T2, T3, FormTypeFactory> combinedResult, Action<Humidifier.DataZone.FormTypeTypes.Model> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithModel(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<FormTypeFactory, T1, T2, T3, T4, InnerFormTypeModelFactory> WithModel<T1, T2, T3, T4>(this CombinedResult<FormTypeFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DataZone.FormTypeTypes.Model> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithModel(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, FormTypeFactory, T2, T3, T4, InnerFormTypeModelFactory> WithModel<T1, T2, T3, T4>(this CombinedResult<T1, FormTypeFactory, T2, T3, T4> combinedResult, Action<Humidifier.DataZone.FormTypeTypes.Model> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithModel(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, FormTypeFactory, T3, T4, InnerFormTypeModelFactory> WithModel<T1, T2, T3, T4>(this CombinedResult<T1, T2, FormTypeFactory, T3, T4> combinedResult, Action<Humidifier.DataZone.FormTypeTypes.Model> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithModel(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, FormTypeFactory, T4, InnerFormTypeModelFactory> WithModel<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, FormTypeFactory, T4> combinedResult, Action<Humidifier.DataZone.FormTypeTypes.Model> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithModel(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, FormTypeFactory, InnerFormTypeModelFactory> WithModel<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, FormTypeFactory> combinedResult, Action<Humidifier.DataZone.FormTypeTypes.Model> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithModel(combinedResult.T5, subFactoryAction).T2);
}
