# ITA

Image To ASCII library for .NET framework


# Input Image

![sample_image](https://github.com/Bojidarist/ITA/blob/master/readme_content/Octo.png)


# Sample Code

    ITAImage image = new ITAImage(PATH);
    image.ResizeImage(1000, 250);
    
    image.colorCharacters.WhiteColorCharacter = '▒';  
    image.colorCharacters.BlackColorCharacter = '█';
    image.colorCharacters.RGBBelowHundredAndFifty = '▓';
    image.colorCharacters.OtherColorsCharacter = '▒';
    
    string imageASCII = image.ToString();
    Console.WriteLine(imageASCII);


# Output

![sample_image](https://github.com/Bojidarist/ITA/blob/master/readme_content/OctoConverted.png)
