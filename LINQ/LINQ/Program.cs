//SPECIFY THE DATA SOURCE 

int[] numbers= new int[] { 2,5,7,8,10,12};

//DEFINE THE QUERY EXPRESSION

var result = numbers.Where(x => x % 2 == 0).Select(x => x * 10);

// execute query

foreach (var number in result)
{
    Console.WriteLine(number);
}