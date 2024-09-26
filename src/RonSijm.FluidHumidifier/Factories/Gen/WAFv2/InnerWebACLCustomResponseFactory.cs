// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAFv2;

public class InnerWebACLCustomResponseFactory(Action<Humidifier.WAFv2.WebACLTypes.CustomResponse> factoryAction = null) : SubResourceFactory<Humidifier.WAFv2.WebACLTypes.CustomResponse>
{

    protected override Humidifier.WAFv2.WebACLTypes.CustomResponse Create()
    {
        var customResponseResult = CreateCustomResponse();
        factoryAction?.Invoke(customResponseResult);

        return customResponseResult;
    }

    private Humidifier.WAFv2.WebACLTypes.CustomResponse CreateCustomResponse()
    {
        var customResponseResult = new Humidifier.WAFv2.WebACLTypes.CustomResponse();

        return customResponseResult;
    }

} // End Of Class

public static class InnerWebACLCustomResponseFactoryExtensions
{
}
