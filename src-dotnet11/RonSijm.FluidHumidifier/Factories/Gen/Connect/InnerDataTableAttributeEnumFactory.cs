// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Connect;

public class InnerDataTableAttributeEnumFactory(Action<Humidifier.Connect.DataTableAttributeTypes.Enum> factoryAction = null) : SubResourceFactory<Humidifier.Connect.DataTableAttributeTypes.Enum>
{

    protected override Humidifier.Connect.DataTableAttributeTypes.Enum Create()
    {
        var enumResult = CreateEnum();
        factoryAction?.Invoke(enumResult);

        return enumResult;
    }

    private Humidifier.Connect.DataTableAttributeTypes.Enum CreateEnum()
    {
        var enumResult = new Humidifier.Connect.DataTableAttributeTypes.Enum();

        return enumResult;
    }

} // End Of Class

public static class InnerDataTableAttributeEnumFactoryExtensions
{
}
