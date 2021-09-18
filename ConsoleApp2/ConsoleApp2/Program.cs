using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //s1.1
            Console.WriteLine("S1.1");
            double a = 1.36;
            Console.WriteLine(a);
            //s1.2
            Console.WriteLine("S1.2");
            double e = 2.7;
            Console.WriteLine(e);
            //s1.3
            Console.WriteLine("S1.3");
            string j;
            j = Console.ReadLine();
            Console.WriteLine("Вы ввели число " + j);
            //s1.4
            Console.WriteLine("S1.4");
            string y;
            y = Console.ReadLine();
            Console.WriteLine(y + " - вот какое число Вы ввели");
            //s1.5
            Console.WriteLine("S1.5");
            Console.WriteLine("1 " + "13 " + "49");
            //s1.6
            Console.WriteLine("S1.6");
            Console.WriteLine("7  " + "15  " + "100");
            //s1.7
            Console.WriteLine("S1.7");
            Console.WriteLine("23  " + "135  " + "115");
            //s1.8
            Console.WriteLine("S1.8");
            Console.WriteLine("27 " + "13 " + "15 " + "84");
            //s1.9
            Console.WriteLine("S1.9");
            Console.WriteLine("50");
            Console.WriteLine("10");
            //s1.10
            Console.WriteLine("S1.10");
            Console.WriteLine("5");
            Console.WriteLine("10");
            Console.WriteLine("21");
            //s1.11
            Console.WriteLine("S1.11");
            Console.WriteLine("3");
            Console.WriteLine("14");
            Console.WriteLine("26");
            Console.WriteLine("45");
            //s1.12
            Console.WriteLine("S1.12");
            Console.WriteLine("5 10");
            Console.WriteLine("7 см");
            //s1.13
            Console.WriteLine("S1.13");
            Console.WriteLine("2 кг");
            Console.WriteLine("13 17");
            //s2.1a
            Console.WriteLine("S2.1a");
            string h = Console.ReadLine();
            int x = Convert.ToInt32(h);
            int t = 7 * x * x + 3 * x + 6;
            Console.WriteLine(t);
            //s2.1b
            Console.WriteLine("S2.1b");
            string b = Console.ReadLine();
            int q = Convert.ToInt32(b);
            int i = 12 * q * q + 7 * q + 12;
            Console.WriteLine(i);
            //s2.2
            Console.WriteLine("S2.2");
            b = Console.ReadLine();
            int ab = Convert.ToInt32(b);
            int S = 4 * ab;
            Console.WriteLine(S);
            //s2.3
            Console.WriteLine("S2.3");
            string ba = Console.ReadLine();
            int o = Convert.ToInt32(ba);
            int d = 2 * o;
            Console.WriteLine(d);
            //s2.4
            Console.WriteLine("S2.4");
            int r = 6350;
            Console.WriteLine("Высота: ");
            string b1 = Console.ReadLine();
            int h1 = Convert.ToInt32(b1);
            Console.WriteLine("Расстояние до горизонта: " + Math.Sqrt((r + h1) * (r + h1) - r * r));
            //s2.5
            Console.WriteLine("S2.5");
            Console.WriteLine("Длина ребра куба:");
            string b2 = Console.ReadLine();
            int a1 = Convert.ToInt32(b2);
            Console.WriteLine("Объём куба: " + a1 * a1 * a1);
            Console.WriteLine("Площадь боковой поверхности: " + 4 * a1 * a1);
            //s2.6
            Console.WriteLine("S2.6");
            Console.WriteLine("Радиус окружности:");
            string b3 = Console.ReadLine();
            int r1 = Convert.ToInt32(b3);
            Console.WriteLine("Длина окружности: " + 2 * r1 * Math.PI);
            Console.WriteLine("Площадь круга: " + Math.PI * r1 * r1);
            //s2.7
            Console.WriteLine("S2.7");
            Console.WriteLine("Число 1:");
            string c = Console.ReadLine();
            int d1 = Convert.ToInt32(c);
            Console.WriteLine("Число 2:");
            string b4 = Console.ReadLine();
            int a3 = Convert.ToInt32(b4);
            Console.WriteLine("Среднее арифметическое: " + (double)(d1 + a3) / 2);
            Console.WriteLine("Среднее геометрическое: " + Math.Sqrt(d1 * a3));
            //s2.8
            Console.WriteLine("S2.8");
            Console.WriteLine("Масса (кг):");
            string a4 = Console.ReadLine();
            int m = Convert.ToInt32(a4);
            Console.WriteLine("Объём (м^3):");
            string b5 = Console.ReadLine();
            int v = Convert.ToInt32(b5);
            Console.WriteLine("Плотность (кг/м^3): " + (double)m / v);
            //s2.9
            Console.WriteLine("S2.9");
            Console.WriteLine("Количество жителей:");
            string a5 = Console.ReadLine();
            int m1 = Convert.ToInt32(a5);
            Console.WriteLine("Площадь государства:");
            string b6 = Console.ReadLine();
            int s = Convert.ToInt32(b6);
            Console.WriteLine("Плотность населения: " + (double)m1 / s);
            //s2.10
            Console.WriteLine("S2.10");
            Console.WriteLine("Коэффициент a:");
            string c1 = Console.ReadLine();
            if (c1 != "0")
            {
                int a_7 = Convert.ToInt32(c1);
                Console.WriteLine("Свободный член b:");
                string d_4 = Console.ReadLine();
                int b_7 = Convert.ToInt32(d_4);
                Console.WriteLine("Решение уравнения ax+b=0: " + (double)-b_7 / a_7);
            }
            else
            {
                Console.WriteLine("Коэффициент a не может быть равен 0, введите другое значение");
            }
            //s2.11
            Console.WriteLine("S2.11");
            Console.WriteLine("Катет 1:");
            string c2 = Console.ReadLine();
            int a6 = Convert.ToInt32(c2);
            Console.WriteLine("Катет 2:");
            string d2 = Console.ReadLine();
            int b7 = Convert.ToInt32(d2);
            Console.WriteLine("Гипотенуза: " + Math.Sqrt(a6 * a6 + b7 * b7));
            //s2.12
            Console.WriteLine("S2.12");
            Console.WriteLine("Внешний радиус:");
            string c3 = Console.ReadLine();
            int a7 = Convert.ToInt32(c3);
            Console.WriteLine("Внутренний радиус:");
            string d3 = Console.ReadLine();
            int b8 = Convert.ToInt32(d3);
            Console.WriteLine("Площадь кольца: " + Math.PI * (a7 * a7 - b8 * b8));
            //s2.13
            Console.WriteLine("S2.13");
            Console.WriteLine("Катет 1:");
            string c4 = Console.ReadLine();
            int a8 = Convert.ToInt32(c4);
            Console.WriteLine("Катет 2:");
            string d4 = Console.ReadLine();
            int b9 = Convert.ToInt32(d4);
            double g = Math.Sqrt(a8 * a8 + b9 * b9);
            Console.WriteLine("Периметр прямоугольного треугольника: " + (Math.Sqrt(a8 * a8 + b9 * b9) + a8 + b9));
            //s2.13a
            Console.WriteLine("S2.13a");
            Console.WriteLine("Число 1:");
            string c5 = Console.ReadLine();
            int a9 = Convert.ToInt32(c5);
            Console.WriteLine("Число 2:");
            string d5 = Console.ReadLine();
            int b10 = Convert.ToInt32(d5);
            Console.WriteLine("Среднее арифметическое модулей: " + ((double)(Math.Abs(a9) + Math.Abs(b10)) / 2));
            Console.WriteLine("Среднее геометрическое модулей: " + Math.Sqrt(Math.Abs(a9) * Math.Abs(b10)));
            //s2.14
            Console.WriteLine("S2.14");
            Console.WriteLine("Основание 1:");
            string c6 = Console.ReadLine();
            int a10 = Convert.ToInt32(c6);
            Console.WriteLine("Основание 2:");
            string d6 = Console.ReadLine();
            int b11 = Convert.ToInt32(d6);
            Console.WriteLine("Высота:");
            string f = Console.ReadLine();
            int h2 = Convert.ToInt32(f);
            double side = Math.Sqrt(Math.Abs(a10 - b11) * Math.Abs(a10 - b11) + h2 * h2);
            Console.WriteLine("Периметр трапеции: " + (2 * side + a10 + b11));
            //s2.14a
            Console.WriteLine("S2.14a");
            Console.WriteLine("Сторона 1:");
            string c7 = Console.ReadLine();
            int a12 = Convert.ToInt32(c7);
            Console.WriteLine("Сторона 2:");
            string d7 = Console.ReadLine();
            int b12 = Convert.ToInt32(d7);
            Console.WriteLine("Периметр прямоугольника: " + (2 * a12 + 2 * b12));
            Console.WriteLine("Длина диагонали прямоугольника: " + Math.Sqrt(a12 * a12 + b12 * b12));
            //s2.15
            Console.WriteLine("S2.15");
            Console.WriteLine("Число 1:");
            string c8 = Console.ReadLine();
            int a13 = Convert.ToInt32(c8);
            Console.WriteLine("Число 2:");
            string d8 = Console.ReadLine();
            int b13 = Convert.ToInt32(d8);
            Console.WriteLine("Сумма чисел: " + (a13 + b13));
            Console.WriteLine("Разность чисел: " + (a13 - b13));
            Console.WriteLine("Произведение чисел: " + (a13 * b13));
            Console.WriteLine("Частное от деления числа 1 на число 2: " + (double)a13 / b13);
            //s2.16
            Console.WriteLine("S2.16");
            Console.WriteLine("Сторона 1:");
            string f1 = Console.ReadLine();
            int a14 = Convert.ToInt32(f1);
            Console.WriteLine("Сторона 2:");
            string d9 = Console.ReadLine();
            int b14 = Convert.ToInt32(d9);
            Console.WriteLine("Сторона 3:");
            string g1 = Console.ReadLine();
            int c9 = Convert.ToInt32(g1);
            Console.WriteLine("Объём параллелепипеда: " + (a14 * b14 * c9));
            Console.WriteLine("Площадь боковой поверхности: " + (2 * a14 * c9 + 2 * b14 * c9));
            //s2.17
            Console.WriteLine("S2.17");
            Console.WriteLine("Координаты точки 1 по оси абсцисс:");
            string f2 = Console.ReadLine();
            int x1 = Convert.ToInt32(f2);
            Console.WriteLine("Координаты точки 1 по оси ординат:");
            string d10 = Console.ReadLine();
            int y1 = Convert.ToInt32(d10);
            Console.WriteLine("Координаты точки 2 по оси абсцисс:");
            string c10 = Console.ReadLine();
            int x2 = Convert.ToInt32(c10);
            Console.WriteLine("Координаты точки 2 по оси ординат:");
            string g2 = Console.ReadLine();
            int y2 = Convert.ToInt32(g2);
            Console.WriteLine("Расстояние между точками: " + Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1)));
            //s2.18
            Console.WriteLine("S2.18");
            Console.WriteLine("Основание 1:");
            string c11 = Console.ReadLine();
            int a15 = Convert.ToInt32(c11);
            Console.WriteLine("Основание 2:");
            string d11 = Console.ReadLine();
            int b15 = Convert.ToInt32(d11);
            Console.WriteLine("Высота:");
            string f3 = Console.ReadLine();
            int h3 = Convert.ToInt32(f3);
            double side1 = Math.Sqrt(Math.Abs(a15 - b15) * Math.Abs(a15 - b15) + h3 * h3);
            Console.WriteLine("Периметр трапеции: " + (2 * side1 + a15 + b));
            //s2.19
            Console.WriteLine("S2.19");
            Console.WriteLine("Меньшее основание:");
            string c12 = Console.ReadLine();
            int a16 = Convert.ToInt32(c12);
            Console.WriteLine("Большое основание:");
            string d12 = Console.ReadLine();
            int b16 = Convert.ToInt32(d12);
            Console.WriteLine("Меньший угол:");
            string f4 = Console.ReadLine();
            int angle = Convert.ToInt32(f4);
            double side2 = Math.Abs(a16 - b16) * (double)1 / Math.Cos(angle * Math.PI / 180);
            Console.WriteLine(Math.Sin(angle * Math.PI / 180));
            Console.WriteLine("Площадь трапеции: " + (side2 * b16 * Math.Sin(angle * Math.PI / 180)));
            //s2.20
            Console.WriteLine("S2.20");
            Console.WriteLine("Координаты вершины 1(x):");
            string n1 = Console.ReadLine();
            int v1_x = Convert.ToInt32(n1);
            Console.WriteLine("Координаты вершины 1(y):");
            string n2 = Console.ReadLine();
            int v1_y = Convert.ToInt32(n2);
            Console.WriteLine("Координаты вершины 2(x):");
            string n3 = Console.ReadLine();
            int v2_x = Convert.ToInt32(n3);
            Console.WriteLine("Координаты вершины 2(y):");
            string n4 = Console.ReadLine();
            int v2_y = Convert.ToInt32(n4);
            Console.WriteLine("Координаты вершины 3(x):");
            string n5 = Console.ReadLine();
            int v3_x = Convert.ToInt32(n5);
            Console.WriteLine("Координаты вершины 3(y):");
            string n6 = Console.ReadLine();
            int v3_y = Convert.ToInt32(n6);
            double dis1 = Math.Sqrt((Math.Abs(v2_x - v1_x)) * (Math.Abs(v2_x - v1_x)) + (Math.Abs(v2_y - v1_y)) * (Math.Abs(v2_y - v1_y)));
            double dis2 = Math.Sqrt((Math.Abs(v3_x - v1_x)) * (Math.Abs(v3_x - v1_x)) + (Math.Abs(v3_y - v1_y)) * (Math.Abs(v3_y - v1_y)));
            double dis3 = Math.Sqrt((Math.Abs(v3_x - v2_x)) * (Math.Abs(v3_x - v2_x)) + (Math.Abs(v3_y - v2_y)) * (Math.Abs(v3_y - v2_y)));
            double p = (dis1 + dis2 + dis3) / 2;
            Console.WriteLine("Периметр треугольника: " + (2 * p));
            Console.WriteLine("Площадь треугольника: " + (Math.Sqrt(p * (p - dis1) * (p - dis2) * (p - dis3))));
            //s2.21
            Console.WriteLine("S2.21");
            Console.WriteLine("Координаты вершины 1(x):");
            string k1 = Console.ReadLine();
            int ve1_x = Convert.ToInt32(k1);
            Console.WriteLine("Координаты вершины 1(y):");
            string k2 = Console.ReadLine();
            int ve1_y = Convert.ToInt32(k2);
            Console.WriteLine("Координаты вершины 2(x):");
            string k3 = Console.ReadLine();
            int ve2_x = Convert.ToInt32(k3);
            Console.WriteLine("Координаты вершины 2(y):");
            string k4 = Console.ReadLine();
            int ve2_y = Convert.ToInt32(k4);
            Console.WriteLine("Координаты вершины 3(x):");
            string k5 = Console.ReadLine();
            int ve3_x = Convert.ToInt32(k5);
            Console.WriteLine("Координаты вершины 3(y):");
            string k6 = Console.ReadLine();
            int ve3_y = Convert.ToInt32(k6);
            Console.WriteLine("Координаты вершины 4(x):");
            string k7 = Console.ReadLine();
            int ve4_x = Convert.ToInt32(k7);
            Console.WriteLine("Координаты вершины 4(y):");
            string k8 = Console.ReadLine();
            int ve4_y = Convert.ToInt32(k8);
            double dist1 = Math.Sqrt((Math.Abs(ve2_x - ve1_x)) * (Math.Abs(ve2_x - ve1_x)) + (Math.Abs(ve2_y - ve1_y)) * (Math.Abs(ve2_y - ve1_y)));
            double dist2 = Math.Sqrt((Math.Abs(ve3_x - ve1_x)) * (Math.Abs(ve3_x - ve1_x)) + (Math.Abs(ve3_y - ve1_y)) * (Math.Abs(ve3_y - ve1_y)));
            double dist3 = Math.Sqrt((Math.Abs(ve3_x - ve2_x)) * (Math.Abs(ve3_x - ve2_x)) + (Math.Abs(ve3_y - ve2_y)) * (Math.Abs(ve3_y - ve2_y)));
            double dist4 = Math.Sqrt((Math.Abs(ve4_x - ve3_x)) * (Math.Abs(ve4_x - ve3_x)) + (Math.Abs(ve4_y - ve3_y)) * (Math.Abs(ve4_y - ve3_y)));
            double dist5 = Math.Sqrt((Math.Abs(ve4_x - ve1_x)) * (Math.Abs(ve4_x - ve1_x)) + (Math.Abs(ve4_y - ve1_y)) * (Math.Abs(ve4_y - ve1_y)));
            double p1 = (dist1 + dist2 + dist3) / 2;
            double p2 = (dist1 + dist4 + dist5) / 2;
            Console.WriteLine("Периметр четырёхугольника: " + (dist1 + dist2 + dist4 + dist5));
            Console.WriteLine("Площадь четырёхугольника: " + (Math.Sqrt(p1 * (p1 - dist1) * (p1 - dist2) * (p1 - dist3)) + Math.Sqrt(p2 * (p2 - dist3) * (p2 - dist4) * (p2 - dist5))));
            //s2.22
            Console.WriteLine("S2.22");
            Console.WriteLine("Цена за 1 кг конфет:");
            string pr1 = Console.ReadLine();
            int price1 = Convert.ToInt32(pr1);
            Console.WriteLine("Цена за 1 кг печенья:");
            string pr2 = Console.ReadLine();
            int price2 = Convert.ToInt32(pr2);
            Console.WriteLine("Цена за 1 кг яблок:");
            string pr3 = Console.ReadLine();
            int price3 = Convert.ToInt32(pr3);
            Console.WriteLine("Купили конфет (кг):");
            string bu1 = Console.ReadLine();
            int buy1 = Convert.ToInt32(bu1);
            Console.WriteLine("Купили печенья (кг):");
            string bu2 = Console.ReadLine();
            int buy2 = Convert.ToInt32(bu2);
            Console.WriteLine("Купили яблок (кг):");
            string bu3 = Console.ReadLine();
            int buy3 = Convert.ToInt32(bu3);
            Console.WriteLine("Общая стоимость покупки: " + (price1 * buy1 + price2 * buy2 + price3 * buy3));
            //S2.23
            Console.WriteLine("S2.23");
            Console.WriteLine("Стоимость монитора:");
            string pr4 = Console.ReadLine();
            int price4 = Convert.ToInt32(pr4);
            Console.WriteLine("Стоимость системного блока:");
            string pr5 = Console.ReadLine();
            int price5 = Convert.ToInt32(pr5);
            Console.WriteLine("Стоимость клавиатуры:");
            string pr6 = Console.ReadLine();
            int price6 = Convert.ToInt32(pr6);
            Console.WriteLine("Стоимость мыши:");
            string pr7 = Console.ReadLine();
            int price7 = Convert.ToInt32(pr7);
            Console.WriteLine("Цена 3 компьютеров: " + (3 * (price4 + price5 + price6 + price7)));
            Console.WriteLine("Количество компьютеров:");
            string n = Console.ReadLine();
            int number = Convert.ToInt32(n);
            Console.WriteLine("Стоимость " + number + " компютеров: " + (number * (price4 + price5 + price6 + price7)));
            //S2.24
            Console.WriteLine("S2.24");
            Console.WriteLine("Возраст Тани:");
            string age1 = Console.ReadLine();
            int age_1 = Convert.ToInt32(age1);
            Console.WriteLine("Возраст Мити:");
            string age2 = Console.ReadLine();
            int age_2 = Convert.ToInt32(age2);
            double average_age = (age_1 + age_2) / 2;
            Console.WriteLine("Средний возраст:" + average_age);
            Console.WriteLine("Разница от ср.з. Тани: " + Math.Abs(age_1 - average_age));
            Console.WriteLine("Разница от ср.з. Мити: " + Math.Abs(age_2 - average_age));
            //S2.25
            Console.WriteLine("S2.24");
            Console.WriteLine("Скорость 1 автомобиля:");
            string v1 = Console.ReadLine();
            int V1 = Convert.ToInt32(v1);
            Console.WriteLine("Скорость 2 автомобиля:");
            string v2 = Console.ReadLine();
            int V2 = Convert.ToInt32(v2);
            Console.WriteLine("Расстояние между автомобилями:");
            string s1 = Console.ReadLine();
            int S1 = Convert.ToInt32(s1);
            Console.WriteLine("Время через которое встретяться автомобили: " + (double)S1 / (V1 + V2));
            //S2.26
            Console.WriteLine("S2.26");
            Console.WriteLine("Скорость быстрейшего автомобиля:");
            string v3 = Console.ReadLine();
            int V3 = Convert.ToInt32(v3);
            Console.WriteLine("Скорость медлейшего автомобиля:");
            string v4 = Console.ReadLine();
            int V4 = Convert.ToInt32(v4);
            Console.WriteLine("Расстояние между ними через 30 минут: " + (V3 * 0.5 - V4 * 0.5));
            //S2.27
            Console.WriteLine("S2.27");
            Console.WriteLine("Значения температуры по Цельсию:");
            string t1 = Console.ReadLine();
            int temp = Convert.ToInt32(t1);
            Console.WriteLine("Значение температуры по Фаренгейту: " + (temp * 1.8 + 32));
            Console.WriteLine("Значение температуры по Кельвину: " + (temp + 273.15));
            //S2.28
            Console.WriteLine("S2.28");
            Console.WriteLine("Значение температуры по Фаренгейту: 450");
            Console.WriteLine("Значения температуры по Цельсию: " + (double)(450 - 32) / 1.8);
            //S3.1
            Console.WriteLine("S3.1");
            Console.WriteLine("Значение 1 переменной: ");
            string l1 = Console.ReadLine();
            int w1 = Convert.ToInt32(l1);
            Console.WriteLine("Значение 2 переменной: ");
            string l2 = Console.ReadLine();
            int w2 = Convert.ToInt32(l2);
            int turn = w1;
            w1 = w2;
            w2 = turn;
            Console.WriteLine("Значение 1 переменной: " + w1);
            Console.WriteLine("Значение 2 переменной: " + w2);
            //S3.2a
            Console.WriteLine("S3.2a");
            Console.WriteLine("Значение переменной a:");
            string u1 = Console.ReadLine();
            int a_1 = Convert.ToInt32(u1);
            Console.WriteLine("Значение переменной b:");
            string u2 = Console.ReadLine();
            int b_1 = Convert.ToInt32(u2);
            Console.WriteLine("Значение переменной c:");
            string u3 = Console.ReadLine();
            int c_1 = Convert.ToInt32(u3);
            b_1 = c_1;
            a_1 = b_1;
            c_1 = a_1;
            Console.WriteLine("Значение переменной a:" + a_1);
            Console.WriteLine("Значение переменной b:" + b_1);
            Console.WriteLine("Значение переменной c:" + c_1);
            //S3.2b
            Console.WriteLine("S3.2b");
            Console.WriteLine("Значение переменной a:");
            string u4 = Console.ReadLine();
            int a_2 = Convert.ToInt32(u4);
            Console.WriteLine("Значение переменной b:");
            string u5 = Console.ReadLine();
            int b_2 = Convert.ToInt32(u5);
            Console.WriteLine("Значение переменной c:");
            string u6 = Console.ReadLine();
            int c_2 = Convert.ToInt32(u6);
            b_2 = a_2;
            c_2 = b_2;
            a_2 = c_2;
            Console.WriteLine("Значение переменной a:" + a_1);
            Console.WriteLine("Значение переменной b:" + b_1);
            Console.WriteLine("Значение переменной c:" + c_1);
            //S3.3а
            Console.WriteLine("S3.3а");
            Console.WriteLine("Число a:");
            a = Convert.ToInt32(Console.ReadLine());
            a *= a;
            a *= a;
            Console.WriteLine("a^4: " + a);
            //S3.3б
            Console.WriteLine("S3.3б");
            Console.WriteLine("Число a:");
            a = Convert.ToInt32(Console.ReadLine());
            a *= a;
            double a_4 = a * a;
            double a_6 = a_4 * a;
            Console.WriteLine("a^6: " + a_6);
            //S3.3в
            Console.WriteLine("S3.3в");
            a = Convert.ToInt32(Console.ReadLine());
            double a_22 = a * a;
            double a_44 = a_22 * a_22;
            double a_66 = a_44 * a_22;
            double a_77 = a_66 * a;
            Console.WriteLine("a^7: " + a_77);
            //S3.3г
            Console.WriteLine("S3.3г");
            a = Convert.ToInt32(Console.ReadLine());
            double a__2 = a * a;
            double a__4 = a__2 * a__2;
            double a__8 = a__4 * a__4;
            Console.WriteLine("a^8: " + a__8);
            //S3.3д
            Console.WriteLine("S3.3д");
            a = Convert.ToInt32(Console.ReadLine());
            double b__2 = a * a;
            double b__4 = b__2 * b__2;
            double b__8 = b__4 * b__4;
            double b__9 = b__8 * a;
            Console.WriteLine("a^9: " + b__9);
            //S3.3е
            Console.WriteLine("S3.3е");
            a = Convert.ToInt32(Console.ReadLine());
            double c__2 = a * a;
            double c__4 = c__2 * c__2;
            double c__8 = c__4 * c__4;
            double c__10 = c__8 * c__2;
            Console.WriteLine("a^10: " + c__10);
            //S3.4а
            Console.WriteLine("S3.4а");
            a = Convert.ToInt32(Console.ReadLine());
            double d_2 = a * a;
            double d_3 = d_2 * a;
            double d_5 = d_3 * d_2;
            double d_10 = d_5 * d_5;
            Console.WriteLine("a^3: " + d_3);
            Console.WriteLine("a^10: " + d_10);
            //S3.4б
            Console.WriteLine("S3.4б");
            a = Convert.ToInt32(Console.ReadLine());
            double e_2 = a * a;
            double e_4 = e_2 * e_2;
            double e_8 = e_4 * e_4;
            double e_20 = e_8 * e_8 * e_4;
            Console.WriteLine("a^4: " + e_4);
            Console.WriteLine("a^20: " + e_20);
            //S3.4в
            Console.WriteLine("S3.4в");
            a = Convert.ToInt32(Console.ReadLine());
            double f_2 = a * a;
            double f_3 = f_2 * a;
            double f_5 = f_3 * f_2;
            double f_13 = f_5 * f_5 * f_3;
            Console.WriteLine("a^5: " + f_5);
            Console.WriteLine("a^13: " + f_13);
            //S3.4г
            Console.WriteLine("S3.4г");
            a = Convert.ToInt32(Console.ReadLine());
            double g_2 = a * a;
            double g_4 = g_2 * g_2;
            double g_5 = g_4 * a;
            double g_19 = g_5 * g_5 * g_5 * g_4;
            Console.WriteLine("a^5: " + g_5);
            Console.WriteLine("a^19: " + g_19);
            //S3.4д
            Console.WriteLine("S3.4д");
            a = Convert.ToInt32(Console.ReadLine());
            double h_2 = a * a;
            double h_3 = h_2 * a;
            double h_5 = h_3 * h_2;
            double h_17 = h_5 * h_5 * h_5 * h_2;
            Console.WriteLine("a^2: " + h_2);
            Console.WriteLine("a^5: " + h_5);
            Console.WriteLine("a^17: " + h_17);
            //S3.4е
            Console.WriteLine("S3.4е");
            a = Convert.ToInt32(Console.ReadLine());
            double i_2 = a * a;
            double i_4 = i_2 * i_2;
            double i_12 = i_4 * i_4 * i_4;
            double i_28 = i_12 * i_12 * i_4;
            Console.WriteLine("a^4: " + i_4);
            Console.WriteLine("a^12: " + i_12);
            Console.WriteLine("a^28: " + i_28);
            //S3.5
            Console.WriteLine("S3.5");
            double numb = 10;
            double numb2 = numb * numb;
            double numb4 = numb2 * numb2;
            double numb10 = numb4 * numb4 * numb2;
            Console.WriteLine(numb10);

        }
    }
}