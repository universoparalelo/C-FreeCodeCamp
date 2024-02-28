// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, C#");

// Random dice = new Random();
// int roll1 = dice.Next();
// int roll2 = dice.Next(101);
// int roll3 = dice.Next(50, 101);

// Console.WriteLine($"First roll: {roll1}");
// Console.WriteLine($"Second roll: {roll2}");
// Console.WriteLine($"Third roll: {roll3}");




// int firstValue = 500;
// int secondValue = 600;
// int largerValue;

// largerValue = Math.Max(firstValue, secondValue);

// Console.WriteLine(largerValue);




// Random dice = new Random();

// int result1 = dice.Next(1,7);
// int result2 = dice.Next(1,7);
// int result3 = dice.Next(1,7);

// int total = result1 + result2 + result3;

// Console.WriteLine($"{result1} + {result2} + {result3} = {total}");

// if (result1 == result2 && result1 == result3){
//     Console.WriteLine("Three dices have the same number, Amazing!!! +6");
//     total += 6;
// } else if ((result1 == result2) || (result1 == result3) || (result2 == result3)){
//     Console.WriteLine("Two dices have the same number, Congrats!!! +2");
//     total += 2;
// }

// if (total >= 16){
//     Console.WriteLine($"Felicitaciones ganaste un auto!!");
// } 
// else if (total>=10){
//     Console.WriteLine($"Felicitaciones ganaste un portatil!!");
// } 
// else if (total == 7) {
//     Console.WriteLine($"Ganaste un viaje!!");
// } 
// else {
//     Console.WriteLine($"Felicitaciones ganaste un gatito!!");
// }




// Random random = new Random();
// int daysUntilExpiration = random.Next(12);
// int discountPercentage = 0;

// if (daysUntilExpiration == 0){
//     Console.WriteLine("Your subscription has expired.");
// }
// else if (daysUntilExpiration == 1){
//     Console.WriteLine("Your subscription expires within a day!");
//     discountPercentage = 20;
// }
// else if (daysUntilExpiration <= 5){
//     Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
//     discountPercentage = 10;
// }
// else if (daysUntilExpiration <= 10){
//     Console.WriteLine("Your subscription will expire soon.");
// }

// if (discountPercentage > 0)
// {
//     Console.WriteLine($"Renew now and save {discountPercentage}%.");
// }



// string[] fraudulentOrderIDs = new string[3];

// fraudulentOrderIDs[0] = "A123";
// fraudulentOrderIDs[1] = "B456";
// fraudulentOrderIDs[2] = "C789";
// fraudulentOrderIDs[3] = "D000";

// Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
// Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
// Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

// fraudulentOrderIDs[0] = "F000";

// Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");



// string[] fraudulentOrderIDs = { "A123", "B456", "C789" };

// Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
// Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
// Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

// fraudulentOrderIDs[0] = "F000";

// Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

// Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");



// string[] names = {"Celeste", "Ludmila", "Bianca"};

// foreach (string name in names){
//     Console.Write($"{name}, ");
// }



// int[] inventory = {23,34,45,56,67,78,89};
// int sum = 0;
// int bin = 1;

// foreach (int item in inventory){
//     sum += item;
//     Console.WriteLine($"Bin {bin} = {item} items (Running total: {sum})");
//     bin++;
// }

// Console.WriteLine($"The total: {sum}.");




// string[] codigosFraudulentos = {"B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"};

// foreach (string codigo in codigosFraudulentos){
//     if (codigo.StartsWith('B')){
//         Console.WriteLine($"El codigo {codigo} tiene altas probabilidades de ser fraudulento");
//     }
// }




// string firstName = "Bob";
// int widgetsPurchased = 7;
// // Testing a change to the message.
// // int widgetsSold = 7;
// // Console.WriteLine($"{firstName} sold {widgetsSold} widgets.");
// Console.WriteLine($"{firstName} purchased {widgetsPurchased} widgets.");



/*
  The following code creates five random OrderIDs
  to test the fraud detection process.  OrderIDs 
  consist of a letter from A to E, and a three
  digit number. Ex. A123.
*/
// Random random = new Random();
// string[] orderIDs = new string[5];

// for (int i = 0; i < orderIDs.Length; i++)
// {
//     int prefixValue = random.Next(65, 70);
//     string prefix = Convert.ToChar(prefixValue).ToString();
//     string suffix = random.Next(1, 1000).ToString("000");

//     orderIDs[i] = prefix + suffix;
// }

// foreach (var orderID in orderIDs)
// {
//     Console.WriteLine(orderID);
// }




/*
This code counts how many o's are in the phrase frase and reverse de frase
*/

// string frase = "The quick brown fox jumps over the lazy dog.";
// int cantidad = 0;

// char[] charMessage = frase.ToCharArray();
// Array.Reverse(charMessage);

// foreach (char letra in charMessage) { 
//     if (letra == 'o') {
//         cantidad++;
//     } 
// }

// string new_message = new String(charMessage);
// Console.WriteLine(new_message);

// Console.WriteLine($"'o' appears {cantidad} times.");





