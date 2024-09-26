// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Config;

public class InnerOrganizationConformancePackConformancePackInputParameterFactory(Action<Humidifier.Config.OrganizationConformancePackTypes.ConformancePackInputParameter> factoryAction = null) : SubResourceFactory<Humidifier.Config.OrganizationConformancePackTypes.ConformancePackInputParameter>
{

    protected override Humidifier.Config.OrganizationConformancePackTypes.ConformancePackInputParameter Create()
    {
        var conformancePackInputParameterResult = CreateConformancePackInputParameter();
        factoryAction?.Invoke(conformancePackInputParameterResult);

        return conformancePackInputParameterResult;
    }

    private Humidifier.Config.OrganizationConformancePackTypes.ConformancePackInputParameter CreateConformancePackInputParameter()
    {
        var conformancePackInputParameterResult = new Humidifier.Config.OrganizationConformancePackTypes.ConformancePackInputParameter();

        return conformancePackInputParameterResult;
    }

} // End Of Class

public static class InnerOrganizationConformancePackConformancePackInputParameterFactoryExtensions
{
}
