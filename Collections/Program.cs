

//Generic Collection
//1.	შექმენით პროგრამა, რომელიც ახდენს წიგნის მაღაზიის სიმულაციას: შეინახეთ წიგნების სათაურები და ფასები Dictionary<string, double>. 
//2.	გამოიყენეთ Queue<string> სატელეფონო ცენტრის მოლოდინის ხაზის სიმულაციისთვის. 
//3.	დაწერეთ პროგრამა Stack<char>-ის გამოყენებით, რომელიც ამოწმებს არის თუ არა სიტყვა პალინდრომი. 
//4.	შექმენით List<int> 10 შემთხვევითი რიცხვისგან და წაშალეთ ყველა ლუწი რიცხვი.





Dictionary<string, double> MyDictionary = new Dictionary<string, double>();

MyDictionary.Add("Spiderman", 15);
MyDictionary.Add("Pinocchio", 14);
MyDictionary.Add("Snow White", 19);
MyDictionary.Add("Marvel", 19);
MyDictionary.Add("Harry Potter", 14);

foreach (var item in MyDictionary)
{
    Console.WriteLine(item);
}






Queue<string> q = new Queue<string>();

q.Enqueue("N1");
q.Enqueue("N2");
q.Enqueue("N3");
q.Enqueue("N4");
q.Enqueue("N5");

foreach (var item in q)
{
    Console.WriteLine(item);
}







List<int> ints = new List<int>();

ints.Add(1);
ints.Add(2);
ints.Add(3);
ints.Add(4);
ints.Add(5);
ints.Add(6);
ints.Add(7);
ints.Add(8);
ints.Add(9);
ints.Add(10);

for (int i = 0; i < ints.Count; i++)
{
    if (ints[i] % 2 == 0)
    {
        ints.Clear();
        break;
    }
}

Console.WriteLine(ints);