namespace Supplement_P1_3.Tests;

public class UnitTest1
{

    private readonly string testAsciiFile = "test_ascii.txt";
    private readonly string testBinaryFile = "test_binary.bin";

    [Fact]
    public void CreateAsciiFile()
    {
         string content = "Hello, File!";
        Supplement_P1_3.CreateAsciiFile(testAsciiFile, content);
        
        Assert.True(File.Exists(testAsciiFile));
        Assert.Equal(content, File.ReadAllText(testAsciiFile));

        File.Delete(testAsciiFile);

    }

      [Fact]
    public void CreateBinaryFile_FileWithCorrectContent()
    {
        byte[] content = { 0x42, 0x43, 0x44 };
        Supplement_P1_3.CreateBinaryFile(testBinaryFile, content);

        Assert.True(File.Exists(testBinaryFile));
        Assert.Equal(content, File.ReadAllBytes(testBinaryFile));

        File.Delete(testBinaryFile);
    }

      [Fact]
    public void ReadAsciiFile_ReturnCorrectContent()
    {
        string content = "Test Read";
        File.WriteAllText(testAsciiFile, content);

        string result = Supplement_P1_3.ReadAsciiFile(testAsciiFile);
        Assert.Equal(content, result);

        File.Delete(testAsciiFile);
    }

     [Fact]
    public void ReadBinaryFile_ReturnCorrectContent()
    {
        byte[] content = { 0x10, 0x20, 0x30 };
        File.WriteAllBytes(testBinaryFile, content);

        byte[] result = Supplement_P1_3.ReadBinaryFile(testBinaryFile);
        Assert.Equal(content, result);

        File.Delete(testBinaryFile);
    }


}
