using Aquarium;
using Aquarium.Enities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AquariumUI
{

	public partial class MainForm : Form
	{
		private static int _countFishs = 0;
		private static int _countAlgaes = 0;

		private List<Fish> _fishes = new();
		private List<Algae> _algaes = new();

		private readonly Random _random = new();

		private int _temperature;

		private event Action StatChanged;

		public MainForm()
		{
			_temperature = _random.Next(12, 18);
			StatChanged += GetStats;

			InitializeComponent();
		}

		private (string[], Color color) GetFishInformation(Fish fish)
		{
			StringBuilder information = new();

			information.AppendLine("Имя: " + fish.Name);
			information.AppendLine("Условия содержания:");
			information.AppendLine("  Температура: " + fish.Breed.HabitatConditions.Temperature);
			information.AppendLine("Питание: " + fish.Name);
			information.AppendLine("  Название: " + fish.Meal.Title);
			information.AppendLine("  Пищ. ценность: " + fish.Meal.Nutritional);
			information.AppendLine("Вид: " + fish.Variety.Title);

			return (information.ToString().Split('\n', StringSplitOptions.RemoveEmptyEntries), fish.Variety.Color);
		}

		private (string[], Color color) GetAlgaeInformation(Algae algae)
		{
			StringBuilder information = new();

			information.AppendLine("Навзание: " + algae.Name);
			information.AppendLine("Вид: " + algae.Variety.Title);
			information.AppendLine("Время роста: " + algae.TimeGrow);
			string statGrow = algae.IsGrowUp ? "Вырос" : "Растет";
			information.AppendLine("Состояние: " + statGrow);

			return (information.ToString().Split('\n', StringSplitOptions.RemoveEmptyEntries), algae.Variety.Color);
		}

		private void RemoveItemFromListBox<T>(ListBox listBox, List<T> items)
		{
			if (listBox.SelectedIndex == -1)
			{
				return;
			}

			T selectedItem = items[listBox.SelectedIndex];

			items.Remove(selectedItem);
			listBox.Items.Remove(selectedItem);
		}

		private void ShowInformation<T>(ListBox listBox, List<T> items, Func<T, (string[], Color)> getInforamation)
		{
			if (listBox.SelectedIndex == -1)
			{
				return;
			}

			T selectedItem = items[listBox.SelectedIndex];

			lstInformation.Items.Clear();

			(string[] text, Color color) inforamation = getInforamation(selectedItem);

			foreach (var line in inforamation.text)
			{
				lstInformation.Items.Add(line);
			}

			pbColour.BackColor = inforamation.color;
		}

		private float GetLevelOxygen(List<Algae> algaes)
		{
			return algaes.Sum(x => x.CountOxygen);
		}

		private void GetStats()
		{
			StringBuilder information = new();
			information.AppendLine("Кол-во рыбок: " + _fishes.Count);
			information.AppendLine("Кол-во водрослей: " + _algaes.Count);
			float levelOxygen = GetLevelOxygen(_algaes);
			information.AppendLine("Уровень кислорода: " + levelOxygen);
			information.AppendLine("Температура: " + _temperature);


			var stats = information.ToString().Split('\n', StringSplitOptions.RemoveEmptyEntries);

			lstStats.Invoke(new MethodInvoker(() => 
			{
				lstStats.Items.Clear();
				foreach (var stat in stats)
				{
					lstStats.Items.Add(stat);
				}

				ShowInformation(lstAlgaes, _algaes, GetAlgaeInformation);
			}));

		}

		private void btnAddFish_Click(object sender, EventArgs e)
		{
			var fish = new Fish()
			{
				Name = "Рыбка" + (++_countFishs).ToString(),
				Breed = new()
				{
					HabitatConditions = new()
					{
						Temperature = _random.Next(1, 16)
					}
				},
				Meal = new()
				{
					Title = "Пища" + _random.Next(1, 4),
					Nutritional = _random.Next(10, 50)
				},
				Variety = new()
				{
					Title = "Вид" + _random.Next(1, 10),
					Color = Color.FromArgb(_random.Next(0, 255), _random.Next(0, 255), _random.Next(0, 255))
				}
			};

			_fishes.Add(fish);
			lstFishes.Items.Add(fish);
			StatChanged?.Invoke();
		}

		private void btnDeleteFish_Click(object sender, EventArgs e)
		{
			RemoveItemFromListBox(lstFishes, _fishes);
			StatChanged?.Invoke();
		}

		private void lstFishes_SelectedIndexChanged(object sender, EventArgs e)
		{
			ShowInformation(lstFishes, _fishes, GetFishInformation);
		}

		private void btnAddAlgae_Click(object sender, EventArgs e)
		{
			var algae = new Algae(
				"Вдросоль" + (++_countAlgaes).ToString(),
				_random.Next(3, 15),
				new()
				{
					Title = "Вид" + _random.Next(1, 10),
					Color = Color.FromArgb(_random.Next(0, 100), _random.Next(0, 255), _random.Next(0, 10))
				});

			algae.Growed += GetStats;

			_algaes.Add(algae);
			lstAlgaes.Items.Add(algae);
			StatChanged?.Invoke();
		}

		private void btnDeleteAlgae_Click(object sender, EventArgs e)
		{
			RemoveItemFromListBox(lstAlgaes, _algaes);
			StatChanged?.Invoke();
		}

		private void lstAlgaes_SelectedIndexChanged(object sender, EventArgs e)
		{
			ShowInformation(lstAlgaes, _algaes, GetAlgaeInformation);
		}
	}
}
