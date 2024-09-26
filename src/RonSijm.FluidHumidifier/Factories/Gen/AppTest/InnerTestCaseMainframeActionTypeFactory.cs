// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppTest;

public class InnerTestCaseMainframeActionTypeFactory(Action<Humidifier.AppTest.TestCaseTypes.MainframeActionType> factoryAction = null) : SubResourceFactory<Humidifier.AppTest.TestCaseTypes.MainframeActionType>
{

    internal InnerTestCaseBatchFactory BatchFactory { get; set; }

    internal InnerTestCaseTN3270Factory Tn3270Factory { get; set; }

    protected override Humidifier.AppTest.TestCaseTypes.MainframeActionType Create()
    {
        var mainframeActionTypeResult = CreateMainframeActionType();
        factoryAction?.Invoke(mainframeActionTypeResult);

        return mainframeActionTypeResult;
    }

    private Humidifier.AppTest.TestCaseTypes.MainframeActionType CreateMainframeActionType()
    {
        var mainframeActionTypeResult = new Humidifier.AppTest.TestCaseTypes.MainframeActionType();

        return mainframeActionTypeResult;
    }
    public override void CreateChildren(Humidifier.AppTest.TestCaseTypes.MainframeActionType result)
    {
        base.CreateChildren(result);

        result.Batch ??= BatchFactory?.Build();
        result.Tn3270 ??= Tn3270Factory?.Build();
    }

} // End Of Class

