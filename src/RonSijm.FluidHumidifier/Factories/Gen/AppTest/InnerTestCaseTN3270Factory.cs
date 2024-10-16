// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppTest;

public class InnerTestCaseTN3270Factory(Action<Humidifier.AppTest.TestCaseTypes.TN3270> factoryAction = null) : SubResourceFactory<Humidifier.AppTest.TestCaseTypes.TN3270>
{

    internal InnerTestCaseScriptFactory ScriptFactory { get; set; }

    protected override Humidifier.AppTest.TestCaseTypes.TN3270 Create()
    {
        var tN3270Result = CreateTN3270();
        factoryAction?.Invoke(tN3270Result);

        return tN3270Result;
    }

    private Humidifier.AppTest.TestCaseTypes.TN3270 CreateTN3270()
    {
        var tN3270Result = new Humidifier.AppTest.TestCaseTypes.TN3270();

        return tN3270Result;
    }
    public override void CreateChildren(Humidifier.AppTest.TestCaseTypes.TN3270 result)
    {
        base.CreateChildren(result);

        result.Script ??= ScriptFactory?.Build();
    }

} // End Of Class

public static class InnerTestCaseTN3270FactoryExtensions
{
    public static CombinedResult<InnerTestCaseTN3270Factory, InnerTestCaseScriptFactory> WithScript(this InnerTestCaseTN3270Factory parentFactory, Action<Humidifier.AppTest.TestCaseTypes.Script> subFactoryAction = null)
    {
        parentFactory.ScriptFactory = new InnerTestCaseScriptFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ScriptFactory);
    }

    public static CombinedResult<InnerTestCaseTN3270Factory, T1, InnerTestCaseScriptFactory> WithScript<T1>(this CombinedResult<InnerTestCaseTN3270Factory, T1> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.Script> subFactoryAction = null) => new (combinedResult, combinedResult, WithScript(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTestCaseTN3270Factory, InnerTestCaseScriptFactory> WithScript<T1>(this CombinedResult<T1, InnerTestCaseTN3270Factory> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.Script> subFactoryAction = null) => new (combinedResult, combinedResult, WithScript(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerTestCaseTN3270Factory, T1, T2, InnerTestCaseScriptFactory> WithScript<T1, T2>(this CombinedResult<InnerTestCaseTN3270Factory, T1, T2> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.Script> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScript(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTestCaseTN3270Factory, T2, InnerTestCaseScriptFactory> WithScript<T1, T2>(this CombinedResult<T1, InnerTestCaseTN3270Factory, T2> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.Script> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScript(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTestCaseTN3270Factory, InnerTestCaseScriptFactory> WithScript<T1, T2>(this CombinedResult<T1, T2, InnerTestCaseTN3270Factory> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.Script> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScript(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerTestCaseTN3270Factory, T1, T2, T3, InnerTestCaseScriptFactory> WithScript<T1, T2, T3>(this CombinedResult<InnerTestCaseTN3270Factory, T1, T2, T3> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.Script> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScript(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTestCaseTN3270Factory, T2, T3, InnerTestCaseScriptFactory> WithScript<T1, T2, T3>(this CombinedResult<T1, InnerTestCaseTN3270Factory, T2, T3> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.Script> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScript(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTestCaseTN3270Factory, T3, InnerTestCaseScriptFactory> WithScript<T1, T2, T3>(this CombinedResult<T1, T2, InnerTestCaseTN3270Factory, T3> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.Script> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScript(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTestCaseTN3270Factory, InnerTestCaseScriptFactory> WithScript<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerTestCaseTN3270Factory> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.Script> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScript(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerTestCaseTN3270Factory, T1, T2, T3, T4, InnerTestCaseScriptFactory> WithScript<T1, T2, T3, T4>(this CombinedResult<InnerTestCaseTN3270Factory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.Script> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScript(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTestCaseTN3270Factory, T2, T3, T4, InnerTestCaseScriptFactory> WithScript<T1, T2, T3, T4>(this CombinedResult<T1, InnerTestCaseTN3270Factory, T2, T3, T4> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.Script> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScript(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTestCaseTN3270Factory, T3, T4, InnerTestCaseScriptFactory> WithScript<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerTestCaseTN3270Factory, T3, T4> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.Script> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScript(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTestCaseTN3270Factory, T4, InnerTestCaseScriptFactory> WithScript<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerTestCaseTN3270Factory, T4> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.Script> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScript(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerTestCaseTN3270Factory, InnerTestCaseScriptFactory> WithScript<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerTestCaseTN3270Factory> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.Script> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScript(combinedResult.T5, subFactoryAction));
}
