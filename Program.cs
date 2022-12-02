#region xexesalom
// void SalomDunyo()
// {
//     Console.WriteLine("Assalomu alaikum hurmatli mehmonlar");
//     Console.WriteLine("tuzumisila??");
// }
// void SalomOzbekiston()
// {
//     Console.WriteLine("Assalomu alaikum Oz`bekiston");
//     Console.WriteLine("tuzumisila??");
// }
// void SalomIlmHub()
// {
//     Console.WriteLine("Assalomu alaikum IlmHub talabalari");
//     Console.WriteLine("tuzumisila??");
// }

// string salomlashishTurlari = Console.ReadLine();
// switch(salomlashishTurlari)
// {
//     case "Ozbekiston":
//         SalomOzbekiston();
//         break;
//     case "Dunyo":
//         SalomDunyo();
//         break;
//     case "IlmHub":
//         SalomIlmHub();
//         break;
//     default:
//         Console.WriteLine("Assalomu alaikum qadrli dostim");
//         break;

// }
#endregion

#region 
// void PrintRandomNumbers()
// {
//     Random random = new Random();
//     int number1 = random.Next(1, 10);
//     int number2 = random.Next(1, 100);
//     int number3 = random.Next(1, 1000);
//     Console.WriteLine($"{number1},{number2},{number3}");
// }

// PrintRandomNumbers();
#endregion

#region string conversation

// static void StringConversation()
// {
//     var testString = "xeXeSALOm";
//     var toLower = testString.ToLower();
//     System.Console.WriteLine(toLower);
//     System.Console.WriteLine(testString.ToUpper());
// }

// StringConversation();

#endregion

#region 
// void StringArray()
// {
//     string testString = "xexesalom";
//     for(int i = 0; i < testString.Length; i++)
//     {
//         System.Console.WriteLine(testString[i]);
//     }
// }
// StringArray();
#endregion

#region 
// void PrintNumber(int number)
// {
//     System.Console.WriteLine($"you entered: {number}");
// }

// Console.WriteLine("son kiriting");
// int a = Convert.ToInt32(Console.ReadLine());

// PrintNumber(a);
#endregion

#region 

// void Sum(int x, int y)
// {
//     var result = x + y;
//     System.Console.WriteLine($"{x} + {y} = {result}");
// }
// System.Console.WriteLine("iltimos 1 chi sonni kiriting!!");
// int a = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("iltimos 2 chi sonni kiriting!!");
// int b = Convert.ToInt32(Console.ReadLine());

// Sum(a, b);
#endregion

#region 

// void Summa(int x, int y) => Console.WriteLine($"{x} va {y} yigindisi {x+y} ga teng");

#endregion

#region 2 xil tipdagi ozgaruvchilarni kirituvchi funksiya

// void PrintUserInfo(string name , int age, bool isMarried = false)
// {
//     Console.WriteLine($"name: {name},  age: {age}, is married? {isMarried}");
// };

// PrintUserInfo("Abbos", 25, true);

#endregion

#region 

// void PrintPerson(string name, int age = 1, string company = "undefined")
// {
//     Console.WriteLine($"Name: {name}, Age: {age}, Company name:  {company}");
// };

// PrintPerson()
#endregion

#region 
// int Sum(int x, int y)
// {
//     return x + y;
// }
// int result = Sum(10,15);
// System.Console.WriteLine(result);
#endregion

#region boluvradi

// string Getmessage() => "hello world";

// var message = Getmessage() + 1 + "sawdaw";
// System.Console.WriteLine(message);
#endregion


#region method ichida method

// string GetMessage() => "hello world";

// void PrintMessage()
// {
//     System.Console.WriteLine();
// }
#endregion

#region ixtiyoriy tipdagi parametrlarni arrayga kiritish params 

// void Sum(params int[] numbers)
// {
//     int result = 0;
//     foreach(var n in numbers)
//     {
//         result += n;
//     }
//     System.Console.WriteLine(result);
// }

// int[] nums = {1, 2, 3, 4, 5 };
// Sum(nums);
// Sum(1,2,3,4);
// Sum(1,2,3);
// Sum();


#endregion

#region funksiya ichida funksiya

string GetMessage()
{
    return "xexesalom";
}

void PrintMessage(string message)
{
    Console.WriteLine(message);
}

PrintMessage(GetMessage());
#endregion



