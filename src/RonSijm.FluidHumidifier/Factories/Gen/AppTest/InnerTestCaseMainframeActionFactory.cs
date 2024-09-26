// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppTest;

public class InnerTestCaseMainframeActionFactory(Action<Humidifier.AppTest.TestCaseTypes.MainframeAction> factoryAction = null) : SubResourceFactory<Humidifier.AppTest.TestCaseTypes.MainframeAction>
{

    internal InnerTestCaseMainframeActionTypeFactory ActionTypeFactory { get; set; }

    internal InnerTestCaseMainframeActionPropertiesFactory PropertiesFactory { get; set; }

    protected override Humidifier.AppTest.TestCaseTypes.MainframeAction Create()
    {
        var mainframeActionResult = CreateMainframeAction();
        factoryAction?.Invoke(mainframeActionResult);

        return mainframeActionResult;
    }

    private Humidifier.AppTest.TestCaseTypes.MainframeAction CreateMainframeAction()
    {
        var mainframeActionResult = new Humidifier.AppTest.TestCaseTypes.MainframeAction();

        return mainframeActionResult;
    }
    public override void CreateChildren(Humidifier.AppTest.TestCaseTypes.MainframeAction result)
    {
        base.CreateChildren(result);

        result.ActionType ??= ActionTypeFactory?.Build();
        result.Properties ??= PropertiesFactory?.Build();
    }

} // End Of Class

