// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerModelImportJobVpcConfigFactory(Action<Humidifier.Bedrock.ModelImportJobTypes.VpcConfig> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.ModelImportJobTypes.VpcConfig>
{

    protected override Humidifier.Bedrock.ModelImportJobTypes.VpcConfig Create()
    {
        var vpcConfigResult = CreateVpcConfig();
        factoryAction?.Invoke(vpcConfigResult);

        return vpcConfigResult;
    }

    private Humidifier.Bedrock.ModelImportJobTypes.VpcConfig CreateVpcConfig()
    {
        var vpcConfigResult = new Humidifier.Bedrock.ModelImportJobTypes.VpcConfig();

        return vpcConfigResult;
    }

} // End Of Class

public static class InnerModelImportJobVpcConfigFactoryExtensions
{
}
