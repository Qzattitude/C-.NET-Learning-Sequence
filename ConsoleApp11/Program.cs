using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;
using System.Reflection;
using System.Linq;

#region C. Train and Queries
class Program
{
    public static void Main()
    {
        int.TryParse(Console.ReadLine(), out int n);
        string[,] ans = new string[n,200000];

        for (int i = 0; i < n; i++)
        {
            Console.ReadLine();

            string Input = Console.ReadLine();
            string[] InputParser = Input.Split(" ");
            int.TryParse(InputParser[0], out int NumberOfStations);
            int.TryParse(InputParser[1], out int NumberOfPoints);

            //int.TryParse(Console.ReadLine(), out int NumberOfStations);

            //int[] Stations = new int[NumberOfStations];

            //int.TryParse(Console.ReadLine(), out int NumberOfPoints);

            int[] Points = new int[NumberOfStations];
            int[,] Nodes = new int[NumberOfPoints, 3];

            string s = Console.ReadLine();
            string[] Parser = s.Split(" ");
            for(int j = 0; j < NumberOfStations; j++)
            {
                int.TryParse(Parser[j], out Points[j]);
            }

            for(int j = 0; j < NumberOfPoints; j++)
            {
                string node = Console.ReadLine();
                string[] nodeParser = node.Split(" ");
                int.TryParse(nodeParser[0], out Nodes[j,0]);
                int.TryParse(nodeParser[1], out Nodes[j,1]);
            }
            int INDEX = 0;
            int DECISION1 = 0;
            for (int j = 0; j < NumberOfPoints; j++)
            {
                for(int k = 0; k < NumberOfStations; k++)
                {
                    if(Nodes[j,0] == Points[k])
                    {
                        INDEX = k;
                        DECISION1++;
                        break;
                    }
                }
                if (DECISION1!=0)
                {
                    int DECISION = 0;
                    if (INDEX < NumberOfStations)
                    {
                        for (int k = INDEX + 1; k < NumberOfStations; k++)
                        {
                            if (Nodes[j, 1] == Points[k])
                            {
                                ans[i, j] = "YES";
                                DECISION++;
                                break;
                            }
                        }

                    }
                    if (DECISION == 0)
                    {
                        ans[i, j] = "NO";
                    } 
                }
                else
                {
                    ans[i, j] = "NO";
                }
            }
            
        }
        for(int i = 0;i < n; i++)
        {
            for(int j = 0; ans[i,j]!=null; j++)
            {
                Console.WriteLine("{0}", ans[i,j]);
            }
        }
    }
}
#endregion

#region A. Benches
//class Program
//{
//    public static void Main()
//    {
//        int.TryParse(Console.ReadLine(), out int n);
//        int.TryParse(Console.ReadLine(), out int IncomingPeople);
//        int ansMin = 0;
//        int currentTota = 0;
//        int currentMax = 0;
//        int[] BenchPeople = new int[n];
//        for (int i = 0; i < n; i++)
//        {
//            int.TryParse(Console.ReadLine(), out BenchPeople[i]);
//            currentTota += BenchPeople[i];
//        }
//        currentMax = BenchPeople.Max();
//        if(((currentTota + IncomingPeople) % n) != 0 && (int)(currentTota + IncomingPeople) / n >= currentMax)
//        {
//            ansMin = ((int)(currentTota+IncomingPeople)/n)+1;
//        }
//        else if(((currentTota + IncomingPeople) % n) == 0 && (int)(currentTota + IncomingPeople) / n >= currentMax)
//        {
//            ansMin = (currentTota + IncomingPeople) / n;
//        }
//        else
//        {
//            ansMin = currentMax;
//        }

//        Console.WriteLine("{0} {1}", ansMin, IncomingPeople+currentMax);
//    }
//} 
#endregion

#region B. Polycarp Writes a String from Memory && A. YES or YES?
//class Program
//{
//    public static void Main()
//    {
//        int n = int.Parse(Console.ReadLine());
//        string[] ans = new string[n];
//        for (int i = 0; i < n; i++)
//        {
//            string s = Console.ReadLine().ToUpper();
//            if (s.Equals("YES"))
//            {
//                ans[i] = "YES";
//            }
//            else
//            {
//                ans[i] = "NO";
//            }
//        }
//        foreach(string s in ans)
//        {
//            Console.WriteLine(s);
//        }
//    }
//}
//class Program
//{
//    public static void Main()
//    {
//        int n = int.Parse(Console.ReadLine());
//        int[] ans = new int[n];
//        for(int i = 0; i < n; i++)
//        {
//            string s = Console.ReadLine();
//            int NullCount = (s.Length) % 3;
//            int MaxChar = 0;
//            int countSubLength = 3;
//            char[] MaxCharPerDay = new char[4];
//            for (int j = 0; j < s.Length; )
//            {
//                if (MaxCharPerDay[0] == '\0')
//                {
//                    MaxCharPerDay[0] = s[j];
//                    j++;
//                }
//                else if (MaxCharPerDay[0] == s[j])
//                {
//                    j++;
//                }
//                else if (MaxCharPerDay[1] == s[j])
//                {
//                    j++;
//                }
//                else if (MaxCharPerDay[2] == s[j])
//                {
//                    j++;
//                }
//                else if (MaxCharPerDay[1] == '\0')
//                {
//                    MaxCharPerDay[1] = s[j];
//                    j++;
//                }
//                else if (MaxCharPerDay[2] == '\0')
//                {
//                    MaxCharPerDay[2] = s[j];
//                    j++;
//                }
//                else
//                {
//                    ans[i] += 1;
//                    MaxCharPerDay[0] = '\0';
//                    MaxCharPerDay[1] = '\0';
//                    MaxCharPerDay[2] = '\0';
//                }
//            }
//            if (MaxCharPerDay[0]!='\0' || MaxCharPerDay[1] != '\0' || MaxCharPerDay[2] != '\0')
//            {
//                ans[i] += 1;
//            }

