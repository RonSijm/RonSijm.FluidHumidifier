// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.LookoutEquipment;

public class InnerInferenceSchedulerInputNameConfigurationFactory(Action<Humidifier.LookoutEquipment.InferenceSchedulerTypes.InputNameConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.LookoutEquipment.InferenceSchedulerTypes.InputNameConfiguration>
{

    protected override Humidifier.LookoutEquipment.InferenceSchedulerTypes.InputNameConfiguration Create()
    {
        var inputNameConfigurationResult = CreateInputNameConfiguration();
        factoryAction?.Invoke(inputNameConfigurationResult);

        return inputNameConfigurationResult;
    }

    private Humidifier.LookoutEquipment.InferenceSchedulerTypes.InputNameConfiguration CreateInputNameConfiguration()
    {
        var inputNameConfigurationResult = new Humidifier.LookoutEquipment.InferenceSchedulerTypes.InputNameConfiguration();

        return inputNameConfigurationResult;
    }

} // End Of Class

public static class InnerInferenceSchedulerInputNameConfigurationFactoryExtensions
{
}
