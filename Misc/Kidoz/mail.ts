myFunction();
myF2();

function yearsSince(startDate: Date, endDate: Date): number {
    const millisecondsPerYear = 365 * 24 * 60 * 60 * 1000;
    return ( endDate.getTime() - startDate.getTime() ) / millisecondsPerYear;
}

function myFunction() {
  var d1 = new Date(1995, 11, 17)
  var d2 = new Date();
  var n = yearsSince(d1, d2);
  console.log(n);

}

function myF2()
{
  var d1 = new Date(1995, 11, 17);
    var d2 = new Date();

    var start = new Date();    
    var n = yearsSince(d1, d2);
    var end = new Date();

    var time1 = end.getMilliseconds() - start.getMilliseconds();
    console.log(time1);
    console.log(n);

    start = new Date();
    n = d2.getFullYear() - d1.getFullYear();
    end = new Date();
    var time2 = end.getMilliseconds() - start.getMilliseconds();
    console.log(time2);
    console.log(n);
}