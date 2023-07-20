using CSharpSummary.AccessModifiers;

namespace CSharpSummary
{
    public class Class1: DefaultInterfacePublic
    {
        public string Name => throw new NotImplementedException();

        public string GetName()
        {
            throw new NotImplementedException();
        }

        public int method(int x)
        {
            var defaultClassInternal = new DefaultClassIsInternal { };
            defaultClassInternal.GetName();

            var defaultStruct = new DefaultStruct() { };
            //defaultStruct.MyProperty = 0;Default properties are private
            var defaultRecord = new DefaultRecord() { };
            
            return (int)DefaultEnum.Value1;
        }
    }
}