// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AmplifyUIBuilder;

public class InnerFormFormStyleFactory(Action<Humidifier.AmplifyUIBuilder.FormTypes.FormStyle> factoryAction = null) : SubResourceFactory<Humidifier.AmplifyUIBuilder.FormTypes.FormStyle>
{

    internal InnerFormFormStyleConfigFactory VerticalGapFactory { get; set; }

    internal InnerFormFormStyleConfigFactory OuterPaddingFactory { get; set; }

    internal InnerFormFormStyleConfigFactory HorizontalGapFactory { get; set; }

    protected override Humidifier.AmplifyUIBuilder.FormTypes.FormStyle Create()
    {
        var formStyleResult = CreateFormStyle();
        factoryAction?.Invoke(formStyleResult);

        return formStyleResult;
    }

    private Humidifier.AmplifyUIBuilder.FormTypes.FormStyle CreateFormStyle()
    {
        var formStyleResult = new Humidifier.AmplifyUIBuilder.FormTypes.FormStyle();

        return formStyleResult;
    }
    public override void CreateChildren(Humidifier.AmplifyUIBuilder.FormTypes.FormStyle result)
    {
        base.CreateChildren(result);

        result.VerticalGap ??= VerticalGapFactory?.Build();
        result.OuterPadding ??= OuterPaddingFactory?.Build();
        result.HorizontalGap ??= HorizontalGapFactory?.Build();
    }

} // End Of Class

