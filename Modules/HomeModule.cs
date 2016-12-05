using Nancy;
using AddressBook.Objects;

namespace AddressBook
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["add_new_contact.cshtml"];
      Get["/view_all_contacts"] = _ => {
        Task newTask = new Task(Request.Query)["newName"]);
        return View["view_all_contacts.cshtml, newName"]
      }
        return View["Contact.cshtml"];
      };
    }
  }
