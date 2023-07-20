namespace CSharpSummary.AccessModifiers
{

    record DefaultRecord
    {
        int MyProperty { get; set; }
    }

    struct DefaultStruct
    {
        int MyProperty { get; set; }
        int MyMethod()
        {
            return 0;
        }
    }

    enum DefaultEnum
    {
        Value1,
        Value2
    }

    /// <summary>
    /// Default Internal
    /// </summary>
    interface DefaultInterfacePublic
    {
        string Name { get; }
        string GetName();
    }

    /// <summary>
    /// Default Internal
    /// </summary>
    class DefaultClassIsInternal:DefaultInterfacePublic
    {
        public string Name => throw new NotImplementedException();

        int MyProperty { get; set; }

        public string GetName()
        {
            throw new NotImplementedException();
        }
    }
}
