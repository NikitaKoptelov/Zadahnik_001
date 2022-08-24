// 
// Написать программу масштабирования фигуры
// ```
// Тут для тех кто далеко улетел, чтобы задавались вершины фигуры списком (одной строкой)
// например: "(0,0) (2,0) (2,2) (0,2)"
// коэффициент масштабирования k задавался отдельно - 2 или 4 или 0.5
// В результате показать координаты, которые получатся.
// при k = 2 получаем "(0,0) (4,0) (4,4) (0,4)"
// ```
// 


Console.Clear();



void Print (int mnog)
{
    int[] goriz = {0, 2, 2, 0};
    int[] vertik = {0, 0, 2, 2};
    
    for (int i = 0; i < 4; i++)
    {
        Console.SetCursorPosition((goriz[i]) * mnog, (vertik[i]) * mnog);
        Console.WriteLine("+");
        
    }
}



Print(1);
Console.Write("введите коэффицент увеличения - ");
int mnog = Convert.ToInt32(Console.ReadLine());
Console.Clear();
Print(mnog);

