// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Connect;

public class InnerHoursOfOperationHoursOfOperationsIdentifierFactory(Action<Humidifier.Connect.HoursOfOperationTypes.HoursOfOperationsIdentifier> factoryAction = null) : SubResourceFactory<Humidifier.Connect.HoursOfOperationTypes.HoursOfOperationsIdentifier>
{

    protected override Humidifier.Connect.HoursOfOperationTypes.HoursOfOperationsIdentifier Create()
    {
        var hoursOfOperationsIdentifierResult = CreateHoursOfOperationsIdentifier();
        factoryAction?.Invoke(hoursOfOperationsIdentifierResult);

        return hoursOfOperationsIdentifierResult;
    }

    private Humidifier.Connect.HoursOfOperationTypes.HoursOfOperationsIdentifier CreateHoursOfOperationsIdentifier()
    {
        var hoursOfOperationsIdentifierResult = new Humidifier.Connect.HoursOfOperationTypes.HoursOfOperationsIdentifier();

        return hoursOfOperationsIdentifierResult;
    }

} // End Of Class

public static class InnerHoursOfOperationHoursOfOperationsIdentifierFactoryExtensions
{
}
