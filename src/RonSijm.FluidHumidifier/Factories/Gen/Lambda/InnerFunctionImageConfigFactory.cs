// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lambda;

public class InnerFunctionImageConfigFactory(Action<Humidifier.Lambda.FunctionTypes.ImageConfig> factoryAction = null) : SubResourceFactory<Humidifier.Lambda.FunctionTypes.ImageConfig>
{

    protected override Humidifier.Lambda.FunctionTypes.ImageConfig Create()
    {
        var imageConfigResult = CreateImageConfig();
        factoryAction?.Invoke(imageConfigResult);

        return imageConfigResult;
    }

    private Humidifier.Lambda.FunctionTypes.ImageConfig CreateImageConfig()
    {
        var imageConfigResult = new Humidifier.Lambda.FunctionTypes.ImageConfig();

        return imageConfigResult;
    }

} // End Of Class

public static class InnerFunctionImageConfigFactoryExtensions
{
}
