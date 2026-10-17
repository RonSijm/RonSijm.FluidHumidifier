// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Comprehend;

public class InnerEntityRecognizerVpcConfigFactory(Action<Humidifier.Comprehend.EntityRecognizerTypes.VpcConfig> factoryAction = null) : SubResourceFactory<Humidifier.Comprehend.EntityRecognizerTypes.VpcConfig>
{

    protected override Humidifier.Comprehend.EntityRecognizerTypes.VpcConfig Create()
    {
        var vpcConfigResult = CreateVpcConfig();
        factoryAction?.Invoke(vpcConfigResult);

        return vpcConfigResult;
    }

    private Humidifier.Comprehend.EntityRecognizerTypes.VpcConfig CreateVpcConfig()
    {
        var vpcConfigResult = new Humidifier.Comprehend.EntityRecognizerTypes.VpcConfig();

        return vpcConfigResult;
    }

} // End Of Class

public static class InnerEntityRecognizerVpcConfigFactoryExtensions
{
}
