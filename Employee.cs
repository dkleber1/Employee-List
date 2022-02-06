using System;

class Employee
{
  private string name;
  private int employeeID;
  private double salary;

  private Employee next;

  public Employee(string name, int employeeID, double salary)
  {
    this.name = name;
    this.employeeID = employeeID;
    this.salary = salary;
  }

  public string GetName()
  {
    return name;
  }

  public int GetEmployeeID()
  {
    return employeeID;
  }

  public double GetSalary()
  {
    return salary;
  }

  public Employee GetNext()
  {
    return next;
  }

  public void SetNext(Employee employee)
  {
    next = employee;
  }

  public void CargoValues()
  {
    Console.WriteLine("Name: " + name + "\nID number: " + employeeID + "\nSalary: $" + salary);
 }
}