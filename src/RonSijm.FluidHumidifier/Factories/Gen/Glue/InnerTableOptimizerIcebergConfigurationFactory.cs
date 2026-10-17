// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Glue;

public class InnerTableOptimizerIcebergConfigurationFactory(Action<Humidifier.Glue.TableOptimizerTypes.IcebergConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Glue.TableOptimizerTypes.IcebergConfiguration>
{

    protected override Humidifier.Glue.TableOptimizerTypes.IcebergConfiguration Create()
    {
        var icebergConfigurationResult = CreateIcebergConfiguration();
        factoryAction?.Invoke(icebergConfigurationResult);

        return icebergConfigurationResult;
    }

    private Humidifier.Glue.TableOptimizerTypes.IcebergConfiguration CreateIcebergConfiguration()
    {
        var icebergConfigurationResult = new Humidifier.Glue.TableOptimizerTypes.IcebergConfiguration();

        return icebergConfigurationResult;
    }

} // End Of Class

public static class InnerTableOptimizerIcebergConfigurationFactoryExtensions
{
}
