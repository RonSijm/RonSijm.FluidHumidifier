namespace RonSijm.FluidHumidifier.Features.Output;

public abstract class BaseOutputResult<T> : IOutputResult
{
    public string BaseDir { get; set; }
    public string RelativePath { get; set; }
    public string LinuxRelativePath => RelativePath.Replace("\\", "/");
    public string Name { get; set; }
    public T Result { get; set; }
    public abstract string Description { get; }
    public abstract string FileName { get; }
}