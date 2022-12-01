string[] lines = File.ReadAllLines("input.txt");

var topElf = 0;
var nextElf = 0;

foreach (string line in lines)
{
    if(line != "")
    {
        nextElf += Int32.Parse(line);
    }
    else
    {
        if(nextElf > topElf)
        {
            topElf = nextElf;   
        }
        nextElf = 0;
    }
}

Console.WriteLine("part 1: " + topElf);


topElf = 0;
nextElf = 0;
var secondElf = 0;
var thirdElf = 0;
var temp = 0;
foreach (string line in lines)
{
    if (line != "")
    {
        nextElf += Int32.Parse(line);
    }
    else
    {
        if (nextElf > topElf)
        {
            temp = topElf;
            topElf = nextElf;
            nextElf = secondElf;
            secondElf = temp;
            thirdElf = nextElf;
        }
        else if(nextElf > secondElf)
        { 
            thirdElf = secondElf;
            secondElf = nextElf;
        }
        else if(nextElf > thirdElf)
        {
            thirdElf = nextElf;
        }
        temp = 0;
        nextElf = 0;
    }
}
temp = topElf + secondElf + thirdElf;
Console.WriteLine("part 2: " + temp);