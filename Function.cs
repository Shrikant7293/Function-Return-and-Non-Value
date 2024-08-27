using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function_Return_and_Non_Value
{
	internal class Function
	{
		public int Id { get; set; }
        public string Name { get; set; }
        public int GrossIncome { get; set; }
        public int IncomeTax {  get; set; }
		public int NetIncome {  get; set; }

		// Non Returing Value
		public void GetData()
		{
			Console.WriteLine("Enter Id");
			Id = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Enter Name");
			Name = Console.ReadLine();

			Console.WriteLine("Enter GrossIncome");
			GrossIncome= Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Enter IncomeTax");
			IncomeTax= Convert.ToInt32(Console.ReadLine());

			NetIncome = CalculateNetIncome();
		}

		public void PutData()
		{
			Console.WriteLine("Id = " + Id);
			Console.WriteLine("Name = " + Name);
			Console.WriteLine("GrossIncome = " + GrossIncome);
			Console.WriteLine("IncomeTax = " + IncomeTax);
			Console.WriteLine("NetIncome = " + NetIncome);
		}


		// Returing Value
		public int CalculateNetIncome()
		{
			NetIncome = GrossIncome - IncomeTax;
			
			return NetIncome;
		}
	}
}
