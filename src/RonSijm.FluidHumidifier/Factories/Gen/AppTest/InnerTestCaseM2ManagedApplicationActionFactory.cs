// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppTest;

public class InnerTestCaseM2ManagedApplicationActionFactory(Action<Humidifier.AppTest.TestCaseTypes.M2ManagedApplicationAction> factoryAction = null) : SubResourceFactory<Humidifier.AppTest.TestCaseTypes.M2ManagedApplicationAction>
{

    internal InnerTestCaseM2ManagedActionPropertiesFactory PropertiesFactory { get; set; }

    protected override Humidifier.AppTest.TestCaseTypes.M2ManagedApplicationAction Create()
    {
        var m2ManagedApplicationActionResult = CreateM2ManagedApplicationAction();
        factoryAction?.Invoke(m2ManagedApplicationActionResult);

        return m2ManagedApplicationActionResult;
    }

    private Humidifier.AppTest.TestCaseTypes.M2ManagedApplicationAction CreateM2ManagedApplicationAction()
    {
        var m2ManagedApplicationActionResult = new Humidifier.AppTest.TestCaseTypes.M2ManagedApplicationAction();

        return m2ManagedApplicationActionResult;
    }
    public override void CreateChildren(Humidifier.AppTest.TestCaseTypes.M2ManagedApplicationAction result)
    {
        base.CreateChildren(result);

        result.Properties ??= PropertiesFactory?.Build();
    }

} // End Of Class

public static class InnerTestCaseM2ManagedApplicationActionFactoryExtensions
{
    public static CombinedResult<InnerTestCaseM2ManagedApplicationActionFactory, InnerTestCaseM2ManagedActionPropertiesFactory> WithProperties(this InnerTestCaseM2ManagedApplicationActionFactory parentFactory, Action<Humidifier.AppTest.TestCaseTypes.M2ManagedActionProperties> subFactoryAction = null)
    {
        parentFactory.PropertiesFactory = new InnerTestCaseM2ManagedActionPropertiesFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.PropertiesFactory);
    }

    public static CombinedResult<InnerTestCaseM2ManagedApplicationActionFactory, T1, InnerTestCaseM2ManagedActionPropertiesFactory> WithProperties<T1>(this CombinedResult<InnerTestCaseM2ManagedApplicationActionFactory, T1> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.M2ManagedActionProperties> subFactoryAction = null) => new (combinedResult, combinedResult, WithProperties(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTestCaseM2ManagedApplicationActionFactory, InnerTestCaseM2ManagedActionPropertiesFactory> WithProperties<T1>(this CombinedResult<T1, InnerTestCaseM2ManagedApplicationActionFactory> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.M2ManagedActionProperties> subFactoryAction = null) => new (combinedResult, combinedResult, WithProperties(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerTestCaseM2ManagedApplicationActionFactory, T1, T2, InnerTestCaseM2ManagedActionPropertiesFactory> WithProperties<T1, T2>(this CombinedResult<InnerTestCaseM2ManagedApplicationActionFactory, T1, T2> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.M2ManagedActionProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithProperties(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTestCaseM2ManagedApplicationActionFactory, T2, InnerTestCaseM2ManagedActionPropertiesFactory> WithProperties<T1, T2>(this CombinedResult<T1, InnerTestCaseM2ManagedApplicationActionFactory, T2> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.M2ManagedActionProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithProperties(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTestCaseM2ManagedApplicationActionFactory, InnerTestCaseM2ManagedActionPropertiesFactory> WithProperties<T1, T2>(this CombinedResult<T1, T2, InnerTestCaseM2ManagedApplicationActionFactory> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.M2ManagedActionProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithProperties(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerTestCaseM2ManagedApplicationActionFactory, T1, T2, T3, InnerTestCaseM2ManagedActionPropertiesFactory> WithProperties<T1, T2, T3>(this CombinedResult<InnerTestCaseM2ManagedApplicationActionFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.M2ManagedActionProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProperties(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTestCaseM2ManagedApplicationActionFactory, T2, T3, InnerTestCaseM2ManagedActionPropertiesFactory> WithProperties<T1, T2, T3>(this CombinedResult<T1, InnerTestCaseM2ManagedApplicationActionFactory, T2, T3> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.M2ManagedActionProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProperties(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTestCaseM2ManagedApplicationActionFactory, T3, InnerTestCaseM2ManagedActionPropertiesFactory> WithProperties<T1, T2, T3>(this CombinedResult<T1, T2, InnerTestCaseM2ManagedApplicationActionFactory, T3> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.M2ManagedActionProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProperties(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTestCaseM2ManagedApplicationActionFactory, InnerTestCaseM2ManagedActionPropertiesFactory> WithProperties<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerTestCaseM2ManagedApplicationActionFactory> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.M2ManagedActionProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProperties(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerTestCaseM2ManagedApplicationActionFactory, T1, T2, T3, T4, InnerTestCaseM2ManagedActionPropertiesFactory> WithProperties<T1, T2, T3, T4>(this CombinedResult<InnerTestCaseM2ManagedApplicationActionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.M2ManagedActionProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProperties(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTestCaseM2ManagedApplicationActionFactory, T2, T3, T4, InnerTestCaseM2ManagedActionPropertiesFactory> WithProperties<T1, T2, T3, T4>(this CombinedResult<T1, InnerTestCaseM2ManagedApplicationActionFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.M2ManagedActionProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProperties(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTestCaseM2ManagedApplicationActionFactory, T3, T4, InnerTestCaseM2ManagedActionPropertiesFactory> WithProperties<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerTestCaseM2ManagedApplicationActionFactory, T3, T4> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.M2ManagedActionProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProperties(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTestCaseM2ManagedApplicationActionFactory, T4, InnerTestCaseM2ManagedActionPropertiesFactory> WithProperties<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerTestCaseM2ManagedApplicationActionFactory, T4> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.M2ManagedActionProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProperties(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerTestCaseM2ManagedApplicationActionFactory, InnerTestCaseM2ManagedActionPropertiesFactory> WithProperties<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerTestCaseM2ManagedApplicationActionFactory> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.M2ManagedActionProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProperties(combinedResult.T5, subFactoryAction));
}
