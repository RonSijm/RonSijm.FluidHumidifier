// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EMRServerless;

public class InnerApplicationImageConfigurationInputFactory(Action<Humidifier.EMRServerless.ApplicationTypes.ImageConfigurationInput> factoryAction = null) : SubResourceFactory<Humidifier.EMRServerless.ApplicationTypes.ImageConfigurationInput>
{

    protected override Humidifier.EMRServerless.ApplicationTypes.ImageConfigurationInput Create()
    {
        var imageConfigurationInputResult = CreateImageConfigurationInput();
        factoryAction?.Invoke(imageConfigurationInputResult);

        return imageConfigurationInputResult;
    }

    private Humidifier.EMRServerless.ApplicationTypes.ImageConfigurationInput CreateImageConfigurationInput()
    {
        var imageConfigurationInputResult = new Humidifier.EMRServerless.ApplicationTypes.ImageConfigurationInput();

        return imageConfigurationInputResult;
    }

} // End Of Class

public static class InnerApplicationImageConfigurationInputFactoryExtensions
{
}