// Console.WriteLine("a" == "a");
// Console.WriteLine("a" == "A");
// Console.WriteLine(1 == 2);

// string myValue = "a";
// Console.WriteLine(myValue == "a");




// string value1 = " a";
// string value2 = "A ";
// Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());

// string pangram = "The quick brown fox jumps over the lazy dog.";
// Console.WriteLine(pangram.Contains("fox"));
// Console.WriteLine(!pangram.Contains("cow"));





// int saleAmount = 1001;
// int discount = saleAmount > 1000 ? 100 : 50;
// Console.WriteLine($"Discount: {discount}");




// Random coin = new Random();
// int choice = coin.Next(0,2);
// Console.WriteLine($"Choice: {(choice == 0 ? "heads" : "tails")}");





// string permission = "Emplyee";
// int level = 15;

// if (permission.Contains("Admin") && level >= 55){
//   Console.WriteLine("Welcome, Super Admin user.");
// } else if (permission.Contains("Admin") && level < 55){
//   Console.WriteLine("Welcome, Admin user.");
// } else if (permission.Contains("Manager") && level >= 20){
//   Console.WriteLine("Contact an Admin for access.");
// } else if (permission.Contains("Manager") && level < 20){
//   Console.WriteLine("You do not have sufficient privileges.");
// } else if (!permission.Contains("Admin")){
//   Console.WriteLine("You do not have sufficient privileges.");
// }





// bool flag = true;
// int value=0;
// if (flag)
// {
//     value = 10;
//     Console.WriteLine($"Inside of code block: {value}");
// }
// Console.WriteLine($"Outside of code block: {value}");




// int[] numbers = { 4, 8, 15, 16, 23, 42 };
// int total = 0;
// bool found = false;

// foreach (int number in numbers)
// {
//     total += number;

//     if (number == 42)
//       found = true;
// }

// if (found) 
//     Console.WriteLine("Set contains 42");

// Console.WriteLine($"Total: {total}");





// int employeeLevel = 100;
// string employeeName = "John Smith";

// string title = "";

// switch (employeeLevel)
// {
//     case 100:
//     case 200:
//         title = "Senior Associate";
//         break;
//     case 300:
//         title = "Manager";
//         break;
//     case 400:
//         title = "Senior Manager";
//         break;
//     default:
//         title = "Associate";
//         break;
// }

// Console.WriteLine($"{employeeName}, {title}");






// SKU = Stock Keeping Unit. 
// SKU value format: <product #>-<2-letter color code>-<size code>
// string sku = "01-MN-L";

// string[] product = sku.Split('-');

// string type = "";
// string color = "";
// string size = "";

// switch(product[0]){
//   case "01":
//     type = "Sweat shirt";
//     break;
//   case "02":
//     type = "T-Shirt";
//     break;
//   case "03":
//     type = "Sweat pants";
//     break;
//   default:
//     type = "Other";
//     break;
// }

// switch(product[1]){
//   case "BL":
//     color = "Maroon";
//     break;
//   default:
//     color = "White";
//     break;
// }

// switch(product[2]){
//   case "S":
//     size = "Small";
//     break;
//   case "M":
//     size = "Medium";
//     break;
//   case "L":
//     size = "Large";
//     break;
//   default:
//     size = "One Size Fits All";
//     break;

// }

// Console.WriteLine($"Product: {size} {color} {type}");





// for (int i = 0; i < 10; i++)
// {
//     Console.WriteLine(i);
// }

// for (int i = 10; i >= 0; i--)
// {
//     Console.WriteLine(i);
// }

// for (int i = 0; i < 10; i += 3)
// {
//     Console.WriteLine(i);
// }

// for (int i = 0; i < 10; i++)
// {
//     Console.WriteLine(i);
//     if (i == 7) break;
// }

// string[] names = { "Alex", "Eddie", "David", "Michael" };
// for (int i = names.Length - 1; i >= 0; i--)
// {
//     Console.WriteLine(names[i]);
// }

// string[] names2 = { "Alex", "Eddie", "David", "Michael" };
// for (int i = 0; i < names2.Length; i++)
//     if (names2[i] == "David") names2[i] = "Sammy";

// foreach (var name in names2) Console.WriteLine(name);





// for (int i=1; i<=100; i++){
//   Console.Write($"{i} - ");
//   if (i%3 == 0 && i%5 == 0)
//     Console.Write("FizzBuzz\n");
//   else if (i%5 == 0)
//     Console.Write("Buzz\n");
//   else if (i%3 == 0)
//     Console.Write("Fizz\n");
//   else
//     Console.Write("\n");
// }




// Random random = new Random();
// int current = random.Next(1, 11);

// /*
// do
// {
//     current = random.Next(1, 11);
//     Console.WriteLine(current);
// } while (current != 7);*/

// while (current >= 3)
// {
//     Console.WriteLine(current);
//     current = random.Next(1, 11);
// }
// Console.WriteLine($"Last number: {current}");




// Random random = new Random();
// int current = 0;

// do
// {
//     current = random.Next(1, 11);

//     if (current >= 8) continue;

//     Console.WriteLine(current);
// } while (current != 7);




