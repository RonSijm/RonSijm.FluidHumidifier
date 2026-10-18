// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerCapacityProviderCapacityReservationTargetFactory(Action<Humidifier.BedrockAgentCore.CapacityProviderTypes.CapacityReservationTarget> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.CapacityProviderTypes.CapacityReservationTarget>
{

    protected override Humidifier.BedrockAgentCore.CapacityProviderTypes.CapacityReservationTarget Create()
    {
        var capacityReservationTargetResult = CreateCapacityReservationTarget();
        factoryAction?.Invoke(capacityReservationTargetResult);

        return capacityReservationTargetResult;
    }

    private Humidifier.BedrockAgentCore.CapacityProviderTypes.CapacityReservationTarget CreateCapacityReservationTarget()
    {
        var capacityReservationTargetResult = new Humidifier.BedrockAgentCore.CapacityProviderTypes.CapacityReservationTarget();

        return capacityReservationTargetResult;
    }

} // End Of Class

public static class InnerCapacityProviderCapacityReservationTargetFactoryExtensions
{
}
