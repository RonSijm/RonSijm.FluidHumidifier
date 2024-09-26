// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAFv2;

public class InnerWebACLCustomRequestHandlingFactory(Action<Humidifier.WAFv2.WebACLTypes.CustomRequestHandling> factoryAction = null) : SubResourceFactory<Humidifier.WAFv2.WebACLTypes.CustomRequestHandling>
{

    protected override Humidifier.WAFv2.WebACLTypes.CustomRequestHandling Create()
    {
        var customRequestHandlingResult = CreateCustomRequestHandling();
        factoryAction?.Invoke(customRequestHandlingResult);

        return customRequestHandlingResult;
    }

    private Humidifier.WAFv2.WebACLTypes.CustomRequestHandling CreateCustomRequestHandling()
    {
        var customRequestHandlingResult = new Humidifier.WAFv2.WebACLTypes.CustomRequestHandling();

        return customRequestHandlingResult;
    }

} // End Of Class

public static class InnerWebACLCustomRequestHandlingFactoryExtensions
{
}
