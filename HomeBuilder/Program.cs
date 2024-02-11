// See https://aka.ms/new-console-template for more information
using HomeBuilder;
using HomeBuilder.Builder;

HouseBuilder builder;

Console.WriteLine("Select house to build: \n1-Basic house\n2-Family house\n3-Luxury house");
int houseType = int.Parse(Console.ReadLine());

switch (houseType)
{
    case 1:
        builder = new BasicHomeBuilder();
        break;
    case 2:
        builder = new FamilyHomeBuilder();
        break;
    case 3:
        builder = new FancyHomeBuilder();
        break;
    default:
        throw new Exception("Not available house type");
}

Engineer engineer = new Engineer();
engineer.Build(builder);

Console.WriteLine(builder.GetBuiltHouse()); 