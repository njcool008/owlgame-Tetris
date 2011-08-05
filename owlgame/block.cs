using System;
using System.Drawing;
using System.Collections.Generic;
using System.Text;

namespace owlgame
{
    class block
    {
        public block(int x,int y) 
        {
            curx = x;
            cury = y;
            colorblock = boxcolors[rander.Next(3)];
            int no = rander.Next(No);
            for (int i = 0; i < size; ++i)
                for (int j = 0; j < size; ++j)
                    matblock[i, j] = blockbox[no, i, j];
        }
        
        public int[,] matblock = new int[size, size];         // ���Ӿ���
        public Color colorblock;
        public int curx,cury;                                 // ���ӵ����
        public static int size = 5;                           // ���Ӿ����ά��
        private const int No = 7;                             // ���ӵ�����        
        private Random rander = new Random();                 // ���ѡ����
        private static Color[] boxcolors ={                   // Ԥ���������ɫ
            Color.Red,Color.Yellow,Color.Blue
        }; 
        private static int[,,] blockbox ={                     // Ԥ����ĺ���
            {
                {0,0,0,0,0},
                {0,0,0,0,0},
                {1,1,1,1,0},
                {0,0,0,0,0},
                {0,0,0,0,0}
            },
            
            {
                {0,0,0,0,0},
                {0,0,1,0,0},
                {0,1,1,1,0},
                {0,0,0,0,0},
                {0,0,0,0,0}
            },
            
            {
                {0,0,0,0,0},
                {0,1,1,0,0},
                {0,0,1,1,0},
                {0,0,0,0,0},
                {0,0,0,0,0}
            },
            
            {
                {0,0,0,0,0},
                {0,0,1,1,0},
                {0,1,1,0,0},
                {0,0,0,0,0},
                {0,0,0,0,0}
            },
            
            {
                {0,0,0,0,0},
                {0,1,1,0,0},
                {0,0,1,0,0},
                {0,0,1,0,0},
                {0,0,0,0,0}
            },
            
            {
                {0,0,0,0,0},
                {0,0,1,1,0},
                {0,0,1,0,0},
                {0,0,1,0,0},
                {0,0,0,0,0}
            },
            
            {
                {0,0,0,0,0},
                {0,0,1,1,0},
                {0,0,1,1,0},
                {0,0,0,0,0},
                {0,0,0,0,0}
            }
         };
    }
}
