// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lambda;

public class InnerMicrovmImageCpuConfigurationFactory(Action<Humidifier.Lambda.MicrovmImageTypes.CpuConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Lambda.MicrovmImageTypes.CpuConfiguration>
{

    protected override Humidifier.Lambda.MicrovmImageTypes.CpuConfiguration Create()
    {
        var cpuConfigurationResult = CreateCpuConfiguration();
        factoryAction?.Invoke(cpuConfigurationResult);

        return cpuConfigurationResult;
    }

    private Humidifier.Lambda.MicrovmImageTypes.CpuConfiguration CreateCpuConfiguration()
    {
        var cpuConfigurationResult = new Humidifier.Lambda.MicrovmImageTypes.CpuConfiguration();

        return cpuConfigurationResult;
    }

} // End Of Class

public static class InnerMicrovmImageCpuConfigurationFactoryExtensions
{
}
