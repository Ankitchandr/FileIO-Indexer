using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexersDemo
{
    class TestEmployeeInfo
    {
        static void Main(string[] args)
        {
            GetSetValue call = new GetSetValue();
            call.Get();
            call.Set();
            Console.WriteLine("================");
            call.Get();
            Testing();
            Console.ReadLine();
        }

        internal static void Testing()
        {
            log4net.Config.BasicConfigurator.Configure();
            log4net.ILog log = log4net.LogManager.GetLogger(typeof(TestEmployeeInfo));
            try
            {
                log.Info("This program creating for indexers using");
                log.Info("Employee Informations getting through index");

                log.Debug("This is a Debug message");

                log.Info("This is a Info message");

                log.Warn("This is a Warning message");

                log.Error("This is an Error message");

                log.Fatal("This is a Fatal message");

                // string str = String.Empty;
                // string subStr = str.Substring(0, 4); //this line will create error as the string "str" is empty.  
            }
            catch (Exception ex)
            {
                log.Error("Error Message: " + ex.Message.ToString(), ex);
            }
        }

        public class Employee
        {
            int Eid;
            double Salary;
            string Ename, Job, Dname, Location;

            public Employee(int Eid, String Ename, String Job, String Dname, String Location, double Salary)
            {
                this.Eid = Eid;
                this.Ename = Ename;
                this.Job = Job;
                this.Dname = Dname;
                this.Location = Location;
                this.Salary = Salary;

            }


            public object this[int index]
            {
                get
                {
                    if (index == 1)
                        return Eid;
                    else if (index == 2)
                        return Ename;
                    else if (index == 3)
                        return Job;
                    else if (index == 4)
                        return Dname;
                    else if (index == 5)
                        return Location;
                    else if (index == 6)
                        return Salary;
                    return null;
                }
                set
                {
                    if (index == 1)
                        Eid = (int)value;
                    else if (index == 2)
                        Ename = (string)value;
                    else if (index == 3)
                        Job = (string)value;
                    else if (index == 4)
                        Dname = (string)value;
                    else if (index == 5)
                        Location = (string)value;
                    else if (index == 6)
                        Salary = (double)value;

                }
            }


            public class GetSetValue
            {

                Employee Emp = new Employee(102, "Ankit chandra", "Manager", "IT", "Banglore", 20000.00);

                public void Get()
                {
                    Console.WriteLine("Eid = " + Emp[1]);
                    Console.WriteLine("Ename = " + Emp[2]);
                    Console.WriteLine("Job = " + Emp[3]);
                    Console.WriteLine("Dname = " + Emp[4]);
                    Console.WriteLine("Location= " + Emp[5]);
                    Console.WriteLine("Salary= " + Emp[6]);
                }

                public void Set()
                {
                    Emp[1] = 132;
                    Emp[2] = "Mr. sanjay Kumar";
                    Emp[6] = 490000.00;

                }

            }

        }


    }

}

