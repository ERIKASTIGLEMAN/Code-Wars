public class Kata
{
  public static string SwitchItUp(int number)
  {
   var answer = "";
    
   switch (number)       
    {case 0:
      answer = "Zero";
      break;
     case 1:
      answer = "One";
      break;
     case 2:
      answer = "Two";
      break;
    case 3:
      answer = "Three";
      break;
    case 4:
      answer = "Four";
      break;
    case 5:
      answer = "Five";
      break;
    case 6:
      answer = "Six";
      break;
    case 7:
      answer = "Seven";
      break;
    case 8:
      answer = "Eight";
      break;
    case 9:
      answer = "Nine";
      break;
       } 
    return answer;
    }
 
  }
 
ROCK PAPER SCISSORS


public class Kata
{
  public string Rps(string p1, string p2)
  {
   if (p1 == p2)
     {return("Draw!");}
    if (p1 == "rock" && p2 == "paper")
      {return("Player 2 won!");}
    if (p1 == "paper" && p2 == "rock")
      {return("Player 1 won!");}
    if (p1 == "scissors" && p2 =="paper")
      {return("Player 1 won!");}
    if (p1 == "paper" && p2 == "scissors")
      {return("Player 2 won!");}
    if (p1 == "scissors" && p2 =="rock")
      {return("Player 2 won!");}
    
    return("Player 1 won!");
    
  }
