using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CSharpSummary.Inheritence
{
    public class Animal
    {
        public void hello(double a) => Console.WriteLine("Animal");
        public void hello2(int a) => Console.WriteLine("Animal");
        public virtual void hello3(double a) => Console.WriteLine("Animal");
        //no puede ser sealed porque tiene que sobreescribir algún método
        //public sealed void hello4(int a) => Console.WriteLine("Animal");
        public virtual void hello5(double a) => Console.WriteLine("Animal");
        public void hello6(double a) => Console.WriteLine("Animal");
        public void hello8(double a) => Console.WriteLine("Animal");
        public void hello9(int a) => Console.WriteLine("Animal");
    }
    sealed class Mamifero: Animal
    {
        public void hello() => Console.WriteLine("Mamifero");
    }
    //No puede heredar de una clase sealed
    //public class Gato: Mamifero
    //{
    //    public void hello() => Console.WriteLine("Soy un gato")
    //}

    public class Perro : Animal
    {
        public void hello(int a) => Console.WriteLine("Perro");
        public void hello2(double a) => Console.WriteLine("Perro");
        //Tiene que llevar el override
        //al ser un override debe llevar la misma firma
        //public sealed override void hello3(int a) => Console.WriteLine("Perro");
        public sealed override void hello3(double a) => Console.WriteLine("Perro");
        void hello5(int a) => Console.WriteLine("Perro");
        public virtual void hello7(int a) => Console.WriteLine("Perro");
        public void hello8(double a) {
            base.hello8(a);
            Console.WriteLine("Perro");
        }


    }
    public class Bulldog : Perro
    {
        //Error porque hello3 en sealed en Perro
        //public override void hello3(int a) => Console.WriteLine("Bulldog");
        public void hello8(double a)
        {
            base.hello8(a); 
            Console.WriteLine("Bulldog");
        }
        //error porque no está marcado como abstract, virtual o override en el nivel superior
        //public override void hello9(int a) => base.hello9(a);
    }

    public class InheritenceShowMessages
    {
        public void Print()
        {
            int intValue = 2;
            double doubleValue = 3.2d;
            var animal = new Animal();
            animal.hello(intValue);                         //Animal          
            animal.hello(doubleValue);                      //Animal
            animal.hello2(intValue);                        //Animal          
            //animal.hello2(doubleValue); --> no se puede convertir double a int
            animal.hello2((int)doubleValue);//truncamiento  //Animal
            animal.hello3(intValue);                        //Animal
            animal.hello3((int)doubleValue);                //Animal
            //animal.hello7(intValue); --> no soportado en animal
            Console.WriteLine("----------------------------");
            var perro = new Perro();
            perro.hello(intValue);                          //Perro
            perro.hello(doubleValue);                       //Animal
            perro.hello2(intValue);                         //Perro
            perro.hello2(doubleValue);                      //Perro
            perro.hello2((int)doubleValue);//truncamiento   //Perro
            perro.hello3(intValue);                         //Perro
            perro.hello3(doubleValue);                      //Perro
            perro.hello5(intValue);                         //Perro
            perro.hello5(doubleValue);                      //Animal
            perro.hello6(doubleValue);                      //Animal
            Console.WriteLine("----------------------------");
            var bulldog = new Bulldog();
            bulldog.hello(intValue);                        //Perro
            bulldog.hello(doubleValue);                     //Animal
            bulldog.hello2(intValue);                       //Perro
            bulldog.hello2(doubleValue);                    //Perro
            bulldog.hello2((int)doubleValue);               //Perro
            bulldog.hello3(intValue);                       //Perro
            bulldog.hello3((int)doubleValue);               //Perro
            bulldog.hello8(doubleValue);                    //Aniamal, Perro, Buldog
            bulldog.hello9((int)doubleValue);               //Animal
            Console.WriteLine("---------CAST---------");
            //Perro perro2 = new Animal(); --> no soportado
            //Perro perro3 = (Perro)animal;--> no soportado
            //perro3.hello(intValue);
            //perro3.hello(doubleValue);
            //perro3.hello2(intValue);
            //perro3.hello2(doubleValue);
            //perro3.hello2((int)doubleValue);//truncamiento
            //perro3.hello3(intValue);
            //perro3.hello3(doubleValue);
            //perro3.hello5(intValue);
            //perro3.hello5(doubleValue);
            //perro3.hello6(doubleValue);
            Console.WriteLine("----------------------------");
            Animal animal2 = perro;
            animal2.hello(intValue);                        //Animal
            animal2.hello(doubleValue);                     //Animal
            animal2.hello2(intValue);                       //Animal
            
            //--> hay que hacer un casting
            ((Perro)animal2).hello2(doubleValue);           //Perro
            animal2.hello2((int)doubleValue);//truncamient  //Animal
            animal2.hello3(intValue);                       //Perro
            animal2.hello3((int)doubleValue);               //Perro --> override
            animal2.hello5(doubleValue);                    //Animal
            animal2.hello8(doubleValue);                    //Animal
        }
    }
}