//        }
//        foreach(int i in ans)
//        {
//            Console.WriteLine(i);
//        }
//    }
//}
#endregion

#region A. Round The Bill

//class Program
//{
//    public static void Main()
//    {
//        int n = int.Parse(Console.ReadLine());
//        int[] ans = new int[n];
//        int[] PowOfTen = new int[10];
//        for (int i = 0; i < 10; i++)
//        {
//            int des = 10;
//            PowOfTen[i] = (int)Math.Pow(des, i);
//        }



//        for (int num = 0; num < n; num++)
//        {
//            int lowest = 1999999999;
//            int.TryParse(Console.ReadLine(), out int Number);
//            for (int i = 0; i < 10; i++)
//            {
//                if (Math.Abs(Number - PowOfTen[i]) <= lowest && PowOfTen[i] <= Number)
//                {
//                    lowest = (int)Math.Abs(Number - PowOfTen[i]);
//                }
//            }
//            ans[num] = lowest;

//        }
//        for (int i = 0; i < n; i++)
//        {
//            Console.WriteLine(ans[i]);
//        }
//    }
//}

#endregion

#region Where is the Bishop
//class Program
//{
//    public static void Main()
//    {
//        int n = int.Parse(Console.ReadLine());

//        char[,] Chess = new char[8, 8];
//        int[,] Ans = new int[2, n];
//        string s2 = Console.ReadLine();
//        for (int num = 0; num < n; num++)
//        {
//            for (int i = 0; i <= 7; i++)
//            {
//                string s = Console.ReadLine();
//                if (!s.Equals(""))
//                {
//                    for (int j = 0; j <= 7; j++)
//                    {
//                        Chess[i, j] = s[j];
//                    }
//                }
//                else if (s.Equals("")) i = -1;

//            }

//            for (int i = 0; i <= 7; i++)
//            {
//                for (int j = 0; j <= 7; j++)
//                {
//                    if (Chess[i, j].Equals('#') && i >= 1 && j >= 1 && i <= 6 && j <= 6)
//                    {
//                        if (Chess[i - 1, j - 1].Equals('#')
//                            && Chess[i - 1, j + 1].Equals('#')
//                            && Chess[i + 1, j - 1].Equals('#')
//                            && Chess[i + 1, j + 1].Equals('#'))
//                        {

//                            Ans[0, num] = i + 1;
//                            Ans[1, num] = j + 1;
//                        }
//                    }
//                }
//            }

//        }
//        for (int i = 0; i < n; i++)
//        {
//            Console.WriteLine("{0} {1}", Ans[0, i], Ans[1, i]);
//        }
//    }
//} 
#endregion

#region B. All Distinct

//class Program
//{
//    public static void Main()
//    {
//        int n = int.Parse(Console.ReadLine());

//        int[] ans = new int[n];

//        for (int num = 0; num < n; num++)
//        {
//            int countpair = 0;
//            int n1 = int.Parse(Console.ReadLine());
//            string s = Console.ReadLine();
//            string[] numArray = s.Split(" ");
//            int[] a = new int[numArray.Count()];
//            for (int j = 0; j < numArray.Count(); j++)
//            {
//                a[j] = Convert.ToInt32(numArray[j]);
//            }
//            Array.Sort(a);
//            var totalA = a.Count();
//            var b = a.Distinct().ToArray();
//            Array.Sort(b);
//            for (int j = 0; j < b.Count(); j++)
//            {
//                int singlecount = 0;
//                for (int i = 0; i < a.Count(); i++)
//                {
//                    if (b[j] == a[i]) singlecount++;
//                }
//                if (singlecount == 2)
//                {
//                    countpair++;
//                }
//                //odd pair but not 1
//                else if (singlecount % 2 == 0 && (singlecount / 2) % 2 == 1 && singlecount > 2)
//                {
//                    countpair++;
//                }
//                else if (singlecount % 2 == 0 && (singlecount / 2) % 2 == 0 && singlecount > 2)
//                {
//                    countpair++;
//                }
//                else ans[num]++;
//            }
//            if (countpair % 2 == 1 && countpair != 0)
//            {
//                ans[num] += (countpair - 1);
//            }
//            else if (countpair % 2 == 0 && countpair != 0)
//            {
//                ans[num] += countpair;
//            }
//        }
//        foreach (int Number in ans)
//        {
//            Console.WriteLine(Number);
//        }
//    }
//}

