// 18. Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y
bool x = false;
bool y = true;
bool f1 = !(x || y);
bool f2 = !x && !y;
Console.WriteLine(f1 == f2);
