public class TextEncryptorTests
{
    [Fact]
    public void TestEncrypt()
    {
        var encryptor = new TextEncryptor();
        string result = encryptor.Encrypt("Hello", 3);
        Assert.Equal("Khoor", result);
    }

    [Fact]
    public void TestDecrypt()
    {
        var encryptor = new TextEncryptor();
        string result = encryptor.Decrypt("Khoor", 3);
        Assert.Equal("Hello", result);
    }

    [Fact]
    public void TestEncryptWithUpperCase()
    {
        var encryptor = new TextEncryptor();
        Assert.Equal("KHOOR", encryptor.Encrypt("HELLO", 3));
    }

    [Fact]
    public void TestEncryptWithSpaces()
    {
        var encryptor = new TextEncryptor();
        Assert.Equal("Khoor Zruog", encryptor.Encrypt("Hello World", 3));
    }

    [Fact]
    public void TestEncryptWithNumbers()
    {
        var encryptor = new TextEncryptor();
        Assert.Equal("Khoor123", encryptor.Encrypt("Hello123", 3));
    }

    [Fact]
    public void TestEncryptWrapAround()
    {
        var encryptor = new TextEncryptor();
        Assert.Equal("Abc", encryptor.Encrypt("Xyz", 3));
    } 
}