public static class InnerTestCaseMainframeActionFactoryExtensions
{
    public static CombinedResult<InnerTestCaseMainframeActionFactory, InnerTestCaseMainframeActionTypeFactory> WithActionType(this InnerTestCaseMainframeActionFactory parentFactory, Action<Humidifier.AppTest.TestCaseTypes.MainframeActionType> subFactoryAction = null)
    {
        parentFactory.ActionTypeFactory = new InnerTestCaseMainframeActionTypeFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ActionTypeFactory);
    }

    public static CombinedResult<InnerTestCaseMainframeActionFactory, InnerTestCaseMainframeActionPropertiesFactory> WithProperties(this InnerTestCaseMainframeActionFactory parentFactory, Action<Humidifier.AppTest.TestCaseTypes.MainframeActionProperties> subFactoryAction = null)
    {
        parentFactory.PropertiesFactory = new InnerTestCaseMainframeActionPropertiesFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.PropertiesFactory);
    }

    public static CombinedResult<InnerTestCaseMainframeActionFactory, T1, InnerTestCaseMainframeActionTypeFactory> WithActionType<T1>(this CombinedResult<InnerTestCaseMainframeActionFactory, T1> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.MainframeActionType> subFactoryAction = null) => new (combinedResult, combinedResult, WithActionType(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTestCaseMainframeActionFactory, InnerTestCaseMainframeActionTypeFactory> WithActionType<T1>(this CombinedResult<T1, InnerTestCaseMainframeActionFactory> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.MainframeActionType> subFactoryAction = null) => new (combinedResult, combinedResult, WithActionType(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerTestCaseMainframeActionFactory, T1, T2, InnerTestCaseMainframeActionTypeFactory> WithActionType<T1, T2>(this CombinedResult<InnerTestCaseMainframeActionFactory, T1, T2> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.MainframeActionType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithActionType(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTestCaseMainframeActionFactory, T2, InnerTestCaseMainframeActionTypeFactory> WithActionType<T1, T2>(this CombinedResult<T1, InnerTestCaseMainframeActionFactory, T2> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.MainframeActionType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithActionType(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTestCaseMainframeActionFactory, InnerTestCaseMainframeActionTypeFactory> WithActionType<T1, T2>(this CombinedResult<T1, T2, InnerTestCaseMainframeActionFactory> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.MainframeActionType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithActionType(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerTestCaseMainframeActionFactory, T1, T2, T3, InnerTestCaseMainframeActionTypeFactory> WithActionType<T1, T2, T3>(this CombinedResult<InnerTestCaseMainframeActionFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.MainframeActionType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithActionType(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTestCaseMainframeActionFactory, T2, T3, InnerTestCaseMainframeActionTypeFactory> WithActionType<T1, T2, T3>(this CombinedResult<T1, InnerTestCaseMainframeActionFactory, T2, T3> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.MainframeActionType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithActionType(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTestCaseMainframeActionFactory, T3, InnerTestCaseMainframeActionTypeFactory> WithActionType<T1, T2, T3>(this CombinedResult<T1, T2, InnerTestCaseMainframeActionFactory, T3> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.MainframeActionType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithActionType(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTestCaseMainframeActionFactory, InnerTestCaseMainframeActionTypeFactory> WithActionType<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerTestCaseMainframeActionFactory> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.MainframeActionType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithActionType(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerTestCaseMainframeActionFactory, T1, T2, T3, T4, InnerTestCaseMainframeActionTypeFactory> WithActionType<T1, T2, T3, T4>(this CombinedResult<InnerTestCaseMainframeActionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.MainframeActionType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithActionType(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTestCaseMainframeActionFactory, T2, T3, T4, InnerTestCaseMainframeActionTypeFactory> WithActionType<T1, T2, T3, T4>(this CombinedResult<T1, InnerTestCaseMainframeActionFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.MainframeActionType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithActionType(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTestCaseMainframeActionFactory, T3, T4, InnerTestCaseMainframeActionTypeFactory> WithActionType<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerTestCaseMainframeActionFactory, T3, T4> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.MainframeActionType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithActionType(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTestCaseMainframeActionFactory, T4, InnerTestCaseMainframeActionTypeFactory> WithActionType<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerTestCaseMainframeActionFactory, T4> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.MainframeActionType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithActionType(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerTestCaseMainframeActionFactory, InnerTestCaseMainframeActionTypeFactory> WithActionType<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerTestCaseMainframeActionFactory> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.MainframeActionType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithActionType(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerTestCaseMainframeActionFactory, T1, InnerTestCaseMainframeActionPropertiesFactory> WithProperties<T1>(this CombinedResult<InnerTestCaseMainframeActionFactory, T1> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.MainframeActionProperties> subFactoryAction = null) => new (combinedResult, combinedResult, WithProperties(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTestCaseMainframeActionFactory, InnerTestCaseMainframeActionPropertiesFactory> WithProperties<T1>(this CombinedResult<T1, InnerTestCaseMainframeActionFactory> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.MainframeActionProperties> subFactoryAction = null) => new (combinedResult, combinedResult, WithProperties(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerTestCaseMainframeActionFactory, T1, T2, InnerTestCaseMainframeActionPropertiesFactory> WithProperties<T1, T2>(this CombinedResult<InnerTestCaseMainframeActionFactory, T1, T2> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.MainframeActionProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithProperties(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTestCaseMainframeActionFactory, T2, InnerTestCaseMainframeActionPropertiesFactory> WithProperties<T1, T2>(this CombinedResult<T1, InnerTestCaseMainframeActionFactory, T2> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.MainframeActionProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithProperties(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTestCaseMainframeActionFactory, InnerTestCaseMainframeActionPropertiesFactory> WithProperties<T1, T2>(this CombinedResult<T1, T2, InnerTestCaseMainframeActionFactory> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.MainframeActionProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithProperties(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerTestCaseMainframeActionFactory, T1, T2, T3, InnerTestCaseMainframeActionPropertiesFactory> WithProperties<T1, T2, T3>(this CombinedResult<InnerTestCaseMainframeActionFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.MainframeActionProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProperties(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTestCaseMainframeActionFactory, T2, T3, InnerTestCaseMainframeActionPropertiesFactory> WithProperties<T1, T2, T3>(this CombinedResult<T1, InnerTestCaseMainframeActionFactory, T2, T3> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.MainframeActionProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProperties(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTestCaseMainframeActionFactory, T3, InnerTestCaseMainframeActionPropertiesFactory> WithProperties<T1, T2, T3>(this CombinedResult<T1, T2, InnerTestCaseMainframeActionFactory, T3> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.MainframeActionProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProperties(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTestCaseMainframeActionFactory, InnerTestCaseMainframeActionPropertiesFactory> WithProperties<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerTestCaseMainframeActionFactory> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.MainframeActionProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProperties(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerTestCaseMainframeActionFactory, T1, T2, T3, T4, InnerTestCaseMainframeActionPropertiesFactory> WithProperties<T1, T2, T3, T4>(this CombinedResult<InnerTestCaseMainframeActionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.MainframeActionProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProperties(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTestCaseMainframeActionFactory, T2, T3, T4, InnerTestCaseMainframeActionPropertiesFactory> WithProperties<T1, T2, T3, T4>(this CombinedResult<T1, InnerTestCaseMainframeActionFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.MainframeActionProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProperties(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTestCaseMainframeActionFactory, T3, T4, InnerTestCaseMainframeActionPropertiesFactory> WithProperties<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerTestCaseMainframeActionFactory, T3, T4> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.MainframeActionProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProperties(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTestCaseMainframeActionFactory, T4, InnerTestCaseMainframeActionPropertiesFactory> WithProperties<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerTestCaseMainframeActionFactory, T4> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.MainframeActionProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProperties(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerTestCaseMainframeActionFactory, InnerTestCaseMainframeActionPropertiesFactory> WithProperties<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerTestCaseMainframeActionFactory> combinedResult, Action<Humidifier.AppTest.TestCaseTypes.MainframeActionProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProperties(combinedResult.T5, subFactoryAction));
}
