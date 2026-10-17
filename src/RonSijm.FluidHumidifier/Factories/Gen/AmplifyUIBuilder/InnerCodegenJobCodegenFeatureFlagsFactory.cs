// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AmplifyUIBuilder;

public class InnerCodegenJobCodegenFeatureFlagsFactory(Action<Humidifier.AmplifyUIBuilder.CodegenJobTypes.CodegenFeatureFlags> factoryAction = null) : SubResourceFactory<Humidifier.AmplifyUIBuilder.CodegenJobTypes.CodegenFeatureFlags>
{

    protected override Humidifier.AmplifyUIBuilder.CodegenJobTypes.CodegenFeatureFlags Create()
    {
        var codegenFeatureFlagsResult = CreateCodegenFeatureFlags();
        factoryAction?.Invoke(codegenFeatureFlagsResult);

        return codegenFeatureFlagsResult;
    }

    private Humidifier.AmplifyUIBuilder.CodegenJobTypes.CodegenFeatureFlags CreateCodegenFeatureFlags()
    {
        var codegenFeatureFlagsResult = new Humidifier.AmplifyUIBuilder.CodegenJobTypes.CodegenFeatureFlags();

        return codegenFeatureFlagsResult;
    }

} // End Of Class

public static class InnerCodegenJobCodegenFeatureFlagsFactoryExtensions
{
}
