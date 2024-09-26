// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Glue;

public class InnerMLTransformFindMatchesParametersFactory(Action<Humidifier.Glue.MLTransformTypes.FindMatchesParameters> factoryAction = null) : SubResourceFactory<Humidifier.Glue.MLTransformTypes.FindMatchesParameters>
{

    protected override Humidifier.Glue.MLTransformTypes.FindMatchesParameters Create()
    {
        var findMatchesParametersResult = CreateFindMatchesParameters();
        factoryAction?.Invoke(findMatchesParametersResult);

        return findMatchesParametersResult;
    }

    private Humidifier.Glue.MLTransformTypes.FindMatchesParameters CreateFindMatchesParameters()
    {
        var findMatchesParametersResult = new Humidifier.Glue.MLTransformTypes.FindMatchesParameters();

        return findMatchesParametersResult;
    }

} // End Of Class

public static class InnerMLTransformFindMatchesParametersFactoryExtensions
{
}
