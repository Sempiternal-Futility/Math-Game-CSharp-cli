using System;

//THE REASON WHY I DIDN'T USE A STRING LITERAL, AND DID ALL THIS MESS INSTEAD, IS BECAUSE  "Console.SetCursorPosition()" DOESN'T WORK WITH LITERALS
class ASCII
{

   public static void Zero( short posXSum, short posYSum )
   {

	int posX = Console.CursorLeft + posXSum;
	int posY = Console.CursorTop + posYSum;

	
	Console.CursorLeft = posX;
	Console.CursorTop = posY;
	Console.WriteLine(" ██████  ");

   	Console.CursorLeft = posX;
	Console.CursorTop = posY + 1;
	Console.WriteLine("██  ████ ");

	Console.CursorLeft = posX;
	Console.CursorTop = posY + 2;
	Console.WriteLine("██ ██ ██ ");

	Console.CursorLeft = posX;
	Console.CursorTop = posY + 3;
	Console.WriteLine("████  ██ ");

	Console.CursorLeft = posX;
	Console.CursorTop = posY + 4;
	Console.WriteLine(" ██████  ");


   }

   public static void One( short posXSum, short posYSum )
   {

	int posX = Console.CursorLeft + posXSum;
	int posY = Console.CursorTop + posYSum;

	
	Console.CursorLeft = posX + 1;
	Console.CursorTop = posY;
	Console.WriteLine(" ██ ");

	Console.CursorLeft = posX + 1;
	Console.CursorTop = posY + 1;
	Console.WriteLine("███ ");

	Console.CursorLeft = posX + 1;
	Console.CursorTop = posY + 2;
	Console.WriteLine(" ██ ");

	Console.CursorLeft = posX + 1;
	Console.CursorTop = posY + 3;
	Console.WriteLine(" ██ ");

	Console.CursorLeft = posX + 1;
	Console.CursorTop = posY + 4;
	Console.WriteLine(" ██ ");



   }

   public static void Two( short posXSum, short posYSum )
   {
 

	int posX = Console.CursorLeft + posXSum;
	int posY = Console.CursorTop + posYSum;


        Console.CursorLeft = posX;
	Console.CursorTop = posY;
	Console.WriteLine("██████  ");

        Console.CursorLeft = posX;
	Console.CursorTop = posY + 1;
	Console.WriteLine("     ██ ");

        Console.CursorLeft = posX;
	Console.CursorTop = posY + 2;
	Console.WriteLine(" █████  ");

        Console.CursorLeft = posX;
	Console.CursorTop = posY+ 3;
	Console.WriteLine("██      ");

        Console.CursorLeft = posX;
	Console.CursorTop = posY + 4;
	Console.WriteLine("███████ ");


   }

   public static void Three( short posXSum, short posYSum )
   {
 
	int posX = Console.CursorLeft + posXSum;
	int posY = Console.CursorTop + posYSum;

	
	Console.CursorLeft = posX;
	Console.CursorTop = posY;
	Console.WriteLine("██████  ");

  	Console.CursorLeft = posX;
	Console.CursorTop = posY + 1;
	Console.WriteLine("     ██ ");

	Console.CursorLeft = posX;
	Console.CursorTop = posY + 2;
	Console.WriteLine(" █████  ");

	Console.CursorLeft = posX;
	Console.CursorTop = posY + 3;
	Console.WriteLine("     ██ ");

	Console.CursorLeft = posX;
	Console.CursorTop = posY + 4;
	Console.WriteLine("██████  ");


   }

   public static void Four( short posXSum, short posYSum )
   {
  
	int posX = Console.CursorLeft + posXSum;
	int posY = Console.CursorTop + posYSum;


	Console.CursorLeft = posX;
	Console.CursorTop = posY;
	Console.WriteLine("██   ██ ");

  	Console.CursorLeft = posX;
	Console.CursorTop = posY + 1;
	Console.WriteLine("██   ██ ");

	Console.CursorLeft = posX;
	Console.CursorTop = posY + 2;
	Console.WriteLine("███████ ");

	Console.CursorLeft = posX;
	Console.CursorTop = posY + 3;
	Console.WriteLine("     ██ ");

	Console.CursorLeft = posX;
	Console.CursorTop = posY + 4;
	Console.WriteLine("     ██ ");

   }

   public static void Five( short posXSum, short posYSum )
   {

 	int posX = Console.CursorLeft + posXSum;
	int posY = Console.CursorTop + posYSum;


	Console.CursorLeft = posX;
	Console.CursorTop = posY;
	Console.WriteLine("███████ ");

  	Console.CursorLeft = posX;
	Console.CursorTop = posY + 1;
	Console.WriteLine("██      ");

	Console.CursorLeft = posX;
	Console.CursorTop = posY + 2;
	Console.WriteLine("███████ ");

	Console.CursorLeft = posX;
	Console.CursorTop = posY + 3;
	Console.WriteLine("     ██ ");

	Console.CursorLeft = posX;
	Console.CursorTop = posY + 4;
	Console.WriteLine("███████ ");

   }

