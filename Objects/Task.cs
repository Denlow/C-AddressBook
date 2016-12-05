using System.Collections.Generic;

namespace AddressBook.Objects

{
  public class Address
  {
    private string _name;
    private static List<string> _instances = new List<string> {};

    public Address (string name)
    {
      _name = name;
    }
    public string GetName()
    {
      return _name;
    }
    public void SetName(string newName)
    {
      _name = newName;
    }
    public static List<string> GetAll()
    {
      return _instances;
    }
    public void Save()
    {
      _instances.Add(_name);
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
};
