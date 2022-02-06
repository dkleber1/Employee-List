using System;

class EmployeeList
{
  private Employee head;

  private int count;

  public EmployeeList()
  {
    count = 0;
  }

  public void Insert(Employee employee, Employee newEmployee)
  {
    if (count == 0)
    {
      head = newEmployee;
    }
  }

  public void AddToTail(Employee newEmployee)
  {
    if (count == 0)
    {
      head = newEmployee;
    }
    else
    {
      Employee curEmployee = head;

      while (curEmployee.GetNext() != null)
      {
        curEmployee = curEmployee.GetNext();
      }
      curEmployee.SetNext(newEmployee);
    }
    count++;  
  }

  public void DeleteHead()
  {
    head = head.GetNext();
    count--;
  }

  public void Delete(int position)
  {
    if (head != null)
    {
      Employee firstArrow = head;
      Employee curEmployee = head;


     while(curEmployee.GetEmployeeID() != position && curEmployee.GetNext() != null)
    {
      firstArrow = curEmployee;
      curEmployee = curEmployee.GetNext();
    }

    if (curEmployee.GetEmployeeID() == position)
    {
      if (curEmployee != head)
      {
        firstArrow.SetNext(curEmployee.GetNext());
        count--;
      }
      else
      {
      head = curEmployee.GetNext();
      count--;
      }
    }
    }
  }

  public void DisplayList()
  {
    Employee curEmployee = head;

    for (int i = 0; i < count; i++)
    {
      Console.WriteLine(i + ".)" + "\n" + "ID: " + curEmployee.GetEmployeeID() + "\nName: " + curEmployee.GetName() + "\nSalary: $" + curEmployee.GetSalary() + "\n");

      curEmployee = curEmployee.GetNext();
    }
  }

  public int GetCount()
  {
    return count;
  }

  public void GetEmployee(int numID)
  {
    if (head != null)
    {
    Employee firstArrow = head;
    Employee curEmployee = head;
    

    while(curEmployee.GetEmployeeID() != numID && curEmployee.GetNext() != null)
    {
      firstArrow = curEmployee;
      curEmployee = curEmployee.GetNext();
    }

      if (curEmployee.GetEmployeeID() == numID)
      {  
        curEmployee.CargoValues();
      }   
    }  
  }
}