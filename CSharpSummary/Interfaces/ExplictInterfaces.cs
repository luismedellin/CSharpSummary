namespace CSharpSummary.Interfaces
{
    public interface IFile
    {
        void ReadFile();
        void WriteFile(string text);
        void Default() => Console.WriteLine("test");
    }

    public class FileInfo : IFile
    {
        public void ReadFile() => Console.WriteLine("Implicit ReadFile");
        public void Default()
        {

        }
        void IFile.ReadFile() => Console.WriteLine("Reading File");
        void IFile.WriteFile(string text) => Console.WriteLine("Writing to file");
        public void Search(string text) => Console.WriteLine("Searching in file");
    }


    public class ExplictInterfaces
    {
        public void Print()
        {
            IFile file1 = new FileInfo();
            FileInfo file2 = new FileInfo();

            file1.ReadFile();
            file1.WriteFile("content");
            file1.Default();
            //file1.Search("text to be searched")//compile-time error 

            file2.Search("text to be searched");
            file2.ReadFile(); //compile-time error 
            file2.Default();
            //file2.WriteFile("content"); //compile-time error 
        }
    }
}
