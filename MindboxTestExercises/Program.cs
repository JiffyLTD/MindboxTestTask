using Figures;//Библиотека классов в которой описаны методы с которыми мы работаем

internal class Program
{
    private static void Main(string[] args)
    {
        //Вопрос 2: Напишите на C# библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам.
        //Круги
        Circle first = new(2); // Работаем с экземплярами классов
        Circle second = new(2.33);
        Circle third = new();

        double firstCircle = first.Area();

        double secondCircle = second.Area();

        third.R = 3.14;

        double thirdCircle = third.Area();

        Console.WriteLine($"Площадь первого круга : {Math.Round(firstCircle, 2)}" +
            $"\nПлощадь второго круга : {secondCircle}\n" +
            $"Площадь третьего круга : {thirdCircle}\n");

        //Треугольники
        double firstTriangle = Triangle.Area(2, 3, 4); // Работаем со статичными методами класса

        double secondTriangle = Triangle.Area(2.1, 3.2, 4.3);

        bool thirdTriangle = Triangle.IsItRectangular(3, 4, 5);

        bool fourthTriangle = Triangle.IsItRectangular(2.1, 3.2, 4.3);

        Console.WriteLine($"Площадь первого треугольника: {Math.Round(firstTriangle, 3)}\n" +
            $"Площадь второго треугольника: {secondTriangle}\n");

        Console.WriteLine($"Третий треугольник прямоугольный? - : {thirdTriangle}\n" +
           $"Четвертый треугольник прямоугольный? - : {fourthTriangle}\n");

        Console.ReadLine();

        /*Вопрос 3: В базе данных MS SQL Server есть продукты и категории. 
         * Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов.
         * Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.
        */

        // Создание таблиц и их заполнение
        /*
            create table Category
            (
	            CategoryId int identity(1,1) primary key,
	            categoryName varchar(50)
            );
            create table Product
            (
	            ProductId int identity(1,1) primary key,
	            productName varchar(50)
            );
            create table ProductsAndCategoriesList
            (
	            id int identity(1,1),
	            ProductId int references Product (ProductId),
	            CategoryId int references Category (CategoryId)
            );

            insert into Category values ('Напитки');
            insert into Category values ('Кисломолочные продукты');

            insert into Product values ('Молоко');
            insert into Product values ('Квас');
            insert into Product values ('Хлеб');

            insert into ProductsAndCategoriesList values (1,1);
            insert into ProductsAndCategoriesList values (1,2);
            insert into ProductsAndCategoriesList values (2,1);
            insert into ProductsAndCategoriesList values (3, null);
        */

        //САМ ЗАПРОС
        /*
            select p.productName, c.categoryName  from Product p
            join ProductsAndCategoriesList pc on pc.ProductId = p.ProductId  
            left join Category c on pc.CategoryId = c.CategoryId ;
        */

        //ВЫВОД 
        /*
           Молоко - Напитки
           Молоко - Кисломолочные продукты
           Квас - Напитки
           Хлеб - NULL
       */
    }
}


