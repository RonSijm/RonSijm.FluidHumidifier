// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Kendra;

public class InnerIndexJwtTokenTypeConfigurationFactory(Action<Humidifier.Kendra.IndexTypes.JwtTokenTypeConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Kendra.IndexTypes.JwtTokenTypeConfiguration>
{

    protected override Humidifier.Kendra.IndexTypes.JwtTokenTypeConfiguration Create()
    {
        var jwtTokenTypeConfigurationResult = CreateJwtTokenTypeConfiguration();
        factoryAction?.Invoke(jwtTokenTypeConfigurationResult);

        return jwtTokenTypeConfigurationResult;
    }

    private Humidifier.Kendra.IndexTypes.JwtTokenTypeConfiguration CreateJwtTokenTypeConfiguration()
    {
        var jwtTokenTypeConfigurationResult = new Humidifier.Kendra.IndexTypes.JwtTokenTypeConfiguration();

        return jwtTokenTypeConfigurationResult;
    }

} // End Of Class

public static class InnerIndexJwtTokenTypeConfigurationFactoryExtensions
{
}
