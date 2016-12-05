using Nancy;
using AddressBook;
using System.Collections.Generic;


namespace AddressBook
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["add_new_contact.cshtml"];
      Get["/view_all_contacts"] = _ => {
        List<string> GetName = Name.GetAll();
        Name newName = new Name(Request.Query["name-added"]);
        return View["view_all_contacts.cshtml", newName];
      };
      Post["/name_added"] = _ => {
      Address newAddress = new Address (Request.Form["new-name"]);
      newAddressSave();
      return View["name_added.cshtml", newName];
    };
    Post["/names_cleared"] = _ => {
      Name.ClearAll();
      return View["names_cleared.cshtml"];
    };
  }
}
}
