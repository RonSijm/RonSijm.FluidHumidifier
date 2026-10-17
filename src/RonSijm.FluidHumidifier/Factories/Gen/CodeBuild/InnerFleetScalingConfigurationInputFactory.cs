// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CodeBuild;

public class InnerFleetScalingConfigurationInputFactory(Action<Humidifier.CodeBuild.FleetTypes.ScalingConfigurationInput> factoryAction = null) : SubResourceFactory<Humidifier.CodeBuild.FleetTypes.ScalingConfigurationInput>
{

    protected override Humidifier.CodeBuild.FleetTypes.ScalingConfigurationInput Create()
    {
        var scalingConfigurationInputResult = CreateScalingConfigurationInput();
        factoryAction?.Invoke(scalingConfigurationInputResult);

        return scalingConfigurationInputResult;
    }

    private Humidifier.CodeBuild.FleetTypes.ScalingConfigurationInput CreateScalingConfigurationInput()
    {
        var scalingConfigurationInputResult = new Humidifier.CodeBuild.FleetTypes.ScalingConfigurationInput();

        return scalingConfigurationInputResult;
    }

} // End Of Class

public static class InnerFleetScalingConfigurationInputFactoryExtensions
{
}
