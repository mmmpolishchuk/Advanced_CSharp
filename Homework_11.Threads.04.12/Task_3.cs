using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Homework_11.Threads._04._12
{
    //    Создайте новый поток с помощью Thread, поместите в него метод который будет вычислять число Фибоначчи n-го порядка
    //    (в зависимости от входящего аргумента). Саму реализацию вычисления числа Фибоначчи можете загуглить.
    //    Запустите метод одновременно в двух потоках и выведите результаты выполнения в основном потоке.

    public static class FibonachiClass
    {
        public static int Fibonachi(int n)
        {
            return n > 1 ? Fibonachi(n - 1) + Fibonachi(n - 2) : n;
        }
    }
}