public static class InnerFormFormStyleFactoryExtensions
{
    public static CombinedResult<InnerFormFormStyleFactory, InnerFormFormStyleConfigFactory> WithVerticalGap(this InnerFormFormStyleFactory parentFactory, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormStyleConfig> subFactoryAction = null)
    {
        parentFactory.VerticalGapFactory = new InnerFormFormStyleConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.VerticalGapFactory);
    }

    public static CombinedResult<InnerFormFormStyleFactory, InnerFormFormStyleConfigFactory> WithOuterPadding(this InnerFormFormStyleFactory parentFactory, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormStyleConfig> subFactoryAction = null)
    {
        parentFactory.OuterPaddingFactory = new InnerFormFormStyleConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.OuterPaddingFactory);
    }

    public static CombinedResult<InnerFormFormStyleFactory, InnerFormFormStyleConfigFactory> WithHorizontalGap(this InnerFormFormStyleFactory parentFactory, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormStyleConfig> subFactoryAction = null)
    {
        parentFactory.HorizontalGapFactory = new InnerFormFormStyleConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.HorizontalGapFactory);
    }

    public static CombinedResult<InnerFormFormStyleFactory, T1, InnerFormFormStyleConfigFactory> WithVerticalGap<T1>(this CombinedResult<InnerFormFormStyleFactory, T1> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormStyleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithVerticalGap(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFormFormStyleFactory, InnerFormFormStyleConfigFactory> WithVerticalGap<T1>(this CombinedResult<T1, InnerFormFormStyleFactory> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormStyleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithVerticalGap(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerFormFormStyleFactory, T1, T2, InnerFormFormStyleConfigFactory> WithVerticalGap<T1, T2>(this CombinedResult<InnerFormFormStyleFactory, T1, T2> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormStyleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVerticalGap(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFormFormStyleFactory, T2, InnerFormFormStyleConfigFactory> WithVerticalGap<T1, T2>(this CombinedResult<T1, InnerFormFormStyleFactory, T2> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormStyleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVerticalGap(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFormFormStyleFactory, InnerFormFormStyleConfigFactory> WithVerticalGap<T1, T2>(this CombinedResult<T1, T2, InnerFormFormStyleFactory> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormStyleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVerticalGap(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerFormFormStyleFactory, T1, T2, T3, InnerFormFormStyleConfigFactory> WithVerticalGap<T1, T2, T3>(this CombinedResult<InnerFormFormStyleFactory, T1, T2, T3> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormStyleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVerticalGap(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFormFormStyleFactory, T2, T3, InnerFormFormStyleConfigFactory> WithVerticalGap<T1, T2, T3>(this CombinedResult<T1, InnerFormFormStyleFactory, T2, T3> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormStyleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVerticalGap(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFormFormStyleFactory, T3, InnerFormFormStyleConfigFactory> WithVerticalGap<T1, T2, T3>(this CombinedResult<T1, T2, InnerFormFormStyleFactory, T3> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormStyleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVerticalGap(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFormFormStyleFactory, InnerFormFormStyleConfigFactory> WithVerticalGap<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerFormFormStyleFactory> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormStyleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVerticalGap(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerFormFormStyleFactory, T1, T2, T3, T4, InnerFormFormStyleConfigFactory> WithVerticalGap<T1, T2, T3, T4>(this CombinedResult<InnerFormFormStyleFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormStyleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVerticalGap(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFormFormStyleFactory, T2, T3, T4, InnerFormFormStyleConfigFactory> WithVerticalGap<T1, T2, T3, T4>(this CombinedResult<T1, InnerFormFormStyleFactory, T2, T3, T4> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormStyleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVerticalGap(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFormFormStyleFactory, T3, T4, InnerFormFormStyleConfigFactory> WithVerticalGap<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerFormFormStyleFactory, T3, T4> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormStyleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVerticalGap(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFormFormStyleFactory, T4, InnerFormFormStyleConfigFactory> WithVerticalGap<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerFormFormStyleFactory, T4> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormStyleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVerticalGap(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerFormFormStyleFactory, InnerFormFormStyleConfigFactory> WithVerticalGap<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerFormFormStyleFactory> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormStyleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVerticalGap(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerFormFormStyleFactory, T1, InnerFormFormStyleConfigFactory> WithOuterPadding<T1>(this CombinedResult<InnerFormFormStyleFactory, T1> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormStyleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithOuterPadding(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFormFormStyleFactory, InnerFormFormStyleConfigFactory> WithOuterPadding<T1>(this CombinedResult<T1, InnerFormFormStyleFactory> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormStyleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithOuterPadding(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerFormFormStyleFactory, T1, T2, InnerFormFormStyleConfigFactory> WithOuterPadding<T1, T2>(this CombinedResult<InnerFormFormStyleFactory, T1, T2> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormStyleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOuterPadding(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFormFormStyleFactory, T2, InnerFormFormStyleConfigFactory> WithOuterPadding<T1, T2>(this CombinedResult<T1, InnerFormFormStyleFactory, T2> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormStyleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOuterPadding(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFormFormStyleFactory, InnerFormFormStyleConfigFactory> WithOuterPadding<T1, T2>(this CombinedResult<T1, T2, InnerFormFormStyleFactory> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormStyleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOuterPadding(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerFormFormStyleFactory, T1, T2, T3, InnerFormFormStyleConfigFactory> WithOuterPadding<T1, T2, T3>(this CombinedResult<InnerFormFormStyleFactory, T1, T2, T3> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormStyleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOuterPadding(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFormFormStyleFactory, T2, T3, InnerFormFormStyleConfigFactory> WithOuterPadding<T1, T2, T3>(this CombinedResult<T1, InnerFormFormStyleFactory, T2, T3> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormStyleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOuterPadding(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFormFormStyleFactory, T3, InnerFormFormStyleConfigFactory> WithOuterPadding<T1, T2, T3>(this CombinedResult<T1, T2, InnerFormFormStyleFactory, T3> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormStyleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOuterPadding(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFormFormStyleFactory, InnerFormFormStyleConfigFactory> WithOuterPadding<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerFormFormStyleFactory> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormStyleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOuterPadding(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerFormFormStyleFactory, T1, T2, T3, T4, InnerFormFormStyleConfigFactory> WithOuterPadding<T1, T2, T3, T4>(this CombinedResult<InnerFormFormStyleFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormStyleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOuterPadding(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFormFormStyleFactory, T2, T3, T4, InnerFormFormStyleConfigFactory> WithOuterPadding<T1, T2, T3, T4>(this CombinedResult<T1, InnerFormFormStyleFactory, T2, T3, T4> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormStyleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOuterPadding(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFormFormStyleFactory, T3, T4, InnerFormFormStyleConfigFactory> WithOuterPadding<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerFormFormStyleFactory, T3, T4> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormStyleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOuterPadding(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFormFormStyleFactory, T4, InnerFormFormStyleConfigFactory> WithOuterPadding<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerFormFormStyleFactory, T4> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormStyleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOuterPadding(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerFormFormStyleFactory, InnerFormFormStyleConfigFactory> WithOuterPadding<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerFormFormStyleFactory> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormStyleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOuterPadding(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerFormFormStyleFactory, T1, InnerFormFormStyleConfigFactory> WithHorizontalGap<T1>(this CombinedResult<InnerFormFormStyleFactory, T1> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormStyleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithHorizontalGap(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFormFormStyleFactory, InnerFormFormStyleConfigFactory> WithHorizontalGap<T1>(this CombinedResult<T1, InnerFormFormStyleFactory> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormStyleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithHorizontalGap(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerFormFormStyleFactory, T1, T2, InnerFormFormStyleConfigFactory> WithHorizontalGap<T1, T2>(this CombinedResult<InnerFormFormStyleFactory, T1, T2> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormStyleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHorizontalGap(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFormFormStyleFactory, T2, InnerFormFormStyleConfigFactory> WithHorizontalGap<T1, T2>(this CombinedResult<T1, InnerFormFormStyleFactory, T2> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormStyleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHorizontalGap(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFormFormStyleFactory, InnerFormFormStyleConfigFactory> WithHorizontalGap<T1, T2>(this CombinedResult<T1, T2, InnerFormFormStyleFactory> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormStyleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHorizontalGap(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerFormFormStyleFactory, T1, T2, T3, InnerFormFormStyleConfigFactory> WithHorizontalGap<T1, T2, T3>(this CombinedResult<InnerFormFormStyleFactory, T1, T2, T3> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormStyleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHorizontalGap(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFormFormStyleFactory, T2, T3, InnerFormFormStyleConfigFactory> WithHorizontalGap<T1, T2, T3>(this CombinedResult<T1, InnerFormFormStyleFactory, T2, T3> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormStyleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHorizontalGap(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFormFormStyleFactory, T3, InnerFormFormStyleConfigFactory> WithHorizontalGap<T1, T2, T3>(this CombinedResult<T1, T2, InnerFormFormStyleFactory, T3> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormStyleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHorizontalGap(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFormFormStyleFactory, InnerFormFormStyleConfigFactory> WithHorizontalGap<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerFormFormStyleFactory> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormStyleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHorizontalGap(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerFormFormStyleFactory, T1, T2, T3, T4, InnerFormFormStyleConfigFactory> WithHorizontalGap<T1, T2, T3, T4>(this CombinedResult<InnerFormFormStyleFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormStyleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHorizontalGap(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFormFormStyleFactory, T2, T3, T4, InnerFormFormStyleConfigFactory> WithHorizontalGap<T1, T2, T3, T4>(this CombinedResult<T1, InnerFormFormStyleFactory, T2, T3, T4> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormStyleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHorizontalGap(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFormFormStyleFactory, T3, T4, InnerFormFormStyleConfigFactory> WithHorizontalGap<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerFormFormStyleFactory, T3, T4> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormStyleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHorizontalGap(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFormFormStyleFactory, T4, InnerFormFormStyleConfigFactory> WithHorizontalGap<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerFormFormStyleFactory, T4> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormStyleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHorizontalGap(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerFormFormStyleFactory, InnerFormFormStyleConfigFactory> WithHorizontalGap<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerFormFormStyleFactory> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormStyleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHorizontalGap(combinedResult.T5, subFactoryAction));
}
