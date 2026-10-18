// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ServiceCatalog;

public class TagOptionFactory(string resourceName = null, Action<Humidifier.ServiceCatalog.TagOption> factoryAction = null) : ResourceFactory<Humidifier.ServiceCatalog.TagOption>(resourceName)
{

    protected override Humidifier.ServiceCatalog.TagOption Create()
    {
        var tagOptionResult = CreateTagOption();
        factoryAction?.Invoke(tagOptionResult);

        return tagOptionResult;
    }

    private Humidifier.ServiceCatalog.TagOption CreateTagOption()
    {
        var tagOptionResult = new Humidifier.ServiceCatalog.TagOption
        {
            GivenName = InputResourceName,
        };

        return tagOptionResult;
    }

} // End Of Class

public static class TagOptionFactoryExtensions
{
}
