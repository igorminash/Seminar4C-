int [] array = new int [8];
Massive(array);
Console.WriteLine($"[{String.Join(",", array)}]");

int [] Massive (int [] arr){
    for(int i=0; i < arr.Length; i++){
    arr[i] = new Random().Next(0,11);
    }
    return arr;
}  