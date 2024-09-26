// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SecurityLake;

public class InnerSubscriberSourceFactory(Action<Humidifier.SecurityLake.SubscriberTypes.Source> factoryAction = null) : SubResourceFactory<Humidifier.SecurityLake.SubscriberTypes.Source>
{

    internal InnerSubscriberAwsLogSourceFactory AwsLogSourceFactory { get; set; }

    internal InnerSubscriberCustomLogSourceFactory CustomLogSourceFactory { get; set; }

    protected override Humidifier.SecurityLake.SubscriberTypes.Source Create()
    {
        var sourceResult = CreateSource();
        factoryAction?.Invoke(sourceResult);

        return sourceResult;
    }

    private Humidifier.SecurityLake.SubscriberTypes.Source CreateSource()
    {
        var sourceResult = new Humidifier.SecurityLake.SubscriberTypes.Source();

        return sourceResult;
    }
    public override void CreateChildren(Humidifier.SecurityLake.SubscriberTypes.Source result)
    {
        base.CreateChildren(result);

        result.AwsLogSource ??= AwsLogSourceFactory?.Build();
        result.CustomLogSource ??= CustomLogSourceFactory?.Build();
    }

} // End Of Class

public static class InnerSubscriberSourceFactoryExtensions
{
    public static CombinedResult<InnerSubscriberSourceFactory, InnerSubscriberAwsLogSourceFactory> WithAwsLogSource(this InnerSubscriberSourceFactory parentFactory, Action<Humidifier.SecurityLake.SubscriberTypes.AwsLogSource> subFactoryAction = null)
    {
        parentFactory.AwsLogSourceFactory = new InnerSubscriberAwsLogSourceFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AwsLogSourceFactory);
    }

    public static CombinedResult<InnerSubscriberSourceFactory, InnerSubscriberCustomLogSourceFactory> WithCustomLogSource(this InnerSubscriberSourceFactory parentFactory, Action<Humidifier.SecurityLake.SubscriberTypes.CustomLogSource> subFactoryAction = null)
    {
        parentFactory.CustomLogSourceFactory = new InnerSubscriberCustomLogSourceFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CustomLogSourceFactory);
    }

    public static CombinedResult<InnerSubscriberSourceFactory, T1, InnerSubscriberAwsLogSourceFactory> WithAwsLogSource<T1>(this CombinedResult<InnerSubscriberSourceFactory, T1> combinedResult, Action<Humidifier.SecurityLake.SubscriberTypes.AwsLogSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithAwsLogSource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerSubscriberSourceFactory, InnerSubscriberAwsLogSourceFactory> WithAwsLogSource<T1>(this CombinedResult<T1, InnerSubscriberSourceFactory> combinedResult, Action<Humidifier.SecurityLake.SubscriberTypes.AwsLogSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithAwsLogSource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerSubscriberSourceFactory, T1, T2, InnerSubscriberAwsLogSourceFactory> WithAwsLogSource<T1, T2>(this CombinedResult<InnerSubscriberSourceFactory, T1, T2> combinedResult, Action<Humidifier.SecurityLake.SubscriberTypes.AwsLogSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAwsLogSource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerSubscriberSourceFactory, T2, InnerSubscriberAwsLogSourceFactory> WithAwsLogSource<T1, T2>(this CombinedResult<T1, InnerSubscriberSourceFactory, T2> combinedResult, Action<Humidifier.SecurityLake.SubscriberTypes.AwsLogSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAwsLogSource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerSubscriberSourceFactory, InnerSubscriberAwsLogSourceFactory> WithAwsLogSource<T1, T2>(this CombinedResult<T1, T2, InnerSubscriberSourceFactory> combinedResult, Action<Humidifier.SecurityLake.SubscriberTypes.AwsLogSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAwsLogSource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerSubscriberSourceFactory, T1, T2, T3, InnerSubscriberAwsLogSourceFactory> WithAwsLogSource<T1, T2, T3>(this CombinedResult<InnerSubscriberSourceFactory, T1, T2, T3> combinedResult, Action<Humidifier.SecurityLake.SubscriberTypes.AwsLogSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAwsLogSource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerSubscriberSourceFactory, T2, T3, InnerSubscriberAwsLogSourceFactory> WithAwsLogSource<T1, T2, T3>(this CombinedResult<T1, InnerSubscriberSourceFactory, T2, T3> combinedResult, Action<Humidifier.SecurityLake.SubscriberTypes.AwsLogSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAwsLogSource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerSubscriberSourceFactory, T3, InnerSubscriberAwsLogSourceFactory> WithAwsLogSource<T1, T2, T3>(this CombinedResult<T1, T2, InnerSubscriberSourceFactory, T3> combinedResult, Action<Humidifier.SecurityLake.SubscriberTypes.AwsLogSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAwsLogSource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerSubscriberSourceFactory, InnerSubscriberAwsLogSourceFactory> WithAwsLogSource<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerSubscriberSourceFactory> combinedResult, Action<Humidifier.SecurityLake.SubscriberTypes.AwsLogSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAwsLogSource(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerSubscriberSourceFactory, T1, T2, T3, T4, InnerSubscriberAwsLogSourceFactory> WithAwsLogSource<T1, T2, T3, T4>(this CombinedResult<InnerSubscriberSourceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SecurityLake.SubscriberTypes.AwsLogSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAwsLogSource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerSubscriberSourceFactory, T2, T3, T4, InnerSubscriberAwsLogSourceFactory> WithAwsLogSource<T1, T2, T3, T4>(this CombinedResult<T1, InnerSubscriberSourceFactory, T2, T3, T4> combinedResult, Action<Humidifier.SecurityLake.SubscriberTypes.AwsLogSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAwsLogSource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerSubscriberSourceFactory, T3, T4, InnerSubscriberAwsLogSourceFactory> WithAwsLogSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerSubscriberSourceFactory, T3, T4> combinedResult, Action<Humidifier.SecurityLake.SubscriberTypes.AwsLogSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAwsLogSource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerSubscriberSourceFactory, T4, InnerSubscriberAwsLogSourceFactory> WithAwsLogSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerSubscriberSourceFactory, T4> combinedResult, Action<Humidifier.SecurityLake.SubscriberTypes.AwsLogSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAwsLogSource(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerSubscriberSourceFactory, InnerSubscriberAwsLogSourceFactory> WithAwsLogSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerSubscriberSourceFactory> combinedResult, Action<Humidifier.SecurityLake.SubscriberTypes.AwsLogSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAwsLogSource(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerSubscriberSourceFactory, T1, InnerSubscriberCustomLogSourceFactory> WithCustomLogSource<T1>(this CombinedResult<InnerSubscriberSourceFactory, T1> combinedResult, Action<Humidifier.SecurityLake.SubscriberTypes.CustomLogSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithCustomLogSource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerSubscriberSourceFactory, InnerSubscriberCustomLogSourceFactory> WithCustomLogSource<T1>(this CombinedResult<T1, InnerSubscriberSourceFactory> combinedResult, Action<Humidifier.SecurityLake.SubscriberTypes.CustomLogSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithCustomLogSource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerSubscriberSourceFactory, T1, T2, InnerSubscriberCustomLogSourceFactory> WithCustomLogSource<T1, T2>(this CombinedResult<InnerSubscriberSourceFactory, T1, T2> combinedResult, Action<Humidifier.SecurityLake.SubscriberTypes.CustomLogSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCustomLogSource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerSubscriberSourceFactory, T2, InnerSubscriberCustomLogSourceFactory> WithCustomLogSource<T1, T2>(this CombinedResult<T1, InnerSubscriberSourceFactory, T2> combinedResult, Action<Humidifier.SecurityLake.SubscriberTypes.CustomLogSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCustomLogSource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerSubscriberSourceFactory, InnerSubscriberCustomLogSourceFactory> WithCustomLogSource<T1, T2>(this CombinedResult<T1, T2, InnerSubscriberSourceFactory> combinedResult, Action<Humidifier.SecurityLake.SubscriberTypes.CustomLogSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCustomLogSource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerSubscriberSourceFactory, T1, T2, T3, InnerSubscriberCustomLogSourceFactory> WithCustomLogSource<T1, T2, T3>(this CombinedResult<InnerSubscriberSourceFactory, T1, T2, T3> combinedResult, Action<Humidifier.SecurityLake.SubscriberTypes.CustomLogSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomLogSource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerSubscriberSourceFactory, T2, T3, InnerSubscriberCustomLogSourceFactory> WithCustomLogSource<T1, T2, T3>(this CombinedResult<T1, InnerSubscriberSourceFactory, T2, T3> combinedResult, Action<Humidifier.SecurityLake.SubscriberTypes.CustomLogSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomLogSource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerSubscriberSourceFactory, T3, InnerSubscriberCustomLogSourceFactory> WithCustomLogSource<T1, T2, T3>(this CombinedResult<T1, T2, InnerSubscriberSourceFactory, T3> combinedResult, Action<Humidifier.SecurityLake.SubscriberTypes.CustomLogSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomLogSource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerSubscriberSourceFactory, InnerSubscriberCustomLogSourceFactory> WithCustomLogSource<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerSubscriberSourceFactory> combinedResult, Action<Humidifier.SecurityLake.SubscriberTypes.CustomLogSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomLogSource(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerSubscriberSourceFactory, T1, T2, T3, T4, InnerSubscriberCustomLogSourceFactory> WithCustomLogSource<T1, T2, T3, T4>(this CombinedResult<InnerSubscriberSourceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SecurityLake.SubscriberTypes.CustomLogSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomLogSource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerSubscriberSourceFactory, T2, T3, T4, InnerSubscriberCustomLogSourceFactory> WithCustomLogSource<T1, T2, T3, T4>(this CombinedResult<T1, InnerSubscriberSourceFactory, T2, T3, T4> combinedResult, Action<Humidifier.SecurityLake.SubscriberTypes.CustomLogSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomLogSource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerSubscriberSourceFactory, T3, T4, InnerSubscriberCustomLogSourceFactory> WithCustomLogSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerSubscriberSourceFactory, T3, T4> combinedResult, Action<Humidifier.SecurityLake.SubscriberTypes.CustomLogSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomLogSource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerSubscriberSourceFactory, T4, InnerSubscriberCustomLogSourceFactory> WithCustomLogSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerSubscriberSourceFactory, T4> combinedResult, Action<Humidifier.SecurityLake.SubscriberTypes.CustomLogSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomLogSource(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerSubscriberSourceFactory, InnerSubscriberCustomLogSourceFactory> WithCustomLogSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerSubscriberSourceFactory> combinedResult, Action<Humidifier.SecurityLake.SubscriberTypes.CustomLogSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomLogSource(combinedResult.T5, subFactoryAction));
}