#endregion

#region A.Marathon
//class Program
//{
//    public static void Main()
//    {
//        int.TryParse(Console.ReadLine(), out int n);
//        int[] b = new int[n];
//        for (int i = 0; i < n; i++)
//        {
//            string s = Console.ReadLine();
//            string[] numArray = s.Split(" ");
//            int[,] a = new int[n, 4];
//            for (int j = 0; j < 4; j++)
//            {
//                a[i, j] = Convert.ToInt32(numArray[j]);
//                if (j > 0 && a[i, j] > a[i, 0]) b[i] += 1;
//            }

//        }
//        foreach (int i in b)
//        {
//            Console.WriteLine(i);
//        }

//    }
//}

#endregion

#region Separate two List and Comapre
//class Program
//{
//    public static void Main()
//    {
//        string ElementString = "Ascorbic Acid + Biotin + Boron + " +
//            "Calcium Carbonate + Chromium + Copper + Cyanocobalamin + " +
//            "Diabasic Calcium Phosphate + Elemental Iron + Folic Acid + " +
//            "Iodine + Lutein + Magnesium + Manganese + Molybdenum + " +
//            "Niacin + Nickel + Pantothenic acid + Potassium Chloride + " +
//            "Pyridoxine Hydrochloride + Riboflavin + Selenium + Silicon + " +
//            "Tin + Vanadium + Vitamin B1 + Vitamin D + Vitamin E + Vitamin K + Zinc";
//        string ElementQuantity = "60 mg + 30 mcg + 150 mcg + 52.49 mg + " +
//            "120 mcg + 2 mg + 6 mcg + 478.695 mg + 18 mg + 400 mcg + 150 mcg + " +
//            "250 mcg + 100 mg + 2 mg + 75 mcg + 20 mg + 5 mcg + 10 mg + " +
//            "152.52 mg + 2 mg + 1.7 mg + 20 mcg + 2 mg + 10 mcg + 10 mcg + " +
//            "1.5 mg + 400 IU + 30 IU + 25 mcg + 15 mg";
//        //Doesnt Work but : Reflection in C# is used to retrieve metadata on types at runtime | Also used to access private function of other classes
//        //typeof(Methods).GetMethod("NewMethod", BindingFlags.NonPublic | BindingFlags.Instance).Invoke(new Methods(), null);

//        //Methods method = new Methods();
//        //var Type = method.GetType();
//        //Methods.ElementSplitter(ElementString, ElementQuantity);
//        string RawPrice = "75.25, 120.40";
//        string splitter = ", ";
//        PriceSplitter(RawPrice, splitter);
//    }

//    public static void PriceSplitter(string RawPrice, string splitter)
//    {
//        IList<string> Prices = RawPrice.Split(splitter);
//        List<float> PriceinFloat = new();
//        foreach (string PriceItem in Prices)
//        {
//            float.TryParse(PriceItem, out float result);
//            PriceinFloat.Add(result);
//        }

//        Dictionary<int, float> PriceByVariation = new Dictionary<int, float>();
//        int VariationIndex = 1;
//        foreach (var flaotPrice in PriceinFloat)
//        {
//            PriceByVariation.Add(VariationIndex++, flaotPrice);
//        }
//        foreach (KeyValuePair<int, float> keyValuePair in PriceByVariation)
//        {
//            Console.WriteLine(keyValuePair.Key + " " + keyValuePair.Value);
//        }
//    }
//}
////class MyClass
////{

//    class Methods
//    {
//        public static void ElementSplitter(string ElementString, string ElementQuantity)
//        {
//            string ElementSplitter = " + ";
//            string QuantitySplitter = " + ";

//            IList<string> ElementList = ElementString.Split(ElementSplitter);
//            IList<string> QuantityList = ElementQuantity.Split(QuantitySplitter);
//            Dictionary<string, string> ElementVsQuantity = new Dictionary<string, string>();
//            if (ElementList.Count.Equals(QuantityList.Count))
//            {
//                int loopelement = 0;
//                var TotalElements = ElementList.Count;
//                foreach (string Element in ElementList)
//                {
//                    ElementVsQuantity.Add(Element, QuantityList[loopelement]);
//                    loopelement++;
//                }
//            }
//            foreach (KeyValuePair<string, string> Element in ElementVsQuantity)
//            {
//                Console.WriteLine(Element.Key + " = " + Element.Value);
//            }
//        }
//    }


