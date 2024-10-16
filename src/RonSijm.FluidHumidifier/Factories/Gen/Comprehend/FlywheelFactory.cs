// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Comprehend;

public class FlywheelFactory(string resourceName = null, Action<Humidifier.Comprehend.Flywheel> factoryAction = null) : ResourceFactory<Humidifier.Comprehend.Flywheel>(resourceName)
{

    internal InnerFlywheelTaskConfigFactory TaskConfigFactory { get; set; }

    internal InnerFlywheelDataSecurityConfigFactory DataSecurityConfigFactory { get; set; }

    protected override Humidifier.Comprehend.Flywheel Create()
    {
        var flywheelResult = CreateFlywheel();
        factoryAction?.Invoke(flywheelResult);

        return flywheelResult;
    }

    private Humidifier.Comprehend.Flywheel CreateFlywheel()
    {
        var flywheelResult = new Humidifier.Comprehend.Flywheel
        {
            GivenName = InputResourceName,
        };

        return flywheelResult;
    }
    public override void CreateChildren(Humidifier.Comprehend.Flywheel result)
    {
        base.CreateChildren(result);

        result.TaskConfig ??= TaskConfigFactory?.Build();
        result.DataSecurityConfig ??= DataSecurityConfigFactory?.Build();
    }

} // End Of Class