public static class InnerTestCaseMainframeActionTypeFactoryExtensions
{
    public static CombinedResult<InnerTestCaseMainframeActionTypeFactory, InnerTestCaseBatchFactory> WithBatch(this InnerTestCaseMainframeActionTypeFactory parentFactory, Action<Humidifier.AppTest.TestCaseTypes.Batch> subFactoryAction = null)
    {
        parentFactory.BatchFactory = new InnerTestCaseBatchFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.BatchFactory);
    }

    public static CombinedResult<InnerTestCaseMainframeActionTypeFactory, InnerTestCaseTN3270Factory> WithTn3270(this InnerTestCaseMainframeActionTypeFactory parentFactory, Action<Humidifier.AppTest.TestCaseTypes.TN3270> subFactoryAction = null)
    {
        parentFactory.Tn3270Factory = new InnerTestCaseTN3270Factory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.Tn3270Factory);
    }

    public static CombinedResult<InnerTestCaseMainframeActionTypeFactory, T1, InnerTestCaseBatchFactory> WithBatch<T1>(this CombinedResult<InnerTestCaseMainframeActionTypeFactory, T1> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.Batch> subFactoryAction = null) => new (combinedResult, combinedResult, WithBatch(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTestCaseMainframeActionTypeFactory, InnerTestCaseBatchFactory> WithBatch<T1>(this CombinedResult<T1, InnerTestCaseMainframeActionTypeFactory> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.Batch> subFactoryAction = null) => new (combinedResult, combinedResult, WithBatch(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerTestCaseMainframeActionTypeFactory, T1, T2, InnerTestCaseBatchFactory> WithBatch<T1, T2>(this CombinedResult<InnerTestCaseMainframeActionTypeFactory, T1, T2> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.Batch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBatch(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTestCaseMainframeActionTypeFactory, T2, InnerTestCaseBatchFactory> WithBatch<T1, T2>(this CombinedResult<T1, InnerTestCaseMainframeActionTypeFactory, T2> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.Batch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBatch(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTestCaseMainframeActionTypeFactory, InnerTestCaseBatchFactory> WithBatch<T1, T2>(this CombinedResult<T1, T2, InnerTestCaseMainframeActionTypeFactory> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.Batch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBatch(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerTestCaseMainframeActionTypeFactory, T1, T2, T3, InnerTestCaseBatchFactory> WithBatch<T1, T2, T3>(this CombinedResult<InnerTestCaseMainframeActionTypeFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.Batch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBatch(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTestCaseMainframeActionTypeFactory, T2, T3, InnerTestCaseBatchFactory> WithBatch<T1, T2, T3>(this CombinedResult<T1, InnerTestCaseMainframeActionTypeFactory, T2, T3> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.Batch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBatch(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTestCaseMainframeActionTypeFactory, T3, InnerTestCaseBatchFactory> WithBatch<T1, T2, T3>(this CombinedResult<T1, T2, InnerTestCaseMainframeActionTypeFactory, T3> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.Batch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBatch(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTestCaseMainframeActionTypeFactory, InnerTestCaseBatchFactory> WithBatch<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerTestCaseMainframeActionTypeFactory> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.Batch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBatch(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerTestCaseMainframeActionTypeFactory, T1, T2, T3, T4, InnerTestCaseBatchFactory> WithBatch<T1, T2, T3, T4>(this CombinedResult<InnerTestCaseMainframeActionTypeFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.Batch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBatch(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTestCaseMainframeActionTypeFactory, T2, T3, T4, InnerTestCaseBatchFactory> WithBatch<T1, T2, T3, T4>(this CombinedResult<T1, InnerTestCaseMainframeActionTypeFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.Batch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBatch(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTestCaseMainframeActionTypeFactory, T3, T4, InnerTestCaseBatchFactory> WithBatch<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerTestCaseMainframeActionTypeFactory, T3, T4> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.Batch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBatch(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTestCaseMainframeActionTypeFactory, T4, InnerTestCaseBatchFactory> WithBatch<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerTestCaseMainframeActionTypeFactory, T4> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.Batch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBatch(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerTestCaseMainframeActionTypeFactory, InnerTestCaseBatchFactory> WithBatch<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerTestCaseMainframeActionTypeFactory> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.Batch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBatch(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerTestCaseMainframeActionTypeFactory, T1, InnerTestCaseTN3270Factory> WithTn3270<T1>(this CombinedResult<InnerTestCaseMainframeActionTypeFactory, T1> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.TN3270> subFactoryAction = null) => new (combinedResult, combinedResult, WithTn3270(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTestCaseMainframeActionTypeFactory, InnerTestCaseTN3270Factory> WithTn3270<T1>(this CombinedResult<T1, InnerTestCaseMainframeActionTypeFactory> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.TN3270> subFactoryAction = null) => new (combinedResult, combinedResult, WithTn3270(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerTestCaseMainframeActionTypeFactory, T1, T2, InnerTestCaseTN3270Factory> WithTn3270<T1, T2>(this CombinedResult<InnerTestCaseMainframeActionTypeFactory, T1, T2> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.TN3270> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTn3270(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTestCaseMainframeActionTypeFactory, T2, InnerTestCaseTN3270Factory> WithTn3270<T1, T2>(this CombinedResult<T1, InnerTestCaseMainframeActionTypeFactory, T2> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.TN3270> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTn3270(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTestCaseMainframeActionTypeFactory, InnerTestCaseTN3270Factory> WithTn3270<T1, T2>(this CombinedResult<T1, T2, InnerTestCaseMainframeActionTypeFactory> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.TN3270> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTn3270(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerTestCaseMainframeActionTypeFactory, T1, T2, T3, InnerTestCaseTN3270Factory> WithTn3270<T1, T2, T3>(this CombinedResult<InnerTestCaseMainframeActionTypeFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.TN3270> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTn3270(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTestCaseMainframeActionTypeFactory, T2, T3, InnerTestCaseTN3270Factory> WithTn3270<T1, T2, T3>(this CombinedResult<T1, InnerTestCaseMainframeActionTypeFactory, T2, T3> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.TN3270> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTn3270(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTestCaseMainframeActionTypeFactory, T3, InnerTestCaseTN3270Factory> WithTn3270<T1, T2, T3>(this CombinedResult<T1, T2, InnerTestCaseMainframeActionTypeFactory, T3> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.TN3270> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTn3270(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTestCaseMainframeActionTypeFactory, InnerTestCaseTN3270Factory> WithTn3270<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerTestCaseMainframeActionTypeFactory> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.TN3270> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTn3270(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerTestCaseMainframeActionTypeFactory, T1, T2, T3, T4, InnerTestCaseTN3270Factory> WithTn3270<T1, T2, T3, T4>(this CombinedResult<InnerTestCaseMainframeActionTypeFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.TN3270> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTn3270(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTestCaseMainframeActionTypeFactory, T2, T3, T4, InnerTestCaseTN3270Factory> WithTn3270<T1, T2, T3, T4>(this CombinedResult<T1, InnerTestCaseMainframeActionTypeFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.TN3270> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTn3270(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTestCaseMainframeActionTypeFactory, T3, T4, InnerTestCaseTN3270Factory> WithTn3270<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerTestCaseMainframeActionTypeFactory, T3, T4> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.TN3270> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTn3270(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTestCaseMainframeActionTypeFactory, T4, InnerTestCaseTN3270Factory> WithTn3270<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerTestCaseMainframeActionTypeFactory, T4> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.TN3270> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTn3270(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerTestCaseMainframeActionTypeFactory, InnerTestCaseTN3270Factory> WithTn3270<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerTestCaseMainframeActionTypeFactory> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.TN3270> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTn3270(combinedResult.T5, subFactoryAction));
}
