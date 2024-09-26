// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppTest;

public class InnerTestCaseStepFactory(Action<Humidifier.AppTest.TestCaseTypes.Step> factoryAction = null) : SubResourceFactory<Humidifier.AppTest.TestCaseTypes.Step>
{

    internal InnerTestCaseStepActionFactory ActionFactory { get; set; }

    protected override Humidifier.AppTest.TestCaseTypes.Step Create()
    {
        var stepResult = CreateStep();
        factoryAction?.Invoke(stepResult);

        return stepResult;
    }

    private Humidifier.AppTest.TestCaseTypes.Step CreateStep()
    {
        var stepResult = new Humidifier.AppTest.TestCaseTypes.Step();

        return stepResult;
    }
    public override void CreateChildren(Humidifier.AppTest.TestCaseTypes.Step result)
    {
        base.CreateChildren(result);

        result.Action ??= ActionFactory?.Build();
    }

} // End Of Class

public static class InnerTestCaseStepFactoryExtensions
{
    public static CombinedResult<InnerTestCaseStepFactory, InnerTestCaseStepActionFactory> WithAction(this InnerTestCaseStepFactory parentFactory, Action<Humidifier.AppTest.TestCaseTypes.StepAction> subFactoryAction = null)
    {
        parentFactory.ActionFactory = new InnerTestCaseStepActionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ActionFactory);
    }

    public static CombinedResult<InnerTestCaseStepFactory, T1, InnerTestCaseStepActionFactory> WithAction<T1>(this CombinedResult<InnerTestCaseStepFactory, T1> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.StepAction> subFactoryAction = null) => new (combinedResult, combinedResult, WithAction(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTestCaseStepFactory, InnerTestCaseStepActionFactory> WithAction<T1>(this CombinedResult<T1, InnerTestCaseStepFactory> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.StepAction> subFactoryAction = null) => new (combinedResult, combinedResult, WithAction(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerTestCaseStepFactory, T1, T2, InnerTestCaseStepActionFactory> WithAction<T1, T2>(this CombinedResult<InnerTestCaseStepFactory, T1, T2> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.StepAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTestCaseStepFactory, T2, InnerTestCaseStepActionFactory> WithAction<T1, T2>(this CombinedResult<T1, InnerTestCaseStepFactory, T2> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.StepAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTestCaseStepFactory, InnerTestCaseStepActionFactory> WithAction<T1, T2>(this CombinedResult<T1, T2, InnerTestCaseStepFactory> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.StepAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerTestCaseStepFactory, T1, T2, T3, InnerTestCaseStepActionFactory> WithAction<T1, T2, T3>(this CombinedResult<InnerTestCaseStepFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.StepAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTestCaseStepFactory, T2, T3, InnerTestCaseStepActionFactory> WithAction<T1, T2, T3>(this CombinedResult<T1, InnerTestCaseStepFactory, T2, T3> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.StepAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTestCaseStepFactory, T3, InnerTestCaseStepActionFactory> WithAction<T1, T2, T3>(this CombinedResult<T1, T2, InnerTestCaseStepFactory, T3> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.StepAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTestCaseStepFactory, InnerTestCaseStepActionFactory> WithAction<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerTestCaseStepFactory> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.StepAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerTestCaseStepFactory, T1, T2, T3, T4, InnerTestCaseStepActionFactory> WithAction<T1, T2, T3, T4>(this CombinedResult<InnerTestCaseStepFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.StepAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTestCaseStepFactory, T2, T3, T4, InnerTestCaseStepActionFactory> WithAction<T1, T2, T3, T4>(this CombinedResult<T1, InnerTestCaseStepFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.StepAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTestCaseStepFactory, T3, T4, InnerTestCaseStepActionFactory> WithAction<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerTestCaseStepFactory, T3, T4> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.StepAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTestCaseStepFactory, T4, InnerTestCaseStepActionFactory> WithAction<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerTestCaseStepFactory, T4> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.StepAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerTestCaseStepFactory, InnerTestCaseStepActionFactory> WithAction<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerTestCaseStepFactory> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.StepAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T5, subFactoryAction));
}
