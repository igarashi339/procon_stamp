﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experiment
{
    class Program
    {
        static void Main(string[] args)
        {
            const short field_x_size = 100;
            const short field_y_size = 100;

            Stamp stamp = new Stamp(Shape.heart);
            Field field = new Field(field_x_size, field_y_size);

            System.Random r = new System.Random(1000);
            for (short count = 0; count < 100; ++count)
            {
                short slide_x = (short)r.Next(stamp.x_size * (-1), field_x_size);
                short slide_y = (short)r.Next(stamp.y_size * (-1), field_y_size);
                field.PressStamp(stamp, slide_x, slide_y);


                // 区切り線の出力
                Console.WriteLine("\n\n\n\n\n");
                for (short i = 0; i < field_x_size; ++i)
                {
                    Console.Write(" >");
                }
                Console.WriteLine("\n\n\n\n\n");

                field.PrshortMyField();
            }
        }
    }

    class Shape
    {
        // 星形
        public static string star = "64;64;0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000111000000000000000000000000000000000000000000000000000000000000111110000000000000000000000000000000000000000000000000000000000011111000000000000000000000000000000000000000000000000000000000001111100000000000000000000000000000000000000000000000000000000001111111000000000000000000000000000000000000000000000000000000000111111100000000000000000000000000000000000000000000000000000000011111110000000000000000000000000000000000000000000000000000000011111111100000000000000000000000000000000000000000000000000000001111111110000000000000000000000000000000000000000000000000000000111111111000000000000000000000000000000000000000000000000000000111111111110000000000000000000000000000000000000000000000000000011111111111000000000000000000000000000000000000000000000000000001111111111100000000000000000000000000000000000000000000000000001111111111111000000000000000000000000000000000000000000000000000111111111111100000000000000000000000000000000000000000000000000011111111111110000000000000000000000000000000000000000000000000011111111111111100000000000000000000000000000000000000000000000001111111111111110000000000000000000000000000000000000000000000000111111111111111000000000000000000000000000001111111111111111111111111111111111111111111111111111111000000001111111111111111111111111111111111111111111111111111111110000000111111111111111111111111111111111111111111111111111111111000000011111111111111111111111111111111111111111111111111111111100000000111111111111111111111111111111111111111111111111111111100000000001111111111111111111111111111111111111111111111111111100000000000001111111111111111111111111111111111111111111111111000000000000000011111111111111111111111111111111111111111111111000000000000000000111111111111111111111111111111111111111111111000000000000000000000111111111111111111111111111111111111111110000000000000000000000001111111111111111111111111111111111111110000000000000000000000000001111111111111111111111111111111111110000000000000000000000000000011111111111111111111111111111111100000000000000000000000000000000111111111111111111111111111111100000000000000000000000000000000000111111111111111111111111111000000000000000000000000000000000000011111111111111111111111111100000000000000000000000000000000000001111111111111111111111111110000000000000000000000000000000000001111111111111111111111111111100000000000000000000000000000000000111111111111111111111111111110000000000000000000000000000000000011111111111111111111111111111000000000000000000000000000000000011111111111111111111111111111110000000000000000000000000000000001111111111111111111111111111111000000000000000000000000000000000111111111111111111111111111111100000000000000000000000000000000011111111111111111111111111111110000000000000000000000000000000011111111111111111111111111111111100000000000000000000000000000001111111111111110001111111111111110000000000000000000000000000000111111111111110000011111111111111000000000000000000000000000000111111111111100000000011111111111110000000000000000000000000000011111111111100000000000111111111111000000000000000000000000000001111111111000000000000000111111111100000000000000000000000000001111111111000000000000000001111111111000000000000000000000000000111111110000000000000000000001111111100000000000000000000000000011111110000000000000000000000011111110000000000000000000000000001111100000000000000000000000000011111000000000000000000000000000011100000000000000000000000000000111000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000";

        // 縦14,横10の正方形
        public static string rect = "27;20;000000000000000000000000000000000000000000000000000000000000011111111110000000000000000011111111110000000000000000011111111110000000000000000011111111110000000000000000011111111110000000000000000011111111110000000000000000011111111110000000000000000011111111110000000000000000011111111110000000000000000011111111110000000000000000011111111110000000000000000011111111110000000000000000011111111110000000000000000011111111110000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000";

        // ハート
        public static string heart = "64;64;0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000001111000000000000000000000000001111000000000000000000000000001111111111110000000000000000001111111111110000000000000000000011111111111111110000000000000011111111111111110000000000000000011111111111111111110000000000011111111111111111100000000000000011111111111111111111100000000111111111111111111111000000000000011111111111111111111111000000111111111111111111111110000000000011111111111111111111111110000111111111111111111111111100000000011111111111111111111111111100111111111111111111111111111000000001111111111111111111111111110011111111111111111111111111100000000111111111111111111111111111111111111111111111111111111111000000111111111111111111111111111111111111111111111111111111111100000011111111111111111111111111111111111111111111111111111111110000001111111111111111111111111111111111111111111111111111111111000001111111111111111111111111111111111111111111111111111111111110000111111111111111111111111111111111111111111111111111111111111000011111111111111111111111111111111111111111111111111111111111100001111111111111111111111111111111111111111111111111111111111110000111111111111111111111111111111111111111111111111111111111111000011111111111111111111111111111111111111111111111111111111111100001111111111111111111111111111111111111111111111111111111111110000011111111111111111111111111111111111111111111111111111111110000001111111111111111111111111111111111111111111111111111111111000000111111111111111111111111111111111111111111111111111111111100000011111111111111111111111111111111111111111111111111111111110000000111111111111111111111111111111111111111111111111111111110000000011111111111111111111111111111111111111111111111111111111000000001111111111111111111111111111111111111111111111111111111100000000011111111111111111111111111111111111111111111111111111100000000001111111111111111111111111111111111111111111111111111110000000000011111111111111111111111111111111111111111111111111110000000000001111111111111111111111111111111111111111111111111111000000000000011111111111111111111111111111111111111111111111111000000000000000111111111111111111111111111111111111111111111111000000000000000011111111111111111111111111111111111111111111111100000000000000000111111111111111111111111111111111111111111111100000000000000000001111111111111111111111111111111111111111111100000000000000000000111111111111111111111111111111111111111111110000000000000000000001111111111111111111111111111111111111111110000000000000000000000011111111111111111111111111111111111111110000000000000000000000000111111111111111111111111111111111111110000000000000000000000000001111111111111111111111111111111111110000000000000000000000000000011111111111111111111111111111111110000000000000000000000000000000111111111111111111111111111111110000000000000000000000000000000001111111111111111111111111111110000000000000000000000000000000000001111111111111111111111111100000000000000000000000000000000000000011111111111111111111111100000000000000000000000000000000000000000111111111111111111111100000000000000000000000000000000000000000000111111111111111111000000000000000000000000000000000000000000000000111111111111110000000000000000000000000000000000000000000000000001111111111110000000000000000000000000000000000000000000000000000001111111100000000000000000000000000000000000000000000000000000000001111000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000";
    }

    class Field
    {
        private bool[,] my_filed;
        private short x_size;
        private short y_size;

        public Field(short x_size, short y_size)
        {
            this.x_size = x_size;
            this.y_size = y_size;
            this.my_filed = new bool[y_size, x_size];
            for (short y_ind = 0; y_ind < y_size; ++y_ind)
            {
                for (short x_ind = 0; x_ind < x_size; ++x_ind)
                {
                    this.my_filed[y_ind, x_ind] = false;
                }
            }
        }

        // stamp をスライドしてからを my field に押す
        public void PressStamp(Stamp stamp, short x_slide, short y_slide)
        {
            foreach (Tuple<short, short> coordinate in stamp.GetBlackCellCoordinates())
            {
                short y = (short)(y_slide + coordinate.Item1);
                short x = (short)(x_slide + coordinate.Item2);

                // スタンプを押す場所が my field の外なら continue
                if (y < 0 || y >= this.y_size || x < 0 || x >= this.x_size)
                {
                    continue;
                }

                this.my_filed[y, x] = !my_filed[y, x];
            }
        }

        // my fieldを標準出力に表示する
        public void PrshortMyField()
        {
            for (short y_ind = 0; y_ind < y_size; ++y_ind)
            {
                for (short x_ind = 0; x_ind < x_size; ++x_ind)
                {
                    if (this.my_filed[y_ind, x_ind])
                    {
                        Console.Write(" *");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
        }

        public short GetBlackCellNum()
        {
            short count = 0;
            for (short y_ind = 0; y_ind < this.y_size; ++y_ind)
            {
                for (short x_ind = 0; x_ind < this.x_size; ++x_ind)
                {
                    if (this.my_filed[y_ind, x_ind]) count++;
                }
            }

            return count;
        }
    }

    class Stamp
    {
        private List<Tuple<short, short>> black_cell_coordinates;
        public short x_size;
        public short y_size;

        public Stamp(string input_str)
        {
            string[] input_array = input_str.Split(';');
            this.x_size = short.Parse(input_array[0]);
            this.y_size = short.Parse(input_array[1]);

            this.black_cell_coordinates = new List<Tuple<short, short>>();
            short input_array_idx = 0;
            for (short y_idx = 0; y_idx < this.y_size; ++y_idx)
            {
                for (short x_idx = 0; x_idx < this.x_size; ++x_idx)
                {
                    if (input_array[2][input_array_idx++] == '1')
                    {
                        this.black_cell_coordinates.Add(new Tuple<short, short>(y_idx, x_idx));
                    }
                }
            }

        }

        public List<Tuple<short, short>> GetBlackCellCoordinates()
        {
            return this.black_cell_coordinates;
        }
    }
}