// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Config;

public class InnerConformancePackConformancePackInputParameterFactory(Action<Humidifier.Config.ConformancePackTypes.ConformancePackInputParameter> factoryAction = null) : SubResourceFactory<Humidifier.Config.ConformancePackTypes.ConformancePackInputParameter>
{

    protected override Humidifier.Config.ConformancePackTypes.ConformancePackInputParameter Create()
    {
        var conformancePackInputParameterResult = CreateConformancePackInputParameter();
        factoryAction?.Invoke(conformancePackInputParameterResult);

        return conformancePackInputParameterResult;
    }

    private Humidifier.Config.ConformancePackTypes.ConformancePackInputParameter CreateConformancePackInputParameter()
    {
        var conformancePackInputParameterResult = new Humidifier.Config.ConformancePackTypes.ConformancePackInputParameter();

        return conformancePackInputParameterResult;
    }

} // End Of Class

public static class InnerConformancePackConformancePackInputParameterFactoryExtensions
{
}
