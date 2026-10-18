// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Glue;

public class InnerTableOptimizerVpcConfigurationFactory(Action<Humidifier.Glue.TableOptimizerTypes.VpcConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Glue.TableOptimizerTypes.VpcConfiguration>
{

    protected override Humidifier.Glue.TableOptimizerTypes.VpcConfiguration Create()
    {
        var vpcConfigurationResult = CreateVpcConfiguration();
        factoryAction?.Invoke(vpcConfigurationResult);

        return vpcConfigurationResult;
    }

    private Humidifier.Glue.TableOptimizerTypes.VpcConfiguration CreateVpcConfiguration()
    {
        var vpcConfigurationResult = new Humidifier.Glue.TableOptimizerTypes.VpcConfiguration();

        return vpcConfigurationResult;
    }

} // End Of Class

public static class InnerTableOptimizerVpcConfigurationFactoryExtensions
{
}
