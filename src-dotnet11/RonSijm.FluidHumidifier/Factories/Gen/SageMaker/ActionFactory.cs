// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class ActionFactory(string resourceName = null, Action<Humidifier.SageMaker.Action> factoryAction = null) : ResourceFactory<Humidifier.SageMaker.Action>(resourceName)
{

    internal InnerActionMetadataPropertiesFactory MetadataPropertiesFactory { get; set; }

    internal InnerActionActionSourceFactory SourceFactory { get; set; }

    protected override Humidifier.SageMaker.Action Create()
    {
        var actionResult = CreateAction();
        factoryAction?.Invoke(actionResult);

        return actionResult;
    }

    private Humidifier.SageMaker.Action CreateAction()
    {
        var actionResult = new Humidifier.SageMaker.Action
        {
            GivenName = InputResourceName,
        };

        return actionResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.Action result)
    {
        base.CreateChildren(result);

        result.MetadataProperties ??= MetadataPropertiesFactory?.Build();
        result.Source ??= SourceFactory?.Build();
    }

} // End Of Class

public static class ActionFactoryExtensions
{
    public static CombinedResult<ActionFactory, InnerActionMetadataPropertiesFactory> WithMetadataProperties(this ActionFactory parentFactory, Action<Humidifier.SageMaker.ActionTypes.MetadataProperties> subFactoryAction = null)
    {
        parentFactory.MetadataPropertiesFactory = new InnerActionMetadataPropertiesFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.MetadataPropertiesFactory);
    }

    public static CombinedResult<ActionFactory, InnerActionActionSourceFactory> WithSource(this ActionFactory parentFactory, Action<Humidifier.SageMaker.ActionTypes.ActionSource> subFactoryAction = null)
    {
        parentFactory.SourceFactory = new InnerActionActionSourceFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SourceFactory);
    }

    public static CombinedResult<ActionFactory, T1, InnerActionMetadataPropertiesFactory> WithMetadataProperties<T1>(this CombinedResult<ActionFactory, T1> combinedResult, Action<Humidifier.SageMaker.ActionTypes.MetadataProperties> subFactoryAction = null) => new (combinedResult, combinedResult, WithMetadataProperties(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ActionFactory, InnerActionMetadataPropertiesFactory> WithMetadataProperties<T1>(this CombinedResult<T1, ActionFactory> combinedResult, Action<Humidifier.SageMaker.ActionTypes.MetadataProperties> subFactoryAction = null) => new (combinedResult, combinedResult, WithMetadataProperties(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<ActionFactory, T1, T2, InnerActionMetadataPropertiesFactory> WithMetadataProperties<T1, T2>(this CombinedResult<ActionFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.ActionTypes.MetadataProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMetadataProperties(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ActionFactory, T2, InnerActionMetadataPropertiesFactory> WithMetadataProperties<T1, T2>(this CombinedResult<T1, ActionFactory, T2> combinedResult, Action<Humidifier.SageMaker.ActionTypes.MetadataProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMetadataProperties(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ActionFactory, InnerActionMetadataPropertiesFactory> WithMetadataProperties<T1, T2>(this CombinedResult<T1, T2, ActionFactory> combinedResult, Action<Humidifier.SageMaker.ActionTypes.MetadataProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMetadataProperties(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<ActionFactory, T1, T2, T3, InnerActionMetadataPropertiesFactory> WithMetadataProperties<T1, T2, T3>(this CombinedResult<ActionFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.ActionTypes.MetadataProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMetadataProperties(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ActionFactory, T2, T3, InnerActionMetadataPropertiesFactory> WithMetadataProperties<T1, T2, T3>(this CombinedResult<T1, ActionFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.ActionTypes.MetadataProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMetadataProperties(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ActionFactory, T3, InnerActionMetadataPropertiesFactory> WithMetadataProperties<T1, T2, T3>(this CombinedResult<T1, T2, ActionFactory, T3> combinedResult, Action<Humidifier.SageMaker.ActionTypes.MetadataProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMetadataProperties(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ActionFactory, InnerActionMetadataPropertiesFactory> WithMetadataProperties<T1, T2, T3>(this CombinedResult<T1, T2, T3, ActionFactory> combinedResult, Action<Humidifier.SageMaker.ActionTypes.MetadataProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMetadataProperties(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<ActionFactory, T1, T2, T3, T4, InnerActionMetadataPropertiesFactory> WithMetadataProperties<T1, T2, T3, T4>(this CombinedResult<ActionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ActionTypes.MetadataProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMetadataProperties(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ActionFactory, T2, T3, T4, InnerActionMetadataPropertiesFactory> WithMetadataProperties<T1, T2, T3, T4>(this CombinedResult<T1, ActionFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ActionTypes.MetadataProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMetadataProperties(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ActionFactory, T3, T4, InnerActionMetadataPropertiesFactory> WithMetadataProperties<T1, T2, T3, T4>(this CombinedResult<T1, T2, ActionFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.ActionTypes.MetadataProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMetadataProperties(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ActionFactory, T4, InnerActionMetadataPropertiesFactory> WithMetadataProperties<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ActionFactory, T4> combinedResult, Action<Humidifier.SageMaker.ActionTypes.MetadataProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMetadataProperties(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, ActionFactory, InnerActionMetadataPropertiesFactory> WithMetadataProperties<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ActionFactory> combinedResult, Action<Humidifier.SageMaker.ActionTypes.MetadataProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMetadataProperties(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<ActionFactory, T1, InnerActionActionSourceFactory> WithSource<T1>(this CombinedResult<ActionFactory, T1> combinedResult, Action<Humidifier.SageMaker.ActionTypes.ActionSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ActionFactory, InnerActionActionSourceFactory> WithSource<T1>(this CombinedResult<T1, ActionFactory> combinedResult, Action<Humidifier.SageMaker.ActionTypes.ActionSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<ActionFactory, T1, T2, InnerActionActionSourceFactory> WithSource<T1, T2>(this CombinedResult<ActionFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.ActionTypes.ActionSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ActionFactory, T2, InnerActionActionSourceFactory> WithSource<T1, T2>(this CombinedResult<T1, ActionFactory, T2> combinedResult, Action<Humidifier.SageMaker.ActionTypes.ActionSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ActionFactory, InnerActionActionSourceFactory> WithSource<T1, T2>(this CombinedResult<T1, T2, ActionFactory> combinedResult, Action<Humidifier.SageMaker.ActionTypes.ActionSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<ActionFactory, T1, T2, T3, InnerActionActionSourceFactory> WithSource<T1, T2, T3>(this CombinedResult<ActionFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.ActionTypes.ActionSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ActionFactory, T2, T3, InnerActionActionSourceFactory> WithSource<T1, T2, T3>(this CombinedResult<T1, ActionFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.ActionTypes.ActionSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ActionFactory, T3, InnerActionActionSourceFactory> WithSource<T1, T2, T3>(this CombinedResult<T1, T2, ActionFactory, T3> combinedResult, Action<Humidifier.SageMaker.ActionTypes.ActionSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ActionFactory, InnerActionActionSourceFactory> WithSource<T1, T2, T3>(this CombinedResult<T1, T2, T3, ActionFactory> combinedResult, Action<Humidifier.SageMaker.ActionTypes.ActionSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<ActionFactory, T1, T2, T3, T4, InnerActionActionSourceFactory> WithSource<T1, T2, T3, T4>(this CombinedResult<ActionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ActionTypes.ActionSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ActionFactory, T2, T3, T4, InnerActionActionSourceFactory> WithSource<T1, T2, T3, T4>(this CombinedResult<T1, ActionFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ActionTypes.ActionSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ActionFactory, T3, T4, InnerActionActionSourceFactory> WithSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, ActionFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.ActionTypes.ActionSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ActionFactory, T4, InnerActionActionSourceFactory> WithSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ActionFactory, T4> combinedResult, Action<Humidifier.SageMaker.ActionTypes.ActionSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, ActionFactory, InnerActionActionSourceFactory> WithSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ActionFactory> combinedResult, Action<Humidifier.SageMaker.ActionTypes.ActionSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T5, subFactoryAction).T2);
}