public static class FlywheelFactoryExtensions
{
    public static CombinedResult<FlywheelFactory, InnerFlywheelTaskConfigFactory> WithTaskConfig(this FlywheelFactory parentFactory, Action<Humidifier.Comprehend.FlywheelTypes.TaskConfig> subFactoryAction = null)
    {
        parentFactory.TaskConfigFactory = new InnerFlywheelTaskConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.TaskConfigFactory);
    }

    public static CombinedResult<FlywheelFactory, InnerFlywheelDataSecurityConfigFactory> WithDataSecurityConfig(this FlywheelFactory parentFactory, Action<Humidifier.Comprehend.FlywheelTypes.DataSecurityConfig> subFactoryAction = null)
    {
        parentFactory.DataSecurityConfigFactory = new InnerFlywheelDataSecurityConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DataSecurityConfigFactory);
    }

    public static CombinedResult<FlywheelFactory, T1, InnerFlywheelTaskConfigFactory> WithTaskConfig<T1>(this CombinedResult<FlywheelFactory, T1> combinedResult, Action<Humidifier.Comprehend.FlywheelTypes.TaskConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithTaskConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FlywheelFactory, InnerFlywheelTaskConfigFactory> WithTaskConfig<T1>(this CombinedResult<T1, FlywheelFactory> combinedResult, Action<Humidifier.Comprehend.FlywheelTypes.TaskConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithTaskConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<FlywheelFactory, T1, T2, InnerFlywheelTaskConfigFactory> WithTaskConfig<T1, T2>(this CombinedResult<FlywheelFactory, T1, T2> combinedResult, Action<Humidifier.Comprehend.FlywheelTypes.TaskConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTaskConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FlywheelFactory, T2, InnerFlywheelTaskConfigFactory> WithTaskConfig<T1, T2>(this CombinedResult<T1, FlywheelFactory, T2> combinedResult, Action<Humidifier.Comprehend.FlywheelTypes.TaskConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTaskConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FlywheelFactory, InnerFlywheelTaskConfigFactory> WithTaskConfig<T1, T2>(this CombinedResult<T1, T2, FlywheelFactory> combinedResult, Action<Humidifier.Comprehend.FlywheelTypes.TaskConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTaskConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<FlywheelFactory, T1, T2, T3, InnerFlywheelTaskConfigFactory> WithTaskConfig<T1, T2, T3>(this CombinedResult<FlywheelFactory, T1, T2, T3> combinedResult, Action<Humidifier.Comprehend.FlywheelTypes.TaskConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTaskConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FlywheelFactory, T2, T3, InnerFlywheelTaskConfigFactory> WithTaskConfig<T1, T2, T3>(this CombinedResult<T1, FlywheelFactory, T2, T3> combinedResult, Action<Humidifier.Comprehend.FlywheelTypes.TaskConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTaskConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FlywheelFactory, T3, InnerFlywheelTaskConfigFactory> WithTaskConfig<T1, T2, T3>(this CombinedResult<T1, T2, FlywheelFactory, T3> combinedResult, Action<Humidifier.Comprehend.FlywheelTypes.TaskConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTaskConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, FlywheelFactory, InnerFlywheelTaskConfigFactory> WithTaskConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, FlywheelFactory> combinedResult, Action<Humidifier.Comprehend.FlywheelTypes.TaskConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTaskConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<FlywheelFactory, T1, T2, T3, T4, InnerFlywheelTaskConfigFactory> WithTaskConfig<T1, T2, T3, T4>(this CombinedResult<FlywheelFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Comprehend.FlywheelTypes.TaskConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTaskConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FlywheelFactory, T2, T3, T4, InnerFlywheelTaskConfigFactory> WithTaskConfig<T1, T2, T3, T4>(this CombinedResult<T1, FlywheelFactory, T2, T3, T4> combinedResult, Action<Humidifier.Comprehend.FlywheelTypes.TaskConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTaskConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FlywheelFactory, T3, T4, InnerFlywheelTaskConfigFactory> WithTaskConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, FlywheelFactory, T3, T4> combinedResult, Action<Humidifier.Comprehend.FlywheelTypes.TaskConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTaskConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, FlywheelFactory, T4, InnerFlywheelTaskConfigFactory> WithTaskConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, FlywheelFactory, T4> combinedResult, Action<Humidifier.Comprehend.FlywheelTypes.TaskConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTaskConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, FlywheelFactory, InnerFlywheelTaskConfigFactory> WithTaskConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, FlywheelFactory> combinedResult, Action<Humidifier.Comprehend.FlywheelTypes.TaskConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTaskConfig(combinedResult.T5, subFactoryAction));
    public static CombinedResult<FlywheelFactory, T1, InnerFlywheelDataSecurityConfigFactory> WithDataSecurityConfig<T1>(this CombinedResult<FlywheelFactory, T1> combinedResult, Action<Humidifier.Comprehend.FlywheelTypes.DataSecurityConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithDataSecurityConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FlywheelFactory, InnerFlywheelDataSecurityConfigFactory> WithDataSecurityConfig<T1>(this CombinedResult<T1, FlywheelFactory> combinedResult, Action<Humidifier.Comprehend.FlywheelTypes.DataSecurityConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithDataSecurityConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<FlywheelFactory, T1, T2, InnerFlywheelDataSecurityConfigFactory> WithDataSecurityConfig<T1, T2>(this CombinedResult<FlywheelFactory, T1, T2> combinedResult, Action<Humidifier.Comprehend.FlywheelTypes.DataSecurityConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDataSecurityConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FlywheelFactory, T2, InnerFlywheelDataSecurityConfigFactory> WithDataSecurityConfig<T1, T2>(this CombinedResult<T1, FlywheelFactory, T2> combinedResult, Action<Humidifier.Comprehend.FlywheelTypes.DataSecurityConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDataSecurityConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FlywheelFactory, InnerFlywheelDataSecurityConfigFactory> WithDataSecurityConfig<T1, T2>(this CombinedResult<T1, T2, FlywheelFactory> combinedResult, Action<Humidifier.Comprehend.FlywheelTypes.DataSecurityConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDataSecurityConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<FlywheelFactory, T1, T2, T3, InnerFlywheelDataSecurityConfigFactory> WithDataSecurityConfig<T1, T2, T3>(this CombinedResult<FlywheelFactory, T1, T2, T3> combinedResult, Action<Humidifier.Comprehend.FlywheelTypes.DataSecurityConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataSecurityConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FlywheelFactory, T2, T3, InnerFlywheelDataSecurityConfigFactory> WithDataSecurityConfig<T1, T2, T3>(this CombinedResult<T1, FlywheelFactory, T2, T3> combinedResult, Action<Humidifier.Comprehend.FlywheelTypes.DataSecurityConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataSecurityConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FlywheelFactory, T3, InnerFlywheelDataSecurityConfigFactory> WithDataSecurityConfig<T1, T2, T3>(this CombinedResult<T1, T2, FlywheelFactory, T3> combinedResult, Action<Humidifier.Comprehend.FlywheelTypes.DataSecurityConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataSecurityConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, FlywheelFactory, InnerFlywheelDataSecurityConfigFactory> WithDataSecurityConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, FlywheelFactory> combinedResult, Action<Humidifier.Comprehend.FlywheelTypes.DataSecurityConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataSecurityConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<FlywheelFactory, T1, T2, T3, T4, InnerFlywheelDataSecurityConfigFactory> WithDataSecurityConfig<T1, T2, T3, T4>(this CombinedResult<FlywheelFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Comprehend.FlywheelTypes.DataSecurityConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataSecurityConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FlywheelFactory, T2, T3, T4, InnerFlywheelDataSecurityConfigFactory> WithDataSecurityConfig<T1, T2, T3, T4>(this CombinedResult<T1, FlywheelFactory, T2, T3, T4> combinedResult, Action<Humidifier.Comprehend.FlywheelTypes.DataSecurityConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataSecurityConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FlywheelFactory, T3, T4, InnerFlywheelDataSecurityConfigFactory> WithDataSecurityConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, FlywheelFactory, T3, T4> combinedResult, Action<Humidifier.Comprehend.FlywheelTypes.DataSecurityConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataSecurityConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, FlywheelFactory, T4, InnerFlywheelDataSecurityConfigFactory> WithDataSecurityConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, FlywheelFactory, T4> combinedResult, Action<Humidifier.Comprehend.FlywheelTypes.DataSecurityConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataSecurityConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, FlywheelFactory, InnerFlywheelDataSecurityConfigFactory> WithDataSecurityConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, FlywheelFactory> combinedResult, Action<Humidifier.Comprehend.FlywheelTypes.DataSecurityConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataSecurityConfig(combinedResult.T5, subFactoryAction));
}
