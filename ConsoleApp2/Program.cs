
//yousef alkhdoor

Console.WriteLine(" select regular or silver or gold ");
string j = Console.ReadLine();
Console.WriteLine(" enter the invoice amount ");
int i = Convert.ToInt32(Console.ReadLine());

if (i > 100)
{
    if (j == "gold")
    {

        Console.WriteLine($" invoice value after diccount {  i *.75 } and discounted amount in dinars is = {i * .25}");
    }
    else if (j == "silver")
    {
        Console.WriteLine($" invoice value after diccount {  i *.83 } and discounted amount in dinars is = {i * .17}");
    }
    else if (j == "regular")
    {
        Console.WriteLine($" invoice value after diccount {  i *.93 } and discounted amount in dinars is = {i * .07}");
    }
    else
        Console.WriteLine("Unidentified client type");

}


if (i <= 100)
{
    if (j == "gold")
    {

        Console.WriteLine($" invoice value after diccount {i * .8} and discounted amount in dinars is = {i * .2}");

    }
    else if (j == "silver")
    {
        Console.WriteLine($" invoice value after diccount {i * .85} and discounted amount in dinars is = {i * .15}");

    }
    else if (j == "regular")
    {
        Console.WriteLine($" invoice value after diccount {i * .95} and discounted amount in dinars is = {i * .05}");
    }
    else
        Console.WriteLine("Unidentified client type");


}