// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppTest;

public class InnerTestCaseCompareActionFactory(Action<Humidifier.AppTest.TestCaseTypes.CompareAction> factoryAction = null) : SubResourceFactory<Humidifier.AppTest.TestCaseTypes.CompareAction>
{

    internal InnerTestCaseInputFactory InputFactory { get; set; }

    internal InnerTestCaseOutputFactory OutputFactory { get; set; }

    protected override Humidifier.AppTest.TestCaseTypes.CompareAction Create()
    {
        var compareActionResult = CreateCompareAction();
        factoryAction?.Invoke(compareActionResult);

        return compareActionResult;
    }

    private Humidifier.AppTest.TestCaseTypes.CompareAction CreateCompareAction()
    {
        var compareActionResult = new Humidifier.AppTest.TestCaseTypes.CompareAction();

        return compareActionResult;
    }
    public override void CreateChildren(Humidifier.AppTest.TestCaseTypes.CompareAction result)
    {
        base.CreateChildren(result);

        result.Input ??= InputFactory?.Build();
        result.Output ??= OutputFactory?.Build();
    }

} // End Of Class

public static class InnerTestCaseCompareActionFactoryExtensions
{
    public static CombinedResult<InnerTestCaseCompareActionFactory, InnerTestCaseInputFactory> WithInput(this InnerTestCaseCompareActionFactory parentFactory, Action<Humidifier.AppTest.TestCaseTypes.Input> subFactoryAction = null)
    {
        parentFactory.InputFactory = new InnerTestCaseInputFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.InputFactory);
    }

    public static CombinedResult<InnerTestCaseCompareActionFactory, InnerTestCaseOutputFactory> WithOutput(this InnerTestCaseCompareActionFactory parentFactory, Action<Humidifier.AppTest.TestCaseTypes.Output> subFactoryAction = null)
    {
        parentFactory.OutputFactory = new InnerTestCaseOutputFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.OutputFactory);
    }

    public static CombinedResult<InnerTestCaseCompareActionFactory, T1, InnerTestCaseInputFactory> WithInput<T1>(this CombinedResult<InnerTestCaseCompareActionFactory, T1> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.Input> subFactoryAction = null) => new (combinedResult, combinedResult, WithInput(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTestCaseCompareActionFactory, InnerTestCaseInputFactory> WithInput<T1>(this CombinedResult<T1, InnerTestCaseCompareActionFactory> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.Input> subFactoryAction = null) => new (combinedResult, combinedResult, WithInput(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerTestCaseCompareActionFactory, T1, T2, InnerTestCaseInputFactory> WithInput<T1, T2>(this CombinedResult<InnerTestCaseCompareActionFactory, T1, T2> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.Input> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInput(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTestCaseCompareActionFactory, T2, InnerTestCaseInputFactory> WithInput<T1, T2>(this CombinedResult<T1, InnerTestCaseCompareActionFactory, T2> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.Input> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInput(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTestCaseCompareActionFactory, InnerTestCaseInputFactory> WithInput<T1, T2>(this CombinedResult<T1, T2, InnerTestCaseCompareActionFactory> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.Input> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInput(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerTestCaseCompareActionFactory, T1, T2, T3, InnerTestCaseInputFactory> WithInput<T1, T2, T3>(this CombinedResult<InnerTestCaseCompareActionFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.Input> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInput(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTestCaseCompareActionFactory, T2, T3, InnerTestCaseInputFactory> WithInput<T1, T2, T3>(this CombinedResult<T1, InnerTestCaseCompareActionFactory, T2, T3> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.Input> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInput(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTestCaseCompareActionFactory, T3, InnerTestCaseInputFactory> WithInput<T1, T2, T3>(this CombinedResult<T1, T2, InnerTestCaseCompareActionFactory, T3> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.Input> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInput(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTestCaseCompareActionFactory, InnerTestCaseInputFactory> WithInput<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerTestCaseCompareActionFactory> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.Input> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInput(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerTestCaseCompareActionFactory, T1, T2, T3, T4, InnerTestCaseInputFactory> WithInput<T1, T2, T3, T4>(this CombinedResult<InnerTestCaseCompareActionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.Input> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInput(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTestCaseCompareActionFactory, T2, T3, T4, InnerTestCaseInputFactory> WithInput<T1, T2, T3, T4>(this CombinedResult<T1, InnerTestCaseCompareActionFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.Input> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInput(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTestCaseCompareActionFactory, T3, T4, InnerTestCaseInputFactory> WithInput<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerTestCaseCompareActionFactory, T3, T4> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.Input> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInput(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTestCaseCompareActionFactory, T4, InnerTestCaseInputFactory> WithInput<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerTestCaseCompareActionFactory, T4> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.Input> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInput(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerTestCaseCompareActionFactory, InnerTestCaseInputFactory> WithInput<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerTestCaseCompareActionFactory> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.Input> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInput(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerTestCaseCompareActionFactory, T1, InnerTestCaseOutputFactory> WithOutput<T1>(this CombinedResult<InnerTestCaseCompareActionFactory, T1> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.Output> subFactoryAction = null) => new (combinedResult, combinedResult, WithOutput(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTestCaseCompareActionFactory, InnerTestCaseOutputFactory> WithOutput<T1>(this CombinedResult<T1, InnerTestCaseCompareActionFactory> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.Output> subFactoryAction = null) => new (combinedResult, combinedResult, WithOutput(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerTestCaseCompareActionFactory, T1, T2, InnerTestCaseOutputFactory> WithOutput<T1, T2>(this CombinedResult<InnerTestCaseCompareActionFactory, T1, T2> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.Output> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOutput(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTestCaseCompareActionFactory, T2, InnerTestCaseOutputFactory> WithOutput<T1, T2>(this CombinedResult<T1, InnerTestCaseCompareActionFactory, T2> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.Output> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOutput(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTestCaseCompareActionFactory, InnerTestCaseOutputFactory> WithOutput<T1, T2>(this CombinedResult<T1, T2, InnerTestCaseCompareActionFactory> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.Output> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOutput(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerTestCaseCompareActionFactory, T1, T2, T3, InnerTestCaseOutputFactory> WithOutput<T1, T2, T3>(this CombinedResult<InnerTestCaseCompareActionFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.Output> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOutput(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTestCaseCompareActionFactory, T2, T3, InnerTestCaseOutputFactory> WithOutput<T1, T2, T3>(this CombinedResult<T1, InnerTestCaseCompareActionFactory, T2, T3> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.Output> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOutput(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTestCaseCompareActionFactory, T3, InnerTestCaseOutputFactory> WithOutput<T1, T2, T3>(this CombinedResult<T1, T2, InnerTestCaseCompareActionFactory, T3> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.Output> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOutput(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTestCaseCompareActionFactory, InnerTestCaseOutputFactory> WithOutput<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerTestCaseCompareActionFactory> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.Output> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOutput(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerTestCaseCompareActionFactory, T1, T2, T3, T4, InnerTestCaseOutputFactory> WithOutput<T1, T2, T3, T4>(this CombinedResult<InnerTestCaseCompareActionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.Output> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOutput(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTestCaseCompareActionFactory, T2, T3, T4, InnerTestCaseOutputFactory> WithOutput<T1, T2, T3, T4>(this CombinedResult<T1, InnerTestCaseCompareActionFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.Output> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOutput(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTestCaseCompareActionFactory, T3, T4, InnerTestCaseOutputFactory> WithOutput<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerTestCaseCompareActionFactory, T3, T4> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.Output> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOutput(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTestCaseCompareActionFactory, T4, InnerTestCaseOutputFactory> WithOutput<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerTestCaseCompareActionFactory, T4> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.Output> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOutput(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerTestCaseCompareActionFactory, InnerTestCaseOutputFactory> WithOutput<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerTestCaseCompareActionFactory> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.Output> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOutput(combinedResult.T5, subFactoryAction));
}
