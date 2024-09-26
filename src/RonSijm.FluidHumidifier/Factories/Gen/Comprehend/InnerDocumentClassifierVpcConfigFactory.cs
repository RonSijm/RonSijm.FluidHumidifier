// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Comprehend;

public class InnerDocumentClassifierVpcConfigFactory(Action<Humidifier.Comprehend.DocumentClassifierTypes.VpcConfig> factoryAction = null) : SubResourceFactory<Humidifier.Comprehend.DocumentClassifierTypes.VpcConfig>
{

    protected override Humidifier.Comprehend.DocumentClassifierTypes.VpcConfig Create()
    {
        var vpcConfigResult = CreateVpcConfig();
        factoryAction?.Invoke(vpcConfigResult);

        return vpcConfigResult;
    }

    private Humidifier.Comprehend.DocumentClassifierTypes.VpcConfig CreateVpcConfig()
    {
        var vpcConfigResult = new Humidifier.Comprehend.DocumentClassifierTypes.VpcConfig();

        return vpcConfigResult;
    }

} // End Of Class

public static class InnerDocumentClassifierVpcConfigFactoryExtensions
{
}
