// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.KinesisAnalytics;

public class ApplicationFactory(string resourceName = null, Action<Humidifier.KinesisAnalytics.Application> factoryAction = null) : ResourceFactory<Humidifier.KinesisAnalytics.Application>(resourceName)
{

    internal List<InnerApplicationInputFactory> InputsFactories { get; set; } = [];

    protected override Humidifier.KinesisAnalytics.Application Create()
    {
        var applicationResult = CreateApplication();
        factoryAction?.Invoke(applicationResult);

        return applicationResult;
    }

    private Humidifier.KinesisAnalytics.Application CreateApplication()
    {
        var applicationResult = new Humidifier.KinesisAnalytics.Application
        {
            GivenName = InputResourceName,
        };

        return applicationResult;
    }
    public override void CreateChildren(Humidifier.KinesisAnalytics.Application result)
    {
        base.CreateChildren(result);

        result.Inputs = InputsFactories.Any() ? InputsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class ApplicationFactoryExtensions
{
    public static CombinedResult<ApplicationFactory, InnerApplicationInputFactory> WithInputs(this ApplicationFactory parentFactory, Action<Humidifier.KinesisAnalytics.ApplicationTypes.Input> subFactoryAction = null)
    {
        var factory = new InnerApplicationInputFactory(subFactoryAction);
        parentFactory.InputsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<ApplicationFactory, T1, InnerApplicationInputFactory> WithInputs<T1>(this CombinedResult<ApplicationFactory, T1> combinedResult, Action<Humidifier.KinesisAnalytics.ApplicationTypes.Input> subFactoryAction = null) => new (combinedResult, combinedResult, WithInputs(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ApplicationFactory, InnerApplicationInputFactory> WithInputs<T1>(this CombinedResult<T1, ApplicationFactory> combinedResult, Action<Humidifier.KinesisAnalytics.ApplicationTypes.Input> subFactoryAction = null) => new (combinedResult, combinedResult, WithInputs(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ApplicationFactory, T1, T2, InnerApplicationInputFactory> WithInputs<T1, T2>(this CombinedResult<ApplicationFactory, T1, T2> combinedResult, Action<Humidifier.KinesisAnalytics.ApplicationTypes.Input> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInputs(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ApplicationFactory, T2, InnerApplicationInputFactory> WithInputs<T1, T2>(this CombinedResult<T1, ApplicationFactory, T2> combinedResult, Action<Humidifier.KinesisAnalytics.ApplicationTypes.Input> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInputs(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ApplicationFactory, InnerApplicationInputFactory> WithInputs<T1, T2>(this CombinedResult<T1, T2, ApplicationFactory> combinedResult, Action<Humidifier.KinesisAnalytics.ApplicationTypes.Input> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInputs(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ApplicationFactory, T1, T2, T3, InnerApplicationInputFactory> WithInputs<T1, T2, T3>(this CombinedResult<ApplicationFactory, T1, T2, T3> combinedResult, Action<Humidifier.KinesisAnalytics.ApplicationTypes.Input> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInputs(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ApplicationFactory, T2, T3, InnerApplicationInputFactory> WithInputs<T1, T2, T3>(this CombinedResult<T1, ApplicationFactory, T2, T3> combinedResult, Action<Humidifier.KinesisAnalytics.ApplicationTypes.Input> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInputs(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ApplicationFactory, T3, InnerApplicationInputFactory> WithInputs<T1, T2, T3>(this CombinedResult<T1, T2, ApplicationFactory, T3> combinedResult, Action<Humidifier.KinesisAnalytics.ApplicationTypes.Input> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInputs(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ApplicationFactory, InnerApplicationInputFactory> WithInputs<T1, T2, T3>(this CombinedResult<T1, T2, T3, ApplicationFactory> combinedResult, Action<Humidifier.KinesisAnalytics.ApplicationTypes.Input> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInputs(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ApplicationFactory, T1, T2, T3, T4, InnerApplicationInputFactory> WithInputs<T1, T2, T3, T4>(this CombinedResult<ApplicationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.KinesisAnalytics.ApplicationTypes.Input> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInputs(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ApplicationFactory, T2, T3, T4, InnerApplicationInputFactory> WithInputs<T1, T2, T3, T4>(this CombinedResult<T1, ApplicationFactory, T2, T3, T4> combinedResult, Action<Humidifier.KinesisAnalytics.ApplicationTypes.Input> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInputs(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ApplicationFactory, T3, T4, InnerApplicationInputFactory> WithInputs<T1, T2, T3, T4>(this CombinedResult<T1, T2, ApplicationFactory, T3, T4> combinedResult, Action<Humidifier.KinesisAnalytics.ApplicationTypes.Input> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInputs(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ApplicationFactory, T4, InnerApplicationInputFactory> WithInputs<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ApplicationFactory, T4> combinedResult, Action<Humidifier.KinesisAnalytics.ApplicationTypes.Input> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInputs(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ApplicationFactory, InnerApplicationInputFactory> WithInputs<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ApplicationFactory> combinedResult, Action<Humidifier.KinesisAnalytics.ApplicationTypes.Input> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInputs(combinedResult.T5, subFactoryAction));
}
