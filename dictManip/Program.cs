using System;

class Program
{
    public static void Main(string[] args)
    {
        //Console.Write("premier chaine: ");
        Dictionary<char, string> myDictionary = new Dictionary<char, string>
        {
        { 'a' , "apple"},
        { 'b' , "bee"},
        { 'c' , "carrot" }
        };
        //Console.WriteLine(myDictionary);
        myDictionary.Remove('c');
        //Console.WriteLine(myDictionary);

    }
}