// Random random = new Random();
// int heroe = 10;
// int monstruo = 10;
// int turno = 0;

// do {    
//   int number = random.Next(1,11);

//   if (turno%2 == 0)
//     monstruo -= number;
//   else
//     heroe -= number;

//   Console.WriteLine($"El {(turno%2 == 0? "Monstruo":"Heroe")} perdió {number} puntos, le restan {(turno%2 == 0? monstruo:heroe)}");
//   turno++;

// } while (heroe > 0 && monstruo > 0);

// Console.WriteLine($"El ganador es el {(monstruo>heroe? "Monstruo":"Heroe")} con {(monstruo>heroe? monstruo:heroe)} puntos");

//SOLUCION ALTERNATIVA

// int hero = 10;
// int monster = 10;

// Random dice = new Random();

// do
// {
//     int roll = dice.Next(1, 11);
//     monster -= roll;
//     Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health.");

//     if (monster <= 0) continue;

//     roll = dice.Next(1, 11);
//     hero -= roll;
//     Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health.");

// } while (hero > 0 && monster > 0);

// Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");






// string? readResult;
// Console.WriteLine("Enter a string:");
// do
// {
//     readResult = Console.ReadLine();
// } while (readResult == null);





// string? readResult;
// bool validEntry = false;
// Console.WriteLine("Enter a string containing at least three characters:");
// do
// {
//     readResult = Console.ReadLine();
//     if (readResult != null)
//     {
//         if (readResult.Length >= 3)
//         {
//             validEntry = true;
//         }
//         else
//         {
//             Console.WriteLine("Your input is invalid, please try again.");
//         }
//     }
// } while (validEntry == false);




//PROYECTO 1

// int number = 0;
// string? charToConvert;
// bool valid = false;

// Console.Write("Escriba un numero entre 5 y 10: ");

// do {
//   charToConvert = Console.ReadLine();

//   if (charToConvert != null){
//     valid = int.TryParse(charToConvert,out number);
//     if(valid){
//       if(number>=5 && number<=10)
//         Console.WriteLine($"El valor ingresado es un numero y se encuentra entre 5 y 10: {number}");
//       else{
//         Console.WriteLine($"El valor ingresado es un numbero pero no se encuentra entre 5 y 10: {number}");
//         Console.Write("Escriba un numero entre 5 y 10: ");
//         valid = false;
//       }
//     }
//     else {
//         Console.WriteLine($"El valor ingresado no es un numbero: {number}");
//         Console.Write("Escriba un numero entre 5 y 10: ");    
//     }
//   }

// } while (valid == false);





//PROYECTO 2

// string? rol;
// bool valid = false;

// Console.WriteLine("Escriba el rol que ocupa: (Administrador, Director o Usuario)");

// do{
//   rol = Console.ReadLine();
//   if (rol != null)
//     rol = rol.Trim();

//   if (rol.ToLower() == "administrador"){
//     rol = "Administrador";
//     valid = true;
//   } else if (rol.Trim().ToLower() == "director"){
//     rol = "Director";
//     valid = true;
//   }  else if (rol.Trim().ToLower() == "usuario"){
//     rol = "Usuario";
//     valid = true;
//   }  else
//     Console.WriteLine("El rol que escribió es incorrecto. Intentelo de nuevo.");

// } while (valid == false);


// Console.WriteLine($"Bienvenidx, {rol}");


//PROYECTO 3

// string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
// int periodLocated;

// foreach(string myString in myStrings){
//   periodLocated = myString.IndexOf('.');
//   string newString = myString;

//   while(periodLocated != -1){
//     string newString2 = newString.Substring(0, periodLocated);
//     Console.WriteLine(newString2);
//     newString = newString.Remove(0, periodLocated+1).TrimStart();
//     // Console.WriteLine(newString);
//     periodLocated = newString.IndexOf('.');
//   }
//   Console.WriteLine(newString);
// }





// Console.WriteLine("Signed integral types:");

// Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
// Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
// Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
// Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");


// Console.WriteLine("");
// Console.WriteLine("Unsigned integral types:");

// Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
// Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
// Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
// Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");



// Console.WriteLine("");
// Console.WriteLine("Floating point types:");
// Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
// Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
// Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");



// int[] data = new int[3];

// string shortenedString = "Hello World!";
// Console.WriteLine(shortenedString);





// int first = 2;
// string second = "4";
// int third = 34;
// // int result = first + second;
// string result = first + third + second;
// Console.WriteLine(result);

// decimal myDecimal = 3.2454m;
// Console.WriteLine($"decimal: {myDecimal}");

// int myInt = (int)myDecimal;
// Console.WriteLine($"int: {myInt}");


// decimal myDecimal2 = 1.23456789m;
// float myFloat = (float)myDecimal2;

// Console.WriteLine($"Decimal: {myDecimal2}");
// Console.WriteLine($"Float  : {myFloat}");


// int first = 5;
// int second = 7;
// string message = first.ToString() + second.ToString();
// Console.WriteLine(message);


// string first2 = "5";
// string second2 = "7";
// int sum = int.Parse(first2) + int.Parse(second2);
// Console.WriteLine(sum);


