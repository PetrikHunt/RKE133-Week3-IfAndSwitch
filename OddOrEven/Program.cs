
Console.Write("Enter a number: ");
int userNum = Convert.ToInt32(Console.ReadLine());

//kas kasutaja arv on paaris või paaritu

int result = userNum % 2;

if(result == 1)         //!= ei ole võrdne
{
    Console.WriteLine("Your number is odd");
}
else
{
    Console.WriteLine("Your number is even");
}

    

