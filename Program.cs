using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Definiranje klasa i prava pristupa. Konstruktori. Varijabilni broj argumenata. Statičke metode i varijable. U bilo kojem zadatku možete napisati dodatne privatne metode po potrebi. 
 * 
 1. Napravite klasu FoodType koja ima sljedeće javne atribute: name (String), protein
(int), carbs (int), fat (int). Atributi protein, carbs i fat su postoci.

2. Promijenite klasu FoodType tako da su atributi privatni. Dodajte klasi konstruktor
koji prima kao parametre sve vrijednosti za atribute. Napravite get metode za svaki
atribut. 

3. Dodajte u klasi FoodType javnu metodu toString koja nema argumenata, a vraća
String koji predstavlja objekt. Ako atributi imaju vrijednost: name=banana, protein=4, carbs=93, fat=3 onda je String koji se vraća: "banana: p - 4%, c - 93%, f - 3%". 

4. Napravite statičku varijablu counter koja sadrži broj kreiranih objekata iz klase
FoodType. Varijabla counter prilikom deklaracije postavlja vrijednost 0, a u
konstruktoru se povećava za jedan. Napravite statičku metodu
getNumberOfCreatedInstances koja vraća counter.

5. Napravite klasu Food koja ima dva atributa: type (FoodType), weight(int). Težina je
u gramima. Napravite konstruktor sa svim atributima te dodajte get metode i metodu
toString koja nema argumenata i vraća String koji predstavlja objekt u sljedećem
formatu: "banana: p - 4%, c - 93%, f - 3%, w – 110g". 

6. Dodajte u klasu Food get metode za protein, carbs i fat, ali tako da vraćaju te
vrijednosti u gramima (double), a ne u postocima kako je zapisano u klasi FoodType. Npr. sljedeći isječak:
FoodType foodType = new FoodType("banana", 4, 93, 3);
Food food = new Food(foodType, 110);
System.out.println("protein: " + food.getProtein() + "\ncarbs: " +
food.getCarbs() + "\nfat: " + food.getFat());
će ispisati:
protein: 4.4
carbs: 102.3
fat: 3.3

7. Dodajte u klasu Food javnu metodu sa sljedećim potpisom String
toStringInGrams() koja predstavlja objekt u formatu: "banana: p – 4.4g, c – 102.3g, f – 3.3g, w – 110g ". Brojevi s decimalnom točkom se trebaju ispisivati na jednu
decimalu
.*/
namespace Ponavljanje
{
    class Food
        {
        
        FoodType type;
        int weight;

        public Food(FoodType type, int weight)
        {
            this.type = type;
            this.weight = weight;
        }

        public int Weight { get => weight; set => weight = value; }
        internal FoodType Type { get => type; set => type = value; }

        public override string ToString()
        {
            return type + "; w - " + weight + "g";
        }

        public double getProtein()
        {
            return type.Protein / 100.0 * weight;
        }

        public double getCarbs()
        {
            return type.Carbs / 100.0 * weight;
        }
        public double getFat()
        {
            return type.Fat / 100.0 * weight;
        }


          public string ToStringInGrams()
          {
              return type.Name + ": p - " + Math.Round(getProtein(),1) + "g, c - " + Math.Round(getCarbs(), 1) + "g, f - " + Math.Round(getFat(), 1);
          }
        
    }
    class FoodType
    {
       private string name;
        private int protein, carbs, fat;

        public FoodType(string name, int protein, int carbs, int fat)
        {
            this.name = name;
            this.protein = protein;
            this.carbs = carbs;
            this.fat = fat;
            counter++;
        }

        public string Name { get => name; set => name = value; }
        public int Protein { get => protein; set => protein = value; }
        public int Carbs { get => carbs; set => carbs = value; }
        public int Fat { get => fat; set => fat = value; }
         
        public override string ToString()
        {
            return  name + ": " + "p - " + Protein + "% " + "c - " + Carbs + "%" + " f - "+Fat + "%";
        }

        static int counter = 0;
       

        static int getNumberOfInstances()
        {
           return counter;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
