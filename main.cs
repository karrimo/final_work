using System;
     
public class Program
{
 public static void Main()
 {
  string[] array = {"Hello", "World","my", "name", "is","Karina"};
  int index = 0;
  int count = 0;
  
  while(index < array.Length) {
   if(array[index].Length <= 3) {
    count++;
   }
   
   index++;
  }
  
  string[] finalArray = new string[count];
  index = 0;
   
  while(index < array.Length) {
   if(array[index].Length <= 3) {
    count--;
    finalArray[count] = array[index];
   }
   
   index++;
  }
  
  foreach (var item in finalArray) {
    Console.WriteLine(item);
  }
 }
}