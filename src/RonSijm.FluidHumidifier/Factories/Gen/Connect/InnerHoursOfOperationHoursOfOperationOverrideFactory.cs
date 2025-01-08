// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Connect;

public class InnerHoursOfOperationHoursOfOperationOverrideFactory(Action<Humidifier.Connect.HoursOfOperationTypes.HoursOfOperationOverride> factoryAction = null) : SubResourceFactory<Humidifier.Connect.HoursOfOperationTypes.HoursOfOperationOverride>
{

    protected override Humidifier.Connect.HoursOfOperationTypes.HoursOfOperationOverride Create()
    {
        var hoursOfOperationOverrideResult = CreateHoursOfOperationOverride();
        factoryAction?.Invoke(hoursOfOperationOverrideResult);

        return hoursOfOperationOverrideResult;
    }

    private Humidifier.Connect.HoursOfOperationTypes.HoursOfOperationOverride CreateHoursOfOperationOverride()
    {
        var hoursOfOperationOverrideResult = new Humidifier.Connect.HoursOfOperationTypes.HoursOfOperationOverride();

        return hoursOfOperationOverrideResult;
    }

} // End Of Class

public static class InnerHoursOfOperationHoursOfOperationOverrideFactoryExtensions
{
}
