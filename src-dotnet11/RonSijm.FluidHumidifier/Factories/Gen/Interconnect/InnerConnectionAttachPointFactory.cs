// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Interconnect;

public class InnerConnectionAttachPointFactory(Action<Humidifier.Interconnect.ConnectionTypes.AttachPoint> factoryAction = null) : SubResourceFactory<Humidifier.Interconnect.ConnectionTypes.AttachPoint>
{

    protected override Humidifier.Interconnect.ConnectionTypes.AttachPoint Create()
    {
        var attachPointResult = CreateAttachPoint();
        factoryAction?.Invoke(attachPointResult);

        return attachPointResult;
    }

    private Humidifier.Interconnect.ConnectionTypes.AttachPoint CreateAttachPoint()
    {
        var attachPointResult = new Humidifier.Interconnect.ConnectionTypes.AttachPoint();

        return attachPointResult;
    }

} // End Of Class

public static class InnerConnectionAttachPointFactoryExtensions
{
}
