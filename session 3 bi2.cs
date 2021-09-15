using System;
					
public class Trignometria
{
	
	public double AreaRetangulo(double baze, double altura)
	{
		//double Area = baze * altura;
		return baze * altura;
	}
	
	public double PerimetroRetangulo(double baze, double altura)
	{
		//double Per = (baze * 2) + (altura * 2);
		return (baze * 2) + (altura * 2);
	}
	
	public bool RetangulosIguais(double baze1, double altura1, double baze2, double altura2)
	{
		//bool Igual = (baze1 * altura1) == (baze2 * altura2);
		return (baze1 * altura1) == (baze2 * altura2);
	}
	
}

Trignometria trignometria = new Trignometria();
double ArRet  = trignometria.AreaRetangulo(10, 5);
double PerRet =	trignometria.PerimetroRetangulo(10, 5);
bool   IgRet  = trignometria.RetangulosIguais(10, 5, 5, 10);

//=====================================================================================================================

public class Forma
{
	public double Baze   {get; set; }
	public double Altura {get; set; }
}

public class Trigonometria2
{

	public double AreaRetangulo2(Forma Medidas)
	{
		//double Ar = Medidas.Altura * Medidas.Baze;
		return Medidas.Altura * Medidas.Baze;
	}
	
	public double AreaTriangulo(Forma Medidas)
	{
		//double Ar = (Medidas.Altura * Medidas.Baze) / 2;
		return (Medidas.Altura * Medidas.Baze) / 2;
	}
	
	public double AreaParalelogramo(Forma Medidas)
	{
		//double Ar = Medidas.Altura * Medidas.Baze;
		return Medidas.Altura * Medidas.Baze;
	}
	
}

Forma forma = new Forma();
forma.Altura = 5;
forma.Baze = 10;

Trigonometria2 trignometria2 = new Trigonometria2();
double ArRet2 = trignometria2.AreaRetangulo2(forma);
double ArTri = trignometria2.AreaTriangulo(forma);
double ArPar = trignometria2.AreaParalelogramo(forma);

//=====================================================================================================================

public class Pessoa
{
	public string 	Nome   {get; set; }
	public DateTime Niver  {get; set; }
}

public class Calendario
{

	public DateTime PrimeiroDia(DateTime Data)
	{
		//DateTime primeiroDia = Data.AddDays(-Data.Day).AddDays(1);
		return Data.AddDays(-Data.Day).AddDays(1);
	}
	
	public DateTime UltimoDia(DateTime Data)
	{
		//DateTime ultimodia = Data.AddMonths(1).AddDays(-Data.Day);
		return Data.AddMonths(1).AddDays(-Data.Day);
	}
	
	public bool Dias(DateTime Data)
	{
		//DateTime ultimodia = Data.AddMonths(1).AddDays(-Data.Day);
		//bool dias = ultimodia.Day == 31;
		return Data.AddMonths(1).AddDays(-Data.Day).Day == 31;
	}
	
	public bool Sexta(DateTime Data)
	{
		return Data.DayOfWeek == DayOfWeek.Friday && Data.Day == 13;
	}
	
	public string SemanasProNiver(Pessoa Info)
	{
		//TimeSpan Subtracao = Info.Niver - DateTime.Now;
		//double Semanas = Subtracao.TotalDays / 7;
		//double Arredondar = Math.Floor(Semanas);
		return ($"{Info.Nome}, faltam {Math.Floor((Info.Niver - DateTime.Now).TotalDays / 7)} semanas para seu niver.");
	}
	
	public bool Libra(Pessoa Info)
	{
		return Info.Niver.Month == 9 && Info.Niver.Day >= 22 || Info.Niver.Month == 9 && Info.Niver.Day <= 23;
	}
	
}

Pessoa Informacao = new Pessoa();
Informacao.Niver = new DateTime(2022,01,29);
Informacao.Nome = "Lucas da Silva Farias";

DateTime data = new DateTime(2022, 08, 13);

Calendario cal = new Calendario();

