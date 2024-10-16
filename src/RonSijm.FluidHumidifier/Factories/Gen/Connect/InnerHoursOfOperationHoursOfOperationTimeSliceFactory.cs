// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Connect;

public class InnerHoursOfOperationHoursOfOperationTimeSliceFactory(Action<Humidifier.Connect.HoursOfOperationTypes.HoursOfOperationTimeSlice> factoryAction = null) : SubResourceFactory<Humidifier.Connect.HoursOfOperationTypes.HoursOfOperationTimeSlice>
{

    protected override Humidifier.Connect.HoursOfOperationTypes.HoursOfOperationTimeSlice Create()
    {
        var hoursOfOperationTimeSliceResult = CreateHoursOfOperationTimeSlice();
        factoryAction?.Invoke(hoursOfOperationTimeSliceResult);

        return hoursOfOperationTimeSliceResult;
    }

    private Humidifier.Connect.HoursOfOperationTypes.HoursOfOperationTimeSlice CreateHoursOfOperationTimeSlice()
    {
        var hoursOfOperationTimeSliceResult = new Humidifier.Connect.HoursOfOperationTypes.HoursOfOperationTimeSlice();

        return hoursOfOperationTimeSliceResult;
    }

} // End Of Class

public static class InnerHoursOfOperationHoursOfOperationTimeSliceFactoryExtensions
{
}
