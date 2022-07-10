 int[] a = RandomArray();
 System.Console.WriteLine(a);
 TossCoin();

 double  result = TossMultipleCoins(5);
 System.Console.WriteLine(result);

 static int[] RandomArray(){
    int [] newarr = new int [9];
    Random rand = new Random();
    for (int i = 0; i < newarr.Length; i++){
        newarr[i] = rand.Next(5, 25);
    }
    int max = newarr[0];
    int min = newarr[0];
    int sum = 0;
    for (int i = 0; i < newarr.Length; i++){
        if(newarr[i]>max){
            max=newarr[i];
        }
    }
    System.Console.WriteLine("The maximum value in array is " + max);

    for (int i = 0; i < newarr.Length; i++){
        if(newarr[i]<min){
            min=newarr[i];
        }
    }
    System.Console.WriteLine("The minimum value in array is " + min);

    for (int i = 0; i<newarr.Length; i++){
        sum+=newarr[i];
    }
    System.Console.WriteLine("The sum of all the values in array is " + sum);
    

return newarr;
}
///////////////////////////////////////////////////

static string TossCoin(){
    System.Console.WriteLine("Tossing a Coin!");
    Random rand =  new Random();
    string[] coin = {"Head", "Tails"};
    string headOrTails = coin[ rand.Next(0, coin.Length)];
    System.Console.WriteLine(headOrTails);
    return headOrTails;
}
///////////////////////////////////////////////

static double TossMultipleCoins(int num){
    int count = 0;
    for (int i = 1; i<=num; i++){
        string b = TossCoin();
        if(b == "Head"){
            count += 1;
        }
    }
    double result = (double) count/num;   
return result; 
}

 List <string> names = new List<string> () {"Todd", "Tiffany", "Charlie", "Geneva", "Sydney"};
 List <string> newNames = new List<string> ();
 foreach(string name in names){
    if (name.Length>5){
        newNames.Add(name);
    }
 }
 
