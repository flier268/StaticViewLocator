using System;

namespace ViewLocator.Generator.Common;

[AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
public sealed class GenerateViewLocatorAttribute : Attribute
{
    public string? ViewToViewModelNamespaceRule { get; set; }
    public string? ViewToViewModelSuffixRule { get; set; }
    public string[]? IncludeNamespaces { get; set; }
    public string[]? ExcludeNamespaces { get; set; }

    public GenerateViewLocatorAttribute() { }
}