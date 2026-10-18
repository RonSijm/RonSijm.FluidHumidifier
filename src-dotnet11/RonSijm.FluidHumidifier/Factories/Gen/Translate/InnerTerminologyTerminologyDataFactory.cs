// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Translate;

public class InnerTerminologyTerminologyDataFactory(Action<Humidifier.Translate.TerminologyTypes.TerminologyData> factoryAction = null) : SubResourceFactory<Humidifier.Translate.TerminologyTypes.TerminologyData>
{

    protected override Humidifier.Translate.TerminologyTypes.TerminologyData Create()
    {
        var terminologyDataResult = CreateTerminologyData();
        factoryAction?.Invoke(terminologyDataResult);

        return terminologyDataResult;
    }

    private Humidifier.Translate.TerminologyTypes.TerminologyData CreateTerminologyData()
    {
        var terminologyDataResult = new Humidifier.Translate.TerminologyTypes.TerminologyData();

        return terminologyDataResult;
    }

} // End Of Class

public static class InnerTerminologyTerminologyDataFactoryExtensions
{
}
