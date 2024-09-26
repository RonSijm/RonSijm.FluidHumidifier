// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.RefactorSpaces;

public class InnerServiceUrlEndpointInputFactory(Action<Humidifier.RefactorSpaces.ServiceTypes.UrlEndpointInput> factoryAction = null) : SubResourceFactory<Humidifier.RefactorSpaces.ServiceTypes.UrlEndpointInput>
{

    protected override Humidifier.RefactorSpaces.ServiceTypes.UrlEndpointInput Create()
    {
        var urlEndpointInputResult = CreateUrlEndpointInput();
        factoryAction?.Invoke(urlEndpointInputResult);

        return urlEndpointInputResult;
    }

    private Humidifier.RefactorSpaces.ServiceTypes.UrlEndpointInput CreateUrlEndpointInput()
    {
        var urlEndpointInputResult = new Humidifier.RefactorSpaces.ServiceTypes.UrlEndpointInput();

        return urlEndpointInputResult;
    }

} // End Of Class

public static class InnerServiceUrlEndpointInputFactoryExtensions
{
}
