namespace Supplement_P1_3.Tests;

public class UnitTest1
{

    private readonly string testAsciiFile = "test_ascii.txt";
    
    [Fact]
    public void CreateAsciiFile()
    {
         string content = "Hello, File!";
        Supplement_P1_3.CreateAsciiFile(testAsciiFile, content);
        
        Assert.True(File.Exists(testAsciiFile));
        Assert.Equal(content, File.ReadAllText(testAsciiFile));

        File.Delete(testAsciiFile);

    }
}
