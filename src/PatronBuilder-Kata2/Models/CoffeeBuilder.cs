using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronBuilder_Kata2.Models
{
	class CoffeeBuilder
	{
		private string _typeCoffe;
		private List<Milk> _milkList;
		private List<Sugar> _sugarList;

		public CoffeeBuilder() {
			this._milkList = new List<Milk>();
			this._sugarList = new List<Sugar>();
		}

		public CoffeeBuilder SetBlackCoffee() {
			this._typeCoffe = "Black";
			return this;
		}
		public CoffeeBuilder SetCubanoCoffee() {
			this._typeCoffe = "Cubano";
			return this; 
		}
		public CoffeeBuilder SetAntoccinoCoffee() {
			this._typeCoffe = "Americano";
			return this; 
		}

		public CoffeeBuilder WithMilk(double fat) {
			this._milkList.Add(new Milk(fat));
			return this; 
		}
		public CoffeeBuilder WithSugar(string sort) {
			this._sugarList.Add(new Sugar(sort));
			return this; 
		}

		public Coffee Build() { return new Coffee(this._typeCoffe, this._milkList, this._sugarList); }
	};
}
