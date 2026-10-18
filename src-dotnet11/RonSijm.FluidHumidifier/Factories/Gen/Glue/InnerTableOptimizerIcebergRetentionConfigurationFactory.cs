// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Glue;

public class InnerTableOptimizerIcebergRetentionConfigurationFactory(Action<Humidifier.Glue.TableOptimizerTypes.IcebergRetentionConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Glue.TableOptimizerTypes.IcebergRetentionConfiguration>
{

    protected override Humidifier.Glue.TableOptimizerTypes.IcebergRetentionConfiguration Create()
    {
        var icebergRetentionConfigurationResult = CreateIcebergRetentionConfiguration();
        factoryAction?.Invoke(icebergRetentionConfigurationResult);

        return icebergRetentionConfigurationResult;
    }

    private Humidifier.Glue.TableOptimizerTypes.IcebergRetentionConfiguration CreateIcebergRetentionConfiguration()
    {
        var icebergRetentionConfigurationResult = new Humidifier.Glue.TableOptimizerTypes.IcebergRetentionConfiguration();

        return icebergRetentionConfigurationResult;
    }

} // End Of Class

public static class InnerTableOptimizerIcebergRetentionConfigurationFactoryExtensions
{
}
