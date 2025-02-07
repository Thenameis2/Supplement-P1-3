namespace Supplement_P1_3;
using System.Text;

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

        /// <summary>
        /// Creates a binary file that takes take two parameters.
        /// </summary>
        /// <param name="filePath">he path where the file will be created.</param>
        /// <param name="content"> The byte array to write to the file.</param>

        public static void CreateBinaryFile(string filePath, byte[] content)
        {
            File.WriteAllBytes(filePath, content);
        }

        /// <summary>
        /// Reads the contents of an ASCII file and returns it as a string.
        /// </summary>
        /// <param name="filePath"> the path of the file to read.</param>
        /// <returns> The file's contents as a string. </returns>
        public static string ReadAsciiFile(string filePath)
        {
            return File.ReadAllText(filePath);

        }

        /// <summary>
        /// Reads the contents of a binary file and returns it as a byte array.
        /// </summary>
        /// <param name="filePath"> The path of the file to read. </param>
        /// <returns> The file's contents as a byte array.</returns>

        public static byte[] ReadBinaryFile(string filePath)
        {
            return File.ReadAllBytes(filePath);
        }

/// <summary>
/// Function to compare file sizes of binary and ascii files.
/// </summary>
        public static void CompareFileSizes()
        {
            int[] sizes = { 10, 100, 1000, 10000, 1000000 };
            Random rand = new Random();
            string charsForString = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789"; 

            foreach (int size in sizes)
            {
                
                StringBuilder randomString = new StringBuilder();
                for (int i = 0; i < size; i++)
                {
                    randomString.Append(charsForString[rand.Next(charsForString.Length)]);
                }
                string finalString = randomString.ToString();

            
                string asciiPath = $"ascii_{size}.txt";
                string binaryPath = $"binary_{size}.bin";

            
                File.WriteAllText(asciiPath, finalString, Encoding.ASCII);

                
                using (FileStream fs = new FileStream(binaryPath, FileMode.Create))
                using (GZipStream gzip = new GZipStream(fs, CompressionLevel.Optimal))
                {
                    byte[] binaryData = Encoding.UTF8.GetBytes(finalString);
                    gzip.Write(binaryData, 0, binaryData.Length);
                }

                
                long asciiSize = new FileInfo(asciiPath).Length;
                long binarySize = new FileInfo(binaryPath).Length;

                Console.WriteLine($"Size {size}: ASCII = {asciiSize} bytes, Binary = {binarySize} bytes");
            }
        }
}
