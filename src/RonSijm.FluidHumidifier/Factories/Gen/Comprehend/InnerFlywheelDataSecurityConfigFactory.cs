// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Comprehend;

public class InnerFlywheelDataSecurityConfigFactory(Action<Humidifier.Comprehend.FlywheelTypes.DataSecurityConfig> factoryAction = null) : SubResourceFactory<Humidifier.Comprehend.FlywheelTypes.DataSecurityConfig>
{

    internal InnerFlywheelVpcConfigFactory VpcConfigFactory { get; set; }

    protected override Humidifier.Comprehend.FlywheelTypes.DataSecurityConfig Create()
    {
        var dataSecurityConfigResult = CreateDataSecurityConfig();
        factoryAction?.Invoke(dataSecurityConfigResult);

        return dataSecurityConfigResult;
    }

    private Humidifier.Comprehend.FlywheelTypes.DataSecurityConfig CreateDataSecurityConfig()
    {
        var dataSecurityConfigResult = new Humidifier.Comprehend.FlywheelTypes.DataSecurityConfig();

        return dataSecurityConfigResult;
    }
    public override void CreateChildren(Humidifier.Comprehend.FlywheelTypes.DataSecurityConfig result)
    {
        base.CreateChildren(result);

        result.VpcConfig ??= VpcConfigFactory?.Build();
    }

} // End Of Class

public static class InnerFlywheelDataSecurityConfigFactoryExtensions
{
    public static CombinedResult<InnerFlywheelDataSecurityConfigFactory, InnerFlywheelVpcConfigFactory> WithVpcConfig(this InnerFlywheelDataSecurityConfigFactory parentFactory, Action<Humidifier.Comprehend.FlywheelTypes.VpcConfig> subFactoryAction = null)
    {
        parentFactory.VpcConfigFactory = new InnerFlywheelVpcConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.VpcConfigFactory);
    }

    public static CombinedResult<InnerFlywheelDataSecurityConfigFactory, T1, InnerFlywheelVpcConfigFactory> WithVpcConfig<T1>(this CombinedResult<InnerFlywheelDataSecurityConfigFactory, T1> combinedResult, Action<Humidifier.Comprehend.FlywheelTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithVpcConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFlywheelDataSecurityConfigFactory, InnerFlywheelVpcConfigFactory> WithVpcConfig<T1>(this CombinedResult<T1, InnerFlywheelDataSecurityConfigFactory> combinedResult, Action<Humidifier.Comprehend.FlywheelTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithVpcConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerFlywheelDataSecurityConfigFactory, T1, T2, InnerFlywheelVpcConfigFactory> WithVpcConfig<T1, T2>(this CombinedResult<InnerFlywheelDataSecurityConfigFactory, T1, T2> combinedResult, Action<Humidifier.Comprehend.FlywheelTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFlywheelDataSecurityConfigFactory, T2, InnerFlywheelVpcConfigFactory> WithVpcConfig<T1, T2>(this CombinedResult<T1, InnerFlywheelDataSecurityConfigFactory, T2> combinedResult, Action<Humidifier.Comprehend.FlywheelTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFlywheelDataSecurityConfigFactory, InnerFlywheelVpcConfigFactory> WithVpcConfig<T1, T2>(this CombinedResult<T1, T2, InnerFlywheelDataSecurityConfigFactory> combinedResult, Action<Humidifier.Comprehend.FlywheelTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerFlywheelDataSecurityConfigFactory, T1, T2, T3, InnerFlywheelVpcConfigFactory> WithVpcConfig<T1, T2, T3>(this CombinedResult<InnerFlywheelDataSecurityConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.Comprehend.FlywheelTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFlywheelDataSecurityConfigFactory, T2, T3, InnerFlywheelVpcConfigFactory> WithVpcConfig<T1, T2, T3>(this CombinedResult<T1, InnerFlywheelDataSecurityConfigFactory, T2, T3> combinedResult, Action<Humidifier.Comprehend.FlywheelTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFlywheelDataSecurityConfigFactory, T3, InnerFlywheelVpcConfigFactory> WithVpcConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerFlywheelDataSecurityConfigFactory, T3> combinedResult, Action<Humidifier.Comprehend.FlywheelTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFlywheelDataSecurityConfigFactory, InnerFlywheelVpcConfigFactory> WithVpcConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerFlywheelDataSecurityConfigFactory> combinedResult, Action<Humidifier.Comprehend.FlywheelTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerFlywheelDataSecurityConfigFactory, T1, T2, T3, T4, InnerFlywheelVpcConfigFactory> WithVpcConfig<T1, T2, T3, T4>(this CombinedResult<InnerFlywheelDataSecurityConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Comprehend.FlywheelTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFlywheelDataSecurityConfigFactory, T2, T3, T4, InnerFlywheelVpcConfigFactory> WithVpcConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerFlywheelDataSecurityConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.Comprehend.FlywheelTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFlywheelDataSecurityConfigFactory, T3, T4, InnerFlywheelVpcConfigFactory> WithVpcConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerFlywheelDataSecurityConfigFactory, T3, T4> combinedResult, Action<Humidifier.Comprehend.FlywheelTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFlywheelDataSecurityConfigFactory, T4, InnerFlywheelVpcConfigFactory> WithVpcConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerFlywheelDataSecurityConfigFactory, T4> combinedResult, Action<Humidifier.Comprehend.FlywheelTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerFlywheelDataSecurityConfigFactory, InnerFlywheelVpcConfigFactory> WithVpcConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerFlywheelDataSecurityConfigFactory> combinedResult, Action<Humidifier.Comprehend.FlywheelTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T5, subFactoryAction));
}
