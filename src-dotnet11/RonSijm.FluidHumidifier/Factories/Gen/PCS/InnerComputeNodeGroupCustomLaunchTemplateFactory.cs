// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.PCS;

public class InnerComputeNodeGroupCustomLaunchTemplateFactory(Action<Humidifier.PCS.ComputeNodeGroupTypes.CustomLaunchTemplate> factoryAction = null) : SubResourceFactory<Humidifier.PCS.ComputeNodeGroupTypes.CustomLaunchTemplate>
{

    protected override Humidifier.PCS.ComputeNodeGroupTypes.CustomLaunchTemplate Create()
    {
        var customLaunchTemplateResult = CreateCustomLaunchTemplate();
        factoryAction?.Invoke(customLaunchTemplateResult);

        return customLaunchTemplateResult;
    }

    private Humidifier.PCS.ComputeNodeGroupTypes.CustomLaunchTemplate CreateCustomLaunchTemplate()
    {
        var customLaunchTemplateResult = new Humidifier.PCS.ComputeNodeGroupTypes.CustomLaunchTemplate();

        return customLaunchTemplateResult;
    }

} // End Of Class

public static class InnerComputeNodeGroupCustomLaunchTemplateFactoryExtensions
{
}
