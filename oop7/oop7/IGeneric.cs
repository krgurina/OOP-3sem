using System;
using System.Collections.Generic;

namespace oop7
{
    //Создайте обобщенный интерфейс с операциями добавить, удалить, просмотреть.

    public interface IGeneric<T>//where T:
    {
        void Add(T element);
        public void Delete(T deleteEl);
        void Show();
    }
}