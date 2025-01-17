# Language Converter: Arabic to Franco-Arabic and Vice Versa

This project provides a utility for converting text between Arabic and Franco-Arabic. It is designed to handle text seamlessly, ensuring characters without mappings remain unchanged.

## Features

- **Arabic to Franco-Arabic Conversion**:
  Converts Arabic characters to their Franco-Arabic equivalents.
  
- **Franco-Arabic to Arabic Conversion**:
  Converts Franco-Arabic text back to Arabic while preserving any unmapped characters.

## Technologies Used

- **C#**
- .NET Framework/Core

## How It Works

The converter uses dictionaries to map characters and patterns between the two languages. For characters without defined mappings, the original character is retained.

### Example Usage

#### Arabic to Franco-Arabic

```csharp
string arabicText = "السلام عليكم";
string francoText = LanguageConverter.ConvertToFranco(arabicText);
Console.WriteLine(francoText); // Outputs: alslam 3lykm
