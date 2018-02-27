using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileInputOutput
{
    class  FileIO
    {

        static void Main(string[] args)
        {
            TextWriter();
            TextReader();
            BinaryWriter();
            BinaryReader();
            StringWriterReader();
            Testing();
            Console.ReadLine();
        }

        internal static void Testing()
        {
            log4net.Config.BasicConfigurator.Configure();
            log4net.ILog log = log4net.LogManager.GetLogger(typeof(FileIO));
            try
            {
                log.Info("I am Writing the data in to a file syste");
                log.Info("After writing the data read all data from file");
                log.Debug("This is a Debug message");
                log.Info("This is a Info message");
                log.Warn("This is a Warning message");
                log.Error("This is an Error message");
                log.Fatal("This is a Fatal message");

                // string str = String.Empty;
                // string subStr = str.Substring(0, 4); //this line will create error as the string "str" is empty.  
            }
            catch (Exception ex)
            {
                log.Error("Error Message: " + ex.Message.ToString(), ex);
            }

        }

        internal static void TextWriter()
        {
            using (TextWriter writer = File.CreateText("F:\\fileIO\\textwriterfile.txt"))
            {
                writer.WriteLine("Hello India");
                writer.WriteLine("This is my oppinion");
            }
            Console.WriteLine("Data written successfully in TextFile...");
        }

        internal static void TextReader()
        {
            Console.WriteLine("Reading Data from TextFile");
            using (TextReader tr = File.OpenText("F:\\fileIO\\textwriterfile.txt"))
            {
                Console.WriteLine(tr.ReadToEnd());
            }
        }

        internal static void BinaryWriter()
        {
            string fileName = "F:\\fileIO\\Binarywriterfile.txt";
            using (BinaryWriter writer = new BinaryWriter(File.Open(fileName, FileMode.Create)))
            {
                writer.Write(2.5);
                writer.Write("this is string data");
                writer.Write(true);
            }
            Console.WriteLine("Data written successfully in BinaryWriter...");
        }

        internal static void BinaryReader()
        {
            Console.WriteLine("Reading Data from BinaryReader");
            using (BinaryReader reader = new BinaryReader(File.Open("F:\\fileIO\\Binarywriterfile.txt", FileMode.Open)))
            {
                Console.WriteLine("Double Value : " + reader.ReadDouble());
                Console.WriteLine("String Value : " + reader.ReadString());
                Console.WriteLine("Boolean Value : " + reader.ReadBoolean());
            }
        }
        internal static void StringWriterReader()
        {
            Console.WriteLine(" ");
            string text = "Hello, Welcome to the Banglore \n" +
                 "It is nice city. \n" +
                 "It provides more IT company";
            // Creating StringBuilder instance  
            StringBuilder sb = new StringBuilder();
            // Passing StringBuilder instance into StringWriter  
            StringWriter writer = new StringWriter(sb);
            // Writing data using StringWriter  
            writer.WriteLine(text);
            writer.Flush();
            // Closing writer connection  
            writer.Close();
          Console.WriteLine("Data written successfully in StringWriter...");
            Console.WriteLine("Reading Data from StringReader");
            // Creating StringReader instance and passing StringBuilder  
            StringReader reader = new StringReader(sb.ToString());
            // Reading data  
            while (reader.Peek() > -1)
            {
                Console.WriteLine(reader.ReadLine());
            }
        }

        
    }
}
