using UnityEngine;
using System.Collections;

public enum Types { Seed }


public class Item{
    public Types type
    {
        get { return type; }
        private set { type = value; }
    }
    public string Name
    {
        get { return Name; }
        private set { Name = value; }
    }


    public Item(string Name,Types value)
    {
        type = value;
        this.Name = Name;
    }
}
