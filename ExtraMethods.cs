using System;

class ExtraMethods
{	   
	
   public static void DrawNumberASCII( char number, short posXSum, short posYSum )
   {

           if ( number == '0' ) { ASCII.Zero( posXSum, posYSum ); }
	   else if ( number == '1' ) { ASCII.One( posXSum, posYSum ); }
	   else if ( number == '2' ) { ASCII.Two( posXSum, posYSum ); }
	   else if ( number == '3' ) { ASCII.Three( posXSum, posYSum ); }
	   else if ( number == '4' ) { ASCII.Four( posXSum, posYSum ); }
	   else if ( number == '5' ) { ASCII.Five( posXSum, posYSum ); }
	   else if ( number == '6' ) { ASCII.Six( posXSum, posYSum ); }
	   else if ( number == '7' ) { ASCII.Seven( posXSum, posYSum ); }
	   else if ( number == '8' ) { ASCII.Eight( posXSum, posYSum ); }
	   else if ( number == '9' ) { ASCII.Nine( posXSum, posYSum ); }
	   else if ( number == '-' ) { ASCII.Minus( posXSum, posYSum ); }

   }

   public static string DrawingPlayerInputToScreen()
   {
 
       short posXSum = 53;
       bool breakLoop = false;

       string input = "";
       
       //THIS STRING IS USED TO KNOW WHICH KEY WAS THE LAST PRESSED ( TO ERASE IT )
       string lastKeyPressed = "";

       while( breakLoop == false )
       {
         
           var readInput = Console.ReadKey(true).Key;
	   bool inputLengthIsZero = false;

	   switch( readInput )
	   {

	      case ConsoleKey.D1 : Console.SetCursorPosition( posXSum, 20 ); ASCII.One( 0, 0 ); input += "1"; lastKeyPressed = "One";
	      break;

	      case ConsoleKey.D2 : Console.SetCursorPosition( posXSum, 20 ); ASCII.Two( 0, 0 ); input += "2"; lastKeyPressed = "Two";
              break;

	      case ConsoleKey.D3 : Console.SetCursorPosition( posXSum, 20 ); ASCII.Three( 0, 0 ); input += "3"; lastKeyPressed = "Three";
	      break;

	      case ConsoleKey.D4 : Console.SetCursorPosition( posXSum, 20 ); ASCII.Four( 0, 0 ); input += "4"; lastKeyPressed = "Four";
	      break;

	      case ConsoleKey.D5 : Console.SetCursorPosition( posXSum, 20 ); ASCII.Five( 0, 0 ); input += "5"; lastKeyPressed = "Five";
	      break;

	      case ConsoleKey.D6 : Console.SetCursorPosition( posXSum, 20 ); ASCII.Six( 0, 0 ); input += "6"; lastKeyPressed = "Six";
	      break;

              case ConsoleKey.D7 : Console.SetCursorPosition( posXSum, 20 ); ASCII.Seven( 0, 0 ); input += "7"; lastKeyPressed = "Seven";
	      break;

              case ConsoleKey.D8 : Console.SetCursorPosition( posXSum, 20 ); ASCII.Eight( 0, 0 ); input += "8"; lastKeyPressed = "Eight";
	      break;

	      case ConsoleKey.D9 : Console.SetCursorPosition( posXSum, 20 ); ASCII.Nine( 0, 0 ); input += "9"; lastKeyPressed = "Nine";
	      break;

	      case ConsoleKey.D0 : Console.SetCursorPosition( posXSum, 20 ); ASCII.Zero( 0, 0 ); input += "0"; lastKeyPressed = "Zero";
	      break;
 
	      case ConsoleKey.Subtract : Console.SetCursorPosition( posXSum, 20 ); ASCII.Minus( 0, 0 ); input += "-"; lastKeyPressed = "Minus";
	      break;				 


              case ConsoleKey.Backspace : if( input.Length != 0 ) 
					  { 

					    Console.ForegroundColor = ConsoleColor.Black; 
					    Console.SetCursorPosition( posXSum - 10, 0 );
					    int length = input.Length;


					    if ( lastKeyPressed == "One" ) { ASCII.One( 0, 20 ); input = input.Remove( length-1, 1 );  }
					    else if ( lastKeyPressed == "Two" ) { ASCII.Two( 0, 20 ); input = input.Remove( length-1, 1); }
					    else if ( lastKeyPressed == "Three" ) { ASCII.Three( 0, 20 );  input = input.Remove( length-1, 1); }
					    else if ( lastKeyPressed == "Four" ) { ASCII.Four( 0, 20 );  input = input.Remove( length-1, 1); }
					    else if ( lastKeyPressed == "Five" ) { ASCII.Five( 0, 20 );  input = input.Remove( length-1, 1); }
					    else if ( lastKeyPressed == "Six" ) { ASCII.Six( 0, 20 );  input = input.Remove( length-1, 1); }
					    else if ( lastKeyPressed == "Seven" ) { ASCII.Seven( 0, 20 );  input = input.Remove( length-1, 1); }
					    else if ( lastKeyPressed == "Eight" ) { ASCII.Eight( 0, 20 );  input = input.Remove( length-1, 1); }
					    else if ( lastKeyPressed == "Nine" ) { ASCII.Nine( 0, 20 );  input = input.Remove( length-1, 1); }
					    else if ( lastKeyPressed == "Zero" ) { ASCII.Zero( 0, 20 );  input = input.Remove( length-1, 1); }
					    else if ( lastKeyPressed == "Minus" ) { ASCII.Minus( 0, 20 );  input = input.Remove( length-1, 1); }


					    Console.ForegroundColor = ConsoleColor.Cyan;
					    posXSum -= 20; 
					  
					  } 

					  else { inputLengthIsZero = true; } 
	      break;

	      case ConsoleKey.Enter : breakLoop = true; 
	      break;


	   }

           if( posXSum < 113 && inputLengthIsZero == false ) { posXSum += 10; }

       }

       return input;       

   }

   public static void AssesingResult()
   {
	   
   	int result;

	if ( MainClass.plusEquation == true ) 
	{ result = MainClass.numberOne + MainClass.numberTwo; }

	else 
	{ result = MainClass.numberOne - MainClass.numberTwo; }
	

	if( result == Int32.Parse( DrawingPlayerInputToScreen() ) )
	{
	     Console.ForegroundColor = ConsoleColor.Green;
	     Console.WriteLine("CORRECT!");
	}
	
	else 
	{ 
           Console.ForegroundColor = ConsoleColor.Red;
           Console.WriteLine("WRONG!"); 
	}
	
   }
}
