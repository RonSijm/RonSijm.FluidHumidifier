// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EKS;

public class InnerCapabilityAckFactory(Action<Humidifier.EKS.CapabilityTypes.Ack> factoryAction = null) : SubResourceFactory<Humidifier.EKS.CapabilityTypes.Ack>
{

    protected override Humidifier.EKS.CapabilityTypes.Ack Create()
    {
        var ackResult = CreateAck();
        factoryAction?.Invoke(ackResult);

        return ackResult;
    }

    private Humidifier.EKS.CapabilityTypes.Ack CreateAck()
    {
        var ackResult = new Humidifier.EKS.CapabilityTypes.Ack();

        return ackResult;
    }

} // End Of Class

public static class InnerCapabilityAckFactoryExtensions
{
}