DateTime PrimeiroDia = cal.PrimeiroDia(data);
DateTime UltimoDia 	 = cal.UltimoDia(data);
bool 	 Trinta1dias = cal.Dias(data);
bool 	 Sextafeira  = cal.Sexta(data);
string 	 Semanas 	 = cal.SemanasProNiver(Informacao);
bool 	 Libra 	 	 = cal.Libra(Informacao);

//=====================================================================================================================

public class Registro
{

	public bool ValidarCadastro(string email, string senha)
	{
		string recorte = email.Substring(email.IndexOf('@'));
		bool recorte1 = recorte.Substring(0,recorte.IndexOf(".")).Length >= 3;
		
		bool recorte2 = email.Substring(0,email.IndexOf('@')).Length >= 2;
			
		
		bool caracterespecial = senha.Contains("!") ||
								senha.Contains("@") ||
								senha.Contains("#") ||
								senha.Contains("%") ||
								senha.Contains("$");
		bool tamanhoSenha = senha.Length >= 8 && 
								senha.ToUpper().Contains("A") ||
								senha.ToUpper().Contains("E") ||
								senha.ToUpper().Contains("I") ||
								senha.ToUpper().Contains("O") ||
								senha.ToUpper().Contains("U");
		
		
		bool fim = recorte1 == true && recorte2 == true && email.Contains("@") && tamanhoSenha == true && caracterespecial == true;
		
		return fim;
	}
	
	public bool ValidarDominio (string email)
	{
		string inicio = email.Substring(0,1);
		bool ContemNumero =   inicio.Contains("0")||
							  inicio.Contains("1")||
							  inicio.Contains("2")||
							  inicio.Contains("3")||
							  inicio.Contains("4")||
							  inicio.Contains("5")||
							  inicio.Contains("6")||
							  inicio.Contains("7")||
							  inicio.Contains("8")||
							  inicio.Contains("9");

		string dominio = email.Substring(0,email.IndexOf(".com.br"));

		return email.EndsWith(".com.br") && ContemNumero == false && dominio.Length >= 6;
	}
	
}

Registro reg = new Registro();
string email = "mi.ohta5@gmail.com";
string senha = "aeiou@12345678";
string dom 	 = "gmail.com.br";

bool cadastro = reg.ValidarCadastro(email, senha);
bool dominio  = reg.ValidarDominio(dom);

//=============================================================================================

public class Retangulo
{
	public double altura{get; set;}
	public double basee	{get; set;}
}
public class Cilindro
{
	public double raio	{get; set;}
	public double altura{get; set;}
}

public class Trignometria2
{
	public double AreasRet (Retangulo ret)
	{
		return ret.basee * ret.altura;
	}
	public bool AreasIguais(Retangulo ret1, Retangulo ret2)
	{
		return AreasRet(ret1) == AreasRet(ret2);
	}
	
	public double VolumeCilindro(Cilindro cili)
	{
		return Math.PI * Math.Pow(cili.raio, 2) * cili.altura;
	}
	public bool Transeferencia(Cilindro cili1, Cilindro cili2)
	{
		return VolumeCilindro(cili1) >= VolumeCilindro(cili2);
	}
	
}

Trignometria2 trig2  	= new Trignometria2();

Retangulo retangulo1 	= new Retangulo();
	retangulo1.basee 	= 5.7;
	retangulo1.altura	= 9;

Retangulo retangulo2	= new Retangulo();
	retangulo2.basee 	= 9;
	retangulo2.altura	= 5.7;


Cilindro cilindro1 	 	= new Cilindro();
	cilindro1.raio		= 4;
	cilindro1.altura	= 5;

Cilindro cilindro2		= new Cilindro();
	cilindro2.raio		= 3;
	cilindro2.altura	= 4;

bool retangulosIguais 	= trig2.AreasIguais(retangulo1, retangulo2);
bool transferenciaCili	= trig2.Transeferencia(cilindro1, cilindro2);

//=============================================================================================

public class Roupas
{
	public int Qtdcalca		{get; set;}
	public int Qtdcamisa	{get; set;}
	public int Qtdblusa		{get; set;}
	public int Qtdcalcado	{get; set;}
}