// string value1 = "5";
// string value2 = "7";
// int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
// Console.WriteLine(result);





// string value = "102";
// int result = 0;
// if (int.TryParse(value, out result))
// {
//    Console.WriteLine($"Measurement: {result}");
// }
// else
// {
//    Console.WriteLine("Unable to report the measurement.");
// }
// Console.WriteLine($"Measurement (w/ offset): {50 + result}");





// string[] values = { "12,3", "45", "ABC", "11", "DEF" };
// decimal sum = 0;
// string cadena = "";

// foreach(string value in values){
//   decimal value1 = 0;


//   if (decimal.TryParse(value, out value1)) {
//     sum += value1;
//     Console.WriteLine($"Value1: {value1}");
//     Console.WriteLine($"Suma: {sum}");
//   }
//   else {
//     cadena += value;
//   }
// }

// Console.WriteLine($"Suma total: {sum}");
// Console.WriteLine($"Cadena final: {cadena}");






// int value1 = 12;
// decimal value2 = 6.2m;
// float value3 = 4.3f;

// // Your code here to set result1
// decimal result1 = 0;

// result1 = value1 / value2;
// result1 = Convert.ToInt16(result1);

// Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

// // Your code here to set result2
// decimal result2 = value2 / (decimal)value3;

// Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

// // Your code here to set result3
// float result3 = (float)value3 / (float)value1;

// Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");






// string[] pallets = { "B14", "A11", "B12", "A13" };

// Console.WriteLine("Sorted...");
// Array.Sort(pallets);
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// Console.WriteLine("...");
// Console.WriteLine("Reverse...");
// Array.Reverse(pallets);
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }






// string[] pallets = { "B14", "A11", "B12", "A13" };
// Console.WriteLine("");

// Array.Clear(pallets, 0, 2);

// Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// Console.WriteLine("");
// Array.Resize(ref pallets, 6);
// Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

// pallets[4] = "C01";
// pallets[5] = "C02";

// Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// Console.WriteLine("");
// Array.Resize(ref pallets, 3);
// Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }







// string value = "abc123";
// char[] valueArray = value.ToCharArray();
// Array.Reverse(valueArray);
// // string result = new string(valueArray);
// string result = String.Join(",", valueArray);
// Console.WriteLine(result);

// string[] items = result.Split(',');
// foreach (string item in items)
// {
//     Console.WriteLine(item);
// }





// Array.Reverse(valueArray);
// string result = String.Join(",", valueArray);
// string[] items = result.Split(',');
// char[] valueArray = value.ToCharArray();




// string pangram = "The quick brown fox jumps over the lazy dog";
// string[] items = pangram.Split(" ");
// string[] newPangram = new string[pangram.Length];

// for( int i = 0; i < items.Length; i++){
//   char[] valueArray = items[i].ToCharArray();
//   Array.Reverse(valueArray);
//   string result = new string(valueArray);
//   newPangram[i] = result;
// }

// Console.WriteLine(String.Join(" ", newPangram));






// string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
// string[] newOrderStream = orderStream.Split(",");

// for(int i = 0; i < newOrderStream.Length; i++){
//   char[] singleOrder = newOrderStream[i].ToCharArray();

//   if (singleOrder.Length != 4){
//     Console.WriteLine($"{(newOrderStream[i])}\t - error");
//   } else {
//     Console.WriteLine(newOrderStream[i]);
//   }
// }





// string first = "Hello";
// string second = "World";
// Console.WriteLine("{1} {0}!", first, second);
// Console.WriteLine("{0} {0} {0}!", first, second);



// decimal price = 123.45m;
// int discount = 50;
// Console.WriteLine($"Price: {price:C} (Save {discount:C})");


// decimal measurement = 123456.78912m;
// Console.WriteLine($"Measurement: {measurement:N} units");
// Console.WriteLine($"Measurement: {measurement:N3} units");

// decimal tax = .36785m;
// Console.WriteLine($"Tax rate: {tax:P2}");


// decimal price2 = 67.55m;
// decimal salePrice = 59.99m;

// string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price2 - salePrice), price2);
// Console.WriteLine(yourDiscount);







// int invoiceNumber = 1201;
// decimal productShares = 25.4568m;
// decimal subtotal = 2750.00m;
// decimal taxPercentage = .15825m;
// decimal total = 3185.19m;

// Console.WriteLine($"Invoice Number: {invoiceNumber}");
// Console.WriteLine($"   Shares: {productShares:N3} Product");
// Console.WriteLine($"     Sub Total: {subtotal:C}");
// Console.WriteLine($"           Tax: {taxPercentage:P2}");
// Console.WriteLine($"     Total Billed: {total:C}");








// string diaDeSol = "Dia de ver a mi mujer";

// Console.WriteLine(diaDeSol.PadLeft(30));
// Console.WriteLine(diaDeSol.PadRight(30, '-'));
// Console.WriteLine(diaDeSol.PadLeft(30, '-'));




// string paymentId = "769C";
// string payeeName = "Mr. Stephen Ortega";
// string paymentAmount = "$5,000.00";

