﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StampLib.model
{
    public class Stamp
    {
        // スタンプのx軸, y軸方向のサイズ
        private short stamp_x_size;
        private short stamp_y_size;

        // スタンプの黒いセルの座標を格納する配列。
        private List<Tuple<short, short>> black_cell_coordinates;

        // スタンプを構成するオリジナルスタンプの情報を保持する3-tupeの配列。
        // 3-tupleのレイアウトは(index, x軸方向への平行移動距離, y軸方向の平行移動距離)。
        private List<Tuple<short, short, short>> indices;

        // スタンプのオブジェクトを格納するリスト
        private List<Tuple<short, short, short>> origin_stamp_list;

        /// <summary>
        /// 引数ありコンストラクタ
        /// </summary>
        /// <param name="idx">スタンプのインデックス</param>
        /// <param name="input_str">スタンプの定義（x軸方向サイズ；y 軸方向サイズ；絵の定義）</param>
        public Stamp(short idx, string input_str)
        {
            this.black_cell_coordinates = new List<Tuple<short, short>>();
            this.indices = new List<Tuple<short, short, short>>();
            origin_stamp_list = new List<Tuple<short, short, short>>();
            this.origin_stamp_list.Add(new Tuple<short, short, short>(idx, 0, 0));

            string[] input_stamp_information = input_str.Split(';');
            this.stamp_x_size = short.Parse(input_stamp_information[0]);
            this.stamp_y_size = short.Parse(input_stamp_information[1]);

            // black_cell_coordinatesの計算
            string stamp_info_str = input_stamp_information[2];
            short current_position = 0;
            for (short y = 0; y < stamp_y_size; y++)
            {
                for (short x = 0; x < stamp_x_size; x++)
                {
                    if (stamp_info_str[current_position] == '1')
                    {
                        this.black_cell_coordinates.Add(new Tuple<short, short>(y, x));
                    }
                    current_position++;
                }
            }
        }

        public List<Tuple<short, short>> GetBlackCellCoordinate()
        {
            return this.black_cell_coordinates;
        }

        public List<Tuple<short, short, short>> GetOriginStampList()
        {
            return this.origin_stamp_list;
        }
    }
}
