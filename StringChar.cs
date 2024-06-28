namespace String
{
    internal class StringChar
    {
        static void Main(string[] args)
        {
            /*
            > String stores multiple characters in a variable
            > Double quotes " will be used with string datatype
            > Char stores single character
            > Single quote will be used with char datatype

            Escape Sequence:
            > An escape sequence is a special character combination starting with a backslash (\) used to represent non-printable characters or other special characters in strings.
            > In short, it lets you put special meanings into text.
            > Example:
                \t - 4 or 8 spaces
                \n - new line
            Here are some widely used escape sequences in C#:

`\n`: Newline - Inserts a new line character.

`\t`: Horizontal tab - Moves the cursor to the next tab stop.

`\b`: Backspace - Deletes the character preceding the escape sequence.

`\a`: Alert (bell) - Produces an audible or visual alert. 

`\r`: Carriage return - Moves the cursor to the beginning of the current line. Oft used with `\n` for new line)

`\'`: Single quotation mark - Allows including a single quote within a single-oted stng.

`\"`: Double quotation mark - Allows including a double quote within a double-oted stng.

`\\`: Backslash - Represents a literal backslash character. 

`\?`: Literal question mark - Used when a question mark might be sinterpreted as a trigraph (a sequence of three characters treated as a single aracter).

Additionally:

`\ooo`: Octal representation of an ASCII character (ooo is a sequence of up to  digits). (e.g. `\033` for ESC character)

`\xhh` or `\xhhhh`:** Hexadecimal representation of an ASCII or Unicode character (hh is 2 digits for ASCII, hhhh is 4 digits for Unicode). (e.g. `\x41` for 'A')


            Verbatim Literal:
            A verbatim literal is a string prefixed with "@" that treats all characters literally, including escape sequences and newlines.
            e.g. string path = @"C:\Users\myUser\Documents\"
            */

            // Varaibles
            string name = "\"Talha Ahmad\"";        // String --- 16 bpc (bit per character)
            string verbatim = @"C:\Users\myUser\Documents\";
            char character = 'C';               // Character --- 16 bit

            // Output
            Console.WriteLine("Name:\t\t{0}", name);
            Console.WriteLine("Character:\t{0}", character);
            Console.WriteLine("Verbatim:\t{0}", verbatim);
        }
    }
}