// var formattedLine = paymentId.PadRight(6);
// formattedLine += payeeName.PadRight(24);
// formattedLine += paymentAmount.PadLeft(10);

// Console.WriteLine("1234567890123456789012345678901234567890");
// Console.WriteLine(formattedLine);






// string customerName = "Ms. Barros";

// string currentProduct = "Magic Yield";
// int currentShares = 2975000;
// decimal currentReturn = 0.1275m;
// decimal currentProfit = 55000000.0m;

// string newProduct = "Glorious Future";
// decimal newReturn = 0.13125m;
// decimal newProfit = 63000000.0m;

// // Your logic here

// Console.WriteLine($"Dear, {customerName},\nAs a customer of our {currentProduct} offering we are excited to tell you a new finantial product that would dramatically will increase your return.");
// Console.WriteLine($"\nCurrently, you own {currentShares:C} shares at a return of {currentReturn:P}.");
// Console.WriteLine($"\nOur new product, {newProduct} offers a return of {newReturn:P}. Given your current volume, your potencial profit would be {newProfit:C}.");
// Console.WriteLine($"\nHere is a quick comparison:\n");


// string comparisonMessage = currentProduct.PadRight(20) + $"{currentReturn:P}\t  " + $"{currentProfit:C}\n";
// comparisonMessage += newProduct.PadRight(20) + $"{newReturn:P}\t  " + $"{newProfit:C}\n";

// // Your logic here

// Console.WriteLine(comparisonMessage);








// string message = "Find what is (inside the parentheses)";

// int openingPosition = message.IndexOf('(');
// int closingPosition = message.IndexOf(')');

// Console.WriteLine(openingPosition);
// Console.WriteLine(closingPosition);

// openingPosition++;
// int length = closingPosition - openingPosition;

// Console.WriteLine(message.Substring(openingPosition, length));





// string message = "What is the value <span>between the tags</span>?";

// const string openSpan = "<span>";
// const string closeSpan = "</span>";

// int openingPosition = message.IndexOf(openSpan);
// int closingPosition = message.IndexOf(closeSpan);

// openingPosition += openSpan.Length;
// int length = closingPosition - openingPosition;
// Console.WriteLine(message.Substring(openingPosition, length));







// string message = "(What if) I am (only interested) in the last (set of parentheses)?";
// int openingPosition = message.LastIndexOf('(');

// openingPosition += 1;
// int closingPosition = message.LastIndexOf(')');
// int length = closingPosition - openingPosition;
// Console.WriteLine(message.Substring(openingPosition, length));






// string message = "(What if) there are (more than) one (set of parentheses)?";
// while (true)
// {
//     int openingPosition = message.IndexOf('(');
//     if (openingPosition == -1) break;

//     openingPosition += 1;
//     int closingPosition = message.IndexOf(')');
//     int length = closingPosition - openingPosition;
//     Console.WriteLine(message.Substring(openingPosition, length));

//     // Note the overload of the Substring to return only the remaining 
//     // unprocessed message:
//     message = message.Substring(closingPosition + 1);
// }





// string message = "Help (find) the {opening symbols}";
// Console.WriteLine($"Searching THIS Message: {message}");
// char[] openSymbols = { '[', '{', '(' };
// int startPosition = 6;
// int openingPosition = message.IndexOfAny(openSymbols);
// Console.WriteLine($"Found WITHOUT using startPosition: {message.Substring(openingPosition)}");

// openingPosition = message.IndexOfAny(openSymbols, startPosition);
// Console.WriteLine($"Found WITH using startPosition {startPosition}:  {message.Substring(openingPosition)}");






// string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";

// // The IndexOfAny() helper method requires a char array of characters. 
// // You want to look for:

// char[] openSymbols = { '[', '{', '(' };

// // You'll use a slightly different technique for iterating through 
// // the characters in the string. This time, use the closing 
// // position of the previous iteration as the starting index for the 
// //next open symbol. So, you need to initialize the closingPosition 
// // variable to zero:

// int closingPosition = 0;

// while (true)
// {
//     int openingPosition = message.IndexOfAny(openSymbols, closingPosition);

//     if (openingPosition == -1) break;

//     string currentSymbol = message.Substring(openingPosition, 1);

//     // Now  find the matching closing symbol
//     char matchingSymbol = ' ';

//     switch (currentSymbol)
//     {
//         case "[":
//             matchingSymbol = ']';
//             break;
//         case "{":
//             matchingSymbol = '}';
//             break;
//         case "(":
//             matchingSymbol = ')';
//             break;
//     }

//     // To find the closingPosition, use an overload of the IndexOf method to specify 
//     // that the search for the matchingSymbol should start at the openingPosition in the string. 

//     openingPosition += 1;
//     closingPosition = message.IndexOf(matchingSymbol, openingPosition);

//     // Finally, use the techniques you've already learned to display the sub-string:

//     int length = closingPosition - openingPosition;
//     Console.WriteLine(message.Substring(openingPosition, length));
// }













// string data = "12345John Smith          5000  3  ";
// string updatedData = data.Remove(5, 20);
// Console.WriteLine(updatedData);


