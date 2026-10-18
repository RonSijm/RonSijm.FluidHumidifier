// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lambda;

public class InnerUrlCorsFactory(Action<Humidifier.Lambda.UrlTypes.Cors> factoryAction = null) : SubResourceFactory<Humidifier.Lambda.UrlTypes.Cors>
{

    protected override Humidifier.Lambda.UrlTypes.Cors Create()
    {
        var corsResult = CreateCors();
        factoryAction?.Invoke(corsResult);

        return corsResult;
    }

    private Humidifier.Lambda.UrlTypes.Cors CreateCors()
    {
        var corsResult = new Humidifier.Lambda.UrlTypes.Cors();

        return corsResult;
    }

} // End Of Class

public static class InnerUrlCorsFactoryExtensions
{
}
