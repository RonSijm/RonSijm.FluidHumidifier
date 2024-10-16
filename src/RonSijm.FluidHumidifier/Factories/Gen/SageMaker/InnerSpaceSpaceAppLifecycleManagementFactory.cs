// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerSpaceSpaceAppLifecycleManagementFactory(Action<Humidifier.SageMaker.SpaceTypes.SpaceAppLifecycleManagement> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.SpaceTypes.SpaceAppLifecycleManagement>
{

    internal InnerSpaceSpaceIdleSettingsFactory IdleSettingsFactory { get; set; }

    protected override Humidifier.SageMaker.SpaceTypes.SpaceAppLifecycleManagement Create()
    {
        var spaceAppLifecycleManagementResult = CreateSpaceAppLifecycleManagement();
        factoryAction?.Invoke(spaceAppLifecycleManagementResult);

        return spaceAppLifecycleManagementResult;
    }

    private Humidifier.SageMaker.SpaceTypes.SpaceAppLifecycleManagement CreateSpaceAppLifecycleManagement()
    {
        var spaceAppLifecycleManagementResult = new Humidifier.SageMaker.SpaceTypes.SpaceAppLifecycleManagement();

        return spaceAppLifecycleManagementResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.SpaceTypes.SpaceAppLifecycleManagement result)
    {
        base.CreateChildren(result);

        result.IdleSettings ??= IdleSettingsFactory?.Build();
    }

} // End Of Class

public static class InnerSpaceSpaceAppLifecycleManagementFactoryExtensions
{
    public static CombinedResult<InnerSpaceSpaceAppLifecycleManagementFactory, InnerSpaceSpaceIdleSettingsFactory> WithIdleSettings(this InnerSpaceSpaceAppLifecycleManagementFactory parentFactory, Action<Humidifier.SageMaker.SpaceTypes.SpaceIdleSettings> subFactoryAction = null)
    {
        parentFactory.IdleSettingsFactory = new InnerSpaceSpaceIdleSettingsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.IdleSettingsFactory);
    }

    public static CombinedResult<InnerSpaceSpaceAppLifecycleManagementFactory, T1, InnerSpaceSpaceIdleSettingsFactory> WithIdleSettings<T1>(this CombinedResult<InnerSpaceSpaceAppLifecycleManagementFactory, T1> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.SpaceIdleSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithIdleSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerSpaceSpaceAppLifecycleManagementFactory, InnerSpaceSpaceIdleSettingsFactory> WithIdleSettings<T1>(this CombinedResult<T1, InnerSpaceSpaceAppLifecycleManagementFactory> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.SpaceIdleSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithIdleSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerSpaceSpaceAppLifecycleManagementFactory, T1, T2, InnerSpaceSpaceIdleSettingsFactory> WithIdleSettings<T1, T2>(this CombinedResult<InnerSpaceSpaceAppLifecycleManagementFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.SpaceIdleSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIdleSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerSpaceSpaceAppLifecycleManagementFactory, T2, InnerSpaceSpaceIdleSettingsFactory> WithIdleSettings<T1, T2>(this CombinedResult<T1, InnerSpaceSpaceAppLifecycleManagementFactory, T2> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.SpaceIdleSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIdleSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerSpaceSpaceAppLifecycleManagementFactory, InnerSpaceSpaceIdleSettingsFactory> WithIdleSettings<T1, T2>(this CombinedResult<T1, T2, InnerSpaceSpaceAppLifecycleManagementFactory> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.SpaceIdleSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIdleSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerSpaceSpaceAppLifecycleManagementFactory, T1, T2, T3, InnerSpaceSpaceIdleSettingsFactory> WithIdleSettings<T1, T2, T3>(this CombinedResult<InnerSpaceSpaceAppLifecycleManagementFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.SpaceIdleSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIdleSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerSpaceSpaceAppLifecycleManagementFactory, T2, T3, InnerSpaceSpaceIdleSettingsFactory> WithIdleSettings<T1, T2, T3>(this CombinedResult<T1, InnerSpaceSpaceAppLifecycleManagementFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.SpaceIdleSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIdleSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerSpaceSpaceAppLifecycleManagementFactory, T3, InnerSpaceSpaceIdleSettingsFactory> WithIdleSettings<T1, T2, T3>(this CombinedResult<T1, T2, InnerSpaceSpaceAppLifecycleManagementFactory, T3> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.SpaceIdleSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIdleSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerSpaceSpaceAppLifecycleManagementFactory, InnerSpaceSpaceIdleSettingsFactory> WithIdleSettings<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerSpaceSpaceAppLifecycleManagementFactory> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.SpaceIdleSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIdleSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerSpaceSpaceAppLifecycleManagementFactory, T1, T2, T3, T4, InnerSpaceSpaceIdleSettingsFactory> WithIdleSettings<T1, T2, T3, T4>(this CombinedResult<InnerSpaceSpaceAppLifecycleManagementFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.SpaceIdleSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdleSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerSpaceSpaceAppLifecycleManagementFactory, T2, T3, T4, InnerSpaceSpaceIdleSettingsFactory> WithIdleSettings<T1, T2, T3, T4>(this CombinedResult<T1, InnerSpaceSpaceAppLifecycleManagementFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.SpaceIdleSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdleSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerSpaceSpaceAppLifecycleManagementFactory, T3, T4, InnerSpaceSpaceIdleSettingsFactory> WithIdleSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerSpaceSpaceAppLifecycleManagementFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.SpaceIdleSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdleSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerSpaceSpaceAppLifecycleManagementFactory, T4, InnerSpaceSpaceIdleSettingsFactory> WithIdleSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerSpaceSpaceAppLifecycleManagementFactory, T4> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.SpaceIdleSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdleSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerSpaceSpaceAppLifecycleManagementFactory, InnerSpaceSpaceIdleSettingsFactory> WithIdleSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerSpaceSpaceAppLifecycleManagementFactory> combinedResult, Action<Humidifier.SageMaker.SpaceTypes.SpaceIdleSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdleSettings(combinedResult.T5, subFactoryAction));
}
