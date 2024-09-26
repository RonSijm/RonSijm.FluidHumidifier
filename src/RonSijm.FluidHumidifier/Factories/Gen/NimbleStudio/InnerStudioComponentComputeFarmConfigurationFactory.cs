// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.NimbleStudio;

public class InnerStudioComponentComputeFarmConfigurationFactory(Action<Humidifier.NimbleStudio.StudioComponentTypes.ComputeFarmConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.NimbleStudio.StudioComponentTypes.ComputeFarmConfiguration>
{

    protected override Humidifier.NimbleStudio.StudioComponentTypes.ComputeFarmConfiguration Create()
    {
        var computeFarmConfigurationResult = CreateComputeFarmConfiguration();
        factoryAction?.Invoke(computeFarmConfigurationResult);

        return computeFarmConfigurationResult;
    }

    private Humidifier.NimbleStudio.StudioComponentTypes.ComputeFarmConfiguration CreateComputeFarmConfiguration()
    {
        var computeFarmConfigurationResult = new Humidifier.NimbleStudio.StudioComponentTypes.ComputeFarmConfiguration();

        return computeFarmConfigurationResult;
    }

} // End Of Class

public static class InnerStudioComponentComputeFarmConfigurationFactoryExtensions
{
}
