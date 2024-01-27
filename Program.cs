using System.ComponentModel;

namespace dz_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Disk disk= new Disk();
            Directory directory1 = new Directory();
            directory1.AddToDirectory(new WordDocument());
            directory1.AddToDirectory(new PictueDocument());
            disk.AddToDisk(directory1);
            disk.View();
        }
    }


    public interface IData
    {
        public void  View();
    }

    public class PictueDocument:IData
    {
        public void View()
        {
            Console.WriteLine("View picture");
        }

    }

    public class WordDocument : IData
    {
        public void View()
        {
            Console.WriteLine("View word");
        }
    }

    public class Directory : IData
    {
        List<IData> documents;

        public Directory() { 
        
        documents= new List<IData>();   
        }
        public void View()
        {
            Console.WriteLine("View this Directory");
            foreach (IData doc in documents)
            {
                doc.View();
            }
           
        }

        public void AddToDirectory(IData data)
        {
            documents.Add(data);
        }

        public void RemoveFromDirectory(IData data)
        {
            documents.Remove(data);
        }
    }

    public class Disk : IData
    {
        List<IData> data;

        public Disk()
        {
            data= new List<IData>();
        }
        public void View() {
            

            Console.WriteLine("View disk");
            foreach(IData dat in data)
            {
                dat.View();
            }
        }
        public void AddToDisk(IData directory)
        {
            data.Add(directory);    
        }

        public void RemoveFromDisk(IData directory)
        {
            data.Remove(directory);
        }
    }
}