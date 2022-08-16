Console.Write("Введите число: ");
int chislo = Convert.ToInt32(Console.ReadLine());
string number = Convert.ToString(chislo);
if (number.Length > 2){
  Console.WriteLine(number[0]);
}
else {
  Console.WriteLine("третьей цифры нет");
}
