using System.Collections.Generic;
using UnityEngine;

public class ListNames : MonoBehaviour
{
    public List<string> names = new List<string>();

    Dictionary<int, string> people = new Dictionary<int, string>();

  
    [SerializeField] private int _selectNumber;

    private readonly string str;
    private readonly int _selectNumber1;

    public void OnClick()
    {        
        AddName(str);
        GetNames(_selectNumber1);              
    }

    private void AddName(string name)
    {      
        name = names[_selectNumber];
        people.Add(1, name);
        
        Debug.Log(people[1]);
    }

    private void GetNames(int length)
    {       
        length = people[1].Length; 
        
        Debug.Log(length);
    }
}
