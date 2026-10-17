// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class FoundationModelFactory(string resourceName = null, Action<Humidifier.Bedrock.FoundationModel> factoryAction = null) : ResourceFactory<Humidifier.Bedrock.FoundationModel>(resourceName)
{

    protected override Humidifier.Bedrock.FoundationModel Create()
    {
        var foundationModelResult = CreateFoundationModel();
        factoryAction?.Invoke(foundationModelResult);

        return foundationModelResult;
    }

    private Humidifier.Bedrock.FoundationModel CreateFoundationModel()
    {
        var foundationModelResult = new Humidifier.Bedrock.FoundationModel
        {
            GivenName = InputResourceName,
        };

        return foundationModelResult;
    }

} // End Of Class

public static class FoundationModelFactoryExtensions
{
}
