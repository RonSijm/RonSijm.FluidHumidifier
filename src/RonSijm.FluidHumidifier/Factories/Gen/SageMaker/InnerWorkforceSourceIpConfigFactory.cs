// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerWorkforceSourceIpConfigFactory(Action<Humidifier.SageMaker.WorkforceTypes.SourceIpConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.WorkforceTypes.SourceIpConfig>
{

    protected override Humidifier.SageMaker.WorkforceTypes.SourceIpConfig Create()
    {
        var sourceIpConfigResult = CreateSourceIpConfig();
        factoryAction?.Invoke(sourceIpConfigResult);

        return sourceIpConfigResult;
    }

    private Humidifier.SageMaker.WorkforceTypes.SourceIpConfig CreateSourceIpConfig()
    {
        var sourceIpConfigResult = new Humidifier.SageMaker.WorkforceTypes.SourceIpConfig();

        return sourceIpConfigResult;
    }

} // End Of Class

public static class InnerWorkforceSourceIpConfigFactoryExtensions
{
}
