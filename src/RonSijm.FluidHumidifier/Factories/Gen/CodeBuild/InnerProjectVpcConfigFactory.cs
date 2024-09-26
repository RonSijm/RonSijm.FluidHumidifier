// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CodeBuild;

public class InnerProjectVpcConfigFactory(Action<Humidifier.CodeBuild.ProjectTypes.VpcConfig> factoryAction = null) : SubResourceFactory<Humidifier.CodeBuild.ProjectTypes.VpcConfig>
{

    protected override Humidifier.CodeBuild.ProjectTypes.VpcConfig Create()
    {
        var vpcConfigResult = CreateVpcConfig();
        factoryAction?.Invoke(vpcConfigResult);

        return vpcConfigResult;
    }

    private Humidifier.CodeBuild.ProjectTypes.VpcConfig CreateVpcConfig()
    {
        var vpcConfigResult = new Humidifier.CodeBuild.ProjectTypes.VpcConfig();

        return vpcConfigResult;
    }

} // End Of Class

public static class InnerProjectVpcConfigFactoryExtensions
{
}
