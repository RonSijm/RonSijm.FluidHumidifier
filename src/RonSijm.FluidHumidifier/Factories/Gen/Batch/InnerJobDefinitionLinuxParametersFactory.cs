// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Batch;

public class InnerJobDefinitionLinuxParametersFactory(Action<Humidifier.Batch.JobDefinitionTypes.LinuxParameters> factoryAction = null) : SubResourceFactory<Humidifier.Batch.JobDefinitionTypes.LinuxParameters>
{

    protected override Humidifier.Batch.JobDefinitionTypes.LinuxParameters Create()
    {
        var linuxParametersResult = CreateLinuxParameters();
        factoryAction?.Invoke(linuxParametersResult);

        return linuxParametersResult;
    }

    private Humidifier.Batch.JobDefinitionTypes.LinuxParameters CreateLinuxParameters()
    {
        var linuxParametersResult = new Humidifier.Batch.JobDefinitionTypes.LinuxParameters();

        return linuxParametersResult;
    }

} // End Of Class

public static class InnerJobDefinitionLinuxParametersFactoryExtensions
{
}
