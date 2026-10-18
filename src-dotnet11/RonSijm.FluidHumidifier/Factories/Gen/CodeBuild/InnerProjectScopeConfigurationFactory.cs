// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CodeBuild;

public class InnerProjectScopeConfigurationFactory(Action<Humidifier.CodeBuild.ProjectTypes.ScopeConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.CodeBuild.ProjectTypes.ScopeConfiguration>
{

    protected override Humidifier.CodeBuild.ProjectTypes.ScopeConfiguration Create()
    {
        var scopeConfigurationResult = CreateScopeConfiguration();
        factoryAction?.Invoke(scopeConfigurationResult);

        return scopeConfigurationResult;
    }

    private Humidifier.CodeBuild.ProjectTypes.ScopeConfiguration CreateScopeConfiguration()
    {
        var scopeConfigurationResult = new Humidifier.CodeBuild.ProjectTypes.ScopeConfiguration();

        return scopeConfigurationResult;
    }

} // End Of Class

public static class InnerProjectScopeConfigurationFactoryExtensions
{
}
