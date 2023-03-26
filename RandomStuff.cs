using System;

class RandomStuff
{

   //GENERATES A RANDOM NUMBER, AND RETURNS IT AS A STRING
   public static string GenerateRandomNumber()
   {
       
        var random = new Random();
	short randomNumber = (short)random.Next( -9000, 9001 );
	return randomNumber.ToString();

   }

   //DECIDES IF THE OPERATION WILL BE OF ADDING OR SUBTRACTING
   public static char PlusOrMinus()
   {

        char sign = ' ';
	var random = new Random().Next( 0, 2 );

	if ( random == 0 ) { sign = '+'; }
	if ( random == 1 ) { sign = '-'; }


	return sign;
	
   }


}
