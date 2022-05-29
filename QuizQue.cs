using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineQuiz
{
    public class Quiz
    {
        public static List<Questions> java = new List<Questions>();
        public static List<Questions> csharp = new List<Questions>();
        public static List<Questions> html = new List<Questions>();

        public static int score = 0;

        static Quiz()
        {
            java.Add(new Questions("1. Which of the following option leads to the portability and security of Java ?", "Bytecode is executed by JVM", "The applet makes the Java code secure and portable", "Use of exception handling", "Dynamic binding between objects", "A"));
            java.Add(new Questions("2. Which of the following is not a Java features ?", "Dynamic", "Architecture Neutral", "Use of pointers", "Object - oriented", "C"));
            java.Add(new Questions("3. The \u0021 article referred to as a", "Unicode escape sequence", "Octal escape", "Hexadecimal", "Line feed", "A"));
            java.Add(new Questions("4.  _____ is used to find and fix bugs in the Java programs.", "JVM", "JRE", "JDK", "JDB", "D"));
            java.Add(new Questions("5. What is the return type of the hashCode() method in the Object class?", "Object", "int", "long", "void", "B"));
            java.Add(new Questions("6. Which of the following is a valid long literal?", "ABH8097", "L990023", "904423", "0xnf029L", "D"));
            java.Add(new Questions("7. What does the expression float a = 35 / 0 return?", "0", "Not a Number", "Infinity", "Run time exception", "C"));
            java.Add(new Questions("8. Evaluate the following Java expression, if x=3, y=5, and z=10:  ++z + y - y + z + x++", "24", "23", "20", "25", "D"));
            java.Add(new Questions("9. Which of the following tool is used to generate API documentation in HTML format from doc comments in source code?", "javap tool", "javaw command", "Javadoc tool", "javah command", "C"));
            java.Add(new Questions("10. Which of the following creates a List of 3 visible items and multiple selections abled?", "new List(false, 3)", "new List(3, true)", "new List(true, 3)", "new List(3, false)", "B"));

            csharp.Add(new Questions("1. CLR is the .Net equivalent of _____.", "Java Virtual machine", "Common Language Runtime", "Common Type System", "Common Language Specification", "A"));
            csharp.Add(new Questions("2. Abstract class contains _____.", "Abstract methods", "Non Abstract methods", "", "Both", "None"));
            csharp.Add(new Questions("3. The default scope for the members of an interface is _____.", "private", "public", "protected", "internal", "B"));
            csharp.Add(new Questions("4. Which of the following statements is incorrect about delegate?", "Delegates are reference types.", "Delegates are object-oriented.", "Delegates are type-safe.", "Only one can be called using a delegate.", "D"));
            csharp.Add(new Questions("5. The space required for structure variables is allocated on the stack.", "Defining of constructors can be implicit or explicit.", "The calling of constructors is explicit.", "Implicit constructors can be parameterized or parameterless.", "Explicit constructors can be parameterized or parameterless.", "C"));
            csharp.Add(new Questions("6. Reference is a ___.", "Copy of class which leads to memory allocation.", "Copy of class that is not initialized.", "Pre-defined data type.", "Copy of class creating by an existing instance.", "D"));
            csharp.Add(new Questions("7. The data members of a class by default are?", "protected, public", "private, public", "private", "public", "C"));
            csharp.Add(new Questions("8. What is the value returned by function compareTo( ) if the invoking string is less than the string compared?", "Zero", "A value of less than zero", "A value greater than zero", "None of the mentioned", "B"));
            csharp.Add(new Questions("9. The correct way to overload +operator?", "public sample operator +  (sample a, sample b)", "public abstract operator +  (sample a, sample b)", "public static operator +  (sample a, sample b)", "all of the mentioned above", "D"));
            csharp.Add(new Questions("10. Select the two types of threads mentioned in the concept of multithreading?", "Foreground", "Background", "Only foreground", "Both foreground and background", "D"));

            html.Add(new Questions("1. HTML stands for -", "HighText Machine Language", "HyperText and links Markup Language", "HyperText Markup Language", "None of these", "C"));
            html.Add(new Questions("2. The correct sequence of HTML tags for starting a webpage is -", "Head, Title, HTML, body", "HTML, Body, Title, Head", "HTML, Head, Title, Body", "HTML, Head, Title, Body", "D"));
            html.Add(new Questions("3. Which of the following element is responsible for making the text bold in HTML?", "<pre>", "<a>", "<b>", "<br>", "C"));
            html.Add(new Questions("4. Which of the following tag is used for inserting the largest heading in HTML?", "<h3>", "<h1>", "<h5>", "<h6>", "B"));
            html.Add(new Questions("5. Which of the following tag is used to insert a line-break in HTML?", "<br>", "<a>", "<pre>", "<b>", "A"));
            html.Add(new Questions("6. How to create an unordered list (a list with the list items in bullets) in HTML?", "<ul>", "<ol>", "<li>", "<i>", "A"));
            html.Add(new Questions("7. Which character is used to represent the closing of a tag in HTML?", "!", "/", ".", "none", "D"));
            html.Add(new Questions("8. How to create an ordered list (a list with the list items in numbers) in HTML?", "<ul>", "<ol>", "<li>", "<i>", "B"));
            html.Add(new Questions("9. Which of the following element is responsible for making the text italic in HTML?", "<i>", "<italic>", "<it>", "<pre>", "A"));
            html.Add(new Questions("10. <input> is - ", "a format tag.", "an empty tag.", "All of the above", "None of the above", "B"));

        }

    }
}