   public static void Six( short posXSum, short posYSum )
   {

  	int posX = Console.CursorLeft + posXSum;
	int posY = Console.CursorTop + posYSum;


	Console.CursorLeft = posX;
	Console.CursorTop = posY;
	Console.WriteLine(" ██████  ");

  	Console.CursorLeft = posX;
	Console.CursorTop = posY + 1;
	Console.WriteLine("██       ");

	Console.CursorLeft = posX;
	Console.CursorTop = posY + 2;
	Console.WriteLine("███████  ");

	Console.CursorLeft = posX;
	Console.CursorTop = posY + 3;
	Console.WriteLine("██    ██ ");

	Console.CursorLeft = posX;
	Console.CursorTop = posY + 4;
	Console.WriteLine(" ██████  ");

   }

   public static void Seven( short posXSum, short posYSum )
   {

   	int posX = Console.CursorLeft + posXSum;
	int posY = Console.CursorTop + posYSum;

	Console.CursorLeft = posX;
	Console.CursorTop = posY;
	Console.WriteLine("███████ ");

 	Console.CursorLeft = posX;
	Console.CursorTop = posY + 1;
	Console.WriteLine("     ██ ");

 	Console.CursorLeft = posX;
	Console.CursorTop = posY + 2;
	Console.WriteLine("    ██  ");

	Console.CursorLeft = posX;
	Console.CursorTop = posY + 3;
	Console.WriteLine("   ██   ");

	Console.CursorLeft = posX;
	Console.CursorTop = posY + 4;
	Console.WriteLine("   ██   ");

   }

   public static void Eight( short posXSum, short posYSum )
   {

    	int posX = Console.CursorLeft + posXSum;
	int posY = Console.CursorTop + posYSum;


	Console.CursorLeft = posX;
	Console.CursorTop = posY;
	Console.WriteLine(" █████  ");

  	Console.CursorLeft = posX;
	Console.CursorTop = posY + 1;
	Console.WriteLine("██   ██ ");

	Console.CursorLeft = posX;
	Console.CursorTop = posY + 2;
	Console.WriteLine(" █████  ");

	Console.CursorLeft = posX;
	Console.CursorTop = posY + 3;
	Console.WriteLine("██   ██ ");

	Console.CursorLeft = posX;
	Console.CursorTop = posY + 4;
	Console.WriteLine(" █████  ");

   }

   public static void Nine( short posXSum, short posYSum )
   {

     	int posX = Console.CursorLeft + posXSum;
	int posY = Console.CursorTop + posYSum;

	
	Console.CursorLeft = posX;
	Console.CursorTop = posY;
	Console.WriteLine(" █████  ");

  	Console.CursorLeft = posX;
	Console.CursorTop = posY + 1;
	Console.WriteLine("██   ██ ");

	Console.CursorLeft = posX;
	Console.CursorTop = posY + 2;
	Console.WriteLine(" ██████ ");

	Console.CursorLeft = posX;
	Console.CursorTop = posY + 3;
	Console.WriteLine("     ██ ");

	Console.CursorLeft = posX;
	Console.CursorTop = posY + 4;
	Console.WriteLine(" █████  ");

   }

   public static void Plus( short posXSum, short posYSum )
   {

      	int posX = Console.CursorLeft + posXSum;
	int posY = Console.CursorTop + posYSum;


	Console.CursorLeft = posX;
	Console.CursorTop = posY;
	Console.WriteLine("    ██    ");

  	Console.CursorLeft = posX;
	Console.CursorTop = posY + 1;
	Console.WriteLine("    ██    ");

	Console.CursorLeft = posX;
	Console.CursorTop = posY + 2;
	Console.WriteLine("██████████");

	Console.CursorLeft = posX;
	Console.CursorTop = posY + 3;
	Console.WriteLine("    ██    ");

	Console.CursorLeft = posX;
	Console.CursorTop = posY + 4;
	Console.WriteLine("    ██    ");

   }


   public static void Minus( short posXSum, short posYSum )
   {

       	int posX = Console.CursorLeft + posXSum;
	int posY = Console.CursorTop + posYSum;


	Console.CursorLeft = posX;
	Console.CursorTop = posY;
	Console.WriteLine("");

  	Console.CursorLeft = posX;
	Console.CursorTop = posY + 1;
	Console.WriteLine("");

	Console.CursorLeft = posX;
	Console.CursorTop = posY + 2;
	Console.WriteLine("█████");

	Console.CursorLeft = posX;
	Console.CursorTop = posY + 3;
	Console.WriteLine("");

	Console.CursorLeft = posX;
	Console.CursorTop = posY + 4;
	Console.WriteLine("");

   }

   public static void Equals( short posXSum, short posYSum )
   {
  
        int posX = Console.CursorLeft + posXSum;
	int posY = Console.CursorTop + posYSum;

 
	Console.CursorLeft = posX;
	Console.CursorTop = posY;
	Console.WriteLine("███   ███");

 	Console.CursorLeft = posX;
	Console.CursorTop = posY + 1;
	Console.WriteLine("███   ███");

 	Console.CursorLeft = posX;
	Console.CursorTop = posY + 2;
	Console.WriteLine("███   ███");

 	Console.CursorLeft = posX;
	Console.CursorTop = posY + 3;
	Console.WriteLine("███   ███");

 	Console.CursorLeft = posX;
	Console.CursorTop = posY + 4;
	Console.WriteLine("███   ███");

   }

}
