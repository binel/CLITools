using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pomodoro
{
    public class DigitPlotter
    {
        private Display _display;

        private char[,] _zero = new char[7, 5]
        {
            { '#', '#', '#', '#', '#' },
            { '#', ' ', ' ', ' ', '#' },
            { '#', ' ', ' ', ' ', '#' },
            { '#', ' ', ' ', ' ', '#' },
            { '#', ' ', ' ', ' ', '#' },
            { '#', ' ', ' ', ' ', '#' },
            { '#', '#', '#', '#', '#' },
        };

        private char[,] _one = new char[7, 5]
        {
            { ' ', ' ', '#', ' ', ' ' },
            { ' ', '#', '#', ' ', ' ' },
            { ' ', ' ', '#', ' ', ' ' },
            { ' ', ' ', '#', ' ', ' ' },
            { ' ', ' ', '#', ' ', ' ' },
            { ' ', ' ', '#', ' ', ' ' },
            { '#', '#', '#', '#', '#' },
        };

        private char[,] _two = new char[7, 5]
        {
            { '#', '#', '#', '#', '#' },
            { ' ', ' ', ' ', ' ', '#' },
            { ' ', ' ', ' ', ' ', '#' },
            { '#', '#', '#', '#', '#' },
            { '#', ' ', ' ', ' ', ' ' },
            { '#', ' ', ' ', ' ', ' ' },
            { '#', '#', '#', '#', '#' },
        };

        private char[,] _three = new char[7, 5]
        {
            { '#', '#', '#', '#', '#' },
            { ' ', ' ', ' ', ' ', '#' },
            { ' ', ' ', ' ', ' ', '#' },
            { '#', '#', '#', '#', '#' },
            { ' ', ' ', ' ', ' ', '#' },
            { ' ', ' ', ' ', ' ', '#' },
            { '#', '#', '#', '#', '#' },
        };

        private char[,] _four = new char[7, 5]
        {
            { '#', ' ', ' ', ' ', '#' },
            { '#', ' ', ' ', ' ', '#' },
            { '#', ' ', ' ', ' ', '#' },
            { '#', '#', '#', '#', '#' },
            { ' ', ' ', ' ', ' ', '#' },
            { ' ', ' ', ' ', ' ', '#' },
            { ' ', ' ', ' ', ' ', '#' },
        };

        private char[,] _five = new char[7, 5]
        {
            { '#', '#', '#', '#', '#' },
            { '#', ' ', ' ', ' ', ' ' },
            { '#', ' ', ' ', ' ', ' ' },
            { '#', '#', '#', '#', '#' },
            { ' ', ' ', ' ', ' ', '#' },
            { ' ', ' ', ' ', ' ', '#' },
            { '#', '#', '#', '#', '#' },
        };

        private char[,] _six = new char[7, 5]
        {
            { '#', '#', '#', '#', '#' },
            { '#', ' ', ' ', ' ', ' ' },
            { '#', ' ', ' ', ' ', ' ' },
            { '#', '#', '#', '#', '#' },
            { '#', ' ', ' ', ' ', '#' },
            { '#', ' ', ' ', ' ', '#' },
            { '#', '#', '#', '#', '#' },
        };

        private char[,] _seven = new char[7, 5]
        {
            { '#', '#', '#', '#', '#' },
            { ' ', ' ', ' ', ' ', '#' },
            { ' ', ' ', ' ', ' ', '#' },
            { ' ', ' ', ' ', '#', ' ' },
            { ' ', ' ', '#', ' ', ' ' },
            { ' ', '#', ' ', ' ', ' ' },
            { '#', ' ', ' ', ' ', ' ' },
        };

        private char[,] _eight = new char[7, 5]
        {
            { '#', '#', '#', '#', '#' },
            { '#', ' ', ' ', ' ', '#' },
            { '#', ' ', ' ', ' ', '#' },
            { '#', '#', '#', '#', '#' },
            { '#', ' ', ' ', ' ', '#' },
            { '#', ' ', ' ', ' ', '#' },
            { '#', '#', '#', '#', '#' },
        };

        private char[,] _nine = new char[7, 5]
        {
            { '#', '#', '#', '#', '#' },
            { '#', ' ', ' ', ' ', '#' },
            { '#', ' ', ' ', ' ', '#' },
            { '#', '#', '#', '#', '#' },
            { ' ', ' ', ' ', ' ', '#' },
            { ' ', ' ', ' ', ' ', '#' },
            { ' ', ' ', ' ', ' ', '#' },
        };

        private char[,] _colon = new char[7, 3]
        {
            { ' ', ' ', ' ' },
            { ' ', '#', ' ' },
            { ' ', '#', ' ' },
            { ' ', ' ', ' ' },
            { ' ', '#', ' ' },
            { ' ', '#', ' ' },
            { ' ', ' ', ' ' }
        };


        public DigitPlotter()
        {
            _display = new Display();
        }

        public void PlotTime(int[] nums)
        {
            if (nums.Length != 4)
            {
                throw new ArgumentOutOfRangeException("Can only plot a time with 4 numbers");
            }
            _display.Clear();
            SetDigit(nums[0], 0);
            SetDigit(nums[1], 6);
            PlotColon(11);
            SetDigit(nums[2], 14);
            SetDigit(nums[3], 20);
            Plot();
        }

        public void SetDigit(int num, int xOffset)
        {
            char[,] digit;
            switch(num)
            {
                case 0:
                    digit = _zero;
                    break;
                case 1:
                    digit = _one;
                    break;
                case 2:
                    digit = _two;
                    break;
                case 3:
                    digit = _three;
                    break;
                case 4:
                    digit = _four;
                    break;
                case 5:
                    digit = _five;
                    break;
                case 6:
                    digit = _six;
                    break;
                case 7:
                    digit = _seven;
                    break;
                case 8:
                    digit = _eight;
                    break;
                case 9:
                    digit = _nine;
                    break;
                default:
                    throw new ArgumentOutOfRangeException($"{num} not valid, must be between 0-9");
            }

            for (int y = 0; y < 7; y++)
            {
                for (int x = xOffset; x < 5 + xOffset; x++)
                {
                    _display.SetChar(x, y, digit[y, x - xOffset]);
                }
            }
        }

        public void PlotColon(int xOffset)
        {
            for (int y = 0; y < 7; y++)
            {
                for (int x = xOffset; x < 3 + xOffset; x++)
                {
                    _display.SetChar(x, y, _colon[y, x - xOffset]);
                }
            }
        }

        public void Plot()
        {
            _display.Draw();
        }
    }
}
