// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Organizations;

public class RootFactory(string resourceName = null, Action<Humidifier.Organizations.Root> factoryAction = null) : ResourceFactory<Humidifier.Organizations.Root>(resourceName)
{

    protected override Humidifier.Organizations.Root Create()
    {
        var rootResult = CreateRoot();
        factoryAction?.Invoke(rootResult);

        return rootResult;
    }

    private Humidifier.Organizations.Root CreateRoot()
    {
        var rootResult = new Humidifier.Organizations.Root
        {
            GivenName = InputResourceName,
        };

        return rootResult;
    }

} // End Of Class

public static class RootFactoryExtensions
{
}
