// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Textract;

public class AdapterFactory(string resourceName = null, Action<Humidifier.Textract.Adapter> factoryAction = null) : ResourceFactory<Humidifier.Textract.Adapter>(resourceName)
{

    protected override Humidifier.Textract.Adapter Create()
    {
        var adapterResult = CreateAdapter();
        factoryAction?.Invoke(adapterResult);

        return adapterResult;
    }

    private Humidifier.Textract.Adapter CreateAdapter()
    {
        var adapterResult = new Humidifier.Textract.Adapter
        {
            GivenName = InputResourceName,
        };

        return adapterResult;
    }

} // End Of Class

public static class AdapterFactoryExtensions
{
}
