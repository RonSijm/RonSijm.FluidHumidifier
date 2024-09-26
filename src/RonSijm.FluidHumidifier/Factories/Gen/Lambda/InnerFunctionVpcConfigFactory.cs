// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lambda;

public class InnerFunctionVpcConfigFactory(Action<Humidifier.Lambda.FunctionTypes.VpcConfig> factoryAction = null) : SubResourceFactory<Humidifier.Lambda.FunctionTypes.VpcConfig>
{

    protected override Humidifier.Lambda.FunctionTypes.VpcConfig Create()
    {
        var vpcConfigResult = CreateVpcConfig();
        factoryAction?.Invoke(vpcConfigResult);

        return vpcConfigResult;
    }

    private Humidifier.Lambda.FunctionTypes.VpcConfig CreateVpcConfig()
    {
        var vpcConfigResult = new Humidifier.Lambda.FunctionTypes.VpcConfig();

        return vpcConfigResult;
    }

} // End Of Class

public static class InnerFunctionVpcConfigFactoryExtensions
{
}
