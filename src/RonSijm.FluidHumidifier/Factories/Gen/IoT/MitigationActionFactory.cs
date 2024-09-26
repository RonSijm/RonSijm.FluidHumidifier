// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class MitigationActionFactory(string resourceName = null, Action<Humidifier.IoT.MitigationAction> factoryAction = null) : ResourceFactory<Humidifier.IoT.MitigationAction>(resourceName)
{

    internal InnerMitigationActionActionParamsFactory ActionParamsFactory { get; set; }

    protected override Humidifier.IoT.MitigationAction Create()
    {
        var mitigationActionResult = CreateMitigationAction();
        factoryAction?.Invoke(mitigationActionResult);

        return mitigationActionResult;
    }

    private Humidifier.IoT.MitigationAction CreateMitigationAction()
    {
        var mitigationActionResult = new Humidifier.IoT.MitigationAction
        {
            GivenName = InputResourceName,
        };

        return mitigationActionResult;
    }
    public override void CreateChildren(Humidifier.IoT.MitigationAction result)
    {
        base.CreateChildren(result);

        result.ActionParams ??= ActionParamsFactory?.Build();
    }

} // End Of Class

public static class MitigationActionFactoryExtensions
{
    public static CombinedResult<MitigationActionFactory, InnerMitigationActionActionParamsFactory> WithActionParams(this MitigationActionFactory parentFactory, Action<Humidifier.IoT.MitigationActionTypes.ActionParams> subFactoryAction = null)
    {
        parentFactory.ActionParamsFactory = new InnerMitigationActionActionParamsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ActionParamsFactory);
    }

    public static CombinedResult<MitigationActionFactory, T1, InnerMitigationActionActionParamsFactory> WithActionParams<T1>(this CombinedResult<MitigationActionFactory, T1> combinedResult, Action<Humidifier.IoT.MitigationActionTypes.ActionParams> subFactoryAction = null) => new (combinedResult, combinedResult, WithActionParams(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MitigationActionFactory, InnerMitigationActionActionParamsFactory> WithActionParams<T1>(this CombinedResult<T1, MitigationActionFactory> combinedResult, Action<Humidifier.IoT.MitigationActionTypes.ActionParams> subFactoryAction = null) => new (combinedResult, combinedResult, WithActionParams(combinedResult.T2, subFactoryAction));
    public static CombinedResult<MitigationActionFactory, T1, T2, InnerMitigationActionActionParamsFactory> WithActionParams<T1, T2>(this CombinedResult<MitigationActionFactory, T1, T2> combinedResult, Action<Humidifier.IoT.MitigationActionTypes.ActionParams> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithActionParams(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MitigationActionFactory, T2, InnerMitigationActionActionParamsFactory> WithActionParams<T1, T2>(this CombinedResult<T1, MitigationActionFactory, T2> combinedResult, Action<Humidifier.IoT.MitigationActionTypes.ActionParams> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithActionParams(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, MitigationActionFactory, InnerMitigationActionActionParamsFactory> WithActionParams<T1, T2>(this CombinedResult<T1, T2, MitigationActionFactory> combinedResult, Action<Humidifier.IoT.MitigationActionTypes.ActionParams> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithActionParams(combinedResult.T3, subFactoryAction));
    public static CombinedResult<MitigationActionFactory, T1, T2, T3, InnerMitigationActionActionParamsFactory> WithActionParams<T1, T2, T3>(this CombinedResult<MitigationActionFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoT.MitigationActionTypes.ActionParams> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithActionParams(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MitigationActionFactory, T2, T3, InnerMitigationActionActionParamsFactory> WithActionParams<T1, T2, T3>(this CombinedResult<T1, MitigationActionFactory, T2, T3> combinedResult, Action<Humidifier.IoT.MitigationActionTypes.ActionParams> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithActionParams(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, MitigationActionFactory, T3, InnerMitigationActionActionParamsFactory> WithActionParams<T1, T2, T3>(this CombinedResult<T1, T2, MitigationActionFactory, T3> combinedResult, Action<Humidifier.IoT.MitigationActionTypes.ActionParams> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithActionParams(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, MitigationActionFactory, InnerMitigationActionActionParamsFactory> WithActionParams<T1, T2, T3>(this CombinedResult<T1, T2, T3, MitigationActionFactory> combinedResult, Action<Humidifier.IoT.MitigationActionTypes.ActionParams> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithActionParams(combinedResult.T4, subFactoryAction));
    public static CombinedResult<MitigationActionFactory, T1, T2, T3, T4, InnerMitigationActionActionParamsFactory> WithActionParams<T1, T2, T3, T4>(this CombinedResult<MitigationActionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoT.MitigationActionTypes.ActionParams> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithActionParams(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MitigationActionFactory, T2, T3, T4, InnerMitigationActionActionParamsFactory> WithActionParams<T1, T2, T3, T4>(this CombinedResult<T1, MitigationActionFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoT.MitigationActionTypes.ActionParams> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithActionParams(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, MitigationActionFactory, T3, T4, InnerMitigationActionActionParamsFactory> WithActionParams<T1, T2, T3, T4>(this CombinedResult<T1, T2, MitigationActionFactory, T3, T4> combinedResult, Action<Humidifier.IoT.MitigationActionTypes.ActionParams> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithActionParams(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, MitigationActionFactory, T4, InnerMitigationActionActionParamsFactory> WithActionParams<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, MitigationActionFactory, T4> combinedResult, Action<Humidifier.IoT.MitigationActionTypes.ActionParams> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithActionParams(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, MitigationActionFactory, InnerMitigationActionActionParamsFactory> WithActionParams<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, MitigationActionFactory> combinedResult, Action<Humidifier.IoT.MitigationActionTypes.ActionParams> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithActionParams(combinedResult.T5, subFactoryAction));
}
