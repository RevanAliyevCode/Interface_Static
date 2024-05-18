// See https://aka.ms/new-console-template for more information
using UserTask;

User user1 = new("Revan", "Eliyev", (RegestrationMonth)5, "8B4R679");
User user2 = new("Revan", "Eliyev", RegestrationMonth.April, "8B4R67");
User user3 = new("Revan", "Eliyev", RegestrationMonth.April, "8B4r679");
User user4 = new("Revan", "Eliyev", RegestrationMonth.April, "8b4R679");

user1.GetDetails();
user2.GetDetails();
user3.GetDetails();
user4.GetDetails();