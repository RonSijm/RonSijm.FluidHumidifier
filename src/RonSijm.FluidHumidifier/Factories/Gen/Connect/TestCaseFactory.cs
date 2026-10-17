// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Connect;

public class TestCaseFactory(string resourceName = null, Action<Humidifier.Connect.TestCase> factoryAction = null) : ResourceFactory<Humidifier.Connect.TestCase>(resourceName)
{

    internal InnerTestCaseEntryPointFactory EntryPointFactory { get; set; }

    protected override Humidifier.Connect.TestCase Create()
    {
        var testCaseResult = CreateTestCase();
        factoryAction?.Invoke(testCaseResult);

        return testCaseResult;
    }

    private Humidifier.Connect.TestCase CreateTestCase()
    {
        var testCaseResult = new Humidifier.Connect.TestCase
        {
            GivenName = InputResourceName,
        };

        return testCaseResult;
    }
    public override void CreateChildren(Humidifier.Connect.TestCase result)
    {
        base.CreateChildren(result);

        result.EntryPoint ??= EntryPointFactory?.Build();
    }

} // End Of Class

public static class TestCaseFactoryExtensions
{
    public static CombinedResult<TestCaseFactory, InnerTestCaseEntryPointFactory> WithEntryPoint(this TestCaseFactory parentFactory, Action<Humidifier.Connect.TestCaseTypes.EntryPoint> subFactoryAction = null)
    {
        parentFactory.EntryPointFactory = new InnerTestCaseEntryPointFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EntryPointFactory);
    }

    public static CombinedResult<TestCaseFactory, T1, InnerTestCaseEntryPointFactory> WithEntryPoint<T1>(this CombinedResult<TestCaseFactory, T1> combinedResult, Action<Humidifier.Connect.TestCaseTypes.EntryPoint> subFactoryAction = null) => new (combinedResult, combinedResult, WithEntryPoint(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TestCaseFactory, InnerTestCaseEntryPointFactory> WithEntryPoint<T1>(this CombinedResult<T1, TestCaseFactory> combinedResult, Action<Humidifier.Connect.TestCaseTypes.EntryPoint> subFactoryAction = null) => new (combinedResult, combinedResult, WithEntryPoint(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<TestCaseFactory, T1, T2, InnerTestCaseEntryPointFactory> WithEntryPoint<T1, T2>(this CombinedResult<TestCaseFactory, T1, T2> combinedResult, Action<Humidifier.Connect.TestCaseTypes.EntryPoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEntryPoint(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TestCaseFactory, T2, InnerTestCaseEntryPointFactory> WithEntryPoint<T1, T2>(this CombinedResult<T1, TestCaseFactory, T2> combinedResult, Action<Humidifier.Connect.TestCaseTypes.EntryPoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEntryPoint(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, TestCaseFactory, InnerTestCaseEntryPointFactory> WithEntryPoint<T1, T2>(this CombinedResult<T1, T2, TestCaseFactory> combinedResult, Action<Humidifier.Connect.TestCaseTypes.EntryPoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEntryPoint(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<TestCaseFactory, T1, T2, T3, InnerTestCaseEntryPointFactory> WithEntryPoint<T1, T2, T3>(this CombinedResult<TestCaseFactory, T1, T2, T3> combinedResult, Action<Humidifier.Connect.TestCaseTypes.EntryPoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEntryPoint(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TestCaseFactory, T2, T3, InnerTestCaseEntryPointFactory> WithEntryPoint<T1, T2, T3>(this CombinedResult<T1, TestCaseFactory, T2, T3> combinedResult, Action<Humidifier.Connect.TestCaseTypes.EntryPoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEntryPoint(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, TestCaseFactory, T3, InnerTestCaseEntryPointFactory> WithEntryPoint<T1, T2, T3>(this CombinedResult<T1, T2, TestCaseFactory, T3> combinedResult, Action<Humidifier.Connect.TestCaseTypes.EntryPoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEntryPoint(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, TestCaseFactory, InnerTestCaseEntryPointFactory> WithEntryPoint<T1, T2, T3>(this CombinedResult<T1, T2, T3, TestCaseFactory> combinedResult, Action<Humidifier.Connect.TestCaseTypes.EntryPoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEntryPoint(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<TestCaseFactory, T1, T2, T3, T4, InnerTestCaseEntryPointFactory> WithEntryPoint<T1, T2, T3, T4>(this CombinedResult<TestCaseFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Connect.TestCaseTypes.EntryPoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEntryPoint(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TestCaseFactory, T2, T3, T4, InnerTestCaseEntryPointFactory> WithEntryPoint<T1, T2, T3, T4>(this CombinedResult<T1, TestCaseFactory, T2, T3, T4> combinedResult, Action<Humidifier.Connect.TestCaseTypes.EntryPoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEntryPoint(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, TestCaseFactory, T3, T4, InnerTestCaseEntryPointFactory> WithEntryPoint<T1, T2, T3, T4>(this CombinedResult<T1, T2, TestCaseFactory, T3, T4> combinedResult, Action<Humidifier.Connect.TestCaseTypes.EntryPoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEntryPoint(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, TestCaseFactory, T4, InnerTestCaseEntryPointFactory> WithEntryPoint<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, TestCaseFactory, T4> combinedResult, Action<Humidifier.Connect.TestCaseTypes.EntryPoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEntryPoint(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, TestCaseFactory, InnerTestCaseEntryPointFactory> WithEntryPoint<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, TestCaseFactory> combinedResult, Action<Humidifier.Connect.TestCaseTypes.EntryPoint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEntryPoint(combinedResult.T5, subFactoryAction).T2);
}