#endregion

#region Extension Method
#endregion

#region Async Task
//class Counting
//{
//    public int Count()
//    {
//        int counter = 0;
//        for ( int i = 0; i < 1000000; i++)
//        {
//            counter++;
//        }
//        return counter;
//    }

//    public async void InfinityLoop()
//    {

//        Task<int> task = new Task<int>(Count);
//        task.Start();

//        Console.WriteLine("Counting......");
//        int counter = await task;
//        Console.WriteLine(counter);
//        Console.ReadLine();

//    }
//}
//public class AsyncTest
//{        
//    public static void Main()
//    {
//        Counting counting = new Counting();
//        counting.InfinityLoop();
//    }
//}
#endregion

#region Dictonary is All about Key Value Pair

//public class Customer
//{
//    public int id;
//    public string name;
//    public int salary;
//}
//class Program
//{
//    public static void Main()
//    {
//        Customer customer1 = new Customer()
//        {
//            id = 101,
//            name = "Mukit",
//            salary = 40000
//        };
//        Customer customer2 = new Customer()
//        {
//            id = 102,
//            name = "Farzin",
//            salary = 45000
//        };
//        Customer customer3 = new Customer()
//        {
//            id = 103,
//            name = "Anan",
//            salary = 50000
//        }; 
//        Customer customer4 = new Customer()
//        {
//            id = 104,
//            name = "GG",
//            salary = 50000
//        };


//        Dictionary<int, Customer> customerList = new Dictionary<int, Customer>()
//        {
//            {customer1.id, customer1},
//            {customer2.id, customer2},
//            {customer3.id, customer3}
//        };
//        if (!customerList.ContainsKey(customer4.id))
//        {
//            customerList.Add(customer4.id, customer4);
//        }
//        Customer cust;
//        if(customerList.TryGetValue(102, out cust))
//        {
//            Console.WriteLine("Customer");
//        }

//        ///Customer customer = customerList[103];
//        ///
//        //foreach(KeyValuePair<int, Customer> keyValuePair in customerList)
//        //{
//        //    Customer customer = customerList[keyValuePair.Key];
//        //    Console.WriteLine(keyValuePair.Value.name+" "+keyValuePair.Value.salary);

//        //}
//        foreach (var keyValuePair in customerList)
//        {
//            Customer customer = customerList[keyValuePair.Key];
//            Console.WriteLine(keyValuePair.Value.name + " " + keyValuePair.Value.salary);

//        }

//    }
//}
#endregion

#region Partial Methods
/*Partial Methods
* Partial method has a Partial keyword
* Partial methods are by efault private
* Can only be used in Partial Classes
* All Partial Method has a method signature declaration
* may have only one Implementation.
*/
#endregion

#region Generic (Type independent, Type can be )
//public class Program
//{
//    public static void Main()
//    {
//        float.TryParse(Console.ReadLine(), out float number);
//        int.TryParse(Console.ReadLine(), out int a);
//        int b = 20;
//        bool Equal = Calculation.AreEqual<int>(a,b);
//        if (Equal)
//        {
//            Console.WriteLine("They Are Equal");
//        }
//        else
//        {
//            Console.WriteLine("They are Not Eual");
//        }
//    }
//}
////Class can also be generic
////public class Calculation<T>

//public class Calculation
//{
//    public static bool AreEqual<T>(T a, T b)
//    {
//        return a.Equals(b);
//    }
//}
#endregion

#region Watch Part 55 & 56 = Reflection | Early Binding | late Binding (Creating instance in runtime) done by reflaction
//

#endregion

#region Attribute [Obsolete("new method signature")] to define outdated method
//Doesnt throw error but shows warnning
// can pass the new used method
#endregion

#region  Access Modifiers for Type
//Private Members are not inherited by subclasses of that class. 
// But protected Members can be inherited
//Public -  Accessable to all
//Private - Not at all accessable
//Protected - Containing types (Inherited)
//Internal - Available to same Assemply not in other assembly
//Protected Internal - When derived can be accessed outside assebly
#endregion

#region Type vs Type Member
/*
 * Class, Structure, Interfaces, Delegates are called as Types (Can only be Internal & Public)
 * Fields, Methods are Type Members (Can be all 5 Private, Protected, Internal, Protected Internal, Public)
*/
#endregion

#region Enum (Strongly Typed Constant) undeline type is integer

#endregion

#region Exception (Read from txt)
//class Program
//{
//    public static void Main()
//    {
//        //there is a StreamWriter
//        StreamReader streamReader = null;
//        try
//        {
//            streamReader = new StreamReader(@"C:\Users\Farzin Mukit\Desktop\ErrorLog.txt");
//            Console.WriteLine(streamReader.ReadToEnd());