// string message = "This--is--ex-amp-le--da-ta";
// message = message.Replace("--", " ");
// message = message.Replace("-", "");
// Console.WriteLine(message);










// const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

// string quantity = "";
// string output = "";

// int openSpan = input.IndexOf("<span>");
// openSpan += 6;
// int closeSpan = input.IndexOf("</span>");

// int lenghtQuantity = closeSpan - openSpan;

// quantity = input.Substring(openSpan, lenghtQuantity);

// output = input;
// output = output.Replace("trade", "reg");
// output = output.Replace("<div>", "");
// output = output.Replace("</div>", "");


// // Your work here

// Console.WriteLine($"Quantity: {quantity}");
// Console.WriteLine($"Output: {output}");
// // Quantity: 5000
// // Output: <h2>Widgets &reg;</h2><span>5000</span>





// void Display5RandomNumbers(){
//   Random random = new Random();
//   for(int i = 0; i < 5; i++){
//     Console.WriteLine(random.Next(1,100));
//   }
// }

// Console.WriteLine("Generating random numbers...");
// Display5RandomNumbers();






// using System;

// int[] times = {800, 1200, 1600, 2000};
// int diff = 0;

// Console.WriteLine("Enter current GMT");
// int currentGMT = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Current Medicine Schedule:");

// DisplayTimes();

// Console.WriteLine("Enter new GMT");
// int newGMT = Convert.ToInt32(Console.ReadLine());

// if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
// {
//     Console.WriteLine("Invalid GMT");
// }
// else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0) 
// {
//     diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));

//     AdjustTimes();
// } 
// else 
// {
//     diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));

//     AdjustTimes();
// }

// Console.WriteLine("New Medicine Schedule:");

// DisplayTimes();

// //--------------------------METODOS----------------------------------------------

// void DisplayTimes(){
//   /* Format and display medicine times */
//     foreach (int val in times)
//     {
//         string time = val.ToString();
//         int len = time.Length;

//         if (len >= 3)
//         {
//             time = time.Insert(len - 2, ":");
//         }
//         else if (len == 2)
//         {
//             time = time.Insert(0, "0:");
//         }
//         else
//         {
//             time = time.Insert(0, "0:0");
//         }

//         Console.Write($"{time} ");
//     }

//     Console.WriteLine();
// }

// void AdjustTimes(){
//     /* Adjust the times by adding the difference, keeping the value within 24 hours */
//     for (int i = 0; i < times.Length; i++) 
//     {
//         times[i] = ((times[i] + diff)) % 2400;
//     }
// }






// string[] ipv4Input = {"107.31.1.5", "255.0.0.255", "555..0.555", "255...255"};
// string[] address;
// bool validLength = false;
// bool validZeroes = false;
// bool validRange = false;

// foreach (string ip in ipv4Input) 
// {
//     address = ip.Split(".", StringSplitOptions.RemoveEmptyEntries);

//     ValidateLength(); 
//     ValidateZeroes(); 
//     ValidateRange();

//     if (validLength && validZeroes && validRange) 
//     {
//         Console.WriteLine($"{ip} is a valid IPv4 address");
//     } 
//     else 
//     {
//         Console.WriteLine($"{ip} is an invalid IPv4 address");
//     }
// }

// //----------------------------------------------------------------

// void ValidateLength() 
// {
//     validLength = address.Length == 4;
// };

// void ValidateZeroes() 
// {
//     foreach (string number in address) 
//     {
//         if (number.Length > 1 && number.StartsWith("0")) 
//         {
//             validZeroes = false;
//             return;
//         }
//     }

//     validZeroes = true;
// }

// void ValidateRange() 
// {
//     foreach (string number in address) 
//     {
//         int value = int.Parse(number);
//         if (value < 0 || value > 255) 
//         {
//             validRange = false;
//             return;
//         }
//     }
//     validRange = true;
// }







// void tellFortune (){
//     Random random = new Random();
//     int luck = random.Next(100);

//     string[] text = {"You have much to", "Today is a day to", "Whatever work you do", "This is an ideal time to"};
//     string[] good = {"look forward to.", "try new things!", "is likely to succeed.", "accomplish your dreams!"};
//     string[] bad = {"fear.", "avoid major decisions.", "may have unexpected outcomes.", "re-evaluate your life."};
//     string[] neutral = {"appreciate.", "enjoy time with friends.", "should align with your values.", "get in tune with nature."};

//     Console.WriteLine("A fortune teller whispers the following words:");
//     string[] fortune = (luck > 75 ? good : (luck < 25 ? bad : neutral));
//     for (int i = 0; i < 4; i++) 
//     {
//         Console.Write($"{text[i]} {fortune[i]} ");
//     }
// }

// tellFortune();







// int[] schedule = {800, 1200, 1600, 2000};

// void DisplayAdjustTime(int[] times, int currentGMT, int newGMT){
//     int diff = 0;

