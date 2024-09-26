// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AmplifyUIBuilder;

public class InnerFormFormCTAFactory(Action<Humidifier.AmplifyUIBuilder.FormTypes.FormCTA> factoryAction = null) : SubResourceFactory<Humidifier.AmplifyUIBuilder.FormTypes.FormCTA>
{

    internal InnerFormFormButtonFactory CancelFactory { get; set; }

    internal InnerFormFormButtonFactory SubmitFactory { get; set; }

    internal InnerFormFormButtonFactory ClearFactory { get; set; }

    protected override Humidifier.AmplifyUIBuilder.FormTypes.FormCTA Create()
    {
        var formCTAResult = CreateFormCTA();
        factoryAction?.Invoke(formCTAResult);

        return formCTAResult;
    }

    private Humidifier.AmplifyUIBuilder.FormTypes.FormCTA CreateFormCTA()
    {
        var formCTAResult = new Humidifier.AmplifyUIBuilder.FormTypes.FormCTA();

        return formCTAResult;
    }
    public override void CreateChildren(Humidifier.AmplifyUIBuilder.FormTypes.FormCTA result)
    {
        base.CreateChildren(result);

        result.Cancel ??= CancelFactory?.Build();
        result.Submit ??= SubmitFactory?.Build();
        result.Clear ??= ClearFactory?.Build();
    }

} // End Of Class

