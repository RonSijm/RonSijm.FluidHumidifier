// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Synthetics;

public class InnerCanaryCodeFactory(Action<Humidifier.Synthetics.CanaryTypes.Code> factoryAction = null) : SubResourceFactory<Humidifier.Synthetics.CanaryTypes.Code>
{

    protected override Humidifier.Synthetics.CanaryTypes.Code Create()
    {
        var codeResult = CreateCode();
        factoryAction?.Invoke(codeResult);

        return codeResult;
    }

    private Humidifier.Synthetics.CanaryTypes.Code CreateCode()
    {
        var codeResult = new Humidifier.Synthetics.CanaryTypes.Code();

        return codeResult;
    }

} // End Of Class

public static class InnerCanaryCodeFactoryExtensions
{
}
