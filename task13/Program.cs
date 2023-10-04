// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


Console.Write("Введи число: ");
int Num = Convert.ToInt32(Console.ReadLine());
string NumToStr = Convert.ToString(Num);
if (NumToStr.Length > 2){
  Console.WriteLine("Третья цифра = " + NumToStr[2]);
}
else {
  Console.WriteLine("Третьей цифры нет");
}