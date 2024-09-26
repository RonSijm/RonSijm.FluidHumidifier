// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Glue;

public class InnerTableOptimizerTableOptimizerConfigurationFactory(Action<Humidifier.Glue.TableOptimizerTypes.TableOptimizerConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Glue.TableOptimizerTypes.TableOptimizerConfiguration>
{

    protected override Humidifier.Glue.TableOptimizerTypes.TableOptimizerConfiguration Create()
    {
        var tableOptimizerConfigurationResult = CreateTableOptimizerConfiguration();
        factoryAction?.Invoke(tableOptimizerConfigurationResult);

        return tableOptimizerConfigurationResult;
    }

    private Humidifier.Glue.TableOptimizerTypes.TableOptimizerConfiguration CreateTableOptimizerConfiguration()
    {
        var tableOptimizerConfigurationResult = new Humidifier.Glue.TableOptimizerTypes.TableOptimizerConfiguration();

        return tableOptimizerConfigurationResult;
    }

} // End Of Class

public static class InnerTableOptimizerTableOptimizerConfigurationFactoryExtensions
{
}
