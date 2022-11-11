using System;
using System.Collections.Generic;

namespace oop7
{
    //1) Создайте обобщенный интерфейс с операциями добавить, удалить, просмотреть.

    public interface IGeneric<T>//where T:PrintedEdiction
    {
        void Add(T element);
        public void Delete(T deleteEl);
        void Show();
    }
}