public class TextEncryptorTests
{
    [Fact]
    public void TestEncrypt()
    {
        //Given
        var encryptor = new TextEncryptor();
        //When
        string result = encryptor.Encrypt("Hello", 3);
        //Then
        Assert.Equal("Khoor", result);
    }

    [Fact]
    public void TestDecrypt()
    {
        //Given
        var encryptor = new TextEncryptor();
        //When
        string result = encryptor.Decrypt("Khoor", 3);
        //Then
        Assert.Equal("Hello", result);
    }

    [Fact]
    public void TestEncryptWithUpperCase()
    {
        //Given
        var encryptor = new TextEncryptor();
        //When
        string result = encryptor.Encrypt("HELLO", 3);
        //Then
        Assert.Equal("KHOOR", result);
    }

    [Fact]
    public void TestEncryptWithSpaces()
    {
        //Given
        var encryptor = new TextEncryptor();
        //When
        string result = encryptor.Encrypt("Hello World", 3);
        //Then
        Assert.Equal("Khoor Zruog", result);
    }

    [Fact]
    public void TestEncryptWithNumbers()
    {
        //Given
        var encryptor = new TextEncryptor();
        //When
        string result = encryptor.Encrypt("Hello123", 3);
        //Then
        Assert.Equal("Khoor123", result);
    }

    [Fact]
    public void TestEncryptWrapAround()
    {
        //Given
        var encryptor = new TextEncryptor();
        //When
        string result = encryptor.Encrypt("Xyz", 3);
        Assert.Equal("Abc", result);
    } 
}