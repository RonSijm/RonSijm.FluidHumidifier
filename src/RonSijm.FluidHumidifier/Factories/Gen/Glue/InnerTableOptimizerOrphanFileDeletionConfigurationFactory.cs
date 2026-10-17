// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Glue;

public class InnerTableOptimizerOrphanFileDeletionConfigurationFactory(Action<Humidifier.Glue.TableOptimizerTypes.OrphanFileDeletionConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Glue.TableOptimizerTypes.OrphanFileDeletionConfiguration>
{

    internal InnerTableOptimizerIcebergConfigurationFactory IcebergConfigurationFactory { get; set; }

    protected override Humidifier.Glue.TableOptimizerTypes.OrphanFileDeletionConfiguration Create()
    {
        var orphanFileDeletionConfigurationResult = CreateOrphanFileDeletionConfiguration();
        factoryAction?.Invoke(orphanFileDeletionConfigurationResult);

        return orphanFileDeletionConfigurationResult;
    }

    private Humidifier.Glue.TableOptimizerTypes.OrphanFileDeletionConfiguration CreateOrphanFileDeletionConfiguration()
    {
        var orphanFileDeletionConfigurationResult = new Humidifier.Glue.TableOptimizerTypes.OrphanFileDeletionConfiguration();

        return orphanFileDeletionConfigurationResult;
    }
    public override void CreateChildren(Humidifier.Glue.TableOptimizerTypes.OrphanFileDeletionConfiguration result)
    {
        base.CreateChildren(result);

        result.IcebergConfiguration ??= IcebergConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerTableOptimizerOrphanFileDeletionConfigurationFactoryExtensions
{
    public static CombinedResult<InnerTableOptimizerOrphanFileDeletionConfigurationFactory, InnerTableOptimizerIcebergConfigurationFactory> WithIcebergConfiguration(this InnerTableOptimizerOrphanFileDeletionConfigurationFactory parentFactory, Action<Humidifier.Glue.TableOptimizerTypes.IcebergConfiguration> subFactoryAction = null)
    {
        parentFactory.IcebergConfigurationFactory = new InnerTableOptimizerIcebergConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.IcebergConfigurationFactory);
    }

    public static CombinedResult<InnerTableOptimizerOrphanFileDeletionConfigurationFactory, T1, InnerTableOptimizerIcebergConfigurationFactory> WithIcebergConfiguration<T1>(this CombinedResult<InnerTableOptimizerOrphanFileDeletionConfigurationFactory, T1> combinedResult, Action<Humidifier.Glue.TableOptimizerTypes.IcebergConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithIcebergConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerTableOptimizerOrphanFileDeletionConfigurationFactory, InnerTableOptimizerIcebergConfigurationFactory> WithIcebergConfiguration<T1>(this CombinedResult<T1, InnerTableOptimizerOrphanFileDeletionConfigurationFactory> combinedResult, Action<Humidifier.Glue.TableOptimizerTypes.IcebergConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithIcebergConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerTableOptimizerOrphanFileDeletionConfigurationFactory, T1, T2, InnerTableOptimizerIcebergConfigurationFactory> WithIcebergConfiguration<T1, T2>(this CombinedResult<InnerTableOptimizerOrphanFileDeletionConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.Glue.TableOptimizerTypes.IcebergConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIcebergConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerTableOptimizerOrphanFileDeletionConfigurationFactory, T2, InnerTableOptimizerIcebergConfigurationFactory> WithIcebergConfiguration<T1, T2>(this CombinedResult<T1, InnerTableOptimizerOrphanFileDeletionConfigurationFactory, T2> combinedResult, Action<Humidifier.Glue.TableOptimizerTypes.IcebergConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIcebergConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerTableOptimizerOrphanFileDeletionConfigurationFactory, InnerTableOptimizerIcebergConfigurationFactory> WithIcebergConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerTableOptimizerOrphanFileDeletionConfigurationFactory> combinedResult, Action<Humidifier.Glue.TableOptimizerTypes.IcebergConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIcebergConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerTableOptimizerOrphanFileDeletionConfigurationFactory, T1, T2, T3, InnerTableOptimizerIcebergConfigurationFactory> WithIcebergConfiguration<T1, T2, T3>(this CombinedResult<InnerTableOptimizerOrphanFileDeletionConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Glue.TableOptimizerTypes.IcebergConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIcebergConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerTableOptimizerOrphanFileDeletionConfigurationFactory, T2, T3, InnerTableOptimizerIcebergConfigurationFactory> WithIcebergConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerTableOptimizerOrphanFileDeletionConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.Glue.TableOptimizerTypes.IcebergConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIcebergConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerTableOptimizerOrphanFileDeletionConfigurationFactory, T3, InnerTableOptimizerIcebergConfigurationFactory> WithIcebergConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerTableOptimizerOrphanFileDeletionConfigurationFactory, T3> combinedResult, Action<Humidifier.Glue.TableOptimizerTypes.IcebergConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIcebergConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerTableOptimizerOrphanFileDeletionConfigurationFactory, InnerTableOptimizerIcebergConfigurationFactory> WithIcebergConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerTableOptimizerOrphanFileDeletionConfigurationFactory> combinedResult, Action<Humidifier.Glue.TableOptimizerTypes.IcebergConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIcebergConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerTableOptimizerOrphanFileDeletionConfigurationFactory, T1, T2, T3, T4, InnerTableOptimizerIcebergConfigurationFactory> WithIcebergConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerTableOptimizerOrphanFileDeletionConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Glue.TableOptimizerTypes.IcebergConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIcebergConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerTableOptimizerOrphanFileDeletionConfigurationFactory, T2, T3, T4, InnerTableOptimizerIcebergConfigurationFactory> WithIcebergConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerTableOptimizerOrphanFileDeletionConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Glue.TableOptimizerTypes.IcebergConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIcebergConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerTableOptimizerOrphanFileDeletionConfigurationFactory, T3, T4, InnerTableOptimizerIcebergConfigurationFactory> WithIcebergConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerTableOptimizerOrphanFileDeletionConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.Glue.TableOptimizerTypes.IcebergConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIcebergConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerTableOptimizerOrphanFileDeletionConfigurationFactory, T4, InnerTableOptimizerIcebergConfigurationFactory> WithIcebergConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerTableOptimizerOrphanFileDeletionConfigurationFactory, T4> combinedResult, Action<Humidifier.Glue.TableOptimizerTypes.IcebergConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIcebergConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerTableOptimizerOrphanFileDeletionConfigurationFactory, InnerTableOptimizerIcebergConfigurationFactory> WithIcebergConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerTableOptimizerOrphanFileDeletionConfigurationFactory> combinedResult, Action<Humidifier.Glue.TableOptimizerTypes.IcebergConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIcebergConfiguration(combinedResult.T5, subFactoryAction).T2);
}
