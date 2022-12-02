string[] lines = File.ReadAllLines("input.txt");

// a = rock, b = paper, c = scissor
// x = rock, y = paper, z = scissor
var score = 0;
foreach(string line in lines)
{
    var plays = line.Split(" ");
    if (plays[0] == "A")
    {
        if (plays[1] == "X")
        {
            score += 3 + 1;
        }
        else if(plays[1] == "Y")
        {
            score += 6 + 2;
        }
        else 
        {
            score += 0 + 3;
        }
    }
    if(plays[0] == "B")
    {
        if (plays[1] == "X")
        {
            score += 0 + 1;
        }
        else if (plays[1] == "Y")
        {
            score += 3 + 2;
        }
        else
        {
            score += 6 + 3;
        }
    }
    if (plays[0] == "C")
    {
        if (plays[1] == "X")
        {
            score += 6 + 1;
        }
        else if (plays[1] == "Y")
        {
            score += 0 + 2;
        }
        else
        {
            score += 3 + 3;
        }
    }
}

Console.WriteLine("part 1: " + score);


// a = rock, b = paper, c = scissor
// x = lose, y = draw, z = win

score = 0;
foreach (string line in lines)
{
    var plays = line.Split(" ");
    if (plays[0] == "A")
    {
        //rock
        if (plays[1] == "X")
        {
            //scissor
            score += 0 + 3;
        }
        else if (plays[1] == "Y")
        {
            //rock
            score += 3 + 1;
        }
        else
        {
            //paper
            score += 6 + 2;  
        }
    }
    if (plays[0] == "B")
    {
        //paper
        if (plays[1] == "X")
        {
            //rock
            score += 0 + 1;
        }
        else if (plays[1] == "Y")
        {
            //paper
            score += 3 + 2;
        }
        else
        {
            //scissor
            score += 6 + 3;  
        }
    }
    if (plays[0] == "C")
    {
        //scissor
        if (plays[1] == "X")
        {
            //paper
            score += 0 + 2;
        }
        else if (plays[1] == "Y")
        {
            //scissor
            score += 3 + 3;
        }
        else
        {
            //rock
            score += 6 + 1;
        }
    }
}

Console.WriteLine("part 2: " + score);