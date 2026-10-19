// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SecurityAgent;

public class InnerIntegrationBitbucketInputFactory(Action<Humidifier.SecurityAgent.IntegrationTypes.BitbucketInput> factoryAction = null) : SubResourceFactory<Humidifier.SecurityAgent.IntegrationTypes.BitbucketInput>
{

    protected override Humidifier.SecurityAgent.IntegrationTypes.BitbucketInput Create()
    {
        var bitbucketInputResult = CreateBitbucketInput();
        factoryAction?.Invoke(bitbucketInputResult);

        return bitbucketInputResult;
    }

    private Humidifier.SecurityAgent.IntegrationTypes.BitbucketInput CreateBitbucketInput()
    {
        var bitbucketInputResult = new Humidifier.SecurityAgent.IntegrationTypes.BitbucketInput();

        return bitbucketInputResult;
    }

} // End Of Class

public static class InnerIntegrationBitbucketInputFactoryExtensions
{
}
