
List<int> integerList = new List<int>()
{
    1,2,3,4,5,6,7,8,9,10
};

// query syntax
var numberBiggerThanFive = from number in integerList
                           where number > 5
                           select number;
foreach (var number in numberBiggerThanFive)
{
    Console.WriteLine(number);
}

// method syntax
var evenNumber = integerList.Where(n => n % 2 == 0).ToList();

foreach (var number in evenNumber)
{
    Console.WriteLine(number);
}

// mixed syntax
var sumofOddNumbers = (from number in integerList
                       where number % 2 != 0
                       select number).Sum();
Console.WriteLine(sumofOddNumbers);