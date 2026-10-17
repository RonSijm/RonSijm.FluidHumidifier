// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFront;

public class InnerDistributionGrpcConfigFactory(Action<Humidifier.CloudFront.DistributionTypes.GrpcConfig> factoryAction = null) : SubResourceFactory<Humidifier.CloudFront.DistributionTypes.GrpcConfig>
{

    protected override Humidifier.CloudFront.DistributionTypes.GrpcConfig Create()
    {
        var grpcConfigResult = CreateGrpcConfig();
        factoryAction?.Invoke(grpcConfigResult);

        return grpcConfigResult;
    }

    private Humidifier.CloudFront.DistributionTypes.GrpcConfig CreateGrpcConfig()
    {
        var grpcConfigResult = new Humidifier.CloudFront.DistributionTypes.GrpcConfig();

        return grpcConfigResult;
    }

} // End Of Class

public static class InnerDistributionGrpcConfigFactoryExtensions
{
}
