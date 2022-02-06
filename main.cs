using System;

class MainClass 
{
  public static void Main (string[] args) 
  {
    EmployeeList allEmployees = new EmployeeList();
    int choice;
    string name;
    double salary;
    int numID;

    bool menu = true;

    while (menu == true)
    {
    Console.Clear();
    Msg();
    choice = Convert.ToInt32(Console.ReadLine());

    switch (choice)
    {
      case 1:
      Console.Clear();
      Console.WriteLine("Enter name: ");
      name = Console.ReadLine();
      Console.WriteLine("Enter employee ID number: ");
      numID = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Enter salary: ");
      salary = Convert.ToDouble(Console.ReadLine());

      allEmployees.AddToTail(new Employee(name, numID, salary));

      EnterMsg();
      string enter = Console.ReadLine();
      Msg();
      break;

      case 2:
      Console.Clear();
      Console.WriteLine("Enter the ID number you want to delete: ");
      int pos = Convert.ToInt32(Console.ReadLine()); 

      allEmployees.Delete(pos);
      break;

      case 3:
      Console.Clear();
      allEmployees.DisplayList();
      EnterMsg();
      enter = Console.ReadLine();
      Msg();
      break;

      case 4:
      Console.Clear();
      Console.WriteLine("Number of employees: "  + allEmployees.GetCount());
      EnterMsg();
      enter = Console.ReadLine();
      Msg();
      break;

      case 5:
      Console.Clear();
      Console.WriteLine("ID number: ");
      int num = Convert.ToInt32(Console.ReadLine());
  
      Console.Clear();
      allEmployees.GetEmployee(num);
      EnterMsg();
      enter = Console.ReadLine();
      Msg();
      break;
    } 
  }
  }

  public static void Msg()
  {
    Console.WriteLine("Press 1,2,3 or 4 to do the following:\n1. Add a new employee.\n2. Delete an employee with specified id number.\n3. View employees.\n4. Display the number of employees.\n5. Search for an employee with a specified id number.");
  }

  public static void EnterMsg()
  {
    Console.WriteLine("Press enter to return to continue");
  }
}