//     if(Math.Abs(currentGMT) > 12 || Math.Abs(newGMT) > 12){
//         Console.WriteLine("Invalid IP");
//     } else if (currentGMT >= 0 && newGMT >= 0 || currentGMT <= 0 && newGMT <= 0){
//         diff = 100 * (Math.Abs(currentGMT) - Math.Abs(newGMT));
//     } else {
//         diff = 100 * (Math.Abs(currentGMT) + Math.Abs(newGMT));
//     }

//     for (int i = 0; i < times.Length; i++) 
//     {
//         int newTime = ((times[i] + diff)) % 2400;
//         Console.WriteLine($"{times[i]} -> {newTime}");
//     }
// }

// DisplayAdjustTime(schedule, 6, -6);






// string[] students = {"Jenna", "Ayesha", "Carlos", "Viktor"};

// DisplayStudents(students);
// DisplayStudents(new string[] {"Robert","Vanya"});

// void DisplayStudents(string[] students) 
// {
//     foreach (string student in students) 
//     {
//         Console.Write($"{student}, ");
//     }
//     Console.WriteLine();
// }






// int a = 3;
// int b = 4;
// int c = 0;

// Multiply(a, b, c);
// Console.WriteLine($"global statement: {a} x {b} = {c}");

// void Multiply(int a, int b, int c) 
// {
//     c = a * b;
//     Console.WriteLine($"inside Multiply method: {a} x {b} = {c}");
// }





// string[] guestList = {"Rebecca", "Nadia", "Noor", "Jonte"};
// string[] rsvps = new string[10];
// int count = 0;

// void RSVP(string name, int partySize, string allergies, bool inviteOnly = true) 
// {
//     if (inviteOnly)
//     {
//         // search guestList before adding rsvp
//         bool found = false;
//         foreach (string guest in guestList)
//         {
//             if (guest.Equals(name)) {
//                 found = true;
//                 break;
//             }
//         }
//         if (!found)
//         {
//             Console.WriteLine($"Sorry, {name} is not on the guest list");
//             return;
//         }
//     }

//     rsvps[count] = $"Name: {name}, \tParty Size: {partySize}, \tAllergies: {allergies}";
//     count++;
// }

// void ShowRSVPs()
// {
//     Console.WriteLine("\nTotal RSVPs:");
//     for (int i = 0; i < count; i++)
//     {
//         Console.WriteLine(rsvps[i]);
//     }
// }

// RSVP("Rebecca", 1, "none", true);
// RSVP("Nadia", 2, "Nuts", true);
// RSVP("Linh", 2, "none", inviteOnly:false);
// RSVP("Tony", 1, "Jackfruit", true);
// RSVP("Noor", 4, "none", false);
// RSVP("Jonte", 2, "Stone fruit", false);
// ShowRSVPs();








// string[,] corporate = 
// {
//     {"Robert", "Bavin"}, {"Simon", "Bright"},
//     {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
//     {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
// };

// string[,] external = 
// {
//     {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
//     {"Shay", "Lawrence"}, {"Daren", "Valdes"}
// };

// for (int i = 0; i < corporate.GetLength(0); i++) 
// {
//     ShowEmail(corporate[i, 0], corporate[i, 1],false);
// }

// for (int i = 0; i < external.GetLength(0); i++) 
// {
//         ShowEmail(external[i, 0], external[i, 1]);
// }

// void ShowEmail(string name, string surname, bool isExternal = true){
//     string email = "";
//     if (isExternal){
//         email = name.ToLower().Substring(0,2) + surname.ToLower() + "@hayworth.com";
//     } else {
//         email = name.ToLower().Substring(0,2) + surname.ToLower() + "@contoso.com";
//     }

//     Console.WriteLine($"{(name)} {(surname)}:\t {email}");
// }






// double total = 0;
// double minimumSpend = 30.00;

// double[] items = {15.97, 3.50, 12.25, 22.99, 10.98};
// double[] discounts = {0.30, 0.00, 0.10, 0.20, 0.50};

// for (int i = 0; i < items.Length; i++)
// {
//     total += GetDiscountedPrice(i);
// }

// total -= TotalMeetsMinimum() ? 5.00 : 0.00;

// Console.WriteLine($"Total: ${FormatDecimal(total)}");

// double GetDiscountedPrice(int itemIndex)
// {
//     // Calculate the discounted price of the item
//     return items[itemIndex] * (1 - discounts[itemIndex]);
// }

// bool TotalMeetsMinimum()
// {
//     // Check if the total meets the minimum
//     return total >= minimumSpend;
// }

// string FormatDecimal(double input)
// {
//     return input.ToString().Substring(0, 5);
// }






// double usd = 23.73;
// int vnd = UsdToVnd(usd);

// Console.WriteLine($"${usd} USD = ${vnd} VND");
// Console.WriteLine($"${vnd} VND = ${VndToUsd(vnd)} USD");

// int UsdToVnd(double usd) 
// {
//     int rate = 23500;
//     return (int) (rate * usd);
// }

// double VndToUsd(int vnd) 
// {
//     double rate = 23500;
//     return vnd / rate;
// }





// string input = "snake";
// string message = "todas son iguales";

// Console.WriteLine(input);
// Console.WriteLine(ReverseWord(input));
// Console.WriteLine(ReverseSentence(message));
// Console.WriteLine(ReverseSentence(input));



