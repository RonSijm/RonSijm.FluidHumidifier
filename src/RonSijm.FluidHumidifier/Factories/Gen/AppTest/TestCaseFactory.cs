// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppTest;

public class TestCaseFactory(string resourceName = null, Action<Humidifier.AppTest.TestCase> factoryAction = null) : ResourceFactory<Humidifier.AppTest.TestCase>(resourceName)
{

    internal List<InnerTestCaseStepFactory> StepsFactories { get; set; } = [];

    protected override Humidifier.AppTest.TestCase Create()
    {
        var testCaseResult = CreateTestCase();
        factoryAction?.Invoke(testCaseResult);

        return testCaseResult;
    }

    private Humidifier.AppTest.TestCase CreateTestCase()
    {
        var testCaseResult = new Humidifier.AppTest.TestCase
        {
            GivenName = InputResourceName,
        };

        return testCaseResult;
    }
    public override void CreateChildren(Humidifier.AppTest.TestCase result)
    {
        base.CreateChildren(result);

        result.Steps = StepsFactories.Any() ? StepsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class TestCaseFactoryExtensions
{
    public static CombinedResult<TestCaseFactory, InnerTestCaseStepFactory> WithSteps(this TestCaseFactory parentFactory, Action<Humidifier.AppTest.TestCaseTypes.Step> subFactoryAction = null)
    {
        var factory = new InnerTestCaseStepFactory(subFactoryAction);
        parentFactory.StepsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<TestCaseFactory, T1, InnerTestCaseStepFactory> WithSteps<T1>(this CombinedResult<TestCaseFactory, T1> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.Step> subFactoryAction = null) => new (combinedResult, combinedResult, WithSteps(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TestCaseFactory, InnerTestCaseStepFactory> WithSteps<T1>(this CombinedResult<T1, TestCaseFactory> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.Step> subFactoryAction = null) => new (combinedResult, combinedResult, WithSteps(combinedResult.T2, subFactoryAction));
    public static CombinedResult<TestCaseFactory, T1, T2, InnerTestCaseStepFactory> WithSteps<T1, T2>(this CombinedResult<TestCaseFactory, T1, T2> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.Step> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSteps(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TestCaseFactory, T2, InnerTestCaseStepFactory> WithSteps<T1, T2>(this CombinedResult<T1, TestCaseFactory, T2> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.Step> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSteps(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TestCaseFactory, InnerTestCaseStepFactory> WithSteps<T1, T2>(this CombinedResult<T1, T2, TestCaseFactory> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.Step> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSteps(combinedResult.T3, subFactoryAction));
    public static CombinedResult<TestCaseFactory, T1, T2, T3, InnerTestCaseStepFactory> WithSteps<T1, T2, T3>(this CombinedResult<TestCaseFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.Step> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSteps(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TestCaseFactory, T2, T3, InnerTestCaseStepFactory> WithSteps<T1, T2, T3>(this CombinedResult<T1, TestCaseFactory, T2, T3> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.Step> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSteps(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TestCaseFactory, T3, InnerTestCaseStepFactory> WithSteps<T1, T2, T3>(this CombinedResult<T1, T2, TestCaseFactory, T3> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.Step> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSteps(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, TestCaseFactory, InnerTestCaseStepFactory> WithSteps<T1, T2, T3>(this CombinedResult<T1, T2, T3, TestCaseFactory> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.Step> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSteps(combinedResult.T4, subFactoryAction));
    public static CombinedResult<TestCaseFactory, T1, T2, T3, T4, InnerTestCaseStepFactory> WithSteps<T1, T2, T3, T4>(this CombinedResult<TestCaseFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.Step> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSteps(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TestCaseFactory, T2, T3, T4, InnerTestCaseStepFactory> WithSteps<T1, T2, T3, T4>(this CombinedResult<T1, TestCaseFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.Step> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSteps(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TestCaseFactory, T3, T4, InnerTestCaseStepFactory> WithSteps<T1, T2, T3, T4>(this CombinedResult<T1, T2, TestCaseFactory, T3, T4> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.Step> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSteps(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, TestCaseFactory, T4, InnerTestCaseStepFactory> WithSteps<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, TestCaseFactory, T4> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.Step> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSteps(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, TestCaseFactory, InnerTestCaseStepFactory> WithSteps<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, TestCaseFactory> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.Step> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSteps(combinedResult.T5, subFactoryAction));
}
