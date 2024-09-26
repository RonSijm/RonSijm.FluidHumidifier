// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class AppFactory(string resourceName = null, Action<Humidifier.SageMaker.App> factoryAction = null) : ResourceFactory<Humidifier.SageMaker.App>(resourceName)
{

    internal InnerAppResourceSpecFactory ResourceSpecFactory { get; set; }

    protected override Humidifier.SageMaker.App Create()
    {
        var appResult = CreateApp();
        factoryAction?.Invoke(appResult);

        return appResult;
    }

    private Humidifier.SageMaker.App CreateApp()
    {
        var appResult = new Humidifier.SageMaker.App
        {
            GivenName = InputResourceName,
        };

        return appResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.App result)
    {
        base.CreateChildren(result);

        result.ResourceSpec ??= ResourceSpecFactory?.Build();
    }

} // End Of Class

public static class AppFactoryExtensions
{
    public static CombinedResult<AppFactory, InnerAppResourceSpecFactory> WithResourceSpec(this AppFactory parentFactory, Action<Humidifier.SageMaker.AppTypes.ResourceSpec> subFactoryAction = null)
    {
        parentFactory.ResourceSpecFactory = new InnerAppResourceSpecFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ResourceSpecFactory);
    }

    public static CombinedResult<AppFactory, T1, InnerAppResourceSpecFactory> WithResourceSpec<T1>(this CombinedResult<AppFactory, T1> combinedResult, Action<Humidifier.SageMaker.AppTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, WithResourceSpec(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AppFactory, InnerAppResourceSpecFactory> WithResourceSpec<T1>(this CombinedResult<T1, AppFactory> combinedResult, Action<Humidifier.SageMaker.AppTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, WithResourceSpec(combinedResult.T2, subFactoryAction));
    public static CombinedResult<AppFactory, T1, T2, InnerAppResourceSpecFactory> WithResourceSpec<T1, T2>(this CombinedResult<AppFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.AppTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithResourceSpec(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AppFactory, T2, InnerAppResourceSpecFactory> WithResourceSpec<T1, T2>(this CombinedResult<T1, AppFactory, T2> combinedResult, Action<Humidifier.SageMaker.AppTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithResourceSpec(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AppFactory, InnerAppResourceSpecFactory> WithResourceSpec<T1, T2>(this CombinedResult<T1, T2, AppFactory> combinedResult, Action<Humidifier.SageMaker.AppTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithResourceSpec(combinedResult.T3, subFactoryAction));
    public static CombinedResult<AppFactory, T1, T2, T3, InnerAppResourceSpecFactory> WithResourceSpec<T1, T2, T3>(this CombinedResult<AppFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.AppTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResourceSpec(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AppFactory, T2, T3, InnerAppResourceSpecFactory> WithResourceSpec<T1, T2, T3>(this CombinedResult<T1, AppFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.AppTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResourceSpec(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AppFactory, T3, InnerAppResourceSpecFactory> WithResourceSpec<T1, T2, T3>(this CombinedResult<T1, T2, AppFactory, T3> combinedResult, Action<Humidifier.SageMaker.AppTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResourceSpec(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, AppFactory, InnerAppResourceSpecFactory> WithResourceSpec<T1, T2, T3>(this CombinedResult<T1, T2, T3, AppFactory> combinedResult, Action<Humidifier.SageMaker.AppTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResourceSpec(combinedResult.T4, subFactoryAction));
    public static CombinedResult<AppFactory, T1, T2, T3, T4, InnerAppResourceSpecFactory> WithResourceSpec<T1, T2, T3, T4>(this CombinedResult<AppFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.AppTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceSpec(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AppFactory, T2, T3, T4, InnerAppResourceSpecFactory> WithResourceSpec<T1, T2, T3, T4>(this CombinedResult<T1, AppFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.AppTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceSpec(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AppFactory, T3, T4, InnerAppResourceSpecFactory> WithResourceSpec<T1, T2, T3, T4>(this CombinedResult<T1, T2, AppFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.AppTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceSpec(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, AppFactory, T4, InnerAppResourceSpecFactory> WithResourceSpec<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, AppFactory, T4> combinedResult, Action<Humidifier.SageMaker.AppTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceSpec(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, AppFactory, InnerAppResourceSpecFactory> WithResourceSpec<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, AppFactory> combinedResult, Action<Humidifier.SageMaker.AppTypes.ResourceSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceSpec(combinedResult.T5, subFactoryAction));
}
