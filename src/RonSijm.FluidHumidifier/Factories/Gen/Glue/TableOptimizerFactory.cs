// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Glue;

public class TableOptimizerFactory(string resourceName = null, Action<Humidifier.Glue.TableOptimizer> factoryAction = null) : ResourceFactory<Humidifier.Glue.TableOptimizer>(resourceName)
{

    internal InnerTableOptimizerTableOptimizerConfigurationFactory TableOptimizerConfigurationFactory { get; set; }

    protected override Humidifier.Glue.TableOptimizer Create()
    {
        var tableOptimizerResult = CreateTableOptimizer();
        factoryAction?.Invoke(tableOptimizerResult);

        return tableOptimizerResult;
    }

    private Humidifier.Glue.TableOptimizer CreateTableOptimizer()
    {
        var tableOptimizerResult = new Humidifier.Glue.TableOptimizer
        {
            GivenName = InputResourceName,
        };

        return tableOptimizerResult;
    }
    public override void CreateChildren(Humidifier.Glue.TableOptimizer result)
    {
        base.CreateChildren(result);

        result.TableOptimizerConfiguration ??= TableOptimizerConfigurationFactory?.Build();
    }

} // End Of Class

public static class TableOptimizerFactoryExtensions
{
    public static CombinedResult<TableOptimizerFactory, InnerTableOptimizerTableOptimizerConfigurationFactory> WithTableOptimizerConfiguration(this TableOptimizerFactory parentFactory, Action<Humidifier.Glue.TableOptimizerTypes.TableOptimizerConfiguration> subFactoryAction = null)
    {
        parentFactory.TableOptimizerConfigurationFactory = new InnerTableOptimizerTableOptimizerConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.TableOptimizerConfigurationFactory);
    }

    public static CombinedResult<TableOptimizerFactory, T1, InnerTableOptimizerTableOptimizerConfigurationFactory> WithTableOptimizerConfiguration<T1>(this CombinedResult<TableOptimizerFactory, T1> combinedResult, Action<Humidifier.Glue.TableOptimizerTypes.TableOptimizerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithTableOptimizerConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TableOptimizerFactory, InnerTableOptimizerTableOptimizerConfigurationFactory> WithTableOptimizerConfiguration<T1>(this CombinedResult<T1, TableOptimizerFactory> combinedResult, Action<Humidifier.Glue.TableOptimizerTypes.TableOptimizerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithTableOptimizerConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<TableOptimizerFactory, T1, T2, InnerTableOptimizerTableOptimizerConfigurationFactory> WithTableOptimizerConfiguration<T1, T2>(this CombinedResult<TableOptimizerFactory, T1, T2> combinedResult, Action<Humidifier.Glue.TableOptimizerTypes.TableOptimizerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTableOptimizerConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TableOptimizerFactory, T2, InnerTableOptimizerTableOptimizerConfigurationFactory> WithTableOptimizerConfiguration<T1, T2>(this CombinedResult<T1, TableOptimizerFactory, T2> combinedResult, Action<Humidifier.Glue.TableOptimizerTypes.TableOptimizerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTableOptimizerConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TableOptimizerFactory, InnerTableOptimizerTableOptimizerConfigurationFactory> WithTableOptimizerConfiguration<T1, T2>(this CombinedResult<T1, T2, TableOptimizerFactory> combinedResult, Action<Humidifier.Glue.TableOptimizerTypes.TableOptimizerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTableOptimizerConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<TableOptimizerFactory, T1, T2, T3, InnerTableOptimizerTableOptimizerConfigurationFactory> WithTableOptimizerConfiguration<T1, T2, T3>(this CombinedResult<TableOptimizerFactory, T1, T2, T3> combinedResult, Action<Humidifier.Glue.TableOptimizerTypes.TableOptimizerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTableOptimizerConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TableOptimizerFactory, T2, T3, InnerTableOptimizerTableOptimizerConfigurationFactory> WithTableOptimizerConfiguration<T1, T2, T3>(this CombinedResult<T1, TableOptimizerFactory, T2, T3> combinedResult, Action<Humidifier.Glue.TableOptimizerTypes.TableOptimizerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTableOptimizerConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TableOptimizerFactory, T3, InnerTableOptimizerTableOptimizerConfigurationFactory> WithTableOptimizerConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, TableOptimizerFactory, T3> combinedResult, Action<Humidifier.Glue.TableOptimizerTypes.TableOptimizerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTableOptimizerConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, TableOptimizerFactory, InnerTableOptimizerTableOptimizerConfigurationFactory> WithTableOptimizerConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, TableOptimizerFactory> combinedResult, Action<Humidifier.Glue.TableOptimizerTypes.TableOptimizerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTableOptimizerConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<TableOptimizerFactory, T1, T2, T3, T4, InnerTableOptimizerTableOptimizerConfigurationFactory> WithTableOptimizerConfiguration<T1, T2, T3, T4>(this CombinedResult<TableOptimizerFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Glue.TableOptimizerTypes.TableOptimizerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTableOptimizerConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TableOptimizerFactory, T2, T3, T4, InnerTableOptimizerTableOptimizerConfigurationFactory> WithTableOptimizerConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, TableOptimizerFactory, T2, T3, T4> combinedResult, Action<Humidifier.Glue.TableOptimizerTypes.TableOptimizerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTableOptimizerConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TableOptimizerFactory, T3, T4, InnerTableOptimizerTableOptimizerConfigurationFactory> WithTableOptimizerConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, TableOptimizerFactory, T3, T4> combinedResult, Action<Humidifier.Glue.TableOptimizerTypes.TableOptimizerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTableOptimizerConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, TableOptimizerFactory, T4, InnerTableOptimizerTableOptimizerConfigurationFactory> WithTableOptimizerConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, TableOptimizerFactory, T4> combinedResult, Action<Humidifier.Glue.TableOptimizerTypes.TableOptimizerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTableOptimizerConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, TableOptimizerFactory, InnerTableOptimizerTableOptimizerConfigurationFactory> WithTableOptimizerConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, TableOptimizerFactory> combinedResult, Action<Humidifier.Glue.TableOptimizerTypes.TableOptimizerConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTableOptimizerConfiguration(combinedResult.T5, subFactoryAction));
}
