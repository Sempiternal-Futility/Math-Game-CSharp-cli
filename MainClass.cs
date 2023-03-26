using System;

class MainClass : ExtraMethods
{
 
   //TODO:FIX BEING ABLE TO BACKSPACE TO ERASE


   public static bool plusEquation = false;
   public static string numberString;

   public static int numberOne;
   public static int numberTwo;
 
   static void Main()
   {

	Console.ForegroundColor = ConsoleColor.Cyan;
	Console.BackgroundColor = ConsoleColor.Black;
	Console.Clear();
	

	//GENERATES THE FIRST NUMBER
	numberString = RandomStuff.GenerateRandomNumber();

	try
	{

	  DrawNumberASCII( numberString[0], 0, 0 ); 
	  DrawNumberASCII( numberString[1], 10, -5 ); 
	  DrawNumberASCII( numberString[2], 20, -5 ); 
	  DrawNumberASCII( numberString[3], 29, -5 ); 
	  DrawNumberASCII( numberString[4], 39, -5 );

	} catch( IndexOutOfRangeException ) {}

        numberOne = Int32.Parse( numberString );



        //GENERATES THE OPERATOR
	if ( RandomStuff.PlusOrMinus() == '+' ) { ASCII.Plus( 69, -5 ); plusEquation = true; }
	else { ASCII.Minus( 71, -5 ); plusEquation = false; }



        //GENERATES THE SECOND NUMBER
        numberString = RandomStuff.GenerateRandomNumber();

        try
	{

          DrawNumberASCII( numberString[0], 100, -5 ); 
	  DrawNumberASCII( numberString[1], 110, -5 ); 
	  DrawNumberASCII( numberString[2], 120, -5 ); 
	  DrawNumberASCII( numberString[3], 130, -5 ); 
	  DrawNumberASCII( numberString[4], 140, -5 );

	} catch( IndexOutOfRangeException ) {}

	numberTwo = Int32.Parse( numberString );


        ASCII.Equals( 69, 8 );
	AssesingResult();

   }
}
