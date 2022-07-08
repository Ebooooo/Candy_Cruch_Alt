using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Text.RegularExpressions;

public class CreateBoard : MonoBehaviour
{
    public Transform formwhite;
    public Transform formgrey;
    public const string grey = "0";
    public const string white = "1";
    string pattern = " ";


    string[][] readFile(string file)
    {
        string text = System.IO.File.ReadAllText(file);
        string[] lines = Regex.Split(text, "\r\n");
        int rows = lines.Length;

        string[][] levelBase = new string[rows][];
        for(int i = 0; i < lines.Length; i++)
        {
            string[] stringsOfLine = Regex.Split(lines[i], pattern);
            levelBase[i] = stringsOfLine;
        }
        return levelBase;
    }

    void Start()
    {
        string[][] jagged = readFile("Assets/Board/board.txt");
        for (int y = 0; y < jagged.Length; y++)
        {
            for (int x = 0; x < jagged.Length; x++)
            {
                switch (jagged[y][x])
                {
                    case grey:
                    Instantiate(formgrey, new Vector2(x - jagged.Length/2, y - jagged.Length/2), Quaternion.identity);
                    break;
                    case white:
                    Instantiate(formwhite, new Vector2(x - jagged.Length/2, y - jagged.Length/2), Quaternion.identity);
                    break;
                }
            }
        }
    }
}