public static class InnerFormFormCTAFactoryExtensions
{
    public static CombinedResult<InnerFormFormCTAFactory, InnerFormFormButtonFactory> WithCancel(this InnerFormFormCTAFactory parentFactory, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormButton> subFactoryAction = null)
    {
        parentFactory.CancelFactory = new InnerFormFormButtonFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CancelFactory);
    }

    public static CombinedResult<InnerFormFormCTAFactory, InnerFormFormButtonFactory> WithSubmit(this InnerFormFormCTAFactory parentFactory, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormButton> subFactoryAction = null)
    {
        parentFactory.SubmitFactory = new InnerFormFormButtonFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SubmitFactory);
    }

    public static CombinedResult<InnerFormFormCTAFactory, InnerFormFormButtonFactory> WithClear(this InnerFormFormCTAFactory parentFactory, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormButton> subFactoryAction = null)
    {
        parentFactory.ClearFactory = new InnerFormFormButtonFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ClearFactory);
    }

    public static CombinedResult<InnerFormFormCTAFactory, T1, InnerFormFormButtonFactory> WithCancel<T1>(this CombinedResult<InnerFormFormCTAFactory, T1> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormButton> subFactoryAction = null) => new (combinedResult, combinedResult, WithCancel(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFormFormCTAFactory, InnerFormFormButtonFactory> WithCancel<T1>(this CombinedResult<T1, InnerFormFormCTAFactory> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormButton> subFactoryAction = null) => new (combinedResult, combinedResult, WithCancel(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerFormFormCTAFactory, T1, T2, InnerFormFormButtonFactory> WithCancel<T1, T2>(this CombinedResult<InnerFormFormCTAFactory, T1, T2> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormButton> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCancel(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFormFormCTAFactory, T2, InnerFormFormButtonFactory> WithCancel<T1, T2>(this CombinedResult<T1, InnerFormFormCTAFactory, T2> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormButton> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCancel(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFormFormCTAFactory, InnerFormFormButtonFactory> WithCancel<T1, T2>(this CombinedResult<T1, T2, InnerFormFormCTAFactory> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormButton> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCancel(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerFormFormCTAFactory, T1, T2, T3, InnerFormFormButtonFactory> WithCancel<T1, T2, T3>(this CombinedResult<InnerFormFormCTAFactory, T1, T2, T3> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormButton> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCancel(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFormFormCTAFactory, T2, T3, InnerFormFormButtonFactory> WithCancel<T1, T2, T3>(this CombinedResult<T1, InnerFormFormCTAFactory, T2, T3> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormButton> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCancel(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFormFormCTAFactory, T3, InnerFormFormButtonFactory> WithCancel<T1, T2, T3>(this CombinedResult<T1, T2, InnerFormFormCTAFactory, T3> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormButton> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCancel(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFormFormCTAFactory, InnerFormFormButtonFactory> WithCancel<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerFormFormCTAFactory> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormButton> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCancel(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerFormFormCTAFactory, T1, T2, T3, T4, InnerFormFormButtonFactory> WithCancel<T1, T2, T3, T4>(this CombinedResult<InnerFormFormCTAFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormButton> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCancel(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFormFormCTAFactory, T2, T3, T4, InnerFormFormButtonFactory> WithCancel<T1, T2, T3, T4>(this CombinedResult<T1, InnerFormFormCTAFactory, T2, T3, T4> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormButton> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCancel(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFormFormCTAFactory, T3, T4, InnerFormFormButtonFactory> WithCancel<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerFormFormCTAFactory, T3, T4> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormButton> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCancel(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFormFormCTAFactory, T4, InnerFormFormButtonFactory> WithCancel<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerFormFormCTAFactory, T4> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormButton> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCancel(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerFormFormCTAFactory, InnerFormFormButtonFactory> WithCancel<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerFormFormCTAFactory> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormButton> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCancel(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerFormFormCTAFactory, T1, InnerFormFormButtonFactory> WithSubmit<T1>(this CombinedResult<InnerFormFormCTAFactory, T1> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormButton> subFactoryAction = null) => new (combinedResult, combinedResult, WithSubmit(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFormFormCTAFactory, InnerFormFormButtonFactory> WithSubmit<T1>(this CombinedResult<T1, InnerFormFormCTAFactory> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormButton> subFactoryAction = null) => new (combinedResult, combinedResult, WithSubmit(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerFormFormCTAFactory, T1, T2, InnerFormFormButtonFactory> WithSubmit<T1, T2>(this CombinedResult<InnerFormFormCTAFactory, T1, T2> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormButton> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSubmit(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFormFormCTAFactory, T2, InnerFormFormButtonFactory> WithSubmit<T1, T2>(this CombinedResult<T1, InnerFormFormCTAFactory, T2> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormButton> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSubmit(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFormFormCTAFactory, InnerFormFormButtonFactory> WithSubmit<T1, T2>(this CombinedResult<T1, T2, InnerFormFormCTAFactory> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormButton> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSubmit(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerFormFormCTAFactory, T1, T2, T3, InnerFormFormButtonFactory> WithSubmit<T1, T2, T3>(this CombinedResult<InnerFormFormCTAFactory, T1, T2, T3> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormButton> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSubmit(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFormFormCTAFactory, T2, T3, InnerFormFormButtonFactory> WithSubmit<T1, T2, T3>(this CombinedResult<T1, InnerFormFormCTAFactory, T2, T3> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormButton> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSubmit(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFormFormCTAFactory, T3, InnerFormFormButtonFactory> WithSubmit<T1, T2, T3>(this CombinedResult<T1, T2, InnerFormFormCTAFactory, T3> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormButton> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSubmit(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFormFormCTAFactory, InnerFormFormButtonFactory> WithSubmit<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerFormFormCTAFactory> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormButton> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSubmit(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerFormFormCTAFactory, T1, T2, T3, T4, InnerFormFormButtonFactory> WithSubmit<T1, T2, T3, T4>(this CombinedResult<InnerFormFormCTAFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormButton> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSubmit(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFormFormCTAFactory, T2, T3, T4, InnerFormFormButtonFactory> WithSubmit<T1, T2, T3, T4>(this CombinedResult<T1, InnerFormFormCTAFactory, T2, T3, T4> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormButton> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSubmit(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFormFormCTAFactory, T3, T4, InnerFormFormButtonFactory> WithSubmit<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerFormFormCTAFactory, T3, T4> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormButton> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSubmit(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFormFormCTAFactory, T4, InnerFormFormButtonFactory> WithSubmit<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerFormFormCTAFactory, T4> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormButton> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSubmit(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerFormFormCTAFactory, InnerFormFormButtonFactory> WithSubmit<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerFormFormCTAFactory> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormButton> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSubmit(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerFormFormCTAFactory, T1, InnerFormFormButtonFactory> WithClear<T1>(this CombinedResult<InnerFormFormCTAFactory, T1> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormButton> subFactoryAction = null) => new (combinedResult, combinedResult, WithClear(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFormFormCTAFactory, InnerFormFormButtonFactory> WithClear<T1>(this CombinedResult<T1, InnerFormFormCTAFactory> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormButton> subFactoryAction = null) => new (combinedResult, combinedResult, WithClear(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerFormFormCTAFactory, T1, T2, InnerFormFormButtonFactory> WithClear<T1, T2>(this CombinedResult<InnerFormFormCTAFactory, T1, T2> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormButton> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithClear(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFormFormCTAFactory, T2, InnerFormFormButtonFactory> WithClear<T1, T2>(this CombinedResult<T1, InnerFormFormCTAFactory, T2> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormButton> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithClear(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFormFormCTAFactory, InnerFormFormButtonFactory> WithClear<T1, T2>(this CombinedResult<T1, T2, InnerFormFormCTAFactory> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormButton> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithClear(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerFormFormCTAFactory, T1, T2, T3, InnerFormFormButtonFactory> WithClear<T1, T2, T3>(this CombinedResult<InnerFormFormCTAFactory, T1, T2, T3> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormButton> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithClear(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFormFormCTAFactory, T2, T3, InnerFormFormButtonFactory> WithClear<T1, T2, T3>(this CombinedResult<T1, InnerFormFormCTAFactory, T2, T3> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormButton> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithClear(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFormFormCTAFactory, T3, InnerFormFormButtonFactory> WithClear<T1, T2, T3>(this CombinedResult<T1, T2, InnerFormFormCTAFactory, T3> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormButton> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithClear(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFormFormCTAFactory, InnerFormFormButtonFactory> WithClear<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerFormFormCTAFactory> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormButton> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithClear(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerFormFormCTAFactory, T1, T2, T3, T4, InnerFormFormButtonFactory> WithClear<T1, T2, T3, T4>(this CombinedResult<InnerFormFormCTAFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormButton> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithClear(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFormFormCTAFactory, T2, T3, T4, InnerFormFormButtonFactory> WithClear<T1, T2, T3, T4>(this CombinedResult<T1, InnerFormFormCTAFactory, T2, T3, T4> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormButton> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithClear(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFormFormCTAFactory, T3, T4, InnerFormFormButtonFactory> WithClear<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerFormFormCTAFactory, T3, T4> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormButton> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithClear(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFormFormCTAFactory, T4, InnerFormFormButtonFactory> WithClear<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerFormFormCTAFactory, T4> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormButton> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithClear(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerFormFormCTAFactory, InnerFormFormButtonFactory> WithClear<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerFormFormCTAFactory> combinedResult, Action<Humidifier.AmplifyUIBuilder.FormTypes.FormButton> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithClear(combinedResult.T5, subFactoryAction));
}
