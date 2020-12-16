using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsElectrovozs
{
    public class Depo<T, D> where T : class, ITransport where D : class, InterDop
    {
        // Массив объектов, которые храним
        private readonly List<T> _places;
        // Максимальное кол-во мест в депо
        private readonly int _maxCount;
        // Ширина окна отрисовки
        private readonly int pictureWidth;
        // Высота окна отрисовки
        private readonly int pictureHeight;
        // Размер депо (ширина)
        private readonly int _placeSizeWidth = 200;
        // Размер депо (высота)
        private readonly int _placeSizeHeight = 80;
        // Конструктор
        public Depo(int picWidth, int picHeight)
        {
            int width = picWidth / _placeSizeWidth;
            int height = picHeight / _placeSizeHeight;
            _maxCount = width * height;
            _places = new List<T>();
            pictureWidth = picWidth;
            pictureHeight = picHeight;
        }
        // Перегрузка оператора сложения
        // Логика действия: в депо добавляется поезд
        public static bool operator +(Depo<T, D> p, T train)
        {
            if (p._places.Count >= p._maxCount)
            {
                return false;
            }
            p._places.Add(train);
            return true;
        }
        public static bool operator ==(Depo<T, D> d, int ind)
        {
            return (d.CompareHelper() == ind);
        }
        public static bool operator !=(Depo<T, D> d, int ind)
        {
            return (d.CompareHelper() != ind);
        }
        private int CompareHelper()
        {
            int cnt = 0;
            for (int i = 0; i < _places.Count; ++i)
            {
                if (_places[i] == null)
                {
                    cnt++;
                }
            }
            return cnt;
        }
        // Перегрузка оператора вычитания
        // Логика действия: из депо забираем поезд
        public static T operator -(Depo<T, D> p, int index)
        {
            if (index < -1 || index >= p._places.Count)
            {
                return null;
            }
            T train = p._places[index];
            p._places.RemoveAt(index);
            return train;
        }
        // Метод отрисовки депо
        public void Draw(Graphics g)
        {
            DrawMarking(g);
            for (int i = 0; i < _places.Count; i++)
            {
                _places[i].SetPosition(i / 4 * _placeSizeWidth + 7, i % 4 *
                    _placeSizeHeight + 4, pictureWidth, pictureHeight);
                _places[i]?.DrawTransport(g);
            }
        }
        // Метод отрисовки разметки парковочных мест
        private void DrawMarking(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);
            for (int i = 0; i < pictureWidth / _placeSizeWidth; i++)
            {
                for (int j = 0; j < pictureHeight / _placeSizeHeight + 1; ++j)
                {//линия рамзетки места
                    g.DrawLine(pen, i * _placeSizeWidth, j * _placeSizeHeight, i *
                   _placeSizeWidth + _placeSizeWidth / 2, j * _placeSizeHeight);
                }
                g.DrawLine(pen, i * _placeSizeWidth, 0, i * _placeSizeWidth,
               (pictureHeight / _placeSizeHeight) * _placeSizeHeight);
            }
        }
        public T this[int ind]
        {
            get
            {
                if (ind > -1 && ind < _maxCount)
                {
                    return _places[ind];
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
