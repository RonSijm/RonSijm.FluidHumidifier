// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CleanRooms;

public class InnerAnalysisTemplateHashFactory(Action<Humidifier.CleanRooms.AnalysisTemplateTypes.Hash> factoryAction = null) : SubResourceFactory<Humidifier.CleanRooms.AnalysisTemplateTypes.Hash>
{

    protected override Humidifier.CleanRooms.AnalysisTemplateTypes.Hash Create()
    {
        var hashResult = CreateHash();
        factoryAction?.Invoke(hashResult);

        return hashResult;
    }

    private Humidifier.CleanRooms.AnalysisTemplateTypes.Hash CreateHash()
    {
        var hashResult = new Humidifier.CleanRooms.AnalysisTemplateTypes.Hash();

        return hashResult;
    }

} // End Of Class

public static class InnerAnalysisTemplateHashFactoryExtensions
{
}
