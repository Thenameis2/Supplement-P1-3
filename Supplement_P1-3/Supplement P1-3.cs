﻿namespace Supplement_P1_3;

public class Supplement_P1_3
{
    
       /// <summary>
       /// Creates an ASCII file that takes take two parameters
       /// </summary>
       /// <param name="filePath"> The path where the file will be created </param>
       /// <param name="content"> The text content to write to the file.</param>
       public static void CreateAsciiFile(string filePath, string content)
        {
           File.WriteAllText(filePath, content);
        }

        public static void CreateBinaryFile(string filePath, byte[] content)
        {
            throw new NotImplementedException();
        }

        public static string ReadAsciiFile(string filePath)
        {
            throw new NotImplementedException();
        }

        public static byte[] ReadBinaryFile(string filePath)
        {
            throw new NotImplementedException();
        }

        public static void CompareFileSizes()
        {
            throw new NotImplementedException();
        }

}
