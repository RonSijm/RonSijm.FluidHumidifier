// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.KinesisAnalyticsV2;

public class ApplicationOutputFactory(string resourceName = null, Action<Humidifier.KinesisAnalyticsV2.ApplicationOutput> factoryAction = null) : ResourceFactory<Humidifier.KinesisAnalyticsV2.ApplicationOutput>(resourceName)
{

    internal InnerApplicationOutputOutputFactory OutputFactory { get; set; }

    protected override Humidifier.KinesisAnalyticsV2.ApplicationOutput Create()
    {
        var applicationOutputResult = CreateApplicationOutput();
        factoryAction?.Invoke(applicationOutputResult);

        return applicationOutputResult;
    }

    private Humidifier.KinesisAnalyticsV2.ApplicationOutput CreateApplicationOutput()
    {
        var applicationOutputResult = new Humidifier.KinesisAnalyticsV2.ApplicationOutput
        {
            GivenName = InputResourceName,
        };

        return applicationOutputResult;
    }
    public override void CreateChildren(Humidifier.KinesisAnalyticsV2.ApplicationOutput result)
    {
        base.CreateChildren(result);

        result.Output ??= OutputFactory?.Build();
    }

} // End Of Class

public static class ApplicationOutputFactoryExtensions
{
    public static CombinedResult<ApplicationOutputFactory, InnerApplicationOutputOutputFactory> WithOutput(this ApplicationOutputFactory parentFactory, Action<Humidifier.KinesisAnalyticsV2.ApplicationOutputTypes.Output> subFactoryAction = null)
    {
        parentFactory.OutputFactory = new InnerApplicationOutputOutputFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.OutputFactory);
    }

    public static CombinedResult<ApplicationOutputFactory, T1, InnerApplicationOutputOutputFactory> WithOutput<T1>(this CombinedResult<ApplicationOutputFactory, T1> combinedResult, Action<Humidifier.KinesisAnalyticsV2.ApplicationOutputTypes.Output> subFactoryAction = null) => new (combinedResult, combinedResult, WithOutput(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ApplicationOutputFactory, InnerApplicationOutputOutputFactory> WithOutput<T1>(this CombinedResult<T1, ApplicationOutputFactory> combinedResult, Action<Humidifier.KinesisAnalyticsV2.ApplicationOutputTypes.Output> subFactoryAction = null) => new (combinedResult, combinedResult, WithOutput(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ApplicationOutputFactory, T1, T2, InnerApplicationOutputOutputFactory> WithOutput<T1, T2>(this CombinedResult<ApplicationOutputFactory, T1, T2> combinedResult, Action<Humidifier.KinesisAnalyticsV2.ApplicationOutputTypes.Output> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOutput(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ApplicationOutputFactory, T2, InnerApplicationOutputOutputFactory> WithOutput<T1, T2>(this CombinedResult<T1, ApplicationOutputFactory, T2> combinedResult, Action<Humidifier.KinesisAnalyticsV2.ApplicationOutputTypes.Output> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOutput(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ApplicationOutputFactory, InnerApplicationOutputOutputFactory> WithOutput<T1, T2>(this CombinedResult<T1, T2, ApplicationOutputFactory> combinedResult, Action<Humidifier.KinesisAnalyticsV2.ApplicationOutputTypes.Output> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOutput(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ApplicationOutputFactory, T1, T2, T3, InnerApplicationOutputOutputFactory> WithOutput<T1, T2, T3>(this CombinedResult<ApplicationOutputFactory, T1, T2, T3> combinedResult, Action<Humidifier.KinesisAnalyticsV2.ApplicationOutputTypes.Output> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOutput(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ApplicationOutputFactory, T2, T3, InnerApplicationOutputOutputFactory> WithOutput<T1, T2, T3>(this CombinedResult<T1, ApplicationOutputFactory, T2, T3> combinedResult, Action<Humidifier.KinesisAnalyticsV2.ApplicationOutputTypes.Output> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOutput(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ApplicationOutputFactory, T3, InnerApplicationOutputOutputFactory> WithOutput<T1, T2, T3>(this CombinedResult<T1, T2, ApplicationOutputFactory, T3> combinedResult, Action<Humidifier.KinesisAnalyticsV2.ApplicationOutputTypes.Output> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOutput(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ApplicationOutputFactory, InnerApplicationOutputOutputFactory> WithOutput<T1, T2, T3>(this CombinedResult<T1, T2, T3, ApplicationOutputFactory> combinedResult, Action<Humidifier.KinesisAnalyticsV2.ApplicationOutputTypes.Output> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOutput(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ApplicationOutputFactory, T1, T2, T3, T4, InnerApplicationOutputOutputFactory> WithOutput<T1, T2, T3, T4>(this CombinedResult<ApplicationOutputFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.KinesisAnalyticsV2.ApplicationOutputTypes.Output> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOutput(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ApplicationOutputFactory, T2, T3, T4, InnerApplicationOutputOutputFactory> WithOutput<T1, T2, T3, T4>(this CombinedResult<T1, ApplicationOutputFactory, T2, T3, T4> combinedResult, Action<Humidifier.KinesisAnalyticsV2.ApplicationOutputTypes.Output> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOutput(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ApplicationOutputFactory, T3, T4, InnerApplicationOutputOutputFactory> WithOutput<T1, T2, T3, T4>(this CombinedResult<T1, T2, ApplicationOutputFactory, T3, T4> combinedResult, Action<Humidifier.KinesisAnalyticsV2.ApplicationOutputTypes.Output> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOutput(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ApplicationOutputFactory, T4, InnerApplicationOutputOutputFactory> WithOutput<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ApplicationOutputFactory, T4> combinedResult, Action<Humidifier.KinesisAnalyticsV2.ApplicationOutputTypes.Output> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOutput(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ApplicationOutputFactory, InnerApplicationOutputOutputFactory> WithOutput<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ApplicationOutputFactory> combinedResult, Action<Humidifier.KinesisAnalyticsV2.ApplicationOutputTypes.Output> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOutput(combinedResult.T5, subFactoryAction));
}
