// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerModelCardExportJobModelCardExportOutputConfigFactory(Action<Humidifier.SageMaker.ModelCardExportJobTypes.ModelCardExportOutputConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ModelCardExportJobTypes.ModelCardExportOutputConfig>
{

    protected override Humidifier.SageMaker.ModelCardExportJobTypes.ModelCardExportOutputConfig Create()
    {
        var modelCardExportOutputConfigResult = CreateModelCardExportOutputConfig();
        factoryAction?.Invoke(modelCardExportOutputConfigResult);

        return modelCardExportOutputConfigResult;
    }

    private Humidifier.SageMaker.ModelCardExportJobTypes.ModelCardExportOutputConfig CreateModelCardExportOutputConfig()
    {
        var modelCardExportOutputConfigResult = new Humidifier.SageMaker.ModelCardExportJobTypes.ModelCardExportOutputConfig();

        return modelCardExportOutputConfigResult;
    }

} // End Of Class

public static class InnerModelCardExportJobModelCardExportOutputConfigFactoryExtensions
{
}