//        }
//        catch(FileNotFoundException ex)
//        {
//            Console.WriteLine("File Not Found");
//            Console.WriteLine(ex.FileName);
//        }
//        catch(Exception ex)
//        {
//            Console.WriteLine(ex.Message);
//        }
//        finally
//        {
//            if(streamReader != null) streamReader.Close();
//        }

//    }
//}

#endregion

#region MultiCast Delegate
////Used in Observer Design Patter
////or Publisher Subscribers Pattern
//// Chaining delegates
//public delegate void SampleDelegate(out int Number);
//class Onnorokom
//{
//    public static void Main()
//    {
//        //SampleDelegate sampleDelegate1 = new SampleDelegate(SampleMethod1);
//        //sampleDelegate1();
//        SampleDelegate sample1, sample2, sample3, sample4;
//        sample1 = new SampleDelegate(SampleMethod3);
//        //sample2 = new SampleDelegate(SampleMethod2);
//        //sample3 = new SampleDelegate(SampleMethod3);

//        //sample4 = sample1 - sample2 + sample3;
//        ///int returned = sample4;

//        sample1(out int Output);
//        /*
//         * in invocation, only one value can be hold. Thus the last invoked method will be returned.
//         */
//        Console.WriteLine(Output);
//    }

//    public static void SampleMethod1(out int sum)
//    {
//        sum = 1;
//        //Console.WriteLine("Sample Method1");

//    }
//    public static void SampleMethod2(out int sum)
//    {
//        sum = 2;
//        //Console.WriteLine("Sample Method2");

//    }
//    public static void SampleMethod3(out int sum)
//    {
//        sum = 3;
//        //Console.WriteLine("Sample Method3");

//    }
//}


#endregion

#region Delegets RefranceType Example part 36

//delegate bool IsPromotable(Employee employee);

//class Employee
//{
//    public int ID { get; set; }
//    public string Name { get; set; }
//    public int Salary { get; set; }
//    public int Experience { get; set; }
//    public void Elegible(List<Employee> employeeList, IsPromotable isPromotable)
//    {
//        foreach(Employee employee in employeeList)
//        {
//            if(isPromotable(employee)) { Console.WriteLine(employee.ID+" "+employee.Name+" Is Elegible"); }
//        }
//    }
//}
//class Program
//{
//    public static void Main()
//    {
//        List<Employee> employeeList = new List<Employee>();
//        employeeList.Add(new Employee() { ID = 1, Name = "Farzin", Salary = 30000, Experience = 2});
//        employeeList.Add(new Employee() { ID = 2, Name = "Anan", Salary = 34000, Experience = 2 });
//        employeeList.Add(new Employee() { ID = 3, Name = "Mukit", Salary = 35000, Experience = 3 });
//        employeeList.Add(new Employee() { ID = 4, Name = "Mahin", Salary = 40000, Experience = 4 });
//        employeeList.Add(new Employee() { ID = 5, Name = "Nusrat", Salary = 35000, Experience = 5 });

//        Employee employee = new Employee();

//        //bool PromotionCriteria(Employee employee)
//        //{
//        //    if (employee.Experience >= 4) return true;
//        //    return false;
//        //}

//        //IsPromotable promotable = new IsPromotable(PromotionCriteria);
//        //employee.Elegible(employeeList, promotable);

//        employee.Elegible(employeeList, p => p.Experience >= 4);
//    }
//}
#endregion

#region Delegets RefranceType part 36
////Type Safe Function Pointer, 
////Passing Function
//public delegate void HelloFunctionDelegate(string Message);
////need creating instance of delegate
//class Program
//{
//    public static void Main()
//    {
//        HelloFunctionDelegate delG = new HelloFunctionDelegate(Message);
//        delG.Invoke("My God Invoking");
//        delG("My God");
//    }
//    public static void Message(string strMessage) { Console.WriteLine(strMessage); }
//}
#endregion

#region Struct (Class vs Struct) Part 29
//Struct is a value Type || Stored on a stack
//Class is a refrance Type || Stored on a heap

//public struct Customer
//{
//    private int _Id;
//    private string _Name;
//    private int _Cost;
//    private int _Item;
//    public int TotalCost()
//    {
//        var Sum = Item * Cost;
//        return Sum;
//    }

//    public int Id { get => _Id; set => _Id = value; }
//    public string Name { get => _Name; set => _Name = value; }
//    public int Item { get => _Item; set => _Item = value; }
//    public int Cost { get => _Cost; set => _Cost = value; }
//}
//class Program
//{
//    public static void Main()
//    {
//        Customer customer = new Customer();
//        {
//            customer.Id = 20;
//            customer.Name = "Farzin";
//            customer.Item = 5;
//            customer.Cost = 30;
//            Console.WriteLine(customer.Id+"\n"+ customer.Name + "\n"+ customer.Item + "\n"+customer.TotalCost());
//        }
//    }
//}
#endregion

#region Properties In C# (get set)

// If you use Get Set, you have to use "value" in set and get block.

