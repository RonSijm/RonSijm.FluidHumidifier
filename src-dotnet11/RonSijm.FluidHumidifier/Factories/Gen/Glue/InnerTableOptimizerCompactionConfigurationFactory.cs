// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Glue;

public class InnerTableOptimizerCompactionConfigurationFactory(Action<Humidifier.Glue.TableOptimizerTypes.CompactionConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Glue.TableOptimizerTypes.CompactionConfiguration>
{

    internal InnerTableOptimizerIcebergCompactionConfigurationFactory IcebergConfigurationFactory { get; set; }

    protected override Humidifier.Glue.TableOptimizerTypes.CompactionConfiguration Create()
    {
        var compactionConfigurationResult = CreateCompactionConfiguration();
        factoryAction?.Invoke(compactionConfigurationResult);

        return compactionConfigurationResult;
    }

    private Humidifier.Glue.TableOptimizerTypes.CompactionConfiguration CreateCompactionConfiguration()
    {
        var compactionConfigurationResult = new Humidifier.Glue.TableOptimizerTypes.CompactionConfiguration();

        return compactionConfigurationResult;
    }
    public override void CreateChildren(Humidifier.Glue.TableOptimizerTypes.CompactionConfiguration result)
    {
        base.CreateChildren(result);

        result.IcebergConfiguration ??= IcebergConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerTableOptimizerCompactionConfigurationFactoryExtensions
{
    public static CombinedResult<InnerTableOptimizerCompactionConfigurationFactory, InnerTableOptimizerIcebergCompactionConfigurationFactory> WithIcebergConfiguration(this InnerTableOptimizerCompactionConfigurationFactory parentFactory, Action<Humidifier.Glue.TableOptimizerTypes.IcebergCompactionConfiguration> subFactoryAction = null)
    {
        parentFactory.IcebergConfigurationFactory = new InnerTableOptimizerIcebergCompactionConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.IcebergConfigurationFactory);
    }

    public static CombinedResult<InnerTableOptimizerCompactionConfigurationFactory, T1, InnerTableOptimizerIcebergCompactionConfigurationFactory> WithIcebergConfiguration<T1>(this CombinedResult<InnerTableOptimizerCompactionConfigurationFactory, T1> combinedResult, Action<Humidifier.Glue.TableOptimizerTypes.IcebergCompactionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithIcebergConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerTableOptimizerCompactionConfigurationFactory, InnerTableOptimizerIcebergCompactionConfigurationFactory> WithIcebergConfiguration<T1>(this CombinedResult<T1, InnerTableOptimizerCompactionConfigurationFactory> combinedResult, Action<Humidifier.Glue.TableOptimizerTypes.IcebergCompactionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithIcebergConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerTableOptimizerCompactionConfigurationFactory, T1, T2, InnerTableOptimizerIcebergCompactionConfigurationFactory> WithIcebergConfiguration<T1, T2>(this CombinedResult<InnerTableOptimizerCompactionConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.Glue.TableOptimizerTypes.IcebergCompactionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIcebergConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerTableOptimizerCompactionConfigurationFactory, T2, InnerTableOptimizerIcebergCompactionConfigurationFactory> WithIcebergConfiguration<T1, T2>(this CombinedResult<T1, InnerTableOptimizerCompactionConfigurationFactory, T2> combinedResult, Action<Humidifier.Glue.TableOptimizerTypes.IcebergCompactionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIcebergConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerTableOptimizerCompactionConfigurationFactory, InnerTableOptimizerIcebergCompactionConfigurationFactory> WithIcebergConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerTableOptimizerCompactionConfigurationFactory> combinedResult, Action<Humidifier.Glue.TableOptimizerTypes.IcebergCompactionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIcebergConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerTableOptimizerCompactionConfigurationFactory, T1, T2, T3, InnerTableOptimizerIcebergCompactionConfigurationFactory> WithIcebergConfiguration<T1, T2, T3>(this CombinedResult<InnerTableOptimizerCompactionConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Glue.TableOptimizerTypes.IcebergCompactionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIcebergConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerTableOptimizerCompactionConfigurationFactory, T2, T3, InnerTableOptimizerIcebergCompactionConfigurationFactory> WithIcebergConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerTableOptimizerCompactionConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.Glue.TableOptimizerTypes.IcebergCompactionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIcebergConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerTableOptimizerCompactionConfigurationFactory, T3, InnerTableOptimizerIcebergCompactionConfigurationFactory> WithIcebergConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerTableOptimizerCompactionConfigurationFactory, T3> combinedResult, Action<Humidifier.Glue.TableOptimizerTypes.IcebergCompactionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIcebergConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerTableOptimizerCompactionConfigurationFactory, InnerTableOptimizerIcebergCompactionConfigurationFactory> WithIcebergConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerTableOptimizerCompactionConfigurationFactory> combinedResult, Action<Humidifier.Glue.TableOptimizerTypes.IcebergCompactionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIcebergConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerTableOptimizerCompactionConfigurationFactory, T1, T2, T3, T4, InnerTableOptimizerIcebergCompactionConfigurationFactory> WithIcebergConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerTableOptimizerCompactionConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Glue.TableOptimizerTypes.IcebergCompactionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIcebergConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerTableOptimizerCompactionConfigurationFactory, T2, T3, T4, InnerTableOptimizerIcebergCompactionConfigurationFactory> WithIcebergConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerTableOptimizerCompactionConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Glue.TableOptimizerTypes.IcebergCompactionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIcebergConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerTableOptimizerCompactionConfigurationFactory, T3, T4, InnerTableOptimizerIcebergCompactionConfigurationFactory> WithIcebergConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerTableOptimizerCompactionConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.Glue.TableOptimizerTypes.IcebergCompactionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIcebergConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerTableOptimizerCompactionConfigurationFactory, T4, InnerTableOptimizerIcebergCompactionConfigurationFactory> WithIcebergConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerTableOptimizerCompactionConfigurationFactory, T4> combinedResult, Action<Humidifier.Glue.TableOptimizerTypes.IcebergCompactionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIcebergConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerTableOptimizerCompactionConfigurationFactory, InnerTableOptimizerIcebergCompactionConfigurationFactory> WithIcebergConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerTableOptimizerCompactionConfigurationFactory> combinedResult, Action<Humidifier.Glue.TableOptimizerTypes.IcebergCompactionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIcebergConfiguration(combinedResult.T5, subFactoryAction).T2);
}
