


static void Main(string[] args){
System.Console.WriteLine("Yapmak istediğiniz işlemi seçiniz : ");
int islem = Convert.ToChar(Console.ReadLine());
System.Console.WriteLine("Hesaplamak istediğiniz ilk sayıyı giriniz : ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Hesaplamak istediğiniz ikinci sayıyı giriniz : ");
int b = Convert.ToInt32(Console.ReadLine());
if(islem == '+'){
    System.Console.WriteLine(a+b);;
}
else if(islem == '-'){
    System.Console.WriteLine(a-b);
}
else if(islem == '*'){
    System.Console.WriteLine(a*b);
}
else if(islem == '/'){
    System.Console.WriteLine(a/b);
 }
}