//public class Student
//{
//    private int _ID;
//    private string _Name;
//    private int _PassMarks = 40;  

//    public int ID
//    {
//        set
//        {
//            if (value <= 0) throw new Exception("Invalid ID");
//            _ID = value;
//        }
//        get
//        {
//            return _ID;
//        }

//    }

//    public string Name
//    {
//        set
//        {
//            if (string.IsNullOrEmpty(value)) throw new Exception("Invalid Name");
//            _Name = value;
//        }
//        get { return _Name; }

//    }
//    public string CheckMarks(int Marks)
//    {
//        if ( Marks >= _PassMarks)    return "PASSED";
//        return "Failure";
//    }

//}
//class Program
//{
//    public static void Main()
//    {
//        Student student = new Student();
//        try
//        {
//            student.ID = 1602030;
//            student.Name = "Farzin";
//            var Marks = 42;
//            Console.WriteLine(student.ID+"\n" +student.Name+ "\n"+student.CheckMarks(Marks));
//        }
//        catch
//        {
//            Console.WriteLine("Invalid Input");
//        }


//    }
//}


#endregion

#region Part 26 - Properties (GET SET) || Encaptulation
//public class Student
//{
//    private int _ID;
//    private string _Name;
//    private int _PassMarks = 40;  

//    public void SetID(int ID)
//    {
//        if (ID <= 0) throw new Exception("Invalid");
//        _ID = ID;
//    }
//    public int GetID()
//    {
//        return _ID;
//    }
//    public void SetName(string Name)
//    {
//        if (string.IsNullOrEmpty(Name)) throw new Exception("Invalid");
//        this._Name = Name;
//    }
//    public string GetName()
//    {
//        return string.IsNullOrEmpty(_Name) ? null : _Name;
//    }
//    public string CheckMarks(int Marks)
//    {
//        if ( Marks >= _PassMarks)    return "PASSED";
//        return "Failure";
//    }

//}
//class Program
//{
//    public static void Main()
//    {
//        Student student = new Student();
//        try
//        {
//            student.SetID(1602030);
//            student.SetName("Farzin Anan Mukit");
//            var Marks = 40;
//            Console.WriteLine(student.GetID()+"\n" +student.GetName()+ "\n"+student.CheckMarks(Marks));
//        }
//        catch
//        {
//            Console.WriteLine("Invalid");
//        }
//        //student._Name = "Farzin Anan Mukit";
//        //student._PassMarks = 0;


//    }
//}


#endregion

#region Multiple Interface Inheritance

/// Multiple Interface Part 35


//interface IA
//{
//    void AMethod();
//}
//interface IB
//{
//    void BMethod();
//}
//class A : IA
//{
//    public void AMethod()
//    {
//        int a = 30;
//        int b = 40;
//        Console.WriteLine("From IA, Value = {0}", a+b);
//    }
//}

//class B : IB
//{

//    public void BMethod()
//    {
//        int a = 20;
//        int b = 40;
//        Console.WriteLine("From IB, Value = {0}", a + b);
//    }
//}
//class AB : IA, IB
//{
//    A a = new A();
//    B b = new B();
//    public void AMethod()
//    {
//        a.AMethod();
//    }

//    public void BMethod()
//    {
//        b.BMethod();
//    }
//}

//internal class Program
//{
//    public static void Main()
//    {
//        AB aB = new AB();
//        aB.BMethod();
//        aB.AMethod();
//    }
//}
#endregion

#region Method Hiding & Methodd Overriding /\ Calling hidden metho by 'base' Keyword, Type Casting to call parent, 

//public class Employee
//{
//    public string _Fname;
//    public string _Lname;
//    public int _ID;
//    public string _Email;
//    //public Employee(string Fname, string Lname, int ID, string Email)
//    //{
//    //    _Fname = Fname;
//    //    _Lname = Lname;
//    //    _ID = ID;
//    //    _Email = Email;
//    //}

//    public void FullName()
//    {
//        Console.WriteLine(_Fname + " " + _Lname);
//    }
//}

//public class FullTime : Employee
//{
//    public int YearlySalary;
//}
//public class PartTime : Employee
//{
//    public new void FullName()
//    {
//        //base.FullName(); //to print parent method -> to use hiden method
//        Console.WriteLine("_Contract "+_Fname + " " + _Lname);
//    }
//    public int HourlyRate;
//}

//class Program
//{
//    public static void Main()
//    {
//        FullTime fullTime = new FullTime();
//        fullTime._Fname = "Farzin";
//        fullTime._Lname = "Mukit";
//        fullTime.FullName();

//        PartTime partTime = new PartTime();
//        partTime._Fname = "Md.";
//        partTime._Lname = "Zaman";
//        partTime.FullName();
//    //    // another way if calling base method

// // // type casting to parent class

//        //((Employee)partTime).FullName();

