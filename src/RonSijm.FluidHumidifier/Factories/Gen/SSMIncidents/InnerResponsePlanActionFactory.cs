// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SSMIncidents;

public class InnerResponsePlanActionFactory(Action<Humidifier.SSMIncidents.ResponsePlanTypes.Action> factoryAction = null) : SubResourceFactory<Humidifier.SSMIncidents.ResponsePlanTypes.Action>
{

    internal InnerResponsePlanSsmAutomationFactory SsmAutomationFactory { get; set; }

    protected override Humidifier.SSMIncidents.ResponsePlanTypes.Action Create()
    {
        var actionResult = CreateAction();
        factoryAction?.Invoke(actionResult);

        return actionResult;
    }

    private Humidifier.SSMIncidents.ResponsePlanTypes.Action CreateAction()
    {
        var actionResult = new Humidifier.SSMIncidents.ResponsePlanTypes.Action();

        return actionResult;
    }
    public override void CreateChildren(Humidifier.SSMIncidents.ResponsePlanTypes.Action result)
    {
        base.CreateChildren(result);

        result.SsmAutomation ??= SsmAutomationFactory?.Build();
    }

} // End Of Class

public static class InnerResponsePlanActionFactoryExtensions
{
    public static CombinedResult<InnerResponsePlanActionFactory, InnerResponsePlanSsmAutomationFactory> WithSsmAutomation(this InnerResponsePlanActionFactory parentFactory, Action<Humidifier.SSMIncidents.ResponsePlanTypes.SsmAutomation> subFactoryAction = null)
    {
        parentFactory.SsmAutomationFactory = new InnerResponsePlanSsmAutomationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SsmAutomationFactory);
    }

    public static CombinedResult<InnerResponsePlanActionFactory, T1, InnerResponsePlanSsmAutomationFactory> WithSsmAutomation<T1>(this CombinedResult<InnerResponsePlanActionFactory, T1> combinedResult, Action<Humidifier.SSMIncidents.ResponsePlanTypes.SsmAutomation> subFactoryAction = null) => new (combinedResult, combinedResult, WithSsmAutomation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerResponsePlanActionFactory, InnerResponsePlanSsmAutomationFactory> WithSsmAutomation<T1>(this CombinedResult<T1, InnerResponsePlanActionFactory> combinedResult, Action<Humidifier.SSMIncidents.ResponsePlanTypes.SsmAutomation> subFactoryAction = null) => new (combinedResult, combinedResult, WithSsmAutomation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerResponsePlanActionFactory, T1, T2, InnerResponsePlanSsmAutomationFactory> WithSsmAutomation<T1, T2>(this CombinedResult<InnerResponsePlanActionFactory, T1, T2> combinedResult, Action<Humidifier.SSMIncidents.ResponsePlanTypes.SsmAutomation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSsmAutomation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerResponsePlanActionFactory, T2, InnerResponsePlanSsmAutomationFactory> WithSsmAutomation<T1, T2>(this CombinedResult<T1, InnerResponsePlanActionFactory, T2> combinedResult, Action<Humidifier.SSMIncidents.ResponsePlanTypes.SsmAutomation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSsmAutomation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerResponsePlanActionFactory, InnerResponsePlanSsmAutomationFactory> WithSsmAutomation<T1, T2>(this CombinedResult<T1, T2, InnerResponsePlanActionFactory> combinedResult, Action<Humidifier.SSMIncidents.ResponsePlanTypes.SsmAutomation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSsmAutomation(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerResponsePlanActionFactory, T1, T2, T3, InnerResponsePlanSsmAutomationFactory> WithSsmAutomation<T1, T2, T3>(this CombinedResult<InnerResponsePlanActionFactory, T1, T2, T3> combinedResult, Action<Humidifier.SSMIncidents.ResponsePlanTypes.SsmAutomation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSsmAutomation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerResponsePlanActionFactory, T2, T3, InnerResponsePlanSsmAutomationFactory> WithSsmAutomation<T1, T2, T3>(this CombinedResult<T1, InnerResponsePlanActionFactory, T2, T3> combinedResult, Action<Humidifier.SSMIncidents.ResponsePlanTypes.SsmAutomation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSsmAutomation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerResponsePlanActionFactory, T3, InnerResponsePlanSsmAutomationFactory> WithSsmAutomation<T1, T2, T3>(this CombinedResult<T1, T2, InnerResponsePlanActionFactory, T3> combinedResult, Action<Humidifier.SSMIncidents.ResponsePlanTypes.SsmAutomation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSsmAutomation(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerResponsePlanActionFactory, InnerResponsePlanSsmAutomationFactory> WithSsmAutomation<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerResponsePlanActionFactory> combinedResult, Action<Humidifier.SSMIncidents.ResponsePlanTypes.SsmAutomation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSsmAutomation(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerResponsePlanActionFactory, T1, T2, T3, T4, InnerResponsePlanSsmAutomationFactory> WithSsmAutomation<T1, T2, T3, T4>(this CombinedResult<InnerResponsePlanActionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SSMIncidents.ResponsePlanTypes.SsmAutomation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSsmAutomation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerResponsePlanActionFactory, T2, T3, T4, InnerResponsePlanSsmAutomationFactory> WithSsmAutomation<T1, T2, T3, T4>(this CombinedResult<T1, InnerResponsePlanActionFactory, T2, T3, T4> combinedResult, Action<Humidifier.SSMIncidents.ResponsePlanTypes.SsmAutomation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSsmAutomation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerResponsePlanActionFactory, T3, T4, InnerResponsePlanSsmAutomationFactory> WithSsmAutomation<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerResponsePlanActionFactory, T3, T4> combinedResult, Action<Humidifier.SSMIncidents.ResponsePlanTypes.SsmAutomation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSsmAutomation(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerResponsePlanActionFactory, T4, InnerResponsePlanSsmAutomationFactory> WithSsmAutomation<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerResponsePlanActionFactory, T4> combinedResult, Action<Humidifier.SSMIncidents.ResponsePlanTypes.SsmAutomation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSsmAutomation(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerResponsePlanActionFactory, InnerResponsePlanSsmAutomationFactory> WithSsmAutomation<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerResponsePlanActionFactory> combinedResult, Action<Humidifier.SSMIncidents.ResponsePlanTypes.SsmAutomation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSsmAutomation(combinedResult.T5, subFactoryAction));
}
