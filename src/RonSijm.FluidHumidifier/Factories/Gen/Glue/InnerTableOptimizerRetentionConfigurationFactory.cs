// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Glue;

public class InnerTableOptimizerRetentionConfigurationFactory(Action<Humidifier.Glue.TableOptimizerTypes.RetentionConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Glue.TableOptimizerTypes.RetentionConfiguration>
{

    internal InnerTableOptimizerIcebergRetentionConfigurationFactory IcebergConfigurationFactory { get; set; }

    protected override Humidifier.Glue.TableOptimizerTypes.RetentionConfiguration Create()
    {
        var retentionConfigurationResult = CreateRetentionConfiguration();
        factoryAction?.Invoke(retentionConfigurationResult);

        return retentionConfigurationResult;
    }

    private Humidifier.Glue.TableOptimizerTypes.RetentionConfiguration CreateRetentionConfiguration()
    {
        var retentionConfigurationResult = new Humidifier.Glue.TableOptimizerTypes.RetentionConfiguration();

        return retentionConfigurationResult;
    }
    public override void CreateChildren(Humidifier.Glue.TableOptimizerTypes.RetentionConfiguration result)
    {
        base.CreateChildren(result);

        result.IcebergConfiguration ??= IcebergConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerTableOptimizerRetentionConfigurationFactoryExtensions
{
    public static CombinedResult<InnerTableOptimizerRetentionConfigurationFactory, InnerTableOptimizerIcebergRetentionConfigurationFactory> WithIcebergConfiguration(this InnerTableOptimizerRetentionConfigurationFactory parentFactory, Action<Humidifier.Glue.TableOptimizerTypes.IcebergRetentionConfiguration> subFactoryAction = null)
    {
        parentFactory.IcebergConfigurationFactory = new InnerTableOptimizerIcebergRetentionConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.IcebergConfigurationFactory);
    }

    public static CombinedResult<InnerTableOptimizerRetentionConfigurationFactory, T1, InnerTableOptimizerIcebergRetentionConfigurationFactory> WithIcebergConfiguration<T1>(this CombinedResult<InnerTableOptimizerRetentionConfigurationFactory, T1> combinedResult, Action<Humidifier.Glue.TableOptimizerTypes.IcebergRetentionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithIcebergConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerTableOptimizerRetentionConfigurationFactory, InnerTableOptimizerIcebergRetentionConfigurationFactory> WithIcebergConfiguration<T1>(this CombinedResult<T1, InnerTableOptimizerRetentionConfigurationFactory> combinedResult, Action<Humidifier.Glue.TableOptimizerTypes.IcebergRetentionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithIcebergConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerTableOptimizerRetentionConfigurationFactory, T1, T2, InnerTableOptimizerIcebergRetentionConfigurationFactory> WithIcebergConfiguration<T1, T2>(this CombinedResult<InnerTableOptimizerRetentionConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.Glue.TableOptimizerTypes.IcebergRetentionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIcebergConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerTableOptimizerRetentionConfigurationFactory, T2, InnerTableOptimizerIcebergRetentionConfigurationFactory> WithIcebergConfiguration<T1, T2>(this CombinedResult<T1, InnerTableOptimizerRetentionConfigurationFactory, T2> combinedResult, Action<Humidifier.Glue.TableOptimizerTypes.IcebergRetentionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIcebergConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerTableOptimizerRetentionConfigurationFactory, InnerTableOptimizerIcebergRetentionConfigurationFactory> WithIcebergConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerTableOptimizerRetentionConfigurationFactory> combinedResult, Action<Humidifier.Glue.TableOptimizerTypes.IcebergRetentionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIcebergConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerTableOptimizerRetentionConfigurationFactory, T1, T2, T3, InnerTableOptimizerIcebergRetentionConfigurationFactory> WithIcebergConfiguration<T1, T2, T3>(this CombinedResult<InnerTableOptimizerRetentionConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Glue.TableOptimizerTypes.IcebergRetentionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIcebergConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerTableOptimizerRetentionConfigurationFactory, T2, T3, InnerTableOptimizerIcebergRetentionConfigurationFactory> WithIcebergConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerTableOptimizerRetentionConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.Glue.TableOptimizerTypes.IcebergRetentionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIcebergConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerTableOptimizerRetentionConfigurationFactory, T3, InnerTableOptimizerIcebergRetentionConfigurationFactory> WithIcebergConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerTableOptimizerRetentionConfigurationFactory, T3> combinedResult, Action<Humidifier.Glue.TableOptimizerTypes.IcebergRetentionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIcebergConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerTableOptimizerRetentionConfigurationFactory, InnerTableOptimizerIcebergRetentionConfigurationFactory> WithIcebergConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerTableOptimizerRetentionConfigurationFactory> combinedResult, Action<Humidifier.Glue.TableOptimizerTypes.IcebergRetentionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIcebergConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerTableOptimizerRetentionConfigurationFactory, T1, T2, T3, T4, InnerTableOptimizerIcebergRetentionConfigurationFactory> WithIcebergConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerTableOptimizerRetentionConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Glue.TableOptimizerTypes.IcebergRetentionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIcebergConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerTableOptimizerRetentionConfigurationFactory, T2, T3, T4, InnerTableOptimizerIcebergRetentionConfigurationFactory> WithIcebergConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerTableOptimizerRetentionConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Glue.TableOptimizerTypes.IcebergRetentionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIcebergConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerTableOptimizerRetentionConfigurationFactory, T3, T4, InnerTableOptimizerIcebergRetentionConfigurationFactory> WithIcebergConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerTableOptimizerRetentionConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.Glue.TableOptimizerTypes.IcebergRetentionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIcebergConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerTableOptimizerRetentionConfigurationFactory, T4, InnerTableOptimizerIcebergRetentionConfigurationFactory> WithIcebergConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerTableOptimizerRetentionConfigurationFactory, T4> combinedResult, Action<Humidifier.Glue.TableOptimizerTypes.IcebergRetentionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIcebergConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerTableOptimizerRetentionConfigurationFactory, InnerTableOptimizerIcebergRetentionConfigurationFactory> WithIcebergConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerTableOptimizerRetentionConfigurationFactory> combinedResult, Action<Humidifier.Glue.TableOptimizerTypes.IcebergRetentionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIcebergConfiguration(combinedResult.T5, subFactoryAction).T2);
}
