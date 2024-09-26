// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerUserProfileCustomPosixUserConfigFactory(Action<Humidifier.SageMaker.UserProfileTypes.CustomPosixUserConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.UserProfileTypes.CustomPosixUserConfig>
{

    protected override Humidifier.SageMaker.UserProfileTypes.CustomPosixUserConfig Create()
    {
        var customPosixUserConfigResult = CreateCustomPosixUserConfig();
        factoryAction?.Invoke(customPosixUserConfigResult);

        return customPosixUserConfigResult;
    }

    private Humidifier.SageMaker.UserProfileTypes.CustomPosixUserConfig CreateCustomPosixUserConfig()
    {
        var customPosixUserConfigResult = new Humidifier.SageMaker.UserProfileTypes.CustomPosixUserConfig();

        return customPosixUserConfigResult;
    }

} // End Of Class

public static class InnerUserProfileCustomPosixUserConfigFactoryExtensions
{
}