//        Employee partTime2 = new PartTime();
//        partTime._Fname = "Abdul";
//        partTime._Lname = "Ahad";
//        partTime.FullName();
//    }
//}
#endregion

#region Virtual/Override vs New
/*
 The override keyword is used to extend or modify 
a virtual/abstract method, property, indexer, 
or event of base class into a derived class. 
The new keyword is used to hide 
a method, property, indexer, 
or event of base class into derived class.
 */
#endregion

#region Using Static Variables
//class Circle
//{
//    public static float _pi;
//    static int counter;
//    static int counter1;
//    int _radius;


//    static Circle()
//    {
//       _pi = 3.14f;
//        counter = 0;
//        counter1++;
//    }
//    public Circle(int Radius)
//    {
//        this._radius = Radius;
//    }
//    public float CalculateRadius()
//    {
//        counter++;
//        Console.WriteLine(counter1);
//        Console.WriteLine(counter);
//        return _pi * this._radius * this._radius;
//    }
//}

//class Program
//{
//    public static void Main()
//    {
//        int Radius = 5;
//        int Radius1 = 6;
//        int Radius2 = 7;

//        Circle circle = new Circle(Radius);
//        Console.WriteLine(circle.CalculateRadius());
//        Circle circle2 = new Circle(Radius1);
//        Console.WriteLine(circle2.CalculateRadius());
//        Circle circle3 = new Circle(Radius2);
//        Console.WriteLine(circle3.CalculateRadius());


//    }
//}
#endregion

#region Constructor & Destructor
//class Customer
//{
//    string _firstName;
//    string _lastName;

// // default Constructor default value passing
// // Constructors are used to initiate values

//    public Customer() : this("No FName Provided", "No LName Provided")
//    {

//    }

//    public Customer(string FirstName, string LastName)
//    {
//        this._firstName = FirstName;
//        this._lastName = LastName;
//    }

//    public void FullName()
//    {
//        Console.WriteLine("Full Name = "+_firstName + " " + _lastName);
//    }

// // Destructor

//    ~Customer()
//    {

//    }
//}

//class Program
//{
//    public static void Main()
//    {
//        Customer customer = new Customer("Farzin", "Mukit");
//        customer.FullName();

//        Customer customer1 = new Customer();
//        customer1.FullName();
//    }
//}

#endregion

#region Method Parameter
//namespace ConsoleApp11
//{

//    internal class Program
//    {

//        public static void Main(string[] args)
//        {
//            int[] Numbers = new int[3];
//            Numbers[0] = 1;
//            Numbers[1] = 2;
//            Numbers[2] = 3;
//            int[] Numbers2 = new int[3];
//            Numbers2[0] = 2;
//            Numbers2[1] = 3;
//            Numbers2[2] = 4;
//            Program.ParameMethod(Numbers, Numbers2);
//        }
//        public static void ParameMethod(int[] Number, int[] Number1)
//        {
//            Console.WriteLine("Number of elements: {0}", Number.Length);
//            foreach (int i in Number)
//            {
//                Console.WriteLine(i);
//            }

//            Console.WriteLine("Number of elements: {0}", Number1.Length);
//            foreach (int i in Number1)
//            {
//                Console.WriteLine(i);
//            }
//        }
//    }
//}
#endregion

#region Out Parameters

//         public static void Main(string[] args)
//        {
//            int sum = 0;
//            int product = 0;    
//            OutParameter(3, 4, out sum, out product);
//            Console.WriteLine("Sum: {0}, Product: {1}", sum, product);
//        }
//        public static void OutParameter(int a, int b, out int sum, out int product)
//        {
//            sum = a+b;
//            product = a * b;
//        }   
#endregion

#region Call by referance
//Changes the refferred var

//    class InstacneCalling
//    {
//        public ArrayList SumUp(int a, ref ArrayList list)
//        {
//            ArrayList arrayList = new ArrayList();

//            for(int i=0; i< list.Count; i++)
//            {
//                list[i] = (int)list[i] + a;
//            }

//            //foreach (int i in list)
//            //{
//            //    arrayList.Add(i + a);
//            //}
//            return list;
//        }
//    }
//    internal class Program
//    {

//        public static void Main(string[] args)
//        {
//            InstacneCalling instacneCalling = new InstacneCalling();
//            ArrayList list = new ArrayList() {1,3,5,7,9};
//            ArrayList list2 = new ArrayList();
//            ArrayList list3 = new ArrayList();
//            int a = 1;
//            list2 = instacneCalling.SumUp( a, ref list);
//            foreach(int i in list2)
//            {
//                Console.WriteLine(i);
//            }
//            list3 = instacneCalling.SumUp( 1, ref list);
//            foreach (int i in list3)
//            {   
//                Console.WriteLine(i);
//            }
//        }
#endregion

#region Static vs Instance 

//         // normal method needs creating object
//         //static method needs instance of Class



