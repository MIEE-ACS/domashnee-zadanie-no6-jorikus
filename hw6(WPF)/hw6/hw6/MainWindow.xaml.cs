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

namespace hw6
{
	abstract class Transport
	{
		public double s_speed;
		public string name;
		public int pas_count;

		abstract public double Fuel(double dist);
		abstract public double Time(double dist);

		public override string ToString()
        {
			return String.Format($"{s_speed},{name},{pas_count}");
        }
	}

	class Bicycle : Transport
	{
		public Bicycle(double speed, string name, int pas_c)
		{
			this.s_speed = speed;
			this.name = name;
			this.pas_count = pas_c;
		}
		public override double Fuel(double dist)
		{
			return 0;
		}
		public override double Time(double dist)
		{
			return dist / s_speed;
		}
	}

	class Car : Transport
	{
		public Car(double speed, string name, int pas_c)
		{
			this.s_speed = speed;
			this.name = name;
			this.pas_count = pas_c;
		}
		public override double Fuel(double dist)
		{
			return 0.075 * dist;
		}
		public override double Time(double dist)
		{
			return dist / s_speed;
		}
	}

	class Truck : Transport
	{
		public Truck(double speed, string name, int pas_c)
		{
			this.s_speed = speed;
			this.name = name;
			this.pas_count = pas_c;
		}
		public override double Fuel(double dist)
		{
			return 0.3 * dist;
		}
		public override double Time(double dist)
		{
			return dist / s_speed;
		}
	}
	public partial class MainWindow : Window
    {
		static bool CheckNumber(string s) //Функция для проверки строки на содержание символов(для преобразования в число)
		{
			foreach (char item in s) //Цикл для поочередного обращения к элементам строки
			{
				if (item != ',')
				{
					if (char.IsDigit(item) == false) // IsDigit функция определяет относится ли символ к категории чисел
					{
						return true;
					}
				}
			}
			return false;
		}
		public MainWindow()
        {
			InitializeComponent();
			comboBox_bicycle.Items.Add("");
			comboBox_car.Items.Add("");
			comboBox_truck.Items.Add("");
			button_bicycle.Visibility = Visibility.Hidden;
			button_car.Visibility = Visibility.Hidden;
			button_truck.Visibility = Visibility.Hidden;
			label1.Visibility = Visibility.Hidden;
			label2.Visibility = Visibility.Hidden;
			label3.Visibility = Visibility.Hidden;
			textBox1.Visibility = Visibility.Hidden;
			textBox2.Visibility = Visibility.Hidden;
			textBox3.Visibility = Visibility.Hidden;

			Bicycle bicycle = new Bicycle(30, "Stels", 1);
			Car car = new Car(70, "Ford", 5);
			Truck truck = new Truck(60, "Mercedes", 3);
			comboBox_bicycle.Items.Add(bicycle);
			comboBox_car.Items.Add(car);
			comboBox_truck.Items.Add(truck);
		}

        private void button1_Click(object sender, RoutedEventArgs e)
        {
			button_bicycle.Visibility = Visibility.Visible;
			button_car.Visibility = Visibility.Visible;
			button_truck.Visibility = Visibility.Visible;
			label1.Visibility = Visibility.Visible;
			label2.Visibility = Visibility.Visible;
			label3.Visibility = Visibility.Visible;
			textBox1.Visibility = Visibility.Visible;
			textBox2.Visibility = Visibility.Visible;
			textBox3.Visibility = Visibility.Visible;
		}

        private void button_bicycle_Click(object sender, RoutedEventArgs e)
        {
			if (CheckNumber(textBox1.Text) || (textBox1.Text == "") || CheckNumber(textBox3.Text) || (textBox3.Text == ""))
			{
				MessageBox.Show("Ошибка. Введите число");
			}
            else
            {
				double speed = double.Parse(textBox1.Text);
				string name = textBox2.Text;
				int pas_c = int.Parse(textBox3.Text);
				Bicycle bicycle = new Bicycle(speed, name, pas_c);
				comboBox_bicycle.Items.Add(bicycle);
				MessageBox.Show("Добавлено");
				textBox1.Text = "";
				textBox2.Text = "";
				textBox3.Text = "";
				button_bicycle.Visibility = Visibility.Hidden;
				button_car.Visibility = Visibility.Hidden;
				button_truck.Visibility = Visibility.Hidden;
				label1.Visibility = Visibility.Hidden;
				label2.Visibility = Visibility.Hidden;
				label3.Visibility = Visibility.Hidden;
				textBox1.Visibility = Visibility.Hidden;
				textBox2.Visibility = Visibility.Hidden;
				textBox3.Visibility = Visibility.Hidden;
			}
		}

