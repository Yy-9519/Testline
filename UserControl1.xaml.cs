using LiveCharts.Wpf;
using LiveCharts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Testline
{
    /// <summary>
    /// UserControl1.xaml 的交互逻辑
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();

              List<byte> byteArray = new List<byte>();
              byteArray.Add(0x12);
              byteArray.Add(0x34);
              byteArray.Add(0x56);
              byteArray.Add(0x78);
              byteArray.Add(0xAB);
              byteArray.Add(0xCD);
              byteArray.Add(0xEF);
              byteArray.Add(0x01);
              byteArray.Add(0x23);
              byteArray.Add(0x45);
              byteArray.Add(0x25);
              byteArray.Add(0x33);
              byteArray.Add(0x7);
              byteArray.Add(0x88);
              byteArray.Add(0xAC);
              byteArray.Add(0xAD);
              byteArray.Add(0xEA);
              byteArray.Add(0x11);
              byteArray.Add(0x13);
              byteArray.Add(0x25);
            byteArray.Add(0xCD);
            byteArray.Add(0xEF);
            byteArray.Add(0x01);
            byteArray.Add(0x23);
            byteArray.Add(0x45);
            byteArray.Add(0x25);
            byteArray.Add(0x33);
            byteArray.Add(0x7);
            byteArray.Add(0x88);
            byteArray.Add(0xAC);
            byteArray.Add(0xAD);
            byteArray.Add(0xEA);
            byteArray.Add(0x11);
            byteArray.Add(0x13);
            byteArray.Add(0x25);
            byteArray.Add(0xCD);
            byteArray.Add(0xEF);
            byteArray.Add(0x01);
            byteArray.Add(0x23);
            byteArray.Add(0x45);
            byteArray.Add(0x25);
            byteArray.Add(0x33);
            byteArray.Add(0x7);
            byteArray.Add(0x88);
            byteArray.Add(0xAC);
            byteArray.Add(0xAD);
            byteArray.Add(0xEA);
            byteArray.Add(0x11);
            byteArray.Add(0x13);
            byteArray.Add(0x25);
            byteArray.Add(0xCD);
            byteArray.Add(0xEF);
            byteArray.Add(0x01);
            byteArray.Add(0x23);
            byteArray.Add(0x45);
            byteArray.Add(0x25);
            byteArray.Add(0x33);
            byteArray.Add(0x7);
            byteArray.Add(0x88);
            byteArray.Add(0xAC);
            byteArray.Add(0xAD);
            byteArray.Add(0xEA);
            byteArray.Add(0x11);
            byteArray.Add(0x13);
            byteArray.Add(0x25);
            byteArray.Add(0xCD);
            byteArray.Add(0xEF);
            byteArray.Add(0x01);
            byteArray.Add(0x23);
            byteArray.Add(0x45);
            byteArray.Add(0x25);
            byteArray.Add(0x33);
            byteArray.Add(0x7);
            byteArray.Add(0x88);
            byteArray.Add(0xAC);
            byteArray.Add(0xAD);
            byteArray.Add(0xEA);
            byteArray.Add(0x11);
            byteArray.Add(0x13);
            byteArray.Add(0x25);
            byteArray.Add(0xCD);
            byteArray.Add(0xEF);
            byteArray.Add(0x01);
            byteArray.Add(0x23);
            byteArray.Add(0x45);
            byteArray.Add(0x25);
            byteArray.Add(0x33);
            byteArray.Add(0x7);
            byteArray.Add(0x88);
            byteArray.Add(0xAC);
            byteArray.Add(0xAD);
            byteArray.Add(0xEA);
            byteArray.Add(0x11);
            byteArray.Add(0x13);
            byteArray.Add(0xCD);
            byteArray.Add(0xEF);
            byteArray.Add(0x01);
            byteArray.Add(0x23);
            byteArray.Add(0x45);
            byteArray.Add(0x25);
            byteArray.Add(0x33);
            byteArray.Add(0x7);
            byteArray.Add(0x88);
            byteArray.Add(0xAC);
            byteArray.Add(0xAD);
            byteArray.Add(0xEA);
            byteArray.Add(0x11);
            byteArray.Add(0x13);
            byteArray.Add(0x25);
            byteArray.Add(0xCD);
            byteArray.Add(0xEF);
            byteArray.Add(0x01);
            byteArray.Add(0x23);
            byteArray.Add(0x45);
            byteArray.Add(0x25);
            byteArray.Add(0x33);
            byteArray.Add(0x7);
            byteArray.Add(0x88);
            byteArray.Add(0xAC);
            byteArray.Add(0xAD);
            byteArray.Add(0xEA);
            byteArray.Add(0x11);
            byteArray.Add(0x13);
            byteArray.Add(0xCD);
            byteArray.Add(0xEF);
            byteArray.Add(0x01);
            byteArray.Add(0x23);
            byteArray.Add(0x45);
            byteArray.Add(0x25);
            byteArray.Add(0x33);
            byteArray.Add(0x7);
            byteArray.Add(0x88);
            byteArray.Add(0xAC);
            byteArray.Add(0xAD);
            byteArray.Add(0xEA);
            byteArray.Add(0x11);
            byteArray.Add(0x13);
            byteArray.Add(0xCD);
            byteArray.Add(0xEF);
            byteArray.Add(0x01);
            byteArray.Add(0x23);
            byteArray.Add(0x45);
            byteArray.Add(0x25);
            byteArray.Add(0x33);
            byteArray.Add(0x7);
            byteArray.Add(0x88);
            byteArray.Add(0xAC);
            byteArray.Add(0xAD);
            byteArray.Add(0xEA);
            byteArray.Add(0x11);
            byteArray.Add(0x13);
            byteArray.Add(0xCD);
            byteArray.Add(0xEF);
            byteArray.Add(0x01);
            byteArray.Add(0x23);
            byteArray.Add(0x45);
            byteArray.Add(0x25);
            byteArray.Add(0x33);
            byteArray.Add(0x7);
            byteArray.Add(0x88);
            byteArray.Add(0xAC);
            byteArray.Add(0xAD);
            byteArray.Add(0xEA);
            byteArray.Add(0x11);
            byteArray.Add(0x13);
            byteArray.Add(0xCD);
            byteArray.Add(0xEF);
            byteArray.Add(0x01);
            byteArray.Add(0x23);
            byteArray.Add(0x45);
            byteArray.Add(0x25);
            byteArray.Add(0x33);
            byteArray.Add(0x7);
            byteArray.Add(0x88);
            byteArray.Add(0xAC);
            byteArray.Add(0xAD);
            byteArray.Add(0xEA);
            byteArray.Add(0x11);
            byteArray.Add(0x13);
            byteArray.Add(0xCD);
            byteArray.Add(0xEF);
            byteArray.Add(0x01);
            byteArray.Add(0x23);
            byteArray.Add(0x45);
            byteArray.Add(0x25);
            byteArray.Add(0x33);
            byteArray.Add(0x7);
            byteArray.Add(0x88);
            byteArray.Add(0xAC);
            byteArray.Add(0xAD);
            byteArray.Add(0xEA);
            byteArray.Add(0x11);
            byteArray.Add(0x13);
            byteArray.Add(0x25);
            byteArray.Add(0x25);
            byteArray.Add(0x25);
            byteArray.Add(0x25);
            byteArray.Add(0x25);
            byteArray.Add(0x25);
            byteArray.Add(0x25);

            int[] intArray = new int[byteArray.Count / 2]; // 定义长度为byteArray.Length/2的int数组
            for (int i = 0; i < intArray.Length; i++)
            {
                int index = i * 2;
                int value = (byteArray[index] << 8) | (byteArray[index + 1] & 0xFF); // 通过位运算将两个byte类型的值转换为一个int类型的值
                intArray[i] = value;
            }

            SeriesCollection = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Series 1",
                    Values = new ChartValues<int> (intArray)
                },
            };
            //横坐标系数
            Labels = new string[intArray.Length];
            for (int i = 0; i < Labels.Length; i++)
            {
                Labels[i] = (i + 1).ToString();
            }
            YFormatter = new string[60000];
            for (int i = 0; i < YFormatter.Length; i++)
            {
                YFormatter[i] = (i + 1).ToString();
            }
            DataContext = this;
        }


        public SeriesCollection SeriesCollection { get; set; }
        public string[] Labels { get; set; }
        public string[] YFormatter { get; set; }

    }
}