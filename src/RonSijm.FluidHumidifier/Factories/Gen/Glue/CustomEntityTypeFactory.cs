// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Glue;

public class CustomEntityTypeFactory(string resourceName = null, Action<Humidifier.Glue.CustomEntityType> factoryAction = null) : ResourceFactory<Humidifier.Glue.CustomEntityType>(resourceName)
{

    protected override Humidifier.Glue.CustomEntityType Create()
    {
        var customEntityTypeResult = CreateCustomEntityType();
        factoryAction?.Invoke(customEntityTypeResult);

        return customEntityTypeResult;
    }

    private Humidifier.Glue.CustomEntityType CreateCustomEntityType()
    {
        var customEntityTypeResult = new Humidifier.Glue.CustomEntityType
        {
            GivenName = InputResourceName,
        };

        return customEntityTypeResult;
    }

} // End Of Class

public static class CustomEntityTypeFactoryExtensions
{
}
