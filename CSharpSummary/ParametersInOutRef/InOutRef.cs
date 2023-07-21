namespace CSharpSummary.ParametersInOutRef
{
    public class Person
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }

    public struct Student
    {
        public string Name { get; set; }
        public int Id { get; set; }
    }

    public class InOutRef
    {
        public void Example(in int inValue, out int outValue, ref int refValue)
        {
            //inValue++; --> cannot be assigned
            //outValue++;//The compiler could not verify that the out parameter was assigned a value before it was used
            outValue = inValue + 1;
            refValue++;
        }

        public void ExampleString(string stringValue, in string inStringValue, 
            out string outStringValue, ref string refStringValue)
        {
            stringValue += "mundo";
            //inStringValue = "Hola";--> cannot be assigned
            outStringValue = $"{stringValue}-{inStringValue}";
            refStringValue += "mundo";
        }

        //sino pongo Person como public generara error porque el assembly sería internal
        public void ExampleObject(Person person, in Person personIn, out Person personOut, ref Person personRef)
        {
            person.Name = "test";
            //personIn = new Person(); --> new instance can not be created
            personIn.Name = "test";
            personOut = new Person();
            personOut.Name = "test"; //--> I must created a new instance
            personRef.Name = "test";
        }

        public void ExampleStruct(Student student, in Student studentIn, out Student studentOut, ref Student studentRef)
        {
            student.Name = "test";
            //studentIn = new Person(); //--> new instance can not be created
            student.Name = "test";
            studentOut = new Student();
            studentOut.Name = "test"; //--> I must created a new instance
            studentRef.Name = "test";
        }

        //async methods cannot have ref, in or out parameters
        //public async Task ExampleAsync(in int valu1){}

        public void Print()
        {
            string msg1 = "hola";//debe estar inicializado
            string msg2="hola";//debe estar inicializado
            string msg3;
            string msg4 = "hola";//debe estar inicializado

            ExampleString(msg1, msg2, out msg3, ref msg4 );
            Console.WriteLine( msg1);//hola-->cambios son locales en el método
            Console.WriteLine(msg2);//hola-->es readonly en el método
            Console.WriteLine(msg3);//holamundo-hola
            Console.WriteLine(msg4);//holamundo

            Person person = new Person() { Name = "hola"};//debe estar inicializada
            Person person2 = new Person() { Name = "hola"};
            Person person3; //no requiere estar inicializada por el out, pero debo crear una nueva instancia
            Person person4 = new Person() { Name = "hola"};//debe estar inicializada

            ExampleObject(person, person2, out person3, ref person4);
            Console.WriteLine(person.Name);//test
            Console.WriteLine(person2.Name);//test
            Console.WriteLine(person3.Name);//test  
            Console.WriteLine(person4.Name);//test


            string m1 = "hola";
            string m2 = m1;
            m1 = "mundo";
            Console.WriteLine(m1);//hola
            Console.WriteLine(m2);//mundo

            Student student = new Student();
            Student student2 = new Student();
            Student student3;
            Student student4 = new Student();
            ExampleStruct(student, student2, out student3, ref student4);

            Console.WriteLine(student.Name);//empty
            Console.WriteLine(student2.Name);//empty
            Console.WriteLine(student3.Name);//test
            Console.WriteLine(student4.Name);//test
        }
    }
}
