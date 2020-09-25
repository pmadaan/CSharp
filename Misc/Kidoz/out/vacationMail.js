"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
function yearsSince(startDate, endDate) {
    var millisecondsPerYear = 365 * 24 * 60 * 60 * 1000;
    return (endDate.getTime() - startDate.getTime()) / millisecondsPerYear;
}
/**
 * We haved decided to grant bonus vacation to every employee, 1 day per year of experience
 * we need to email them a notice.
 */
function grantVacation(emailApi, payroll, addresses, employees) {
    var _loop_1 = function () {
        var payrollInfo = payroll[index];
        var addressInfo = addresses.find(function (x) { return x.emp_id == payrollInfo.emp_id; });
        var empInfo = employees.find(function (x) { return x.id == payrollInfo.emp_id; });
        var today = new Date();
        var yearsEmployed = yearsSince(empInfo.endDate, today);
        var newVacationBalance = yearsEmployed + payrollInfo.vacationDays;
        emailApi.sendEmail(addressInfo.email, "Good news!", "Dear " + empInfo.name + "\n" +
            ("based on your " + yearsEmployed + " years of employment, you have been granted " + yearsEmployed + " days of vacation, bringing your total to " + newVacationBalance));
    };
    for (var index in payroll) {
        _loop_1();
    }
}
//# sourceMappingURL=vacationMail.js.map