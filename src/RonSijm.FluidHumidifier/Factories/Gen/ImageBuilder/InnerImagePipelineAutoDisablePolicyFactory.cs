// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ImageBuilder;

public class InnerImagePipelineAutoDisablePolicyFactory(Action<Humidifier.ImageBuilder.ImagePipelineTypes.AutoDisablePolicy> factoryAction = null) : SubResourceFactory<Humidifier.ImageBuilder.ImagePipelineTypes.AutoDisablePolicy>
{

    protected override Humidifier.ImageBuilder.ImagePipelineTypes.AutoDisablePolicy Create()
    {
        var autoDisablePolicyResult = CreateAutoDisablePolicy();
        factoryAction?.Invoke(autoDisablePolicyResult);

        return autoDisablePolicyResult;
    }

    private Humidifier.ImageBuilder.ImagePipelineTypes.AutoDisablePolicy CreateAutoDisablePolicy()
    {
        var autoDisablePolicyResult = new Humidifier.ImageBuilder.ImagePipelineTypes.AutoDisablePolicy();

        return autoDisablePolicyResult;
    }

} // End Of Class

public static class InnerImagePipelineAutoDisablePolicyFactoryExtensions
{
}
