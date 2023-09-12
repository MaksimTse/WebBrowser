using System;
using System.Collections.Generic;
using System.Linq;

public class Browser
{
    private Stack<string> _back = new Stack<string>();
    private Stack<string> _forward = new Stack<string>();
    private List<string> _history = new List<string>();
    private List<string> _bookmarks = new List<string>();

    private string _current;

    public Browser()
    {
        GoTo("google.com");
    }

    public void GoTo(string url)
    {
        _back.Push(_current);
        _current = url;
        _forward.Clear();
        _history.Add(url);
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine("Laadimine: " + url + "\n");
        Console.ResetColor();
    }

    public void Back()
    {
        if (_back.Count > 0)
        {
            _forward.Push(_current);
            _current = _back.Pop();
            _history.Add(_current);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n Tagasi on: " + _current + "\n");
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n Eelmist lehte pole. \n");
            Console.ResetColor();
        }
    }

    public void Forward()
    {
        if (_forward.Count > 0)
        {
            _back.Push(_current);
            _current = _forward.Pop();
            _history.Add(_current);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n Edasi on: " + _current);
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n Ei mingit edasist lehte. \n");
            Console.ResetColor();
        }
    }

    public string Current()
    {
        return _current;
    }

    public List<string> History()
    {
        return _history;
    }

    public void RemoveHistory()
    {
        _history.Clear();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Kustutatud külstusajaloo. \n");
        Console.ResetColor();
    }

    public void AddBookmark()
    {
        _bookmarks.Add(_current);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Lisatud praegune leht järjehoidjatesse: " + _current);
        Console.ResetColor();
    }

    public void ViewBookmarks()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Järjehoidjaid: " + string.Join(", ", _bookmarks));
        Console.ResetColor();
    }
}