/*
Exceeding requirements:
I added a class that allows the user to create a list of scriptures they want to memorize
Select a scripture at a time and memorize 
And delete that scripture from the list when they are sure that they now know the scripture.
*/

 using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

        ScriptureFile _scriptureFile = new ScriptureFile();

        Reference _ref1 = new Reference(" ", 0, 0);
        _ref1.SetBook("John");
        _ref1.SetChapter(3);
        _ref1.SetVerse(16);

        Reference _ref2 = new Reference(" ", 0, 0);
        _ref2.SetBook("Psalm");
        _ref2.SetChapter(23);
        _ref2.SetVerse(1);

        Reference _ref3 = new Reference("Psalm", 23, 1, 2);
        
        Word _word1 = new Word(" ");
        _word1.SetText("For God so loved the world, that He gave His only begotten Son. That whosoever believes in Him should not perish but have everlasting life.");

        Word _word2 = new Word(" ");
        _word2.SetText("The Lord is my shepherd; I shall not want.");

        Word _word3 = new Word(" ");
        _word3.SetText("The Lord is my shepherd; I shall not want. He makes me lie down in green pastures. He leads me beside still waters.");

        Scripture script1 = new Scripture(_ref1, _word1.GetText());
        _scriptureFile.AddScripture(script1);
        Scripture script2 = new Scripture(_ref2, _word2.GetText());
        _scriptureFile.AddScripture(script2);
        Scripture script3 = new Scripture(_ref3, _word3.GetText());
        _scriptureFile.AddScripture(script3);

        Console.WriteLine("Your Scripture List: ");
        _scriptureFile.DisplayAllScriptures();

        Console.Write("\nSelect a scripture to learn(enter number): ");
        int choice = int.Parse(Console.ReadLine()) - 1;

        Scripture selected = _scriptureFile.SelectScripture(choice);
        
        while(selected != null){
            if (choice == 0){
                while(!script1.IsCompletelyHidden()){
                    Console.Clear();
                    //Console.Write( _ref1.GetDisplayText());
                    Console.WriteLine(script1.GetDisplayText());
                    Console.WriteLine("\nPress enter to hide words or type quit to end.");

                    string input = Console.ReadLine();
                    if(input.ToLower() == "quit"){
                        Console.WriteLine("Thank you.\nSee you another day,");
                        break;
                    }
                    script1.HideRandomWords(3);
                }

                if(script1.IsCompletelyHidden()){
                    Console.Clear();
                    //Console.Write( _ref1.GetDisplayText());
                    Console.WriteLine(script1.GetDisplayText());
                    Console.WriteLine("\nGood Job, you have memorised everything.");
                    Console.Write("\nType delete if you are certain you know this scripture: ");
                    string input1 = Console.ReadLine();
                    if (input1.ToLower() == "delete"){
                        _scriptureFile.DeleteScripture(choice);
                        Console.WriteLine("\nScripture deleted successfully.");
                    }
                    break;
            }
            }

            if (choice == 1){
                while(!script2.IsCompletelyHidden()){
                    Console.Clear();
                   // Console.Write( _ref2.GetDisplayText());
                    Console.WriteLine(script2.GetDisplayText());
                    Console.WriteLine("\nPress enter to hide words or type quit to end.");
                    string input1 = Console.ReadLine(); 
                    if(input1.ToLower() == "quit"){
                        Console.WriteLine("Thank you.\nSee you another day,");
                        break;
                    }
                    script2.HideRandomWords(3);
                }
                if(script2.IsCompletelyHidden()){
                    Console.Clear();
                    //Console.Write( _ref2.GetDisplayText());
                    Console.WriteLine(script2.GetDisplayText());
                    Console.WriteLine("\nGood Job, you have memorised everything.");
                    Console.Write("\nType delete if you are certain you know this scripture: ");
                    string input2 = Console.ReadLine();
                    if (input2.ToLower() == "delete"){
                        _scriptureFile.DeleteScripture(choice);
                       Console.WriteLine("\nScripture deleted successfully.");
                    }
                }
                break;
            }
            
            if (choice == 2){
                while(!script3.IsCompletelyHidden()){
                    Console.Clear();
                   // Console.Write( _ref2.GetDisplayText());
                    Console.WriteLine(script3.GetDisplayText());
                    Console.WriteLine("\nPress enter to hide words or type quit to end.");
                    string input1 = Console.ReadLine(); 
                    if(input1.ToLower() == "quit"){
                        Console.WriteLine("Thank you.\nSee you another day,");
                        break;
                    }
                    script3.HideRandomWords(3);
                }
                if(script3.IsCompletelyHidden()){
                    Console.Clear();
                    //Console.Write( _ref2.GetDisplayText());
                    Console.WriteLine(script3.GetDisplayText());
                    Console.WriteLine("\nGood Job, you have memorised everything.");
                    Console.Write("\nType delete if you are certain you know this scripture: ");
                    string input2 = Console.ReadLine();
                    if (input2.ToLower() == "delete"){
                        _scriptureFile.DeleteScripture(choice);
                       Console.WriteLine("\nScripture deleted successfully.");
                    }
                }
                break;
            }
        }
    }
}