// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Glue;

public class InnerTableOptimizerIcebergCompactionConfigurationFactory(Action<Humidifier.Glue.TableOptimizerTypes.IcebergCompactionConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Glue.TableOptimizerTypes.IcebergCompactionConfiguration>
{

    protected override Humidifier.Glue.TableOptimizerTypes.IcebergCompactionConfiguration Create()
    {
        var icebergCompactionConfigurationResult = CreateIcebergCompactionConfiguration();
        factoryAction?.Invoke(icebergCompactionConfigurationResult);

        return icebergCompactionConfigurationResult;
    }

    private Humidifier.Glue.TableOptimizerTypes.IcebergCompactionConfiguration CreateIcebergCompactionConfiguration()
    {
        var icebergCompactionConfigurationResult = new Humidifier.Glue.TableOptimizerTypes.IcebergCompactionConfiguration();

        return icebergCompactionConfigurationResult;
    }

} // End Of Class

public static class InnerTableOptimizerIcebergCompactionConfigurationFactoryExtensions
{
}
