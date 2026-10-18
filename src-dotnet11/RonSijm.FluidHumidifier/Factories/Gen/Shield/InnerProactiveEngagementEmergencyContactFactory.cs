// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Shield;

public class InnerProactiveEngagementEmergencyContactFactory(Action<Humidifier.Shield.ProactiveEngagementTypes.EmergencyContact> factoryAction = null) : SubResourceFactory<Humidifier.Shield.ProactiveEngagementTypes.EmergencyContact>
{

    protected override Humidifier.Shield.ProactiveEngagementTypes.EmergencyContact Create()
    {
        var emergencyContactResult = CreateEmergencyContact();
        factoryAction?.Invoke(emergencyContactResult);

        return emergencyContactResult;
    }

    private Humidifier.Shield.ProactiveEngagementTypes.EmergencyContact CreateEmergencyContact()
    {
        var emergencyContactResult = new Humidifier.Shield.ProactiveEngagementTypes.EmergencyContact();

        return emergencyContactResult;
    }

} // End Of Class

public static class InnerProactiveEngagementEmergencyContactFactoryExtensions
{
}
