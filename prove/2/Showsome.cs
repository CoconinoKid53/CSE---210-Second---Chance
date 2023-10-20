using System;
using System.ComponentModel.DataAnnotations;
public class Showsome {

    DateTime today = DateTime.Now;
    public string? _entry1;
    public string? _date;
    public string? _prompt;

 

public void WritePrompt()
{
    Prompt prompt1 = new Prompt();

    _date = today.ToString("MM/dd/yy");
    _prompt = prompt1.sentence();
    _entry1 = Console.ReadLine();


}
 public  void Display () 
 {
    Console.WriteLine($"display date{_date} , prompt {_prompt}, entry {_entry1}"); 
    
 }

    public string C1()
    {
        return  $"{_date}, {_prompt}, {_entry1}";
    }

    public void entry(string[] fast)
    {
        _date = fast [0];
        _prompt = fast [1];
        _entry1 = fast [2];
    }
}