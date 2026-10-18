// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Connect;

public class InnerInstanceAttributesFactory(Action<Humidifier.Connect.InstanceTypes.Attributes> factoryAction = null) : SubResourceFactory<Humidifier.Connect.InstanceTypes.Attributes>
{

    protected override Humidifier.Connect.InstanceTypes.Attributes Create()
    {
        var attributesResult = CreateAttributes();
        factoryAction?.Invoke(attributesResult);

        return attributesResult;
    }

    private Humidifier.Connect.InstanceTypes.Attributes CreateAttributes()
    {
        var attributesResult = new Humidifier.Connect.InstanceTypes.Attributes();

        return attributesResult;
    }

} // End Of Class

public static class InnerInstanceAttributesFactoryExtensions
{
}
