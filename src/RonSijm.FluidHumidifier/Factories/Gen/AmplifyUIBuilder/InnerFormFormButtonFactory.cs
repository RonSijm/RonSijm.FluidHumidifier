// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AmplifyUIBuilder;

public class InnerFormFormButtonFactory(Action<Humidifier.AmplifyUIBuilder.FormTypes.FormButton> factoryAction = null) : SubResourceFactory<Humidifier.AmplifyUIBuilder.FormTypes.FormButton>
{

    internal InnerFormFieldPositionFactory PositionFactory { get; set; }

    protected override Humidifier.AmplifyUIBuilder.FormTypes.FormButton Create()
    {
        var formButtonResult = CreateFormButton();
        factoryAction?.Invoke(formButtonResult);

        return formButtonResult;
    }

    private Humidifier.AmplifyUIBuilder.FormTypes.FormButton CreateFormButton()
    {
        var formButtonResult = new Humidifier.AmplifyUIBuilder.FormTypes.FormButton();

        return formButtonResult;
    }
    public override void CreateChildren(Humidifier.AmplifyUIBuilder.FormTypes.FormButton result)
    {
        base.CreateChildren(result);

        result.Position ??= PositionFactory?.Build();
    }

} // End Of Class

public static class InnerFormFormButtonFactoryExtensions
{
    public static CombinedResult<InnerFormFormButtonFactory, InnerFormFieldPositionFactory> WithPosition(this InnerFormFormButtonFactory parentFactory, Action<Humidifier.AmplifyUIBuilder.FormTypes.FieldPosition> subFactoryAction = null)
    {
        parentFactory.PositionFactory = new InnerFormFieldPositionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.PositionFactory);
    }

    public static CombinedResult<InnerFormFormButtonFactory, T1, InnerFormFieldPositionFactory> WithPosition<T1>(this CombinedResult<InnerFormFormButtonFactory, T1> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FieldPosition> subFactoryAction = null) => new (combinedResult, combinedResult, WithPosition(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFormFormButtonFactory, InnerFormFieldPositionFactory> WithPosition<T1>(this CombinedResult<T1, InnerFormFormButtonFactory> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FieldPosition> subFactoryAction = null) => new (combinedResult, combinedResult, WithPosition(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerFormFormButtonFactory, T1, T2, InnerFormFieldPositionFactory> WithPosition<T1, T2>(this CombinedResult<InnerFormFormButtonFactory, T1, T2> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FieldPosition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPosition(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFormFormButtonFactory, T2, InnerFormFieldPositionFactory> WithPosition<T1, T2>(this CombinedResult<T1, InnerFormFormButtonFactory, T2> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FieldPosition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPosition(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFormFormButtonFactory, InnerFormFieldPositionFactory> WithPosition<T1, T2>(this CombinedResult<T1, T2, InnerFormFormButtonFactory> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FieldPosition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPosition(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerFormFormButtonFactory, T1, T2, T3, InnerFormFieldPositionFactory> WithPosition<T1, T2, T3>(this CombinedResult<InnerFormFormButtonFactory, T1, T2, T3> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FieldPosition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPosition(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFormFormButtonFactory, T2, T3, InnerFormFieldPositionFactory> WithPosition<T1, T2, T3>(this CombinedResult<T1, InnerFormFormButtonFactory, T2, T3> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FieldPosition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPosition(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFormFormButtonFactory, T3, InnerFormFieldPositionFactory> WithPosition<T1, T2, T3>(this CombinedResult<T1, T2, InnerFormFormButtonFactory, T3> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FieldPosition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPosition(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFormFormButtonFactory, InnerFormFieldPositionFactory> WithPosition<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerFormFormButtonFactory> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FieldPosition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPosition(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerFormFormButtonFactory, T1, T2, T3, T4, InnerFormFieldPositionFactory> WithPosition<T1, T2, T3, T4>(this CombinedResult<InnerFormFormButtonFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FieldPosition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPosition(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFormFormButtonFactory, T2, T3, T4, InnerFormFieldPositionFactory> WithPosition<T1, T2, T3, T4>(this CombinedResult<T1, InnerFormFormButtonFactory, T2, T3, T4> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FieldPosition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPosition(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFormFormButtonFactory, T3, T4, InnerFormFieldPositionFactory> WithPosition<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerFormFormButtonFactory, T3, T4> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FieldPosition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPosition(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFormFormButtonFactory, T4, InnerFormFieldPositionFactory> WithPosition<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerFormFormButtonFactory, T4> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FieldPosition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPosition(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerFormFormButtonFactory, InnerFormFieldPositionFactory> WithPosition<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerFormFormButtonFactory> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FieldPosition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPosition(combinedResult.T5, subFactoryAction));
}
