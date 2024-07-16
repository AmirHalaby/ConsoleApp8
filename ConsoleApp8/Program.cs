

using ConsoleApp8;
using System.Security.Cryptography.X509Certificates;

//Exercise 1

string[] balls = { "Green", "Yellow", "Red", "Yellow", "Green", "Red", "Green", "Red", "Green" };

SortArrayByColor.SortArray(balls);


//Exercise 2

List<Song> songs = new List<Song>();

songs.Add(new Song("Amir"));
songs.Add(new Song("Halaby"));
songs.Add(new Song("rEEMA"));
songs.Add(new Song("Kamal"));
songs.Add(new Song("Amin"));
songs.Add(new Song("Wazira"));
songs.Add(new Song("Adham"));
songs.Add(new Song("Enbal"));
songs.Add(new Song("Dan"));
songs.Add(new Song("Lana"));

Songs.GetRandomSongList(songs);


//Exercise 3


Expression.ValidationExpression(null);
Expression.ValidationExpression("");
Expression.ValidationExpression("{Am[ir|{Ha}|[|laby|51]4]}");
Expression.ValidationExpression("{Amir}|457|x|556|123||");
Expression.ValidationExpression("{4[i{|H{a}|464}5[5|l|5]14]}");

Expression.ValidationExpression("{Am[ir|{H|a}|[|laby|514}");
Expression.ValidationExpression("{Amir}|457||x|556|123||");
Expression.ValidationExpression("{4[i{|H{a}|4|64}5[5|l|5]14]}");

//Exercise 4


var ourDic = new DictionaryImplementation<int, string>();

for (int i = 0; i < 10; i++)
{
    ourDic.Set(i + 1, "Amir" + (i + 1).ToString());
}

var y1 = ourDic.Get(2);
var y2 = ourDic.Get(3);
var y3 = ourDic.Get(4);
var y4 = ourDic.Get(5);
var y5 = ourDic.Get(6);

ourDic.SetAll("Reema");


//Exercise 5

List<People> people = new List<People>();
people.Add(new People("Amir"));
people.Add(new People("Moshe"));

FindFiveMethod.findfive(people);
