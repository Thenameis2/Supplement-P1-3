﻿namespace Supplement_P1_3;

public class Supplement_P1_3
{

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
