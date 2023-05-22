# Библиотека расчета площади фигур 

Эта библиотека предоставляет классы для расчета площади круга по радиусу и треугольника по трем сторонам.

## Как установить

Для установки этой библиотеки необходимо выполнить следующие шаги:

1. Скачайте исходный код с репозитория на GitHub.
2. Разархивируйте архив с исходным кодом.
3. Выполните команду "dotnet add <"Путь до папки с репозиторием" + CalculationFigures\bin\Debug\CalculationFigures.1.0.0.nupkg>", чтобы добавить источник NuGet пакетов.

### Расчет площади круга

Для расчета площади круга необходимо создать обьект типа Circle и использовать метод Area().

```
IFigure circle = new Circle(10);
double result = circle.Area();
Console.WriteLine(result);
```

### Расчет площади прямоугольника 

Для расчета площади прямоугольника необходимо создать обьект типа Triangle и использовать метод Area().
Также с помощью метода IsRightTriangle() можно произвести проверку на прямоугольность треугольника.

```
ITriangle figure = new Triangle(5, 5, 5);
double result = figure.Area();
Console.WriteLine(result);
```

```
ITriangle figure = new Triangle(5, 4, 3);
bool isRightTriangle = figure.IsRightTriangle();

if (isRightTriangle)
{
    Console.WriteLine("Треугольник прямоугольный");
}
else
{
    Console.WriteLine("Треугольник не прямоугольный");
}
```