using System;
using System.Collections.Generic;
using System.Text;

namespace Kidoz
{
    class EmployeeData      //New class to temporarily store all the information together
    {
        internal string id { get; set; }
        internal string name { get; set; }
        internal DateTime startDate { get; set; }
        internal DateTime endDate { get; set; }
        internal string email { get; set; }
        internal double vacationDays { get; set; }
    }
    class BonusVacation
    {
        public void grantVacation(EmailAPI emailAPI, Payroll[] payroll, AddressBook[] addresses, Employee[] employees)
        {
            Dictionary<string, EmployeeData> map = new Dictionary<string, EmployeeData>();

            ReadPayroll(map, payroll);
            ReadAddresses(map, addresses);
            ReadEmployees(map, employees);

            sendEmails(emailAPI, map);
        }

        private void sendEmails(EmailAPI emailApi, Dictionary<string, EmployeeData> map)
        {
            DateTime today = DateTime.Now;

            foreach(string key in map.Keys)
            {
                if (map[key].endDate != DateTime.MinValue) continue; //Skip any employee who has left the company

                double yearsEmployed = yearsSince(map[key].startDate, today);
                double vacationBalance = map[key].vacationDays + yearsEmployed;

                string subject = string.Format("Dear {0} \n " +
                    "Based on your {1:0} years of employment, you have been granted {2:0} days of vacation, bringing your total to {3:0}", 
                    map[key].name, yearsEmployed, yearsEmployed, vacationBalance);

                emailApi.sendEmail(map[key].email, "Good News!", subject);
            }
        }

        private double yearsSince(DateTime start, DateTime end)
        {
            const double millisecondsPerYear = 365.0 * 24 * 60 * 60 * 1000;
            return (end - start).TotalMilliseconds / millisecondsPerYear;
        }

        private void ReadPayroll(Dictionary<string, EmployeeData> map, Payroll[] payroll)
        {
            foreach(Payroll item in payroll)
            {
                EmployeeData obj = new EmployeeData();
                obj.id = item.emp_id;
                obj.vacationDays = item.vacationDays;

                map[item.emp_id] = obj;
            }
        }

        private void ReadAddresses(Dictionary<string, EmployeeData> map, AddressBook[] addresses)
        {
            foreach (AddressBook item in addresses)
            {
                if (!map.ContainsKey(item.emp_id)) continue;

                EmployeeData obj = map[item.emp_id];
                obj.email = item.email;
                map[item.emp_id] = obj;
            }
        }

        private void ReadEmployees(Dictionary<string, EmployeeData> map, Employee[] employees)
        {
            foreach (Employee item in employees)
            {
                if (!map.ContainsKey(item.id)) continue;

                EmployeeData obj = map[item.id];
                obj.name = item.name;
                obj.startDate = item.startDate;
                obj.endDate = item.endDate;

                map[item.id] = obj;
            }
        }
    }

    class AddressBook
    {
        internal string emp_id { get; set; }
        internal string first { get; set; }
        internal string last { get; set; }
        internal string email { get; set; }

    }

    class Employee
    {
        internal string id { get; set; }
        internal string name { get; set; }
        internal DateTime startDate { get; set; }
        internal DateTime endDate { get; set; }

    }

    class Payroll
    {
        internal string emp_id { get; set; }
        internal double vacationDays { get; set; }

    }

    class EmailAPI
    {
        public void sendEmail(string email, string subject, string body) { }
    }
}
