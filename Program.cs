using System;

namespace JavaValidationCode
{
    class Program
    {
        static void Main(string[] args)
        {

			< !DOCTYPE html >
 < html >
 < body >
 


 < h1 > Customer Information </ h1 >
	< form action = "/action_page.php" >
	 
		 < label for= "fname" > First name:</ label >
	  
		  < input type = "text" id = "fname" name = "fname" >< br >< br >
	  
		  < label for= "lname" > Last name:</ label >
	   
		   < input type = "text" id = "lname" name = "lname" >< br >< br >
	   
		   < label for= "email" > E - mail:</ label >
		
			< input type = "text" id = "email" name = "email" >< br >< br >
		

		< button type = "button" > Submit </ button >
		



		</ form >
		

		< script >

		function validateForm() {
						var x = document.forms["myForm']["email"].value;
			if (x == "")
						{
							alert("E-Mail must be filled out.");
							return false;
						}
					}
		}
    }
}
