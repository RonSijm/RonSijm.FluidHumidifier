// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Deadline;

public class MeteredProductFactory(string resourceName = null, Action<Humidifier.Deadline.MeteredProduct> factoryAction = null) : ResourceFactory<Humidifier.Deadline.MeteredProduct>(resourceName)
{

    protected override Humidifier.Deadline.MeteredProduct Create()
    {
        var meteredProductResult = CreateMeteredProduct();
        factoryAction?.Invoke(meteredProductResult);

        return meteredProductResult;
    }

    private Humidifier.Deadline.MeteredProduct CreateMeteredProduct()
    {
        var meteredProductResult = new Humidifier.Deadline.MeteredProduct
        {
            GivenName = InputResourceName,
        };

        return meteredProductResult;
    }

} // End Of Class

public static class MeteredProductFactoryExtensions
{
}