        private void button_car_Click(object sender, RoutedEventArgs e)
        {
			if (CheckNumber(textBox1.Text) || (textBox1.Text == "") || CheckNumber(textBox3.Text) || (textBox3.Text == ""))
			{
				MessageBox.Show("Ошибка. Введите число");
			}
            else
            {
				double speed = double.Parse(textBox1.Text);
				string name = textBox2.Text;
				int pas_c = int.Parse(textBox3.Text);
				Car car = new Car(speed, name, pas_c);
				comboBox_car.Items.Add(car);
				MessageBox.Show("Добавлено");
				textBox1.Text = "";
				textBox2.Text = "";
				textBox3.Text = "";
				button_bicycle.Visibility = Visibility.Hidden;
				button_car.Visibility = Visibility.Hidden;
				button_truck.Visibility = Visibility.Hidden;
				label1.Visibility = Visibility.Hidden;
				label2.Visibility = Visibility.Hidden;
				label3.Visibility = Visibility.Hidden;
				textBox1.Visibility = Visibility.Hidden;
				textBox2.Visibility = Visibility.Hidden;
				textBox3.Visibility = Visibility.Hidden;
			}
		}

        private void button_truck_Click(object sender, RoutedEventArgs e)
        {
			if (CheckNumber(textBox1.Text) || (textBox1.Text == "") || CheckNumber(textBox3.Text) || (textBox3.Text == ""))
			{
				MessageBox.Show("Ошибка. Введите число");
			}
            else
            {
				double speed = double.Parse(textBox1.Text);
				string name = textBox2.Text;
				int pas_c = int.Parse(textBox3.Text);
				Truck truck = new Truck(speed, name, pas_c);
				comboBox_truck.Items.Add(truck);
				MessageBox.Show("Добавлено");
				textBox1.Text = "";
				textBox2.Text = "";
				textBox3.Text = "";
				button_bicycle.Visibility = Visibility.Hidden;
				button_car.Visibility = Visibility.Hidden;
				button_truck.Visibility = Visibility.Hidden;
				label1.Visibility = Visibility.Hidden;
				label2.Visibility = Visibility.Hidden;
				label3.Visibility = Visibility.Hidden;
				textBox1.Visibility = Visibility.Hidden;
				textBox2.Visibility = Visibility.Hidden;
				textBox3.Visibility = Visibility.Hidden;
			}
		}
        private void Button_Click(object sender, RoutedEventArgs e)
        {
			if (CheckNumber(textBox_dist.Text) || (textBox_dist.Text == ""))
            {
				MessageBox.Show("Ошибка. Введите число");
            }
            else
            {
				double dist = double.Parse(textBox_dist.Text);
				if (Convert.ToString(comboBox_bicycle.SelectedItem) != "")
				{
					string info = Convert.ToString(comboBox_bicycle.SelectedItem);
					Bicycle bicycle = new Bicycle(double.Parse(info.Split(',')[0]), info.Split(',')[1], int.Parse(info.Split(',')[0]));
					textBox_l.Text = Convert.ToString(Math.Round(bicycle.Fuel(dist), 3));
					textBox_t.Text = Convert.ToString(Math.Round(bicycle.Time(dist), 3));
				}
				else if (Convert.ToString(comboBox_car.SelectedItem) != "")
				{
					string info = Convert.ToString(comboBox_car.SelectedItem);
					Car car = new Car(double.Parse(info.Split(',')[0]), info.Split(',')[1], int.Parse(info.Split(',')[0]));
					textBox_l.Text = Convert.ToString(Math.Round(car.Fuel(dist), 3));
					textBox_t.Text = Convert.ToString(Math.Round(car.Time(dist), 3));
				}
				else if (Convert.ToString(comboBox_truck.SelectedItem) != "")
				{
					string info = Convert.ToString(comboBox_truck.SelectedItem);
					Truck truck = new Truck(double.Parse(info.Split(',')[0]), info.Split(',')[1], int.Parse(info.Split(',')[0]));
					textBox_l.Text = Convert.ToString(Math.Round(truck.Fuel(dist), 3));
					textBox_t.Text = Convert.ToString(Math.Round(truck.Time(dist), 3));
				}
				else
				{
					MessageBox.Show("Ошибка. Не выбран транспорт");
				}
			}
        }
    }
}
