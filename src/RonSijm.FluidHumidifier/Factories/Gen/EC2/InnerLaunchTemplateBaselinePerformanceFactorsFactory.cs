// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerLaunchTemplateBaselinePerformanceFactorsFactory(Action<Humidifier.EC2.LaunchTemplateTypes.BaselinePerformanceFactors> factoryAction = null) : SubResourceFactory<Humidifier.EC2.LaunchTemplateTypes.BaselinePerformanceFactors>
{

    internal InnerLaunchTemplateCpuFactory CpuFactory { get; set; }

    protected override Humidifier.EC2.LaunchTemplateTypes.BaselinePerformanceFactors Create()
    {
        var baselinePerformanceFactorsResult = CreateBaselinePerformanceFactors();
        factoryAction?.Invoke(baselinePerformanceFactorsResult);

        return baselinePerformanceFactorsResult;
    }

    private Humidifier.EC2.LaunchTemplateTypes.BaselinePerformanceFactors CreateBaselinePerformanceFactors()
    {
        var baselinePerformanceFactorsResult = new Humidifier.EC2.LaunchTemplateTypes.BaselinePerformanceFactors();

        return baselinePerformanceFactorsResult;
    }
    public override void CreateChildren(Humidifier.EC2.LaunchTemplateTypes.BaselinePerformanceFactors result)
    {
        base.CreateChildren(result);

        result.Cpu ??= CpuFactory?.Build();
    }

} // End Of Class

public static class InnerLaunchTemplateBaselinePerformanceFactorsFactoryExtensions
{
    public static CombinedResult<InnerLaunchTemplateBaselinePerformanceFactorsFactory, InnerLaunchTemplateCpuFactory> WithCpu(this InnerLaunchTemplateBaselinePerformanceFactorsFactory parentFactory, Action<Humidifier.EC2.LaunchTemplateTypes.Cpu> subFactoryAction = null)
    {
        parentFactory.CpuFactory = new InnerLaunchTemplateCpuFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CpuFactory);
    }

    public static CombinedResult<InnerLaunchTemplateBaselinePerformanceFactorsFactory, T1, InnerLaunchTemplateCpuFactory> WithCpu<T1>(this CombinedResult<InnerLaunchTemplateBaselinePerformanceFactorsFactory, T1> combinedResult, Action<Humidifier.EC2.LaunchTemplateTypes.Cpu> subFactoryAction = null) => new (combinedResult, combinedResult, WithCpu(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerLaunchTemplateBaselinePerformanceFactorsFactory, InnerLaunchTemplateCpuFactory> WithCpu<T1>(this CombinedResult<T1, InnerLaunchTemplateBaselinePerformanceFactorsFactory> combinedResult, Action<Humidifier.EC2.LaunchTemplateTypes.Cpu> subFactoryAction = null) => new (combinedResult, combinedResult, WithCpu(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerLaunchTemplateBaselinePerformanceFactorsFactory, T1, T2, InnerLaunchTemplateCpuFactory> WithCpu<T1, T2>(this CombinedResult<InnerLaunchTemplateBaselinePerformanceFactorsFactory, T1, T2> combinedResult, Action<Humidifier.EC2.LaunchTemplateTypes.Cpu> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCpu(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerLaunchTemplateBaselinePerformanceFactorsFactory, T2, InnerLaunchTemplateCpuFactory> WithCpu<T1, T2>(this CombinedResult<T1, InnerLaunchTemplateBaselinePerformanceFactorsFactory, T2> combinedResult, Action<Humidifier.EC2.LaunchTemplateTypes.Cpu> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCpu(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerLaunchTemplateBaselinePerformanceFactorsFactory, InnerLaunchTemplateCpuFactory> WithCpu<T1, T2>(this CombinedResult<T1, T2, InnerLaunchTemplateBaselinePerformanceFactorsFactory> combinedResult, Action<Humidifier.EC2.LaunchTemplateTypes.Cpu> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCpu(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerLaunchTemplateBaselinePerformanceFactorsFactory, T1, T2, T3, InnerLaunchTemplateCpuFactory> WithCpu<T1, T2, T3>(this CombinedResult<InnerLaunchTemplateBaselinePerformanceFactorsFactory, T1, T2, T3> combinedResult, Action<Humidifier.EC2.LaunchTemplateTypes.Cpu> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCpu(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerLaunchTemplateBaselinePerformanceFactorsFactory, T2, T3, InnerLaunchTemplateCpuFactory> WithCpu<T1, T2, T3>(this CombinedResult<T1, InnerLaunchTemplateBaselinePerformanceFactorsFactory, T2, T3> combinedResult, Action<Humidifier.EC2.LaunchTemplateTypes.Cpu> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCpu(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerLaunchTemplateBaselinePerformanceFactorsFactory, T3, InnerLaunchTemplateCpuFactory> WithCpu<T1, T2, T3>(this CombinedResult<T1, T2, InnerLaunchTemplateBaselinePerformanceFactorsFactory, T3> combinedResult, Action<Humidifier.EC2.LaunchTemplateTypes.Cpu> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCpu(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerLaunchTemplateBaselinePerformanceFactorsFactory, InnerLaunchTemplateCpuFactory> WithCpu<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerLaunchTemplateBaselinePerformanceFactorsFactory> combinedResult, Action<Humidifier.EC2.LaunchTemplateTypes.Cpu> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCpu(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerLaunchTemplateBaselinePerformanceFactorsFactory, T1, T2, T3, T4, InnerLaunchTemplateCpuFactory> WithCpu<T1, T2, T3, T4>(this CombinedResult<InnerLaunchTemplateBaselinePerformanceFactorsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EC2.LaunchTemplateTypes.Cpu> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCpu(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerLaunchTemplateBaselinePerformanceFactorsFactory, T2, T3, T4, InnerLaunchTemplateCpuFactory> WithCpu<T1, T2, T3, T4>(this CombinedResult<T1, InnerLaunchTemplateBaselinePerformanceFactorsFactory, T2, T3, T4> combinedResult, Action<Humidifier.EC2.LaunchTemplateTypes.Cpu> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCpu(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerLaunchTemplateBaselinePerformanceFactorsFactory, T3, T4, InnerLaunchTemplateCpuFactory> WithCpu<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerLaunchTemplateBaselinePerformanceFactorsFactory, T3, T4> combinedResult, Action<Humidifier.EC2.LaunchTemplateTypes.Cpu> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCpu(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerLaunchTemplateBaselinePerformanceFactorsFactory, T4, InnerLaunchTemplateCpuFactory> WithCpu<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerLaunchTemplateBaselinePerformanceFactorsFactory, T4> combinedResult, Action<Humidifier.EC2.LaunchTemplateTypes.Cpu> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCpu(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerLaunchTemplateBaselinePerformanceFactorsFactory, InnerLaunchTemplateCpuFactory> WithCpu<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerLaunchTemplateBaselinePerformanceFactorsFactory> combinedResult, Action<Humidifier.EC2.LaunchTemplateTypes.Cpu> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCpu(combinedResult.T5, subFactoryAction));
}
