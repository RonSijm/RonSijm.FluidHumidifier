// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.PCS;

public class InnerComputeNodeGroupSlurmConfigurationFactory(Action<Humidifier.PCS.ComputeNodeGroupTypes.SlurmConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.PCS.ComputeNodeGroupTypes.SlurmConfiguration>
{

    protected override Humidifier.PCS.ComputeNodeGroupTypes.SlurmConfiguration Create()
    {
        var slurmConfigurationResult = CreateSlurmConfiguration();
        factoryAction?.Invoke(slurmConfigurationResult);

        return slurmConfigurationResult;
    }

    private Humidifier.PCS.ComputeNodeGroupTypes.SlurmConfiguration CreateSlurmConfiguration()
    {
        var slurmConfigurationResult = new Humidifier.PCS.ComputeNodeGroupTypes.SlurmConfiguration();

        return slurmConfigurationResult;
    }

} // End Of Class

public static class InnerComputeNodeGroupSlurmConfigurationFactoryExtensions
{
}
