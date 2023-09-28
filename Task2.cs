string[] array = {"Murad","Ali", "Adil", "Nur", "Abdulmehmed", "Aga"};
bool isExist=false;

for (int i = 0; i < array.Length; i++)
{
     if (array[i].Length <4)
     {
         isExist = true;
         Console.WriteLine(array[i]);
     }
}
if (isExist == false)
{
    Console.WriteLine("All the names legth is higher than 4");
}