//         public static void Main(string[] args)
//        {
//            ArrayList list = new ArrayList(){1,3,5,7,9};
//            ArrayList list2 = new ArrayList();
//            int a = 1;
//            list2 = Program.SumUp(a, list);
//            foreach(int i in list2)
//            {
//                Console.WriteLine(i);
//            }
//        }
//        public static ArrayList SumUp(int a, ArrayList list)
//        {
//            ArrayList arrayList = new ArrayList();
//            foreach (int i in list)
//            {
//                arrayList.Add(i+a);
//            }
//            return arrayList;
//        }

#endregion

#region Class Instance Calling

//        +++++++++++++++++++++++++++++

//    class InstacneCalling
//    {
//        public ArrayList SumUp(int a, ArrayList list)
//        {
//            ArrayList arrayList = new ArrayList();
//            foreach (int i in list)
//            {
//                arrayList.Add(i + a);
//            }
//            return arrayList;
//        }
//    }
//    internal class Program
//    {

//        public static void Main(string[] args)
//        {
//            InstacneCalling instacneCalling = new InstacneCalling();
//            ArrayList list = new ArrayList(){1,3,5,7,9};
//            ArrayList list2 = new ArrayList();
//            ArrayList list3 = new ArrayList();
//            int a = 1;
//            list2 = instacneCalling.SumUp(a, list);
//            foreach(int i in list2)
//            {
//                Console.WriteLine(i);
//            }
//            list3 = instacneCalling.SumUp(a+1, list);
//            foreach (int i in list3)
//            {   
//                Console.WriteLine(i);
//            }
//        }   


//        +++++++++++++++++++++++++++++


#endregion

#region More Switchcase

//             int BaseCoffeeCost = 20;
//            Start:
//            Console.WriteLine("Small = 1\nMedium = 2\nLarge = 3");
//            int.TryParse(Console.ReadLine(), out int size);
//            switch (size)
//            {
//                case 1:
//                    Console.WriteLine("Cost: " + BaseCoffeeCost);
//                    break;
//                case 2:
//                    Console.WriteLine("Cost: " + (float)BaseCoffeeCost * 1.50);
//                    break;
//                case 3:
//                    Console.WriteLine("Cost: " + (float)BaseCoffeeCost * 1.75);
//                    break;
//                default:
//                    Console.WriteLine("Wrong Input");
//                    goto Start;
//                    //Can go to another case

//            }
//            Console.WriteLine("Wanna Buy Another Coffee? Yes or No?");
//            Again:
//            string Decision = Console.ReadLine();
//            switch (Decision.ToUpper())
//            {
//                case "YES":
//                    goto Start;
//                case "NO":
//                    break;
//                default:
//                    goto Again;
//            }

#endregion

#region SwitchCase and Refactoring


//        Console.WriteLine("Enter a Number: ");
//            int.TryParse(Console.ReadLine(), out int UserNumber);
//         Console.WriteLine(UserNumber); 

//        Console.WriteLine("Enter Number");
//            int.TryParse(Console.ReadLine(), out int Number);
//            NewMethod(Number);
//            static void NewMethod(int Number)
//            {
//                switch (Number)
//                {
//                    case 1:
//                        Console.WriteLine("January");
//                        break;
//                    case 2:
//                        Console.WriteLine("February");
//                        break;
//                    case 3:
//                        Console.WriteLine("March");
//                        break;
//                    case 4:
//                    case 5:
//                        Console.WriteLine("Your Number is {0}", Number);
//                        break;
//                    case 6:
//                        Console.WriteLine("Your Number is {0}", Number+1);
//                        break;
//                    default:
//                        Console.WriteLine("Times Up");
//                        break;
//                }
//            }    

#endregion

#region Array in C#

//        /*Array in C#
//         * 
//         *  Advantage is Strongly Typed
//         *  int[] i = { 1, 2, 3 };

//        int[] i = new int[5];
//            i[0] = 20;
//            i[1] = 20;
//            i[2] = 20;
//            i[3] = 20;
//            i[4] = 20;
//            i[5] = 20;

//            foreach (int x in i)
//            {
//                Console.WriteLine(x);   
//            }   
#endregion

#region Type COnverion

//        /* Type Conversion */
//        //float f = 12929571273527320.12f;
//        ////int i = (int)f;
//        //// convert can throw the exception, where Explicit convertion (int) cant catch the exception
//        //int i = Convert.ToInt32(f);
//        //Console.WriteLine(i);


//        //string StrNumber = "1271T";
//        //bool IsConvSuccess = int.TryParse(StrNumber, out int i);

//        //    if (IsConvSuccess)
//        //    {
//        //        Console.WriteLine(i);
//        //    }
//        //    else

//        //        Console.WriteLine("ERROR");
//        // int i = Convert.ToInt32(StrNumber);
//        // int j = int.Parse(StrNumber);      
//        // Console.WriteLine(i);
//        //Console.WriteLine(j);

//    }
//}
#endregion