public class Brecho
{

	private double Tmasculino(Roupas masc)
	{
		return (masc.Qtdblusa + masc.Qtdcalca + masc.Qtdcamisa) * 30.00;	
	}
	
	private double Tfeminino(Roupas fem)
	{
		return (fem.Qtdblusa + fem.Qtdcalca + fem.Qtdcamisa) * 40.00;	
	}

	private double Tinfantil(Roupas inf)
	{
		return (inf.Qtdblusa + inf.Qtdcalca + inf.Qtdcamisa) * 20.00;	
	}
	
	private double Tcalcado(int Qtdcalcmasc, int Qtdcalfem, int Qtdcalinf)
	{
		return (Qtdcalcmasc + Qtdcalfem + Qtdcalinf) * 35;
	} 
	
	public double TotalCompras(Roupas masc, Roupas fem, Roupas inf)
	{
		//double um = Tmasculino(masc);
		//double dois = Tfeminino(fem);
		//double tres = Tinfantil(inf);
		//double quatro = Tcalcado(masc.Qtdcalcado, fem.Qtdcalcado, inf.Qtdcalcado);
		//double cinco = um + dois + tres + quatro;
		return Tmasculino(masc) + Tfeminino(fem) + Tinfantil(inf) + Tcalcado(masc.Qtdcalcado, fem.Qtdcalcado, inf.Qtdcalcado);
	}
	
}

Brecho brecho = new Brecho();

Roupas CompraM = new Roupas();
	CompraM.Qtdcalca 	= 2;
	CompraM.Qtdcalcado 	= 1;
	CompraM.Qtdcamisa	= 2;
	CompraM.Qtdblusa 	= 1;

Roupas CompraF = new Roupas();
	CompraF.Qtdcalca 	= 13;
	CompraF.Qtdcalcado 	= 9;
	CompraF.Qtdcamisa 	= 20;
	CompraF.Qtdblusa 	= 10;

Roupas CompraI = new Roupas();
	CompraI.Qtdcalca 	= 3;
	CompraI.Qtdcalcado 	= 3;
	CompraI.Qtdcamisa	= 4;
	CompraI.Qtdblusa 	= 2;

double CompraBrecho = brecho.TotalCompras(CompraM, CompraF, CompraI);

//=============================================================================================

//=============================================================================================

Console.WriteLine("-------Exercício1-------");
Console.WriteLine($"AreaRetangulo = {ArRet}");
Console.WriteLine($"PerimetroRetangulo = {PerRet}");
Console.WriteLine($"RetangulosIguais = {IgRet}");
Console.WriteLine();

Console.WriteLine("-------Exercício2-------");
Console.WriteLine($"AreaRetangulo2 = {ArRet2}");
Console.WriteLine($"Area = {ArTri}");
Console.WriteLine($"AreaParalelogramo = {ArPar}");
Console.WriteLine();

Console.WriteLine("-------Exercício3-------");
Console.WriteLine($"PrimeiroDia = {PrimeiroDia}");
Console.WriteLine($"UltimoDia = {UltimoDia}");
Console.WriteLine($"UltimoDia = {Trinta1dias}");
Console.WriteLine($"UltimoDia = {Sextafeira}");
Console.WriteLine($"UltimoDia = {Semanas}");
Console.WriteLine($"UltimoDia = {Libra}");
Console.WriteLine();

Console.WriteLine("-------Exercício4-------");
Console.WriteLine($"ValidarCadastro = {cadastro}");
Console.WriteLine($"ValidarDominio = {dominio}");
Console.WriteLine();

Console.WriteLine("-------Exercício5-------");
Console.WriteLine($"AreasIguais = {retangulosIguais}");
Console.WriteLine($"TransferenciaPossivel = {transferenciaCili}");
Console.WriteLine();

Console.WriteLine("-------Exercício6-------");
Console.WriteLine($"ComprasBrechô = {CompraBrecho}");
Console.WriteLine();

Console.WriteLine("-------Exercício7-------");