// string ReverseWord(string word) 
// {
//     string result = "";
//     for (int i = word.Length - 1; i >= 0; i--) 
//     {
//         result += word[i];
//     }
//     return result;
// }

// string ReverseSentence(string input) 
// {
//     string result = "";
//     string[] words = input.Split(" ");

//     foreach(string word in words) 
//     {
//         result += ReverseWord(word) + " ";
//     }

//     return result;
// }




// int target = 60;
// int[] coins = new int[] {5, 5, 50, 25, 25, 10, 5};
// int[] result = TwoCoins(coins, target);

// if (result.Length == 0) 
// {
//     Console.WriteLine("No two coins make change");
// } 
// else 
// {
//     Console.WriteLine($"Change found at positions {result[0]} and {result[1]}");

// }

// int[] TwoCoins(int[] coins, int target) 
// {
//     for (int curr = 0; curr < coins.Length; curr++) 
//     {
//         for (int next = curr + 1; next < coins.Length; next++) 
//         {
//             if (coins[curr] + coins[next] == target) 
//             {
//                 return new int[]{curr, next};
//             }

//         }
//     }

//     return  new int[0];
// }


// int target = 30;
// int[] coins = new int[] {5, 5, 50, 25, 25, 10, 5};
// int[,] result = MoreCoins(coins, target);

// if (result.Length == 0) 
// {
//     Console.WriteLine("No two coins make change");
// } 
// else 
// {
//     Console.WriteLine("Change found at positions:");
//     for (int i = 0; i < result.GetLength(0); i++) 
//     {
//         if (result[i,0] == -1) 
//         {
//             break;
//         }
//         Console.WriteLine($"{result[i,0]},{result[i,1]}");
//     }
// }

// int[,] MoreCoins(int[] coins, int target)
// {
//     int[,] result = {{-1,-1},{-1,-1},{-1,-1},{-1,-1},{-1,-1}};
//     int count = 0;

//     for (int curr = 0; curr < coins.Length; curr++) 
//     {
//         for (int next = curr + 1; next < coins.Length; next++) 
//         {
//             if (coins[curr] + coins[next] == target) 
//             {
//                 result[count, 0] = curr;
//                 result[count, 1] = next;
//                 count++;
//             }
//             if (count == result.GetLength(0)) 
//             {
//                 return result;
//             }
//         }
//     }
//     return count == 0 ? new int[0,0] : result;
// }





// Random random = new Random();

// Console.WriteLine("Would you like to play? (Y/N)");
// if (ShouldPlay()) 
// {
//     PlayGame();
// }

// void PlayGame() 
// {
//     var play = true;

//     while (play) 
//     {
//         var target = random.Next(1,6);
//         var roll = random.Next(1,7);

//         Console.WriteLine($"Roll a number greater than {target} to win!");
//         Console.WriteLine($"You rolled a {roll}");
//         Console.WriteLine(WinOrLose(target, roll));
//         Console.WriteLine("\nPlay again? (Y/N)");

//         play = ShouldPlay();
//     }
// }


// bool ShouldPlay(){
//     string? keepPlaying = Console.ReadLine();
//     return keepPlaying == "Y" ? true: false;
// }

// string WinOrLose(int target, int roll){
//     return (roll > target) ? "Has ganado :)" : "Has perdido :(";
// }




//CONTOSO ZOO
using System;

string[] pettingZoo = 
{
    "alpacas", "capybaras", "chickens", "ducks", "emus", "geese", 
    "goats", "iguanas", "kangaroos", "lemurs", "llamas", "macaws", 
    "ostriches", "pigs", "ponies", "rabbits", "sheep", "tortoises",
};

PlanSchoolVisit("School A");
PlanSchoolVisit("School B", 3);
PlanSchoolVisit("School C", 2);


// ---------------------------------------------------------------------

void PlanSchoolVisit(string schoolName, int groups = 6)
{
    RandomizeAnimals();
    string[,] group = AssignGroup(groups);
    Console.WriteLine(schoolName);
    PrintGroup(group);
}

void RandomizeAnimals(){
    Random random = new Random();

    for (int i = 0; i < pettingZoo.Length; i++) 
    {
        int r = random.Next(pettingZoo.Length);

        string temp = pettingZoo[i];
        pettingZoo[i] = pettingZoo[r];
        pettingZoo[r] = temp;
    }

}

string[,] AssignGroup(int groups = 6){
    string[,] result = new string[groups, pettingZoo.Length/groups];
    int start = 0;

    for (int i = 0; i < groups; i++) 
    {
        for (int j = 0; j < result.GetLength(1); j++) 
        {
            result[i,j] = pettingZoo[start++];
        }
    }

    return result;
}

void PrintGroup(string[,] group) 
{
    for (int i = 0; i < group.GetLength(0); i++) 
    {
        Console.Write($"Group {i + 1}: ");
        for (int j = 0; j < group.GetLength(1); j++) 
        {
            Console.Write($"{group[i,j]}  ");
        }
        Console.WriteLine();
    }
}
