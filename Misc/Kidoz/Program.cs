using System;

namespace Kidoz
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            e1.id = "12";
            e1.name = "ab";
            e1.startDate = new DateTime(2012, 7, 30);
            e1.endDate = new DateTime(2019, 10, 11);

            Employee e2 = new Employee();
            e2.id = "123";
            e2.name = "abc";
            e2.startDate = new DateTime(2012, 7, 30);

            AddressBook a1 = new AddressBook();
            a1.emp_id = "12";
            a1.email = "ab@xyz.com";

            AddressBook a2 = new AddressBook();
            a2.emp_id = "123";
            a2.email = "abc@xyz.com";

            Payroll p1 = new Payroll();
            p1.emp_id = "12";
            p1.vacationDays = 0;

            Payroll p2 = new Payroll();
            p2.emp_id = "123";
            p2.vacationDays = 20;

            EmailAPI email = new EmailAPI();

            BonusVacation bv = new BonusVacation();
            bv.grantVacation(email, new Payroll[] { p1, p2 }, new AddressBook[] { a1, a2 }, new Employee[] { e2, e1 });
        }
    }
}
