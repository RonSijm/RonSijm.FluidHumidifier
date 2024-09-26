// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerDomainCustomPosixUserConfigFactory(Action<Humidifier.SageMaker.DomainTypes.CustomPosixUserConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.DomainTypes.CustomPosixUserConfig>
{

    protected override Humidifier.SageMaker.DomainTypes.CustomPosixUserConfig Create()
    {
        var customPosixUserConfigResult = CreateCustomPosixUserConfig();
        factoryAction?.Invoke(customPosixUserConfigResult);

        return customPosixUserConfigResult;
    }

    private Humidifier.SageMaker.DomainTypes.CustomPosixUserConfig CreateCustomPosixUserConfig()
    {
        var customPosixUserConfigResult = new Humidifier.SageMaker.DomainTypes.CustomPosixUserConfig();

        return customPosixUserConfigResult;
    }

} // End Of Class

public static class InnerDomainCustomPosixUserConfigFactoryExtensions
{
}
