// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppSync;

public class TypeFactory(string resourceName = null, Action<Humidifier.AppSync.Type> factoryAction = null) : ResourceFactory<Humidifier.AppSync.Type>(resourceName)
{

    protected override Humidifier.AppSync.Type Create()
    {
        var typeResult = CreateType();
        factoryAction?.Invoke(typeResult);

        return typeResult;
    }

    private Humidifier.AppSync.Type CreateType()
    {
        var typeResult = new Humidifier.AppSync.Type
        {
            GivenName = InputResourceName,
        };

        return typeResult;
    }

} // End Of Class

public static class TypeFactoryExtensions
{
}
