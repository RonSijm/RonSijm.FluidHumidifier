// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Omics;

public class InnerConfigurationVpcConfigFactory(Action<Humidifier.Omics.ConfigurationTypes.VpcConfig> factoryAction = null) : SubResourceFactory<Humidifier.Omics.ConfigurationTypes.VpcConfig>
{

    protected override Humidifier.Omics.ConfigurationTypes.VpcConfig Create()
    {
        var vpcConfigResult = CreateVpcConfig();
        factoryAction?.Invoke(vpcConfigResult);

        return vpcConfigResult;
    }

    private Humidifier.Omics.ConfigurationTypes.VpcConfig CreateVpcConfig()
    {
        var vpcConfigResult = new Humidifier.Omics.ConfigurationTypes.VpcConfig();

        return vpcConfigResult;
    }

} // End Of Class

public static class InnerConfigurationVpcConfigFactoryExtensions
{
}
