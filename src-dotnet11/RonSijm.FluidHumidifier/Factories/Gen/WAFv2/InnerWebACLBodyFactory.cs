// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAFv2;

public class InnerWebACLBodyFactory(Action<Humidifier.WAFv2.WebACLTypes.Body> factoryAction = null) : SubResourceFactory<Humidifier.WAFv2.WebACLTypes.Body>
{

    protected override Humidifier.WAFv2.WebACLTypes.Body Create()
    {
        var bodyResult = CreateBody();
        factoryAction?.Invoke(bodyResult);

        return bodyResult;
    }

    private Humidifier.WAFv2.WebACLTypes.Body CreateBody()
    {
        var bodyResult = new Humidifier.WAFv2.WebACLTypes.Body();

        return bodyResult;
    }

} // End Of Class

public static class InnerWebACLBodyFactoryExtensions
{
}
