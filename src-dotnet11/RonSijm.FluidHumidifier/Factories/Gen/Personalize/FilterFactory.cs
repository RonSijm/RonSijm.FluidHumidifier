// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Personalize;

public class FilterFactory(string resourceName = null, Action<Humidifier.Personalize.Filter> factoryAction = null) : ResourceFactory<Humidifier.Personalize.Filter>(resourceName)
{

    protected override Humidifier.Personalize.Filter Create()
    {
        var filterResult = CreateFilter();
        factoryAction?.Invoke(filterResult);

        return filterResult;
    }

    private Humidifier.Personalize.Filter CreateFilter()
    {
        var filterResult = new Humidifier.Personalize.Filter
        {
            GivenName = InputResourceName,
        };

        return filterResult;
    }

} // End Of Class

public static class FilterFactoryExtensions
{
}
