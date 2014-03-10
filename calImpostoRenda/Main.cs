using System;

namespace calImpostoRenda
{
	/*
	Faça um programa que calcule o imposto de renda mensal de uma
	pessoa sem dependentes para o ano que vem. Para isso informe
	apenas o seu salário bruto e quanto ele contribui para o INSS.

	A cálculo do imposto de renda deve ser a seguinte:
	BASE_DE_CÁLCULO= SALÁRIO BRUTO – PAGO AO INSS
	IMPOSTO_MENSAL = BASE_DE_CÁLCULO * ALIQUOTA
	*/
	public class Imposto
	{
		double base_calc {get; set;}

		public double Calcular(double sal, double inss)
		{
			this.base_calc = sal - inss;

			if (base_calc <= 1710.78) {
				return base_calc;
			}
			else if (base_calc < 2563.91) {
				return base_calc * 0.075;
			} 
			else if (base_calc < 3418.59) {
				return base_calc * 0.15;
			} 
			else if (base_calc < 4271.59) {
				return base_calc * 0.225;
			} 
			else
				return base_calc * 0.275;

		
		}

		public Imposto() {
			base_calc = 0;
		}
	}

	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("||||||||||||||||||||||||||||||||||||||||||");
			Console.WriteLine("Cálculo Imposto de Renda     >||||||||||||");
			Console.WriteLine("Informe o salário bruto");
			double salario_bruto = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Informe o valor pago de INSS");
			double pago_inss = Convert.ToDouble(Console.ReadLine());

			Imposto myImp = new Imposto();

			double mensal = myImp.Calcular(salario_bruto, pago_inss);

			Console.WriteLine("Imposto de renda mensal é de: " + mensal);
		}
	}
}