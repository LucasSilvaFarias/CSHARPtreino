//----------------------------------------------------//
	using System;
						
	public class nota{
		public double n1;
		public double n2;
		public double n3;
		public double n4;
	}
	public double notas(nota nota1, nota nota2, nota nota3, nota nota4){
		double media = (nota1.n1 + nota2.n2 + nota3.n3 + nota4.n4) / 4;
		double round = Math.Round(media,1);
		return round;
	}

	nota n1 = new nota();
		n1.n1 = 4;
	nota n2 = new nota();
		n2.n2 = 10;
	nota n3 = new nota();
		n3.n3 = 5.7;
	nota n4 = new nota();
		n4.n4 = 3;

	double x = notas(n1, n2, n3, n4);
//----------------------------------------------------//
	using System;
	public class medidas{
		public double alt;
		public double bas;
	}

	public double retangulo (medidas altura, medidas basee){
		double area = altura.alt * basee.bas;
		return area;
	}

	medidas altura = new medidas();
		altura.alt = 20;
	medidas basee = new medidas();
		basee.bas = 2;

	double x = retangulo(altura, basee);
//----------------------------------------------------//
	using System;
	public class medidas{
		public double alt;
		public double bas;
	}

	public bool triangulo (medidas altura1, medidas basee1, medidas altura2, medidas basee2){
		double ar1 = (altura1.alt * basee1.bas) / 2;
		double ar2 = (altura2.alt * basee2.bas) / 2;
		bool ig = ar1 == ar2;
		return ig;
	}


	medidas altura1 = new medidas();
		altura1.alt = 20;
	medidas basee1 = new medidas();
		basee1.bas = 2;

	medidas altura2 = new medidas();
		altura2.alt = 2;
	medidas basee2 = new medidas();
		basee2.bas = 23;


	bool x = triangulo(altura1, basee1, altura2, basee2);
//----------------------------------------------------//
		using System;
	public class precos{
		public double acp;
		public double acm;
		public double acg;
	}

	public double acai (precos p, precos m, precos g){
		double total = (p.acp * 10.00) + (m.acm * 12.00) + (g.acg * 14.00);
		return total;
	}

	precos pequeno = new precos();
		pequeno.acp = 5;

	precos medio = new precos();
		medio.acm = 3;

	precos grande = new precos();
		grande.acg = 0;

	double r = acai(pequeno, medio, grande);
//----------------------------------------------------//
	using System;
	public class compra{
		public double preco;
		public int parcelas;
	}

	public double veiculo(compra preco, compra parc){
		double veic =  preco.preco * parc.parcelas * 5 / 100;
		return veic;
	}

	compra pre = new compra();
		pre.preco = 132451;
	compra par = new compra();
		par.parcelas = 4;

	double x = veiculo(pre, par);
//----------------------------------------------------//
	using System;
	public class info{
		public string nome;
		public string cep;
	}


	public string contem (info nome, info cep){
		int cp = cep.cep.Length;
		bool x = cep.cep.Contains("-") && cp == 9;
		return (nome.nome + ", a validação do seu cep deu " + x + ".");
	}

	info nm = new info();
		nm.nome = "Lucas da Silva Farias";
	info cp = new info();
		cp.cep = "04763-200";

	string x = contem(nm, cp);
//----------------------------------------------------//
	using System;
	public class nome
	{
		public string nomecompleto;
	}
	public string sobrenome (string nome)
	{
		string buscar = nome.Substring(nome.LastIndexOf(" "));
		string espaco = buscar.Trim();
		return espaco;
	}
	public bool msm (nome p1, nome p2, nome p3)
	{
		string a = sobrenome(p1.nomecompleto);
		string b = sobrenome(p2.nomecompleto);
		string c = sobrenome(p3.nomecompleto);
		bool igual = a == b && a == c;
		return igual;
	}
	nome p1 = new nome();
	p1.nomecompleto = Console.ReadLine();
	nome p2 = new nome();
	p2.nomecompleto = Console.ReadLine();
	nome p3 = new nome();
	p3.nomecompleto = Console.ReadLine();

	bool x = msm(p1, p2, p3);
 //---------------------------------------------------//
	using System;	
	public class equacao
	{
		public double a;
		public double b;
		public double c;
	}
	public class resultado
	{
		public double xp;
		public double xn;
	}

	public double delta (equacao eq)
	{
		double x = Math.Pow(eq.b, 2) - 4 * eq.a * eq.c;
		return x;
	}
	public resultado resposta (equacao eq)
	{
		double x1 = (-eq.b + Math.Sqrt(delta(eq))) /2 * eq.a;
		double x2 = (-eq.b - Math.Sqrt(delta(eq))) /2 * eq.a;
		resultado x = new resultado();
		x.xp = x1;
		x.xn = x2;
		return x;
	}

	equacao valor = new equacao();
	valor.a = 1;
	valor.b = -1;
	valor.c = -12;

	resultado r = resposta(valor);
	Console.WriteLine("valor de x1 é " + r.xp + ", e o valor de x2 é " + r.xn + ".");
 //---------------------------------------------------//
	using System;

	public class casal
	{
		public DateTime ps1;
		public DateTime ps2;
	}

	public bool maior (DateTime data)
	{
		DateTime x = DateTime.Now;
		DateTime y = new DateTime(x.Year - 18, x.Month, x.Day);
		bool z = y >= data;
		return z;
	}

	public bool libra (DateTime data) 
	{
		DateTime x = new DateTime(data.Year,09,23);
		DateTime y = new DateTime(data.Year,10,22);
		bool z = data >= x && data <= y;
		return z;
	}

	public bool entrada (casal ps) 
	{
		bool x = libra(ps.ps1) && maior(ps.ps1);
		bool y = libra(ps.ps2) && maior(ps.ps2);
		return x && y;
	}

	casal datas = new casal();
	datas.ps1 = new DateTime(2000,09,30);
	datas.ps2 = new DateTime(1998,10,20);


	bool x = entrada(datas);
//---------------------------------------------------------------------------------------//
using System;
public class tr{
	public double disi;
	public double disv;
}

public double gasolina (tr ida1, tr volta1, tr ida2, tr volta2, double consumo)
{
	double normal = ida1.disi + volta1.disv;
	double rodizio = ida2.disi + volta2.disv;
	double total_per = normal + rodizio;
	double consumo_carro = total_per  / consumo;
	double total_litro = consumo_carro * 20;
	double total = total_litro * 2.60;
	return total;
}

tr ida1 = new tr();
	ida1.disi = 10;
tr volta1 = new tr();
	volta1.disv = 12;
tr ida2 = new tr();
	ida2.disi = 15;
tr volta2 = new tr();
	volta2.disv= 16;

double gasto = gasolina (ida1, volta1, ida2, volta2, 10);